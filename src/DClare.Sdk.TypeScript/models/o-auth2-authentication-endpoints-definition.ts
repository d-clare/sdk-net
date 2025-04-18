
/**
 * Represents the configuration of OAUTH2 endpoints
 */
export class OAuth2AuthenticationEndpointsDefinition
 {
  /**
   * Gets/sets the relative path to the token endpoint. Defaults to `/oauth2/token`
   */
  token: Uri;
  /**
   * Gets/sets the relative path to the revocation endpoint. Defaults to `/oauth2/revoke`
   */
  revocation: Uri;
  /**
   * Gets/sets the relative path to the introspection endpoint. Defaults to `/oauth2/introspect`
   */
  introspection: Uri;
}