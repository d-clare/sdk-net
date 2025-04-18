import { AuthenticationPolicyDefinition } from './authentication-policy-definition';
import { ToolsetDefinition } from './toolset-definition';
import { KernelFunctionDefinition } from './kernel-function-definition';
import { KernelDefinition } from './kernel-definition';
import { MemoryDefinition } from './memory-definition';
import { AgentDefinition } from './agent-definition';
import { AgenticProcessDefinition } from './agentic-process-definition';

/**
 * Represents the definition of a collection of reusable components
 */
export class ComponentCollectionDefinition
 {
  /**
   * Gets/sets a name/definition mapping, if any, of reusable authentication policies
   */
  authentications: Record<string, AuthenticationPolicyDefinition> | null;
  /**
   * Gets/sets a name/definition mapping, if any, of reusable toolsets
   */
  toolsets: Record<string, ToolsetDefinition> | null;
  /**
   * Gets/sets a name/definition mapping, if any, of reusable functions
   */
  functions: Record<string, KernelFunctionDefinition> | null;
  /**
   * Gets/sets a name/definition mapping, if any, of reusable kernels
   */
  kernels: Record<string, KernelDefinition> | null;
  /**
   * Gets/sets a name/definition mapping, if any, of reusable memories
   */
  memories: Record<string, MemoryDefinition> | null;
  /**
   * Gets/sets a name/definition mapping, if any, of reusable agents
   */
  agents: Record<string, AgentDefinition> | null;
  /**
   * Gets/sets a name/definition mapping, if any, of reusable agentic processes
   */
  processes: Record<string, AgenticProcessDefinition> | null;
}