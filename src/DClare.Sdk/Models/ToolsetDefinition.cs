namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a toolset, which may be described using either the Model Context Protocol (MCP) or an OpenAPI specification document.
/// </summary>
[Description("Represents the definition of a toolset, described using either MCP or OpenAPI.")]
[DataContract]
public record ToolsetDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the definition of a toolset based on the Model Context Protocol (MCP).
    /// </summary>
    [Description("The definition of a toolset based on the Model Context Protocol (MCP).")]
    [DataMember(Name = "mcp", Order = 1), JsonPropertyName("mcp"), JsonPropertyOrder(1), YamlMember(Alias = "mcp", Order = 1)]
    public virtual McpToolsetDefinition? Mcp { get; set; }

    /// <summary>
    /// Gets or sets the definition of a toolset based on an OpenAPI specification document.
    /// </summary>
    [Description("The definition of a toolset based on an OpenAPI specification document.")]
    [DataMember(Name = "openapi", Order = 1), JsonPropertyName("openapi"), JsonPropertyOrder(1), YamlMember(Alias = "openapi", Order = 1)]
    public virtual OpenApiToolsetDefinition? OpenApi { get; set; }

    /// <summary>
    /// Gets the type of the toolset based on which definition is present (either 'mcp' or 'openapi').
    /// </summary>
    [Description("The type of toolset definition present: either 'mcp' or 'openapi'.")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Mcp != null ? ToolsetType.Mcp : OpenApi != null ? ToolsetType.OpenApi : null!;

}
