namespace DClare.Sdk.Models.Memory;

/// <summary>
/// Represents the configuration of a MongoDB-based memory provider.
/// </summary>
[Description("Represents the configuration of a MongoDB-based memory provider.")]
[DataContract]
public record MongoDbMemoryConfiguration
{

    /// <summary>
    /// Gets/sets the MongoDB connection string.
    /// </summary>
    [Description("The connection string to the MongoDB instance.")]
    [Required, MinLength(1)]
    [DataMember(Name = "connectionString", Order = 1), JsonPropertyName("connectionString"), JsonPropertyOrder(1), YamlMember(Alias = "connectionString", Order = 1)]
    public virtual string ConnectionString { get; set; } = null!;

    /// <summary>
    /// Gets/sets the name of the MongoDB database.
    /// </summary>
    [Description("The MongoDB database name.")]
    [Required, MinLength(1)]
    [DataMember(Name = "database", Order = 2), JsonPropertyName("database"), JsonPropertyOrder(2), YamlMember(Alias = "database", Order = 2)]
    public virtual string Database { get; set; } = null!;

    /// <summary>
    /// Gets/sets the name of the collection used for storing memory entries.
    /// </summary>
    [Description("The MongoDB collection name used for storing memory entries.")]
    [DataMember(Name = "collection", Order = 3), JsonPropertyName("collection"), JsonPropertyOrder(3), YamlMember(Alias = "collection", Order = 3)]
    public virtual string Collection { get; set; } = null!;

}
