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
/// Represents the definition of an output variable returned by a function or prompt.
/// </summary>
[Description("Represents the definition of an output variable returned by a function or prompt.")]
[DataContract]
public record OutputVariableDefinition
{

    /// <summary>
    /// Gets or sets a human-readable description of the output variable, if any.
    /// </summary>
    [Description("A human-readable description of the output variable and its meaning.")]
    [DataMember(Name = "description", Order = 1), JsonPropertyName("description"), JsonPropertyOrder(1), YamlMember(Alias = "description", Order = 1)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets or sets a JSON schema that describes the structure and constraints of the output variable.
    /// </summary>
    [Description("An optional JSON Schema that defines the expected structure, type, and constraints of the output variable.")]
    [DataMember(Name = "schema", Order = 2), JsonPropertyName("schema"), JsonPropertyOrder(2), YamlMember(Alias = "schema", Order = 2)]
    public virtual JsonSchema? Schema { get; set; }

}
