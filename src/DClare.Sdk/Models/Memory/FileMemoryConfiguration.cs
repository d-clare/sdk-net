namespace DClare.Sdk.Models.Memory;

/// <summary>
/// Represents the configuration of a file-based memory provider.
/// </summary>
[Description("Represents the configuration of a file-based memory provider.")]
[DataContract]
public record FileMemoryConfiguration
{

    /// <summary>
    /// Gets/sets the path to the file where memory will be persisted.
    /// </summary>
    [Description("Path to the file where memory data is stored.")]
    [Required, MinLength(1)]
    [DataMember(Name = "path", Order = 1), JsonPropertyName("path"), JsonPropertyOrder(1), YamlMember(Alias = "path", Order = 1)]
    public virtual string Path { get; set; } = null!;

}
