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

namespace DClare.Sdk.UnitTests.Cases;

public abstract class SerializationTestsBase<TSerializer>
    : IDisposable
    where TSerializer : ITextSerializer
{

    public SerializationTestsBase()
    {
        var services = new ServiceCollection();
        services.AddDClare();
        ServiceProvider = services.BuildServiceProvider();
    }

    protected ServiceProvider ServiceProvider { get; }

    protected ITextSerializer Serializer => ServiceProvider.GetRequiredService<TSerializer>();

    [Fact]
    public void SerializeDeserialize_HostedAgent_Should_Work()
    {
        //arrange
        var toSerialize = AgentDefinitionFactory.CreateHosted();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<AgentDefinition>(serialized);
        
        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void SerializeDeserialize_RemoteAgent_Should_Work()
    {
        //arrange
        var toSerialize = AgentDefinitionFactory.CreateRemote();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<AgentDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void SerializeDeserialize_Workflow_Should_Work()
    {
        //arrange
        var toSerialize = WorkflowDefinitionFactory.Create();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<WorkflowDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    void IDisposable.Dispose()
    {
        ServiceProvider.Dispose();
        GC.SuppressFinalize(this);
    }

}
