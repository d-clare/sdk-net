
/**
 * Represents structured metadata describing a memory entry,
 */
export class MemoryEntryMetadata
 {
  /**
   * Gets/sets the primary topic or subject of the memory entry
   */
  topic: string | null;
  /**
   * Gets/sets the category or type of content represented by this entry
   */
  category: string | null;
  /**
   * Gets/sets a list of tags, if any, used to annotate or describe the memory entry
   */
  tags: string[] | null;
  /**
   * Gets/sets the locale or language tag associated with the entry, if applicable
   */
  locale: string | null;
  /**
   * Gets/sets additional arbitrary key-value data, if any, associated to the memory entry
   */
  properties: Record<string, string> | null;
}