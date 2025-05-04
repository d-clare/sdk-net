namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of protocol-specific configuration options for communicating with a remote agent.
/// </summary>
[Description("Represents the definition of protocol-specific configuration options for communicating with a remote agent.")]
[DataContract]
public record AgentCommunicationChannelDefinition
{

    /// <summary>
    /// Gets or sets the configuration for the Agent-to-Agent (A2A) communication protocol.
    /// </summary>
    [Description("The configuration for the Agent-to-Agent (A2A) communication protocol.")]
    [DataMember(Name = "a2a", Order = 1), JsonPropertyName("a2a"), JsonPropertyOrder(1), YamlMember(Alias = "a2a", Order = 1)]
    public virtual A2ACommunicationChannelDefinition? A2A { get; set; }

    /// <summary>
    /// Gets the agent's communication channel type.
    /// </summary>
    [Description("The resolved type of the agent's communication channel, based on which configuration is set.")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Type => A2A != null ? AgentCommunicationChannelType.A2A : null!;

}
