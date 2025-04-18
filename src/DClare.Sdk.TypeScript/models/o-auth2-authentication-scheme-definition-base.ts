import { AuthenticationSchemeDefinition } from './authentication-scheme-definition';import { OAuth2AuthenticationClientDefinition } from './o-auth2-authentication-client-definition';
import { OAuth2AuthenticationRequestDefinition } from './o-auth2-authentication-request-definition';
import { OAuth2TokenDefinition } from './o-auth2-token-definition';
import { OAuth2TokenDefinition } from './o-auth2-token-definition';

/**
 * Represents the base class for all authentication schemes based on OAUTH2
 */
export class OAuth2AuthenticationSchemeDefinitionBase extends AuthenticationSchemeDefinition
 {
  /**
   * Gets/sets the uri that references the OAUTH2 authority to use
   */
  authority: Uri;
  /**
   * Gets/sets the grant type to use. See <see cref="T:DClare.Sdk.OAuth2GrantType" />
   */
  grant: string | null;
  /**
   * Gets/sets the definition of the client to use
   */
  client: OAuth2AuthenticationClientDefinition | null;
  /**
   * Gets/sets the configuration of the authentication request to perform
   */
  request: OAuth2AuthenticationRequestDefinition | null;
  /**
   * Gets/sets a list, if any, that contains valid issuers that will be used to check against the issuer of generated tokens
   */
  issuers: string[] | null;
  /**
   * Gets/sets the scopes, if any, to request the token for
   */
  scopes: string[] | null;
  /**
   * Gets/sets the audiences, if any, to request the token for
   */
  audiences: string[] | null;
  /**
   * Gets/sets the username to use. Used only if <see cref="P:DClare.Sdk.Models.Authentication.OAuth2AuthenticationSchemeDefinitionBase.Grant" /> is <see cref="F:DClare.Sdk.OAuth2GrantType.Password" />
   */
  username: string | null;
  /**
   * Gets/sets the password to use. Used only if <see cref="P:DClare.Sdk.Models.Authentication.OAuth2AuthenticationSchemeDefinitionBase.Grant" /> is <see cref="F:DClare.Sdk.OAuth2GrantType.Password" />
   */
  password: string | null;
  /**
   * Gets/sets the security token that represents the identity of the party on behalf of whom the request is being made. Used only if <see cref="P:DClare.Sdk.Models.Authentication.OAuth2AuthenticationSchemeDefinitionBase.Grant" /> is <see cref="F:DClare.Sdk.OAuth2GrantType.TokenExchange" />, in which case it is required
   */
  subject: OAuth2TokenDefinition | null;
  /**
   * Gets/sets the security token that represents the identity of the acting party. Typically, this will be the party that is authorized to use the requested security token and act on behalf of the subject.  Used only if <see cref="P:DClare.Sdk.Models.Authentication.OAuth2AuthenticationSchemeDefinitionBase.Grant" /> is <see cref="F:DClare.Sdk.OAuth2GrantType.TokenExchange" />, in which case it is required
   */
  actor: OAuth2TokenDefinition | null;
}