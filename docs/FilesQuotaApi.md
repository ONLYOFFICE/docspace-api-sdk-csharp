# DocSpace.API.SDK.Api.QuotaApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ResetRoomQuota**](#resetroomquota) | **PUT** /api/2.0/files/rooms/resetquota | Reset the room quota limit |
| [**UpdateRoomsQuota**](#updateroomsquota) | **PUT** /api/2.0/files/rooms/roomquota | Change the room quota limit |

<a id="resetroomquota"></a>
# **ResetRoomQuota**
> FolderIntegerArrayWrapper ResetRoomQuota (UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = null)

Returns every listed room to the default room quota of the portal and streams the updated rooms back in the  order they were given. This is not the same as removing the limit: the room stops carrying its own value and  starts following the portal default, which a portal administrator can change at any time. The per-room quota  feature has to be on, the caller must be a manager of each listed room, and an archived room or a room in the  trash is refused. The list is not transactional, so rooms processed before a failing one keep the default and  the rest keep what they had. Only numeric room ids are processed, which means ids of rooms stored in a  connected third-party account are silently skipped. Use `PUT api/2.0/files/rooms/roomquota` to set an explicit  value, and a quota of -1 in `PUT api/2.0/files/rooms/{id}` to leave the room with no custom limit at all.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-room-quota/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateRoomsRoomIdsRequestDtoInteger** | [**UpdateRoomsRoomIdsRequestDtoInteger?**](UpdateRoomsRoomIdsRequestDtoInteger.md) | The rooms that are to go back to the default storage limit of the portal. | [optional]  |

### Return type

[**FolderIntegerArrayWrapper**](FolderIntegerArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
    public class ResetRoomQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
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
            var apiInstance = new QuotaApi(httpClient, config, httpClientHandler);
            var updateRoomsRoomIdsRequestDtoInteger = new UpdateRoomsRoomIdsRequestDtoInteger?(); // UpdateRoomsRoomIdsRequestDtoInteger? | The rooms that are to go back to the default storage limit of the portal. (optional) 

            try
            {
                // Reset the room quota limit
                FolderIntegerArrayWrapper result = apiInstance.ResetRoomQuota(updateRoomsRoomIdsRequestDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotaApi.ResetRoomQuota: " + e.Message);
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
    // Reset the room quota limit
    ApiResponse<FolderIntegerArrayWrapper> response = apiInstance.ResetRoomQuotaWithHttpInfo(updateRoomsRoomIdsRequestDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotaApi.ResetRoomQuotaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rooms as they are after the default limit was restored |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateroomsquota"></a>
# **UpdateRoomsQuota**
> FolderIntegerArrayWrapper UpdateRoomsQuota (UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = null)

Sets the same custom storage limit, in bytes, on every listed room and streams the updated rooms back in the  order they were given. The per-room quota feature has to be on for the portal, and the value must stay within  the portal own limit, otherwise the call is refused before anything is written. The caller must be a manager  of each listed room, and an archived room or a room in the trash is refused. The list is not transactional:  rooms processed before the offending one keep their new limit, so a failed call has to be checked room by  room. Only numeric room ids are processed, which means ids of rooms stored in a connected third-party account  are silently skipped. A room whose limit already equals the requested value is left untouched and still  returned. To go back to the portal default use `PUT api/2.0/files/rooms/resetquota`, and to drop the custom  limit entirely send a quota of -1 to `PUT api/2.0/files/rooms/{id}`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-rooms-quota/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateRoomsQuotaRequestDtoInteger** | [**UpdateRoomsQuotaRequestDtoInteger?**](UpdateRoomsQuotaRequestDtoInteger.md) | The rooms whose storage limit is to be changed, and the limit to give them. | [optional]  |

### Return type

[**FolderIntegerArrayWrapper**](FolderIntegerArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
    public class UpdateRoomsQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
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
            var apiInstance = new QuotaApi(httpClient, config, httpClientHandler);
            var updateRoomsQuotaRequestDtoInteger = new UpdateRoomsQuotaRequestDtoInteger?(); // UpdateRoomsQuotaRequestDtoInteger? | The rooms whose storage limit is to be changed, and the limit to give them. (optional) 

            try
            {
                // Change the room quota limit
                FolderIntegerArrayWrapper result = apiInstance.UpdateRoomsQuota(updateRoomsQuotaRequestDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotaApi.UpdateRoomsQuota: " + e.Message);
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
    // Change the room quota limit
    ApiResponse<FolderIntegerArrayWrapper> response = apiInstance.UpdateRoomsQuotaWithHttpInfo(updateRoomsQuotaRequestDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotaApi.UpdateRoomsQuotaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rooms as they are after the new limit was applied |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

