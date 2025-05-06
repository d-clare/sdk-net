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

using DClare.Sdk.Models.Authentication;

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of an authentication policy used to authorize access to external services or APIs.
/// </summary>
[Description("Represents the definition of an authentication policy used to authorize access to external services or APIs.")]
[DataContract]
public record AuthenticationPolicyDefinition 
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets the configured authentication scheme based on the first non-null scheme defined.
    /// </summary>
    [Description("The resolved authentication scheme name based on the first defined scheme in priority order (ApiKey, Bearer, OAuth2, OIDC).")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public virtual string Scheme => this.ApiKey?.Scheme ?? this.Bearer?.Scheme ?? this.OAuth2?.Scheme ?? this.Oidc?.Scheme ?? null!;

    /// <summary>
    /// Gets or sets the API key authentication scheme to use, if any.
    /// </summary>
    [Description("Defines an API key authentication scheme, typically using headers or query parameters.")]
    [DataMember(Name = "apikey", Order = 1), JsonPropertyName("apikey"), JsonPropertyOrder(1), YamlMember(Alias = "apikey", Order = 1)]
    public virtual ApiKeyAuthenticationSchemeDefinition? ApiKey { get; set; }

    /// <summary>
    /// Gets or sets the Bearer token authentication scheme to use, if any.
    /// </summary>
    [Description("Defines a Bearer token authentication scheme using an access token in the Authorization header.")]
    [DataMember(Name = "bearer", Order = 1), JsonPropertyName("bearer"), JsonPropertyOrder(1), YamlMember(Alias = "bearer", Order = 1)]
    public virtual BearerAuthenticationSchemeDefinition? Bearer { get; set; }

    /// <summary>
    /// Gets or sets the OAuth 2.0 authentication scheme to use, if any.
    /// </summary>
    [Description("Defines an OAuth 2.0 authentication scheme with support for various grant types.")]
    [DataMember(Name = "oauth2", Order = 1), JsonPropertyName("oauth2"), JsonPropertyOrder(1), YamlMember(Alias = "oauth2", Order = 1)]
    public virtual OAuth2AuthenticationSchemeDefinition? OAuth2 { get; set; }

    /// <summary>
    /// Gets or sets the OpenID Connect (OIDC) authentication scheme to use, if any.
    /// </summary>
    [Description("Defines an OpenID Connect authentication scheme for federated identity and token management.")]
    [DataMember(Name = "oidc", Order = 1), JsonPropertyName("oidc"), JsonPropertyOrder(1), YamlMember(Alias = "oidc", Order = 1)]
    public virtual OpenIDConnectSchemeDefinition? Oidc { get; set; }

}
