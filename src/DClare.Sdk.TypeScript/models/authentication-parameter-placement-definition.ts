
/**
 * Represents the definition of the placement of a resolved authentication parameter
 */
export class AuthenticationParameterPlacementDefinition
 {
  /**
   * Gets or sets where to place the authentication parameter
   */
  in: string;
  /**
   * Gets or sets the name of the parameter, header, or cookie in which the authentication parameter will be inserted
   */
  name: string;
  /**
   * Gets or sets an optional prefix to prepend to the authentication parameter
   */
  prefix: string | null;
}