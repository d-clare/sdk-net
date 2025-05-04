using YamlDotNet.Core;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the client implementation to use to connect to an MCP server.
/// </summary>
[Description("Represents the definition of the client implementation to use to connect to an MCP server.")]
[DataContract]
public record McpClientImplementationDefinition
{

    /// <summary>
    /// Gets or sets the name of the client implementation.
    /// </summary>
    [Description("The name of the client implementation used to connect to the MCP server.")]
    [Required, MinLength(1)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the version of the client to use.
    /// </summary>
    [Description("The version of the client implementation to use.")]
    [Required, MinLength(1)]
    [DataMember(Name = "version", Order = 2), JsonPropertyName("version"), JsonPropertyOrder(2), YamlMember(Alias = "version", Order = 2, ScalarStyle = ScalarStyle.SingleQuoted)]
    public virtual string Version { get; set; } = null!;

}
