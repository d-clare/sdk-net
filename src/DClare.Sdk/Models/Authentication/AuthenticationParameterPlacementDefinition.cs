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

namespace DClare.Sdk.Models.Authentication;

/// <summary>
/// Represents the definition of the placement of a resolved authentication parameter
/// </summary>
[DataContract]
public record AuthenticationParameterPlacementDefinition
{

    /// <summary>
    /// Gets or sets where to place the authentication parameter
    /// </summary>
    [Required, AllowedValues(AuthenticationParameterPlacementLocation.Cookie, AuthenticationParameterPlacementLocation.Header, AuthenticationParameterPlacementLocation.Query)]
    [DataMember(Name = "in", Order = 1), JsonPropertyName("in"), JsonPropertyOrder(1), YamlMember(Alias = "in", Order = 1)]
    public virtual string In { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the parameter, header, or cookie in which the authentication parameter will be inserted
    /// </summary>
    [Required]
    [DataMember(Name = "name", Order = 2), JsonPropertyName("name"), JsonPropertyOrder(2), YamlMember(Alias = "name", Order = 2)]
    public virtual string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets an optional prefix to prepend to the authentication parameter
    /// </summary>
    [DataMember(Name = "prefix", Order = 3), JsonPropertyName("prefix"), JsonPropertyOrder(3), YamlMember(Alias = "prefix", Order = 3)]
    public virtual string? Prefix { get; set; }

}