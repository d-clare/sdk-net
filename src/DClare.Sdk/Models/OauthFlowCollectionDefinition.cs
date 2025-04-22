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
/// Represents an object used to configure supported OAuth Flows
/// </summary>
[DataContract]
public record OauthFlowCollectionDefinition
{

    /// <summary>
    /// Gets/sets an object, if any, used to configure the OAuth Implicit flow
    /// </summary>
    [DataMember(Name = "implicit", Order = 1), JsonPropertyName("implicit"), JsonPropertyOrder(1), YamlMember(Alias = "implicit", Order = 1)]
    public virtual OAuthFlowDefinition? Implicit { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, used to configure the OAuth Password flow
    /// </summary>
    [DataMember(Name = "password", Order = 2), JsonPropertyName("password"), JsonPropertyOrder(2), YamlMember(Alias = "password", Order = 2)]
    public virtual OAuthFlowDefinition? PasswordPassword { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, used to configure the OAuth Client Credentials flow
    /// </summary>
    [DataMember(Name = "clientCredentials", Order = 3), JsonPropertyName("clientCredentials"), JsonPropertyOrder(3), YamlMember(Alias = "clientCredentials", Order = 3)]
    public virtual OAuthFlowDefinition? ClientCredentials { get; set; }

    /// <summary>
    /// Gets/sets an object, if any, used to configure the OAuth Authorization Code flow
    /// </summary>
    [DataMember(Name = "authorizationCode", Order = 4), JsonPropertyName("authorizationCode"), JsonPropertyOrder(4), YamlMember(Alias = "authorizationCode", Order = 4)]
    public virtual OAuthFlowDefinition? AuthorizationCode { get; set; }

}
