
/**
 * Represents an object used to describe an DClare workflow definition
 */
export class WorkflowDefinitionMetadata
 {
  /**
   * Gets/sets the version of the DSL used to write the workflow
   */
  dsl: string;
  /**
   * Gets/sets the namespace the workflow belongs to
   */
  namespace: string;
  /**
   * Gets/sets the workflow's name
   */
  name: string;
  /**
   * Gets/sets the workflow's semantic version
   */
  version: string;
}