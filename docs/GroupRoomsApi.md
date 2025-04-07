# Docspace.Api.GroupRoomsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGroupsWithShared**](GroupRoomsApi.md#getgroupswithshared) | **GET** /api/2.0/group/room/{id} | Gets groups with shared |

<a id="getgroupswithshared"></a>
# **GetGroupsWithShared**
> GroupArrayWrapper GetGroupsWithShared (int id, bool? excludeShared = null)

Gets groups with shared

Gets groups with shared

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | ID
            var excludeShared = true;  // bool? | Exclude shared (optional) 

            try
            {
                // Gets groups with shared
                GroupArrayWrapper result = apiInstance.GetGroupsWithShared(id, excludeShared);
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
    // Gets groups with shared
    ApiResponse<GroupArrayWrapper> response = apiInstance.GetGroupsWithSharedWithHttpInfo(id, excludeShared);
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
| **id** | **int** | ID |  |
| **excludeShared** | **bool?** | Exclude shared | [optional]  |

### Return type

[**GroupArrayWrapper**](GroupArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

