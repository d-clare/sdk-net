namespace DClare.Sdk;

/// <summary>
/// Enumerates all types of agents
/// </summary>
public static class AgentType
{

    /// <summary>
    /// Indicates a fully defined, locally hosted agent whose behavior and capabilities are described inline
    /// </summary>
    public const string Hosted = "hosted";
    /// <summary>
    /// Indicates a remote agent referenced via an external endpoint
    /// </summary>
    public const string Remote = "remote";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Hosted;
        yield return Remote;
    }

}
