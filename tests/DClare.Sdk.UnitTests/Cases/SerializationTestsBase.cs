using DClare.Sdk.UnitTests.Services;
using Microsoft.Extensions.DependencyInjection;

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
    public void Serialize_Deserialize_A2AChannelConfiguration_Should_Work()
    {
        //arrange
        var toSerialize = new A2AChannelConfiguration()
        {
            Endpoint = new()
            {
                Uri = new("https://test.com")
            }
        };

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<A2AChannelConfiguration>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_AgentDefinition_Should_Work()
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
    public void Serialize_Deserialize_AgenticProcessDefinition_Should_Work()
    {
        //arrange
        var toSerialize = AgenticProcessDefinitionFactory.CreateConvergence();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<AgenticProcessDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_AgentSkillDefinition_Should_Work()
    {
        //arrange
        var toSerialize = AgentSkillDefinitionFactory.Create();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<AgentSkillDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_AuthenticationPolicyDefinition_Should_Work()
    {
        //arrange
        var toSerialize = AuthenticationPolicyDefinitionFactory.CreateBearer();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<AuthenticationPolicyDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_CollaborationAgenticProcessDefinition_Should_Work()
    {
        //arrange
        var toSerialize = CollaborationAgenticProcessDefinitionFactory.Create();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<CollaborationAgenticProcessDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_ComponentCollectionDefinition_Should_Work()
    {
        //arrange
        var toSerialize = ComponentCollectionDefinitionFactory.Create();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<ComponentCollectionDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_ConvergenceAgenticProcessDefinition_Should_Work()
    {
        //arrange
        var toSerialize = ConvergenceAgenticProcessDefinitionFactory.Create();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<ConvergenceAgenticProcessDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_Duration_Should_Work()
    {
        //arrange
        var toSerialize = Models.Duration.FromHours(69);

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<Models.Duration>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_EndpointDefinition_Should_Work()
    {
        //arrange
        var toSerialize = new EndpointDefinition()
        {
            Uri = new("https://fake-endpoint.com"),
            Authentication = AuthenticationPolicyDefinitionFactory.CreateOAuth2()
        };

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<EndpointDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_FileMemoryDefinition_Should_Work()
    {
        //arrange
        var toSerialize = MemoryDefinitionFactory.CreateFile();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<FileMemoryDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_HostedAgentDefinition_Should_Work()
    {
        //arrange
        var toSerialize = AgentDefinitionFactory.CreateHosted();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<HostedAgentDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_KernelDefinition_Should_Work()
    {
        //arrange
        var toSerialize = KernelDefinitionFactory.Create();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<KernelDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_KeyValueMemoryDefinition_Should_Work()
    {
        //arrange
        var toSerialize = MemoryDefinitionFactory.CreateKeyValue();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<KeyValueMemoryDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_McpToolsetDefinition_Should_Work()
    {
        //arrange
        var toSerialize = ToolsetDefinitionFactory.CreateMcp();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<McpToolsetDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_OpenApiToolsetDefinition_Should_Work()
    {
        //arrange
        var toSerialize = ToolsetDefinitionFactory.CreateOpenApi();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<OpenApiToolsetDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_RemoteAgentDefinition_Should_Work()
    {
        //arrange
        var toSerialize = AgentDefinitionFactory.CreateRemote();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<RemoteAgentDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_StaticMemoryDefinition_Should_Work()
    {
        //arrange
        var toSerialize = MemoryDefinitionFactory.CreateStatic();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<StaticMemoryDefinition>(serialized);

        //assert
        deserialized.Should().NotBeNull();
        deserialized.Should().BeEquivalentTo(deserialized);
    }

    [Fact]
    public void Serialize_Deserialize_VectorMemoryDefinition_Should_Work()
    {
        //arrange
        var toSerialize = MemoryDefinitionFactory.CreateVector();

        //act
        var serialized = Serializer.SerializeToText(toSerialize);
        var deserialized = Serializer.Deserialize<VectorMemoryDefinition>(serialized);

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