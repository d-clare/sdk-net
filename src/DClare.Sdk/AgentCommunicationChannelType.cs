namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported types of agent communication channels.
/// </summary>
public static class AgentCommunicationChannelType
{

    /// <summary>
    /// Indicates a communication channel using the Agent-to-Agent (A2A) protocol.
    /// </summary>
    public const string A2A = "a2a";

    /// <summary>
    /// Returns a collection of all supported communication channel types.
    /// </summary>
    /// <returns>An enumerable list of supported communication channel identifiers.</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return A2A;
    }

}
