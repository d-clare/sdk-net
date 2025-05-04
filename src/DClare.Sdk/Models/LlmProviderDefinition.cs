namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a provider used to execute LLM models, including its identifier and optional configuration.
/// </summary>
[Description("Represents the definition of a provider used to execute LLM models, including its identifier and optional configuration.")]
[DataContract]
public record LlmProviderDefinition
{

    /// <summary>
    /// Gets or sets the name of the LLM provider.
    /// </summary>
    [Description("The name of the LLM provider. Supported values include 'openai', 'azure-openai', 'hugging-face', 'gemini', 'mistral', 'ollama', and 'onnx'.")]
    [Required, MinLength(1)]
    [AllowedValues(LlmProvider.AzureOpenAI, LlmProvider.Gemini, LlmProvider.HuggingFace, LlmProvider.MistralAI, LlmProvider.Ollama, LlmProvider.Onnx, LlmProvider.OpenAI)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the optional configuration settings specific to the selected provider.
    /// </summary>
    [Description("A dictionary of optional configuration settings specific to the selected LLM provider.")]
    [DataMember(Name = "configuration", Order = 2), JsonPropertyName("configuration"), JsonPropertyOrder(2), YamlMember(Alias = "configuration", Order = 2)]
    public virtual EquatableDictionary<string, object>? Configuration { get; set; }

    /// <inheritdoc/>
    public override string ToString() => Name;

}
