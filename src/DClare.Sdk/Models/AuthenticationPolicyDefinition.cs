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
/// Represents the definition of an authentication policy
/// </summary>
[DataContract]
public record AuthenticationPolicyDefinition
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets the configured authentication scheme
    /// </summary>
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Scheme => this.ApiKey?.Scheme ?? this.Bearer?.Scheme ?? this.OAuth2?.Scheme ?? this.Oidc?.Scheme ?? null!;

    /// <summary>
    /// Gets/sets the `ApiKey` authentication scheme to use, if any
    /// </summary>
    [DataMember(Name = "apikey", Order = 1), JsonPropertyName("apikey"), JsonPropertyOrder(1), YamlMember(Alias = "apikey", Order = 1)]
    public virtual ApiKeyAuthenticationSchemeDefinition? ApiKey { get; set; }

    /// <summary>
    /// Gets/sets the `Bearer` authentication scheme to use, if any
    /// </summary>
    [DataMember(Name = "bearer", Order = 1), JsonPropertyName("bearer"), JsonPropertyOrder(1), YamlMember(Alias = "bearer", Order = 1)]
    public virtual BearerAuthenticationSchemeDefinition? Bearer { get; set; }

    /// <summary>
    /// Gets/sets the `OAUTH2` authentication scheme to use, if any
    /// </summary>
    [DataMember(Name = "oauth2", Order = 1), JsonPropertyName("oauth2"), JsonPropertyOrder(1), YamlMember(Alias = "oauth2", Order = 1)]
    public virtual OAuth2AuthenticationSchemeDefinition? OAuth2 { get; set; }

    /// <summary>
    /// Gets/sets the `OIDC` authentication scheme to use, if any
    /// </summary>
    [DataMember(Name = "oidc", Order = 1), JsonPropertyName("oidc"), JsonPropertyOrder(1), YamlMember(Alias = "oidc", Order = 1)]
    public virtual OpenIDConnectSchemeDefinition? Oidc { get; set; }

}
