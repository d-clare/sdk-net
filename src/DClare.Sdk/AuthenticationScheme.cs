namespace DClare.Sdk;

/// <summary>
/// Enumerates all default authentication schemes
/// </summary>
public static class AuthenticationScheme
{

    /// <summary>
    /// Gets the 'ApiKey' authentication scheme
    /// </summary>
    public const string ApiKey = "ApiKey";
    /// <summary>
    /// Gets the 'Bearer' authentication scheme
    /// </summary>
    public const string Bearer = "Bearer";
    /// <summary>
    /// Gets the 'OAUTH2' authentication scheme
    /// </summary>
    public const string OAuth2 = "OAuth2";
    /// <summary>
    /// Gets the 'OpenIDConnect' authentication scheme
    /// </summary>
    public const string OpenIDConnect = "OpenIDConnect";

    /// <summary>
    /// Gets a new <see cref="IEnumerable{T}"/> containing the authentication schemes supported by default
    /// </summary>
    /// <returns>A new <see cref="IEnumerable{T}"/> containing the authentication schemes supported by default</returns>
    public static IEnumerable<string> AsEnumerable()
    {
        yield return ApiKey;
        yield return Bearer;
        yield return OAuth2;
        yield return OpenIDConnect;
    }

}
