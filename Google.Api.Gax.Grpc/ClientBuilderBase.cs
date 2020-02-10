﻿/*
 * Copyright 2019 Google LLC
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Api.Gax.Grpc
{
    /// <summary>
    /// Base class for API-specific builders.
    /// </summary>
    /// <typeparam name="TClient">The type of client created by this builder.</typeparam>
    /// <typeparam name="TEmulatorConfiguration">The type of the emulator configuration used by this builder.</typeparam>
    /// <typeparam name="TSelf">The type of the class given value to <typeparamref name="TSelf"/></typeparam>
    public abstract class ClientBuilderBase<TClient, TEmulatorConfiguration, TSelf>
        where TEmulatorConfiguration : EmulatorConfiguration
        where TSelf : ClientBuilderBase<TClient, TEmulatorConfiguration, TSelf>
    {
        private static readonly GrpcChannelOptions s_defaultOptions = GrpcChannelOptions.Empty
            .WithKeepAliveTime(TimeSpan.FromMinutes(1))
            .WithEnableServiceConfigResolution(false);

        /// <summary>
        /// The endpoint to connect to, or null to use the default endpoint.
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The scopes to use, or null to use the default scopes.
        /// </summary>
        public IReadOnlyList<string> Scopes { get; set; }

        /// <summary>
        /// The channel credentials to use, or null if credentials are being provided in a different way.
        /// </summary>
        public ChannelCredentials ChannelCredentials { get; set; }

        /// <summary>
        /// The path to the credentials file to use, or null if credentials are being provided in a different way.
        /// </summary>
        public string CredentialsPath { get; set; }

        /// <summary>
        /// The credentials to use as a JSON string, or null if credentials are being provided in a different way.
        /// </summary>
        public string JsonCredentials { get; set; }

        /// <summary>
        /// The token access method to use, or null if credentials are being provided in a different way.
        /// </summary>
        /// <remarks>
        /// <para>
        /// To use a GoogleCredential for credentials, set this property using a method group conversion, e.g.
        /// <c>TokenAccessMethod = credential.GetAccessTokenForRequestAsync</c>
        /// </para>
        /// </remarks>
        public Func<string, CancellationToken, Task<string>> TokenAccessMethod { get; set; }

        /// <summary>
        /// The call invoker to use, or null to create the call invoker when the client is built.
        /// </summary>
        public CallInvoker CallInvoker { get; set; }

        /// <summary>
        /// A custom user agent to specify in the channel metadata, or null if no custom user agent is required.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// The gRPC implementation to use, or null to use the default channel factory.
        /// </summary>
        internal GrpcImplementation GrpcImplementation { get; set; }

        /// <summary>
        /// The EmulatorDetector to use, or null if this client does not have emulator support.
        /// </summary>
        /// <remarks>In clients that do have emulator support this propety should be made public
        /// and shoule be assigned a value other than null.</remarks>
        internal protected EmulatorDetector<TEmulatorConfiguration> EmulatorDetector { get; }

        // Note: when adding any more properties, CopyCommonSettings must also be updated.

        /// <summary>
        /// Creates a new instance with no settings.
        /// </summary>
        protected ClientBuilderBase()
        {
        }

        /// <summary>
        /// Creates a new instance with the given emulator detector.
        /// </summary>
        /// <param name="emulatorDetector">The emulator detector to use in this instance.</param>
        protected ClientBuilderBase(EmulatorDetector<TEmulatorConfiguration> emulatorDetector) =>
            EmulatorDetector = emulatorDetector;

        /// <summary>
        /// Returns a shallow copy of this client builder, but replacing the relevant settings
        /// with those from the <paramref name="emulatorConfiguration"/>.
        /// This method should clear settings that, althoug not specified on the <paramref name="emulatorConfiguration"/>
        /// might conflict with some that are.
        /// </summary>
        /// <param name="emulatorConfiguration">The emulator configuration to apply.
        /// Must not be null and must be a valid emulator configuration.</param>
        /// <returns>A shallow copy of this client builder with the <paramref name="emulatorConfiguration"/> applied.</returns>
        protected virtual TSelf WithEmulatorConfiguration(TEmulatorConfiguration emulatorConfiguration)
        {
            GaxPreconditions.CheckArgument(emulatorConfiguration?.IsValid ?? false, nameof(emulatorConfiguration), "The emulator configuration should be non-null and valid.");

            var withEmulator = (TSelf) MemberwiseClone();

            // Let's clean up all conflicting settings on the clone.
            withEmulator.CallInvoker = null;
            withEmulator.CredentialsPath = null;
            withEmulator.JsonCredentials = null;
            withEmulator.Scopes = null;
            withEmulator.TokenAccessMethod = null;

            // Override with the emulator configuration.
            withEmulator.Endpoint = emulatorConfiguration.Endpoint;
            withEmulator.ChannelCredentials = ChannelCredentials.Insecure;

            return withEmulator;
        }

        /// <summary>
        /// Copies common settings from the specified builder into this one. This is a shallow copy.
        /// </summary>
        /// <typeparam name="TOtherClient">The other client type</typeparam>
        /// <typeparam name="TOtherEmulatorConfig">The other client emulator configuration type.</typeparam>
        /// <typeparam name="TOtherSelf">The other client builder type.</typeparam>
        /// <param name="source">The builder to copy from.</param>
        protected void CopyCommonSettings<TOtherClient, TOtherEmulatorConfig, TOtherSelf>(ClientBuilderBase<TOtherClient, TOtherEmulatorConfig, TOtherSelf> source)
            where TOtherEmulatorConfig : EmulatorConfiguration
            where TOtherSelf : ClientBuilderBase<TOtherClient, TOtherEmulatorConfig, TOtherSelf>
        {
            GaxPreconditions.CheckNotNull(source, nameof(source));
            Endpoint = source.Endpoint;
            Scopes = source.Scopes;
            ChannelCredentials = source.ChannelCredentials;
            CredentialsPath = source.CredentialsPath;
            JsonCredentials = source.JsonCredentials;
            TokenAccessMethod = source.TokenAccessMethod;
            CallInvoker = source.CallInvoker;
            UserAgent = source.UserAgent;
        }

        /// <summary>
        /// Validates that the builder is in a consistent state for building. For example, it's invalid to call
        /// <see cref="Build"/> on an instance which has both JSON credentials and a credentials path specified.
        /// </summary>
        /// <exception cref="InvalidOperationException">The builder is in an invalid state.</exception>
        protected virtual void Validate()
        {
            // If there's a call invoker, we shouldn't have any credentials-related information or an endpoint.
            ValidateOptionExcludesOthers("CallInvoker cannot be specified with credentials settings or an endpoint", CallInvoker,
                ChannelCredentials, CredentialsPath, JsonCredentials, Scopes, Endpoint, TokenAccessMethod);

            ValidateAtMostOneNotNull("Only one source of credentials can be specified",
                ChannelCredentials, CredentialsPath, JsonCredentials, TokenAccessMethod);

            ValidateOptionExcludesOthers("Scopes are not relevant when a token access method or channel credentials are supplied", Scopes,
                TokenAccessMethod, ChannelCredentials);
        }

        /// <summary>
        /// Validates that at most one of the given values is not null.
        /// </summary>
        /// <param name="message">The message if the condition is violated.</param>
        /// <param name="values">The values to check for nullity.</param>
        /// <exception cref="InvalidOperationException">More than one value is null.</exception>
        protected void ValidateAtMostOneNotNull(string message, params object[] values)
        {
            int notNull = values.Count(v => v != null);
            GaxPreconditions.CheckState(notNull < 2, message);
        }

        /// <summary>
        /// Validates that if <paramref name="controlling"/> is not null, then every value in <paramref name="values"/> is null.
        /// </summary>
        /// <param name="message">The message if the condition is violated.</param>
        /// <param name="controlling">The value controlling whether or not any other value can be non-null.</param>
        /// <param name="values">The values checked for non-nullity if <paramref name="controlling"/> is non-null.</param>
        protected void ValidateOptionExcludesOthers(string message, object controlling, params object[] values)
        {
            GaxPreconditions.CheckState(controlling == null || values.All(v => v == null), message);
        }

        /// <summary>
        /// Creates a call invoker synchronously. Override this method in a concrete builder type if more
        /// call invoker mechanisms are supported.
        /// This implementation calls <see cref="GetChannelCredentials"/> if no call invoker is specified.
        /// </summary>
        protected virtual CallInvoker CreateCallInvoker()
        {
            if (CallInvoker != null)
            {
                return CallInvoker;
            }
            var endpoint = Endpoint ?? GetDefaultEndpoint();
            ChannelBase channel;
            if (CanUseChannelPool)
            {
                channel = GetChannelPool().GetChannel(endpoint, GetChannelOptions());
            }
            else
            {
                var credentials = GetChannelCredentials();
                channel = CreateChannel(endpoint, credentials);
            }
            return channel.CreateCallInvoker();
        }

        /// <summary>
        /// Creates a call invoker asynchronously. Override this method in a concrete builder type if more
        /// call invoker mechanisms are supported.
        /// This implementation calls <see cref="GetChannelCredentialsAsync(CancellationToken)"/> if no call
        /// invoker is specified.
        /// </summary>
        protected virtual async Task<CallInvoker> CreateCallInvokerAsync(CancellationToken cancellationToken)
        {
            if (CallInvoker != null)
            {
                return CallInvoker;
            }
            var endpoint = Endpoint ?? GetDefaultEndpoint();
            ChannelBase channel;
            if (CanUseChannelPool)
            {
                channel = await GetChannelPool().GetChannelAsync(endpoint, GetChannelOptions()).ConfigureAwait(false);
            }
            else
            {
                var credentials = await GetChannelCredentialsAsync(cancellationToken).ConfigureAwait(false);
                channel = CreateChannel(endpoint, credentials);
            }
            return channel.CreateCallInvoker();
        }

        /// <summary>
        /// Obtains channel credentials synchronously. Override this method in a concrete builder type if more
        /// credential mechanisms are supported.
        /// </summary>
        protected virtual ChannelCredentials GetChannelCredentials()
        {
            if (ChannelCredentials != null)
            {
                return ChannelCredentials;
            }
            if (TokenAccessMethod != null)
            {
                return new DelegatedTokenAccess(TokenAccessMethod).ToChannelCredentials();
            }
            GoogleCredential unscoped =
                CredentialsPath != null ? GoogleCredential.FromFile(CredentialsPath) :
                JsonCredentials != null ? GoogleCredential.FromJson(JsonCredentials) :
                GoogleCredential.GetApplicationDefault();
            return unscoped.CreateScoped(Scopes ?? GetDefaultScopes()).ToChannelCredentials();
        }

        /// <summary>
        /// Obtains channel credentials asynchronously. Override this method in a concrete builder type if more
        /// credential mechanisms are supported.
        /// </summary>
        protected async virtual Task<ChannelCredentials> GetChannelCredentialsAsync(CancellationToken cancellationToken)
        {
            if (ChannelCredentials != null)
            {
                return ChannelCredentials;
            }
            if (TokenAccessMethod != null)
            {
                return new DelegatedTokenAccess(TokenAccessMethod).ToChannelCredentials();
            }
            GoogleCredential unscoped =
                CredentialsPath != null ? GoogleCredential.FromFile(CredentialsPath) : // TODO: Use an async method when one is available
                JsonCredentials != null ? GoogleCredential.FromJson(JsonCredentials) :
                await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            return unscoped.CreateScoped(Scopes ?? GetDefaultScopes()).ToChannelCredentials();
        }

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected abstract IReadOnlyList<string> GetDefaultScopes();

        /// <summary>
        /// Returns the endpoint for this builder type, used if no endpoint is otherwise specified.
        /// </summary>
        protected abstract string GetDefaultEndpoint();

        /// <summary>
        /// Returns the channel pool to use when no other options are specified. This method is not called unless
        /// <see cref="CanUseChannelPool"/> returns true, so if a channel pool is unavailable, override that property
        /// to return false and throw an exception from this method.
        /// </summary>
        protected abstract ChannelPool GetChannelPool();

        /// <summary>
        /// Returns the options to use when creating a channel.
        /// </summary>
        /// <returns>The options to use when creating a channel.</returns>
        protected virtual GrpcChannelOptions GetChannelOptions() =>
            UserAgent == null
            ? s_defaultOptions
            : s_defaultOptions.WithPrimaryUserAgent(UserAgent);

        /// <summary>
        /// Returns whether or not a channel pool can be used if a channel is required. The default behavior is to return
        /// true if and only if no scopes, credentials or token access method have been specified. Derived classes should
        /// override this property if there are other reasons why the channel pool should not be used.
        /// </summary>
        protected virtual bool CanUseChannelPool =>
            ChannelCredentials == null &&
            CredentialsPath == null &&
            JsonCredentials == null &&
            TokenAccessMethod == null &&
            Scopes == null;

        /// <summary>
        /// Builds the resulting client.
        /// </summary>
        /// <remarks>
        /// This method validates that the client builder settings are not conflicting.
        /// If the client supports an emulator this method will attempt to detect an emulator
        /// configuration and use that configuration to create the client. This client builder settings
        /// won't change as a result of using an emulator configuration.
        /// Validation is done for non-emulator settings so that configuration of the client builder
        /// is not dependent on wheter an emulator configuration is detected or not.
        /// </remarks>
        // TODO: This virtual as well?
        public TClient Build()
        {
            Validate();
            if (EmulatorDetector != null && EmulatorDetector.TryDetectEmulator(out TEmulatorConfiguration config))
            {
                return WithEmulatorConfiguration(config).BuildImpl();
            }
            return BuildImpl();
        }

        /// <summary>
        /// Builds the resulting client.
        /// </summary>
        /// <remarks>
        /// This method validates that the client builder settings are not conflicting.
        /// If the client supports an emulator this method will attempt to detect an emulator
        /// configuration and use that configuration to create the client. This client builder settings
        /// won't change as a result of using an emulator configuration.
        /// Validation is done for non-emulator settings so that configuration of the client builder
        /// is not dependent on wheter an emulator configuration is detected or not.
        /// </remarks>
        protected abstract TClient BuildImpl();

        /// <summary>
        /// Builds the resulting client asynchronously.
        /// </summary>
        /// <remarks>Validation and emulator detection has already happened at this point.</remarks>
        public Task<TClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            Validate();
            if (EmulatorDetector != null && EmulatorDetector.TryDetectEmulator(out TEmulatorConfiguration config))
            {
                return WithEmulatorConfiguration(config).BuildImplAsync(cancellationToken);
            }
            return BuildImplAsync(cancellationToken);
        }

        /// <summary>
        /// Builds the resulting client asynchronously.
        /// </summary>
        /// <remarks>Validation and emulator detection has already happened at this point.</remarks>
        protected abstract Task<TClient> BuildImplAsync(CancellationToken cancellationToken);

        private protected virtual ChannelBase CreateChannel(string endpoint, ChannelCredentials credentials) =>
            (GrpcImplementation ?? GrpcImplementation.Default).CreateChannel(endpoint, credentials, GetChannelOptions());

        private class DelegatedTokenAccess : ITokenAccess
        {
            private readonly Func<string, CancellationToken, Task<string>> _tokenAccessMethod;

            internal DelegatedTokenAccess(Func<string, CancellationToken, Task<string>> tokenAccessMethod) =>
                _tokenAccessMethod = tokenAccessMethod;

            public Task<string> GetAccessTokenForRequestAsync(string authUri, CancellationToken cancellationToken) =>
                _tokenAccessMethod(authUri, cancellationToken);
        }
    }
}