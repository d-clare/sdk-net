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
/// Represents an object that defines how an agent's output is persisted to memory
/// </summary>
[DataContract]
public record AgentMemoryStoragePolicyDefinition
{

    /// <summary>
    /// Gets/sets the optional template to apply per memory entry (e.g., "- {{ content }}").
    /// </summary>
    [DataMember(Name = "template", Order = 1), JsonPropertyName("template"), JsonPropertyOrder(1), YamlMember(Alias = "template", Order = 1)]
    public virtual string? Template { get; set; }  

    /// <summary>
    /// Gets/sets whether to include the prompt along with the agent's output.
    /// </summary>
    [DataMember(Name = "includePrompt", Order = 2), JsonPropertyName("includePrompt"), JsonPropertyOrder(2), YamlMember(Alias = "includePrompt", Order = 2)]
    public virtual bool? IncludePrompt { get; set; }

    /// <summary>
    /// Gets/sets the definition of the strategy, if any, to use to synthesize the agent's output before storing it into memory
    /// </summary>
    [DataMember(Name = "synthetization", Order = 3), JsonPropertyName("synthetization"), JsonPropertyOrder(3), YamlMember(Alias = "synthetization", Order =3)]
    public virtual AgentMemorySynthetizationStrategyDefinition? Synthetization { get; set; }

    /// <summary>
    /// Gets/sets the definition of the strategy, if any, used to synthesize the agent's output before storing it into memory
    /// </summary>
    [DataMember(Name = "metadata", Order = 4), JsonPropertyName("metadata"), JsonPropertyOrder(4), YamlMember(Alias = "metadata", Order = 4)]
    public virtual AgentMemoryEntryMetadataDefinition? Metadata { get; set; }

}