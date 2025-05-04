namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported graph providers used for knowledge graph traversal and storage.
/// </summary>
[Description("Enumerates all supported graph providers used for knowledge graph traversal and storage.")]
public static class KnowledgeGraphProvider
{

    /// <summary>
    /// ArangoDB graph database.
    /// </summary>
    public const string ArangoDb = "arangodb";
    /// <summary>
    /// AWS Neptune graph database.
    /// </summary>
    public const string Neptune = "neptune";
    /// <summary>
    /// Neo4j graph database.
    /// </summary>
    public const string Neo4j = "neo4j";

    /// <summary>
    /// Returns a list of all supported graph provider identifiers.
    /// </summary>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return ArangoDb;
        yield return Neptune;
        yield return Neo4j;
    }
}
