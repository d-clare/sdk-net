﻿// Copyright © 2025-Present The DClare Authors
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

using DClare.Sdk.Models.Authentication;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the base class for all authentication scheme definitions
/// </summary>
[DataContract]
public abstract record AuthenticationSchemeDefinition
    : Extendable
{

    /// <summary>
    /// Gets the name of the authentication scheme
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public abstract string Scheme { get; }

    /// <summary>
    /// Gets/sets the name of the secret, if any, used to configure the authentication scheme
    /// </summary>
    [DataMember(Name = "use", Order = 1), JsonPropertyName("use"), JsonPropertyOrder(1), YamlMember(Alias = "use", Order = 1)]
    public virtual string? Use { get; set; }

    /// <summary>
    /// Gets/sets the definition of the placement, if any, of the resolved authentication parameter
    /// </summary>
    [DataMember(Name = "placement", Order = 99), JsonPropertyName("placement"), JsonPropertyOrder(99), YamlMember(Alias = "placement", Order = 99)]
    public virtual AuthenticationParameterPlacementDefinition? Placement { get; set; }

}
