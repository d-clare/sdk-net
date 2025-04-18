import { A2AChannelConfiguration } from './a2a-channel-configuration';

/**
 * Represents the definition of protocol-specific configuration options for communicating with a remote agent
 */
export class AgentCommunicationChannelDefinition
 {
  /**
   * Gets/sets the configuration for the Agent-to-Agent (A2A) communication protocol
   */
  a2A: A2AChannelConfiguration | null;
  /**
   * Gets the agent's type
   */
  type: string;
}