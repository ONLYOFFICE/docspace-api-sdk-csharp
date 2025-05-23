# Docspace.Api.OAuth20AuthorizationApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Oauth2AuthorizeGet**](OAuth20AuthorizationApi.md#oauth2authorizeget) | **GET** /oauth2/authorize | OAuth2 authorization endpoint |
| [**Oauth2AuthorizePost**](OAuth20AuthorizationApi.md#oauth2authorizepost) | **POST** /oauth2/authorize | OAuth2 consent endpoint |
| [**Oauth2TokenPost**](OAuth20AuthorizationApi.md#oauth2tokenpost) | **POST** /oauth2/token | OAuth2 token endpoint |

<a id="oauth2authorizeget"></a>
# **Oauth2AuthorizeGet**
> void Oauth2AuthorizeGet (string responseType, string clientId, string redirectUri, string scope)

OAuth2 authorization endpoint

Initiates the OAuth2 authorization flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class Oauth2AuthorizeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
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
                apiInstance.Oauth2AuthorizeGet(responseType, clientId, redirectUri, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20AuthorizationApi.Oauth2AuthorizeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Oauth2AuthorizeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // OAuth2 authorization endpoint
    apiInstance.Oauth2AuthorizeGetWithHttpInfo(responseType, clientId, redirectUri, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20AuthorizationApi.Oauth2AuthorizeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Authorization page |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="oauth2authorizepost"></a>
# **Oauth2AuthorizePost**
> void Oauth2AuthorizePost (string? clientId = null, string? state = null, string? scope = null)

OAuth2 consent endpoint

Sends a consent request with the specified parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class Oauth2AuthorizePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
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
                apiInstance.Oauth2AuthorizePost(clientId, state, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20AuthorizationApi.Oauth2AuthorizePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Oauth2AuthorizePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // OAuth2 consent endpoint
    apiInstance.Oauth2AuthorizePostWithHttpInfo(clientId, state, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20AuthorizationApi.Oauth2AuthorizePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirect to the client&#39;s redirect URI with authorization code |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="oauth2tokenpost"></a>
# **Oauth2TokenPost**
> Oauth2TokenPost200Response Oauth2TokenPost (string? grantType = null, string? code = null, string? redirectUri = null, string? clientId = null, string? clientSecret = null)

OAuth2 token endpoint

Exchanges an authorization code specified in the request for the access token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class Oauth2TokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
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
                Oauth2TokenPost200Response result = apiInstance.Oauth2TokenPost(grantType, code, redirectUri, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20AuthorizationApi.Oauth2TokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the Oauth2TokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // OAuth2 token endpoint
    ApiResponse<Oauth2TokenPost200Response> response = apiInstance.Oauth2TokenPostWithHttpInfo(grantType, code, redirectUri, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20AuthorizationApi.Oauth2TokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string?** | The OAuth2 grant type, must be &#39;authorization_code&#39; for the authorization code flow. | [optional]  |
| **code** | **string?** | A temporary authorization code that is sent to the client to be exchanged for a token. | [optional]  |
| **redirectUri** | **string?** | The URL where the user will be redirected after successful or unsuccessful authentication. | [optional]  |
| **clientId** | **string?** | The client identifier issued to the client during registration. | [optional]  |
| **clientSecret** | **string?** | The client secret issued to the client during registration. | [optional]  |

### Return type

[**Oauth2TokenPost200Response**](Oauth2TokenPost200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The authorization code was successfully exchanged for the access token |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

