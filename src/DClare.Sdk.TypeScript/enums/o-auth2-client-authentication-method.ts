export enum OAuth2ClientAuthenticationMethod{
  Basic = `client_secret_basic`,
  Post = `client_secret_post`,
  JwT = `client_secret_jwt`,
  PrivateKey = `private_key_jwt`,
  None = `none`,
}