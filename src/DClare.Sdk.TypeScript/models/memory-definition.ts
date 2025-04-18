import { FileMemoryDefinition } from './file-memory-definition';
import { KeyValueMemoryDefinition } from './key-value-memory-definition';
import { StaticMemoryDefinition } from './static-memory-definition';
import { VectorMemoryDefinition } from './vector-memory-definition';

/**
 * Represents the definition of a memory capability
 */
export class MemoryDefinition
 {
  /**
   * Gets/sets the definition of a file-backed memory that loads entries from structured files in the local or remote file system
   */
  file: FileMemoryDefinition | null;
  /**
   * Gets/sets the definition of a key-value store memory that retrieves entries based on keys or tags
   */
  keyValue: KeyValueMemoryDefinition | null;
  /**
   * Gets/sets the definition of a static memory that returns predefined values without kernel lookup
   */
  static: StaticMemoryDefinition | null;
  /**
   * Gets/sets the definition of a vector memory that retrieves entries using semantic similarity and vector search
   */
  vector: VectorMemoryDefinition | null;
  /**
   * Gets the memory's type based on which definition is present
   */
  type: string;
}