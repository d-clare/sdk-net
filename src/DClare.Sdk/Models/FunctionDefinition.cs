// Copyright © 2025-Present The DClare Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

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
