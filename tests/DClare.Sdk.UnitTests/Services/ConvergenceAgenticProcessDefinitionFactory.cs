﻿// Copyright � 2025-Present The DClare Authors
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

internal static class ConvergenceAgenticProcessDefinitionFactory
{

    internal static ConvergenceAgenticProcessDefinition Create() => new()
    {
        Agents = new()
        {
            { "hosted", AgentDefinitionFactory.CreateHosted() },
            { "remote", AgentDefinitionFactory.CreateRemote() }
        },
        Strategy = new()
        {
            Decomposition = new()
            {
                AgentsVariableName = "agents",
                PromptVariableName = "prompt",
                Function = KernelFunctionDefinitionFactory.Create(),
                Kernel = KernelDefinitionFactory.Create()
            },
            Synthesis = new()
            {
                InputsVariableName = "responses",
                Function = KernelFunctionDefinitionFactory.Create(),
                Kernel = KernelDefinitionFactory.Create()
            }
        }
    };

}
