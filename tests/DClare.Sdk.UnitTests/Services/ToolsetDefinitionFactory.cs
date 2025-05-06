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

internal static class ToolsetDefinitionFactory
{

    internal static ToolsetDefinition CreateMcp()
    {
        return new()
        {
            Mcp = new()
            {
                Client = new()
                {
                    ProtocolVersion = McpProtocolVersion.v20241105,
                    Implementation = new()
                    {
                        Name = "fake-mcp-client-implementation",
                        Version = "fake-mcp-client-version"
                    }
                },
                Transport = new()
                {
                    Http = new()
                    {
                        Endpoint = new Uri("https://fake-endpoint")
                    }
                }
            }
        };
    }

    internal static ToolsetDefinition CreateOpenApi()
    {
        return new()
        {
            OpenApi = new()
            {
                Document = new()
                {
                    Name = "fake-document-name",
                    Endpoint = new Uri("https://fake-endpoint.com")
                }
            }
        };
    }

    internal static EquatableDictionary<string, ToolsetDefinition> CreateCollection()
    {
        return new()
        {
            { "mcp", CreateMcp() },
            { "openapi", CreateOpenApi() }
        };
    }

}