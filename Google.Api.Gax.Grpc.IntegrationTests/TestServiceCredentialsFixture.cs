/*
 * Copyright 2020 Google LLC
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Google.Api.Gax.Grpc.GrpcCore;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Api.Gax.Grpc.IntegrationTests
{
    /// <summary>
    /// Test fixture for a simple gRPC service hosted on a local port. This can be manually constructed,
    /// or used as a dependency for a test collection.
    /// </summary>
    [CollectionDefinition(nameof(TestServiceCredentialsFixture))]
    public class TestServiceCredentialsFixture : IDisposable, ICollectionFixture<TestServiceCredentialsFixture>
    {
        private readonly Server _server;

        public int Port => _server.Ports.First().BoundPort;
        public string Endpoint => $"localhost:{Port}";

        public TestServiceCredentialsFixture()
        {
            _server = new Server
            {
                Services = { TestService.BindService(new TestServiceImpl()) },
                Ports = { new ServerPort("localhost", 0, ServerCredentials.Insecure) }
            };
            _server.Start();
        }

        public void Dispose()
        {
            Task.Run(() => _server.ShutdownAsync()).Wait();
        }

        private class TestServiceImpl : TestService.TestServiceBase
        {
            public override Task<SimpleResponse> DoSimple(SimpleRequest request, ServerCallContext context)
                => Task.FromResult(new SimpleResponse { Name = request.Name });
        }

        public class TestServiceClient
        {
            private readonly TestService.TestServiceClient _grpcClient;
            private readonly ApiCall<SimpleRequest, SimpleResponse> _callDoSimple;

            private TestServiceClient(TestService.TestServiceClient grpcClient)
            {
                _grpcClient = grpcClient;
                ClientHelper clientHelper = new ClientHelper(new TestServiceSettings());
                _callDoSimple = clientHelper.BuildApiCall<SimpleRequest, SimpleResponse>(grpcClient.DoSimpleAsync, grpcClient.DoSimple, CallSettings.FromExpiration(Expiration.None));
            }

            internal static TestServiceClient Create(CallInvoker callInvoker)
            {
                GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
                
                TestService.TestServiceClient grpcClient = new TestService.TestServiceClient(callInvoker);
                return new TestServiceClient(grpcClient);
            }

            public SimpleResponse DoSimple(SimpleRequest request, CallSettings callSettings = null)
            {
                return _callDoSimple.Sync(request, callSettings);
            }

            public async Task<SimpleResponse> DoSimpleAsync(SimpleRequest request, CallSettings callSettings = null)
            {
                return await _callDoSimple.Async(request, callSettings).ConfigureAwait(false);
            }

            internal class TestServiceSettings : ServiceSettingsBase
            { }
        }

        public class TestServiceClientBuilder : ClientBuilderBase<TestServiceClient>
        {
            private static readonly IReadOnlyList<string> s_empty = new List<string>().AsReadOnly();
            protected override GrpcAdapter DefaultGrpcAdapter => GrpcCoreAdapter.Instance;

            public override TestServiceClient Build()
            {
                Validate();
                CallInvoker callInvoker = CreateCallInvoker();
                return TestServiceClient.Create(callInvoker);
            }

            public async override Task<TestServiceClient> BuildAsync(CancellationToken cancellationToken = default)
            {
                Validate();
                CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
                return TestServiceClient.Create(callInvoker);
            }

            protected override bool CanUseChannelPool => false;

            protected override ChannelPool GetChannelPool() => throw new NotImplementedException();

            protected override string GetDefaultEndpoint() => throw new NotImplementedException();

            protected override IReadOnlyList<string> GetDefaultScopes() => s_empty;
        }
    }
}
