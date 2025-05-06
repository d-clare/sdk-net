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
/// Represents the definition of a knowledge graph used for storing and traversing structured relationships between entities.
/// </summary>
[Description("Represents the definition of a knowledge graph used for storing and traversing structured relationships between entities.")]
[DataContract]
public record KnowledgeGraphDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the definition of the graph provider to use.
    /// </summary>
    [Description("The definition of the graph provider to use.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual KnowledgeGraphProviderDefinition Provider { get; set; } = null!;

    /// <inheritdoc/>
    public override string ToString() => Provider.ToString();

}

