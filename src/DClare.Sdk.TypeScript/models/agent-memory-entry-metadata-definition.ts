import { AgentMemoryMetadataResolutionStrategyDefinition } from './agent-memory-metadata-resolution-strategy-definition';
import { MemoryEntryMetadata } from './memory-entry-metadata';

/**
 * Represents the definition of the metadata of the memory entries produced by an agent's output
 */
export class AgentMemoryEntryMetadataDefinition
 {
  /**
   * Gets/sets the definition of the strategy, if any, used to dynamically resolve the metadata of a memory entry
   */
  resolution: AgentMemoryMetadataResolutionStrategyDefinition | null;
  /**
   * Gets/sets the static values to use when initializing a memory entry produced by the agent
   */
  values: MemoryEntryMetadata | null;
}