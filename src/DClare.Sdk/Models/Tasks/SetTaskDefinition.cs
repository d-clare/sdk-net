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
/// Represents the definition of a task used to assign values to one or more variables in the data scope.
/// </summary>
[Description("Represents the definition of a task used to assign values to one or more variables in the data scope.")]
[DataContract]
public record SetTaskDefinition 
    : TaskDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Type => TaskType.Set;

    /// <summary>
    /// Gets or sets the mapping of variables to values to assign.
    /// </summary>
    [Description("Specifies the mapping of variable names to values to assign within the current data scope.")]
    [Required, MinLength(1)]
    [DataMember(Name = "set", Order = 1), JsonPropertyName("set"), JsonPropertyOrder(1), YamlMember(Alias = "set", Order = 1)]
    public virtual EquatableDictionary<string, object> Set { get; set; } = null!;

}
