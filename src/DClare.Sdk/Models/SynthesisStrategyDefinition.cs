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
/// Represents a kernel function strategy responsible for combining inputs into a single synthesized result
/// </summary>
[DataContract]
public record SynthesisStrategyDefinition
    : KernelFunctionStrategyDefinition
{

    /// <summary>
    /// Gets the default variable name used to pass the collection of inputs to the synthesis function
    /// </summary>
    public const string DefaultInputsVariableName = "inputs";

    /// <summary>
    /// Gets/sets the variable name used to pass the collection of inputs to the synthesis function
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "inputsVariableName", Order = 1), JsonPropertyName("inputsVariableName"), JsonPropertyOrder(1), YamlMember(Alias = "inputsVariableName", Order = 1)]
    public virtual string InputsVariableName { get; set; } = DefaultInputsVariableName;

}
