using Json.Schema;
using YamlDotNet.Core;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the client to use to connect to an MCP (Model Context Protocol) server.
/// </summary>
[Description("Represents the definition of the client to use to connect to an MCP (Model Context Protocol) server.")]
[DataContract]
public record McpClientDefinition
{

    /// <summary>
    /// Gets or sets the definition of the client implementation to use to connect to an MCP server.
    /// </summary>
    [Description("The client implementation to use to connect to the MCP server.")]
    [DataMember(Name = "implementation", Order = 1), JsonPropertyName("implementation"), JsonPropertyOrder(1), YamlMember(Alias = "implementation", Order = 1)]
    public virtual McpClientImplementationDefinition? Implementation { get; set; }

    /// <summary>
    /// Gets or sets the version of the MCP protocol to use.
    /// </summary>
    [Description("The version of the MCP protocol to use (e.g., 'v20241105').")]
    [Required, DefaultValue(McpProtocolVersion.v20241105)]
    [DataMember(Name = "protocolVersion", Order = 2), JsonPropertyName("protocolVersion"), JsonPropertyOrder(2), YamlMember(Alias = "protocolVersion", Order = 2, ScalarStyle = ScalarStyle.SingleQuoted)]
    public virtual string ProtocolVersion { get; set; } = McpProtocolVersion.v20241105;

    /// <summary>
    /// Gets or sets the duration, if any, after which requests to the MCP tool time out.
    /// </summary>
    [Description("The optional timeout duration for requests to the MCP tool.")]
    [DataMember(Name = "timeout", Order = 3), JsonInclude, JsonPropertyName("timeout"), JsonPropertyOrder(3), YamlMember(Alias = "timeout", Order = 3)]
    public virtual Duration? Timeout { get; set; }

}
