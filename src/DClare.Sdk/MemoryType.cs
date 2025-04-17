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
/// Enumerates all supported memory types
/// </summary>
public static class MemoryType
{

    /// <summary>
    /// Indicates a file-based memory
    /// </summary>
    public const string File = "file";
    /// <summary>
    /// Indicates a key-value store memory
    /// </summary>
    public const string KeyValue = "key-value";
    /// <summary>
    /// Indicates a static memory
    /// </summary>
    public const string Static = "static";
    /// <summary>
    /// Indicates a vector memory
    /// </summary>
    public const string Vector = "vector";

}