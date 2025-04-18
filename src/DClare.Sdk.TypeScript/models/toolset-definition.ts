import { ReferenceableComponentDefinition } from './referenceable-component-definition';import { McpToolsetDefinition } from './mcp-toolset-definition';
import { OpenApiToolsetDefinition } from './open-api-toolset-definition';

/**
 * Represents the definition of a toolset
 */
export class ToolsetDefinition extends ReferenceableComponentDefinition
 {
  /**
   * Gets/sets the definition of a toolset based on the Model Context Protocol (MCP)
   */
  mcp: McpToolsetDefinition | null;
  /**
   * Gets/sets the definition of a toolset based on an OpenAPI specification document
   */
  openApi: OpenApiToolsetDefinition | null;
  /**
   * Gets the toolset's type based on which definition is present (either MCP or OpenAPI)
   */
  type: string;
}