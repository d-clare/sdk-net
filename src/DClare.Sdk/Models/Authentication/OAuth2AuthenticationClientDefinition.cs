namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an OAuth 2.0 client, including its credentials and authentication method.
/// </summary>
[Description("Represents the definition of an OAuth 2.0 client, including its credentials and authentication method.")]
[DataContract]
public record OAuth2AuthenticationClientDefinition
{

    /// <summary>
    /// Gets or sets the OAuth 2.0 `client_id` to use. Required unless the client authentication method is set to 'none'.
    /// </summary>
    [Description("The OAuth 2.0 client_id used to identify the application. Required unless client authentication is set to 'none'.")]
    [DataMember(Name = "id", Order = 1), JsonPropertyName("id"), JsonPropertyOrder(1), YamlMember(Alias = "id", Order = 1)]
    public virtual string? Id { get; set; }

    /// <summary>
    /// Gets or sets the OAuth 2.0 `client_secret` to use, if any.
    /// </summary>
    [Description("The client_secret used to authenticate the client. Optional depending on the authentication method.")]
    [DataMember(Name = "secret", Order = 2), JsonPropertyName("secret"), JsonPropertyOrder(2), YamlMember(Alias = "secret", Order = 2)]
    public virtual string? Secret { get; set; }

    /// <summary>
    /// Gets or sets a signed JWT assertion to authenticate the client instead of using a client_secret.
    /// </summary>
    [Description("A JWT used as a client assertion for authentication instead of a shared secret.")]
    [DataMember(Name = "assertion", Order = 3), JsonPropertyName("assertion"), JsonPropertyOrder(3), YamlMember(Alias = "assertion", Order = 3)]
    public virtual string? Assertion { get; set; }

    /// <summary>
    /// Gets or sets the authentication method used by the client. Defaults to 'client_secret_post'.
    /// </summary>
    [Description("The authentication method used by the client (e.g., 'client_secret_post', 'client_secret_basic', 'private_key_jwt', or 'none').")]
    [DataMember(Name = "authentication", Order = 4), JsonPropertyName("authentication"), JsonPropertyOrder(4), YamlMember(Alias = "authentication", Order = 4)]
    public virtual string? Authentication { get; set; }

}
