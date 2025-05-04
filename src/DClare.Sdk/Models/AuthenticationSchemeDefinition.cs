namespace DClare.Sdk.Models;

/// <summary>
/// Represents the abstract base class for all authentication scheme definitions, including shared properties like secret reference and parameter placement.
/// </summary>
[Description("Represents the abstract base class for all authentication scheme definitions, including shared properties like secret reference and parameter placement.")]
[DataContract]
public abstract record AuthenticationSchemeDefinition 
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets the name of the authentication scheme (e.g., 'apikey', 'bearer', 'oauth2', 'oidc').
    /// </summary>
    [Description("The name of the authentication scheme (e.g., 'apikey', 'bearer', 'oauth2', 'oidc').")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public abstract string Scheme { get; }

    /// <summary>
    /// Gets/sets a key/value mapping of the object's extension data, if any
    /// </summary>
    [DataMember(Name = "extensions", Order = 99), JsonPropertyName("extensions"), JsonPropertyOrder(99), YamlMember(Alias = "extensions", Order = 99)]
    public virtual EquatableDictionary<string, object>? Extensions { get; set; }

}
