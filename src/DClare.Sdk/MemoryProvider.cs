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
/// Enumerates all supported conversation memory providers
/// </summary>
public static class MemoryProvider
{

    /// <summary>
    /// Indicates a file-based memory
    /// </summary>
    public const string File = "file";
    /// <summary>
    /// Indicates an in-memory (ephemeral) memory provider, useful for testing or short-lived sessions
    /// </summary>
    public const string Memory = "memory";
    /// <summary>
    /// Indicates a MongoDB-based memory
    /// </summary>
    public const string MongoDB = "mongodb";
    /// <summary>
    /// Indicates a Redis-based memory
    /// </summary>
    public const string Redis = "redis";
    /// <summary>
    /// Indicates a SQL-based memory
    /// </summary>
    public const string Sql = "sql";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return File;
        yield return Memory;
        yield return MongoDB;
        yield return Redis;
        yield return Sql;
    }

}
