// Copyright © 2025-Present The DClare Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported embedding model providers used to vectorize data.
/// </summary>
[Description("Enumerates all supported embedding model providers used to vectorize data.")]
public static class EmbeddingModelProvider
{

    /// <summary>
    /// Azure OpenAI service.
    /// </summary>
    public const string AzureOpenAI = "azure-openai";
    /// <summary>
    /// Google Gemini API.
    /// </summary>
    public const string Gemini = "gemini";
    /// <summary>
    /// Generic embedding service.
    /// </summary>
    public const string Generic = "generic";
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
        yield return Generic;
        yield return HuggingFace;
        yield return MistralAI;
        yield return Ollama;
        yield return Onnx;
        yield return OpenAI;
    }

}