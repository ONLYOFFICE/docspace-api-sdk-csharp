# DocSpace.API.SDK.Api.AuthorizationApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorizeOAuth**](#authorizeoauth) | **GET** /oauth2/authorize | Start the authorization flow |
| [**ExchangeToken**](#exchangetoken) | **POST** /oauth2/token | Exchange the authorization code |
| [**SubmitConsent**](#submitconsent) | **POST** /oauth2/authorize | Submit the consent decision |

<a id="authorizeoauth"></a>
# **AuthorizeOAuth**
> void AuthorizeOAuth (string responseType, string clientId, string redirectUri, string scope)

Starts the OAuth2 authorization code flow for the client named by client_id. The caller has to present the portal signature cookie, and a request without a valid one is not refused with 401 or 403 but redirected to the portal login page, carrying the client ID so the flow can resume after signing in. When the user has not yet consented to the requested scopes the browser is redirected to the consent page; once the consent exists the browser is redirected to the client's redirect URI with the authorization code and, when one was sent, the original state. A caller that cannot follow redirects may send the X-Disable-Redirect header, and then the response is 200 with an empty body and the target URL in the X-Redirect-URI header. The code returned here is exchanged for tokens at the token endpoint.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **responseType** | **string** | The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint. |  |
| **clientId** | **string** | The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against. |  |
| **redirectUri** | **string** | Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused. |  |
| **scope** | **string** | The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these. |  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class AuthorizeOAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthorizationApi(httpClient, config, httpClientHandler);
            var responseType = code;  // string | The OAuth 2.0 response type. Only code is supported: this server issues an authorization code, never a token, from this endpoint.
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | The identifier the client was given when it was registered. It selects both the client shown on the consent screen and the set of redirect URIs the request is checked against.
            var redirectUri = https://example.com;  // string | Where to send the user once authorization is complete. It has to be one of the redirect URIs registered for the client, otherwise the request is refused.
            var scope = files:read;  // string | The permissions being asked for, as a space-separated list. Every scope has to be one the client is registered for, and the consent screen lists exactly these.

            try
            {
                // Start the authorization flow
                apiInstance.AuthorizeOAuth(responseType, clientId, redirectUri, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.AuthorizeOAuth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeOAuthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start the authorization flow
    apiInstance.AuthorizeOAuthWithHttpInfo(responseType, clientId, redirectUri, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationApi.AuthorizeOAuthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirect to the login page, to the consent page, or back to the client's redirect URI with an authorization code |  -  |
| **200** | Returned instead of the redirect when the request carries the X-Disable-Redirect header: the target URL is sent in the X-Redirect-URI response header and the body is empty |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exchangetoken"></a>
# **ExchangeToken**
> ExchangeToken200Response ExchangeToken (string? grantType = null, string? code = null, string? redirectUri = null, string? clientId = null, string? clientSecret = null)

Exchanges an authorization code for an access token. The request is form-encoded and has to carry the grant type, the code, the same redirect URI that was used to obtain the code, and the client credentials: the client authenticates itself here rather than through the portal signature cookie the authorization endpoint uses. The response carries the access token, its type and its lifetime in seconds, plus a refresh token when the client is configured for the refresh token grant. Client authentication that fails is answered with 401, while a malformed, unknown or expired code is answered with 400. The code is single use, so replaying it fails.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string?** | Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. | [optional]  |
| **code** | **string?** | The authorization code returned by the authorization endpoint. It may be redeemed once. | [optional]  |
| **redirectUri** | **string?** | The same redirect URI that was used to obtain the code. The exchange fails when it differs. | [optional]  |
| **clientId** | **string?** | The identifier of the client redeeming the code. | [optional]  |
| **clientSecret** | **string?** | The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. | [optional]  |

### Return type

[**ExchangeToken200Response**](ExchangeToken200Response.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [bearerAuth](../README.md#bearerAuth)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class ExchangeTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: cookieAuth
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthorizationApi(httpClient, config, httpClientHandler);
            var grantType = "grantType_example";  // string? | Which exchange is being performed: authorization_code to redeem a code, refresh_token to renew an access token. (optional) 
            var code = "code_example";  // string? | The authorization code returned by the authorization endpoint. It may be redeemed once. (optional) 
            var redirectUri = "redirectUri_example";  // string? | The same redirect URI that was used to obtain the code. The exchange fails when it differs. (optional) 
            var clientId = "clientId_example";  // string? | The identifier of the client redeeming the code. (optional) 
            var clientSecret = "clientSecret_example";  // string? | The secret of the client redeeming the code. It is omitted by a public client, which proves itself with a PKCE code verifier instead. (optional) 

            try
            {
                // Exchange the authorization code
                ExchangeToken200Response result = apiInstance.ExchangeToken(grantType, code, redirectUri, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.ExchangeToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExchangeTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Exchange the authorization code
    ApiResponse<ExchangeToken200Response> response = apiInstance.ExchangeTokenWithHttpInfo(grantType, code, redirectUri, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationApi.ExchangeTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully exchanged authorization code for access token |  -  |
| **400** | Invalid request parameters |  -  |
| **401** | Client authentication failed: the client ID is unknown or the client secret does not match |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="submitconsent"></a>
# **SubmitConsent**
> void SubmitConsent (string? clientId = null, string? state = null, string? scope = null)

Submits the user's consent decision for the scopes an authorization request asked for. It is the form post the consent page makes, so it carries the client ID, the state and the agreed scopes as multipart form data, along with the same portal signature cookie the authorization request needed. On success the browser is redirected to the client's redirect URI with an authorization code, or, when the request carries the X-Disable-Redirect header, answered 200 with that URL in the X-Redirect-URI header. The consent is stored per user and client, so a later authorization request for the same scopes no longer stops at the consent page.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string?** | The client the consent is being given to. It has to be the same client the authorization request named. | [optional]  |
| **state** | **string?** | The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. | [optional]  |
| **scope** | **string?** | The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.API.SDK.Api;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;

namespace Example
{
    public class SubmitConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthorizationApi(httpClient, config, httpClientHandler);
            var clientId = "clientId_example";  // string? | The client the consent is being given to. It has to be the same client the authorization request named. (optional) 
            var state = "state_example";  // string? | The opaque value carried through from the authorization request, returned unchanged on the redirect so the client can match the answer to its request. (optional) 
            var scope = "scope_example";  // string? | The scopes the user agreed to, as a space-separated list. Anything the user declined is left out, so this may be narrower than what was requested. (optional) 

            try
            {
                // Submit the consent decision
                apiInstance.SubmitConsent(clientId, state, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.SubmitConsent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitConsentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit the consent decision
    apiInstance.SubmitConsentWithHttpInfo(clientId, state, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationApi.SubmitConsentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirect to the client's redirect URI with authorization code |  -  |
| **200** | Returned instead of the redirect when the request carries the X-Disable-Redirect header: the target URL is sent in the X-Redirect-URI response header and the body is empty |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

