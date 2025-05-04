namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of an endpoint
/// </summary>
[Description("Represents the definition of an endpoint.")]
[DataContract]
public record EndpointDefinition
{

    /// <summary>
    /// Gets or sets the endpoint URI.
    /// </summary>
    [Description("The endpoint URI.")]
    [DataMember(Name = "uri", Order = 1), JsonPropertyName("uri"), JsonPropertyOrder(1), YamlMember(Alias = "uri", Order = 1)]
    public required virtual Uri? Uri { get; set; }

    /// <summary>
    /// Gets or sets the authentication policy required to access the API endpoint, if any.
    /// </summary>
    [Description("The authentication policy required to access the API endpoint, if any.")]
    [DataMember(Name = "authentication", Order = 2), JsonPropertyName("authentication"), JsonPropertyOrder(2), YamlMember(Alias = "authentication", Order = 2)]
    public virtual AuthenticationPolicyDefinition? Authentication { get; set; }

}