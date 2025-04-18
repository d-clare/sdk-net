import { AgentDefinition } from './agent-definition';
import { ConvergenceStrategyDefinition } from './convergence-strategy-definition';

/**
 * Represents an agentic process in which multiple specialized agents are invoked using tailored sub-prompts,  and a designated function synthesizes their responses into a single cohesive result.  A dedicated kernel function may optionally be used to split the initial user prompt into sub-prompts aligned with each agent's expertise.
 */
export class ConvergenceAgenticProcessDefinition
 {
  /**
   * Gets/sets the collection of named agents that participate in this process
   */
  agents: Record<string, AgentDefinition>;
  /**
   * Gets/sets the definition of the convergence process's strategy, if any
   */
  strategy: ConvergenceStrategyDefinition;
}