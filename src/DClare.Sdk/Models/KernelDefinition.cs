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
/// Represents the configuration of a kernel system capable of performing AI inference operations, such as language model completions, chat interactions, or vector embeddings
/// </summary>
[DataContract]
public record KernelDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets/sets a reference to the kernel definition to extend, if any
    /// </summary>
    [DataMember(Name = "extends", Order = 1), JsonPropertyName("extends"), JsonPropertyOrder(1), YamlMember(Alias = "extends", Order = 1)]
    public virtual string? Extends { get; set; }

    /// <summary>
    /// Gets/sets the configuration of the kernel's reasoning capability, if any
    /// </summary>
    [DataMember(Name = "reasoning", Order = 2), JsonPropertyName("reasoning"), JsonPropertyOrder(2), YamlMember(Alias = "reasoning", Order = 2)]
    public virtual ReasoningCapabilityDefinition? Reasoning { get; set; }

    /// <summary>
    /// Gets/sets the configuration of the kernel's embedding capability, if any
    /// </summary>
    [DataMember(Name = "embedding", Order = 3), JsonPropertyName("embedding"), JsonPropertyOrder(3), YamlMember(Alias = "embedding", Order = 3)]
    public virtual EmbeddingCapabilityDefinition? Embedding { get; set; }

    /// <summary>
    /// Gets/sets a key/definition mapping of the toolsets available to the kernel
    /// </summary>
    [DataMember(Name = "toolsets", Order = 4), JsonPropertyName("toolsets"), JsonPropertyOrder(4), YamlMember(Alias = "toolsets", Order = 4)]
    public virtual EquatableDictionary<string, ToolsetDefinition>? Toolsets { get; set; }

}
