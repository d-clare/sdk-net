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
/// Represents the configuration of an in-memory memory provider.
/// </summary>
[Description("Represents the configuration of an in-memory memory provider.")]
[DataContract]
public record InMemoryMemoryConfiguration
{

    /// <summary>
    /// Gets or sets the optional namespace or prefix for the in-memory store.
    /// </summary>
    [Description("Optional namespace or prefix for in-memory key isolation.")]
    [DataMember(Name = "prefix", Order = 1), JsonPropertyName("prefix"), JsonPropertyOrder(1), YamlMember(Alias = "prefix", Order = 1)]
    public virtual string? Prefix { get; set; }

}