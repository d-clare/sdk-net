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
/// Defines extensions for <see cref="ComponentDefinitionCollection"/>s
/// </summary>
public static class ComponentDefinitionCollectionExtensions
{

    /// <summary>
    /// Gets the specified <see cref="ReferenceableComponentDefinition"/>.
    /// </summary>
    /// <typeparam name="TComponent">The type of the <see cref="ReferenceableComponentDefinition"/> to get.</typeparam>
    /// <param name="collection">The <see cref="ComponentDefinitionCollection"/> that defines the <see cref="ReferenceableComponentDefinition"/> to get.</param>
    /// <param name="name">The name of the <see cref="ReferenceableComponentDefinition"/> to get.</param>
    /// <returns>The <see cref="ReferenceableComponentDefinition"/> with the specified name, if any.</returns>
    public static TComponent? Get<TComponent>(this ComponentDefinitionCollection collection, string name) where TComponent : ReferenceableComponentDefinition => (TComponent?)collection.Get(typeof(TComponent), name);

    /// <summary>
    /// Gets the specified <see cref="ReferenceableComponentDefinition"/>.
    /// </summary>
    /// <param name="collection">The <see cref="ComponentDefinitionCollection"/> that defines the <see cref="ReferenceableComponentDefinition"/> to get.</param>
    /// <param name="type">The The type of the <see cref="ReferenceableComponentDefinition"/> to get.</param>
    /// <param name="name">The name of the <see cref="ReferenceableComponentDefinition"/> to get.</param>
    /// <returns>The <see cref="ReferenceableComponentDefinition"/> with the specified name, if any.</returns>
    public static ReferenceableComponentDefinition? Get(this ComponentDefinitionCollection collection, Type type, string name)
    {
        ArgumentNullException.ThrowIfNull(collection);
        ArgumentNullException.ThrowIfNull(type);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        if (type == typeof(AuthenticationPolicyDefinition))
        {
            if (collection.Authentications?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(ToolsetDefinition))
        {
            if (collection.Toolsets?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(PromptTemplateDefinition))
        {
            if (collection.Prompts?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(FunctionDefinition))
        {
            if (collection.Functions?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(MemoryDefinition))
        {
            if (collection.Memories?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(EmbeddingModelDefinition))
        {
            if (collection.EmbeddingModels?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(VectorStoreDefinition))
        {
            if (collection.VectorStores?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(VectorCollectionDefinition))
        {
            if (collection.VectorCollections?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(KnowledgeGraphDefinition))
        {
            if (collection.Graphs?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(LlmDefinition))
        {
            if (collection.Llms?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        if (type == typeof(AgentDefinition))
        {
            if (collection.Agents?.TryGetValue(name, out var component) == true) return component;
            else return null;
        }
        return null;
    }

}