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

    void IDisposable.Dispose()
    {
        ServiceProvider.Dispose();
        GC.SuppressFinalize(this);
    }

}
