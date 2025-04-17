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

namespace DClare.Sdk.Models.Processes;

/// <summary>
/// Represents an agentic process in which multiple agents perform their tasks sequentially with configurable selection and termination strategies
/// </summary>
[DataContract]
public record CollaborationAgenticProcessDefinition
{

    /// <summary>
    /// Gets/sets the collection of named agents that participate in this process
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "agents", Order = 1), JsonPropertyName("agents"), JsonPropertyOrder(1), YamlMember(Alias = "agents", Order = 1)]
    public virtual EquatableDictionary<string, AgentDefinition> Agents { get; set; } = [];

    /// <summary>
    /// Gets/sets the definition of the collaboration process's strategy, if any
    /// </summary>
    [Required]
    [DataMember(Name = "strategy", Order = 2), JsonPropertyName("strategy"), JsonPropertyOrder(2), YamlMember(Alias = "strategy", Order = 2)]
    public virtual CollaborationStrategyDefinition Strategy { get; set; } = null!;

}
