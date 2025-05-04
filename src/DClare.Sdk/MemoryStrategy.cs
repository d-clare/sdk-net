namespace DClare.Sdk;

/// <summary>
/// Enumerates core strategies for managing memory.
/// </summary>
public static class MemoryStrategy
{

    /// <summary>
    /// Retains the full conversation history.
    /// </summary>
    public const string Full = "full";
    /// <summary>
    /// Summarizes previous messages into a compressed representation.
    /// </summary>
    public const string Summary = "summary";
    /// <summary>
    /// Keeps a fixed-size window of recent messages.
    /// </summary>
    public const string Window = "window";

    /// <summary>
    /// Returns all supported memory strategies.
    /// </summary>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Full;
        yield return Summary;
        yield return Window;
    }

}
