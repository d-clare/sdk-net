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
/// Represents a high-level orchestration process involving one or more agents
/// </summary>
[DataContract]
public record AgenticProcessDefinition
{

    /// <summary>
    /// Gets/sets the collaboration process to perform
    /// </summary>
    [DataMember(Name = "collaboration", Order = 1), JsonPropertyName("collaboration"), JsonPropertyOrder(1), YamlMember(Alias = "collaboration", Order = 1)]
    public virtual CollaborationAgenticProcessDefinition? Collaboration { get; set; }

    /// <summary>
    /// Gets/sets the convergence process to perform
    /// </summary>
    [DataMember(Name = "convergence", Order = 1), JsonPropertyName("convergence"), JsonPropertyOrder(1), YamlMember(Alias = "convergence", Order = 1)]
    public virtual ConvergenceAgenticProcessDefinition? Convergence { get; set; }

    /// <summary>
    /// Gets the type of agentic process
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Collaboration != null ? AgenticProcessType.Collaboration : Convergence != null ? AgenticProcessType.Convergence : null!;

}
