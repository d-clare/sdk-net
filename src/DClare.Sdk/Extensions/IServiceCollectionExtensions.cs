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
            var mapEntryConverter = new YamlMapEntryConverter(() => options.Serializer.Build(), () => options.Deserializer.Build());
            options.Deserializer.WithTypeConverter(mapEntryConverter);
            options.Serializer.WithTypeConverter(mapEntryConverter);
            options.Serializer.WithTypeConverter(new YamlOneOfConverter());
            options.Deserializer.WithNodeDeserializer(
                 inner => new YamlTaskDefinitionDeserializer(inner),
                 syntax => syntax.InsteadOf<JsonSchemaDeserializer>());
            options.Deserializer.WithNodeDeserializer(
                inner => new YamlOneOfNodeDeserializer(inner),
                syntax => syntax.InsteadOf<YamlTaskDefinitionDeserializer>());
            options.Deserializer.WithNodeDeserializer(
               inner => new YamlOneOfScalarDeserializer(inner),
               syntax => syntax.InsteadOf<StringEnumDeserializer>());
        });
        services.AddValidatorsFromAssemblyContaining<AgentDefinition>();
        var defaultPropertyNameResolver = ValidatorOptions.Global.PropertyNameResolver;
        ValidatorOptions.Global.PropertyNameResolver = (type, member, lambda) => member == null ? defaultPropertyNameResolver(type, member, lambda) : member.Name.ToCamelCase();
        return services;
    }

}
