import { MemoryEntryMetadata } from './memory-entry-metadata';

/**
 * Represents the definition of a memory entry
 */
export class MemoryEntryDefinition
 {
  /**
   * Gets/sets the actual content or message of the memory entry
   */
  content: string;
  /**
   * Gets/sets a list of tags associated with the memory entry
   */
  metadata: MemoryEntryMetadata | null;
}