# DocSpace.API.SDK.Api.RoomsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddRoomTags**](#addroomtags) | **PUT** /api/2.0/files/rooms/{id}/tags | Add the room tags |
| [**ArchiveRoom**](#archiveroom) | **PUT** /api/2.0/files/rooms/{id}/archive | Archive a room |
| [**ChangeRoomCover**](#changeroomcover) | **POST** /api/2.0/files/rooms/{id}/cover | Change the room cover |
| [**CreateRoom**](#createroom) | **POST** /api/2.0/files/rooms | Create a room |
| [**CreateRoomFromTemplate**](#createroomfromtemplate) | **POST** /api/2.0/files/rooms/fromtemplate | Create a room from the template |
| [**CreateRoomLogo**](#createroomlogo) | **POST** /api/2.0/files/rooms/{id}/logo | Create a room logo |
| [**CreateRoomTag**](#createroomtag) | **POST** /api/2.0/files/tags | Create a tag |
| [**CreateRoomTemplate**](#createroomtemplate) | **POST** /api/2.0/files/roomtemplate | Start creating room template |
| [**CreateRoomThirdParty**](#createroomthirdparty) | **POST** /api/2.0/files/rooms/thirdparty/{id} | Create a third-party room |
| [**DeleteCustomTags**](#deletecustomtags) | **DELETE** /api/2.0/files/tags | Delete tags |
| [**DeleteRoom**](#deleteroom) | **DELETE** /api/2.0/files/rooms/{id} | Remove a room |
| [**DeleteRoomLogo**](#deleteroomlogo) | **DELETE** /api/2.0/files/rooms/{id}/logo | Remove a room logo |
| [**DeleteRoomTags**](#deleteroomtags) | **DELETE** /api/2.0/files/rooms/{id}/tags | Remove the room tags |
| [**GetNewRoomItems**](#getnewroomitems) | **GET** /api/2.0/files/rooms/{id}/news | Get the new room items |
| [**GetPublicSettings**](#getpublicsettings) | **GET** /api/2.0/files/roomtemplate/{id}/public | Get public settings |
| [**GetRoomCovers**](#getroomcovers) | **GET** /api/2.0/files/rooms/covers | Get covers |
| [**GetRoomCreatingStatus**](#getroomcreatingstatus) | **GET** /api/2.0/files/rooms/fromtemplate/status | Get the room creation progress |
| [**GetRoomIndexExport**](#getroomindexexport) | **GET** /api/2.0/files/rooms/indexexport | Get the room index export |
| [**GetRoomInfo**](#getroominfo) | **GET** /api/2.0/files/rooms/{id} | Get room information |
| [**GetRoomLinks**](#getroomlinks) | **GET** /api/2.0/files/rooms/{id}/links | Get the room links |
| [**GetRoomSecurityInfo**](#getroomsecurityinfo) | **GET** /api/2.0/files/rooms/{id}/share | Get the room access rights |
| [**GetRoomTagsInfo**](#getroomtagsinfo) | **GET** /api/2.0/files/tags | Get tags |
| [**GetRoomTemplateCreatingStatus**](#getroomtemplatecreatingstatus) | **GET** /api/2.0/files/roomtemplate/status | Get status of room template creation |
| [**GetRoomsFolder**](#getroomsfolder) | **GET** /api/2.0/files/rooms | Get rooms |
| [**GetRoomsNewItems**](#getroomsnewitems) | **GET** /api/2.0/files/rooms/news | Get the room new items |
| [**GetRoomsPrimaryExternalLink**](#getroomsprimaryexternallink) | **GET** /api/2.0/files/rooms/{id}/link | Get the room primary external link |
| [**PinRoom**](#pinroom) | **PUT** /api/2.0/files/rooms/{id}/pin | Pin a room |
| [**ReorderRoom**](#reorderroom) | **PUT** /api/2.0/files/rooms/{id}/reorder | Reorder the room |
| [**ResendEmailInvitations**](#resendemailinvitations) | **POST** /api/2.0/files/rooms/{id}/resend | Resend the room invitations |
| [**SetPublicSettings**](#setpublicsettings) | **PUT** /api/2.0/files/roomtemplate/public | Set public settings |
| [**SetRoomLink**](#setroomlink) | **PUT** /api/2.0/files/rooms/{id}/links | Set the room external or invitation link |
| [**SetRoomSecurity**](#setroomsecurity) | **PUT** /api/2.0/files/rooms/{id}/share | Set the room access rights |
| [**StartRoomIndexExport**](#startroomindexexport) | **POST** /api/2.0/files/rooms/{id}/indexexport | Start the room index export |
| [**TerminateRoomIndexExport**](#terminateroomindexexport) | **DELETE** /api/2.0/files/rooms/indexexport | Terminate the room index export |
| [**UnarchiveRoom**](#unarchiveroom) | **PUT** /api/2.0/files/rooms/{id}/unarchive | Unarchive a room |
| [**UnpinRoom**](#unpinroom) | **PUT** /api/2.0/files/rooms/{id}/unpin | Unpin a room |
| [**UpdateRoom**](#updateroom) | **PUT** /api/2.0/files/rooms/{id} | Update a room |
| [**UploadRoomLogo**](#uploadroomlogo) | **POST** /api/2.0/files/logos | Upload a room logo image |

<a id="addroomtags"></a>
# **AddRoomTags**
> FolderIntegerWrapper AddRoomTags (int id, BatchTagsRequestDto? batchTagsRequestDto = null)

Adds the tags to a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room Id. |  |
| **batchTagsRequestDto** | [**BatchTagsRequestDto?**](BatchTagsRequestDto.md) | The parameters for adding tags. | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class AddRoomTagsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room Id.
            var batchTagsRequestDto = new BatchTagsRequestDto?(); // BatchTagsRequestDto? | The parameters for adding tags. (optional) 

            try
            {
                // Add the room tags
                FolderIntegerWrapper result = apiInstance.AddRoomTags(id, batchTagsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.AddRoomTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddRoomTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add the room tags
    ApiResponse<FolderIntegerWrapper> response = apiInstance.AddRoomTagsWithHttpInfo(id, batchTagsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.AddRoomTagsWithHttpInfo: " + e.Message);
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
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have permission to edit the room |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="archiveroom"></a>
# **ArchiveRoom**
> FileOperationWrapper ArchiveRoom (int id, ArchiveRoomRequest? archiveRoomRequest = null)

Moves a room with the ID specified in the request to the \"Archive\" section.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **archiveRoomRequest** | [**ArchiveRoomRequest?**](ArchiveRoomRequest.md) | The parameters for archiving a room. | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

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
    public class ArchiveRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var archiveRoomRequest = new ArchiveRoomRequest?(); // ArchiveRoomRequest? | The parameters for archiving a room. (optional) 

            try
            {
                // Archive a room
                FileOperationWrapper result = apiInstance.ArchiveRoom(id, archiveRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.ArchiveRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ArchiveRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a room
    ApiResponse<FileOperationWrapper> response = apiInstance.ArchiveRoomWithHttpInfo(id, archiveRoomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.ArchiveRoomWithHttpInfo: " + e.Message);
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
| **200** | File operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changeroomcover"></a>
# **ChangeRoomCover**
> FolderIntegerWrapper ChangeRoomCover (int id, CoverRequestDto? coverRequestDto = null)

Changes a cover of a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **coverRequestDto** | [**CoverRequestDto?**](CoverRequestDto.md) | The request parameters to change the room cover. | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class ChangeRoomCoverExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var coverRequestDto = new CoverRequestDto?(); // CoverRequestDto? | The request parameters to change the room cover. (optional) 

            try
            {
                // Change the room cover
                FolderIntegerWrapper result = apiInstance.ChangeRoomCover(id, coverRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.ChangeRoomCover: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeRoomCoverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change the room cover
    ApiResponse<FolderIntegerWrapper> response = apiInstance.ChangeRoomCoverWithHttpInfo(id, coverRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.ChangeRoomCoverWithHttpInfo: " + e.Message);
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
| **200** | Room cover |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have permission to change cover |  -  |
| **404** | The required room was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createroom"></a>
# **CreateRoom**
> FolderIntegerWrapper CreateRoom (CreateRoomRequestDto? createRoomRequestDto = null)

Creates a room in the \"Rooms\" section.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRoomRequestDto** | [**CreateRoomRequestDto?**](CreateRoomRequestDto.md) | The request parameters for creating a room. | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class CreateRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var createRoomRequestDto = new CreateRoomRequestDto?(); // CreateRoomRequestDto? | The request parameters for creating a room. (optional) 

            try
            {
                // Create a room
                FolderIntegerWrapper result = apiInstance.CreateRoom(createRoomRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.CreateRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a room
    ApiResponse<FolderIntegerWrapper> response = apiInstance.CreateRoomWithHttpInfo(createRoomRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.CreateRoomWithHttpInfo: " + e.Message);
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
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createroomfromtemplate"></a>
# **CreateRoomFromTemplate**
> RoomFromTemplateStatusWrapper CreateRoomFromTemplate (CreateRoomFromTemplateDto? createRoomFromTemplateDto = null)

Creates a room in the \"Rooms\" section based on the template.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRoomFromTemplateDto** | [**CreateRoomFromTemplateDto?**](CreateRoomFromTemplateDto.md) | The parameters for creating a room from a template. | [optional]  |

### Return type

[**RoomFromTemplateStatusWrapper**](RoomFromTemplateStatusWrapper.md)

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
    public class CreateRoomFromTemplateExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var createRoomFromTemplateDto = new CreateRoomFromTemplateDto?(); // CreateRoomFromTemplateDto? | The parameters for creating a room from a template. (optional) 

            try
            {
                // Create a room from the template
                RoomFromTemplateStatusWrapper result = apiInstance.CreateRoomFromTemplate(createRoomFromTemplateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.CreateRoomFromTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoomFromTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a room from the template
    ApiResponse<RoomFromTemplateStatusWrapper> response = apiInstance.CreateRoomFromTemplateWithHttpInfo(createRoomFromTemplateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.CreateRoomFromTemplateWithHttpInfo: " + e.Message);
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
| **200** | Status |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createroomlogo"></a>
# **CreateRoomLogo**
> FolderIntegerWrapper CreateRoomLogo (int id, LogoRequest? logoRequest = null)

Creates a logo for a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **logoRequest** | [**LogoRequest?**](LogoRequest.md) | The logo request parameters. | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class CreateRoomLogoExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var logoRequest = new LogoRequest?(); // LogoRequest? | The logo request parameters. (optional) 

            try
            {
                // Create a room logo
                FolderIntegerWrapper result = apiInstance.CreateRoomLogo(id, logoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.CreateRoomLogo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoomLogoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a room logo
    ApiResponse<FolderIntegerWrapper> response = apiInstance.CreateRoomLogoWithHttpInfo(id, logoRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.CreateRoomLogoWithHttpInfo: " + e.Message);
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
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |
| **404** | The required room was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createroomtag"></a>
# **CreateRoomTag**
> ObjectWrapper CreateRoomTag (CreateTagRequestDto? createTagRequestDto = null)

Creates a custom tag with the parameters specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagRequestDto** | [**CreateTagRequestDto?**](CreateTagRequestDto.md) | The request parameters for creating a tag. | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

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
    public class CreateRoomTagExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var createTagRequestDto = new CreateTagRequestDto?(); // CreateTagRequestDto? | The request parameters for creating a tag. (optional) 

            try
            {
                // Create a tag
                ObjectWrapper result = apiInstance.CreateRoomTag(createTagRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.CreateRoomTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoomTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a tag
    ApiResponse<ObjectWrapper> response = apiInstance.CreateRoomTagWithHttpInfo(createTagRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.CreateRoomTagWithHttpInfo: " + e.Message);
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
| **200** | New tag name |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createroomtemplate"></a>
# **CreateRoomTemplate**
> RoomTemplateStatusWrapper CreateRoomTemplate (RoomTemplateDto? roomTemplateDto = null)

Starts creating the room template.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomTemplateDto** | [**RoomTemplateDto?**](RoomTemplateDto.md) | The room template parameters. | [optional]  |

### Return type

[**RoomTemplateStatusWrapper**](RoomTemplateStatusWrapper.md)

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
    public class CreateRoomTemplateExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var roomTemplateDto = new RoomTemplateDto?(); // RoomTemplateDto? | The room template parameters. (optional) 

            try
            {
                // Start creating room template
                RoomTemplateStatusWrapper result = apiInstance.CreateRoomTemplate(roomTemplateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.CreateRoomTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoomTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start creating room template
    ApiResponse<RoomTemplateStatusWrapper> response = apiInstance.CreateRoomTemplateWithHttpInfo(roomTemplateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.CreateRoomTemplateWithHttpInfo: " + e.Message);
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
| **200** | Status |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createroomthirdparty"></a>
# **CreateRoomThirdParty**
> FolderStringWrapper CreateRoomThirdParty (string id, CreateThirdPartyRoom? createThirdPartyRoom = null)

Creates a room in the \"Rooms\" section stored in a third-party storage.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the folder in the third-party storage in which the contents of the room will be stored. |  |
| **createThirdPartyRoom** | [**CreateThirdPartyRoom?**](CreateThirdPartyRoom.md) | The third-party room information. | [optional]  |

### Return type

[**FolderStringWrapper**](FolderStringWrapper.md)

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
    public class CreateRoomThirdPartyExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // string | The ID of the folder in the third-party storage in which the contents of the room will be stored.
            var createThirdPartyRoom = new CreateThirdPartyRoom?(); // CreateThirdPartyRoom? | The third-party room information. (optional) 

            try
            {
                // Create a third-party room
                FolderStringWrapper result = apiInstance.CreateRoomThirdParty(id, createThirdPartyRoom);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.CreateRoomThirdParty: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRoomThirdPartyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a third-party room
    ApiResponse<FolderStringWrapper> response = apiInstance.CreateRoomThirdPartyWithHttpInfo(id, createThirdPartyRoom);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.CreateRoomThirdPartyWithHttpInfo: " + e.Message);
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
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomtags"></a>
# **DeleteCustomTags**
> void DeleteCustomTags (BatchTagsRequestDto? batchTagsRequestDto = null)

Deletes a bunch of custom tags specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchTagsRequestDto** | [**BatchTagsRequestDto?**](BatchTagsRequestDto.md) | The parameters for adding tags. | [optional]  |

### Return type

void (empty response body)

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
    public class DeleteCustomTagsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var batchTagsRequestDto = new BatchTagsRequestDto?(); // BatchTagsRequestDto? | The parameters for adding tags. (optional) 

            try
            {
                // Delete tags
                apiInstance.DeleteCustomTags(batchTagsRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.DeleteCustomTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete tags
    apiInstance.DeleteCustomTagsWithHttpInfo(batchTagsRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.DeleteCustomTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteroom"></a>
# **DeleteRoom**
> FileOperationWrapper DeleteRoom (int id, DeleteRoomRequest? deleteRoomRequest = null)

Removes a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **deleteRoomRequest** | [**DeleteRoomRequest?**](DeleteRoomRequest.md) | The parameters for deleting a room. | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

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
    public class DeleteRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var deleteRoomRequest = new DeleteRoomRequest?(); // DeleteRoomRequest? | The parameters for deleting a room. (optional) 

            try
            {
                // Remove a room
                FileOperationWrapper result = apiInstance.DeleteRoom(id, deleteRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.DeleteRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a room
    ApiResponse<FileOperationWrapper> response = apiInstance.DeleteRoomWithHttpInfo(id, deleteRoomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.DeleteRoomWithHttpInfo: " + e.Message);
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
| **200** | File operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteroomlogo"></a>
# **DeleteRoomLogo**
> FolderIntegerWrapper DeleteRoomLogo (int id)

Removes a logo from a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class DeleteRoomLogoExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Remove a room logo
                FolderIntegerWrapper result = apiInstance.DeleteRoomLogo(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.DeleteRoomLogo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRoomLogoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a room logo
    ApiResponse<FolderIntegerWrapper> response = apiInstance.DeleteRoomLogoWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.DeleteRoomLogoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteroomtags"></a>
# **DeleteRoomTags**
> FolderIntegerWrapper DeleteRoomTags (int id, BatchTagsRequestDto? batchTagsRequestDto = null)

Removes the tags from a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room Id. |  |
| **batchTagsRequestDto** | [**BatchTagsRequestDto?**](BatchTagsRequestDto.md) | The parameters for adding tags. | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class DeleteRoomTagsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room Id.
            var batchTagsRequestDto = new BatchTagsRequestDto?(); // BatchTagsRequestDto? | The parameters for adding tags. (optional) 

            try
            {
                // Remove the room tags
                FolderIntegerWrapper result = apiInstance.DeleteRoomTags(id, batchTagsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.DeleteRoomTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRoomTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove the room tags
    ApiResponse<FolderIntegerWrapper> response = apiInstance.DeleteRoomTagsWithHttpInfo(id, batchTagsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.DeleteRoomTagsWithHttpInfo: " + e.Message);
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
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have permission to edit the room |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnewroomitems"></a>
# **GetNewRoomItems**
> NewItemsFileEntryBaseArrayWrapper GetNewRoomItems (int id)

Returns a list of all the new items from a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**NewItemsFileEntryBaseArrayWrapper**](NewItemsFileEntryBaseArrayWrapper.md)

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
    public class GetNewRoomItemsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Get the new room items
                NewItemsFileEntryBaseArrayWrapper result = apiInstance.GetNewRoomItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetNewRoomItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNewRoomItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the new room items
    ApiResponse<NewItemsFileEntryBaseArrayWrapper> response = apiInstance.GetNewRoomItemsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetNewRoomItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of file entry information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpublicsettings"></a>
# **GetPublicSettings**
> BooleanWrapper GetPublicSettings (int id)

Returns the public settings of the room template with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room template ID. |  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class GetPublicSettingsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room template ID.

            try
            {
                // Get public settings
                BooleanWrapper result = apiInstance.GetPublicSettings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetPublicSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPublicSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get public settings
    ApiResponse<BooleanWrapper> response = apiInstance.GetPublicSettingsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetPublicSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomcovers"></a>
# **GetRoomCovers**
> CoversResultArrayWrapper GetRoomCovers ()

Returns a list of all covers.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**CoversResultArrayWrapper**](CoversResultArrayWrapper.md)

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
    public class GetRoomCoversExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get covers
                CoversResultArrayWrapper result = apiInstance.GetRoomCovers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomCovers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomCoversWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get covers
    ApiResponse<CoversResultArrayWrapper> response = apiInstance.GetRoomCoversWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomCoversWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gets room cover |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomcreatingstatus"></a>
# **GetRoomCreatingStatus**
> RoomFromTemplateStatusWrapper GetRoomCreatingStatus ()

Returns the progress of creating a room from the template.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**RoomFromTemplateStatusWrapper**](RoomFromTemplateStatusWrapper.md)

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
    public class GetRoomCreatingStatusExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the room creation progress
                RoomFromTemplateStatusWrapper result = apiInstance.GetRoomCreatingStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomCreatingStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomCreatingStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the room creation progress
    ApiResponse<RoomFromTemplateStatusWrapper> response = apiInstance.GetRoomCreatingStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomCreatingStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Status |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomindexexport"></a>
# **GetRoomIndexExport**
> DocumentBuilderTaskWrapper GetRoomIndexExport ()

Returns the room index export.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**DocumentBuilderTaskWrapper**](DocumentBuilderTaskWrapper.md)

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
    public class GetRoomIndexExportExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the room index export
                DocumentBuilderTaskWrapper result = apiInstance.GetRoomIndexExport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomIndexExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomIndexExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the room index export
    ApiResponse<DocumentBuilderTaskWrapper> response = apiInstance.GetRoomIndexExportWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomIndexExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroominfo"></a>
# **GetRoomInfo**
> FolderIntegerWrapper GetRoomInfo (int id)

Returns the room information.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

No authorization required

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
    public class GetRoomInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Get room information
                FolderIntegerWrapper result = apiInstance.GetRoomInfo(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get room information
    ApiResponse<FolderIntegerWrapper> response = apiInstance.GetRoomInfoWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomlinks"></a>
# **GetRoomLinks**
> FileShareArrayWrapper GetRoomLinks (int id, LinkType? type = null)

Returns the links of the room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **type** | [**LinkType?**](LinkType.md) | The link type. | [optional]  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

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
    public class GetRoomLinksExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var type = new LinkType?(); // LinkType? | The link type. (optional) 

            try
            {
                // Get the room links
                FileShareArrayWrapper result = apiInstance.GetRoomLinks(id, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomLinks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomLinksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the room links
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetRoomLinksWithHttpInfo(id, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomLinksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomsecurityinfo"></a>
# **GetRoomSecurityInfo**
> FileShareArrayWrapper GetRoomSecurityInfo (int id, ShareFilterType? filterType = null, int? count = null, int? startIndex = null, string? filterValue = null)

Returns the access rights of a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **filterType** | [**ShareFilterType?**](ShareFilterType.md) | The filter type of the access rights. | [optional]  |
| **count** | **int?** | The number of items to be retrieved or processed. | [optional]  |
| **startIndex** | **int?** | The starting index of the items to retrieve in a paginated request. | [optional]  |
| **filterValue** | **string?** | The text filter value used for filtering room security information. | [optional]  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

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
    public class GetRoomSecurityInfoExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var filterType = new ShareFilterType?(); // ShareFilterType? | The filter type of the access rights. (optional) 
            var count = 1234;  // int? | The number of items to be retrieved or processed. (optional) 
            var startIndex = 1234;  // int? | The starting index of the items to retrieve in a paginated request. (optional) 
            var filterValue = some text;  // string? | The text filter value used for filtering room security information. (optional) 

            try
            {
                // Get the room access rights
                FileShareArrayWrapper result = apiInstance.GetRoomSecurityInfo(id, filterType, count, startIndex, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the room access rights
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetRoomSecurityInfoWithHttpInfo(id, filterType, count, startIndex, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomSecurityInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Security information of room files |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomtagsinfo"></a>
# **GetRoomTagsInfo**
> ObjectArrayWrapper GetRoomTagsInfo (int? count = null, int? startIndex = null, string? filterValue = null, string fields = null)

Returns a list of custom tags.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **count** | **int?** | Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. | [optional]  |
| **startIndex** | **int?** | Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. | [optional]  |
| **filterValue** | **string?** | Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. | [optional]  |
| **fields** | **string** | Comma-separated list of fields to include in the response | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

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
    public class GetRoomTagsInfoExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var count = 1234;  // int? | Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional) 
            var startIndex = 1234;  // int? | Represents the starting index from which the tags' information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional) 
            var filterValue = some text;  // string? | Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional) 
            var fields = ;  // string | Comma-separated list of fields to include in the response (optional) 

            try
            {
                // Get tags
                ObjectArrayWrapper result = apiInstance.GetRoomTagsInfo(count, startIndex, filterValue, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomTagsInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomTagsInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get tags
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetRoomTagsInfoWithHttpInfo(count, startIndex, filterValue, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomTagsInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tag names |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomtemplatecreatingstatus"></a>
# **GetRoomTemplateCreatingStatus**
> RoomTemplateStatusWrapper GetRoomTemplateCreatingStatus ()

Returns the progress status of the room template creation process.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**RoomTemplateStatusWrapper**](RoomTemplateStatusWrapper.md)

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
    public class GetRoomTemplateCreatingStatusExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get status of room template creation
                RoomTemplateStatusWrapper result = apiInstance.GetRoomTemplateCreatingStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomTemplateCreatingStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomTemplateCreatingStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get status of room template creation
    ApiResponse<RoomTemplateStatusWrapper> response = apiInstance.GetRoomTemplateCreatingStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomTemplateCreatingStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Status |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomsfolder"></a>
# **GetRoomsFolder**
> FolderContentIntegerWrapper GetRoomsFolder (List<RoomType>? type = null, string? subjectId = null, SearchArea? searchArea = null, bool? withoutTags = null, string? tags = null, bool? excludeSubject = null, ProviderFilter? provider = null, SubjectFilter? subjectFilter = null, QuotaFilter? quotaFilter = null, StorageFilter? storageFilter = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null, string fields = null)

Returns the contents of the \"Rooms\" section by the parameters specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | [**List&lt;RoomType&gt;?**](RoomType.md) | The filter by room type. | [optional]  |
| **subjectId** | **string?** | The filter by user ID. | [optional]  |
| **searchArea** | [**SearchArea?**](SearchArea.md) | The room search area (Active, Archive, Any, Recent by links). | [optional]  |
| **withoutTags** | **bool?** | Specifies whether to search by tags or not. | [optional]  |
| **tags** | **string?** | The tags in the serialized format. | [optional]  |
| **excludeSubject** | **bool?** | Specifies whether to exclude search by user or group ID. | [optional]  |
| **provider** | [**ProviderFilter?**](ProviderFilter.md) | The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). | [optional]  |
| **subjectFilter** | [**SubjectFilter?**](SubjectFilter.md) | The filter by user (Owner - 0, Member - 1). | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter.md) | The filter by quota (All - 0, Default - 1, Custom - 2). | [optional]  |
| **storageFilter** | [**StorageFilter?**](StorageFilter.md) | The filter by storage (None - 0, Internal - 1, ThirdParty - 2). | [optional]  |
| **count** | **int?** | Specifies the maximum number of items to retrieve. | [optional]  |
| **startIndex** | **int?** | The index from which to start retrieving the room content. | [optional]  |
| **sortBy** | **string?** | Specifies the field by which the room content should be sorted. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text filter value used to refine search or query operations. | [optional]  |
| **fields** | **string** | Comma-separated list of fields to include in the response | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetRoomsFolderExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var type = new List<RoomType>?(); // List<RoomType>? | The filter by room type. (optional) 
            var subjectId = some text;  // string? | The filter by user ID. (optional) 
            var searchArea = new SearchArea?(); // SearchArea? | The room search area (Active, Archive, Any, Recent by links). (optional) 
            var withoutTags = true;  // bool? | Specifies whether to search by tags or not. (optional) 
            var tags = some text;  // string? | The tags in the serialized format. (optional) 
            var excludeSubject = true;  // bool? | Specifies whether to exclude search by user or group ID. (optional) 
            var provider = new ProviderFilter?(); // ProviderFilter? | The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional) 
            var subjectFilter = new SubjectFilter?(); // SubjectFilter? | The filter by user (Owner - 0, Member - 1). (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | The filter by quota (All - 0, Default - 1, Custom - 2). (optional) 
            var storageFilter = new StorageFilter?(); // StorageFilter? | The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional) 
            var count = 1234;  // int? | Specifies the maximum number of items to retrieve. (optional) 
            var startIndex = 1234;  // int? | The index from which to start retrieving the room content. (optional) 
            var sortBy = some text;  // string? | Specifies the field by which the room content should be sorted. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text filter value used to refine search or query operations. (optional) 
            var fields = ;  // string | Comma-separated list of fields to include in the response (optional) 

            try
            {
                // Get rooms
                FolderContentIntegerWrapper result = apiInstance.GetRoomsFolder(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomsFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomsFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get rooms
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetRoomsFolderWithHttpInfo(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue, fields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomsFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the contents of the \&quot;Rooms\&quot; section |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to view the room content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomsnewitems"></a>
# **GetRoomsNewItems**
> NewItemsRoomNewItemsArrayWrapper GetRoomsNewItems ()

Returns the room new items.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**NewItemsRoomNewItemsArrayWrapper**](NewItemsRoomNewItemsArrayWrapper.md)

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
    public class GetRoomsNewItemsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the room new items
                NewItemsRoomNewItemsArrayWrapper result = apiInstance.GetRoomsNewItems();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomsNewItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomsNewItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the room new items
    ApiResponse<NewItemsRoomNewItemsArrayWrapper> response = apiInstance.GetRoomsNewItemsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomsNewItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of new items |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomsprimaryexternallink"></a>
# **GetRoomsPrimaryExternalLink**
> FileShareWrapper GetRoomsPrimaryExternalLink (int id)

Returns the primary external link of the room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

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
    public class GetRoomsPrimaryExternalLinkExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Get the room primary external link
                FileShareWrapper result = apiInstance.GetRoomsPrimaryExternalLink(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoomsPrimaryExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomsPrimaryExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the room primary external link
    ApiResponse<FileShareWrapper> response = apiInstance.GetRoomsPrimaryExternalLinkWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomsPrimaryExternalLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room security information |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pinroom"></a>
# **PinRoom**
> FolderIntegerWrapper PinRoom (int id)

Pins a room with the ID specified in the request to the top of the list.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class PinRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Pin a room
                FolderIntegerWrapper result = apiInstance.PinRoom(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.PinRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PinRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pin a room
    ApiResponse<FolderIntegerWrapper> response = apiInstance.PinRoomWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.PinRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reorderroom"></a>
# **ReorderRoom**
> FolderIntegerWrapper ReorderRoom (int id)

Reorders the room with ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class ReorderRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Reorder the room
                FolderIntegerWrapper result = apiInstance.ReorderRoom(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.ReorderRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReorderRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reorder the room
    ApiResponse<FolderIntegerWrapper> response = apiInstance.ReorderRoomWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.ReorderRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resendemailinvitations"></a>
# **ResendEmailInvitations**
> void ResendEmailInvitations (int id, UserInvitation? userInvitation = null)

Resends the email invitations to a room with the ID specified in the request to the selected users.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **userInvitation** | [**UserInvitation?**](UserInvitation.md) | The user invitation parameters. | [optional]  |

### Return type

void (empty response body)

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
    public class ResendEmailInvitationsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var userInvitation = new UserInvitation?(); // UserInvitation? | The user invitation parameters. (optional) 

            try
            {
                // Resend the room invitations
                apiInstance.ResendEmailInvitations(id, userInvitation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.ResendEmailInvitations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResendEmailInvitationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend the room invitations
    apiInstance.ResendEmailInvitationsWithHttpInfo(id, userInvitation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.ResendEmailInvitationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpublicsettings"></a>
# **SetPublicSettings**
> void SetPublicSettings (SetPublicDto? setPublicDto = null)

Sets the public settings for the room template with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setPublicDto** | [**SetPublicDto?**](SetPublicDto.md) | The public settings of the room template to set. | [optional]  |

### Return type

void (empty response body)

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
    public class SetPublicSettingsExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var setPublicDto = new SetPublicDto?(); // SetPublicDto? | The public settings of the room template to set. (optional) 

            try
            {
                // Set public settings
                apiInstance.SetPublicSettings(setPublicDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.SetPublicSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPublicSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set public settings
    apiInstance.SetPublicSettingsWithHttpInfo(setPublicDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.SetPublicSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setroomlink"></a>
# **SetRoomLink**
> FileShareWrapper SetRoomLink (int id, RoomLinkRequest? roomLinkRequest = null)

Sets the room external or invitation link with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **roomLinkRequest** | [**RoomLinkRequest?**](RoomLinkRequest.md) | The room link parameters. | [optional]  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

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
    public class SetRoomLinkExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var roomLinkRequest = new RoomLinkRequest?(); // RoomLinkRequest? | The room link parameters. (optional) 

            try
            {
                // Set the room external or invitation link
                FileShareWrapper result = apiInstance.SetRoomLink(id, roomLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.SetRoomLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRoomLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the room external or invitation link
    ApiResponse<FileShareWrapper> response = apiInstance.SetRoomLinkWithHttpInfo(id, roomLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.SetRoomLinkWithHttpInfo: " + e.Message);
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
| **200** | Room security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setroomsecurity"></a>
# **SetRoomSecurity**
> RoomSecurityWrapper SetRoomSecurity (int id, RoomInvitationRequest? roomInvitationRequest = null)

Sets the access rights to the room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **roomInvitationRequest** | [**RoomInvitationRequest?**](RoomInvitationRequest.md) | The room invitation request. | [optional]  |

### Return type

[**RoomSecurityWrapper**](RoomSecurityWrapper.md)

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
    public class SetRoomSecurityExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var roomInvitationRequest = new RoomInvitationRequest?(); // RoomInvitationRequest? | The room invitation request. (optional) 

            try
            {
                // Set the room access rights
                RoomSecurityWrapper result = apiInstance.SetRoomSecurity(id, roomInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.SetRoomSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRoomSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the room access rights
    ApiResponse<RoomSecurityWrapper> response = apiInstance.SetRoomSecurityWithHttpInfo(id, roomInvitationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.SetRoomSecurityWithHttpInfo: " + e.Message);
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
| **200** | Room security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startroomindexexport"></a>
# **StartRoomIndexExport**
> DocumentBuilderTaskWrapper StartRoomIndexExport (int id)

Starts the index export of a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**DocumentBuilderTaskWrapper**](DocumentBuilderTaskWrapper.md)

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
    public class StartRoomIndexExportExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Start the room index export
                DocumentBuilderTaskWrapper result = apiInstance.StartRoomIndexExport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.StartRoomIndexExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartRoomIndexExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start the room index export
    ApiResponse<DocumentBuilderTaskWrapper> response = apiInstance.StartRoomIndexExportWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.StartRoomIndexExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **501** | Folder indexing is turned off |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="terminateroomindexexport"></a>
# **TerminateRoomIndexExport**
> void TerminateRoomIndexExport ()

Terminates the room index export.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

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
    public class TerminateRoomIndexExportExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Terminate the room index export
                apiInstance.TerminateRoomIndexExport();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.TerminateRoomIndexExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TerminateRoomIndexExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Terminate the room index export
    apiInstance.TerminateRoomIndexExportWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.TerminateRoomIndexExportWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unarchiveroom"></a>
# **UnarchiveRoom**
> FileOperationWrapper UnarchiveRoom (int id, ArchiveRoomRequest? archiveRoomRequest = null)

Moves a room with the ID specified in the request from the \"Archive\" section to the \"Rooms\" section.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **archiveRoomRequest** | [**ArchiveRoomRequest?**](ArchiveRoomRequest.md) | The parameters for archiving a room. | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

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
    public class UnarchiveRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var archiveRoomRequest = new ArchiveRoomRequest?(); // ArchiveRoomRequest? | The parameters for archiving a room. (optional) 

            try
            {
                // Unarchive a room
                FileOperationWrapper result = apiInstance.UnarchiveRoom(id, archiveRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.UnarchiveRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnarchiveRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unarchive a room
    ApiResponse<FileOperationWrapper> response = apiInstance.UnarchiveRoomWithHttpInfo(id, archiveRoomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.UnarchiveRoomWithHttpInfo: " + e.Message);
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
| **200** | File operation |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unpinroom"></a>
# **UnpinRoom**
> FolderIntegerWrapper UnpinRoom (int id)

Unpins a room with the ID specified in the request from the top of the list.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID of the request. |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class UnpinRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID of the request.

            try
            {
                // Unpin a room
                FolderIntegerWrapper result = apiInstance.UnpinRoom(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.UnpinRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnpinRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unpin a room
    ApiResponse<FolderIntegerWrapper> response = apiInstance.UnpinRoomWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.UnpinRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateroom"></a>
# **UpdateRoom**
> FolderIntegerWrapper UpdateRoom (int id, UpdateRoomRequest? updateRoomRequest = null)

Updates a room with the ID specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The room ID. |  |
| **updateRoomRequest** | [**UpdateRoomRequest?**](UpdateRoomRequest.md) | The request parameters for updating a room. | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

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
    public class UpdateRoomExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The room ID.
            var updateRoomRequest = new UpdateRoomRequest?(); // UpdateRoomRequest? | The request parameters for updating a room. (optional) 

            try
            {
                // Update a room
                FolderIntegerWrapper result = apiInstance.UpdateRoom(id, updateRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.UpdateRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a room
    ApiResponse<FolderIntegerWrapper> response = apiInstance.UpdateRoomWithHttpInfo(id, updateRoomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.UpdateRoomWithHttpInfo: " + e.Message);
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
| **200** | Updated room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadroomlogo"></a>
# **UploadRoomLogo**
> UploadResultWrapper UploadRoomLogo (List<KeyValuePairStringStringValues>? formCollection = null)

Uploads a temporary image to create a room logo.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formCollection** | [**List&lt;KeyValuePairStringStringValues&gt;?**](KeyValuePairStringStringValues.md) | The image data. | [optional]  |

### Return type

[**UploadResultWrapper**](UploadResultWrapper.md)

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
    public class UploadRoomLogoExample
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
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var formCollection = new List<KeyValuePairStringStringValues>?(); // List<KeyValuePairStringStringValues>? | The image data. (optional) 

            try
            {
                // Upload a room logo image
                UploadResultWrapper result = apiInstance.UploadRoomLogo(formCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.UploadRoomLogo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadRoomLogoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a room logo image
    ApiResponse<UploadResultWrapper> response = apiInstance.UploadRoomLogoWithHttpInfo(formCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.UploadRoomLogoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Upload result |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

