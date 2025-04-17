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
/// Represents the definition of an agent's memory capability
/// </summary>
[DataContract]
public record AgentMemoryCapabilityDefinition
{

    /// <summary>
    /// Gets/sets the source of the agent's memory
    /// </summary>
    [Required]
    [DataMember(Name = "source", Order = 1), JsonPropertyName("source"), JsonPropertyOrder(1), YamlMember(Alias = "source", Order = 1)]
    public virtual MemoryDefinition Source { get; set; } = null!;

    /// <summary>
    /// Gets/sets an object, if any, that defines how memory is used to enrich the agent's prompt context
    /// </summary>
    [DataMember(Name = "inject", Order = 2), JsonPropertyName("inject"), JsonPropertyOrder(2), YamlMember(Alias = "inject", Order = 2)]
    public virtual AgentMemoryInjectionStrategyDefinition? Inject { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, that defines how the agent's output is persisted to memory
    /// </summary>
    [DataMember(Name = "store", Order = 3), JsonPropertyName("store"), JsonPropertyOrder(3), YamlMember(Alias = "store", Order = 3)]
    public virtual AgentMemoryStoragePolicyDefinition? Store { get; set; }

}
