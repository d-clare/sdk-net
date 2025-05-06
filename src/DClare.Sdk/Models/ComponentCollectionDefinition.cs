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
/// Represents a collection of reusable components that can be referenced within a workflow.
/// </summary>
[Description("Represents a collection of reusable components that can be referenced within a workflow.")]
[DataContract]
public record ComponentCollectionDefinition
{

    /// <summary>
    /// Gets or sets a list containing the secrets, if any, used to securely configure components.
    /// </summary>
    [Description("A list containing the secrets, if any, used to securely configure components.")]
    [DataMember(Name = "secrets", Order = 1), JsonPropertyName("secrets"), JsonPropertyOrder(1), YamlMember(Alias = "secrets", Order = 1)]
    public virtual EquatableList<string>? Secrets { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable authentication policies, keyed by name.
    /// </summary>
    [Description("A mapping of reusable authentication policies, keyed by name.")]
    [DataMember(Name = "authentications", Order = 2), JsonPropertyName("authentications"), JsonPropertyOrder(2), YamlMember(Alias = "authentications", Order = 2)]
    public virtual EquatableDictionary<string, AuthenticationPolicyDefinition>? Authentications { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable toolsets, keyed by name.
    /// </summary>
    [Description("A mapping of reusable toolsets, keyed by name.")]
    [DataMember(Name = "toolsets", Order = 3), JsonPropertyName("toolsets"), JsonPropertyOrder(3), YamlMember(Alias = "toolsets", Order = 3)]
    public virtual EquatableDictionary<string, ToolsetDefinition>? Toolsets { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable prompt template definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable prompt template definitions, keyed by name.")]
    [DataMember(Name = "prompts", Order = 4), JsonPropertyName("prompts"), JsonPropertyOrder(4), YamlMember(Alias = "prompts", Order = 4)]
    public virtual EquatableDictionary<string, PromptTemplateDefinition>? Prompts { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable functions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable functions, keyed by name.")]
    [DataMember(Name = "functions", Order = 5), JsonPropertyName("functions"), JsonPropertyOrder(5), YamlMember(Alias = "functions", Order = 5)]
    public virtual EquatableDictionary<string, FunctionDefinition>? Functions { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable memory definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable memory definitions, keyed by name.")]
    [DataMember(Name = "memories", Order = 6), JsonPropertyName("memories"), JsonPropertyOrder(6), YamlMember(Alias = "memories", Order = 6)]
    public virtual EquatableDictionary<string, MemoryDefinition>? Memories { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable embedding model definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable embedding model definitions, keyed by name.")]
    [DataMember(Name = "embedders", Order = 7), JsonPropertyName("embedders"), JsonPropertyOrder(7), YamlMember(Alias = "embedders", Order = 7)]
    public virtual EquatableDictionary<string, EmbeddingModelDefinition>? Embedders { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable vector store definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable vector store definitions, keyed by name.")]
    [DataMember(Name = "vectors", Order = 8), JsonPropertyName("vectors"), JsonPropertyOrder(8), YamlMember(Alias = "vectors", Order = 8)]
    public virtual EquatableDictionary<string, VectorStoreDefinition>? Vectors { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable knowledge graph definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable knowledge graph definitions, keyed by name.")]
    [DataMember(Name = "graphs", Order = 9), JsonPropertyName("graphs"), JsonPropertyOrder(9), YamlMember(Alias = "graphs", Order = 9)]
    public virtual EquatableDictionary<string, KnowledgeGraphDefinition>? Graphs { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable Large Language Model (LLM) definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable LLM Large Language Model (LLM) definitions, keyed by name.")]
    [DataMember(Name = "llms", Order = 10), JsonPropertyName("llms"), JsonPropertyOrder(10), YamlMember(Alias = "llms", Order = 10)]
    public virtual EquatableDictionary<string, LlmDefinition>? Llms { get; set; }

    /// <summary>
    /// Gets or sets a mapping of reusable agent definitions, keyed by name.
    /// </summary>
    [Description("A mapping of reusable agent definitions, keyed by name.")]
    [DataMember(Name = "agents", Order = 11), JsonPropertyName("agents"), JsonPropertyOrder(11), YamlMember(Alias = "agents", Order = 11)]
    public virtual EquatableDictionary<string, AgentDefinition>? Agents { get; set; }

}
