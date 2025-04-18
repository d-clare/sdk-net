import { OAuth2AuthenticationSchemeDefinitionBase } from './o-auth2-authentication-scheme-definition-base';import { OAuth2AuthenticationEndpointsDefinition } from './o-auth2-authentication-endpoints-definition';

/**
 * Represents the definition of an OAUTH2 authentication scheme
 */
export class OAuth2AuthenticationSchemeDefinition extends OAuth2AuthenticationSchemeDefinitionBase
 {
  /**
   */
  scheme: string;
  /**
   * Gets/sets the configuration of the OAUTH2 endpoints to use
   */
  endpoints: OAuth2AuthenticationEndpointsDefinition;
}