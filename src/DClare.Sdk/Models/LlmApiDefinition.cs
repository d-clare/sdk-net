namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the API used to invoke a Large Language Model (LLM) provider.
/// </summary>
[Description("Represents the definition of the API used to invoke a Large Language Model (LLM) provider.")]
[DataContract]
public record LlmApiDefinition
{
    /// <summary>
    /// Gets or sets the API endpoint used to reach the LLM provider.
    /// </summary>
    [Description("The API endpoint used to reach the LLM provider.")]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual OneOf<EndpointDefinition, Uri> Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets or sets a key/value mapping of additional configuration properties for the API.
    /// </summary>
    [Description("Optional key/value mapping of provider-specific configuration settings.")]
    [DataMember(Name = "properties", Order = 2), JsonPropertyName("properties"), JsonPropertyOrder(2), YamlMember(Alias = "properties", Order = 2)]
    public virtual EquatableDictionary<string, object>? Properties { get; set; }

}
