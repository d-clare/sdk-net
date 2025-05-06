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
/// Represents the definition of an external resource that can be fetched via an endpoint.
/// </summary>
[Description("Represents the definition of an external resource that can be fetched via an endpoint.")]
[DataContract]
public record ExternalResourceDefinition
{

    /// <summary>
    /// Gets or sets an optional name for the external resource.
    /// </summary>
    [Description("An optional name used to identify the external resource.")]
    [DataMember(Name = "name", Order = 1), JsonPropertyName("name"), JsonPropertyOrder(1), YamlMember(Alias = "name", Order = 1)]
    public virtual string? Name { get; set; }

    /// <summary>
    /// Gets or sets the endpoint definition used to retrieve the external resource.
    /// </summary>
    [Description("The endpoint definition used to retrieve the external resource.")]
    [Required]
    [DataMember(Name = "endpoint", Order = 2), JsonInclude, JsonPropertyName("endpoint"), JsonPropertyOrder(2), YamlMember(Alias = "endpoint", Order = 2)]
    public virtual OneOf<EndpointDefinition, Uri> Endpoint { get; set; } = null!;

}
