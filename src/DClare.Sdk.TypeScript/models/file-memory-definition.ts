
/**
 * Represents the definition of a file-backed memory
 */
export class FileMemoryDefinition
 {
  /**
   * Gets/sets the path to the directory used as the memory source
   */
  path: string;
  /**
   * Gets/sets the optional file glob pattern to match files in the directory
   */
  pattern: string | null;
}