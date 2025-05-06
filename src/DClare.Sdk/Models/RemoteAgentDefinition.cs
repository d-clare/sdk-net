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
/// Represents the definition of a remote AI agent.
/// </summary>
[Description("Represents the definition of a remote AI agent.")]
[DataContract]
public record RemoteAgentDefinition
{

    /// <summary>
    /// Gets or sets the communication channel used to reach the remote agent.
    /// </summary>
    [Description("The communication channel used to reach the remote agent.")]
    [Required]
    [DataMember(Name = "channel", Order = 1), JsonPropertyName("channel"), JsonPropertyOrder(1), YamlMember(Alias = "channel", Order = 1)]
    public virtual AgentCommunicationChannelDefinition Channel { get; set; } = null!;

}

