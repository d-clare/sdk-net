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
/// Represents the definition of a toolset based on the Model Context Protocol (MCP)
/// </summary>
[DataContract]
public record McpToolsetDefinition
{

    /// <summary>
    /// Gets/sets the definition of the transport to use to connect to the MCP server
    /// </summary>
    [Required]
    [DataMember(Name = "transport", Order = 1), JsonPropertyName("transport"), JsonPropertyOrder(1), YamlMember(Alias = "transport", Order = 1)]
    public virtual McpTransportDefinition Transport { get; set; } = null!;

    /// <summary>
    /// Gets/sets the definition of the client to use to connect to the MCP server
    /// </summary>
    [Required]
    [DataMember(Name = "client", Order = 2), JsonPropertyName("client"), JsonPropertyOrder(2), YamlMember(Alias = "client", Order = 2)]
    public virtual McpClientDefinition Client { get; set; } = null!;

}
