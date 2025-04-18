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

namespace DClare.Sdk;

/// <summary>
/// Enumerates all supported locations for the placement of an authentication parameter
/// </summary>
public static class AuthenticationParameterPlacementLocation
{

    /// <summary>
    /// Indicates that the authentication parameter is placed in a cookie
    /// </summary>
    public const string Cookie = "cookie";
    /// <summary>
    /// Indicates that the authentication parameter is placed in a header
    /// </summary>
    public const string Header = "header";
    /// <summary>
    /// Indicates that the authentication parameter is placed in the request's query
    /// </summary>
    public const string Query = "query";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Cookie;
        yield return Header;
        yield return Query;
    }

}