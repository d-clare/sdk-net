namespace DClare.Sdk.UnitTests.Services;

internal static class InputVariableDefinitionFactory
{

    internal static InputVariableDefinition Create() => new()
    {
        Name = "fake-input-variable-name",
        Description = "fake-input-variable-description",
        Default = "fake-input-variable-description-default",
        Required = true,
        Sample = "fake-input-variable-sample",
        AllowDangerousContent = true,
        Schema = JsonSchemaFactory.Create()
    };

}
