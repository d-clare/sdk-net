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
/// Enumerates all supported types of agent communication channels.
/// </summary>
public static class AgentCommunicationChannelType
{

    /// <summary>
    /// Indicates a communication channel using the Agent-to-Agent (A2A) protocol.
    /// </summary>
    public const string A2A = "a2a";

    /// <summary>
    /// Returns a collection of all supported communication channel types.
    /// </summary>
    /// <returns>An enumerable list of supported communication channel identifiers.</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return A2A;
    }

}
