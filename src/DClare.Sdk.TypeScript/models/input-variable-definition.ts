import { any } from './any';
import { any } from './any';
import { JsonSchema } from './json-schema';

/**
 * Represents the definition of an input variable
 */
export class InputVariableDefinition
 {
  /**
   * Gets/sets the variable's name
   */
  name: string;
  /**
   * Gets/sets the variable's description, if any
   */
  description: string | null;
  /**
   * Gets/sets the variable's default value, if any
   */
  default: any;
  /**
   * Gets/sets the a sample value for the variable, if any
   */
  sample: any;
  /**
   * Gets/sets a boolean indicating whether or not the variable is required
   */
  required: boolean;
  /**
   * Gets/sets a boolean indicating whether or not to handle the variable value as potential dangerous content
   */
  allowDangerousContent: boolean;
  /**
   * Gets/sets the JSON schema, if any, used to describe the variable
   */
  schema: JsonSchema | null;
}