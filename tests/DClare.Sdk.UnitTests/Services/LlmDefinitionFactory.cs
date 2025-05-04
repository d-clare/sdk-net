namespace DClare.Sdk.UnitTests.Services;

internal static class LlmDefinitionFactory
{

    internal static LlmDefinition Create() => new()
    {
        Provider = new()
        {
            Name = LlmProvider.OpenAI,
            Configuration = []
        },
        Model = "gpt-4o",
        Api = new()
        {
            Endpoint = new EndpointDefinition()
            {
                Uri = new("https://fake-uri"),
                Authentication = AuthenticationPolicyDefinitionFactory.CreateOAuth2()
            }
        }
    };

}
