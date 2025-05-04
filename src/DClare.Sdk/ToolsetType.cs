namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported toolset types used to describe external tool capabilities.
/// </summary>
[Description("Enumerates all supported toolset types used to describe external tool capabilities.")]
public static class ToolsetType
{

    /// <summary>
    /// Indicates a toolset defined using the Model Context Protocol (MCP).
    /// </summary>
    public const string Mcp = "mcp";
    /// <summary>
    /// Indicates a toolset defined using an OpenAPI specification.
    /// </summary>
    public const string OpenApi = "openapi";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported toolset type identifiers.
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/> of supported toolset types.</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Mcp;
        yield return OpenApi;
    }

}
