import { AuthenticationPolicyDefinition } from './authentication-policy-definition';

/**
 * Represents the definition of an endpoint
 */
export class EndpointDefinition
 {
  /**
   * Gets/sets the endpoint's uri
   */
  uri: Uri;
  /**
   * Gets/sets the endpoint's authentication policy, if any
   */
  authentication: AuthenticationPolicyDefinition | null;
}