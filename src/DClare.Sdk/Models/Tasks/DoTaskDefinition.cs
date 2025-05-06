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
/// Represents a composite task that executes a set of named tasks either sequentially or in parallel.
/// </summary>
[Description("Represents a composite task that executes a set of named tasks either sequentially or in parallel.")]
[DataContract]
public record DoTaskDefinition
    : TaskDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Type => TaskType.Do;

    /// <summary>
    /// Gets or sets the tasks to execute in sequence. Must not be used together with 'simultaneously'.
    /// </summary>
    [Description("The tasks to execute in sequence. Must not be used together with 'simultaneously'.")]
    [DataMember(Name = "sequentially", Order = 1), JsonPropertyName("sequentially"), JsonPropertyOrder(1), YamlMember(Alias = "sequentially", Order = 1)]
    public virtual Map<string, TaskDefinition>? Sequentially { get; set; } = null!;

    /// <summary>
    /// Gets or sets the tasks to execute in parallel. Must not be used together with 'sequentially'.
    /// </summary>
    [Description("The tasks to execute in parallel. Must not be used together with 'sequentially'.")]
    [DataMember(Name = "simultaneously ", Order = 1), JsonPropertyName("simultaneously"), JsonPropertyOrder(1), YamlMember(Alias = "simultaneously", Order = 1)]
    public virtual Map<string, TaskDefinition>? Simultaneously { get; set; } = null!;

}
