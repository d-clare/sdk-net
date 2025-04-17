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
/// Represents the definition of an OAUTH2 authentication scheme
/// </summary>
[DataContract]
public record OAuth2AuthenticationSchemeDefinition
    : OAuth2AuthenticationSchemeDefinitionBase
{

    /// <inheritdoc/>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public override string Scheme => AuthenticationScheme.OAuth2;

    /// <summary>
    /// Gets/sets the configuration of the OAUTH2 endpoints to use
    /// </summary>
    [DataMember(Name = "endpoints", Order = 2), JsonPropertyName("endpoints"), JsonPropertyOrder(2), YamlMember(Alias = "endpoints", Order = 2)]
    public virtual OAuth2AuthenticationEndpointsDefinition Endpoints { get; set; } = new();

}
