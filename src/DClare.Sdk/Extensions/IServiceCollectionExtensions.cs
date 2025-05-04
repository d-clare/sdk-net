using Neuroglia.Serialization.Yaml;

namespace DClare.Sdk;

/// <summary>
/// Defines extensions for <see cref="IServiceCollection"/>s
/// </summary>
public static class IServiceCollectionExtensions
{

    /// <summary>
    /// Adds and configures DClare services
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to configure</param>
    /// <returns>The configured <see cref="IServiceCollection"/></returns>
    public static IServiceCollection AddDClare(this IServiceCollection services)
    {
        services.AddJsonSerializer();
        services.AddYamlDotNetSerializer(options =>
        {
            YamlSerializer.DefaultSerializerConfiguration(options.Serializer);
            YamlSerializer.DefaultDeserializerConfiguration(options.Deserializer);
            options.Serializer.DisableAliases();
            options.Serializer.WithTypeConverter(new YamlOneOfConverter());
            options.Deserializer.WithNodeDeserializer(
                inner => new OneOfNodeDeserializer(inner),
                syntax => syntax.InsteadOf<JsonSchemaDeserializer>());
            options.Deserializer.WithNodeDeserializer(
               inner => new OneOfScalarDeserializer(inner),
               syntax => syntax.InsteadOf<StringEnumDeserializer>());
        });
        services.AddValidatorsFromAssemblyContaining<AgentDefinition>();
        var defaultPropertyNameResolver = ValidatorOptions.Global.PropertyNameResolver;
        ValidatorOptions.Global.PropertyNameResolver = (type, member, lambda) => member == null ? defaultPropertyNameResolver(type, member, lambda) : member.Name.ToCamelCase();
        return services;
    }

}
