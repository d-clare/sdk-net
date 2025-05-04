namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the configuration of an OAuth 2.0 authentication request, including the expected content encoding.
/// </summary>
[Description("Represents the configuration of an OAuth 2.0 authentication request, including the expected content encoding.")]
[DataContract]
public record OAuth2AuthenticationRequestDefinition
{

    /// <summary>
    /// Gets or sets the encoding format to use for the authentication request payload.
    /// Defaults to 'application/x-www-form-urlencoded'.
    /// </summary>
    [Description("The encoding format for the authentication request (e.g., 'application/x-www-form-urlencoded', 'application/json'). Defaults to 'application/x-www-form-urlencoded'.")]
    [DataMember(Name = "encoding", Order = 1), JsonPropertyName("encoding"), JsonPropertyOrder(1), YamlMember(Alias = "encoding", Order = 1)]
    public virtual string Encoding { get; set; } = OAuth2RequestEncoding.FormUrl;

}
