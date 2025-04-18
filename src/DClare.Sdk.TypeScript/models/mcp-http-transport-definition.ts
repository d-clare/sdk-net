import { EndpointDefinition } from './endpoint-definition';

/**
 * Represents the definition of an HTTP transport for the Model Context Protocol
 */
export class McpHttpTransportDefinition
 {
  /**
   * Gets/sets the endpoint at which to get the defined resource
   */
  endpoint: EndpointDefinition;
  /**
   * Gets/sets a key/value mapping, if any, of the headers to use to connect to the MCP server
   */
  headers: Record<string, string> | null;
}