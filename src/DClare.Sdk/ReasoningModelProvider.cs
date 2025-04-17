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
/// Enumerates all supported reasoning model providers
/// </summary>
public static class ReasoningModelProvider
{

    /// <summary>
    /// Indicates Azure OpenAI
    /// </summary>
    public const string AzureOpenAI = "azure-openai";
    /// <summary>
    /// Indicates Google Gemini
    /// </summary>
    public const string Gemini = "gemini";
    /// <summary>
    /// Indicates Hugging Face
    /// </summary>
    public const string HuggingFace = "hugging-face";
    /// <summary>
    /// Indicates Mistral AI
    /// </summary>
    public const string MistralAI = "mistral";
    /// <summary>
    /// Indicates Ollama
    /// </summary>
    public const string Ollama = "ollama";
    /// <summary>
    /// Indicates Onnx
    /// </summary>
    public const string Onnx = "onnx";
    /// <summary>
    /// Indicates OpenAI
    /// </summary>
    public const string OpenAI = "openai";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
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
