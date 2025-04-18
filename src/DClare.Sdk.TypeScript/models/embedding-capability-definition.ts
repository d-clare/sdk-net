import { RuntimeCapabilityApiDefinition } from './runtime-capability-api-definition';

/**
 * Represents the configuration of a embedding capability within a kernel environment
 */
export class EmbeddingCapabilityDefinition
 {
  /**
   * Gets/sets the identifier of the model provider to use for embeddings.
   */
  provider: string;
  /**
   * Gets/sets the model name to be used for the embedding operation.
   */
  model: string;
  /**
   * Gets/sets the definition of the embedding API to use
   */
  api: RuntimeCapabilityApiDefinition;
}