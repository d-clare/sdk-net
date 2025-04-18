
/**
 * Represents the definition of the search an agent should perform on its memory to enrich its prompt context
 */
export class AgentMemorySearchDefinition
 {
  /**
   * Gets/sets the maximum number, if any, of memory entries to match
   */
  max: number | null;
  /**
   * Gets/sets the minimum similarity score required for a vector match (0.0 to 1.0)<para></para>  Only applies to vector memory sources.
   */
  similarity: number | null;
  /**
   * Gets/sets the keys to retrieve in key-value memory stores, or to pattern-match for file-based memory sources
   */
  keys: string[] | null;
  /**
   * Gets/sets the file path or glob pattern used to restrict the search in file-based memory sources
   */
  path: string | null;
  /**
   * Gets/sets the list of tags used to filter memory entries
   */
  tags: string[] | null;
  /**
   * Gets/sets an optional topic used to filter or group memory entries semantically
   */
  topic: string | null;
  /**
   * Gets/sets optional metadata filters where keys must match specified values
   */
  filters: Record<string, string> | null;
}