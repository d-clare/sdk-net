namespace DClare.Sdk.Models;

/// <summary>
/// Represents a reusable component definition that can either be declared inline or referenced by name.
/// </summary>
[Description("Represents a reusable component definition that can either be declared inline or referenced by name.")]
[DataContract]
public abstract record ReferenceableComponentDefinition
    : ComponentDefinition, IReferenceable
{

    /// <summary>
    /// Gets or sets the name of a previously defined component to reference instead of defining it inline.
    /// If this property is set, the inline definition is ignored.
    /// </summary>
    [Description("The name of a predefined component to reference. If set, the inline definition will be ignored.")]
    [DataMember(Order = 0, Name = "use"), JsonPropertyOrder(0), JsonPropertyName("use"), YamlMember(Order = 0, Alias = "use")]
    public virtual string? Use { get; set; }

}