namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the configuration of OAuth 2.0 endpoints used in token management flows.
/// </summary>
[Description("Represents the configuration of OAuth 2.0 endpoints used in token management flows.")]
[DataContract]
public record OAuth2AuthenticationEndpointsDefinition
{

    /// <summary>
    /// Gets or sets the URI of the token endpoint, which is used to obtain access tokens. Defaults to `/oauth2/token`.
    /// </summary>
    [Description("The URI of the token endpoint used to request access tokens. Defaults to '/oauth2/token'.")]
    [Required]
    [DataMember(Name = "token", Order = 1), JsonPropertyName("token"), JsonPropertyOrder(1), YamlMember(Alias = "token", Order = 1)]
    public virtual Uri Token { get; set; } = new("/oauth2/token", UriKind.RelativeOrAbsolute);

    /// <summary>
    /// Gets or sets the URI of the revocation endpoint, which is used to invalidate access or refresh tokens. Defaults to `/oauth2/revoke`.
    /// </summary>
    [Description("The URI of the revocation endpoint used to invalidate tokens. Defaults to '/oauth2/revoke'.")]
    [Required]
    [DataMember(Name = "revocation", Order = 2), JsonPropertyName("revocation"), JsonPropertyOrder(2), YamlMember(Alias = "revocation", Order = 2)]
    public virtual Uri Revocation { get; set; } = new("/oauth2/revoke", UriKind.RelativeOrAbsolute);

    /// <summary>
    /// Gets or sets the URI of the introspection endpoint, which is used to validate and inspect access tokens. Defaults to `/oauth2/introspect`.
    /// </summary>
    [Description("The URI of the introspection endpoint used to validate and inspect tokens. Defaults to '/oauth2/introspect'.")]
    [Required]
    [DataMember(Name = "introspection", Order = 3), JsonPropertyName("introspection"), JsonPropertyOrder(3), YamlMember(Alias = "introspection", Order = 3)]
    public virtual Uri Introspection { get; set; } = new("/oauth2/introspect", UriKind.RelativeOrAbsolute);

}
