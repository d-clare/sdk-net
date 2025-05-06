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
/// Represents the definition of an agentic workflow.
/// </summary>
[Description("Represents the definition of an agentic workflow.")]
[DataContract]
public record WorkflowDefinition
{

    /// <summary>
    /// Gets or sets the metadata used to describe with the workflow definition.
    /// </summary>
    [Description("The metadata used to describe with the workflow definition.")]
    [Required]
    [DataMember(Name = "metadata", Order = 1), JsonPropertyName("metadata"), JsonPropertyOrder(1), YamlMember(Alias = "metadata", Order = 1)]
    public virtual WorkflowDefinitionMetadata Metadata { get; set; } = null!;

    /// <summary>
    /// Gets or sets a collection of reusable components, if any, that can be referenced within the workflow.
    /// </summary>
    [Description("A collection of reusable components, if any, that can be referenced within the workflow.")]
    [DataMember(Name = "components", Order = 2), JsonPropertyName("components"), JsonPropertyOrder(2), YamlMember(Alias = "components", Order = 2)]
    public virtual ComponentCollectionDefinition? Components { get; set; }

    /// <summary>
    /// Gets or sets the tasks to execute as part of the workflow. The key represents the task name, and the value is its definition.
    /// </summary>
    [Description("The tasks to execute as part of the workflow. The key represents the task name, and the value is its definition.")]
    [Required, MinLength(1)]
    [DataMember(Name = "do", Order = 3), JsonPropertyName("do"), JsonPropertyOrder(3), YamlMember(Alias = "do", Order = 3)]
    public virtual Map<string, TaskDefinition> Do { get; set; } = null!;

}
