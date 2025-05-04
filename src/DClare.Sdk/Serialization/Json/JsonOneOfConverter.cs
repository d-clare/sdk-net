namespace DClare.Sdk.Serialization.Json;

/// <summary>
/// Represents the <see cref="JsonConverterFactory"/> used to serialize/deserialize to/from <see cref="IOneOf"/> instances
/// </summary>
public class JsonOneOfConverter
    : JsonConverterFactory
{

    static readonly ConcurrentDictionary<Type, JsonConverter> ConverterCache = new();

    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert)
    {
        if (!typeToConvert.IsGenericType) return false;
        var genericType = typeToConvert.GetGenericTypeDefinition();
        return genericType == typeof(OneOf<,>);
    }

    /// <inheritdoc/>
    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        return ConverterCache.GetOrAdd(typeToConvert, (type) =>
        {
            var typeArgs = type.GetGenericArguments();
            var converterType = typeof(OneOfConverterInner<,>).MakeGenericType(typeArgs);
            return (JsonConverter?)Activator.CreateInstance(converterType)!;
        });
    }

    class OneOfConverterInner<T1, T2> : JsonConverter<OneOf<T1, T2>>
    {

        /// <inheritdoc/>
        public override OneOf<T1, T2>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null) return null;
            var document = JsonDocument.ParseValue(ref reader);
            var rootElement = document.RootElement;
            try
            {
                var value1 = JsonSerializer.Deserialize<T1>(rootElement.GetRawText(), options);
                if (value1 != null) return new OneOf<T1, T2>(value1);
            }
            catch (JsonException) { }
            try
            {
                var value2 = JsonSerializer.Deserialize<T2>(rootElement.GetRawText(), options);
                if (value2 != null) return new OneOf<T1, T2>(value2);
            }
            catch (JsonException) { throw new JsonException($"Cannot deserialize {rootElement.GetRawText()} as either {typeof(T1).Name} or {typeof(T2).Name}"); }
            throw new JsonException("Unexpected error during deserialization.");
        }

        public override void Write(Utf8JsonWriter writer, OneOf<T1, T2> value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }
            switch (value.TypeIndex)
            {
                case 1:
                    JsonSerializer.Serialize(writer, value.T1Value, options);
                    break;
                case 2:
                    JsonSerializer.Serialize(writer, value.T2Value, options);
                    break;
                default:
                    throw new JsonException("Invalid index value.");
            }
        }

    }

}
