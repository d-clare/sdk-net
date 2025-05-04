namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an OpenID Connect (OIDC) authentication scheme, based on OAuth 2.0, supporting identity tokens and discovery.
/// </summary>
[Description("Represents the definition of an OpenID Connect (OIDC) authentication scheme, based on OAuth 2.0, supporting identity tokens and discovery.")]
[DataContract]
public record OpenIDConnectSchemeDefinition
    : OAuth2AuthenticationSchemeDefinitionBase
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.OpenIDConnect;

}
