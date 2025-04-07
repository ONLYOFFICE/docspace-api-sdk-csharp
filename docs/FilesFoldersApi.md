# Docspace.Api.FilesFoldersApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckUpload**](FilesFoldersApi.md#checkupload) | **POST** /api/2.0/files/{folderId}/upload/check | Checks upload |
| [**CreateFolder**](FilesFoldersApi.md#createfolder) | **POST** /api/2.0/files/folder/{folderId} | Create a folder |
| [**DeleteFolder**](FilesFoldersApi.md#deletefolder) | **DELETE** /api/2.0/files/folder/{folderId} | Delete a folder |
| [**GetFilesUsedSpace**](FilesFoldersApi.md#getfilesusedspace) | **GET** /api/2.0/files/filesusedspace | Get used space of files |
| [**GetFolder**](FilesFoldersApi.md#getfolder) | **GET** /api/2.0/files/{folderId}/formfilter | Get folder form filter |
| [**GetFolderByFolderId**](FilesFoldersApi.md#getfolderbyfolderid) | **GET** /api/2.0/files/{folderId} | Get a folder by ID |
| [**GetFolderHistory**](FilesFoldersApi.md#getfolderhistory) | **GET** /api/2.0/files/folder/{folderId}/log | Get folder history |
| [**GetFolderInfo**](FilesFoldersApi.md#getfolderinfo) | **GET** /api/2.0/files/folder/{folderId} | Get folder information |
| [**GetFolderPath**](FilesFoldersApi.md#getfolderpath) | **GET** /api/2.0/files/folder/{folderId}/path | Get the folder path |
| [**GetFolderPrimaryExternalLink**](FilesFoldersApi.md#getfolderprimaryexternallink) | **GET** /api/2.0/files/folder/{id}/link | Get primary external link |
| [**GetFolders**](FilesFoldersApi.md#getfolders) | **GET** /api/2.0/files/{folderId}/subfolders | Get subfolders |
| [**GetMyFolder**](FilesFoldersApi.md#getmyfolder) | **GET** /api/2.0/files/@my | Get the \&quot;My documents\&quot; section |
| [**GetNewItems**](FilesFoldersApi.md#getnewitems) | **GET** /api/2.0/files/{folderId}/news | Get new folder items |
| [**GetPrivacyFolder**](FilesFoldersApi.md#getprivacyfolder) | **GET** /api/2.0/files/@privacy | Get the \&quot;Private Room\&quot; section |
| [**GetRootFolders**](FilesFoldersApi.md#getrootfolders) | **GET** /api/2.0/files/@root | Get filtered sections |
| [**GetTrashFolder**](FilesFoldersApi.md#gettrashfolder) | **GET** /api/2.0/files/@trash | Get the \&quot;Trash\&quot; section |
| [**InsertFile**](FilesFoldersApi.md#insertfile) | **POST** /api/2.0/files/{folderId}/insert | Insert a file |
| [**InsertFileToMyFromBody**](FilesFoldersApi.md#insertfiletomyfrombody) | **POST** /api/2.0/files/@my/insert | Insert a file to the \&quot;My documents\&quot; section |
| [**RenameFolder**](FilesFoldersApi.md#renamefolder) | **PUT** /api/2.0/files/folder/{folderId} | Rename a folder |
| [**SetFileOrder**](FilesFoldersApi.md#setfileorder) | **PUT** /api/2.0/files/folder/{folderId}/order | Sets file order in the folder with ID specified in the request |
| [**UploadFile**](FilesFoldersApi.md#uploadfile) | **POST** /api/2.0/files/{folderId}/upload | Upload a file |
| [**UploadFileToMy**](FilesFoldersApi.md#uploadfiletomy) | **POST** /api/2.0/files/@my/upload | Upload a file to the \&quot;My documents\&quot; section |

<a id="checkupload"></a>
# **CheckUpload**
> STRINGArrayWrapper CheckUpload (int folderId, CheckUploadRequest? checkUploadRequest = null)

Checks upload

Checks upload

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
    public class CheckUploadExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var checkUploadRequest = new CheckUploadRequest?(); // CheckUploadRequest? | Parameters for checking files uploading (optional) 

            try
            {
                // Checks upload
                STRINGArrayWrapper result = apiInstance.CheckUpload(folderId, checkUploadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.CheckUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checks upload
    ApiResponse<STRINGArrayWrapper> response = apiInstance.CheckUploadWithHttpInfo(folderId, checkUploadRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.CheckUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **checkUploadRequest** | [**CheckUploadRequest?**](CheckUploadRequest?.md) | Parameters for checking files uploading | [optional]  |

### Return type

[**STRINGArrayWrapper**](STRINGArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted file |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfolder"></a>
# **CreateFolder**
> FolderIntegerWrapper CreateFolder (int folderId, CreateFolder? createFolder = null)

Create a folder

Creates a new folder with the title specified in the request. The parent folder ID can be also specified.

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
    public class CreateFolderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var createFolder = new CreateFolder?(); // CreateFolder? | Folder (optional) 

            try
            {
                // Create a folder
                FolderIntegerWrapper result = apiInstance.CreateFolder(folderId, createFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.CreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a folder
    ApiResponse<FolderIntegerWrapper> response = apiInstance.CreateFolderWithHttpInfo(folderId, createFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.CreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **createFolder** | [**CreateFolder?**](CreateFolder?.md) | Folder | [optional]  |

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
| **200** | New folder parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> FileOperationArrayWrapper DeleteFolder (int folderId, DeleteFolder? deleteFolder = null)

Delete a folder

Deletes a folder with the ID specified in the request.

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
    public class DeleteFolderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var deleteFolder = new DeleteFolder?(); // DeleteFolder? | Parameters for deleting a folder (optional) 

            try
            {
                // Delete a folder
                FileOperationArrayWrapper result = apiInstance.DeleteFolder(folderId, deleteFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.DeleteFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a folder
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.DeleteFolderWithHttpInfo(folderId, deleteFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.DeleteFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **deleteFolder** | [**DeleteFolder?**](DeleteFolder?.md) | Parameters for deleting a folder | [optional]  |

### Return type

[**FileOperationArrayWrapper**](FileOperationArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of file operations |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilesusedspace"></a>
# **GetFilesUsedSpace**
> FilesStatisticsResultWrapper GetFilesUsedSpace ()

Get used space of files

Returns the used space of files in the root folders.

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
    public class GetFilesUsedSpaceExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);

            try
            {
                // Get used space of files
                FilesStatisticsResultWrapper result = apiInstance.GetFilesUsedSpace();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFilesUsedSpace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilesUsedSpaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get used space of files
    ApiResponse<FilesStatisticsResultWrapper> response = apiInstance.GetFilesUsedSpaceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFilesUsedSpaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FilesStatisticsResultWrapper**](FilesStatisticsResultWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Used space of files in the root folders |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolder"></a>
# **GetFolder**
> FormsItemArrayWrapper GetFolder (int folderId)

Get folder form filter

Get form filter of a folder with id specified in request

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
    public class GetFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID

            try
            {
                // Get folder form filter
                FormsItemArrayWrapper result = apiInstance.GetFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get folder form filter
    ApiResponse<FormsItemArrayWrapper> response = apiInstance.GetFolderWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |

### Return type

[**FormsItemArrayWrapper**](FormsItemArrayWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderbyfolderid"></a>
# **GetFolderByFolderId**
> FolderContentIntegerWrapper GetFolderByFolderId (int folderId, Guid? userIdOrGroupId = null, FilterType? filterType = null, int? roomId = null, bool? excludeSubject = null, ApplyFilterOption? applyFilterOption = null, string? extension = null, SearchArea? searchArea = null, string? formsItemKey = null, string? formsItemType = null)

Get a folder by ID

Returns the detailed list of files and folders located in the folder with the ID specified in the request.

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
    public class GetFolderByFolderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | User or group ID (optional) 
            var filterType = new FilterType?(); // FilterType? | Filter type (optional) 
            var roomId = 9846;  // int? | Room ID (optional) 
            var excludeSubject = true;  // bool? | Specifies whether to exclude a subject or not (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements from the specified folder (optional) 
            var extension = .txt;  // string? | Specifies whether to search for a specific file extension (optional) 
            var searchArea = new SearchArea?(); // SearchArea? | Search area (optional) 
            var formsItemKey = some text;  // string? |  (optional) 
            var formsItemType = some text;  // string? |  (optional) 

            try
            {
                // Get a folder by ID
                FolderContentIntegerWrapper result = apiInstance.GetFolderByFolderId(folderId, userIdOrGroupId, filterType, roomId, excludeSubject, applyFilterOption, extension, searchArea, formsItemKey, formsItemType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolderByFolderId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderByFolderIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a folder by ID
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetFolderByFolderIdWithHttpInfo(folderId, userIdOrGroupId, filterType, roomId, excludeSubject, applyFilterOption, extension, searchArea, formsItemKey, formsItemType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFolderByFolderIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **userIdOrGroupId** | **Guid?** | User or group ID | [optional]  |
| **filterType** | [**FilterType?**](FilterType?.md) | Filter type | [optional]  |
| **roomId** | **int?** | Room ID | [optional]  |
| **excludeSubject** | **bool?** | Specifies whether to exclude a subject or not | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption?.md) | Specifies whether to return only files, only folders or all elements from the specified folder | [optional]  |
| **extension** | **string?** | Specifies whether to search for a specific file extension | [optional]  |
| **searchArea** | [**SearchArea?**](SearchArea?.md) | Search area | [optional]  |
| **formsItemKey** | **string?** |  | [optional]  |
| **formsItemType** | **string?** |  | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folder contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderhistory"></a>
# **GetFolderHistory**
> HistoryArrayWrapper GetFolderHistory (int folderId, ApiDateTime? fromDate = null, ApiDateTime? toDate = null)

Get folder history

Get the activity history of a folder with a specified identifier

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
    public class GetFolderHistoryExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | File ID
            var fromDate = new ApiDateTime?(); // ApiDateTime? | Start date (optional) 
            var toDate = new ApiDateTime?(); // ApiDateTime? | End date (optional) 

            try
            {
                // Get folder history
                HistoryArrayWrapper result = apiInstance.GetFolderHistory(folderId, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolderHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get folder history
    ApiResponse<HistoryArrayWrapper> response = apiInstance.GetFolderHistoryWithHttpInfo(folderId, fromDate, toDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFolderHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | File ID |  |
| **fromDate** | [**ApiDateTime?**](ApiDateTime?.md) | Start date | [optional]  |
| **toDate** | [**ApiDateTime?**](ApiDateTime?.md) | End date | [optional]  |

### Return type

[**HistoryArrayWrapper**](HistoryArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of actions in the folder |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderinfo"></a>
# **GetFolderInfo**
> FolderIntegerWrapper GetFolderInfo (int folderId)

Get folder information

Returns the detailed information about a folder with the ID specified in the request.

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
    public class GetFolderInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID

            try
            {
                // Get folder information
                FolderIntegerWrapper result = apiInstance.GetFolderInfo(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolderInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get folder information
    ApiResponse<FolderIntegerWrapper> response = apiInstance.GetFolderInfoWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFolderInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |

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
| **200** | Folder parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderpath"></a>
# **GetFolderPath**
> FileEntryArrayWrapper GetFolderPath (int folderId)

Get the folder path

Returns a path to the folder with the ID specified in the request.

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
    public class GetFolderPathExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID

            try
            {
                // Get the folder path
                FileEntryArrayWrapper result = apiInstance.GetFolderPath(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolderPath: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderPathWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the folder path
    ApiResponse<FileEntryArrayWrapper> response = apiInstance.GetFolderPathWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFolderPathWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |

### Return type

[**FileEntryArrayWrapper**](FileEntryArrayWrapper.md)

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
| **403** | You don&#39;t have enough permission to view the folder content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderprimaryexternallink"></a>
# **GetFolderPrimaryExternalLink**
> FileShareWrapper GetFolderPrimaryExternalLink (int id)

Get primary external link

Returns the primary external link by the identifier specified in the request.

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
    public class GetFolderPrimaryExternalLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Folder Id

            try
            {
                // Get primary external link
                FileShareWrapper result = apiInstance.GetFolderPrimaryExternalLink(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolderPrimaryExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderPrimaryExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get primary external link
    ApiResponse<FileShareWrapper> response = apiInstance.GetFolderPrimaryExternalLinkWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFolderPrimaryExternalLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Folder Id |  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Folder security information |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolders"></a>
# **GetFolders**
> FileEntryArrayWrapper GetFolders (int folderId)

Get subfolders

Returns a list of all the subfolders from a folder with the ID specified in the request.

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
    public class GetFoldersExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID

            try
            {
                // Get subfolders
                FileEntryArrayWrapper result = apiInstance.GetFolders(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get subfolders
    ApiResponse<FileEntryArrayWrapper> response = apiInstance.GetFoldersWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |

### Return type

[**FileEntryArrayWrapper**](FileEntryArrayWrapper.md)

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
| **403** | You don&#39;t have enough permission to view the folder content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmyfolder"></a>
# **GetMyFolder**
> FolderContentIntegerWrapper GetMyFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, ApplyFilterOption? applyFilterOption = null)

Get the \"My documents\" section

Returns the detailed list of files and folders located in the \"My documents\" section.

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
    public class GetMyFolderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | User or group ID (optional) 
            var filterType = new FilterType?(); // FilterType? | Filter type (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements from the specified folder (optional) 

            try
            {
                // Get the \"My documents\" section
                FolderContentIntegerWrapper result = apiInstance.GetMyFolder(userIdOrGroupId, filterType, applyFilterOption);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetMyFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the \"My documents\" section
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetMyFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetMyFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | User or group ID | [optional]  |
| **filterType** | [**FilterType?**](FilterType?.md) | Filter type | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption?.md) | Specifies whether to return only files, only folders or all elements from the specified folder | [optional]  |

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
| **200** | The \&quot;My documents\&quot; section contents |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnewitems"></a>
# **GetNewItems**
> FileEntryArrayWrapper GetNewItems (int folderId)

Get new folder items

Returns a list of all the new items from a folder with the ID specified in the request.

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
    public class GetNewItemsExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID

            try
            {
                // Get new folder items
                FileEntryArrayWrapper result = apiInstance.GetNewItems(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetNewItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNewItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get new folder items
    ApiResponse<FileEntryArrayWrapper> response = apiInstance.GetNewItemsWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetNewItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |

### Return type

[**FileEntryArrayWrapper**](FileEntryArrayWrapper.md)

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
| **403** | You don&#39;t have enough permission to view the folder content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprivacyfolder"></a>
# **GetPrivacyFolder**
> FolderContentIntegerWrapper GetPrivacyFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null)

Get the \"Private Room\" section

Returns the detailed list of files and folders located in the \"Private Room\" section.

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
    public class GetPrivacyFolderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | User or group ID (optional) 
            var filterType = new FilterType?(); // FilterType? | Filter type (optional) 

            try
            {
                // Get the \"Private Room\" section
                FolderContentIntegerWrapper result = apiInstance.GetPrivacyFolder(userIdOrGroupId, filterType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetPrivacyFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrivacyFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the \"Private Room\" section
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetPrivacyFolderWithHttpInfo(userIdOrGroupId, filterType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetPrivacyFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | User or group ID | [optional]  |
| **filterType** | [**FilterType?**](FilterType?.md) | Filter type | [optional]  |

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
| **200** | The \&quot;Private Room\&quot; section contents |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrootfolders"></a>
# **GetRootFolders**
> FolderContentIntegerArrayWrapper GetRootFolders (Guid? userIdOrGroupId = null, FilterType? filterType = null, bool? withoutTrash = null)

Get filtered sections

Returns all the sections matching the parameters specified in the request.

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
    public class GetRootFoldersExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | User or group ID (optional) 
            var filterType = new FilterType?(); // FilterType? | Filter type (optional) 
            var withoutTrash = true;  // bool? | Specifies whether to return the \"Trash\" section or not (optional) 

            try
            {
                // Get filtered sections
                FolderContentIntegerArrayWrapper result = apiInstance.GetRootFolders(userIdOrGroupId, filterType, withoutTrash);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetRootFolders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRootFoldersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get filtered sections
    ApiResponse<FolderContentIntegerArrayWrapper> response = apiInstance.GetRootFoldersWithHttpInfo(userIdOrGroupId, filterType, withoutTrash);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetRootFoldersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | User or group ID | [optional]  |
| **filterType** | [**FilterType?**](FilterType?.md) | Filter type | [optional]  |
| **withoutTrash** | **bool?** | Specifies whether to return the \&quot;Trash\&quot; section or not | [optional]  |

### Return type

[**FolderContentIntegerArrayWrapper**](FolderContentIntegerArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of section contents with the following parameters |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettrashfolder"></a>
# **GetTrashFolder**
> FolderContentIntegerWrapper GetTrashFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, ApplyFilterOption? applyFilterOption = null)

Get the \"Trash\" section

Returns the detailed list of files and folders located in the \"Trash\" section.

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
    public class GetTrashFolderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | User or group ID (optional) 
            var filterType = new FilterType?(); // FilterType? | Filter type (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements from the specified folder (optional) 

            try
            {
                // Get the \"Trash\" section
                FolderContentIntegerWrapper result = apiInstance.GetTrashFolder(userIdOrGroupId, filterType, applyFilterOption);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.GetTrashFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTrashFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the \"Trash\" section
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetTrashFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.GetTrashFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | User or group ID | [optional]  |
| **filterType** | [**FilterType?**](FilterType?.md) | Filter type | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption?.md) | Specifies whether to return only files, only folders or all elements from the specified folder | [optional]  |

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
| **200** | The \&quot;Trash\&quot; section contents |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="insertfile"></a>
# **InsertFile**
> FileIntegerWrapper InsertFile (int folderId, FileParameter? insertFileFile = null, string? insertFileTitle = null, bool? insertFileCreateNewIfExist = null, bool? insertFileKeepConvertStatus = null, bool? insertFileStreamCanRead = null, bool? insertFileStreamCanWrite = null, bool? insertFileStreamCanSeek = null, bool? insertFileStreamCanTimeout = null, long? insertFileStreamLength = null, long? insertFileStreamPosition = null, int? insertFileStreamReadTimeout = null, int? insertFileStreamWriteTimeout = null)

Insert a file

Inserts a file specified in the request to the selected folder by single file uploading.

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
    public class InsertFileExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var insertFileFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | File (optional) 
            var insertFileTitle = "insertFileTitle_example";  // string? | File name (optional) 
            var insertFileCreateNewIfExist = true;  // bool? | Specifies whether to create a new file if it already exists or not (optional) 
            var insertFileKeepConvertStatus = true;  // bool? | Specifies whether to keep the file converting status or not (optional) 
            var insertFileStreamCanRead = true;  // bool? |  (optional) 
            var insertFileStreamCanWrite = true;  // bool? |  (optional) 
            var insertFileStreamCanSeek = true;  // bool? |  (optional) 
            var insertFileStreamCanTimeout = true;  // bool? |  (optional) 
            var insertFileStreamLength = 789L;  // long? |  (optional) 
            var insertFileStreamPosition = 789L;  // long? |  (optional) 
            var insertFileStreamReadTimeout = 56;  // int? |  (optional) 
            var insertFileStreamWriteTimeout = 56;  // int? |  (optional) 

            try
            {
                // Insert a file
                FileIntegerWrapper result = apiInstance.InsertFile(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.InsertFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InsertFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Insert a file
    ApiResponse<FileIntegerWrapper> response = apiInstance.InsertFileWithHttpInfo(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.InsertFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **insertFileFile** | **FileParameter?****FileParameter?** | File | [optional]  |
| **insertFileTitle** | **string?** | File name | [optional]  |
| **insertFileCreateNewIfExist** | **bool?** | Specifies whether to create a new file if it already exists or not | [optional]  |
| **insertFileKeepConvertStatus** | **bool?** | Specifies whether to keep the file converting status or not | [optional]  |
| **insertFileStreamCanRead** | **bool?** |  | [optional]  |
| **insertFileStreamCanWrite** | **bool?** |  | [optional]  |
| **insertFileStreamCanSeek** | **bool?** |  | [optional]  |
| **insertFileStreamCanTimeout** | **bool?** |  | [optional]  |
| **insertFileStreamLength** | **long?** |  | [optional]  |
| **insertFileStreamPosition** | **long?** |  | [optional]  |
| **insertFileStreamReadTimeout** | **int?** |  | [optional]  |
| **insertFileStreamWriteTimeout** | **int?** |  | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted file |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | Folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="insertfiletomyfrombody"></a>
# **InsertFileToMyFromBody**
> FileIntegerWrapper InsertFileToMyFromBody (FileParameter? file = null, string? title = null, bool? createNewIfExist = null, bool? keepConvertStatus = null, bool? streamCanRead = null, bool? streamCanWrite = null, bool? streamCanSeek = null, bool? streamCanTimeout = null, long? streamLength = null, long? streamPosition = null, int? streamReadTimeout = null, int? streamWriteTimeout = null)

Insert a file to the \"My documents\" section

Inserts a file specified in the request to the \"My documents\" section by single file uploading.

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
    public class InsertFileToMyFromBodyExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | File (optional) 
            var title = "title_example";  // string? | File name (optional) 
            var createNewIfExist = true;  // bool? | Specifies whether to create a new file if it already exists or not (optional) 
            var keepConvertStatus = true;  // bool? | Specifies whether to keep the file converting status or not (optional) 
            var streamCanRead = true;  // bool? |  (optional) 
            var streamCanWrite = true;  // bool? |  (optional) 
            var streamCanSeek = true;  // bool? |  (optional) 
            var streamCanTimeout = true;  // bool? |  (optional) 
            var streamLength = 789L;  // long? |  (optional) 
            var streamPosition = 789L;  // long? |  (optional) 
            var streamReadTimeout = 56;  // int? |  (optional) 
            var streamWriteTimeout = 56;  // int? |  (optional) 

            try
            {
                // Insert a file to the \"My documents\" section
                FileIntegerWrapper result = apiInstance.InsertFileToMyFromBody(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.InsertFileToMyFromBody: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InsertFileToMyFromBodyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Insert a file to the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.InsertFileToMyFromBodyWithHttpInfo(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.InsertFileToMyFromBodyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **FileParameter?****FileParameter?** | File | [optional]  |
| **title** | **string?** | File name | [optional]  |
| **createNewIfExist** | **bool?** | Specifies whether to create a new file if it already exists or not | [optional]  |
| **keepConvertStatus** | **bool?** | Specifies whether to keep the file converting status or not | [optional]  |
| **streamCanRead** | **bool?** |  | [optional]  |
| **streamCanWrite** | **bool?** |  | [optional]  |
| **streamCanSeek** | **bool?** |  | [optional]  |
| **streamCanTimeout** | **bool?** |  | [optional]  |
| **streamLength** | **long?** |  | [optional]  |
| **streamPosition** | **long?** |  | [optional]  |
| **streamReadTimeout** | **int?** |  | [optional]  |
| **streamWriteTimeout** | **int?** |  | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Inserted file |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | Folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="renamefolder"></a>
# **RenameFolder**
> FolderIntegerWrapper RenameFolder (int folderId, CreateFolder? createFolder = null)

Rename a folder

Renames the selected folder with a new title specified in the request.

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
    public class RenameFolderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var createFolder = new CreateFolder?(); // CreateFolder? | Folder (optional) 

            try
            {
                // Rename a folder
                FolderIntegerWrapper result = apiInstance.RenameFolder(folderId, createFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.RenameFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenameFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename a folder
    ApiResponse<FolderIntegerWrapper> response = apiInstance.RenameFolderWithHttpInfo(folderId, createFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.RenameFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **createFolder** | [**CreateFolder?**](CreateFolder?.md) | Folder | [optional]  |

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
| **200** | Folder parameters |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to rename the folder |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfileorder"></a>
# **SetFileOrder**
> void SetFileOrder (int folderId, OrderRequestDto? orderRequestDto = null)

Sets file order in the folder with ID specified in the request

Sets file order in the folder with ID specified in the request

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
    public class SetFileOrderExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The unique identifier of the folder
            var orderRequestDto = new OrderRequestDto?(); // OrderRequestDto? | Order information for the folder (optional) 

            try
            {
                // Sets file order in the folder with ID specified in the request
                apiInstance.SetFileOrder(folderId, orderRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.SetFileOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFileOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets file order in the folder with ID specified in the request
    apiInstance.SetFileOrderWithHttpInfo(folderId, orderRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.SetFileOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The unique identifier of the folder |  |
| **orderRequestDto** | [**OrderRequestDto?**](OrderRequestDto?.md) | Order information for the folder | [optional]  |

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

<a id="uploadfile"></a>
# **UploadFile**
> ObjectWrapper UploadFile (int folderId, UploadRequestDto? uploadRequestDto = null)

Upload a file

Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   <ol>  <li>Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.</li>  <li>Using standart multipart/form-data method.</li>  </ol>

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
    public class UploadFileExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var uploadRequestDto = new UploadRequestDto?(); // UploadRequestDto? | Upload data (optional) 

            try
            {
                // Upload a file
                ObjectWrapper result = apiInstance.UploadFile(folderId, uploadRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.UploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a file
    ApiResponse<ObjectWrapper> response = apiInstance.UploadFileWithHttpInfo(folderId, uploadRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.UploadFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | Folder ID |  |
| **uploadRequestDto** | [**UploadRequestDto?**](UploadRequestDto?.md) | Upload data | [optional]  |

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
| **200** | Inserted file |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | Folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadfiletomy"></a>
# **UploadFileToMy**
> ObjectWrapper UploadFileToMy (UploadRequestDto? inDto = null)

Upload a file to the \"My documents\" section

Uploads a file specified in the request to the \"My documents\" section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   <ol>  <li>Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.</li>  <li>Using standart multipart/form-data method.</li>  </ol>

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
    public class UploadFileToMyExample
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
            var apiInstance = new FilesFoldersApi(httpClient, config, httpClientHandler);
            var inDto = new UploadRequestDto?(); // UploadRequestDto? | Request parameters for uploading a file (optional) 

            try
            {
                // Upload a file to the \"My documents\" section
                ObjectWrapper result = apiInstance.UploadFileToMy(inDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFoldersApi.UploadFileToMy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileToMyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a file to the \"My documents\" section
    ApiResponse<ObjectWrapper> response = apiInstance.UploadFileToMyWithHttpInfo(inDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFoldersApi.UploadFileToMyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inDto** | [**UploadRequestDto?**](UploadRequestDto?.md) | Request parameters for uploading a file | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Uploaded file(s) |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | File not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

