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
/// Represents the definition of a workflow task.
/// </summary>
[Description("Represents the definition of a workflow task.")]
[DataContract, JsonConverter(typeof(JsonTaskDefinitionConverter))]
public abstract record TaskDefinition
    : ComponentDefinition
{

    /// <summary>
    /// Gets the type of the defined task
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public abstract string Type { get; }

    /// <summary>
    /// Gets or sets the definition of the task's input data, if any. This can define a schema and/or expressions used to prepare input data from the parent scope.
    /// </summary>
    [Description("Defines the task's input data, including optional schema and runtime expressions to derive the input from the current scope.")]
    [DataMember(Name = "input", Order = 10), JsonPropertyName("input"), JsonPropertyOrder(10), YamlMember(Alias = "input", Order = 10)]
    public virtual InputDataModelDefinition? Input { get; set; }

    /// <summary>
    /// Gets or sets the definition of the task's output data, if any. This can define a schema and/or expressions used to expose output data to the parent scope.
    /// </summary>
    [Description("Defines the task's output data, including optional schema and runtime expressions to map output back to the scope.")]
    [DataMember(Name = "output", Order = 11), JsonPropertyName("output"), JsonPropertyOrder(11), YamlMember(Alias = "output", Order = 11)]
    public virtual OutputDataModelDefinition? Output { get; set; }

    /// <summary>
    /// Gets or sets the optional configuration for exporting data from the task to the broader workflow context.
    /// </summary>
    [Description("Defines how to export specific data from the task to the broader workflow scope.")]
    [DataMember(Name = "export", Order = 12), JsonPropertyName("export"), JsonPropertyOrder(12), YamlMember(Alias = "export", Order = 12)]
    public virtual OutputDataModelDefinition? Export { get; set; }

    /// <summary>
    /// Gets/sets a key/value mapping of additional information associated with the task
    /// </summary>
    [DataMember(Name = "metadata", Order = 12), JsonPropertyName("metadata"), JsonPropertyOrder(99), YamlMember(Alias = "metadata", Order = 99)]
    public virtual EquatableDictionary<string, object>? Metadata { get; set; }

}