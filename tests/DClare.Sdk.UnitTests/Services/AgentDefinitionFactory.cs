namespace DClare.Sdk.UnitTests.Services;

internal static class AgentDefinitionFactory
{

    internal static AgentDefinition CreateHosted() => new()
    {
        Hosted = new()
        {
            Description = "Fake Description",
            Instructions = "Fake Instructions",
            Skills = AgentSkillDefinitionFactory.CreateCollection(),
            Memory = MemoryDefinitionFactory.Create(),
            Knowledge = new()
            {
                Embedding = EmbeddingModelDefinitionFactory.Create(),
                Store = VectorStoreDefinitionFactory.Create(),
                Graph = KnowledgeGraphDefinitionFactory.Create()
            },
            Llm = LlmDefinitionFactory.Create(),
            Toolsets = ToolsetDefinitionFactory.CreateCollection()
        }
    };

    internal static AgentDefinition CreateRemote() => new()
    {
        Remote = new()
        {
            Channel = AgentCommunicationChannelDefinitionFactory.CreateA2A()
        }
    };

}
