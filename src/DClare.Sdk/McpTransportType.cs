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
/// Enumerates all supported transport types for the Model Context Protocol (MCP).
/// </summary>
[Description("Enumerates all supported transport types for the Model Context Protocol (MCP).")]
public static class McpTransportType
{

    /// <summary>
    /// Indicates a transport type that communicates via HTTP.
    /// </summary>
    public const string Http = "http";
    /// <summary>
    /// Indicates a transport type that communicates via standard input/output (STDIO).
    /// </summary>
    public const string Stdio = "stdio";

    /// <summary>
    /// Returns a collection of all supported MCP transport types.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{T}"/> of supported transport type identifiers.</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Http;
        yield return Stdio;
    }

}
