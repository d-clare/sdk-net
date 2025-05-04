namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of an API key authentication scheme, typically used via headers or query parameters.
/// </summary>
[Description("Represents the definition of an API key authentication scheme, typically used via headers or query parameters.")]
[DataContract]
public record ApiKeyAuthenticationSchemeDefinition 
    : AuthenticationSchemeDefinition
{

    /// <summary>
    /// Gets the name of the authentication scheme.
    /// </summary>
    [Description("The constant name of this scheme, which is 'apikey'.")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.ApiKey;

    /// <summary>
    /// Gets or sets the name of the key used for authentication.
    /// </summary>
    [Description("The name of the key (e.g., header or query parameter) used to carry the API key.")]
    [Required, MinLength(1)]
    [DataMember(Name = "key", Order = 1), JsonPropertyName("key"), JsonPropertyOrder(1), YamlMember(Alias = "key", Order = 1)]
    public virtual string Key { get; set; } = null!;

}
