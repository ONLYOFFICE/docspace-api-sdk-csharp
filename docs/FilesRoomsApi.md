# Docspace.Api.FilesRoomsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTags**](FilesRoomsApi.md#addtags) | **PUT** /api/2.0/files/rooms/{id}/tags | Add room tags |
| [**ArchiveRoom**](FilesRoomsApi.md#archiveroom) | **PUT** /api/2.0/files/rooms/{id}/archive | Archive a room |
| [**ChangeRoomCover**](FilesRoomsApi.md#changeroomcover) | **POST** /api/2.0/files/rooms/{id}/cover | Changes room cover |
| [**CreateRoom**](FilesRoomsApi.md#createroom) | **POST** /api/2.0/files/rooms | Create a room |
| [**CreateRoomFromTemplate**](FilesRoomsApi.md#createroomfromtemplate) | **POST** /api/2.0/files/rooms/fromtemplate | Start create a room based on a template |
| [**CreateRoomLogo**](FilesRoomsApi.md#createroomlogo) | **POST** /api/2.0/files/rooms/{id}/logo | Create a room logo |
| [**CreateRoomThirdParty**](FilesRoomsApi.md#createroomthirdparty) | **POST** /api/2.0/files/rooms/thirdparty/{id} | Create a third-party room |
| [**CreateTag**](FilesRoomsApi.md#createtag) | **POST** /api/2.0/files/tags | Create a tag |
| [**CreateTemplate**](FilesRoomsApi.md#createtemplate) | **POST** /api/2.0/files/roomtemplate | Start create room template |
| [**DeleteCustomTags**](FilesRoomsApi.md#deletecustomtags) | **DELETE** /api/2.0/files/tags | Delete tags |
| [**DeleteRoom**](FilesRoomsApi.md#deleteroom) | **DELETE** /api/2.0/files/rooms/{id} | Remove a room |
| [**DeleteRoomLogo**](FilesRoomsApi.md#deleteroomlogo) | **DELETE** /api/2.0/files/rooms/{id}/logo | Remove a room logo |
| [**DeleteTags**](FilesRoomsApi.md#deletetags) | **DELETE** /api/2.0/files/rooms/{id}/tags | Remove room tags |
| [**GetCovers**](FilesRoomsApi.md#getcovers) | **GET** /api/2.0/files/rooms/covers | Gets covers |
| [**GetNewRoomItems**](FilesRoomsApi.md#getnewroomitems) | **GET** /api/2.0/files/rooms/{id}/news | Get new room items |
| [**GetRoomCreatingStatus**](FilesRoomsApi.md#getroomcreatingstatus) | **GET** /api/2.0/files/rooms/fromtemplate/status | Get progress creating room |
| [**GetRoomIndexExport**](FilesRoomsApi.md#getroomindexexport) | **GET** /api/2.0/files/rooms/indexexport | Gets room index export |
| [**GetRoomInfo**](FilesRoomsApi.md#getroominfo) | **GET** /api/2.0/files/rooms/{id} | Get room information |
| [**GetRoomLinks**](FilesRoomsApi.md#getroomlinks) | **GET** /api/2.0/files/rooms/{id}/links | Get room links |
| [**GetRoomSecurityInfo**](FilesRoomsApi.md#getroomsecurityinfo) | **GET** /api/2.0/files/rooms/{id}/share | Get room access rights |
| [**GetRoomsFolder**](FilesRoomsApi.md#getroomsfolder) | **GET** /api/2.0/files/rooms | Get rooms |
| [**GetRoomsNewItems**](FilesRoomsApi.md#getroomsnewitems) | **GET** /api/2.0/files/rooms/news | Gets room new items |
| [**GetRoomsPrimaryExternalLink**](FilesRoomsApi.md#getroomsprimaryexternallink) | **GET** /api/2.0/files/rooms/{id}/link | Get primary external link |
| [**GetTagsInfo**](FilesRoomsApi.md#gettagsinfo) | **GET** /api/2.0/files/tags | Get tags |
| [**GetTemplateCreatingStatus**](FilesRoomsApi.md#gettemplatecreatingstatus) | **GET** /api/2.0/files/roomtemplate/status | Get progress creating room template |
| [**IsPublic**](FilesRoomsApi.md#ispublic) | **GET** /api/2.0/files/roomtemplate/{id}/public | Get public |
| [**PinRoom**](FilesRoomsApi.md#pinroom) | **PUT** /api/2.0/files/rooms/{id}/pin | Pin a room |
| [**Reorder**](FilesRoomsApi.md#reorder) | **PUT** /api/2.0/files/rooms/{id}/reorder | Reorders to a room with ID specified in the request |
| [**ResendEmailInvitations**](FilesRoomsApi.md#resendemailinvitations) | **POST** /api/2.0/files/rooms/{id}/resend | Resend room invitations |
| [**SetLink**](FilesRoomsApi.md#setlink) | **PUT** /api/2.0/files/rooms/{id}/links | Set an external or invitation link |
| [**SetPublic**](FilesRoomsApi.md#setpublic) | **PUT** /api/2.0/files/roomtemplate/public | Set public |
| [**SetRoomSecurity**](FilesRoomsApi.md#setroomsecurity) | **PUT** /api/2.0/files/rooms/{id}/share | Set room access rights |
| [**StartRoomIndexExport**](FilesRoomsApi.md#startroomindexexport) | **POST** /api/2.0/files/rooms/{id}/indexexport | Starts room index export |
| [**TerminateRoomIndexExport**](FilesRoomsApi.md#terminateroomindexexport) | **DELETE** /api/2.0/files/rooms/indexexport | Terminates room index export |
| [**UnarchiveRoom**](FilesRoomsApi.md#unarchiveroom) | **PUT** /api/2.0/files/rooms/{id}/unarchive | Unarchive a room |
| [**UnpinRoom**](FilesRoomsApi.md#unpinroom) | **PUT** /api/2.0/files/rooms/{id}/unpin | Unpin a room |
| [**UpdateRoom**](FilesRoomsApi.md#updateroom) | **PUT** /api/2.0/files/rooms/{id} | Rename a room |
| [**UploadRoomLogo**](FilesRoomsApi.md#uploadroomlogo) | **POST** /api/2.0/files/logos | Upload an image for room logo |

<a id="addtags"></a>
# **AddTags**
> FolderIntegerWrapper AddTags (int id, BatchTagsRequestDto? batchTagsRequestDto = null)

Add room tags

Adds the tags to a room with the ID specified in the request.

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
    public class AddTagsExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id
            var batchTagsRequestDto = new BatchTagsRequestDto?(); // BatchTagsRequestDto? | Batch tags (optional) 

            try
            {
                // Add room tags
                FolderIntegerWrapper result = apiInstance.AddTags(id, batchTagsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.AddTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add room tags
    ApiResponse<FolderIntegerWrapper> response = apiInstance.AddTagsWithHttpInfo(id, batchTagsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.AddTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |
| **batchTagsRequestDto** | [**BatchTagsRequestDto?**](BatchTagsRequestDto?.md) | Batch tags | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Archive a room

Moves a room with the ID specified in the request to the \"Archive\" section.

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
    public class ArchiveRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var archiveRoomRequest = new ArchiveRoomRequest?(); // ArchiveRoomRequest? | Parameters for archiving a room (optional) 

            try
            {
                // Archive a room
                FileOperationWrapper result = apiInstance.ArchiveRoom(id, archiveRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.ArchiveRoom: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.ArchiveRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **archiveRoomRequest** | [**ArchiveRoomRequest?**](ArchiveRoomRequest?.md) | Parameters for archiving a room | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Changes room cover

Changes room cover

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
    public class ChangeRoomCoverExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var coverRequestDto = new CoverRequestDto?(); // CoverRequestDto? | Parameters to change the room cover (optional) 

            try
            {
                // Changes room cover
                FolderIntegerWrapper result = apiInstance.ChangeRoomCover(id, coverRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.ChangeRoomCover: " + e.Message);
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
    // Changes room cover
    ApiResponse<FolderIntegerWrapper> response = apiInstance.ChangeRoomCoverWithHttpInfo(id, coverRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.ChangeRoomCoverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **coverRequestDto** | [**CoverRequestDto?**](CoverRequestDto?.md) | Parameters to change the room cover | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Create a room

Creates a room in the \"Rooms\" section.

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
    public class CreateRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var createRoomRequestDto = new CreateRoomRequestDto?(); // CreateRoomRequestDto? |  (optional) 

            try
            {
                // Create a room
                FolderIntegerWrapper result = apiInstance.CreateRoom(createRoomRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.CreateRoom: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.CreateRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRoomRequestDto** | [**CreateRoomRequestDto?**](CreateRoomRequestDto?.md) |  | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Start create a room based on a template

Start create a room in the \"Rooms\" section based on a template.

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
    public class CreateRoomFromTemplateExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var createRoomFromTemplateDto = new CreateRoomFromTemplateDto?(); // CreateRoomFromTemplateDto? |  (optional) 

            try
            {
                // Start create a room based on a template
                RoomFromTemplateStatusWrapper result = apiInstance.CreateRoomFromTemplate(createRoomFromTemplateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.CreateRoomFromTemplate: " + e.Message);
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
    // Start create a room based on a template
    ApiResponse<RoomFromTemplateStatusWrapper> response = apiInstance.CreateRoomFromTemplateWithHttpInfo(createRoomFromTemplateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.CreateRoomFromTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRoomFromTemplateDto** | [**CreateRoomFromTemplateDto?**](CreateRoomFromTemplateDto?.md) |  | [optional]  |

### Return type

[**RoomFromTemplateStatusWrapper**](RoomFromTemplateStatusWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Create a room logo

Creates a logo for a room with the ID specified in the request.

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
    public class CreateRoomLogoExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id
            var logoRequest = new LogoRequest?(); // LogoRequest? | Logo (optional) 

            try
            {
                // Create a room logo
                FolderIntegerWrapper result = apiInstance.CreateRoomLogo(id, logoRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.CreateRoomLogo: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.CreateRoomLogoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |
| **logoRequest** | [**LogoRequest?**](LogoRequest?.md) | Logo | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

<a id="createroomthirdparty"></a>
# **CreateRoomThirdParty**
> FolderStringWrapper CreateRoomThirdParty (string id, CreateThirdPartyRoom? createThirdPartyRoom = null)

Create a third-party room

Creates a room in the \"Rooms\" section stored in a third-party storage.

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
    public class CreateRoomThirdPartyExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // string | ID of the folder in the third-party storage in which the contents of the room will be stored
            var createThirdPartyRoom = new CreateThirdPartyRoom?(); // CreateThirdPartyRoom? | ThirdParty room (optional) 

            try
            {
                // Create a third-party room
                FolderStringWrapper result = apiInstance.CreateRoomThirdParty(id, createThirdPartyRoom);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.CreateRoomThirdParty: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.CreateRoomThirdPartyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | ID of the folder in the third-party storage in which the contents of the room will be stored |  |
| **createThirdPartyRoom** | [**CreateThirdPartyRoom?**](CreateThirdPartyRoom?.md) | ThirdParty room | [optional]  |

### Return type

[**FolderStringWrapper**](FolderStringWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtag"></a>
# **CreateTag**
> ObjectWrapper CreateTag (CreateTagRequestDto? createTagRequestDto = null)

Create a tag

Creates a custom tag with the parameters specified in the request.

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
    public class CreateTagExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var createTagRequestDto = new CreateTagRequestDto?(); // CreateTagRequestDto? |  (optional) 

            try
            {
                // Create a tag
                ObjectWrapper result = apiInstance.CreateTag(createTagRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.CreateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a tag
    ApiResponse<ObjectWrapper> response = apiInstance.CreateTagWithHttpInfo(createTagRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.CreateTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTagRequestDto** | [**CreateTagRequestDto?**](CreateTagRequestDto?.md) |  | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

<a id="createtemplate"></a>
# **CreateTemplate**
> RoomTemplateStatusWrapper CreateTemplate (RoomTemplateDto? roomTemplateDto = null)

Start create room template

Start create room template

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
    public class CreateTemplateExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var roomTemplateDto = new RoomTemplateDto?(); // RoomTemplateDto? |  (optional) 

            try
            {
                // Start create room template
                RoomTemplateStatusWrapper result = apiInstance.CreateTemplate(roomTemplateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.CreateTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start create room template
    ApiResponse<RoomTemplateStatusWrapper> response = apiInstance.CreateTemplateWithHttpInfo(roomTemplateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.CreateTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomTemplateDto** | [**RoomTemplateDto?**](RoomTemplateDto?.md) |  | [optional]  |

### Return type

[**RoomTemplateStatusWrapper**](RoomTemplateStatusWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Status |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomtags"></a>
# **DeleteCustomTags**
> void DeleteCustomTags (BatchTagsRequestDto? batchTagsRequestDto = null)

Delete tags

Deletes a bunch of custom tags specified in the request.

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
    public class DeleteCustomTagsExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var batchTagsRequestDto = new BatchTagsRequestDto?(); // BatchTagsRequestDto? |  (optional) 

            try
            {
                // Delete tags
                apiInstance.DeleteCustomTags(batchTagsRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.DeleteCustomTags: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.DeleteCustomTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchTagsRequestDto** | [**BatchTagsRequestDto?**](BatchTagsRequestDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Remove a room

Removes a room with the ID specified in the request.

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
    public class DeleteRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var deleteRoomRequest = new DeleteRoomRequest?(); // DeleteRoomRequest? | Parameters for deleting a room (optional) 

            try
            {
                // Remove a room
                FileOperationWrapper result = apiInstance.DeleteRoom(id, deleteRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.DeleteRoom: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.DeleteRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **deleteRoomRequest** | [**DeleteRoomRequest?**](DeleteRoomRequest?.md) | Parameters for deleting a room | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Remove a room logo

Removes a logo from a room with the ID specified in the request.

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
    public class DeleteRoomLogoExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Remove a room logo
                FolderIntegerWrapper result = apiInstance.DeleteRoomLogo(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.DeleteRoomLogo: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.DeleteRoomLogoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetags"></a>
# **DeleteTags**
> FolderIntegerWrapper DeleteTags (int id, BatchTagsRequestDto? batchTagsRequestDto = null)

Remove room tags

Removes the tags from a room with the ID specified in the request.

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
    public class DeleteTagsExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id
            var batchTagsRequestDto = new BatchTagsRequestDto?(); // BatchTagsRequestDto? | Batch tags (optional) 

            try
            {
                // Remove room tags
                FolderIntegerWrapper result = apiInstance.DeleteTags(id, batchTagsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.DeleteTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove room tags
    ApiResponse<FolderIntegerWrapper> response = apiInstance.DeleteTagsWithHttpInfo(id, batchTagsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.DeleteTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |
| **batchTagsRequestDto** | [**BatchTagsRequestDto?**](BatchTagsRequestDto?.md) | Batch tags | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

<a id="getcovers"></a>
# **GetCovers**
> CoversResultArrayWrapper GetCovers ()

Gets covers

Gets covers

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
    public class GetCoversExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Gets covers
                CoversResultArrayWrapper result = apiInstance.GetCovers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetCovers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCoversWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets covers
    ApiResponse<CoversResultArrayWrapper> response = apiInstance.GetCoversWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetCoversWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CoversResultArrayWrapper**](CoversResultArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gets room cover |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnewroomitems"></a>
# **GetNewRoomItems**
> NewItemsFileEntryArrayWrapper GetNewRoomItems (int id)

Get new room items

Returns a list of all the new items from a room with the ID specified in the request.

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
    public class GetNewRoomItemsExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Get new room items
                NewItemsFileEntryArrayWrapper result = apiInstance.GetNewRoomItems(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetNewRoomItems: " + e.Message);
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
    // Get new room items
    ApiResponse<NewItemsFileEntryArrayWrapper> response = apiInstance.GetNewRoomItemsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetNewRoomItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**NewItemsFileEntryArrayWrapper**](NewItemsFileEntryArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of file entry information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomcreatingstatus"></a>
# **GetRoomCreatingStatus**
> RoomFromTemplateStatusWrapper GetRoomCreatingStatus ()

Get progress creating room

Get progress creating room based a template

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
    public class GetRoomCreatingStatusExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get progress creating room
                RoomFromTemplateStatusWrapper result = apiInstance.GetRoomCreatingStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomCreatingStatus: " + e.Message);
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
    // Get progress creating room
    ApiResponse<RoomFromTemplateStatusWrapper> response = apiInstance.GetRoomCreatingStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomCreatingStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RoomFromTemplateStatusWrapper**](RoomFromTemplateStatusWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Gets room index export

Gets room index export

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
    public class GetRoomIndexExportExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Gets room index export
                DocumentBuilderTaskWrapper result = apiInstance.GetRoomIndexExport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomIndexExport: " + e.Message);
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
    // Gets room index export
    ApiResponse<DocumentBuilderTaskWrapper> response = apiInstance.GetRoomIndexExportWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomIndexExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DocumentBuilderTaskWrapper**](DocumentBuilderTaskWrapper.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroominfo"></a>
# **GetRoomInfo**
> FolderIntegerWrapper GetRoomInfo (int id)

Get room information

Returns the room information.

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
    public class GetRoomInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Get room information
                FolderIntegerWrapper result = apiInstance.GetRoomInfo(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomInfo: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

No authorization required

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

Get room links

Returns the links of a room with the ID specified in the request.

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
    public class GetRoomLinksExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var type = new LinkType?(); // LinkType? | Link type (optional) 

            try
            {
                // Get room links
                FileShareArrayWrapper result = apiInstance.GetRoomLinks(id, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomLinks: " + e.Message);
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
    // Get room links
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetRoomLinksWithHttpInfo(id, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomLinksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **type** | [**LinkType?**](LinkType?.md) | Link type | [optional]  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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
> FileShareArrayWrapper GetRoomSecurityInfo (int id, ShareFilterType? filterType = null)

Get room access rights

Returns the access rights of a room with the ID specified in the request.

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
    public class GetRoomSecurityInfoExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var filterType = new ShareFilterType?(); // ShareFilterType? | Share filter type (optional) 

            try
            {
                // Get room access rights
                FileShareArrayWrapper result = apiInstance.GetRoomSecurityInfo(id, filterType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomSecurityInfo: " + e.Message);
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
    // Get room access rights
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetRoomSecurityInfoWithHttpInfo(id, filterType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomSecurityInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **filterType** | [**ShareFilterType?**](ShareFilterType?.md) | Share filter type | [optional]  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Security information of room files |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomsfolder"></a>
# **GetRoomsFolder**
> FolderContentIntegerWrapper GetRoomsFolder (List<RoomType>? type = null, string? subjectId = null, SearchArea? searchArea = null, bool? withoutTags = null, string? tags = null, bool? excludeSubject = null, ProviderFilter? provider = null, SubjectFilter? subjectFilter = null, QuotaFilter? quotaFilter = null, StorageFilter? storageFilter = null)

Get rooms

Returns the contents of the \"Rooms\" section by the parameters specified in the request.

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
    public class GetRoomsFolderExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var type = new List<RoomType>?(); // List<RoomType>? | Filter by room type (optional) 
            var subjectId = some text;  // string? | Filter by user ID (optional) 
            var searchArea = new SearchArea?(); // SearchArea? | Room search area (Active, Archive, Any, Recent by links) (optional) 
            var withoutTags = true;  // bool? | Specifies whether to search by tags or not (optional) 
            var tags = some text;  // string? | Tags in the serialized format (optional) 
            var excludeSubject = true;  // bool? | Specifies whether to exclude a subject or not (optional) 
            var provider = new ProviderFilter?(); // ProviderFilter? | Filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage) (optional) 
            var subjectFilter = new SubjectFilter?(); // SubjectFilter? | Filter by subject (Owner - 0, Member - 1) (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | Filter by quota (All - 0, Default - 1, Custom - 2) (optional) 
            var storageFilter = new StorageFilter?(); // StorageFilter? | Filter by storage (None - 0, Internal - 1, ThirdParty - 2) (optional) 

            try
            {
                // Get rooms
                FolderContentIntegerWrapper result = apiInstance.GetRoomsFolder(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomsFolder: " + e.Message);
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
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetRoomsFolderWithHttpInfo(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomsFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | [**List&lt;RoomType&gt;?**](RoomType.md) | Filter by room type | [optional]  |
| **subjectId** | **string?** | Filter by user ID | [optional]  |
| **searchArea** | [**SearchArea?**](SearchArea?.md) | Room search area (Active, Archive, Any, Recent by links) | [optional]  |
| **withoutTags** | **bool?** | Specifies whether to search by tags or not | [optional]  |
| **tags** | **string?** | Tags in the serialized format | [optional]  |
| **excludeSubject** | **bool?** | Specifies whether to exclude a subject or not | [optional]  |
| **provider** | [**ProviderFilter?**](ProviderFilter?.md) | Filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage) | [optional]  |
| **subjectFilter** | [**SubjectFilter?**](SubjectFilter?.md) | Filter by subject (Owner - 0, Member - 1) | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter?.md) | Filter by quota (All - 0, Default - 1, Custom - 2) | [optional]  |
| **storageFilter** | [**StorageFilter?**](StorageFilter?.md) | Filter by storage (None - 0, Internal - 1, ThirdParty - 2) | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Gets room new items

Gets room new items

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
    public class GetRoomsNewItemsExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Gets room new items
                NewItemsRoomNewItemsArrayWrapper result = apiInstance.GetRoomsNewItems();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomsNewItems: " + e.Message);
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
    // Gets room new items
    ApiResponse<NewItemsRoomNewItemsArrayWrapper> response = apiInstance.GetRoomsNewItemsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomsNewItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**NewItemsRoomNewItemsArrayWrapper**](NewItemsRoomNewItemsArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Get primary external link

Returns the primary external link of a room with the ID specified in the request.

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
    public class GetRoomsPrimaryExternalLinkExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Get primary external link
                FileShareWrapper result = apiInstance.GetRoomsPrimaryExternalLink(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetRoomsPrimaryExternalLink: " + e.Message);
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
    // Get primary external link
    ApiResponse<FileShareWrapper> response = apiInstance.GetRoomsPrimaryExternalLinkWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetRoomsPrimaryExternalLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

<a id="gettagsinfo"></a>
# **GetTagsInfo**
> ObjectArrayWrapper GetTagsInfo ()

Get tags

Returns a list of custom tags.

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
    public class GetTagsInfoExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get tags
                ObjectArrayWrapper result = apiInstance.GetTagsInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetTagsInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTagsInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get tags
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetTagsInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetTagsInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tag names |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettemplatecreatingstatus"></a>
# **GetTemplateCreatingStatus**
> RoomTemplateStatusWrapper GetTemplateCreatingStatus ()

Get progress creating room template

Get progress creating room template

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
    public class GetTemplateCreatingStatusExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get progress creating room template
                RoomTemplateStatusWrapper result = apiInstance.GetTemplateCreatingStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.GetTemplateCreatingStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemplateCreatingStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get progress creating room template
    ApiResponse<RoomTemplateStatusWrapper> response = apiInstance.GetTemplateCreatingStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.GetTemplateCreatingStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RoomTemplateStatusWrapper**](RoomTemplateStatusWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Status |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ispublic"></a>
# **IsPublic**
> BooleanWrapper IsPublic (int id)

Get public

Get public settings

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
    public class IsPublicExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Template id

            try
            {
                // Get public
                BooleanWrapper result = apiInstance.IsPublic(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.IsPublic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsPublicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get public
    ApiResponse<BooleanWrapper> response = apiInstance.IsPublicWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.IsPublicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Template id |  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pinroom"></a>
# **PinRoom**
> FolderIntegerWrapper PinRoom (int id)

Pin a room

Pins a room with the ID specified in the request to the top of the list.

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
    public class PinRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Pin a room
                FolderIntegerWrapper result = apiInstance.PinRoom(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.PinRoom: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.PinRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reorder"></a>
# **Reorder**
> FolderIntegerWrapper Reorder (int id)

Reorders to a room with ID specified in the request

Reorders to a room with ID specified in the request

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
    public class ReorderExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Reorders to a room with ID specified in the request
                FolderIntegerWrapper result = apiInstance.Reorder(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.Reorder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReorderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reorders to a room with ID specified in the request
    ApiResponse<FolderIntegerWrapper> response = apiInstance.ReorderWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.ReorderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Resend room invitations

Resends the email invitations to a room with the ID specified in the request to the selected users.

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
    public class ResendEmailInvitationsExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id
            var userInvitation = new UserInvitation?(); // UserInvitation? | User invitation (optional) 

            try
            {
                // Resend room invitations
                apiInstance.ResendEmailInvitations(id, userInvitation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.ResendEmailInvitations: " + e.Message);
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
    // Resend room invitations
    apiInstance.ResendEmailInvitationsWithHttpInfo(id, userInvitation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.ResendEmailInvitationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |
| **userInvitation** | [**UserInvitation?**](UserInvitation?.md) | User invitation | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setlink"></a>
# **SetLink**
> FileShareWrapper SetLink (int id, RoomLinkRequest? roomLinkRequest = null)

Set an external or invitation link

Sets an external or invitation link with the ID specified in the request.

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
    public class SetLinkExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var roomLinkRequest = new RoomLinkRequest?(); // RoomLinkRequest? | Room link (optional) 

            try
            {
                // Set an external or invitation link
                FileShareWrapper result = apiInstance.SetLink(id, roomLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.SetLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set an external or invitation link
    ApiResponse<FileShareWrapper> response = apiInstance.SetLinkWithHttpInfo(id, roomLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.SetLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **roomLinkRequest** | [**RoomLinkRequest?**](RoomLinkRequest?.md) | Room link | [optional]  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Room security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpublic"></a>
# **SetPublic**
> void SetPublic (SetPublicDto? setPublicDto = null)

Set public

Set public settings

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
    public class SetPublicExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var setPublicDto = new SetPublicDto?(); // SetPublicDto? |  (optional) 

            try
            {
                // Set public
                apiInstance.SetPublic(setPublicDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.SetPublic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPublicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set public
    apiInstance.SetPublicWithHttpInfo(setPublicDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.SetPublicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setPublicDto** | [**SetPublicDto?**](SetPublicDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setroomsecurity"></a>
# **SetRoomSecurity**
> RoomSecurityWrapper SetRoomSecurity (int id, RoomInvitationRequest? roomInvitationRequest = null)

Set room access rights

Sets the access rights to a room with the ID specified in the request.

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
    public class SetRoomSecurityExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var roomInvitationRequest = new RoomInvitationRequest?(); // RoomInvitationRequest? | Room invitation (optional) 

            try
            {
                // Set room access rights
                RoomSecurityWrapper result = apiInstance.SetRoomSecurity(id, roomInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.SetRoomSecurity: " + e.Message);
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
    // Set room access rights
    ApiResponse<RoomSecurityWrapper> response = apiInstance.SetRoomSecurityWithHttpInfo(id, roomInvitationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.SetRoomSecurityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **roomInvitationRequest** | [**RoomInvitationRequest?**](RoomInvitationRequest?.md) | Room invitation | [optional]  |

### Return type

[**RoomSecurityWrapper**](RoomSecurityWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Starts room index export

Starts room index export

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
    public class StartRoomIndexExportExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Starts room index export
                DocumentBuilderTaskWrapper result = apiInstance.StartRoomIndexExport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.StartRoomIndexExport: " + e.Message);
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
    // Starts room index export
    ApiResponse<DocumentBuilderTaskWrapper> response = apiInstance.StartRoomIndexExportWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.StartRoomIndexExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**DocumentBuilderTaskWrapper**](DocumentBuilderTaskWrapper.md)

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
| **501** | Folder indexing is turned off |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="terminateroomindexexport"></a>
# **TerminateRoomIndexExport**
> void TerminateRoomIndexExport ()

Terminates room index export

Terminates room index export

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
    public class TerminateRoomIndexExportExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);

            try
            {
                // Terminates room index export
                apiInstance.TerminateRoomIndexExport();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.TerminateRoomIndexExport: " + e.Message);
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
    // Terminates room index export
    apiInstance.TerminateRoomIndexExportWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.TerminateRoomIndexExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unarchiveroom"></a>
# **UnarchiveRoom**
> FileOperationWrapper UnarchiveRoom (int id, ArchiveRoomRequest? archiveRoomRequest = null)

Unarchive a room

Moves a room with the ID specified in the request from the \"Archive\" section to the \"Rooms\" section.

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
    public class UnarchiveRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var archiveRoomRequest = new ArchiveRoomRequest?(); // ArchiveRoomRequest? | Parameters for archiving a room (optional) 

            try
            {
                // Unarchive a room
                FileOperationWrapper result = apiInstance.UnarchiveRoom(id, archiveRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.UnarchiveRoom: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.UnarchiveRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **archiveRoomRequest** | [**ArchiveRoomRequest?**](ArchiveRoomRequest?.md) | Parameters for archiving a room | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Unpin a room

Unpins a room with the ID specified in the request from the top of the list.

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
    public class UnpinRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room Id

            try
            {
                // Unpin a room
                FolderIntegerWrapper result = apiInstance.UnpinRoom(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.UnpinRoom: " + e.Message);
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
    Debug.Print("Exception when calling FilesRoomsApi.UnpinRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room Id |  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Rename a room

Renames a room with the ID specified in  the request.

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
    public class UpdateRoomExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Room ID
            var updateRoomRequest = new UpdateRoomRequest?(); // UpdateRoomRequest? | Update room (optional) 

            try
            {
                // Rename a room
                FolderIntegerWrapper result = apiInstance.UpdateRoom(id, updateRoomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.UpdateRoom: " + e.Message);
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
    // Rename a room
    ApiResponse<FolderIntegerWrapper> response = apiInstance.UpdateRoomWithHttpInfo(id, updateRoomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.UpdateRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Room ID |  |
| **updateRoomRequest** | [**UpdateRoomRequest?**](UpdateRoomRequest?.md) | Update room | [optional]  |

### Return type

[**FolderIntegerWrapper**](FolderIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Upload an image for room logo

Uploads a temporary image to create a room logo.

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
    public class UploadRoomLogoExample
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
            var apiInstance = new FilesRoomsApi(httpClient, config, httpClientHandler);
            var formCollection = new List<KeyValuePairStringStringValues>?(); // List<KeyValuePairStringStringValues>? | Image data (optional) 

            try
            {
                // Upload an image for room logo
                UploadResultWrapper result = apiInstance.UploadRoomLogo(formCollection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesRoomsApi.UploadRoomLogo: " + e.Message);
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
    // Upload an image for room logo
    ApiResponse<UploadResultWrapper> response = apiInstance.UploadRoomLogoWithHttpInfo(formCollection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesRoomsApi.UploadRoomLogoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **formCollection** | [**List&lt;KeyValuePairStringStringValues&gt;?**](KeyValuePairStringStringValues.md) | Image data | [optional]  |

### Return type

[**UploadResultWrapper**](UploadResultWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

