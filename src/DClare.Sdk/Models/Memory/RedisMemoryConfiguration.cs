namespace DClare.Sdk.Models.Memory;

/// <summary>
/// Represents the configuration of a Redis-based memory provider.
/// </summary>
[Description("Represents the configuration of a Redis-based memory provider, including connection settings and database selection.")]
[DataContract]
public record RedisMemoryConfiguration
{

    /// <summary>
    /// Gets or sets the Redis server endpoint (e.g., localhost:6379).
    /// </summary>
    [Description("The Redis server endpoint (e.g., 'localhost:6379').")]
    [Required, MinLength(1)]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual string Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets or sets the Redis database index (0 by default).
    /// </summary>
    [Description("The Redis logical database number to use (default is 0).")]
    [DefaultValue(0)]
    [DataMember(Name = "database", Order = 2), JsonPropertyName("database"), JsonPropertyOrder(2), YamlMember(Alias = "database", Order = 2)]
    public virtual int Database { get; set; } = 0;

    /// <summary>
    /// Gets or sets the optional key prefix to namespace entries in Redis.
    /// </summary>
    [Description("Optional key prefix to namespace all Redis keys used by this memory provider.")]
    [DataMember(Name = "prefix", Order = 3), JsonPropertyName("prefix"), JsonPropertyOrder(3), YamlMember(Alias = "prefix", Order = 3)]
    public virtual string? Prefix { get; set; }

    /// <summary>
    /// Gets or sets the password used to authenticate with Redis, if any.
    /// </summary>
    [Description("Optional password used to authenticate with the Redis instance.")]
    [DataMember(Name = "password", Order = 4), JsonPropertyName("password"), JsonPropertyOrder(4), YamlMember(Alias = "password", Order = 4)]
    public virtual string? Password { get; set; }

    /// <summary>
    /// Gets or sets whether SSL should be used to connect to Redis.
    /// </summary>
    [Description("Indicates whether to use SSL when connecting to the Redis server.")]
    [DataMember(Name = "useSsl", Order = 5), JsonPropertyName("useSsl"), JsonPropertyOrder(5), YamlMember(Alias = "useSsl", Order = 5)]
    public virtual  bool UseSsl { get; set; } = false;

    /// <summary>
    /// Gets or sets the connection timeout in milliseconds.
    /// </summary>
    [Description("The connection timeout in milliseconds (optional).")]
    [DataMember(Name = "timeout", Order = 6), JsonPropertyName("timeout"), JsonPropertyOrder(6), YamlMember(Alias = "timeout", Order = 6)]
    public virtual int? Timeout { get; set; }

}
