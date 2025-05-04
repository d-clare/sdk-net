namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the API used to invoke the embedding model provider.
/// </summary>
[Description("Represents the definition of the API used to invoke the embedding model provider.")]
[DataContract]
public record EmbeddingApiDefinition
{

    /// <summary>
    /// Gets or sets the API endpoint used to access the embedding provider.
    /// </summary>
    [Description("The API endpoint used to access the embedding provider.")]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual OneOf<EndpointDefinition, Uri> Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets or sets a dictionary of additional provider-specific configuration properties.
    /// </summary>
    [Description("A dictionary of additional provider-specific configuration properties.")]
    [DataMember(Name = "properties", Order = 2), JsonPropertyName("properties"), JsonPropertyOrder(2), YamlMember(Alias = "properties", Order = 2)]
    public virtual EquatableDictionary<string, object>? Properties { get; set; }

}
