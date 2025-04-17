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
/// Represents the definition of an hosted agent
/// </summary>
[DataContract]
public record HostedAgentDefinition
{

    /// <summary>
    /// Gets/sets a reference to the agent definition to extend, if any
    /// </summary>
    [DataMember(Name = "extends", Order = 1), JsonPropertyName("extends"), JsonPropertyOrder(1), YamlMember(Alias = "extends", Order = 1)]
    public virtual string? Extends { get; set; }

    /// <summary>
    /// Gets/sets a short human-readable description of the agent's role or purpose, which is used for documentation, UI display, and prompt composition
    /// </summary>
    [DataMember(Name = "description", Order = 2), JsonPropertyName("description"), JsonPropertyOrder(2), YamlMember(Alias = "description", Order = 2)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets/sets the specific instructions that guide the agent's behavior
    /// </summary>
    [DataMember(Name = "instructions", Order = 3), JsonPropertyName("instructions"), JsonPropertyOrder(3), YamlMember(Alias = "instructions", Order = 3)]
    public virtual string? Instructions { get; set; }

    /// <summary>
    /// Gets/sets a list containing the agent's skills, if any
    /// </summary>
    [DataMember(Name = "skills", Order = 4), JsonPropertyName("skills"), JsonPropertyOrder(4), YamlMember(Alias = "skills", Order = 4)]
    public virtual EquatableList<AgentSkillDefinition>? Skills { get; set; }

    /// <summary>
    /// Gets/sets the definition of the kernel that powers the agent's capabilities
    /// </summary>
    [Required]
    [DataMember(Name = "kernel", Order = 5), JsonPropertyName("kernel"), JsonPropertyOrder(5), YamlMember(Alias = "kernel", Order = 5)]
    public virtual KernelDefinition Kernel { get; set; } = null!;

    /// <summary>
    /// Gets/sets the definition of the agent's memory, if any
    /// </summary>
    [DataMember(Name = "memory", Order = 6), JsonPropertyName("memory"), JsonPropertyOrder(6), YamlMember(Alias = "memory", Order = 6)]
    public virtual AgentMemoryCapabilityDefinition? Memory { get; set; }

}
