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

internal static class AgentDefinitionFactory
{

    internal static AgentDefinition CreateHosted() => new()
    {
        Hosted = new()
        {
            Extends = "fake-reference",
            Description = "fake description",
            Instructions = "fake instructions",
            Skills = AgentSkillDefinitionFactory.CreateCollection(),
            Kernel = KernelDefinitionFactory.Create(),
            Memory = new()
            {
                Source = MemoryDefinitionFactory.CreateFile(),
                Inject = new()
                {
                    Format = new()
                    {
                        Position = MemoryInjectionPosition.After,
                        Separator = DClareDefaults.MemoryEntrySeparator,
                        Template = "fake-template"
                    },
                    Match = new()
                    {
                        Keys = ["*.fake-key"],
                        Max = 10
                    }
                }
            }
        }
    };

    internal static AgentDefinition CreateRemote() => new()
    {
        Remote = new()
        {
            Channel = new()
            {
                A2A = new()
                {
                    Endpoint = new()
                    {
                        Uri = new("https://fake-endpoint.com")
                    }
                }
            }
        }
    };

    internal static EquatableDictionary<string, AgentDefinition> CreateCollection() => new()
    {
        { "hosted", CreateHosted() },
        { "remote", CreateRemote() }
    };

}
