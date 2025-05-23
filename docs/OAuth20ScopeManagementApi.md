# Docspace.Api.OAuth20ScopeManagementApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetScopes**](OAuth20ScopeManagementApi.md#getscopes) | **GET** /api/2.0/scopes | Get available OAuth2 scopes |

<a id="getscopes"></a>
# **GetScopes**
> ScopeResponse GetScopes ()

Get available OAuth2 scopes

Retrieves a list of all available OAuth2 scopes for the specified tenant. The scopes define the permissions that can be requested by OAuth2 clients. The list is ordered alphabetically, with the 'openid' scope always appearing first.

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
    public class GetScopesExample
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
            var apiInstance = new OAuth20ScopeManagementApi(httpClient, config, httpClientHandler);

            try
            {
                // Get available OAuth2 scopes
                ScopeResponse result = apiInstance.GetScopes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuth20ScopeManagementApi.GetScopes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScopesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get available OAuth2 scopes
    ApiResponse<ScopeResponse> response = apiInstance.GetScopesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuth20ScopeManagementApi.GetScopesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ScopeResponse**](ScopeResponse.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Scopes successfully retrieved |  -  |
| **400** | Invalid request parameters |  -  |
| **403** | Insufficient permissions to get a list of scopes |  -  |
| **429** | Too many requests - rate limit exceeded |  -  |
| **500** | Internal server error occurred |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

