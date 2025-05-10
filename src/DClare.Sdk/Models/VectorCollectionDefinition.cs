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
/// Represents the definition of a vector collection, including its unique identifier, the embedding model used to generate vectors, and the backing vector store used to persist and retrieve them.
/// </summary>
[Description("Represents the definition of a vector collection, including its unique identifier, the embedding model used to generate vectors, and the backing vector store used to persist and retrieve them.")]
[DataContract]
public record VectorCollectionDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the unique identifier of the collection within the vector store. This value determines the name of the collection as it is stored and queried in the backing vector database.
    /// </summary>
    [Description("The unique identifier of the collection within the vector store. This value determines the name of the collection as it is stored and queried in the backing vector database.")]
    [Required, MinLength(1)]
    [DataMember(Name = "id", Order = 1), JsonPropertyName("id"), JsonPropertyOrder(1), YamlMember(Alias = "id", Order = 1)]
    public virtual string Id { get; set; } = null!;

    /// <summary>
    /// Gets or sets the embedding model used to vectorize textual input.
    /// </summary>
    [Description("The embedding model used to vectorize text.")]
    [Required]
    [DataMember(Name = "embedding", Order = 2), JsonPropertyName("embedding"), JsonPropertyOrder(2), YamlMember(Alias = "embedding", Order = 2)]
    public virtual EmbeddingModelDefinition Embedding { get; set; } = null!;

    /// <summary>
    /// Gets or sets the vector store used to persist and retrieve embedded representations.
    /// </summary>
    [Description("The vector store used to store and retrieve vectorized knowledge.")]
    [Required]
    [DataMember(Name = "store", Order = 3), JsonPropertyName("store"), JsonPropertyOrder(3), YamlMember(Alias = "store", Order = 3)]
    public virtual VectorStoreDefinition Store { get; set; } = null!;

}