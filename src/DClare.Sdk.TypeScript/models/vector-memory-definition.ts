import { any } from './any';

/**
 * Represents the definition of a vector memory
 */
export class VectorMemoryDefinition
 {
  /**
   * Gets/sets the name of the vector memory provider
   */
  provider: string;
  /**
   * Gets/sets a key/value mapping, if any, of the provider-specific properties used to configure the vector memory
   */
  configuration: Record<string, any> | null;
}