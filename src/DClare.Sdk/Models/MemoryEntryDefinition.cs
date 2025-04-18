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
/// Represents the definition of a memory entry
/// </summary>
[DataContract]
public record MemoryEntryDefinition
{

    /// <summary>
    /// Gets/sets the actual content or message of the memory entry
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "content", Order = 1), JsonPropertyName("content"), JsonPropertyOrder(1), YamlMember(Alias = "content", Order = 1)]
    public virtual string Content { get; set; } = null!;

    /// <summary>
    /// Gets/sets the metadata, if any, used to describe the memory entry
    /// </summary>
    [DataMember(Name = "metadata", Order = 2), JsonPropertyName("metadata"), JsonPropertyOrder(2), YamlMember(Alias = "metadata", Order = 2)]
    public virtual MemoryEntryMetadata? Metadata { get; set; }

}
