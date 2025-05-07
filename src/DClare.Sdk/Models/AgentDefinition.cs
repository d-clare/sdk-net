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
/// Represents the definition of an AI agent
/// </summary>
[Description("Represents the definition of an AI agent")]
[DataContract]
public record AgentDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets the agent's type
    /// </summary>
    [Description("The agent's type")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Hosted != null ? AgentType.Hosted : Remote != null ? AgentType.Remote : null!;

    /// <summary>
    /// Gets or sets the configuration for an hosted agent
    /// </summary>
    [Description("The configuration for an hosted agent")]
    [DataMember(Name = "hosted", Order = 1), JsonPropertyName("hosted"), JsonPropertyOrder(1), YamlMember(Alias = "hosted", Order = 1)]
    public virtual HostedAgentDefinition? Hosted { get; set; }

    /// <summary>
    /// Gets or sets the configuration for a remote agent
    /// </summary>
    [Description("The configuration for a remote agent")]
    [DataMember(Name = "remote", Order = 1), JsonPropertyName("remote"), JsonPropertyOrder(1), YamlMember(Alias = "remote", Order = 1)]
    public virtual RemoteAgentDefinition? Remote { get; set; }

}
