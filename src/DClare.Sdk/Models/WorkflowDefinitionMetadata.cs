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
/// Represents an object used to describe an DClare workflow definition
/// </summary>
[DataContract]
public record WorkflowDefinitionMetadata
{

    /// <summary>
    /// Gets/sets the version of the DSL used to write the workflow
    /// </summary>
    [Required, RegularExpression(SemanticVersion.Pattern)]
    [DataMember(Name = "dsl", Order = 1), JsonPropertyName("dsl"), JsonPropertyOrder(1), YamlMember(Alias = "dsl", Order = 1)]
    public virtual string Dsl { get; set; } = null!;

    /// <summary>
    /// Gets/sets the namespace the workflow belongs to
    /// </summary>
    [Required, MinLength(NamingConvention.MinLength), MaxLength(NamingConvention.MaxLength)]
    [DataMember(Name = "namespace", Order = 2), JsonPropertyName("namespace"), JsonPropertyOrder(2), YamlMember(Alias = "namespace", Order = 2)]
    public virtual string Namespace { get; set; } = null!;

    /// <summary>
    /// Gets/sets the workflow's name
    /// </summary>
    [Required, MinLength(NamingConvention.MinLength), MaxLength(NamingConvention.MaxLength)]
    [DataMember(Name = "name", Order = 3), JsonPropertyName("name"), JsonPropertyOrder(3), YamlMember(Alias = "name", Order = 3)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets/sets the workflow's semantic version
    /// </summary>
    [Required, RegularExpression(SemanticVersion.Pattern)]
    [DataMember(Name = "version", Order = 4), JsonPropertyName("version"), JsonPropertyOrder(4), YamlMember(Alias = "version", Order = 4)]
    public virtual string Version { get; set; } = null!;

}