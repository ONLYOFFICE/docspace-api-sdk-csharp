# Docspace.Api.AuthorizationApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Oauth2AuthorizeGet**](AuthorizationApi.md#oauth2authorizeget) | **GET** /oauth2/authorize | OAuth2 Authorization Endpoint |
| [**Oauth2AuthorizePost**](AuthorizationApi.md#oauth2authorizepost) | **POST** /oauth2/authorize | OAuth2 Consent Endpoint |
| [**Oauth2TokenPost**](AuthorizationApi.md#oauth2tokenpost) | **POST** /oauth2/token | OAuth2 Token Endpoint |

<a id="oauth2authorizeget"></a>
# **Oauth2AuthorizeGet**
> void Oauth2AuthorizeGet (string responseType, string clientId, string redirectUri, string scope)

OAuth2 Authorization Endpoint

Initiates the OAuth2 authorization flow

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
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthorizationApi(httpClient, config, httpClientHandler);
            var responseType = code;  // string | 
            var clientId = 6c7cf17b-1bd3-47d5-94c6-be2d3570e168;  // string | 
            var redirectUri = https://example.com;  // string | 
            var scope = files:read;  // string | 

            try
            {
                // OAuth2 Authorization Endpoint
                apiInstance.Oauth2AuthorizeGet(responseType, clientId, redirectUri, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.Oauth2AuthorizeGet: " + e.Message);
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
    // OAuth2 Authorization Endpoint
    apiInstance.Oauth2AuthorizeGetWithHttpInfo(responseType, clientId, redirectUri, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationApi.Oauth2AuthorizeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **responseType** | **string** |  |  |
| **clientId** | **string** |  |  |
| **redirectUri** | **string** |  |  |
| **scope** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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

OAuth2 Consent Endpoint

Sends consent approval

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
            // Configure API key authorization: x-signature
            config.AddApiKey("x-signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-signature", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthorizationApi(httpClient, config, httpClientHandler);
            var clientId = "clientId_example";  // string? |  (optional) 
            var state = "state_example";  // string? |  (optional) 
            var scope = "scope_example";  // string? |  (optional) 

            try
            {
                // OAuth2 Consent Endpoint
                apiInstance.Oauth2AuthorizePost(clientId, state, scope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.Oauth2AuthorizePost: " + e.Message);
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
    // OAuth2 Consent Endpoint
    apiInstance.Oauth2AuthorizePostWithHttpInfo(clientId, state, scope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationApi.Oauth2AuthorizePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string?** |  | [optional]  |
| **state** | **string?** |  | [optional]  |
| **scope** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-signature](../README.md#x-signature)

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

OAuth2 Token Endpoint

Exchange authorization code for access token

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
            var apiInstance = new AuthorizationApi(httpClient, config, httpClientHandler);
            var grantType = "grantType_example";  // string? |  (optional) 
            var code = "code_example";  // string? |  (optional) 
            var redirectUri = "redirectUri_example";  // string? |  (optional) 
            var clientId = "clientId_example";  // string? |  (optional) 
            var clientSecret = "clientSecret_example";  // string? |  (optional) 

            try
            {
                // OAuth2 Token Endpoint
                Oauth2TokenPost200Response result = apiInstance.Oauth2TokenPost(grantType, code, redirectUri, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationApi.Oauth2TokenPost: " + e.Message);
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
    // OAuth2 Token Endpoint
    ApiResponse<Oauth2TokenPost200Response> response = apiInstance.Oauth2TokenPostWithHttpInfo(grantType, code, redirectUri, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationApi.Oauth2TokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **grantType** | **string?** |  | [optional]  |
| **code** | **string?** |  | [optional]  |
| **redirectUri** | **string?** |  | [optional]  |
| **clientId** | **string?** |  | [optional]  |
| **clientSecret** | **string?** |  | [optional]  |

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
| **200** | Successfully exchanged authorization code for access token |  -  |
| **400** | Invalid request parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

