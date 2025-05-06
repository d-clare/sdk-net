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

namespace DClare.Sdk.Models.Tasks;

/// <summary>
/// Represents the definition of a loop that iterates over a collection or range of values.
/// </summary>
[Description("Represents the definition of a loop that iterates over a collection or range of values.")]
[DataContract]
public record ForLoopDefinition
{
    /// <summary>
    /// Gets or sets the name of the variable that will represent the current item in the iteration.
    /// </summary>
    [Description("The name of the variable that will represent the current item in the iteration.")]
    [DataMember(Name = "each", Order = 1), JsonPropertyName("each"), JsonPropertyOrder(1), YamlMember(Alias = "each", Order = 1)]
    public virtual string? Each { get; set; }

    /// <summary>
    /// Gets or sets the runtime expression that evaluates to the collection or range to iterate over.
    /// </summary>
    [Description("The runtime expression that evaluates to the collection or range to iterate over.")]
    [Required, MinLength(1)]
    [DataMember(Name = "in", Order = 2), JsonPropertyName("in"), JsonPropertyOrder(2), YamlMember(Alias = "in", Order = 2)]
    public virtual string In { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the variable used to track the index of each element during iteration.
    /// </summary>
    [Description("The name of the variable used to track the index of each element during iteration.")]
    [DataMember(Name = "at", Order = 3), JsonPropertyName("at"), JsonPropertyOrder(3), YamlMember(Alias = "at", Order = 3)]
    public virtual string? At { get; set; }

    /// <summary>
    /// Gets or sets the input definition, if any, to pass to the task(s) executed during each iteration.
    /// </summary>
    [Description("The input definition, if any, to pass to the task(s) executed during each iteration.")]
    [DataMember(Name = "input", Order = 4), JsonPropertyName("input"), JsonPropertyOrder(4), YamlMember(Alias = "input", Order = 4)]
    public virtual InputDataModelDefinition? Input { get; set; }
}
