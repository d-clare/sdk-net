
/**
 * Represents an object used to define how matched memory entries are rendered into the prompt,
 */
export class AgentMemoryFormatOptions
 {
  /**
   * Gets/sets a value that indicates where to inject the entries into the prompt
   */
  position: string | null;
  /**
   * Gets/sets the optional template to apply per memory entry (e.g., "- {{ content }}").
   */
  template: string | null;
  /**
   * Gets/sets the separator to use between formatted memory entries
   */
  separator: string | null;
}