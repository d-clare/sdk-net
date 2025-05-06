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

namespace DClare.Sdk.Models;

/// <summary>
/// Represents the abstract base class for all authentication scheme definitions, including shared properties like secret reference and parameter placement.
/// </summary>
[Description("Represents the abstract base class for all authentication scheme definitions, including shared properties like secret reference and parameter placement.")]
[DataContract]
public abstract record AuthenticationSchemeDefinition 
    : ReferenceableComponentDefinition
{

    /// <summary>
    /// Gets the name of the authentication scheme (e.g., 'apikey', 'bearer', 'oauth2', 'oidc').
    /// </summary>
    [Description("The name of the authentication scheme (e.g., 'apikey', 'bearer', 'oauth2', 'oidc').")]
    [IgnoreDataMember, JsonIgnore, YamlIgnore]
    public abstract string Scheme { get; }

    /// <summary>
    /// Gets or sets a key/value mapping of the object's extension data, if any
    /// </summary>
    [DataMember(Name = "extensions", Order = 99), JsonPropertyName("extensions"), JsonPropertyOrder(99), YamlMember(Alias = "extensions", Order = 99)]
    public virtual EquatableDictionary<string, object>? Extensions { get; set; }

}
