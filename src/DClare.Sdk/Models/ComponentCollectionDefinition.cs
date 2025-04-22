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
    /// Gets/sets a list containing the secrets, if any, used to securely configure components
    /// </summary>
    [DataMember(Name = "secrets", Order = 1), JsonPropertyName("secrets"), JsonPropertyOrder(1), YamlMember(Alias = "secrets", Order = 1)]
    public virtual EquatableList<string>? Secrets { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable authentication policies
    /// </summary>
    [DataMember(Name = "authentications", Order = 2), JsonPropertyName("authentications"), JsonPropertyOrder(2), YamlMember(Alias = "authentications", Order = 2)]
    public virtual EquatableDictionary<string, AuthenticationPolicyDefinition>? Authentications { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable toolsets
    /// </summary>
    [DataMember(Name = "toolsets", Order = 3), JsonPropertyName("toolsets"), JsonPropertyOrder(3), YamlMember(Alias = "toolsets", Order = 3)]
    public virtual EquatableDictionary<string, ToolsetDefinition>? Toolsets { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable functions
    /// </summary>
    [DataMember(Name = "functions", Order = 4), JsonPropertyName("functions"), JsonPropertyOrder(4), YamlMember(Alias = "functions", Order = 4)]
    public virtual EquatableDictionary<string, KernelFunctionDefinition>? Functions { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable kernels
    /// </summary>
    [DataMember(Name = "kernels", Order = 5), JsonPropertyName("kernels"), JsonPropertyOrder(5), YamlMember(Alias = "kernels", Order = 5)]
    public virtual EquatableDictionary<string, KernelDefinition>? Kernels { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable memories
    /// </summary>
    [DataMember(Name = "memories", Order = 6), JsonPropertyName("memories"), JsonPropertyOrder(6), YamlMember(Alias = "memories", Order = 6)]
    public virtual EquatableDictionary<string, MemoryDefinition>? Memories { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable agents
    /// </summary>
    [DataMember(Name = "agents", Order = 7), JsonPropertyName("agents"), JsonPropertyOrder(7), YamlMember(Alias = "agents", Order = 7)]
    public virtual EquatableDictionary<string, AgentDefinition>? Agents { get; set; } 

    /// <summary>
    /// Gets/sets a name/definition mapping, if any, of reusable agentic processes
    /// </summary>
    [DataMember(Name = "processes", Order = 8), JsonPropertyName("processes"), JsonPropertyOrder(8), YamlMember(Alias = "processes", Order = 8)]
    public virtual EquatableDictionary<string, ProcessDefinition>? Processes { get; set; }

}