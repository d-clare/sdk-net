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
/// Represents the definition of an endpoint
/// </summary>
[Description("Represents the definition of an endpoint.")]
[DataContract]
public record EndpointDefinition
{

    /// <summary>
    /// Gets or sets the endpoint URI.
    /// </summary>
    [Description("The endpoint URI.")]
    [Required, DataType(DataType.Url)]
    [DataMember(Name = "uri", Order = 1), JsonPropertyName("uri"), JsonPropertyOrder(1), YamlMember(Alias = "uri", Order = 1)]
    public virtual Uri? Uri { get; set; } = null!;

    /// <summary>
    /// Gets or sets the authentication policy required to access the API endpoint, if any.
    /// </summary>
    [Description("The authentication policy required to access the API endpoint, if any.")]
    [DataMember(Name = "authentication", Order = 2), JsonPropertyName("authentication"), JsonPropertyOrder(2), YamlMember(Alias = "authentication", Order = 2)]
    public virtual AuthenticationPolicyDefinition? Authentication { get; set; }

}