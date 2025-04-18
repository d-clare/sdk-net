
/**
 * Represents the definition of an STDIO transport for the Model Context Protocol
 */
export class McpStdioTransportDefinition
 {
  /**
   * Gets/sets the Command to execute the MCP tool
   */
  command: string;
  /**
   * Gets/sets a list of arguments, if any, to pass to the command.
   */
  arguments: string[] | null;
}