namespace DClare.Sdk.UnitTests.Services;

internal static class EmbeddingModelDefinitionFactory
{

    internal static EmbeddingModelDefinition Create() => new()
    {
        Provider = new()
        {
            Name = EmbeddingModelProvider.Gemini,
            Configuration = []
        },
        Model = "gemini-embedding-exp-03-07",
        Api = new()
        {
            Endpoint = new Uri("https://fake-uri.com")
        }
    };

}
