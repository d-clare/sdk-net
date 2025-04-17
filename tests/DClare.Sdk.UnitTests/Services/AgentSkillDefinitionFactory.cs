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

namespace DClare.Sdk.UnitTests.Services;

internal static class AgentSkillDefinitionFactory
{

    internal static AgentSkillDefinition Create(string name = "fake-skill-name", string description = "fake-skill-description") => new()
    {
        Name = name,
        Description = description
    };

    internal static EquatableList<AgentSkillDefinition> CreateCollection(int length = 3)
    {
        var skills = new List<AgentSkillDefinition>(length);
        for (int i = 0; i < length; i++) skills.Add(Create($"fake-skill-{i}-name", $"fake-skill-{i}-description"));
        return [..skills];
    }

}
