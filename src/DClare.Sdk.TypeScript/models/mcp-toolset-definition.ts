import { McpTransportDefinition } from './mcp-transport-definition';
import { McpClientDefinition } from './mcp-client-definition';

/**
 * Represents the definition of a toolset based on the Model Context Protocol (MCP)
 */
export class McpToolsetDefinition
 {
  /**
   * Gets/sets the definition of the transport to use to connect to the MCP server
   */
  transport: McpTransportDefinition;
  /**
   * Gets/sets the definition of the client to use to connect to the MCP server
   */
  client: McpClientDefinition;
}