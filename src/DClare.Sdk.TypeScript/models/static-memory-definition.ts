import { MemoryEntryDefinition } from './memory-entry-definition';
import { MemoryEntryDefinition } from './memory-entry-definition';

/**
 * Represents the definition of a static memory
 */
export class StaticMemoryDefinition
 {
  /**
   * Gets/sets a list of memory entries that will always be returned, typically pre-defined messages such as instructions or role definitions.
   */
  entries: MemoryEntryDefinition[] | null;
}