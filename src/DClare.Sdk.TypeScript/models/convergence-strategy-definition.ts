import { DecompositionStrategyDefinition } from './decomposition-strategy-definition';
import { SynthesisStrategyDefinition } from './synthesis-strategy-definition';

/**
 * Represents the definition of the strategy used in a convergence-based agentic process
 */
export class ConvergenceStrategyDefinition
 {
  /**
   * Gets/sets the kernel function strategy, if any, used to decompose the initial prompt into specialized sub-prompts tailored to each contributing agent
   */
  decomposition: DecompositionStrategyDefinition | null;
  /**
   * Gets/sets the kernel function strategy used to synthesize the individual agent responses into a single, unified output
   */
  synthesis: SynthesisStrategyDefinition;
}