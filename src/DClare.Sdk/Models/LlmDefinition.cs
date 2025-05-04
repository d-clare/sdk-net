namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a Large Language Model (LLM) used for text generation and reasoning tasks.
/// </summary>
[Description("Represents the definition of a Large Language Model (LLM) used for text generation and reasoning tasks.")]
[DataContract]
public record LlmDefinition 
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the definition of the LLM provider, including provider name and optional configuration.
    /// </summary>
    [Description("The definition of the LLM provider, including provider name and optional configuration.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual LlmProviderDefinition Provider { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the LLM model to use (e.g., 'gpt-4', 'mistral-7b', 'gemini-pro').
    /// </summary>
    [Description("The name of the LLM model to use (e.g., 'gpt-4', 'mistral-7b', 'gemini-pro').")]
    [Required, MinLength(1)]
    [DataMember(Name = "model", Order = 2), JsonPropertyName("model"), JsonPropertyOrder(2), YamlMember(Alias = "model", Order = 2)]
    public virtual string Model { get; set; } = null!;

    /// <summary>
    /// Gets or sets the API configuration used to invoke the LLM, including authentication and endpoint details.
    /// </summary>
    [Description("The API configuration used to invoke the LLM, including authentication and endpoint details.")]
    [Required]
    [DataMember(Name = "api", Order = 3), JsonPropertyName("api"), JsonPropertyOrder(3), YamlMember(Alias = "api", Order = 3)]
    public virtual LlmApiDefinition Api { get; set; } = null!;

    /// <inheritdoc/>
    public override string ToString() => $"{Provider} - {Model}";

}
