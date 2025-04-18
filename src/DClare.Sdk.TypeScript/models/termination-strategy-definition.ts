import { KernelFunctionStrategyDefinition } from './kernel-function-strategy-definition';
/**
 * Represents a kernel function strategy used to determine whether or not to terminate the chat
 */
export class TerminationStrategyDefinition extends KernelFunctionStrategyDefinition
 {
  /**
   * Gets/sets the name of the variable used to store the name of the agent being evaluated
   */
  agentVariableName: string;
  /**
   * Gets/sets the name of the variable used to store the chat history
   */
  historyVariableName: string;
  /**
   * Gets/sets a list containing the names of the agents for which this strategy is applicable<para></para>  By default value, any agent is evaluated
   */
  agents: string[] | null;
  /**
   * Gets/sets the maximum number of agent interactions for a given chat invocation
   */
  maximumIterations: number;
}