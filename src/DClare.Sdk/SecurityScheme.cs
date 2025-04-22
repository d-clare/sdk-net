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

namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported security scheme types
/// </summary>
public static class SecurityScheme
{

    /// <summary>
    /// Indicates an API key-based security scheme
    /// </summary>
    public const string ApiKey = "apiKey";
    /// <summary>
    /// Indicates an HTTP authentication scheme, such as Basic or Bearer
    /// </summary>
    public const string Http = "http";
    /// <summary>
    /// Indicates a mutual TLS authentication scheme, where both client and server validate certificates
    /// </summary>
    public const string MutualTls = "mutualTls";
    /// <summary>
    /// Indicates an OAuth 2.0–based authentication scheme.
    /// </summary>
    public const string OAuth2 = "oauth2";
    /// <summary>
    /// Indicates an OpenID Connect Discovery–based authentication scheme.
    /// </summary>
    public const string OpenIdConnect = "openIdConnect";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return ApiKey;
        yield return Http;
        yield return MutualTls;
        yield return OAuth2;
        yield return OpenIdConnect;
    }

}