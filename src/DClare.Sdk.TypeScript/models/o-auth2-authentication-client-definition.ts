
/**
 * Represents the definition of an OAUTH2 client
 */
export class OAuth2AuthenticationClientDefinition
 {
  /**
   * Gets/sets the OAUTH2 `client_id` to use. Required if 'Authentication' has NOT been set to 'none'.
   */
  id: string | null;
  /**
   * Gets/sets the OAUTH2 `client_secret` to use, if any
   */
  secret: string | null;
  /**
   * Gets/sets a JWT containing a signed assertion with the application credentials
   */
  assertion: string | null;
  /**
   * Gets/sets the authentication method to use to authenticate the client. Defaults to 'client_secret_post'. See <see cref="T:DClare.Sdk.OAuth2ClientAuthenticationMethod" />
   */
  authentication: string | null;
}