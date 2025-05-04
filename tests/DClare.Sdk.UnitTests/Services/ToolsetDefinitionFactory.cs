namespace DClare.Sdk.UnitTests.Services;

internal static class ToolsetDefinitionFactory
{

    internal static ToolsetDefinition CreateMcp()
    {
        return new()
        {
            Mcp = new()
            {
                Client = new()
                {
                    ProtocolVersion = McpProtocolVersion.v20241105,
                    Implementation = new()
                    {
                        Name = "fake-mcp-client-implementation",
                        Version = "fake-mcp-client-version"
                    }
                },
                Transport = new()
                {
                    Http = new()
                    {
                        Endpoint = new Uri("https://fake-endpoint")
                    }
                }
            }
        };
    }

    internal static ToolsetDefinition CreateOpenApi()
    {
        return new()
        {
            OpenApi = new()
            {
                Document = new()
                {
                    Name = "fake-document-name",
                    Endpoint = new Uri("https://fake-endpoint.com")
                }
            }
        };
    }

    internal static EquatableDictionary<string, ToolsetDefinition> CreateCollection()
    {
        return new()
        {
            { "mcp", CreateMcp() },
            { "openapi", CreateOpenApi() }
        };
    }

}