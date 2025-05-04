namespace DClare.Sdk.UnitTests.Services;

internal static class AgentSkillDefinitionFactory
{

    internal static AgentSkillDefinition Create() => new()
    {
        Description = "fake skill description"
    };

    internal static EquatableDictionary<string, AgentSkillDefinition> CreateCollection() => new()
    {
        { 
            "skill-1", 
            new()
            {
                Description = "Fake Skill 1 Description"
            }
        },
        {
            "skill-2",
            new()
            {
                Description = "Fake Skill 2 Description"
            }
        },
        {
            "skill-3",
            new()
            {
                Description = "Fake Skill 3 Description"
            }
        }
    };

}