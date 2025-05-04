namespace DClare.Sdk.UnitTests.Services;

internal static class VectorStoreDefinitionFactory
{

    internal static VectorStoreDefinition Create() => new()
    {
        Provider = new()
        {
            Name = VectorStoreProvider.Faiss,
            Configuration = []
        }
    };

}
