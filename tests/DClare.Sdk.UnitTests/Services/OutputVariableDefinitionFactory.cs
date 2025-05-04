namespace DClare.Sdk.UnitTests.Services;

internal static class OutputVariableDefinitionFactory
{

    internal static OutputVariableDefinition Create() => new()
    {
        Description = "fake-output-variable-description",
        Schema = JsonSchemaFactory.Create()
    };

}
