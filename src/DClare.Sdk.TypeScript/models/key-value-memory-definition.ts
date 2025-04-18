import { any } from './any';

/**
 * Represents the definition of a key-value store memory
 */
export class KeyValueMemoryDefinition
 {
  /**
   * Gets/sets the name of the key-value memory provider
   */
  provider: string;
  /**
   * Gets/sets a key/value mapping, if any, of the provider-specific properties used to configure the key-value memory
   */
  configuration: Record<string, any> | null;
}