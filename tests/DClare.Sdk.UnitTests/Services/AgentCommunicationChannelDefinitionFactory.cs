namespace DClare.Sdk.UnitTests.Services;

internal static class AgentCommunicationChannelDefinitionFactory
{

    internal static AgentCommunicationChannelDefinition CreateA2A() => new()
    {
        A2A = new()
        {
            Endpoint = new Uri("https://fake-endpoint"),
            Name = "fake-agent"
        }
    };

}