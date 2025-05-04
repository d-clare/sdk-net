namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the transport mechanism used to connect to an MCP (Model Context Protocol) server.
/// </summary>
[Description("Represents the definition of the transport mechanism used to connect to an MCP (Model Context Protocol) server.")]
[DataContract]
public record McpTransportDefinition
{

    /// <summary>
    /// Gets or sets the definition of an HTTP transport for the Model Context Protocol.
    /// </summary>
    [Description("Defines the HTTP transport configuration for the MCP server.")]
    [DataMember(Name = "http", Order = 1), JsonPropertyName("http"), JsonPropertyOrder(1), YamlMember(Alias = "http", Order = 1)]
    public virtual McpHttpTransportDefinition? Http { get; set; }

    /// <summary>
    /// Gets or sets the definition of an STDIO transport for the Model Context Protocol.
    /// </summary>
    [Description("Defines the STDIO transport configuration for the MCP server.")]
    [DataMember(Name = "stdio", Order = 1), JsonPropertyName("stdio"), JsonPropertyOrder(1), YamlMember(Alias = "stdio", Order = 1)]
    public virtual McpStdioTransportDefinition? Stdio { get; set; }

    /// <summary>
    /// Gets or sets additional transport-specific configuration options, if any.
    /// </summary>
    [Description("Optional dictionary of additional configuration settings specific to the selected transport.")]
    [DataMember(Name = "options", Order = 2), JsonPropertyName("options"), JsonPropertyOrder(2), YamlMember(Alias = "options", Order = 2)]
    public virtual EquatableDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// Gets the transport type based on which definition is present (either HTTP or STDIO).
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    [Description("The type of transport used, resolved from the configuration (either 'http' or 'stdio').")]
    public virtual string Type => Http != null ? McpTransportType.Http : Stdio != null ? McpTransportType.Stdio : null!;

}

