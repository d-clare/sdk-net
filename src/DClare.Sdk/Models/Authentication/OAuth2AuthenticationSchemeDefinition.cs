namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an OAuth 2.0 authentication scheme, including required endpoints and flow configuration.
/// </summary>
[Description("Represents the definition of an OAuth 2.0 authentication scheme, including required endpoints and flow configuration.")]
[DataContract]
public record OAuth2AuthenticationSchemeDefinition
    : OAuth2AuthenticationSchemeDefinitionBase
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.OAuth2;

    /// <summary>
    /// Gets or sets the configuration of the OAuth 2.0 endpoints to use for authorization, token exchange, and optionally revocation or introspection.
    /// </summary>
    [Description("Configuration of the OAuth 2.0 endpoints, including authorization and token URLs.")]
    [DataMember(Name = "endpoints", Order = 2), JsonPropertyName("endpoints"), JsonPropertyOrder(2), YamlMember(Alias = "endpoints", Order = 2)]
    public virtual OAuth2AuthenticationEndpointsDefinition Endpoints { get; set; } = new();

}
