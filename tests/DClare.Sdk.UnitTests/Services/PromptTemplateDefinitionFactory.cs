namespace DClare.Sdk.UnitTests.Services;

internal static class PromptTemplateDefinitionFactory
{

    internal static PromptTemplateDefinition Create() => new()
    {
        Content = "Fake template content",
        Format = PromptTemplateFormat.Liquid,
        InputVariables = [InputVariableDefinitionFactory.Create()],
        OutputVariable = OutputVariableDefinitionFactory.Create()
    };

}
