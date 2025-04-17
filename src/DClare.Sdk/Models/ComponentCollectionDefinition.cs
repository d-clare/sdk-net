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
/// Represents the definition of a collection of reusable components
/// </summary>
[DataContract]
public record ComponentCollectionDefinition
{

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable authentication policies
    /// </summary>
    [DataMember(Name = "authentications", Order = 1), JsonPropertyName("authentications"), JsonPropertyOrder(1), YamlMember(Alias = "authentications", Order = 1)]
    public virtual EquatableDictionary<string, AuthenticationPolicyDefinition>? Authentications { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable toolsets
    /// </summary>
    [DataMember(Name = "toolsets", Order = 2), JsonPropertyName("toolsets"), JsonPropertyOrder(2), YamlMember(Alias = "toolsets", Order = 2)]
    public virtual EquatableDictionary<string, ToolsetDefinition>? Toolsets { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable functions
    /// </summary>
    [DataMember(Name = "functions", Order = 3), JsonPropertyName("functions"), JsonPropertyOrder(3), YamlMember(Alias = "functions", Order = 3)]
    public virtual EquatableDictionary<string, KernelFunctionDefinition>? Functions { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable kernels
    /// </summary>
    [DataMember(Name = "kernels", Order = 4), JsonPropertyName("kernels"), JsonPropertyOrder(4), YamlMember(Alias = "kernels", Order = 4)]
    public virtual EquatableDictionary<string, KernelDefinition>? Kernels { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable memories
    /// </summary>
    [DataMember(Name = "memories", Order = 5), JsonPropertyName("memories"), JsonPropertyOrder(5), YamlMember(Alias = "memories", Order = 5)]
    public virtual EquatableDictionary<string, MemoryDefinition>? Memories { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable agents
    /// </summary>
    [DataMember(Name = "agents", Order = 6), JsonPropertyName("agents"), JsonPropertyOrder(6), YamlMember(Alias = "agents", Order = 6)]
    public virtual EquatableDictionary<string, AgentDefinition>? Agents { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable agentic processes
    /// </summary>
    [DataMember(Name = "processes", Order = 7), JsonPropertyName("processes"), JsonPropertyOrder(7), YamlMember(Alias = "processes", Order = 7)]
    public virtual EquatableDictionary<string, AgenticProcessDefinition>? Processes { get; set; }

}