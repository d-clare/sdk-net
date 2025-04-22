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
/// Enumerates all supported agentic process types
/// </summary>
public static class ProcessType
{

    /// <summary>
    /// Indicates a collaboration, which is a process in which multiple agents perform their tasks sequentially with configurable selection and termination strategies
    /// </summary>
    public const string Collaboration = "collaboration";
    /// <summary>
    /// Indicates a convergence, which is a process in which multiple specialized agents are invoked using tailored sub-prompts, 
    /// and a designated strategy is use to synthesize their responses into a single cohesive result
    /// </summary>
    public const string Convergence = "convergence";

    /// <summary>
    /// Gets an <see cref="IEnumerable{T}"/> containing all supported values
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/></returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return Collaboration;
        yield return Convergence;
    }

}
