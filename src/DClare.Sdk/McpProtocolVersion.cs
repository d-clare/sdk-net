namespace DClare.Sdk;

/// <summary>
/// Exposes all default MCP protocol versions
/// </summary>
public static class McpProtocolVersion
{

    /// <summary>
    /// Indicates the '2024-11-05' protocol version
    /// </summary>
    public const string v20241105 = "2024-11-05";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return v20241105;
    }

}