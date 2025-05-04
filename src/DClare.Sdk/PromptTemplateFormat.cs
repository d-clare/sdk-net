namespace DClare.Sdk;

/// <summary>
/// Enumerates the supported formats for prompt templates.
/// </summary>
public static class PromptTemplateFormat
{

    /// <summary>
    /// Echo template format — identity template that outputs exactly what is provided.
    /// </summary>
    public const string Echo = "echo";
    /// <summary>
    /// Handlebars template syntax (e.g., {{#if}}, {{variable}}).
    /// </summary>
    public const string Handlebars = "handlebars";
    /// <summary>
    /// Liquid template syntax, commonly used in Shopify and Jekyll.
    /// </summary>
    public const string Liquid = "liquid";
    /// <summary>
    /// Semantic Kernel Template Language (SKTL), the default format in Semantic Kernel.
    /// </summary>
    public const string SemanticKernel = "semantic-kernel";

    /// <summary>
    /// Returns all supported template format names.
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return SemanticKernel;
        yield return Handlebars;
        yield return Liquid;
        yield return Echo;
    }
}