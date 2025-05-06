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
/// Enumerates all supported SQL engines for memory providers.
/// </summary>
public static class SqlEngine
{

    /// <summary>
    /// MySQL (widely-used relational database engine).
    /// </summary>
    public const string MySQL = "mysql";
    /// <summary>
    /// PostgreSQL (networked relational database).
    /// </summary>
    public const string PostgreSQL = "postgresql";
    /// <summary>
    /// SQLite (embedded, file-based engine).
    /// </summary>
    public const string SQLite = "sqlite";
    /// <summary>
    /// Microsoft SQL Server.
    /// </summary>
    public const string SqlServer = "sqlserver";

    /// <summary>
    /// Returns all supported SQL engine identifiers.
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return MySQL;
        yield return PostgreSQL;
        yield return SQLite;
        yield return SqlServer;
    }

}
