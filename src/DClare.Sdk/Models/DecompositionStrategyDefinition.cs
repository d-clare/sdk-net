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
/// Represents a kernel function strategy that generates tailored sub-prompts for each agent of a convergence process
/// </summary>
[DataContract]
public record DecompositionStrategyDefinition 
    : KernelFunctionStrategyDefinition
{

    /// <summary>
    /// Gets the default name of the variable used to store the prompt to split into agent-specific subprompts
    /// </summary>
    public const string DefaultPromptVariableName = "prompt";
    /// <summary>
    /// Gets the default name of the variable used to store the agents to tailor subprompts for
    /// </summary>
    public const string DefaultAgentsVariableName = "agents";

    /// <summary>
    /// Gets/sets the name of the variable used to store the agents to tailor subprompts for
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "promptVariableName", Order = 1), JsonPropertyName("promptVariableName"), JsonPropertyOrder(1), YamlMember(Alias = "promptVariableName", Order = 1)]
    public virtual string PromptVariableName { get; set; } = DefaultPromptVariableName;

    /// <summary>
    /// Gets/sets the name of the variable used to store the agents to tailor subprompts for
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "agentsVariableName", Order = 2), JsonPropertyName("agentsVariableName"), JsonPropertyOrder(2), YamlMember(Alias = "agentsVariableName", Order = 2)]
    public virtual string AgentsVariableName { get; set; } = DefaultAgentsVariableName;

}