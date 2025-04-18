import { AuthenticationSchemeDefinition } from './authentication-scheme-definition';
/**
 * Represents the definition of a bearer authentication scheme
 */
export class BearerAuthenticationSchemeDefinition extends AuthenticationSchemeDefinition
 {
  /**
   */
  scheme: string;
  /**
   * Gets/sets the bearer token used for authentication
   */
  token: string;
}