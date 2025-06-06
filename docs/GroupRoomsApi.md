# Docspace.Api.GroupRoomsApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGroupsWithShared**](GroupRoomsApi.md#getgroupswithshared) | **GET** /api/2.0/group/room/{id} | Get groups with sharing settings |

<a id="getgroupswithshared"></a>
# **GetGroupsWithShared**
> GroupArrayWrapper GetGroupsWithShared (int id, bool? excludeShared = null, int? count = null, int? startIndex = null, string? filterValue = null)

Get groups with sharing settings

Returns groups with their sharing settings.

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
    public class GetGroupsWithSharedExample
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
            // Configure API key authorization: ApiKeyBearer
            config.AddApiKey("ApiKeyBearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("ApiKeyBearer", "Bearer");
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The group ID.
            var excludeShared = true;  // bool? | Specifies whether to exclude the group sharing settings from the response. (optional) 
            var count = 1234;  // int? | The number of groups to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The starting index from which to begin retrieving groups with their sharing settings. (optional) 
            var filterValue = some text;  // string? | The text used as a filter for retrieving groups with their sharing settings. (optional) 

            try
            {
                // Get groups with sharing settings
                GroupArrayWrapper result = apiInstance.GetGroupsWithShared(id, excludeShared, count, startIndex, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupRoomsApi.GetGroupsWithShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get groups with sharing settings
    ApiResponse<GroupArrayWrapper> response = apiInstance.GetGroupsWithSharedWithHttpInfo(id, excludeShared, count, startIndex, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupRoomsApi.GetGroupsWithSharedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The group ID. |  |
| **excludeShared** | **bool?** | Specifies whether to exclude the group sharing settings from the response. | [optional]  |
| **count** | **int?** | The number of groups to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The starting index from which to begin retrieving groups with their sharing settings. | [optional]  |
| **filterValue** | **string?** | The text used as a filter for retrieving groups with their sharing settings. | [optional]  |

### Return type

[**GroupArrayWrapper**](GroupArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

