import { ReferenceableComponentDefinition } from './referenceable-component-definition';import { HostedAgentDefinition } from './hosted-agent-definition';
import { RemoteAgentDefinition } from './remote-agent-definition';

/**
 * Represents the definition of an agent
 */
export class AgentDefinition extends ReferenceableComponentDefinition
 {
  /**
   * Gets/sets an object used to configure an hosted agent
   */
  hosted: HostedAgentDefinition | null;
  /**
   * Gets/sets an object used to configure a remote agent
   */
  remote: RemoteAgentDefinition | null;
  /**
   * Gets the agent's type
   */
  type: string;
}