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
/// Represents the definition of an STDIO transport for the Model Context Protocol
/// </summary>
[DataContract]
public record McpStdioTransportDefinition
{

    /// <summary>
    /// Gets/sets the Command to execute the MCP tool
    /// </summary>
    [Required]
    [DataMember(Name = "command", Order = 1), JsonInclude, JsonPropertyName("command"), JsonPropertyOrder(1), YamlMember(Alias = "command", Order = 1)]
    public virtual string Command { get; set; } = null!;

    /// <summary>
    /// Gets/sets a list of arguments, if any, to pass to the command.
    /// </summary>
    [DataMember(Name = "arguments", Order = 2), JsonInclude, JsonPropertyName("arguments"), JsonPropertyOrder(2), YamlMember(Alias = "arguments", Order = 2)]
    public virtual EquatableList<string>? Arguments { get; set; }

}
