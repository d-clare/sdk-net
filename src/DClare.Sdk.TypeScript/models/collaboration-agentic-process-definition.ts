import { AgentDefinition } from './agent-definition';
import { CollaborationStrategyDefinition } from './collaboration-strategy-definition';

/**
 * Represents an agentic process in which multiple agents perform their tasks sequentially with configurable selection and termination strategies
 */
export class CollaborationAgenticProcessDefinition
 {
  /**
   * Gets/sets the collection of named agents that participate in this process
   */
  agents: Record<string, AgentDefinition>;
  /**
   * Gets/sets the definition of the collaboration process's strategy, if any
   */
  strategy: CollaborationStrategyDefinition;
}