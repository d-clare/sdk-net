namespace DClare.Sdk.Models;

/// <summary>
/// Represents the configuration of a graph provider used for storing and querying knowledge graphs.
/// </summary>
[Description("Represents the configuration of a graph provider used for storing and querying knowledge graphs.")]
[DataContract]
public record KnowledgeGraphProviderDefinition
{

    /// <summary>
    /// Gets or sets the name of the graph provider.
    /// </summary>
    [Description("The name of the graph provider. Supported values include 'arangodb', 'neo4j', and 'neptune'.")]
    [Required, MinLength(1)]
    [AllowedValues(KnowledgeGraphProvider.ArangoDb, KnowledgeGraphProvider.Neo4j, KnowledgeGraphProvider.Neptune)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets provider-specific configuration settings, if any.
    /// </summary>
    [Description("Optional provider-specific configuration settings.")]
    [DataMember(Name = "configuration", Order = 2), JsonPropertyName("configuration"), JsonPropertyOrder(2), YamlMember(Alias = "configuration", Order = 2)]
    public virtual EquatableDictionary<string, object>? Configuration { get; set; }

    /// <inheritdoc/>
    public override string ToString() => Name;

}
