import { SelectionStrategyDefinition } from './selection-strategy-definition';
import { TerminationStrategyDefinition } from './termination-strategy-definition';

/**
 * Represents the definition of the strategy used in a collaboration-based agentic process
 */
export class CollaborationStrategyDefinition
 {
  /**
   * Gets/sets the kernel function strategy used to select which agents participate and in what order or combination
   */
  selection: SelectionStrategyDefinition;
  /**
   * Gets/sets the kernel function strategy used to determine when the collaborative process should conclude
   */
  termination: TerminationStrategyDefinition;
}