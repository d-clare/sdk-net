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
/// Enumerates all types of agents
/// </summary>
public static class AgentType
{

    /// <summary>
    /// Indicates a fully defined, locally hosted agent whose behavior and capabilities are described inline
    /// </summary>
    public const string Hosted = "hosted";
    /// <summary>
    /// Indicates a remote agent referenced via an external endpoint
    /// </summary>
    public const string Remote = "remote";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Hosted;
        yield return Remote;
    }

}
