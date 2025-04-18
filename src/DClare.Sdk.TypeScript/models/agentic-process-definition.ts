import { CollaborationAgenticProcessDefinition } from './collaboration-agentic-process-definition';
import { ConvergenceAgenticProcessDefinition } from './convergence-agentic-process-definition';

/**
 * Represents a high-level orchestration process involving one or more agents
 */
export class AgenticProcessDefinition
 {
  /**
   * Gets/sets the collaboration process to perform
   */
  collaboration: CollaborationAgenticProcessDefinition | null;
  /**
   * Gets/sets the convergence process to perform
   */
  convergence: ConvergenceAgenticProcessDefinition | null;
  /**
   * Gets the type of agentic process
   */
  type: string;
}