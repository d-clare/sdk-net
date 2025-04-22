// Copyright � 2025-Present The DClare Authors
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
/// Represents the definition of the HTTP interface through which an application component is exposed
/// </summary>
[DataContract]
public record HttpInterfaceDefinition
{

    /// <summary>
    /// Gets/sets the relative URL path at which the component is exposed
    /// </summary>
    [Required, MinLength(1)]
    [DataMember(Name = "path", Order = 1), JsonPropertyName("path"), JsonPropertyOrder(1), YamlMember(Alias = "path", Order = 1)]
    public virtual string Path { get; set; } = null!;

    /// <summary>
    /// Gets/sets an object, if any, that describes the authentication method used to secure the access to the HTTP endpoint
    /// </summary>
    [DataMember(Name = "authentication", Order = 2), JsonPropertyName("authentication"), JsonPropertyOrder(2), YamlMember(Alias = "authentication", Order = 2)]
    public virtual SecuritySchemeDefinition? Authentication { get; set; }

}
