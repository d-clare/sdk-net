namespace DClare.Sdk.Models.Memory;

/// <summary>
/// Represents the configuration of an in-memory memory provider.
/// </summary>
[Description("Represents the configuration of an in-memory memory provider.")]
[DataContract]
public record InMemoryMemoryConfiguration
{

    /// <summary>
    /// Gets/sets the optional namespace or prefix for the in-memory store.
    /// </summary>
    [Description("Optional namespace or prefix for in-memory key isolation.")]
    [DataMember(Name = "prefix", Order = 1), JsonPropertyName("prefix"), JsonPropertyOrder(1), YamlMember(Alias = "prefix", Order = 1)]
    public virtual string? Prefix { get; set; }

}