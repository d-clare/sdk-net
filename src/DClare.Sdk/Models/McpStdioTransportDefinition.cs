namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a STDIO transport for the Model Context Protocol (MCP), used to launch and communicate with an external process via standard input/output streams.
/// </summary>
[Description("Represents the definition of a STDIO transport for the Model Context Protocol (MCP), using standard input/output streams.")]
[DataContract]
public record McpStdioTransportDefinition
{

    /// <summary>
    /// Gets or sets the command to execute the MCP tool.
    /// </summary>
    [Description("The command to execute the MCP tool.")]
    [Required]
    [DataMember(Name = "command", Order = 1), JsonInclude, JsonPropertyName("command"), JsonPropertyOrder(1), YamlMember(Alias = "command", Order = 1)]
    public virtual string Command { get; set; } = null!;

    /// <summary>
    /// Gets or sets an optional list of arguments to pass to the command.
    /// </summary>
    [Description("A list of optional arguments to pass to the command.")]
    [DataMember(Name = "arguments", Order = 2), JsonInclude, JsonPropertyName("arguments"), JsonPropertyOrder(2), YamlMember(Alias = "arguments", Order = 2)]
    public virtual EquatableList<string>? Arguments { get; set; }

}

