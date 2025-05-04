namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a knowledge graph used for storing and traversing structured relationships between entities.
/// </summary>
[Description("Represents the definition of a knowledge graph used for storing and traversing structured relationships between entities.")]
[DataContract]
public record KnowledgeGraphDefinition
{

    /// <summary>
    /// Gets or sets the definition of the graph provider to use.
    /// </summary>
    [Description("The definition of the graph provider to use.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual KnowledgeGraphProviderDefinition Provider { get; set; } = null!;

    /// <inheritdoc/>
    public override string ToString() => Provider.ToString();

}

