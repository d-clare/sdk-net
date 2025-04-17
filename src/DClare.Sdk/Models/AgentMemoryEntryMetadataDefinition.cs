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
/// Represents the definition of the metadata of the memory entries produced by an agent's output
/// </summary>
[DataContract]
public record AgentMemoryEntryMetadataDefinition
{

    /// <summary>
    /// Gets/sets the definition of the strategy, if any, used to dynamically resolve the metadata of a memory entry
    /// </summary>
    [DataMember(Name = "resolution", Order = 1), JsonPropertyName("resolution"), JsonPropertyOrder(1), YamlMember(Alias = "resolution", Order = 1)]
    public virtual AgentMemoryMetadataResolutionStrategyDefinition? Resolution { get; set; }

    /// <summary>
    /// Gets/sets the static values to use when initializing a memory entry produced by the agent
    /// </summary>
    [DataMember(Name = "values", Order = 2), JsonPropertyName("values"), JsonPropertyOrder(2), YamlMember(Alias = "values", Order = 2)]
    public virtual MemoryEntryMetadata? Values { get; set; }

}
