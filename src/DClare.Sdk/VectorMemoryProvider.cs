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
/// Enumerates all supported vector memory providers
/// </summary>
public static class VectorMemoryProvider
{

    /// <summary>
    /// Indicates Chroma
    /// </summary>
    public const string Chroma = "chroma";
    /// <summary>
    /// Indicates Milvus
    /// </summary>
    public const string Milvus = "milvus";
    /// <summary>
    /// Indicates Pinecone
    /// </summary>
    public const string Pinecone = "pinecone";
    /// <summary>
    /// Indicates Qdrant
    /// </summary>
    public const string Qdrant = "qdrant";
    /// <summary>
    /// Indicates Redis
    /// </summary>
    public const string Redis = "redis";
    /// <summary>
    /// Indicates Weaviate
    /// </summary>
    public const string Weaviate = "weaviate";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Chroma;
        yield return Milvus;
        yield return Pinecone;
        yield return Qdrant;
        yield return Redis;
        yield return Weaviate;
    }

}
