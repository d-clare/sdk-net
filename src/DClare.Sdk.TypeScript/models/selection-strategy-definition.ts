import { KernelFunctionStrategyDefinition } from './kernel-function-strategy-definition';
/**
 * Represents a kernel function strategy used to select the agent to invoke next
 */
export class SelectionStrategyDefinition extends KernelFunctionStrategyDefinition
 {
  /**
   * Gets/sets the name of the variable used to store the list of agents to select
   */
  agentsVariableName: string;
  /**
   * Gets/sets the name of the variable used to store the chat history
   */
  historyVariableName: string;
  /**
   * Gets/sets the name of the agent to invoke first, if any
   */
  initialAgent: string | null;
}