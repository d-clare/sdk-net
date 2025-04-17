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

using DClare.Sdk.Models.Processes;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the strategy used in a collaboration-based agentic process
/// </summary>
[DataContract]
public record CollaborationStrategyDefinition
{

    /// <summary>
    /// Gets/sets the kernel function strategy used to select which agents participate and in what order or combination
    /// </summary>
    [Required]
    [DataMember(Name = "selection", Order = 1), JsonPropertyName("selection"), JsonPropertyOrder(1), YamlMember(Alias = "selection", Order = 1)]
    public virtual SelectionStrategyDefinition Selection { get; set; } = null!;

    /// <summary>
    /// Gets/sets the kernel function strategy used to determine when the collaborative process should conclude
    /// </summary>
    [Required]
    [DataMember(Name = "termination", Order = 2), JsonPropertyName("termination"), JsonPropertyOrder(2), YamlMember(Alias = "termination", Order = 2)]
    public virtual TerminationStrategyDefinition Termination { get; set; } = null!;

}