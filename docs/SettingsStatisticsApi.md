# Docspace.Api.SettingsStatisticsApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSpaceUsageStatistics**](SettingsStatisticsApi.md#getspaceusagestatistics) | **GET** /api/2.0/settings/statistics/spaceusage/{id} | Get the space usage statistics |

<a id="getspaceusagestatistics"></a>
# **GetSpaceUsageStatistics**
> UsageSpaceStatItemArrayWrapper GetSpaceUsageStatistics (Guid id)

Get the space usage statistics

Returns the space usage statistics for the module with the ID specified in the request.

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
    public class GetSpaceUsageStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsStatisticsApi(httpClient, config, httpClientHandler);
            var id = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid | The ID extracted from the route parameters.

            try
            {
                // Get the space usage statistics
                UsageSpaceStatItemArrayWrapper result = apiInstance.GetSpaceUsageStatistics(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsStatisticsApi.GetSpaceUsageStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSpaceUsageStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the space usage statistics
    ApiResponse<UsageSpaceStatItemArrayWrapper> response = apiInstance.GetSpaceUsageStatisticsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsStatisticsApi.GetSpaceUsageStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID extracted from the route parameters. |  |

### Return type

[**UsageSpaceStatItemArrayWrapper**](UsageSpaceStatItemArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Module space usage statistics |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

