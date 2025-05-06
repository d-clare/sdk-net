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
/// Enumerates core strategies for managing memory.
/// </summary>
public static class MemoryStrategy
{

    /// <summary>
    /// Retains the full conversation history.
    /// </summary>
    public const string Full = "full";
    /// <summary>
    /// Summarizes previous messages into a compressed representation.
    /// </summary>
    public const string Summary = "summary";
    /// <summary>
    /// Keeps a fixed-size window of recent messages.
    /// </summary>
    public const string Window = "window";

    /// <summary>
    /// Returns all supported memory strategies.
    /// </summary>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Full;
        yield return Summary;
        yield return Window;
    }

}
