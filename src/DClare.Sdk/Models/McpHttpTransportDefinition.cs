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
/// Represents the definition of an HTTP transport for the Model Context Protocol (MCP).
/// </summary>
[Description("Represents the definition of an HTTP transport for the Model Context Protocol (MCP).")]
[DataContract]
public record McpHttpTransportDefinition
{

    /// <summary>
    /// Gets or sets the endpoint used to connect to the MCP server.
    /// </summary>
    [Description("The endpoint used to connect to the MCP server.")]
    [Required]
    [DataMember(Name = "endpoint", Order = 1), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual OneOf<EndpointDefinition, Uri> Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets or sets a key/value mapping of the HTTP headers to send with the request, if any.
    /// </summary>
    [Description("A dictionary of HTTP headers to send when connecting to the MCP server.")]
    [DataMember(Name = "headers", Order = 2), JsonInclude, JsonPropertyName("headers"), JsonPropertyOrder(2), YamlMember(Alias = "headers", Order = 2)]
    public virtual EquatableDictionary<string, string>? Headers { get; set; }

}

