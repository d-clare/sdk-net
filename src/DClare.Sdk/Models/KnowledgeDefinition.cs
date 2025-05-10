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
/// Represents the knowledge configuration used by the agent, including embeddings, vector retrieval, and knowledge graphs.
/// </summary>
[Description("Represents the knowledge configuration used by the agent, including embeddings, vector retrieval, and knowledge graphs.")]
[DataContract]
public record KnowledgeDefinition
{

    /// <summary>
    /// Gets or sets the vector record collections available to the agent, each defined by its embedding model and backing vector store.
    /// </summary>
    [Description("The vector record collections, if any, available to the agent, each defined by its embedding model and backing vector store.")]
    [DataMember(Name = "vectors", Order = 1), JsonPropertyName("vectors"), JsonPropertyOrder(1), YamlMember(Alias = "vectors", Order = 1)]
    public virtual EquatableDictionary<string, VectorCollectionDefinition>? Vectors { get; set; }

    /// <summary>
    /// Gets or sets the knowledge graphs available to the agent, used for concept resolution and relationship traversal.
    /// </summary>
    [Description("The knowledge graphs available to the agent, used for concept resolution and relationship traversal.")]
    [DataMember(Name = "graph", Order = 2), JsonPropertyName("graph"), JsonPropertyOrder(2), YamlMember(Alias = "graph", Order = 2)]
    public virtual EquatableDictionary<string, KnowledgeGraphDefinition>? Graphs { get; set; }

}
