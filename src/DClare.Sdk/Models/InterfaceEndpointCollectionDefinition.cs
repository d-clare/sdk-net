// Copyright � 2025-Present The DClare Authors
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

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the definition of the access points through which an application interface is made available
/// </summary>
[DataContract]
public record InterfaceEndpointCollectionDefinition
{

    /// <summary>
    /// Gets/sets a boolean indicating whether or not the interface is publicly documented and accessible via the A2A protocol
    /// </summary>
    [DataMember(Name = "a2a", Order = 1), JsonPropertyName("a2a"), JsonPropertyOrder(1), YamlMember(Alias = "a2a", Order = 1)]
    public virtual bool A2A { get; set; }

    /// <summary>
    /// Gets/sets the HTTP-specific configuration used to expose the interface over standard web protocols
    /// </summary>
    [DataMember(Name = "http", Order = 2), JsonPropertyName("http"), JsonPropertyOrder(2), YamlMember(Alias = "http", Order = 2)]
    public virtual HttpInterfaceDefinition? Http { get; set; }

}
