import { KernelFunctionStrategyDefinition } from './kernel-function-strategy-definition';
/**
 * Represents a kernel function strategy responsible for combining agent responses to their respective sub-prompts into a single synthesized result
 */
export class SynthesisStrategyDefinition extends KernelFunctionStrategyDefinition
 {
  /**
   * Gets/sets the variable name used to pass the collection of agent responses to the synthesis function
   */
  responsesVariableName: string;
}