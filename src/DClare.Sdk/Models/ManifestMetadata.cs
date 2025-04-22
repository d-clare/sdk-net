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
/// Represents the metadata used to describe a manifest
/// </summary>
[DataContract]
public record ManifestMetadata
{

    /// <summary>
    /// Gets/sets a unique, human-readable name used to identify the manifest in logs, dashboards, or registries
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets/sets a brief summary explaining the purpose or scope of the manifest. Useful for documentation or discovery
    /// </summary>
    [DataMember(Name = "description", Order = 2), JsonPropertyName("description"), JsonPropertyOrder(2), YamlMember(Alias = "description", Order = 2)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets/sets the manifest's version, following semantic versioning 2.0.0
    /// </summary>
    [Required, RegularExpression("^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$")]
    [DataMember(Name = "version", Order = 3), JsonPropertyName("version"), JsonPropertyOrder(3), YamlMember(Alias = "version", Order = 3, ScalarStyle = ScalarStyle.SingleQuoted)]
    public virtual string Version { get; set; } = null!;

    /// <summary>
    /// Gets/sets an optional list of keywords or labels used to categorize or filter manifests by theme, domain, or capability
    /// </summary>
    [DataMember(Name = "tags", Order = 4), JsonPropertyName("tags"), JsonPropertyOrder(4), YamlMember(Alias = "tags", Order = 4)]
    public virtual EquatableList<string>? Tags { get; set; }

}
