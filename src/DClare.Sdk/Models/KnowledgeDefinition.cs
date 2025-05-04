namespace DClare.Sdk.Models;

/// <summary>
/// Represents the knowledge configuration used by the agent, including embeddings, vector retrieval, and knowledge graphs.
/// </summary>
[Description("Represents the knowledge configuration used by the agent, including embeddings, vector retrieval, and knowledge graphs.")]
[DataContract]
public record KnowledgeDefinition
{

    /// <summary>
    /// Gets or sets the embedding model used to vectorize textual input.
    /// </summary>
    [Description("The embedding model used to vectorize text.")]
    [Required]
    [DataMember(Name = "embedding", Order = 1), JsonPropertyName("embedding"), JsonPropertyOrder(1), YamlMember(Alias = "embedding", Order = 1)]
    public virtual EmbeddingModelDefinition Embedding { get; set; } = null!;

    /// <summary>
    /// Gets or sets the vector store used to persist and retrieve embedded representations.
    /// </summary>
    [Description("The vector store used to store and retrieve vectorized knowledge.")]
    [Required]
    [DataMember(Name = "store", Order = 2), JsonPropertyName("store"), JsonPropertyOrder(2), YamlMember(Alias = "store", Order = 2)]
    public virtual VectorStoreDefinition Store { get; set; } = null!;

    /// <summary>
    /// Gets or sets the knowledge graph used for concept resolution and semantic traversal.
    /// </summary>
    [Description("The knowledge graph used for concept resolution and semantic traversal.")]
    [DataMember(Name = "graph", Order = 3), JsonPropertyName("graph"), JsonPropertyOrder(3), YamlMember(Alias = "graph", Order = 3)]
    public virtual KnowledgeGraphDefinition? Graph { get; set; }

}
