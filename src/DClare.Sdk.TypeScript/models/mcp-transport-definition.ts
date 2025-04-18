import { McpHttpTransportDefinition } from './mcp-http-transport-definition';
import { McpStdioTransportDefinition } from './mcp-stdio-transport-definition';

/**
 * Represents the definition of the transport to use to connect to an MCP server
 */
export class McpTransportDefinition
 {
  /**
   * Gets/sets the definition of an HTTP transport for the Model Context Protocol
   */
  http: McpHttpTransportDefinition | null;
  /**
   * Gets/sets the definition of an STDIO transport for the Model Context Protocol
   */
  stdio: McpStdioTransportDefinition | null;
  /**
   * Gets/sets additional transport-specific configuration, if any
   */
  options: Record<string, string> | null;
  /**
   * Gets the MCP transport's type based on which definition is present (either `Http` or `Stdio`)
   */
  type: string;
}