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
/// Represents the agent invocation configuration used by an ask task.
/// </summary>
[Description("Represents the agent invocation configuration used by an ask task.")]
[DataContract]
public record AgentCallDefinition
{

    /// <summary>
    /// Gets or sets the agent to invoke, either as an inline definition or by reference to a reusable agent definition.
    /// </summary>
    [Description("The agent to invoke, either as an inline definition or by reference to a reusable agent definition.")]
    [Required]
    [DataMember(Name = "agent", Order = 1), JsonPropertyName("agent"), JsonPropertyOrder(1), YamlMember(Alias = "agent", Order = 1)]
    public virtual OneOf<AgentDefinition, string> Agent { get; set; } = null!;

    /// <summary>
    /// Gets or sets the instruction to send to the agent. This can be either a plain string or a prompt template.
    /// </summary>
    [Description("The instruction to send to the agent. This can be either a plain string or a prompt template.")]
    [Required]
    [DataMember(Name = "to", Order = 2), JsonPropertyName("to"), JsonPropertyOrder(2), YamlMember(Alias = "to", Order = 2)]
    public virtual OneOf<PromptTemplateDefinition, string> To { get; set; } = null!;

}