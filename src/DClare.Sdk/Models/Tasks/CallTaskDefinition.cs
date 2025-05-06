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

namespace DClare.Sdk.Models.Tasks;

/// <summary>
/// Represents the definition of a task used to call a function.
/// </summary>
[Description("Represents the definition of a task used to call a function.")]
[DataContract]
public record CallTaskDefinition 
    : TaskDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Type => TaskType.Call;

    /// <summary>
    /// Gets or sets the function to call, either as a full definition or by reference to a reusable function definition.
    /// </summary>
    [Description("The function to call, either as a full definition or by reference to a reusable function definition.")]
    [Required]
    [DataMember(Name = "call", Order = 1), JsonPropertyName("call"), JsonPropertyOrder(1), YamlMember(Alias = "call", Order = 1)]
    public virtual OneOf<FunctionDefinition, string> Call { get; set; } = null!;

    /// <summary>
    /// Gets or sets the parameters, if any, to pass to the function to invoke.
    /// </summary>
    [Description("The parameters, if any, to pass to the function to invoke.")]
    [DataMember(Name = "with", Order = 2), JsonPropertyName("with"), JsonPropertyOrder(2), YamlMember(Alias = "with", Order = 2)]
    public virtual EquatableDictionary<string, object>? With { get; set; }

}