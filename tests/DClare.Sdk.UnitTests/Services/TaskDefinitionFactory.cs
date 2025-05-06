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

using DClare.Sdk.Models.Tasks;

namespace DClare.Sdk.UnitTests.Services;

internal static class TaskDefinitionFactory
{

    internal static AskTaskDefinition CreateAsk() => new()
    {
        Ask = new()
        {
            Agent = "fake-agent",
            To = "Fake "
        }
    };

    internal static CallTaskDefinition CreateCall() => new()
    {
        Call = FunctionDefinitionFactory.Create(),
        With = new()
        {
            { "fake-parameter-1", "fake-parameter-2" }
        }
    };

    internal static DoTaskDefinition CreateDo() => new()
    {
        Sequentially =
        [
            new("subtask-1", CreateAsk()),
            new("subtask-2", CreateCall()),
            new("subtask-3", CreateSet())
        ]
    };

    internal static ForTaskDefinition CreateFor() => new()
    {
        For = new()
        {
            Each = "fake-item",
            In = "fake-items",
            At = "fake-index"
        },
        Do = 
        [
            new("subtask-1", CreateAsk()),
            new("subtask-2", CreateCall()),
            new("subtask-3", CreateSet())
        ]
    };

    internal static SetTaskDefinition CreateSet() => new()
    {
        Set = new()
        {
            { "fake-parameter-1", "fake-parameter-2" }
        }
    };

}
