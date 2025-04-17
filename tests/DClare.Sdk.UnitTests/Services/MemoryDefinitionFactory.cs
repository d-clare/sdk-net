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

internal static class MemoryDefinitionFactory
{

    internal static MemoryDefinition CreateFile() => new()
    {
        File = new()
        {
            Path = "/fake/path",
            Pattern = "*.*"
        }
    };

    internal static MemoryDefinition CreateKeyValue() => new()
    {
        KeyValue = new()
        {
            Provider = KeyValueMemoryProvider.Cache,
            Configuration = new()
            {
                { "fake-configuration-key-1", "fake-configuration-value-1" },
                { "fake-configuration-key-2", "fake-configuration-value-2" }
            }
        }
    };

    internal static MemoryDefinition CreateStatic() => new()
    {
        Static = new()
        {
            Entries = MemoryEntryDefinitionFactory.CreateCollection()
        }
    };

    internal static MemoryDefinition CreateVector() => new()
    {
        Vector = new()
        {
            Provider = VectorMemoryProvider.Qdrant,
            Configuration = new()
            {
                { "fake-configuration-1-key", "fake-configuration-1-value" },
                { "fake-configuration-2-key", "fake-configuration-2-value" },
                { "fake-configuration-3-key", "fake-configuration-3-value" }
            }
        }
    };

    internal static EquatableDictionary<string, MemoryDefinition> CreateCollection() => new()
    {
        { "file", CreateFile() },
        { "keyValue", CreateKeyValue() },
        { "static", CreateStatic() },
        { "vector", CreateVector() }
    };

}
