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
    /// Gets or sets the human-readable title of the agent.
    /// </summary>
    [Description("The human-readable title of the agent.")]
    [DataMember(Name = "title", Order = 1), JsonInclude, JsonPropertyName("title"), JsonPropertyOrder(1), YamlMember(Alias = "title", Order = 1)]
    public virtual string? Title { get; set; }

    /// <summary>
    /// Gets or sets an optional human-readable description of the agent's purpose or role.
    /// </summary>
    [Description("Optional human-readable description of the agent's purpose or role.")]
    [DataMember(Name = "description", Order = 2), JsonInclude, JsonPropertyName("description"), JsonPropertyOrder(2), YamlMember(Alias = "description", Order = 2)]
    public virtual string? Description { get; set; }

    /// <summary>
    /// Gets or sets a reference to the agent's documentation, either as a URI or an inline description.
    /// </summary>
    [Description("A reference to the agent's documentation, either as a URI or an inline description.")]
    [DataMember(Name = "documentation", Order = 3), JsonInclude, JsonPropertyName("documentation"), JsonPropertyOrder(3), YamlMember(Alias = "documentation", Order = 3)]
    public virtual OneOf<Uri, string>? Documentation { get; set; }

    /// <summary>
    /// Gets or sets the union value representing either a prompt template or a raw instruction string.
    /// </summary>
    [Required]
    [Description("Defines the agent's instructions, either as a raw string or a prompt template.")]
    [DataMember(Name = "instructions", Order = 4), JsonInclude, JsonPropertyName("instructions"), JsonPropertyOrder(4), YamlMember(Alias = "instructions", Order = 4)]
    public virtual OneOf<PromptTemplateDefinition, string> Instructions { get; set; } = null!;

    /// <summary>
    /// Gets or sets the dictionary of named skills the agent supports.
    /// </summary>
    [Description("A dictionary of named skills the agent supports.")]
    [DataMember(Name = "skills", Order = 5), JsonInclude, JsonPropertyName("skills"), JsonPropertyOrder(5), YamlMember(Alias = "skills", Order = 5)]
    public virtual EquatableDictionary<string, AgentSkillDefinition>? Skills { get; set; }

    /// <summary>
    /// Gets or sets the memory definition used by the agent, if any.
    /// </summary>
    [Description("The memory configuration used by the agent, if any.")]
    [DataMember(Name = "memory", Order = 6), JsonInclude, JsonPropertyName("memory"), JsonPropertyOrder(6), YamlMember(Alias = "memory", Order = 6)]
    public virtual MemoryDefinition? Memory { get; set; }

    /// <summary>
    /// Gets or sets the knowledge configuration used by the agent, if any.
    /// </summary>
    [Description("The knowledge configuration used by the agent, if any.")]
    [DataMember(Name = "knowledge", Order = 7), JsonInclude, JsonPropertyName("knowledge"), JsonPropertyOrder(7), YamlMember(Alias = "knowledge", Order = 7)]
    public virtual KnowledgeDefinition? Knowledge { get; set; }

    /// <summary>
    /// Gets or sets the definition of the LLM used by the agent.
    /// </summary>
    [Required]
    [Description("The definition of the LLM used by the agent.")]
    [DataMember(Name = "llm", Order = 8), JsonInclude, JsonPropertyName("llm"), JsonPropertyOrder(8), YamlMember(Alias = "llm", Order = 8)]
    public virtual LlmDefinition Llm { get; set; } = null!;

    /// <summary>
    /// Gets or sets the toolsets the agent is capable of using.
    /// </summary>
    [Description("The toolsets the agent is capable of using.")]
    [DataMember(Name = "toolsets", Order = 9), JsonInclude, JsonPropertyName("toolsets"), JsonPropertyOrder(9), YamlMember(Alias = "toolsets", Order = 9)]
    public virtual EquatableDictionary<string, ToolsetDefinition>? Toolsets { get; set; }

}