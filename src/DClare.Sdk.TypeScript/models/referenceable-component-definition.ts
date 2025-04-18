import { ComponentDefinition } from './component-definition';
/**
 * Represents a component definition that can be referenced
 */
export class ReferenceableComponentDefinition extends ComponentDefinition
 {
  /**
   */
  use: string | null;
}