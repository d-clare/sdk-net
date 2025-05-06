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
/// Represents the configuration of a MongoDB-based memory provider.
/// </summary>
[Description("Represents the configuration of a MongoDB-based memory provider.")]
[DataContract]
public record MongoDbMemoryConfiguration
{

    /// <summary>
    /// Gets or sets the MongoDB connection string.
    /// </summary>
    [Description("The connection string to the MongoDB instance.")]
    [Required, MinLength(1)]
    [DataMember(Name = "connectionString", Order = 1), JsonPropertyName("connectionString"), JsonPropertyOrder(1), YamlMember(Alias = "connectionString", Order = 1)]
    public virtual string ConnectionString { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the MongoDB database.
    /// </summary>
    [Description("The MongoDB database name.")]
    [Required, MinLength(1)]
    [DataMember(Name = "database", Order = 2), JsonPropertyName("database"), JsonPropertyOrder(2), YamlMember(Alias = "database", Order = 2)]
    public virtual string Database { get; set; } = null!;

    /// <summary>
    /// Gets or sets the name of the collection used for storing memory entries.
    /// </summary>
    [Description("The MongoDB collection name used for storing memory entries.")]
    [DataMember(Name = "collection", Order = 3), JsonPropertyName("collection"), JsonPropertyOrder(3), YamlMember(Alias = "collection", Order = 3)]
    public virtual string Collection { get; set; } = null!;

}
