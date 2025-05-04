namespace DClare.Sdk.UnitTests.Services;

internal static class KnowledgeGraphDefinitionFactory
{

    internal static KnowledgeGraphDefinition Create() => new()
    {
        Provider = new()
        {
            Name = KnowledgeGraphProvider.Neo4j,
            Configuration = []
        }
    };

}
