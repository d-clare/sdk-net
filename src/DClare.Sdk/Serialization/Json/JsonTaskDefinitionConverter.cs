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

using DClare.Sdk.Models.Tasks;

namespace DClare.Sdk.Serialization.Json;

/// <summary>
/// Represents the <see cref="JsonConverter"/> used to serialize and deserialize <see cref="TaskDefinition"/>s to/from JSON
/// </summary>
public class JsonTaskDefinitionConverter
    : JsonConverter<TaskDefinition>
{

    /// <inheritdoc/>
    public override TaskDefinition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject) throw new JsonException("Expected start of object");
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        if (root.TryGetProperty(nameof(AskTaskDefinition.Ask).ToCamelCase(), out _)) return JsonSerializer.Deserialize<AskTaskDefinition>(root.GetRawText(), options)!;
        else if (root.TryGetProperty(nameof(CallTaskDefinition.Call).ToCamelCase(), out _)) return JsonSerializer.Deserialize<CallTaskDefinition>(root.GetRawText(), options)!;
        else if (root.TryGetProperty(nameof(ForTaskDefinition.For).ToCamelCase(), out _)) return JsonSerializer.Deserialize<ForTaskDefinition>(root.GetRawText(), options)!;
        else if (root.TryGetProperty(nameof(SetTaskDefinition.Set).ToCamelCase(), out _)) return JsonSerializer.Deserialize<SetTaskDefinition>(root.GetRawText(), options)!;
        else if (root.TryGetProperty(nameof(DoTaskDefinition.Sequentially).ToCamelCase(), out _) || root.TryGetProperty(nameof(DoTaskDefinition.Simultaneously).ToCamelCase(), out _)) return JsonSerializer.Deserialize<DoTaskDefinition>(root.GetRawText(), options)!;
        else throw new Exception("Unrecognized or unsupported task type");
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, TaskDefinition value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value, value.GetType(), options);

}