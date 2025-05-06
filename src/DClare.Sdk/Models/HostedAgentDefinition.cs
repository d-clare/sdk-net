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
/// Represents the definition of a hosted AI agent, including its instructions, skills, memory, knowledge, and runtime.
/// </summary>
[Description("Represents the definition of a hosted AI agent, including its instructions, skills, memory, knowledge, and runtime.")]
[DataContract]
public record HostedAgentDefinition
{

    /// <summary>
    /// Gets or sets an optional human-readable description of the agent's purpose or role.
    /// </summary>
    [Description("Optional human-readable description of the agent's purpose or role.")]
    [DataMember(Name = "description", Order = 1), JsonInclude, JsonPropertyName("description"), JsonPropertyOrder(1), YamlMember(Alias = "description", Order = 1)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets or sets the union value representing either a prompt template or a raw instruction string.
    /// </summary>
    [Required]
    [Description("Defines the agent's instructions, either as a raw string or a prompt template.")]
    [DataMember(Name = "instructions", Order = 2), JsonInclude, JsonPropertyName("instructions"), JsonPropertyOrder(2), YamlMember(Alias = "instructions", Order = 2)]
    public virtual OneOf<PromptTemplateDefinition, string> Instructions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the dictionary of named skills the agent supports.
    /// </summary>
    [Description("A dictionary of named skills the agent supports.")]
    [DataMember(Name = "skills", Order = 3), JsonInclude, JsonPropertyName("skills"), JsonPropertyOrder(3), YamlMember(Alias = "skills", Order = 3)]
    public virtual EquatableDictionary<string, AgentSkillDefinition>? Skills { get; set; }

    /// <summary>
    /// Gets or sets the memory definition used by the agent, if any.
    /// </summary>
    [Description("The memory configuration used by the agent, if any.")]
    [DataMember(Name = "memory", Order = 4), JsonInclude, JsonPropertyName("memory"), JsonPropertyOrder(4), YamlMember(Alias = "memory", Order = 4)]
    public virtual MemoryDefinition? Memory { get; set; }

    /// <summary>
    /// Gets or sets the knowledge configuration used by the agent, if any.
    /// </summary>
    [Description("The knowledge configuration used by the agent, if any.")]
    [DataMember(Name = "knowledge", Order = 5), JsonInclude, JsonPropertyName("knowledge"), JsonPropertyOrder(5), YamlMember(Alias = "knowledge", Order = 5)]
    public virtual KnowledgeDefinition? Knowledge { get; set; }

    /// <summary>
    /// Gets or sets the definition of the LLM used by the agent.
    /// </summary>
    [Required]
    [Description("The definition of the LLM used by the agent.")]
    [DataMember(Name = "llm", Order = 6), JsonInclude, JsonPropertyName("llm"), JsonPropertyOrder(6), YamlMember(Alias = "llm", Order = 6)]
    public virtual LlmDefinition Llm { get; set; } = null!;

    /// <summary>
    /// Gets or sets the toolsets the agent is capable of using.
    /// </summary>
    [Description("The toolsets the agent is capable of using.")]
    [DataMember(Name = "toolsets", Order = 7), JsonInclude, JsonPropertyName("toolsets"), JsonPropertyOrder(7), YamlMember(Alias = "toolsets", Order = 7)]
    public virtual EquatableDictionary<string, ToolsetDefinition>? Toolsets { get; set; }

}