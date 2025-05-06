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
/// Represents the definition of a vector store provider used to store and retrieve vector embeddings.
/// </summary>
[Description("Represents the definition of a vector store provider used to store and retrieve vector embeddings.")]
[DataContract]
public record VectorStoreProviderDefinition
{

    /// <summary>
    /// Gets or sets the name of the vector store provider.
    /// </summary>
    [Description("The name of the vector store provider. Supported values include 'faiss', 'milvus', 'pinecone', 'qdrant', 'redis', 'vespa', and 'weaviate'.")]
    [Required, MinLength(1)]
    [AllowedValues(VectorStoreProvider.Faiss, VectorStoreProvider.Milvus, VectorStoreProvider.Pinecone, VectorStoreProvider.Pinecone, VectorStoreProvider.Qdrant, VectorStoreProvider.Redis, VectorStoreProvider.Vespa, VectorStoreProvider.Weaviate)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the optional provider-specific configuration settings.
    /// </summary>
    [Description("Optional configuration settings specific to the selected vector store provider.")]
    [DataMember(Name = "configuration", Order = 2), JsonPropertyName("configuration"), JsonPropertyOrder(2), YamlMember(Alias = "configuration", Order = 2)]
    public virtual EquatableDictionary<string, object>? Configuration { get; set; }

    /// <inheritdoc/>
    public override string ToString() => Name;

}