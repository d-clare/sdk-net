namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a toolset based on the Model Context Protocol (MCP),
/// including how to connect to the MCP server and which client to use.
/// </summary>
[Description("Represents the definition of a toolset based on the Model Context Protocol (MCP), including transport and client settings.")]
[DataContract]
public record McpToolsetDefinition
{

    /// <summary>
    /// Gets or sets the definition of the transport to use to connect to the MCP server.
    /// </summary>
    [Description("The definition of the transport to use to connect to the MCP server.")]
    [Required]
    [DataMember(Name = "transport", Order = 1), JsonPropertyName("transport"), JsonPropertyOrder(1), YamlMember(Alias = "transport", Order = 1)]
    public virtual McpTransportDefinition Transport { get; set; } = null!;

    /// <summary>
    /// Gets or sets the definition of the client to use to connect to the MCP server.
    /// </summary>
    [Description("The definition of the client to use to connect to the MCP server.")]
    [DataMember(Name = "client", Order = 2), JsonPropertyName("client"), JsonPropertyOrder(2), YamlMember(Alias = "client", Order = 2)]
    public virtual McpClientDefinition? Client { get; set; }

}
