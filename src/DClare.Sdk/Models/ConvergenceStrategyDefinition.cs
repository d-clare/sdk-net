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
/// Represents the definition of the strategy used in a convergence-based agentic process
/// </summary>
[DataContract]
public record ConvergenceStrategyDefinition
{

    /// <summary>
    /// Gets/sets the kernel function strategy, if any, used to decompose the initial prompt into specialized sub-prompts tailored to each contributing agent
    /// </summary>
    [DataMember(Name = "decomposition", Order = 1), JsonPropertyName("decomposition"), JsonPropertyOrder(1), YamlMember(Alias = "decomposition", Order = 1)]
    public virtual DecompositionStrategyDefinition? Decomposition { get; set; }

    /// <summary>
    /// Gets/sets the kernel function strategy used to synthesize the individual agent responses into a single, unified output
    /// </summary>
    [Required]
    [DataMember(Name = "synthesis", Order = 2), JsonPropertyName("synthesis"), JsonPropertyOrder(2), YamlMember(Alias = "synthesis", Order = 2)]
    public virtual SynthesisStrategyDefinition Synthesis { get; set; } = null!;

}
