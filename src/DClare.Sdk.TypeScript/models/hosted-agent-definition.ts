import { AgentSkillDefinition } from './agent-skill-definition';
import { AgentSkillDefinition } from './agent-skill-definition';
import { KernelDefinition } from './kernel-definition';
import { AgentMemoryCapabilityDefinition } from './agent-memory-capability-definition';

/**
 * Represents the definition of an hosted agent
 */
export class HostedAgentDefinition
 {
  /**
   * Gets/sets a reference to the agent definition to extend, if any
   */
  extends: string | null;
  /**
   * Gets/sets a short human-readable description of the agent's role or purpose, which is used for documentation, UI display, and prompt composition
   */
  description: string | null;
  /**
   * Gets/sets the specific instructions that guide the agent's behavior
   */
  instructions: string | null;
  /**
   * Gets/sets a list containing the agent's skills, if any
   */
  skills: AgentSkillDefinition[] | null;
  /**
   * Gets/sets the definition of the kernel that powers the agent's capabilities
   */
  kernel: KernelDefinition;
  /**
   * Gets/sets the definition of the agent's memory, if any
   */
  memory: AgentMemoryCapabilityDefinition | null;
}