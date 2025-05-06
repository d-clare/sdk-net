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
/// Represents the configuration for an Agent-to-Agent (A2A) communication channel.
/// </summary>
[Description("Represents the configuration for an Agent-to-Agent (A2A) communication channel.")]
[DataContract]
public record A2ACommunicationChannelDefinition
{

    /// <summary>
    /// Gets or sets the endpoint definition used to communicate with the remote agent.
    /// </summary>
    [Description("The endpoint definition used to communicate with the remote agent.")]
    [Required]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual OneOf<EndpointDefinition, Uri> Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets or sets the unique name used to identify the remote agent.
    /// </summary>
    [Description("The unique name used to identify the remote agent.")]
    [Required]
    [DataMember(Name = "name", Order = 2), JsonPropertyName("name"), JsonPropertyOrder(2), YamlMember(Alias = "name", Order = 2)]
    public virtual string? Name { get; set; }

}
