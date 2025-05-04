namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a remote AI agent.
/// </summary>
[Description("Represents the definition of a remote AI agent.")]
[DataContract]
public record RemoteAgentDefinition
{

    /// <summary>
    /// Gets or sets the communication channel used to reach the remote agent.
    /// </summary>
    [Description("The communication channel used to reach the remote agent.")]
    [Required]
    [DataMember(Name = "channel", Order = 1), JsonPropertyName("channel"), JsonPropertyOrder(1), YamlMember(Alias = "channel", Order = 1)]
    public virtual AgentCommunicationChannelDefinition Channel { get; set; } = null!;

}

