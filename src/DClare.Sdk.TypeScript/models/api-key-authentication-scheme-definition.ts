import { AuthenticationSchemeDefinition } from './authentication-scheme-definition';
/**
 * Represents the definition of an API key authentication scheme
 */
export class ApiKeyAuthenticationSchemeDefinition extends AuthenticationSchemeDefinition
 {
  /**
   */
  scheme: string;
  /**
   * Gets/sets the key used for authentication
   */
  key: string;
}