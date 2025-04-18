import { EndpointDefinition } from './endpoint-definition';

/**
 * Represents the definition of an external resource
 */
export class ExternalResourceDefinition
 {
  /**
   * Gets/sets the external resource's name, if any
   */
  name: string | null;
  /**
   * Gets/sets the endpoint at which to get the defined resource
   */
  endpoint: EndpointDefinition;
}