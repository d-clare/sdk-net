namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported SQL engines for memory providers.
/// </summary>
public static class SqlEngine
{

    /// <summary>
    /// MySQL (widely-used relational database engine).
    /// </summary>
    public const string MySQL = "mysql";
    /// <summary>
    /// PostgreSQL (networked relational database).
    /// </summary>
    public const string PostgreSQL = "postgresql";
    /// <summary>
    /// SQLite (embedded, file-based engine).
    /// </summary>
    public const string SQLite = "sqlite";
    /// <summary>
    /// Microsoft SQL Server.
    /// </summary>
    public const string SqlServer = "sqlserver";

    /// <summary>
    /// Returns all supported SQL engine identifiers.
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return MySQL;
        yield return PostgreSQL;
        yield return SQLite;
        yield return SqlServer;
    }

}
