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
/// Represents the definition of a task that executes a set of subtasks iteratively for each element in a collection or range.
/// </summary>
[Description("Represents the definition of a task that executes a set of subtasks iteratively for each element in a collection or range.")]
[DataContract]
public record ForTaskDefinition 
    : TaskDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Type => TaskType.For;

    /// <summary>
    /// Gets or sets the loop control definition specifying how the iteration is performed.
    /// </summary>
    [Description("The loop control definition specifying how the iteration is performed. This defines the input collection or range over which the loop iterates.")]
    [Required]
    [DataMember(Name = "for", Order = 1), JsonPropertyName("for"), JsonPropertyOrder(1), YamlMember(Alias = "for", Order = 1)]
    public virtual ForLoopDefinition For { get; set; } = null!;

    /// <summary>
    /// Gets or sets an optional runtime expression that acts as a conditional guard for the loop.
    /// </summary>
    [Description("An optional runtime expression evaluated at each iteration to determine whether the loop should continue executing.")]
    [DataMember(Name = "while", Order = 2), JsonPropertyName("while"), JsonPropertyOrder(2), YamlMember(Alias = "while", Order = 2)]
    public virtual string? While { get; set; }

    /// <summary>
    /// Gets or sets the tasks to execute during each iteration of the loop.
    /// </summary>
    [Description("The set of named tasks to execute during each iteration of the loop.")]
    [Required, MinLength(1)]
    [DataMember(Name = "do", Order = 3), JsonPropertyName("do"), JsonPropertyOrder(3), YamlMember(Alias = "do", Order = 3)]
    public virtual Map<string, TaskDefinition> Do { get; set; } = null!;

}
