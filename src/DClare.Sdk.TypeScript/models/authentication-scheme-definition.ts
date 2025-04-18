import { Extendable } from './extendable';import { AuthenticationParameterPlacementDefinition } from './authentication-parameter-placement-definition';

/**
 * Represents the base class for all authentication scheme definitions
 */
export class AuthenticationSchemeDefinition extends Extendable
 {
  /**
   * Gets the name of the authentication scheme
   */
  scheme: string;
  /**
   * Gets/sets the name of the secret, if any, used to configure the authentication scheme
   */
  use: string | null;
  /**
   * Gets/sets the definition of the placement, if any, of the resolved authentication parameter
   */
  placement: AuthenticationParameterPlacementDefinition | null;
}