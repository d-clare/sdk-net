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

using YamlDotNet.Core;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents an object used to describe an agentic workflow.
/// </summary>
[Description("Represents an object used to describe an agentic workflow.")]
[DataContract]
public record WorkflowDefinitionMetadata
{

    /// <summary>
    /// Gets or sets the workflow's name. Must conform to the DNS label specification (RFC 1123): lower-case alphanumeric characters, hyphens ('-'), and periods ('.'), starting and ending with an alphanumeric character.
    /// </summary>
    [Description("The workflow's name. Must conform to the DNS label specification (RFC 1123): lower-case alphanumeric characters, hyphens ('-'), and periods ('.'), starting and ending with an alphanumeric character.")]
    [Required, StringLength(DnsLabel.MaxLength, MinimumLength = DnsLabel.MinLength), RegularExpression(DnsLabel.Regex)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the workflow's semantic version.
    /// </summary>
    [Description("The workflow's semantic version.")]
    [Required, RegularExpression("^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$")]
    [DataMember(Name = "version", Order = 2), JsonPropertyName("version"), JsonPropertyOrder(2), YamlMember(Alias = "version", Order = 2, ScalarStyle = ScalarStyle.SingleQuoted)]
    public virtual string Version { get; set; } = null!;

    /// <summary>
    /// Gets or sets the description of the workflow, which is intended to provide context or documentation for the workflow. Supports Markdown.
    /// </summary>
    [Description("The description of the workflow, which is intended to provide context or documentation for the workflow. Supports Markdown.")]
    [DataMember(Name = "description", Order = 3), JsonPropertyName("description"), JsonPropertyOrder(3), YamlMember(Alias = "description", Order = 3)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets/sets an optional list of keywords or labels used to categorize or filter manifests by theme, domain, or capability.
    /// </summary>
    [Description("An optional list of keywords or labels used to categorize or filter manifests by theme, domain, or capability.")]
    [DataMember(Name = "tags", Order = 4), JsonPropertyName("tags"), JsonPropertyOrder(4), YamlMember(Alias = "tags", Order = 4)]
    public virtual EquatableList<string>? Tags { get; set; }

}
