namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a memory provider
/// </summary>
[Description("Represents the definition of a memory provider")]
[DataContract]
public record MemoryProviderDefinition
{

    /// <summary>
    /// Gets/sets the name of the memory provider to use
    /// </summary>
    [Description("The name of the memory provider to use")]
    [Required, AllowedValues(MemoryProvider.File, MemoryProvider.Memory, MemoryProvider.MongoDB, MemoryProvider.Redis, MemoryProvider.Sql)]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets/sets the key/value mapping of configuration values, if any, required by the provider
    /// </summary>
    [Description("A key/value mapping of configuration values, if any, required by the provider")]
    [DataMember(Name = "configuration", Order = 2), JsonPropertyName("configuration"), JsonPropertyOrder(2), YamlMember(Alias = "configuration", Order = 2)]
    public virtual EquatableDictionary<string, object>? Configuration { get; set; }

}