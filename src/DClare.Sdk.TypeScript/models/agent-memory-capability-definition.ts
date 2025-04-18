import { MemoryDefinition } from './memory-definition';
import { AgentMemoryInjectionStrategyDefinition } from './agent-memory-injection-strategy-definition';
import { AgentMemoryStoragePolicyDefinition } from './agent-memory-storage-policy-definition';

/**
 * Represents the definition of an agent's memory capability
 */
export class AgentMemoryCapabilityDefinition
 {
  /**
   * Gets/sets the source of the agent's memory
   */
  source: MemoryDefinition;
  /**
   * Gets/sets an object, if any, that defines how memory is used to enrich the agent's prompt context
   */
  inject: AgentMemoryInjectionStrategyDefinition | null;
  /**
   * Gets/sets an object, if any, that defines how the agent's output is persisted to memory
   */
  store: AgentMemoryStoragePolicyDefinition | null;
}