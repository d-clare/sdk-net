import { RuntimeCapabilityApiDefinition } from './runtime-capability-api-definition';
import { any } from './any';

/**
 * Represents the configuration of a reasoning capability within a kernel environment
 */
export class ReasoningCapabilityDefinition
 {
  /**
   * Gets/sets the identifier of the model provider to use for reasoning
   */
  provider: string;
  /**
   * Gets/sets the model name to be used for the reasoning operation
   */
  model: string;
  /**
   * Gets/sets the definition of the reasoning API to use
   */
  api: RuntimeCapabilityApiDefinition;
  /**
   * Gets/sets the optional provider-specific parameters used when invoking the model, such as temperature, top_p, max_tokens, stop, etc.
   */
  settings: Record<string, any> | null;
}