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

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the configuration of a reasoning capability within a kernel environment
/// </summary>
[DataContract]
public record ReasoningCapabilityDefinition
{

    /// <summary>
    /// Gets/sets the identifier of the model provider to use for reasoning
    /// </summary>
    [Required, MinLength(1), AllowedValues(ReasoningModelProvider.AzureOpenAI, ReasoningModelProvider.Gemini, ReasoningModelProvider.HuggingFace, ReasoningModelProvider.MistralAI, ReasoningModelProvider.Ollama, ReasoningModelProvider.Onnx, ReasoningModelProvider.OpenAI)]
    [DataMember(Name = "provider", Order = 1), JsonPropertyName("provider"), JsonPropertyOrder(1), YamlMember(Alias = "provider", Order = 1)]
    public virtual string Provider { get; set; } = null!;

    /// <summary>
    /// Gets/sets the model name to be used for the reasoning operation
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "model", Order = 2), JsonPropertyName("model"), JsonPropertyOrder(2), YamlMember(Alias = "model", Order = 2)]
    public virtual string Model { get; set; } = null!;

    /// <summary>
    /// Gets/sets the definition of the reasoning API to use
    /// </summary>
    [Required]
    [DataMember(Name = "api", Order = 3), JsonPropertyName("api"), JsonPropertyOrder(3), YamlMember(Alias = "api", Order = 3)]
    public virtual RuntimeCapabilityApiDefinition Api { get; set; } = null!;

    /// <summary>
    /// Gets/sets the optional provider-specific parameters used when invoking the model, such as temperature, top_p, max_tokens, stop, etc.
    /// </summary>
    [DataMember(Name = "settings", Order = 4), JsonPropertyName("settings"), JsonPropertyOrder(4), YamlMember(Alias = "settings", Order = 4)]
    public virtual EquatableDictionary<string, object>? Settings { get; set; }

}
