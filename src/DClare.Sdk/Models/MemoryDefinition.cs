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
/// Represents the definition of a memory capability
/// </summary>
[DataContract]
public record MemoryDefinition
{

    /// <summary>
    /// Gets/sets the definition of a file-backed memory that loads entries from structured files in the local or remote file system
    /// </summary>
    [DataMember(Name = "file", Order = 1), JsonPropertyName("file"), JsonPropertyOrder(1), YamlMember(Alias = "file", Order = 1)]
    public virtual FileMemoryDefinition? File { get; set; }

    /// <summary>
    /// Gets/sets the definition of a key-value store memory that retrieves entries based on keys or tags
    /// </summary>
    [DataMember(Name = "keyvalue", Order = 1), JsonPropertyName("keyvalue"), JsonPropertyOrder(1), YamlMember(Alias = "keyvalue", Order = 1)]
    public virtual KeyValueMemoryDefinition? KeyValue { get; set; }

    /// <summary>
    /// Gets/sets the definition of a static memory that returns predefined values without kernel lookup
    /// </summary>
    [DataMember(Name = "static", Order = 1), JsonPropertyName("static"), JsonPropertyOrder(1), YamlMember(Alias = "static", Order = 1)]
    public virtual StaticMemoryDefinition? Static { get; set; }

    /// <summary>
    /// Gets/sets the definition of a vector memory that retrieves entries using semantic similarity and vector search
    /// </summary>
    [DataMember(Name = "vector", Order = 1), JsonPropertyName("vector"), JsonPropertyOrder(1), YamlMember(Alias = "vector", Order = 1)]
    public virtual VectorMemoryDefinition? Vector { get; set; }

    /// <summary>
    /// Gets the memory's type based on which definition is present
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => File != null ? MemoryType.File : KeyValue != null ? MemoryType.KeyValue : Static != null ? MemoryType.Static : Vector != null ? MemoryType.Vector : null!;

}
