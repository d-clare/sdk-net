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

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of an external resource
/// </summary>
[DataContract]
public record ExternalResourceDefinition
{

    /// <summary>
    /// Gets/sets the external resource's name, if any
    /// </summary>
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string? Name { get; set; }

    /// <summary>
    /// Gets/sets the endpoint at which to get the defined resource
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 2), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(2), YamlMember(Alias = "endpoint", Order = 2)]
    public virtual EndpointDefinition Endpoint { get; set; } = null!;

}
