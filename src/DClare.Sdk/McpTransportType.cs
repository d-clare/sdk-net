namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported transport types for the Model Context Protocol (MCP).
/// </summary>
[Description("Enumerates all supported transport types for the Model Context Protocol (MCP).")]
public static class McpTransportType
{

    /// <summary>
    /// Indicates a transport type that communicates via HTTP.
    /// </summary>
    public const string Http = "http";
    /// <summary>
    /// Indicates a transport type that communicates via standard input/output (STDIO).
    /// </summary>
    public const string Stdio = "stdio";

    /// <summary>
    /// Returns a collection of all supported MCP transport types.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> of supported transport type identifiers.</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Http;
        yield return Stdio;
    }

}
