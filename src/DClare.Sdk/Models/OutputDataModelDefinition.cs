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
/// Represents the definition of an output data model, including its schema and optional projection logic.
/// </summary>
[Description("Represents the definition of an output data model, including its schema and optional projection logic.")]
[DataContract]
public record OutputDataModelDefinition
{

    /// <summary>
    /// Gets or sets the JSON schema that defines and documents the structure of the output data.
    /// </summary>
    [Description("The schema that defines and documents the structure of the output data.")]
    [DataMember(Name = "schema", Order = 1), JsonPropertyName("schema"), JsonPropertyOrder(1), YamlMember(Alias = "schema", Order = 1)]
    public virtual JsonSchema? Schema { get; set; }

    /// <summary>
    /// Gets or sets a runtime expression used to extract or transform data into the scope after execution.
    /// </summary>
    [Description("A runtime expression used to extract or transform data into the scope after execution.")]
    [DataMember(Name = "as", Order = 3), JsonPropertyName("as"), JsonPropertyOrder(3), YamlMember(Alias = "as", Order = 3)]
    public virtual object? As { get; set; }

}