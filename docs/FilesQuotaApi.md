# Docspace.Api.FilesQuotaApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResetRoomQuota**](FilesQuotaApi.md#resetroomquota) | **PUT** /api/2.0/files/rooms/resetquota | Reset a room quota limit |
| [**UpdateRoomsQuota**](FilesQuotaApi.md#updateroomsquota) | **PUT** /api/2.0/files/rooms/roomquota | Change a room quota limit |

<a id="resetroomquota"></a>
# **ResetRoomQuota**
> FolderIntegerArrayWrapper ResetRoomQuota (UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = null)

Reset a room quota limit

Resets a quota limit for the rooms with the IDs specified in the request.

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
    public class ResetRoomQuotaExample
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
            var apiInstance = new FilesQuotaApi(httpClient, config, httpClientHandler);
            var updateRoomsRoomIdsRequestDtoInteger = new UpdateRoomsRoomIdsRequestDtoInteger?(); // UpdateRoomsRoomIdsRequestDtoInteger? |  (optional) 

            try
            {
                // Reset a room quota limit
                FolderIntegerArrayWrapper result = apiInstance.ResetRoomQuota(updateRoomsRoomIdsRequestDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesQuotaApi.ResetRoomQuota: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetRoomQuotaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset a room quota limit
    ApiResponse<FolderIntegerArrayWrapper> response = apiInstance.ResetRoomQuotaWithHttpInfo(updateRoomsRoomIdsRequestDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesQuotaApi.ResetRoomQuotaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateRoomsRoomIdsRequestDtoInteger** | [**UpdateRoomsRoomIdsRequestDtoInteger?**](UpdateRoomsRoomIdsRequestDtoInteger?.md) |  | [optional]  |

### Return type

[**FolderIntegerArrayWrapper**](FolderIntegerArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of rooms with the detailed information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateroomsquota"></a>
# **UpdateRoomsQuota**
> FolderIntegerArrayWrapper UpdateRoomsQuota (UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = null)

Change a room quota limit

Changes a quota limit for the rooms with the IDs specified in the request.

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
    public class UpdateRoomsQuotaExample
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
            var apiInstance = new FilesQuotaApi(httpClient, config, httpClientHandler);
            var updateRoomsQuotaRequestDtoInteger = new UpdateRoomsQuotaRequestDtoInteger?(); // UpdateRoomsQuotaRequestDtoInteger? |  (optional) 

            try
            {
                // Change a room quota limit
                FolderIntegerArrayWrapper result = apiInstance.UpdateRoomsQuota(updateRoomsQuotaRequestDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesQuotaApi.UpdateRoomsQuota: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRoomsQuotaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change a room quota limit
    ApiResponse<FolderIntegerArrayWrapper> response = apiInstance.UpdateRoomsQuotaWithHttpInfo(updateRoomsQuotaRequestDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesQuotaApi.UpdateRoomsQuotaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateRoomsQuotaRequestDtoInteger** | [**UpdateRoomsQuotaRequestDtoInteger?**](UpdateRoomsQuotaRequestDtoInteger?.md) |  | [optional]  |

### Return type

[**FolderIntegerArrayWrapper**](FolderIntegerArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of rooms with the detailed information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

