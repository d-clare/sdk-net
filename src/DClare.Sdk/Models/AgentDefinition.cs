namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of an AI agent
/// </summary>
[Description("Represents the definition of an AI agent")]
[DataContract]
public record AgentDefinition
{

    /// <summary>
    /// Gets the agent's type
    /// </summary>
    [Description("The agent's type")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => Hosted != null ? AgentType.Hosted : Remote != null ? AgentType.Remote : null!;

    /// <summary>
    /// Gets/sets the configuration for an hosted agent
    /// </summary>
    [Description("The configuration for an hosted agent")]
    [DataMember(Name = "hosted", Order = 1), JsonPropertyName("hosted"), JsonPropertyOrder(1), YamlMember(Alias = "hosted", Order = 1)]
    public virtual HostedAgentDefinition? Hosted { get; set; }

    /// <summary>
    /// Gets/sets the configuration for a remote agent
    /// </summary>
    [Description("The configuration for a remote agent")]
    [DataMember(Name = "remote", Order = 1), JsonPropertyName("remote"), JsonPropertyOrder(1), YamlMember(Alias = "remote", Order = 1)]
    public virtual RemoteAgentDefinition? Remote { get; set; }

}
