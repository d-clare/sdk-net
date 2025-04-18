import { EndpointDefinition } from './endpoint-definition';
import { any } from './any';

/**
 * Represents the definition of the API used by a kernel capability
 */
export class RuntimeCapabilityApiDefinition
 {
  /**
   * Gets/sets the API's endpoint
   */
  endpoint: EndpointDefinition;
  /**
   * Gets/sets a key/value mapping of the additional properties required, if any, to configure the API
   */
  properties: Record<string, any> | null;
}