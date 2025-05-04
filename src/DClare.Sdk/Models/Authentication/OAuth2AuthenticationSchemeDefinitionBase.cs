namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the base class for all OAuth 2.0 authentication scheme definitions, including standard fields for authority, client credentials, grant type, scopes, and token exchange options.
/// </summary>
[Description("Base class for OAuth 2.0 authentication schemes, including authority URI, grant type, client configuration, and optional token exchange parameters.")]
[DataContract]
public abstract record OAuth2AuthenticationSchemeDefinitionBase 
    : AuthenticationSchemeDefinition
{

    /// <summary>
    /// Gets or sets the URI of the OAuth 2.0 authority (authorization server).
    /// </summary>
    [Description("The URI of the OAuth 2.0 authority (authorization server).")]
    [DataMember(Name = "authority", Order = 1), JsonPropertyName("authority"), JsonPropertyOrder(1), YamlMember(Alias = "authority", Order = 1)]
    public virtual Uri Authority { get; set; } = null!;

    /// <summary>
    /// Gets or sets the OAuth 2.0 grant type to use for authentication.
    /// </summary>
    [Description("The OAuth 2.0 grant type to use (e.g., client_credentials, password, token_exchange).")]
    [DataMember(Name = "grant", Order = 2), JsonPropertyName("grant"), JsonPropertyOrder(2), YamlMember(Alias = "grant", Order = 2)]
    public virtual string? Grant { get; set; }

    /// <summary>
    /// Gets or sets the client credentials used for authentication.
    /// </summary>
    [Description("The client credentials used to authenticate with the OAuth 2.0 authority.")]
    [DataMember(Name = "client", Order = 3), JsonPropertyName("client"), JsonPropertyOrder(3), YamlMember(Alias = "client", Order = 3)]
    public virtual OAuth2AuthenticationClientDefinition? Client { get; set; }

    /// <summary>
    /// Gets or sets additional request parameters for the authentication request.
    /// </summary>
    [Description("Additional parameters to include in the OAuth 2.0 token request.")]
    [DataMember(Name = "request", Order = 4), JsonPropertyName("request"), JsonPropertyOrder(4), YamlMember(Alias = "request", Order = 4)]
    public virtual OAuth2AuthenticationRequestDefinition? Request { get; set; }

    /// <summary>
    /// Gets or sets a list of expected valid issuers to verify against the token's issuer.
    /// </summary>
    [Description("A list of expected valid issuers to validate against the 'iss' claim in the returned token.")]
    [DataMember(Name = "issuers", Order = 5), JsonPropertyName("issuers"), JsonPropertyOrder(5), YamlMember(Alias = "issuers", Order = 5)]
    public virtual EquatableList<string>? Issuers { get; set; }

    /// <summary>
    /// Gets or sets the scopes to request in the token.
    /// </summary>
    [Description("The list of scopes to request for the token.")]
    [DataMember(Name = "scopes", Order = 6), JsonPropertyName("scopes"), JsonPropertyOrder(6), YamlMember(Alias = "scopes", Order = 6)]
    public virtual EquatableList<string>? Scopes { get; set; }

    /// <summary>
    /// Gets or sets the audiences to request in the token.
    /// </summary>
    [Description("The list of audiences to request access to.")]
    [DataMember(Name = "audiences", Order = 7), JsonPropertyName("audiences"), JsonPropertyOrder(7), YamlMember(Alias = "audiences", Order = 7)]
    public virtual EquatableList<string>? Audiences { get; set; }

    /// <summary>
    /// Gets or sets the username for the resource owner. Only applicable when the grant type is 'password'.
    /// </summary>
    [Description("The username used for the resource owner password credentials grant (if applicable).")]
    [DataMember(Name = "username", Order = 8), JsonPropertyName("username"), JsonPropertyOrder(8), YamlMember(Alias = "username", Order = 8)]
    public virtual string? Username { get; set; }

    /// <summary>
    /// Gets or sets the password for the resource owner. Only applicable when the grant type is 'password'.
    /// </summary>
    [Description("The password used for the resource owner password credentials grant (if applicable).")]
    [DataMember(Name = "password", Order = 9), JsonPropertyName("password"), JsonPropertyOrder(9), YamlMember(Alias = "password", Order = 9)]
    public virtual string? Password { get; set; }

    /// <summary>
    /// Gets or sets the subject token for token exchange. Required when using the 'token_exchange' grant type.
    /// </summary>
    [Description("The subject token representing the identity being delegated. Required for token exchange grants.")]
    [DataMember(Name = "subject", Order = 10), JsonPropertyName("subject"), JsonPropertyOrder(10), YamlMember(Alias = "subject", Order = 10)]
    public virtual OAuth2TokenDefinition? Subject { get; set; }

    /// <summary>
    /// Gets or sets the actor token used for token exchange to represent the acting party.
    /// </summary>
    [Description("The actor token representing the acting party in token exchange grants.")]
    [DataMember(Name = "actor", Order = 11), JsonPropertyName("actor"), JsonPropertyOrder(11), YamlMember(Alias = "actor", Order = 11)]
    public virtual OAuth2TokenDefinition? Actor { get; set; }

}