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
/// Represents the definition of a kernel function
/// </summary>
[DataContract]
public record KernelFunctionDefinition
{

    /// <summary>
    /// Gets/sets the function's prompt template
    /// </summary>
    [Required, MinLength(3)]
    [DataMember(Name = "template", Order = 1), JsonPropertyName("template"), JsonPropertyOrder(1), YamlMember(Alias = "template", Order = 1)]
    public virtual PromptTemplateDefinition Template { get; set; } = null!;

    /// <summary>
    /// Gets/sets a list containing the names of the parameters, if any, to exclude from being encoded
    /// </summary>
    [DataMember(Name = "parameters", Order = 2), JsonPropertyName("parameters"), JsonPropertyOrder(2), YamlMember(Alias = "parameters", Order = 2)]
    public virtual EquatableList<string>? Parameters { get; set; }

}
