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
/// Represents the definition of an input variable used in a prompt template or function call.
/// </summary>
[Description("Represents the definition of an input variable used in a prompt template or function call.")]
[DataContract]
public record InputVariableDefinition
{

    /// <summary>
    /// Gets or sets the name of the variable.
    /// </summary>
    [Description("The name of the input variable.")]
    [Required, MinLength(1)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets a human-readable description of the variable, if any.
    /// </summary>
    [Description("A human-readable description of the variable and its intended use.")]
    [DataMember(Name = "description", Order = 2), JsonPropertyName("description"), JsonPropertyOrder(2), YamlMember(Alias = "description", Order = 2)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets or sets a default value for the variable, used if no input is provided.
    /// </summary>
    [Description("A default value used if no explicit input is provided for the variable.")]
    [DataMember(Name = "default", Order = 3), JsonPropertyName("default"), JsonPropertyOrder(3), YamlMember(Alias = "default", Order = 3)]
    public virtual object? Default { get; set; }

    /// <summary>
    /// Gets or sets a sample value to illustrate typical usage.
    /// </summary>
    [Description("An example value that illustrates how this variable is typically used.")]
    [DataMember(Name = "sample", Order = 4), JsonPropertyName("sample"), JsonPropertyOrder(4), YamlMember(Alias = "sample", Order = 4)]
    public virtual object? Sample { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this variable is required.
    /// </summary>
    [Description("Specifies whether the variable must be provided in every invocation.")]
    [DataMember(Name = "required", Order = 5), JsonPropertyName("required"), JsonPropertyOrder(5), YamlMember(Alias = "required", Order = 5)]
    public virtual bool Required { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to allow potentially dangerous content in the variable.
    /// </summary>
    [Description("Indicates whether the variable is allowed to contain untrusted or potentially dangerous content.")]
    [DataMember(Name = "allowDangerousContent", Order = 6), JsonPropertyName("allowDangerousContent"), JsonPropertyOrder(6), YamlMember(Alias = "allowDangerousContent", Order = 6)]
    public virtual bool AllowDangerousContent { get; set; }

    /// <summary>
    /// Gets or sets a JSON schema definition describing the structure and constraints of the variable.
    /// </summary>
    [Description("An optional JSON Schema used to validate or describe the structure of the input variable.")]
    [DataMember(Name = "schema", Order = 7), JsonPropertyName("schema"), JsonPropertyOrder(7), YamlMember(Alias = "schema", Order = 7)]
    public virtual JsonSchema? Schema { get; set; }

}
