import { KernelFunctionStrategyDefinition } from './kernel-function-strategy-definition';
/**
 * Represents a kernel function strategy that generates tailored sub-prompts for each agent of a convergence process
 */
export class DecompositionStrategyDefinition extends KernelFunctionStrategyDefinition
 {
  /**
   * Gets/sets the name of the variable used to store the agents to tailor subprompts for
   */
  promptVariableName: string;
  /**
   * Gets/sets the name of the variable used to store the agents to tailor subprompts for
   */
  agentsVariableName: string;
}