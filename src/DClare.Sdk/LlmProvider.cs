namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported LLM runtime providers used to execute AI-backed operations.
/// </summary>
[Description("Enumerates all supported LLM runtime providers used to execute AI-backed operations.")]
public static class LlmProvider
{

    /// <summary>
    /// Azure OpenAI Service.
    /// </summary>
    public const string AzureOpenAI = "azure-openai";
    /// <summary>
    /// Google Gemini API.
    /// </summary>
    public const string Gemini = "gemini";
    /// <summary>
    /// Hugging Face inference endpoints.
    /// </summary>
    public const string HuggingFace = "hugging-face";
    /// <summary>
    /// Mistral AI APIs and hosted models.
    /// </summary>
    public const string MistralAI = "mistral";
    /// <summary>
    /// Ollama local model runtime.
    /// </summary>
    public const string Ollama = "ollama";
    /// <summary>
    /// ONNX runtime for executing locally exported models.
    /// </summary>
    public const string Onnx = "onnx";
    /// <summary>
    /// OpenAI public API.
    /// </summary>
    public const string OpenAI = "openai";

    /// <summary>
    /// Returns a list of all supported runtime provider identifiers.
    /// </summary>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return AzureOpenAI;
        yield return Gemini;
        yield return HuggingFace;
        yield return MistralAI;
        yield return Ollama;
        yield return Onnx;
        yield return OpenAI;
    }

}
