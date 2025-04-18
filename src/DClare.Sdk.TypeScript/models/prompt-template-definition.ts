import { InputVariableDefinition } from './input-variable-definition';
import { InputVariableDefinition } from './input-variable-definition';
import { OutputVariableDefinition } from './output-variable-definition';

/**
 * Represents the definition of a prompt template
 */
export class PromptTemplateDefinition
 {
  /**
   * Gets/sets the template content to use for prompt generation, including placeholders for input variables
   */
  content: string;
  /**
   * Gets/sets the optional format of the prompt template
   */
  format: string | null;
  /**
   * Gets/sets a list of input variables, if any, used within the template
   */
  inputVariables: InputVariableDefinition[] | null;
  /**
   * Gets/sets the definition of the expected output variable, if any, for the result produced by the prompt
   */
  outputVariable: OutputVariableDefinition | null;
}