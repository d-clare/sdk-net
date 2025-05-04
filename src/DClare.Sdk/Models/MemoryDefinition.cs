namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of a conversation memory
/// </summary>
[Description("Represents the definition of a memory")]
[DataContract]
public record MemoryDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets or sets the definition of the memory provider to use.
    /// </summary>
    [Description("The definition of the memory provider to use.")]
    [Required]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual MemoryProviderDefinition Provider { get; set; } = null!;

    /// <summary>
    /// Gets or sets the retention strategy to use (e.g., 'window', 'full', 'summary').
    /// </summary>
    [Description("The memory retention to use (e.g., 'window', 'full', 'summary').")]
    [Required, AllowedValues(MemoryStrategy.Full, MemoryStrategy.Summary, MemoryStrategy.Window), DefaultValue(MemoryStrategy.Full)]
    [DataMember(Name = "strategy", Order = 2), JsonPropertyName("strategy"), JsonPropertyOrder(2), YamlMember(Alias = "strategy", Order = 2)]
    public virtual string Strategy { get; set; } = MemoryStrategy.Full;

    /// <summary>
    /// Gets or sets the maximum number of exchanges to retain in memory when using the 'window' strategy.
    /// </summary>
    [Description("The number of recent exchanges to retain if using the 'window' strategy.")]
    [DataMember(Name = "windowSize", Order = 3), JsonPropertyName("windowSize"), JsonPropertyOrder(3), YamlMember(Alias = "windowSize", Order = 3)]
    public virtual int? WindowSize { get; set; }

    /// <summary>
    /// Gets or sets the function used to summarize memory when using the 'summary' strategy.
    /// </summary>
    [Description("The function used to summarize memory when using the 'summary' strategy.")]
    [DataMember(Name = "summarizer", Order = 4), JsonPropertyName("summarizer"), JsonPropertyOrder(4), YamlMember(Alias = "summarizer", Order = 4)]
    public virtual FunctionDefinition? Summarizer { get; set; }

}
