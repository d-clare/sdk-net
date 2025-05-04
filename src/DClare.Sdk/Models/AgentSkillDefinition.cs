namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of an agent's skill, including an optional human-readable description
/// that can be used to inform selection or routing logic.
/// </summary>
[Description("Represents the definition of an agent's skill, including an optional description used to evaluate or select agents.")]
[DataContract]
public record AgentSkillDefinition
{

    /// <summary>
    /// Gets or sets a short, human-readable description of the agent's skill or capability.
    /// This information may be used to evaluate and select the most appropriate agent for a given task.
    /// </summary>
    [Description("A short, human-readable description of the agent's skill or capability.")]
    [DataMember(Name = "description", Order = 2), JsonPropertyName("description"), JsonPropertyOrder(2), YamlMember(Alias = "description", Order = 2)]
    public virtual string? Description { get; set; }

}
