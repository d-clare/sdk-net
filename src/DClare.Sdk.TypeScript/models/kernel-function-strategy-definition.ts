import { KernelFunctionDefinition } from './kernel-function-definition';
import { KernelDefinition } from './kernel-definition';

/**
 * Represents the definition of a kernel function–based strategy
 */
export class KernelFunctionStrategyDefinition
 {
  /**
   */
  function: KernelFunctionDefinition;
  /**
   */
  kernel: KernelDefinition;
}