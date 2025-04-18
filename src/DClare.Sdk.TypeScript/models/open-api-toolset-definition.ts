import { ExternalResourceDefinition } from './external-resource-definition';

/**
 * Represents the definition of a toolset based on an OpenAPI specification document
 */
export class OpenApiToolsetDefinition
 {
  /**
   * Gets/sets the OpenAPI document to use
   */
  document: ExternalResourceDefinition;
}