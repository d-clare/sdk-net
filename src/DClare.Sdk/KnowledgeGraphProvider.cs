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
/// Enumerates all supported graph providers used for knowledge graph traversal and storage.
/// </summary>
[Description("Enumerates all supported graph providers used for knowledge graph traversal and storage.")]
public static class KnowledgeGraphProvider
{

    /// <summary>
    /// ArangoDB graph database.
    /// </summary>
    public const string ArangoDb = "arangodb";
    /// <summary>
    /// AWS Neptune graph database.
    /// </summary>
    public const string Neptune = "neptune";
    /// <summary>
    /// Neo4j graph database.
    /// </summary>
    public const string Neo4j = "neo4j";

    /// <summary>
    /// Returns a list of all supported graph provider identifiers.
    /// </summary>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return ArangoDb;
        yield return Neptune;
        yield return Neo4j;
    }
}
