namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported conversation memory providers
/// </summary>
public static class MemoryProvider
{

    /// <summary>
    /// Indicates a file-based memory
    /// </summary>
    public const string File = "file";
    /// <summary>
    /// Indicates an in-memory (ephemeral) memory provider, useful for testing or short-lived sessions
    /// </summary>
    public const string Memory = "memory";
    /// <summary>
    /// Indicates a MongoDB-based memory
    /// </summary>
    public const string MongoDB = "mongodb";
    /// <summary>
    /// Indicates a Redis-based memory
    /// </summary>
    public const string Redis = "redis";
    /// <summary>
    /// Indicates a SQL-based memory
    /// </summary>
    public const string Sql = "sql";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return File;
        yield return Memory;
        yield return MongoDB;
        yield return Redis;
        yield return Sql;
    }

}