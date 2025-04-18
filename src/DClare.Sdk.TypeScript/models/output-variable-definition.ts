import { JsonSchema } from './json-schema';

/**
 * Represents the definition of an output variable
 */
export class OutputVariableDefinition
 {
  /**
   * Gets/sets the variable's description, if any
   */
  description: string | null;
  /**
   * Gets/sets the JSON schema, if any, used to describe the variable
   */
  schema: JsonSchema | null;
}