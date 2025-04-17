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

namespace DClare.Sdk.Models.Processes;

/// <summary>
/// Represents a kernel function strategy used to select the agent to invoke next
/// </summary>
[DataContract]
public record SelectionStrategyDefinition
    : KernelFunctionStrategyDefinition
{

    /// <summary>
    /// Gets the default name of the variable used to store the list of agents to select
    /// </summary>
    public const string DefaultAgentsVariableName = "agents";
    /// <summary>
    /// Gets the default name of the variable used to store the chat history
    /// </summary>
    public const string DefaultHistoryVariableName = "history";

    /// <summary>
    /// Gets/sets the name of the variable used to store the list of agents to select
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "agentsVariableName", Order = 1), JsonPropertyName("agentsVariableName"), JsonPropertyOrder(1), YamlMember(Alias = "agentsVariableName", Order = 1)]
    public virtual string AgentsVariableName { get; init; } = DefaultAgentsVariableName;

    /// <summary>
    /// Gets/sets the name of the variable used to store the chat history
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "historyVariableName", Order = 2), JsonPropertyName("historyVariableName"), JsonPropertyOrder(2), YamlMember(Alias = "historyVariableName", Order = 2)]
    public virtual string HistoryVariableName { get; init; } = DefaultHistoryVariableName;

    /// <summary>
    /// Gets/sets the name of the agent to invoke first, if any
    /// </summary>
    [DataMember(Name = "initialAgent", Order = 3), JsonPropertyName("initialAgent"), JsonPropertyOrder(3), YamlMember(Alias = "initialAgent", Order = 3)]
    public virtual string? InitialAgent { get; set; }

}
