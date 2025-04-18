import { PromptTemplateDefinition } from './prompt-template-definition';

/**
 * Represents the definition of a kernel function
 */
export class KernelFunctionDefinition
 {
  /**
   * Gets/sets the function's prompt template
   */
  template: PromptTemplateDefinition;
  /**
   * Gets/sets a list containing the names of the parameters, if any, to exclude from being encoded
   */
  parameters: string[] | null;
}