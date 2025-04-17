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
/// Represents the definition of the strategy used to enrich an agent's prompt context
/// </summary>
[DataContract]
public record AgentMemoryInjectionStrategyDefinition
{

    /// <summary>
    /// Gets/sets the definition of the search and filtering strategy, if any, to match relevant memory entries
    /// </summary>
    [DataMember(Name = "match", Order = 1), JsonPropertyName("match"), JsonPropertyOrder(1), YamlMember(Alias = "match", Order = 1)]
    public virtual AgentMemorySearchDefinition? Match { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, that defines how the matched memory entries should be formatted and injected
    /// </summary>
    [DataMember(Name = "format", Order = 2), JsonPropertyName("format"), JsonPropertyOrder(2), YamlMember(Alias = "format", Order = 2)]
    public virtual AgentMemoryFormatOptions? Format { get; set; }

}
