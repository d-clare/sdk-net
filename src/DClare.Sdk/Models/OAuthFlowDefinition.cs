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
/// Represents an object used to define a supported OAuth Flow
/// </summary>
[DataContract]
public record OAuthFlowDefinition
{

    /// <summary>
    /// Gets/sets the authorization URL to be used for this flow<para></para>
    /// Required if the configured flow is `implicit` or `authorizationCode`, otherwise ignored
    /// </summary>
    [DataMember(Name = "authorizationUrl", Order = 1), JsonPropertyName("authorizationUrl"), JsonPropertyOrder(1), YamlMember(Alias = "authorizationUrl", Order = 1)]
    public virtual Uri? AuthorizationUrl { get; set; }

    /// <summary>
    /// Gets/sets the token URL to be used for this flow<para></para>
    /// Required if the configured flow is `password`, `clientCredentials` or `authorizationCode`, otherwise ignored
    /// </summary>
    [DataMember(Name = "tokenUrl", Order = 2), JsonPropertyName("tokenUrl"), JsonPropertyOrder(2), YamlMember(Alias = "tokenUrl", Order = 2)]
    public virtual Uri? TokenUrl { get; set; }

    /// <summary>
    /// Gets/sets the URL to be used for obtaining refresh tokens<para></para>
    /// Required if the configured flow is `oauth2`, otherwise ignored
    /// </summary>
    [DataMember(Name = "refreshUrl", Order = 3), JsonPropertyName("refreshUrl"), JsonPropertyOrder(3), YamlMember(Alias = "refreshUrl", Order = 3)]
    public virtual Uri? RefreshUrl { get; set; }

    /// <summary>
    /// Gets/sets a map, if any, between the name and description of available scopes for the OAuth2 security scheme
    /// </summary>
    [DataMember(Name = "scopes", Order = 4), JsonPropertyName("scopes"), JsonPropertyOrder(4), YamlMember(Alias = "scopes", Order = 4)]
    public virtual EquatableDictionary<string, string?>? Scopes { get; set; }

}