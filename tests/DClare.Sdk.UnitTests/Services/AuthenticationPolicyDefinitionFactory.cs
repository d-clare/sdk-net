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