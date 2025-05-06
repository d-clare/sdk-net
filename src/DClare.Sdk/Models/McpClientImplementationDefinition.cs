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

using YamlDotNet.Core;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the client implementation to use to connect to an MCP server.
/// </summary>
[Description("Represents the definition of the client implementation to use to connect to an MCP server.")]
[DataContract]
public record McpClientImplementationDefinition
{

    /// <summary>
    /// Gets or sets the name of the client implementation.
    /// </summary>
    [Description("The name of the client implementation used to connect to the MCP server.")]
    [Required, MinLength(1)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the version of the client to use.
    /// </summary>
    [Description("The version of the client implementation to use.")]
    [Required, MinLength(1)]
    [DataMember(Name = "version", Order = 2), JsonPropertyName("version"), JsonPropertyOrder(2), YamlMember(Alias = "version", Order = 2, ScalarStyle = ScalarStyle.SingleQuoted)]
    public virtual string Version { get; set; } = null!;

}
