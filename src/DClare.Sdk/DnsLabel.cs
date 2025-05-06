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
/// Exposes constants about RFC 1123 DNS Labels
/// </summary>
public static class DnsLabel
{

    /// <summary>
    /// The minimum length of a valid DNS label.
    /// </summary>
    public const int MinLength = 1;
    /// <summary>
    /// The maximum length of a valid DNS label, as per RFC 1123.
    /// </summary>
    public const int MaxLength = 63;
    /// <summary>
    /// A regular expression that matches valid DNS labels (RFC 1123).
    /// </summary>
    /// <remarks>
    /// A valid DNS label:
    /// - Must consist of lower-case alphanumeric characters and hyphens ('-')
    /// - Must start and end with an alphanumeric character
    /// - Must be between 1 and 63 characters long
    /// </remarks>
    public const string Regex = "^[a-z0-9]([-a-z0-9]*[a-z0-9])?$";

}