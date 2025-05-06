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
/// Represents the definition of a toolset based on an OpenAPI specification document.
/// </summary>
[Description("Represents the definition of a toolset based on an OpenAPI specification document.")]
[DataContract]
public record OpenApiToolsetDefinition
{

    /// <summary>
    /// Gets or sets the external OpenAPI document used to define the toolset.
    /// </summary>
    [Description("The external OpenAPI document used to define the toolset.")]
    [Required]
    [DataMember(Name = "document", Order = 1), JsonPropertyName("document"), JsonPropertyOrder(1), YamlMember(Alias = "document", Order = 1)]
    public virtual ExternalResourceDefinition Document { get; set; } = null!;

}
