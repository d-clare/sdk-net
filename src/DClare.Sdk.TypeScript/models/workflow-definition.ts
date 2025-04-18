import { WorkflowDefinitionMetadata } from './workflow-definition-metadata';
import { ComponentCollectionDefinition } from './component-collection-definition';

/**
 * Represents the definition of a workflow
 */
export class WorkflowDefinition
 {
  /**
   * Gets/sets the metadata used to describe the workflow
   */
  metadata: WorkflowDefinitionMetadata;
  /**
   * Gets/sets the workflow's reusable component collection, if any
   */
  components: ComponentCollectionDefinition | null;
}