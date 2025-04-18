import { AgentMemorySynthetizationStrategyDefinition } from './agent-memory-synthetization-strategy-definition';
import { AgentMemoryEntryMetadataDefinition } from './agent-memory-entry-metadata-definition';

/**
 * Represents an object that defines how an agent's output is persisted to memory
 */
export class AgentMemoryStoragePolicyDefinition
 {
  /**
   * Gets/sets the optional template to apply per memory entry (e.g., "- {{ content }}").
   */
  template: string | null;
  /**
   * Gets/sets whether to include the prompt along with the agent's output.
   */
  includePrompt: boolean | null;
  /**
   * Gets/sets the definition of the strategy, if any, to use to synthesize the agent's output before storing it into memory
   */
  synthetization: AgentMemorySynthetizationStrategyDefinition | null;
  /**
   * Gets/sets the definition of the strategy, if any, used to synthesize the agent's output before storing it into memory
   */
  metadata: AgentMemoryEntryMetadataDefinition | null;
}