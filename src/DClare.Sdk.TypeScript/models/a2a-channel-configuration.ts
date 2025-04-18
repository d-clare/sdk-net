import { EndpointDefinition } from './endpoint-definition';

/**
 * Configuration settings specific to the A2A (Agent-to-Agent) communication protocol.
 */
export class A2AChannelConfiguration
 {
  /**
   * Gets/sets the endpoint of the remote host used to perform A2A agent discovery<para></para>  This is not the agent’s direct message endpoint, but rather the host through which the agent is resolved
   */
  endpoint: EndpointDefinition;
  /**
   * Gets/sets the name or identifier of the remote agent to select from the A2A discovery endpoint, in case multiple agents are available at the same host
   */
  name: string | null;
}