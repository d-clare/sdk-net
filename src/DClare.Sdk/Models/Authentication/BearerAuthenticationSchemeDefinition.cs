namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of a bearer token authentication scheme, where a token is passed in the Authorization header.
/// </summary>
[Description("Represents the definition of a bearer token authentication scheme, where a token is passed in the Authorization header.")]
[DataContract]
public record BearerAuthenticationSchemeDefinition
    : AuthenticationSchemeDefinition
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.Bearer;

    /// <summary>
    /// Gets or sets the bearer token used for authentication.
    /// </summary>
    [Description("The bearer token used for authentication, typically included in the Authorization header.")]
    [Required, MinLength(1)]
    [DataMember(Name = "token", Order = 1), JsonPropertyName("token"), JsonPropertyOrder(1), YamlMember(Alias = "token", Order = 1)]
    public virtual string Token { get; set; } = null!;

}
