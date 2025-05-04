namespace DClare.Sdk.UnitTests.Services;

internal static class FunctionDefinitionFactory
{

    internal static FunctionDefinition Create() => new()
    {
        Prompt = PromptTemplateDefinitionFactory.Create(),
        Llm = LlmDefinitionFactory.Create()
    };

}
