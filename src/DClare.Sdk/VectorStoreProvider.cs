namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported vector store providers used to store and retrieve vector embeddings.
/// </summary>
[Description("Enumerates all supported vector store providers used to store and retrieve vector embeddings.")]
public static class VectorStoreProvider
{

    /// <summary>
    /// FAISS vector store.
    /// </summary>
    public const string Faiss = "faiss";
    /// <summary>
    /// Milvus vector store.
    /// </summary>
    public const string Milvus = "milvus";
    /// <summary>
    /// Pinecone vector store.
    /// </summary>
    public const string Pinecone = "pinecone";
    /// <summary>
    /// Qdrant vector store.
    /// </summary>
    public const string Qdrant = "qdrant";
    /// <summary>
    /// Redis with vector search.
    /// </summary>
    public const string Redis = "redis";
    /// <summary>
    /// Vespa vector store.
    /// </summary>
    public const string Vespa = "vespa";
    /// <summary>
    /// Weaviate vector store.
    /// </summary>
    public const string Weaviate = "weaviate";

    /// <summary>
    /// Returns a list of all supported vector store provider identifiers.
    /// </summary>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Faiss;
        yield return Milvus;
        yield return Pinecone;
        yield return Qdrant;
        yield return Redis;
        yield return Vespa;
        yield return Weaviate;
    }

}
