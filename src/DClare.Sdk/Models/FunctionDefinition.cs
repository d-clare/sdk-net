namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a function, including its prompt, LLM configuration, and optional parameter handling.
/// </summary>
[Description("Represents the definition of a function, including its prompt, LLM configuration, and optional parameter handling.")]
[DataContract]
public record FunctionDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the prompt template used to define the function's behavior.
    /// </summary>
    [Description("The prompt template used to define the function's behavior.")]
    [Required]
    [DataMember(Name = "prompt", Order = 1), JsonPropertyName("prompt"), JsonPropertyOrder(1), YamlMember(Alias = "prompt", Order = 1)]
    public virtual PromptTemplateDefinition Prompt { get; set; } = null!;

    /// <summary>
    /// Gets or sets a list of parameter names that should not be automatically encoded.
    /// </summary>
    [Description("A list of parameter names to exclude from automatic encoding or transformation.")]
    [DataMember(Name = "parameters", Order = 2), JsonPropertyName("parameters"), JsonPropertyOrder(2), YamlMember(Alias = "parameters", Order = 2)]
    public virtual EquatableList<string>? Parameters { get; set; }

    /// <summary>
    /// Gets or sets the definition of the LLM used to execute the function.
    /// </summary>
    [Description("The definition of the LLM used to execute the function.")]
    [Required]
    [DataMember(Name = "llm", Order = 3), JsonPropertyName("llm"), JsonPropertyOrder(3), YamlMember(Alias = "llm", Order = 3)]
    public virtual LlmDefinition Llm { get; set; } = null!;

}

