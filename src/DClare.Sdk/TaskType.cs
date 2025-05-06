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
/// Exposes all types of tasks supported by DClare workflows.
/// </summary>
public static class TaskType
{

    /// <summary>
    /// Gets the 'ask' task type.
    /// </summary>
    public const string Ask = "ask";
    /// <summary>
    /// Gets the 'call' task type.
    /// </summary>
    public const string Call = "call";
    /// <summary>
    /// Gets the 'do' task type.
    /// </summary>
    public const string Do = "do";
    /// <summary>
    /// Gets the 'for' task type.
    /// </summary>
    public const string For = "for";
    /// <summary>
    /// Gets the 'set' task type.
    /// </summary>
    public const string Set = "set";

    /// <summary>
    /// Gets a new <see cref="IEnumerable{T}"/> containing all supported task types 
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Ask;
        yield return Call;
        yield return Do;
        yield return For;
        yield return Set;
    }

}