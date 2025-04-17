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
/// Represents the definition of an input variable
/// </summary>
[DataContract]
public record InputVariableDefinition
{

    /// <summary>
    /// Gets/sets the variable's name
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets/sets the variable's description, if any
    /// </summary>
    [DataMember(Name = "description", Order = 2), JsonPropertyName("description"), JsonPropertyOrder(2), YamlMember(Alias = "description", Order = 2)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets/sets the variable's default value, if any
    /// </summary>
    [DataMember(Name = "default", Order = 3), JsonPropertyName("default"), JsonPropertyOrder(3), YamlMember(Alias = "default", Order = 3)]
    public virtual object? Default { get; set; }

    /// <summary>
    /// Gets/sets the a sample value for the variable, if any
    /// </summary>
    [DataMember(Name = "sample", Order = 4), JsonPropertyName("sample"), JsonPropertyOrder(4), YamlMember(Alias = "sample", Order = 4)]
    public virtual object? Sample { get; set; }

    /// <summary>
    /// Gets/sets a boolean indicating whether or not the variable is required
    /// </summary>
    [DataMember(Name = "required", Order = 5), JsonPropertyName("required"), JsonPropertyOrder(5), YamlMember(Alias = "required", Order = 5)]
    public virtual bool Required { get; set; }

    /// <summary>
    /// Gets/sets a boolean indicating whether or not to handle the variable value as potential dangerous content
    /// </summary>
    [DataMember(Name = "allowDangerousContent", Order = 6), JsonPropertyName("allowDangerousContent"), JsonPropertyOrder(6), YamlMember(Alias = "allowDangerousContent", Order = 6)]
    public virtual bool AllowDangerousContent { get; set; }

    /// <summary>
    /// Gets/sets the JSON schema, if any, used to describe the variable
    /// </summary>
    [DataMember(Name = "schema", Order = 7), JsonPropertyName("schema"), JsonPropertyOrder(7), YamlMember(Alias = "schema", Order = 7)]
    public virtual JsonSchema? Schema { get; set; }

}