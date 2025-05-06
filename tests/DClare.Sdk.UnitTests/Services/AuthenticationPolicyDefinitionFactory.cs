// Copyright © 2025-Present The DClare Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace DClare.Sdk.UnitTests.Services;

internal static class AuthenticationPolicyDefinitionFactory
{

    internal static AuthenticationPolicyDefinition CreateApiKey() => new()
    {
        ApiKey = new()
        {
            Key = "fake-api-key"
        }
    };

    internal static AuthenticationPolicyDefinition CreateBearer() => new()
    {
        Bearer = new()
        {
            Token = "fake-bearer-token"
        }
    };

    internal static AuthenticationPolicyDefinition CreateOAuth2() => new()
    {
        OAuth2 = new()
        {
            Authority = new("https://fake-authority.com"),
            Grant = OAuth2GrantType.ClientCredentials,
            Client = new()
            {
                Id = "fake-client-id",
                Secret = "fake-client-secret"
            },
            Endpoints = new()
            {
                Token = new("/token", UriKind.Relative)
            }
        }
    };

    internal static AuthenticationPolicyDefinition CreateOIDC() => new()
    {
        Oidc = new()
        {
            Authority = new("https://fake-authority.com"),
            Grant = OAuth2GrantType.ClientCredentials,
            Client = new()
            {
                Id = "fake-client-id",
                Secret = "fake-client-secret"
            }
        }
    };

    internal static EquatableDictionary<string, AuthenticationPolicyDefinition> CreateCollection() => new()
    {
        { "apiKey", CreateApiKey() },
        { "bearer", CreateBearer() },
        { "oauth2", CreateOAuth2() },
        { "oidc", CreateOIDC() }
    };

}