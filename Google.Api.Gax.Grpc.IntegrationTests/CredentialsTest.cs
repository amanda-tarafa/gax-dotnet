/*
 * Copyright 2020 Google LLC
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Grpc.Core;
using Xunit;
using static Google.Api.Gax.Grpc.IntegrationTests.TestServiceCredentialsFixture;

namespace Google.Api.Gax.Grpc.IntegrationTests
{
    [Collection(nameof(TestServiceCredentialsFixture))]
    public class CredentialsTest
    {
        private readonly TestServiceCredentialsFixture _fixture;

        public CredentialsTest(TestServiceCredentialsFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void ServiceCredential_CallCredential()
        {
            var builder = new TestServiceClientBuilder
            {
                Endpoint = _fixture.Endpoint,
                //ChannelCredentials = GoogleCredential.FromAccessToken("SERVICE_LEVEL_TOKEN").ToChannelCredentials()
                ChannelCredentials =  ChannelCredentials.Insecure
            };
            var client = builder.Build();

            var callCredentianls = GoogleCredential.FromAccessToken("CLIENT_LEVEL_TOKEN").ToCallCredentials();

            var response = client.DoSimple(
                new SimpleRequest { Name = nameof(ServiceCredential_CallCredential) },
                CallSettings.FromCallCredentials(callCredentianls));

            Assert.Equal(nameof(ServiceCredential_CallCredential), response.Name);
        }
    }
}
