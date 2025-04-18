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
/// Configuration settings specific to the A2A (Agent-to-Agent) communication protocol.
/// </summary>
[DataContract]
public record A2AChannelConfiguration
{

    /// <summary>
    /// Gets/sets the endpoint of the remote host used to perform A2A agent discovery<para></para>
    /// This is not the agent’s direct message endpoint, but rather the host through which the agent is resolved
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual EndpointDefinition Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets/sets the name of the remote agent to select from the A2A discovery endpoint, in case multiple agents are available at the same host
    /// </summary>
    [Required]
    [DataMember(Name = "name", Order = 2), JsonPropertyName("name"), JsonPropertyOrder(2), YamlMember(Alias = "name", Order = 2)]
    public virtual string? Name { get; set; }

}