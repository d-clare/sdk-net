namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of an embedding model used to generate vector representations
/// of input text for use in semantic search, similarity comparison, or knowledge retrieval.
/// </summary>
[Description("Represents the definition of an embedding model used to generate vector representations of input text.")]
[DataContract]
public record EmbeddingModelDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the definition of the embedding model provider.
    /// </summary>
    [Description("The definition of the embedding model provider.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual EmbeddingModelProviderDefinition Provider { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the embedding model to use.
    /// </summary>
    [Description("The name of the embedding model to use.")]
    [Required, MinLength(1)]
    [DataMember(Name = "model", Order = 2), JsonPropertyName("model"), JsonPropertyOrder(2), YamlMember(Alias = "model", Order = 2)]
    public virtual string Model { get; set; } = null!;

    /// <summary>
    /// Gets or sets the definition of the API used to invoke the embedding model.
    /// </summary>
    [Description("The definition of the API used to invoke the embedding model.")]
    [Required]
    [DataMember(Name = "api", Order = 3), JsonPropertyName("api"), JsonPropertyOrder(3), YamlMember(Alias = "api", Order = 3)]
    public virtual EmbeddingApiDefinition Api { get; set; } = null!;

    /// <inheritdoc/>
    public override string ToString() => $"{Provider} - {Model}";

}
