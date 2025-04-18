import { ReferenceableComponentDefinition } from './referenceable-component-definition';import { ReasoningCapabilityDefinition } from './reasoning-capability-definition';
import { EmbeddingCapabilityDefinition } from './embedding-capability-definition';
import { ToolsetDefinition } from './toolset-definition';

/**
 * Represents the configuration of a kernel system capable of performing AI inference operations, such as language model completions, chat interactions, or vector embeddings
 */
export class KernelDefinition extends ReferenceableComponentDefinition
 {
  /**
   * Gets/sets a reference to the kernel definition to extend, if any
   */
  extends: string | null;
  /**
   * Gets/sets the configuration of the kernel's reasoning capability, if any
   */
  reasoning: ReasoningCapabilityDefinition | null;
  /**
   * Gets/sets the configuration of the kernel's embedding capability, if any
   */
  embedding: EmbeddingCapabilityDefinition | null;
  /**
   * Gets/sets a key/definition mapping of the toolsets available to the kernel
   */
  toolsets: Record<string, ToolsetDefinition> | null;
}