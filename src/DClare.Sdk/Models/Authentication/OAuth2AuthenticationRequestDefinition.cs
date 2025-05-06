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
/// Represents the configuration of an OAuth 2.0 authentication request, including the expected content encoding.
/// </summary>
[Description("Represents the configuration of an OAuth 2.0 authentication request, including the expected content encoding.")]
[DataContract]
public record OAuth2AuthenticationRequestDefinition
{

    /// <summary>
    /// Gets or sets the encoding format to use for the authentication request payload.
    /// Defaults to 'application/x-www-form-urlencoded'.
    /// </summary>
    [Description("The encoding format for the authentication request (e.g., 'application/x-www-form-urlencoded', 'application/json'). Defaults to 'application/x-www-form-urlencoded'.")]
    [DataMember(Name = "encoding", Order = 1), JsonPropertyName("encoding"), JsonPropertyOrder(1), YamlMember(Alias = "encoding", Order = 1)]
    public virtual string Encoding { get; set; } = OAuth2RequestEncoding.FormUrl;

}
