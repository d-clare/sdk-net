import { McpClientImplementationDefinition } from './mcp-client-implementation-definition';
import { Duration } from './duration';

/**
 * Represents the definition of the client to use to connect to an MCP server
 */
export class McpClientDefinition
 {
  /**
   * Gets/sets the definition of the client implementation to use to connect to an MCP server
   */
  implementation: McpClientImplementationDefinition;
  /**
   * Gets/sets the version of the MCP protocol to use
   */
  protocolVersion: string;
  /**
   * Gets/sets the duration, if any, after which requests to the MCP tool time out
   */
  timeout: Duration | null;
}