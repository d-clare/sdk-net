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

namespace DClare.Sdk.Models.Memory;

/// <summary>
/// Represents the configuration of a SQL-based memory provider.
/// </summary>
[Description("Represents the configuration of a SQL-based memory provider.")]
[DataContract]
public record SqlMemoryConfiguration
{

    /// <summary>
    /// Gets or sets the SQL engine to use (e.g., 'sqlite', 'postgresql', 'mysql').
    /// </summary>
    [Description("The SQL engine to use (e.g., 'sqlite', 'postgresql', 'mysql').")]
    [Required, AllowedValues(SqlEngine.MySQL, SqlEngine.PostgreSQL, SqlEngine.SQLite, SqlEngine.SqlServer)]
    [DataMember(Name = "engine", Order = 1), JsonPropertyName("engine"), JsonPropertyOrder(1), YamlMember(Alias = "engine", Order = 1)]
    public virtual string Engine { get; set; } = null!;

    /// <summary>
    /// Gets or sets the connection string to the SQL database.
    /// </summary>
    [Description("The connection string to the SQL database.")]
    [DataMember(Name = "connectionString", Order = 2), JsonPropertyName("connectionString"), JsonPropertyOrder(2), YamlMember(Alias = "connectionString", Order = 2)]
    public virtual string ConnectionString { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the database used for memory storage.
    /// </summary>
    [Description("The name of the database used for memory storage.")]
    [DataMember(Name = "database", Order = 3), JsonPropertyName("database"), JsonPropertyOrder(3), YamlMember(Alias = "database", Order = 3)]
    public virtual string Database { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the table used to store memory records.
    /// </summary>
    [Description("The name of the SQL table used for storing memory records.")]
    [DataMember(Name = "table", Order = 4), JsonPropertyName("table"), JsonPropertyOrder(4), YamlMember(Alias = "table", Order = 4)]
    public virtual string Table { get; set; } = null!;

}