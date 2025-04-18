import { AgentCommunicationChannelDefinition } from './agent-communication-channel-definition';

/**
 * Represents the definition of a remote agent
 */
export class RemoteAgentDefinition
 {
  /**
   * Gets/sets the communication channel used to interact with the remote agent
   */
  channel: AgentCommunicationChannelDefinition;
}