
/**
 * Represents the definition of an agent's skill
 */
export class AgentSkillDefinition
 {
  /**
   * Gets/sets the skill's name
   */
  name: string;
  /**
   * Gets/sets a short human-readable description of the agent's skill or capability<para></para>  This information may be used to evaluate and select the most appropriate agent for a given task
   */
  description: string | null;
}