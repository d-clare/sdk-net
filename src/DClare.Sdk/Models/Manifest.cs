// Copyright � 2025-Present The DClare Authors
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
/// Represents the definition of the application metadata, reusable components such as agents, kernels, and secrets, and specifies how these components are exposed through interfaces like A2A or HTTP. It acts as the central entry point for declaring and orchestrating agent behavior
/// </summary>
[DataContract]
public record Manifest
{

    /// <summary>
    /// Gets/sets an object used to describe the manifest
    /// </summary>
    [Required]
    [DataMember(Name = "metadata", Order = 1), JsonPropertyName("metadata"), JsonPropertyOrder(1), YamlMember(Alias = "metadata", Order = 1)]
    public virtual ManifestMetadata Metadata { get; set; } = null!;

    /// <summary>
    /// Gets/sets a collection of reusable components, if any, that can be referenced throughout the manifest
    /// </summary>
    [DataMember(Name = "components", Order = 2), JsonPropertyName("components"), JsonPropertyOrder(2), YamlMember(Alias = "components", Order = 2)]
    public virtual ComponentCollectionDefinition? Components { get; set; }

    /// <summary>
    /// Gets/sets a collection of interfaces through which the application's components are made accessible
    /// </summary>
    [Required]
    [DataMember(Name = "interfaces", Order = 3), JsonPropertyName("interfaces"), JsonPropertyOrder(3), YamlMember(Alias = "interfaces", Order = 3)]
    public virtual InterfaceCollectionDefinition Interfaces { get; set; } = null!;

}