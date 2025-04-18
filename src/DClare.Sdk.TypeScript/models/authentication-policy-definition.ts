import { ReferenceableComponentDefinition } from './referenceable-component-definition';import { ApiKeyAuthenticationSchemeDefinition } from './api-key-authentication-scheme-definition';
import { BearerAuthenticationSchemeDefinition } from './bearer-authentication-scheme-definition';
import { OAuth2AuthenticationSchemeDefinition } from './o-auth2-authentication-scheme-definition';
import { OpenIDConnectSchemeDefinition } from './open-id-connect-scheme-definition';

/**
 * Represents the definition of an authentication policy
 */
export class AuthenticationPolicyDefinition extends ReferenceableComponentDefinition
 {
  /**
   * Gets the configured authentication scheme
   */
  scheme: string;
  /**
   * Gets/sets the `ApiKey` authentication scheme to use, if any
   */
  apiKey: ApiKeyAuthenticationSchemeDefinition | null;
  /**
   * Gets/sets the `Bearer` authentication scheme to use, if any
   */
  bearer: BearerAuthenticationSchemeDefinition | null;
  /**
   * Gets/sets the `OAUTH2` authentication scheme to use, if any
   */
  oAuth2: OAuth2AuthenticationSchemeDefinition | null;
  /**
   * Gets/sets the `OIDC` authentication scheme to use, if any
   */
  oidc: OpenIDConnectSchemeDefinition | null;
}