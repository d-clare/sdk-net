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
/// Represents the definition of a workflow
/// </summary>
[DataContract]
public record WorkflowDefinition
{

    /// <summary>
    /// Gets/sets the metadata used to describe the workflow
    /// </summary>
    [Required]
    [DataMember(Name = "metadata", Order = 1), JsonPropertyName("metadata"), JsonPropertyOrder(1), YamlMember(Alias = "metadata", Order = 1)]
    public virtual WorkflowDefinitionMetadata Metadata { get; set; } = null!;

    /// <summary>
    /// Gets/sets the workflow's reusable component collection, if any
    /// </summary>
    [DataMember(Name = "components", Order = 2), JsonPropertyName("components"), JsonPropertyOrder(2), YamlMember(Alias = "components", Order = 2)]
    public virtual ComponentCollectionDefinition? Components { get; set; }

}
