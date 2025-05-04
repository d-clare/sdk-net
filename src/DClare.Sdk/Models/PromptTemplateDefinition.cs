namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a prompt template, including its format, content, input variables, and expected output.
/// </summary>
[Description("Represents the definition of a prompt template, including its format, content, input variables, and expected output.")]
[DataContract]
public record PromptTemplateDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the raw content of the prompt template.
    /// </summary>
    [Description("The raw content of the prompt template, containing placeholders or expressions.")]
    [Required, MinLength(1)]
    [DataMember(Name = "content", Order = 1), JsonPropertyName("content"), JsonPropertyOrder(1), YamlMember(Alias = "content", Order = 1)]
    public virtual string Content { get; set; } = null!;

    /// <summary>
    /// Gets or sets the format used for interpreting the prompt template (e.g., 'semantic-kernel', 'handlebars', 'liquid', or 'echo').
    /// </summary>
    [Description("The template engine or format used to interpret the prompt. Supported values include 'semantic-kernel', 'handlebars', 'liquid', and 'echo'.")]
    [Required, AllowedValues(PromptTemplateFormat.Echo, PromptTemplateFormat.Handlebars, PromptTemplateFormat.Liquid, PromptTemplateFormat.SemanticKernel), DefaultValue(PromptTemplateFormat.SemanticKernel)]
    [DataMember(Name = "format", Order = 2), JsonPropertyName("format"), JsonPropertyOrder(2), YamlMember(Alias = "format", Order = 2)]
    public virtual string Format { get; set; } = PromptTemplateFormat.SemanticKernel;

    /// <summary>
    /// Gets or sets a list of input variables, if any, that are referenced within the template.
    /// </summary>
    [Description("A list of input variables expected by the template, each with a name, description, and optional default value.")]
    [DataMember(Name = "inputVariables", Order = 3), JsonPropertyName("inputVariables"), JsonPropertyOrder(3), YamlMember(Alias = "inputVariables", Order = 3)]
    public virtual EquatableList<InputVariableDefinition>? InputVariables { get; set; }

    /// <summary>
    /// Gets or sets the definition of the output variable produced by the template, if any.
    /// </summary>
    [Description("The definition of the expected output variable produced by the prompt template.")]
    [DataMember(Name = "outputVariable", Order = 4), JsonPropertyName("outputVariable"), JsonPropertyOrder(4), YamlMember(Alias = "outputVariable", Order = 4)]
    public virtual OutputVariableDefinition? OutputVariable { get; set; }

}

