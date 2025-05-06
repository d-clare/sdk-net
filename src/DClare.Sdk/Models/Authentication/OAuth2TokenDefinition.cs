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
/// Represents the definition of an OAuth 2.0 token, typically used in token exchange or delegation flows.
/// </summary>
[Description("Represents the definition of an OAuth 2.0 token, typically used in token exchange or delegation flows.")]
[DataContract]
public record OAuth2TokenDefinition
{

    /// <summary>
    /// Gets or sets the actual security token value to use (e.g., JWT or opaque token).
    /// </summary>
    [Description("The actual security token value (e.g., JWT or opaque token) used in the OAuth 2.0 flow.")]
    [DataMember(Name = "token", Order = 1), JsonPropertyName("token"), JsonPropertyOrder(1), YamlMember(Alias = "token", Order = 1)]
    public required virtual string Token { get; set; }

    /// <summary>
    /// Gets or sets the type of the token (e.g., 'access_token', 'id_token', or custom type).
    /// </summary>
    [Description("The type of the token (e.g., 'access_token', 'id_token', or another custom token type).")]
    [DataMember(Name = "type", Order = 2), JsonPropertyName("type"), JsonPropertyOrder(2), YamlMember(Alias = "type", Order = 2)]
    public required virtual string Type { get; set; }

}
