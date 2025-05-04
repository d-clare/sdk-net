namespace DClare.Sdk.UnitTests.Services;

internal static class MemoryDefinitionFactory
{

    internal static MemoryDefinition Create() => new()
    {
        Provider = new()
        {
            Name = MemoryProvider.Redis,
            Configuration = [] 
        },
        Strategy = MemoryStrategy.Summary,
        Summarizer = FunctionDefinitionFactory.Create()
    };

}
