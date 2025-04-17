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
/// Represents the definition of the API used by a kernel capability
/// </summary>
[DataContract]
public record RuntimeCapabilityApiDefinition
{

    /// <summary>
    /// Gets/sets the API's endpoint
    /// </summary>
    [Required]
    [DataMember(Name = "endpoint", Order = 1), JsonPropertyName("endpoint"), JsonPropertyOrder(1), YamlMember(Alias = "endpoint", Order = 1)]
    public virtual EndpointDefinition Endpoint { get; set; } = null!;

    /// <summary>
    /// Gets/sets a key/value mapping of the additional properties required, if any, to configure the API
    /// </summary>
    [DataMember(Name = "properties", Order = 2), JsonPropertyName("properties"), JsonPropertyOrder(2), YamlMember(Alias = "properties", Order = 2)]
    public virtual EquatableDictionary<string, object>? Properties { get; set; }

}