namespace DClare.Sdk.Models;

/// <summary>
/// Represents the configuration of a vector store used to persist and query vector embeddings.
/// </summary>
[Description("Represents the configuration of a vector store used to persist and query vector embeddings.")]
[DataContract]
public record VectorStoreDefinition
{

    /// <summary>
    /// Gets or sets the definition of the vector store provider.
    /// </summary>
    [Description("The definition of the vector store provider, including its name and configuration.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual VectorStoreProviderDefinition Provider { get; set; } = null!;

    /// <inheritdoc/>
    public override string ToString() => Provider.ToString();

}