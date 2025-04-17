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

namespace DClare.Sdk.Models;

/// <summary>
/// Represents a component definition that can be referenced
/// </summary>
[DataContract]
public abstract record ReferenceableComponentDefinition
    : ComponentDefinition, IReferenceable
{

    /// <inheritdoc/>
    [DataMember(Order = 0, Name = "use"), JsonPropertyOrder(0), JsonPropertyName("use"), YamlMember(Order = 0, Alias = "use")]
    public virtual string? Use { get; set; }

}
