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
/// Represents the definition of protocol-specific configuration options for communicating with a remote agent
/// </summary>
[DataContract]
public record AgentCommunicationChannelDefinition
{

    /// <summary>
    /// Gets/sets the configuration for the Agent-to-Agent (A2A) communication protocol
    /// </summary>
    [DataMember(Name = "a2a", Order = 1), JsonPropertyName("a2a"), JsonPropertyOrder(1), YamlMember(Alias = "a2a", Order = 1)]
    public virtual A2AChannelConfiguration? A2A { get; set; }

    /// <summary>
    /// Gets the agent's type
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => A2A != null ? AgentCommunicationChannelType.A2A : null!;

}
