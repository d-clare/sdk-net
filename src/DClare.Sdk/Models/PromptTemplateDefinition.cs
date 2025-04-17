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
/// Represents the definition of a prompt template
/// </summary>
[DataContract]
public record PromptTemplateDefinition
{

    /// <summary>
    /// Gets/sets the template content to use for prompt generation, including placeholders for input variables
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "content", Order = 1), JsonPropertyName("content"), JsonPropertyOrder(1), YamlMember(Alias = "content", Order = 1)]
    public virtual string Content { get; set; } = null!;

    /// <summary>
    /// Gets/sets the optional format of the prompt template
    /// </summary>
    [DataMember(Name = "format", Order = 2), JsonPropertyName("format"), JsonPropertyOrder(2), YamlMember(Alias = "format", Order = 2)]
    public virtual string? Format { get; set; }

    /// <summary>
    /// Gets/sets a list of input variables, if any, used within the template
    /// </summary>
    [DataMember(Name = "inputVariables", Order = 3), JsonPropertyName("inputVariables"), JsonPropertyOrder(3), YamlMember(Alias = "inputVariables", Order = 3)]
    public virtual EquatableList<InputVariableDefinition>? InputVariables { get; set; }

    /// <summary>
    /// Gets/sets the definition of the expected output variable, if any, for the result produced by the prompt
    /// </summary>
    [DataMember(Name = "outputVariable", Order = 4), JsonPropertyName("outputVariable"), JsonPropertyOrder(4), YamlMember(Alias = "outputVariable", Order = 4)]
    public virtual OutputVariableDefinition? OutputVariable { get; set; }

}
