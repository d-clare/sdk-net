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
/// Represents the definition of the transport to use to connect to an MCP server
/// </summary>
[DataContract]
public record McpTransportDefinition
{

    /// <summary>
    /// Gets/sets the definition of an HTTP transport for the Model Context Protocol
    /// </summary>
    [DataMember(Name = "http", Order = 1), JsonPropertyName("http"), JsonPropertyOrder(1), YamlMember(Alias = "http", Order = 1)]
    public virtual McpHttpTransportDefinition? Http { get; set; }

    /// <summary>
    /// Gets/sets the definition of an STDIO transport for the Model Context Protocol
    /// </summary>
    [DataMember(Name = "stdio", Order = 1), JsonPropertyName("stdio"), JsonPropertyOrder(1), YamlMember(Alias = "stdio", Order = 1)]
    public virtual McpStdioTransportDefinition? Stdio { get; set; }

    /// <summary>
    /// Gets/sets additional transport-specific configuration, if any
    /// </summary>
    [DataMember(Name = "options", Order = 2), JsonPropertyName("options"), JsonPropertyOrder(2), YamlMember(Alias = "options", Order = 2)]
    public virtual EquatableDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// Gets the MCP transport's type based on which definition is present (either `Http` or `Stdio`)
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Http != null ? McpTransportType.Http : Stdio != null ? McpTransportType.Stdio : null!;

}
