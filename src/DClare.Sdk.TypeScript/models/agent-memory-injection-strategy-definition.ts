import { AgentMemorySearchDefinition } from './agent-memory-search-definition';
import { AgentMemoryFormatOptions } from './agent-memory-format-options';

/**
 * Represents the definition of the strategy used to enrich an agent's prompt context
 */
export class AgentMemoryInjectionStrategyDefinition
 {
  /**
   * Gets/sets the definition of the search and filtering strategy, if any, to match relevant memory entries
   */
  match: AgentMemorySearchDefinition | null;
  /**
   * Gets/sets an object, if any, that defines how the matched memory entries should be formatted and injected
   */
  format: AgentMemoryFormatOptions | null;
}