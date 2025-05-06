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

namespace DClare.Sdk.UnitTests.Services;

internal static class AgentSkillDefinitionFactory
{

    internal static AgentSkillDefinition Create() => new()
    {
        Description = "fake skill description"
    };

    internal static EquatableDictionary<string, AgentSkillDefinition> CreateCollection() => new()
    {
        { 
            "skill-1", 
            new()
            {
                Description = "Fake Skill 1 Description"
            }
        },
        {
            "skill-2",
            new()
            {
                Description = "Fake Skill 2 Description"
            }
        },
        {
            "skill-3",
            new()
            {
                Description = "Fake Skill 3 Description"
            }
        }
    };

}