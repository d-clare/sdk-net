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
/// Represents the definition of the client to use to connect to an MCP server
/// </summary>
[DataContract]
public record McpClientDefinition
{

    /// <summary>
    /// Gets/sets the definition of the client implementation to use to connect to an MCP server
    /// </summary>
    [Required]
    [DataMember(Name = "implementation", Order = 1), JsonPropertyName("implementation"), JsonPropertyOrder(1), YamlMember(Alias = "implementation", Order = 1)]
    public virtual McpClientImplementationDefinition Implementation { get; set; } = null!;

    /// <summary>
    /// Gets/sets the version of the MCP protocol to use
    /// </summary>
    [Required, DefaultValue(McpProtocolVersion.v20241105)]
    [DataMember(Name = "protocolVersion", Order = 1), JsonPropertyName("protocolVersion"), JsonPropertyOrder(1), YamlMember(Alias = "protocolVersion", Order = 1)]
    public virtual string ProtocolVersion { get; set; } = McpProtocolVersion.v20241105;

    /// <summary>
    /// Gets/sets the duration, if any, after which requests to the MCP tool time out
    /// </summary>
    [DataMember(Name = "timeout", Order = 3), JsonInclude, JsonPropertyName("timeout"), JsonPropertyOrder(3), YamlMember(Alias = "timeout", Order = 3)]
    public virtual Duration? Timeout { get; set; }

}
