namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a toolset based on an OpenAPI specification document.
/// </summary>
[Description("Represents the definition of a toolset based on an OpenAPI specification document.")]
[DataContract]
public record OpenApiToolsetDefinition
{

    /// <summary>
    /// Gets or sets the external OpenAPI document used to define the toolset.
    /// </summary>
    [Description("The external OpenAPI document used to define the toolset.")]
    [Required]
    [DataMember(Name = "document", Order = 1), JsonPropertyName("document"), JsonPropertyOrder(1), YamlMember(Alias = "document", Order = 1)]
    public virtual ExternalResourceDefinition Document { get; set; } = null!;

}
