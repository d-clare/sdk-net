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
/// Represents the definition of a toolset
/// </summary>
[DataContract]
public record ToolsetDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets/sets the definition of a toolset based on the Model Context Protocol (MCP)
    /// </summary>
    [DataMember(Name = "mcp", Order = 1), JsonPropertyName("mcp"), JsonPropertyOrder(1), YamlMember(Alias = "mcp", Order = 1)]
    public virtual McpToolsetDefinition? Mcp { get; set; }

    /// <summary>
    /// Gets/sets the definition of a toolset based on an OpenAPI specification document
    /// </summary>
    [DataMember(Name = "openapi", Order = 1), JsonPropertyName("openapi"), JsonPropertyOrder(1), YamlMember(Alias = "openapi", Order = 1)]
    public virtual OpenApiToolsetDefinition? OpenApi { get; set; }

    /// <summary>
    /// Gets the toolset's type based on which definition is present (either MCP or OpenAPI)
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Mcp != null ? ToolsetType.Mcp : OpenApi != null ? ToolsetType.OpenApi : null!;

}
