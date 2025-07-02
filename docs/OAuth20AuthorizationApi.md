# DocSpace.Sdk.Api.OAuth20AuthorizationApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorizeOAuth**](#authorizeoauth) | **GET** /oauth2/authorize | OAuth2 authorization endpoint |
| [**ExchangeToken**](#exchangetoken) | **POST** /oauth2/token | OAuth2 token endpoint |
| [**SubmitConsent**](#submitconsent) | **POST** /oauth2/authorize | OAuth2 consent endpoint |

<a id="authorizeoauth"></a>
# **AuthorizeOAuth**
> void AuthorizeOAuth (string responseType, string clientId, string redirectUri, string scope)

Initiates the OAuth2 authorization flow.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/authorize-o-auth/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **responseType** | **string** | The OAuth 2.0 response type, must be &#39;code&#39; for authorization code flow. |  |
| **clientId** | **string** | The client identifier issued to the client during registration. |  |
| **redirectUri** | **string** | The URL to redirect to after authorization is complete. |  |
| **scope** | **string** | The space-separated list of requested scope permissions. |  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class AuthorizeOAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OAuth20AuthorizationApi(httpClient, config, httpClientHandler);
            var responseType = code;  // string | The OAuth 2.0 response type, must be 'code' for authorization code flow.
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | The client identifier issued to the client during registration.
            var redirectUri = https://example.com;  // string | The URL to redirect to after authorization is complete.
            var scope = files:read;  // string | The space-separated list of requested scope permissions.

            try
            {
                // OAuth2 authorization endpoint
                apiInstance.AuthorizeOAuth(responseType, clientId, redirectUri, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20AuthorizationApi.AuthorizeOAuth: " + e.Message);
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
    // OAuth2 authorization endpoint
    apiInstance.AuthorizeOAuthWithHttpInfo(responseType, clientId, redirectUri, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20AuthorizationApi.AuthorizeOAuthWithHttpInfo: " + e.Message);
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
| **200** | Authorization page |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="exchangetoken"></a>
# **ExchangeToken**
> ExchangeToken200Response ExchangeToken (string? grantType = null, string? code = null, string? redirectUri = null, string? clientId = null, string? clientSecret = null)

Exchanges an authorization code specified in the request for the access token.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/exchange-token/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string?** | The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. | [optional]  |
| **code** | **string?** | A temporary authorization code that is sent to the client to be exchanged for a token. | [optional]  |
| **redirectUri** | **string?** | The URL where the user will be redirected after successful or unsuccessful authentication. | [optional]  |
| **clientId** | **string?** | The client identifier issued to the client during registration. | [optional]  |
| **clientSecret** | **string?** | The client secret issued to the client during registration. | [optional]  |

### Return type

[**ExchangeToken200Response**](ExchangeToken200Response.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class ExchangeTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OAuth20AuthorizationApi(httpClient, config, httpClientHandler);
            var grantType = "grantType_example";  // string? | The OAuth2 grant type, must be 'authorization_code' for the authorization code flow. (optional) 
            var code = "code_example";  // string? | A temporary authorization code that is sent to the client to be exchanged for a token. (optional) 
            var redirectUri = "redirectUri_example";  // string? | The URL where the user will be redirected after successful or unsuccessful authentication. (optional) 
            var clientId = "clientId_example";  // string? | The client identifier issued to the client during registration. (optional) 
            var clientSecret = "clientSecret_example";  // string? | The client secret issued to the client during registration. (optional) 

            try
            {
                // OAuth2 token endpoint
                ExchangeToken200Response result = apiInstance.ExchangeToken(grantType, code, redirectUri, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20AuthorizationApi.ExchangeToken: " + e.Message);
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
    // OAuth2 token endpoint
    ApiResponse<ExchangeToken200Response> response = apiInstance.ExchangeTokenWithHttpInfo(grantType, code, redirectUri, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20AuthorizationApi.ExchangeTokenWithHttpInfo: " + e.Message);
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
| **200** | The authorization code was successfully exchanged for the access token |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="submitconsent"></a>
# **SubmitConsent**
> void SubmitConsent (string? clientId = null, string? state = null, string? scope = null)

Sends a consent request with the specified parameters.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/submit-consent/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string?** | The client identifier issued to the client during registration. | [optional]  |
| **state** | **string?** | The random string used to solve the CSRF vulnerability problem. | [optional]  |
| **scope** | **string?** | The space-separated list of requested scope permissions. | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class SubmitConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OAuth20AuthorizationApi(httpClient, config, httpClientHandler);
            var clientId = "clientId_example";  // string? | The client identifier issued to the client during registration. (optional) 
            var state = "state_example";  // string? | The random string used to solve the CSRF vulnerability problem. (optional) 
            var scope = "scope_example";  // string? | The space-separated list of requested scope permissions. (optional) 

            try
            {
                // OAuth2 consent endpoint
                apiInstance.SubmitConsent(clientId, state, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20AuthorizationApi.SubmitConsent: " + e.Message);
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
    // OAuth2 consent endpoint
    apiInstance.SubmitConsentWithHttpInfo(clientId, state, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20AuthorizationApi.SubmitConsentWithHttpInfo: " + e.Message);
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
| **302** | Redirect to the client&#39;s redirect URI with authorization code |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

