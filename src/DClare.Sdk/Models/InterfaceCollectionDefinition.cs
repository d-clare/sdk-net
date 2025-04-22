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
/// Represents a collection of the interfaces exposed by the application
/// </summary>
[DataContract]
public record InterfaceCollectionDefinition
{

    /// <summary>
    /// Gets/sets a name/definition mapping of the agent interfaces exposed by the application
    /// </summary>
    [DataMember(Name = "agents", Order = 1), JsonPropertyName("agents"), JsonPropertyOrder(1), YamlMember(Alias = "agents", Order = 1)]
    public virtual EquatableDictionary<string, AgentInterfaceDefinition>? Agents { get; set; }

    /// <summary>
    /// Gets/sets a name/definition mapping of the process interfaces exposed by the application
    /// </summary>
    [DataMember(Name = "processes", Order = 1), JsonPropertyName("processes"), JsonPropertyOrder(1), YamlMember(Alias = "processes", Order = 1)]
    public virtual EquatableDictionary<string, ProcessInterfaceDefinition>? Processes { get; set; }

}
