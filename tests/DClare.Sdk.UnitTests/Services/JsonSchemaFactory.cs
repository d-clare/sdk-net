using Json.Schema;

namespace DClare.Sdk.UnitTests.Services;

internal static class JsonSchemaFactory
{

    internal static JsonSchema Create()
    {
        var properties = new Dictionary<string, JsonSchema>()
        {
            { "fake-property-1", new JsonSchemaBuilder().Type(SchemaValueType.String).Build() },
            { "fake-property-2", new JsonSchemaBuilder().Type(SchemaValueType.Number).Build() }
        };
        return new JsonSchemaBuilder()
            .Type(SchemaValueType.Object)
            .Properties(properties)
            .Build();
    }

}