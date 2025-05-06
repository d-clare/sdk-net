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

namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported toolset types used to describe external tool capabilities.
/// </summary>
[Description("Enumerates all supported toolset types used to describe external tool capabilities.")]
public static class ToolsetType
{

    /// <summary>
    /// Indicates a toolset defined using the Model Context Protocol (MCP).
    /// </summary>
    public const string Mcp = "mcp";
    /// <summary>
    /// Indicates a toolset defined using an OpenAPI specification.
    /// </summary>
    public const string OpenApi = "openapi";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported toolset type identifiers.
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/> of supported toolset types.</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Mcp;
        yield return OpenApi;
    }

}
