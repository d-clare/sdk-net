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
/// Represents the definition of an embedding model used to generate vector representations
/// of input text for use in semantic search, similarity comparison, or knowledge retrieval.
/// </summary>
[Description("Represents the definition of an embedding model used to generate vector representations of input text.")]
[DataContract]
public record EmbeddingModelDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the definition of the embedding model provider.
    /// </summary>
    [Description("The definition of the embedding model provider.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual OneOf<EmbeddingModelProviderDefinition, string> Provider { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the embedding model to use.
    /// </summary>
    [Description("The name of the embedding model to use.")]
    [Required, MinLength(1)]
    [DataMember(Name = "model", Order = 2), JsonPropertyName("model"), JsonPropertyOrder(2), YamlMember(Alias = "model", Order = 2)]
    public virtual string Model { get; set; } = null!;

    /// <summary>
    /// Gets or sets the dimensionality of the vectors produced by the embedding model.
    /// </summary>
    [Description("The dimensionality of the vectors produced by the embedding model.")]
    [Required]
    [DataMember(Name = "dimensions", Order = 3), JsonPropertyName("dimensions"), JsonPropertyOrder(3), YamlMember(Alias = "dimensions", Order = 3)]
    public virtual uint Dimensions { get; set; }

    /// <summary>
    /// Gets or sets the definition of the API used to invoke the embedding model.
    /// </summary>
    [Description("The definition of the API used to invoke the embedding model.")]
    [Required]
    [DataMember(Name = "api", Order = 4), JsonPropertyName("api"), JsonPropertyOrder(4), YamlMember(Alias = "api", Order = 4)]
    public virtual EmbeddingApiDefinition Api { get; set; } = null!;

    /// <inheritdoc/>
    public override string ToString() => $"{Provider} - {Model}";

}
