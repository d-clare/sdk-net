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
/// Represents a kernel function strategy used to determine whether or not to terminate the chat
/// </summary>
[DataContract]
public record TerminationStrategyDefinition
    : KernelFunctionStrategyDefinition
{

    /// <summary>
    /// Gets the default name of the variable used to store the name of the agent being evaluated
    /// </summary>
    public const string DefaultAgentVariableName = "agent";
    /// <summary>
    /// Gets the default name of the variable used to store the chat history
    /// </summary>
    public const string DefaultHistoryVariableName = "history";
    /// <summary>
    /// Gets the default limit on the number of turns for a given chat invocation
    /// </summary>
    public const int DefaultMaximumIterations = 99;

    /// <summary>
    /// Gets/sets the name of the variable used to store the name of the agent being evaluated
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "agentVariableName", Order = 1), JsonPropertyName("agentVariableName"), JsonPropertyOrder(1), YamlMember(Alias = "agentVariableName", Order = 1)]
    public virtual string AgentVariableName { get; init; } = DefaultAgentVariableName;

    /// <summary>
    /// Gets/sets the name of the variable used to store the chat history
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "historyVariableName", Order = 2), JsonPropertyName("historyVariableName"), JsonPropertyOrder(2), YamlMember(Alias = "historyVariableName", Order = 2)]
    public virtual string HistoryVariableName { get; init; } = DefaultHistoryVariableName;

    /// <summary>
    /// Gets/sets a list containing the names of the agents for which this strategy is applicable<para></para>
    /// By default value, any agent is evaluated
    /// </summary>
    [DataMember(Name = "agents", Order = 3), JsonPropertyName("agents"), JsonPropertyOrder(3), YamlMember(Alias = "agents", Order = 3)]
    public virtual EquatableList<string>? Agents { get; set; }

    /// <summary>
    /// Gets/sets the maximum number of agent interactions for a given chat invocation
    /// </summary>
    [DataMember(Name = "maximumIterations", Order = 4), JsonPropertyName("maximumIterations"), JsonPropertyOrder(4), YamlMember(Alias = "maximumIterations", Order = 4)]
    public virtual int MaximumIterations { get; set; } = DefaultMaximumIterations;

}