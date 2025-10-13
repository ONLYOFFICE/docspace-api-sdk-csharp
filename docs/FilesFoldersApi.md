# DocSpace.API.SDK.Api.FoldersApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckUpload**](#checkupload) | **POST** /api/2.0/files/{folderId}/upload/check |  |
| [**CreateFolder**](#createfolder) | **POST** /api/2.0/files/folder/{folderId} |  |
| [**CreateFolderPrimaryExternalLink**](#createfolderprimaryexternallink) | **POST** /api/2.0/files/folder/{id}/link |  |
| [**CreateReportFolderHistory**](#createreportfolderhistory) | **POST** /api/2.0/files/folder/{folderId}/log/report |  |
| [**DeleteFolder**](#deletefolder) | **DELETE** /api/2.0/files/folder/{folderId} |  |
| [**GetFavoritesFolder**](#getfavoritesfolder) | **GET** /api/2.0/files/@favorites |  |
| [**GetFilesUsedSpace**](#getfilesusedspace) | **GET** /api/2.0/files/filesusedspace |  |
| [**GetFolder**](#getfolder) | **GET** /api/2.0/files/{folderId}/formfilter |  |
| [**GetFolderByFolderId**](#getfolderbyfolderid) | **GET** /api/2.0/files/{folderId} |  |
| [**GetFolderHistory**](#getfolderhistory) | **GET** /api/2.0/files/folder/{folderId}/log |  |
| [**GetFolderInfo**](#getfolderinfo) | **GET** /api/2.0/files/folder/{folderId} |  |
| [**GetFolderLinks**](#getfolderlinks) | **GET** /api/2.0/files/folder/{id}/links |  |
| [**GetFolderPath**](#getfolderpath) | **GET** /api/2.0/files/folder/{folderId}/path |  |
| [**GetFolderPrimaryExternalLink**](#getfolderprimaryexternallink) | **GET** /api/2.0/files/folder/{id}/link |  |
| [**GetFolders**](#getfolders) | **GET** /api/2.0/files/{folderId}/subfolders |  |
| [**GetMyFolder**](#getmyfolder) | **GET** /api/2.0/files/@my |  |
| [**GetNewFolderItems**](#getnewfolderitems) | **GET** /api/2.0/files/{folderId}/news |  |
| [**GetPrivacyFolder**](#getprivacyfolder) | **GET** /api/2.0/files/@privacy |  |
| [**GetRecentFolder**](#getrecentfolder) | **GET** /api/2.0/files/@recent |  |
| [**GetRootFolders**](#getrootfolders) | **GET** /api/2.0/files/@root |  |
| [**GetTrashFolder**](#gettrashfolder) | **GET** /api/2.0/files/@trash |  |
| [**InsertFile**](#insertfile) | **POST** /api/2.0/files/{folderId}/insert |  |
| [**InsertFileToMyFromBody**](#insertfiletomyfrombody) | **POST** /api/2.0/files/@my/insert |  |
| [**RenameFolder**](#renamefolder) | **PUT** /api/2.0/files/folder/{folderId} |  |
| [**SetFolderOrder**](#setfolderorder) | **PUT** /api/2.0/files/folder/{folderId}/order |  |
| [**SetFolderPrimaryExternalLink**](#setfolderprimaryexternallink) | **PUT** /api/2.0/files/folder/{id}/links |  |
| [**UploadFile**](#uploadfile) | **POST** /api/2.0/files/{folderId}/upload |  |
| [**UploadFileToMy**](#uploadfiletomy) | **POST** /api/2.0/files/@my/upload |  |

<a id="checkupload"></a>
# **CheckUpload**
> STRINGArrayWrapper CheckUpload (int folderId, CheckUploadRequest checkUploadRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID. |  |
| **checkUploadRequest** | [**CheckUploadRequest**](CheckUploadRequest.md) | The request parameters for checking file uploads. |  |

### Return type

[**STRINGArrayWrapper**](STRINGArrayWrapper.md)

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
    public class CheckUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID.
            var checkUploadRequest = new CheckUploadRequest(); // CheckUploadRequest | The request parameters for checking file uploads.

            try
            {
                STRINGArrayWrapper result = apiInstance.CheckUpload(folderId, checkUploadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.CheckUpload: " + e.Message);
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
    ApiResponse<STRINGArrayWrapper> response = apiInstance.CheckUploadWithHttpInfo(folderId, checkUploadRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.CheckUploadWithHttpInfo: " + e.Message);
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
| **200** | Inserted file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfolder"></a>
# **CreateFolder**
> FolderIntegerWrapper CreateFolder (int folderId, CreateFolder createFolder)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID for the folder creation. |  |
| **createFolder** | [**CreateFolder**](CreateFolder.md) | The parameters for creating a folder. |  |

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
    public class CreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID for the folder creation.
            var createFolder = new CreateFolder(); // CreateFolder | The parameters for creating a folder.

            try
            {
                FolderIntegerWrapper result = apiInstance.CreateFolder(folderId, createFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.CreateFolder: " + e.Message);
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
    ApiResponse<FolderIntegerWrapper> response = apiInstance.CreateFolderWithHttpInfo(folderId, createFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.CreateFolderWithHttpInfo: " + e.Message);
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
| **200** | New folder parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfolderprimaryexternallink"></a>
# **CreateFolderPrimaryExternalLink**
> FileShareWrapper CreateFolderPrimaryExternalLink (int id, FolderLinkRequest folderLinkRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder-primary-external-link/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The folder ID. |  |
| **folderLinkRequest** | [**FolderLinkRequest**](FolderLinkRequest.md) | The folder link parameters. |  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

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
    public class CreateFolderPrimaryExternalLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The folder ID.
            var folderLinkRequest = new FolderLinkRequest(); // FolderLinkRequest | The folder link parameters.

            try
            {
                FileShareWrapper result = apiInstance.CreateFolderPrimaryExternalLink(id, folderLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.CreateFolderPrimaryExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFolderPrimaryExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareWrapper> response = apiInstance.CreateFolderPrimaryExternalLinkWithHttpInfo(id, folderLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.CreateFolderPrimaryExternalLinkWithHttpInfo: " + e.Message);
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
| **200** | Folders security information |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createreportfolderhistory"></a>
# **CreateReportFolderHistory**
> StringWrapper CreateReportFolderHistory (int folderId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-report-folder-history/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** |  |  |

### Return type

[**StringWrapper**](StringWrapper.md)

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
    public class CreateReportFolderHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 56;  // int | 

            try
            {
                StringWrapper result = apiInstance.CreateReportFolderHistory(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.CreateReportFolderHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReportFolderHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StringWrapper> response = apiInstance.CreateReportFolderHistoryWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.CreateReportFolderHistoryWithHttpInfo: " + e.Message);
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
| **200** | URL to the report file |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefolder"></a>
# **DeleteFolder**
> FileOperationArrayWrapper DeleteFolder (int folderId, DeleteFolder deleteFolder)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID to delete. |  |
| **deleteFolder** | [**DeleteFolder**](DeleteFolder.md) | The parameters for deleting a folder. |  |

### Return type

[**FileOperationArrayWrapper**](FileOperationArrayWrapper.md)

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
    public class DeleteFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID to delete.
            var deleteFolder = new DeleteFolder(); // DeleteFolder | The parameters for deleting a folder.

            try
            {
                FileOperationArrayWrapper result = apiInstance.DeleteFolder(folderId, deleteFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.DeleteFolder: " + e.Message);
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
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.DeleteFolderWithHttpInfo(folderId, deleteFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.DeleteFolderWithHttpInfo: " + e.Message);
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
| **200** | List of file operations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfavoritesfolder"></a>
# **GetFavoritesFolder**
> FolderContentIntegerWrapper GetFavoritesFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-favorites-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **count** | **int?** | The maximum number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first item to retrieve in a paginated list. | [optional]  |
| **sortBy** | **string?** | Specifies the field by which the folder content should be sorted. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text used as a filter or search criterion for folder content queries. | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetFavoritesFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var count = 1234;  // int? | The maximum number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first item to retrieve in a paginated list. (optional) 
            var sortBy = some text;  // string? | Specifies the field by which the folder content should be sorted. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text used as a filter or search criterion for folder content queries. (optional) 

            try
            {
                FolderContentIntegerWrapper result = apiInstance.GetFavoritesFolder(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFavoritesFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFavoritesFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetFavoritesFolderWithHttpInfo(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFavoritesFolderWithHttpInfo: " + e.Message);
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
| **200** | The Favorites section contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilesusedspace"></a>
# **GetFilesUsedSpace**
> FilesStatisticsResultWrapper GetFilesUsedSpace ()



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**FilesStatisticsResultWrapper**](FilesStatisticsResultWrapper.md)

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
    public class GetFilesUsedSpaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);

            try
            {
                FilesStatisticsResultWrapper result = apiInstance.GetFilesUsedSpace();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFilesUsedSpace: " + e.Message);
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
    ApiResponse<FilesStatisticsResultWrapper> response = apiInstance.GetFilesUsedSpaceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFilesUsedSpaceWithHttpInfo: " + e.Message);
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
| **200** | Used space of files in the root folders |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolder"></a>
# **GetFolder**
> FormsItemArrayWrapper GetFolder (int folderId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The request folder ID. |  |

### Return type

[**FormsItemArrayWrapper**](FormsItemArrayWrapper.md)

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
    public class GetFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The request folder ID.

            try
            {
                FormsItemArrayWrapper result = apiInstance.GetFolder(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolder: " + e.Message);
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
    ApiResponse<FormsItemArrayWrapper> response = apiInstance.GetFolderWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderbyfolderid"></a>
# **GetFolderByFolderId**
> FolderContentIntegerWrapper GetFolderByFolderId (int folderId, Guid? userIdOrGroupId = null, FilterType? filterType = null, int? roomId = null, bool? excludeSubject = null, ApplyFilterOption? applyFilterOption = null, string? extension = null, SearchArea? searchArea = null, string? formsItemKey = null, string? formsItemType = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null, Location? location = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID of the request. |  |
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **roomId** | **int?** | The room ID. | [optional]  |
| **excludeSubject** | **bool?** | Specifies whether to exclude search by user or group ID. | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption.md) | Specifies whether to return only files, only folders or all elements from the specified folder. | [optional]  |
| **extension** | **string?** | Specifies whether to search for the specific file extension. | [optional]  |
| **searchArea** | [**SearchArea?**](SearchArea.md) | The search area. | [optional]  |
| **formsItemKey** | **string?** | The forms item key. | [optional]  |
| **formsItemType** | **string?** | The forms item type. | [optional]  |
| **count** | **int?** | The maximum number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first item to retrieve in a paginated request. | [optional]  |
| **sortBy** | **string?** | Specifies the property used for sorting the folder request results. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text value used as a filter parameter for folder content queries. | [optional]  |
| **location** | [**Location?**](Location.md) | Represents the location context of the request, specifying the area  where the operation is performed, such as a room, documents, or a link. | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetFolderByFolderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID of the request.
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var roomId = 9846;  // int? | The room ID. (optional) 
            var excludeSubject = true;  // bool? | Specifies whether to exclude search by user or group ID. (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements from the specified folder. (optional) 
            var extension = .txt;  // string? | Specifies whether to search for the specific file extension. (optional) 
            var searchArea = new SearchArea?(); // SearchArea? | The search area. (optional) 
            var formsItemKey = some text;  // string? | The forms item key. (optional) 
            var formsItemType = some text;  // string? | The forms item type. (optional) 
            var count = 1234;  // int? | The maximum number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first item to retrieve in a paginated request. (optional) 
            var sortBy = some text;  // string? | Specifies the property used for sorting the folder request results. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text value used as a filter parameter for folder content queries. (optional) 
            var location = new Location?(); // Location? | Represents the location context of the request, specifying the area  where the operation is performed, such as a room, documents, or a link. (optional) 

            try
            {
                FolderContentIntegerWrapper result = apiInstance.GetFolderByFolderId(folderId, userIdOrGroupId, filterType, roomId, excludeSubject, applyFilterOption, extension, searchArea, formsItemKey, formsItemType, count, startIndex, sortBy, sortOrder, filterValue, location);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderByFolderId: " + e.Message);
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
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetFolderByFolderIdWithHttpInfo(folderId, userIdOrGroupId, filterType, roomId, excludeSubject, applyFilterOption, extension, searchArea, formsItemKey, formsItemType, count, startIndex, sortBy, sortOrder, filterValue, location);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderByFolderIdWithHttpInfo: " + e.Message);
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
| **200** | Folder contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderhistory"></a>
# **GetFolderHistory**
> HistoryArrayWrapper GetFolderHistory (int folderId, ApiDateTime? fromDate = null, ApiDateTime? toDate = null, int? count = null, int? startIndex = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID of the history request. |  |
| **fromDate** | [**ApiDateTime?**](ApiDateTime.md) | The start date of the history request. | [optional]  |
| **toDate** | [**ApiDateTime?**](ApiDateTime.md) | The end date of the history request. | [optional]  |
| **count** | **int?** | The number of records to retrieve for the folder history. | [optional]  |
| **startIndex** | **int?** | The starting index from which the history records are retrieved in the request. | [optional]  |

### Return type

[**HistoryArrayWrapper**](HistoryArrayWrapper.md)

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
    public class GetFolderHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID of the history request.
            var fromDate = new ApiDateTime?(); // ApiDateTime? | The start date of the history request. (optional) 
            var toDate = new ApiDateTime?(); // ApiDateTime? | The end date of the history request. (optional) 
            var count = 1234;  // int? | The number of records to retrieve for the folder history. (optional) 
            var startIndex = 1234;  // int? | The starting index from which the history records are retrieved in the request. (optional) 

            try
            {
                HistoryArrayWrapper result = apiInstance.GetFolderHistory(folderId, fromDate, toDate, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderHistory: " + e.Message);
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
    ApiResponse<HistoryArrayWrapper> response = apiInstance.GetFolderHistoryWithHttpInfo(folderId, fromDate, toDate, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderHistoryWithHttpInfo: " + e.Message);
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
| **200** | List of actions in the folder |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderinfo"></a>
# **GetFolderInfo**
> FolderIntegerWrapper GetFolderInfo (int folderId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The request folder ID. |  |

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
    public class GetFolderInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The request folder ID.

            try
            {
                FolderIntegerWrapper result = apiInstance.GetFolderInfo(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderInfo: " + e.Message);
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
    ApiResponse<FolderIntegerWrapper> response = apiInstance.GetFolderInfoWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderInfoWithHttpInfo: " + e.Message);
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
| **200** | Folder parameters |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderlinks"></a>
# **GetFolderLinks**
> FileShareArrayWrapper GetFolderLinks (int id)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-links/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The folder ID. |  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

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
    public class GetFolderLinksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The folder ID.

            try
            {
                FileShareArrayWrapper result = apiInstance.GetFolderLinks(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderLinks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderLinksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetFolderLinksWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderLinksWithHttpInfo: " + e.Message);
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
| **200** | Folder security information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderpath"></a>
# **GetFolderPath**
> FileEntryBaseArrayWrapper GetFolderPath (int folderId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The request folder ID. |  |

### Return type

[**FileEntryBaseArrayWrapper**](FileEntryBaseArrayWrapper.md)

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
    public class GetFolderPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The request folder ID.

            try
            {
                FileEntryBaseArrayWrapper result = apiInstance.GetFolderPath(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderPath: " + e.Message);
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
    ApiResponse<FileEntryBaseArrayWrapper> response = apiInstance.GetFolderPathWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderPathWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to view the folder content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolderprimaryexternallink"></a>
# **GetFolderPrimaryExternalLink**
> FileShareWrapper GetFolderPrimaryExternalLink (int id, int? count = null, int? startIndex = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The request folder ID. |  |
| **count** | **int?** | The number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

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
    public class GetFolderPrimaryExternalLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The request folder ID.
            var count = 1234;  // int? | The number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 

            try
            {
                FileShareWrapper result = apiInstance.GetFolderPrimaryExternalLink(id, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderPrimaryExternalLink: " + e.Message);
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
    ApiResponse<FileShareWrapper> response = apiInstance.GetFolderPrimaryExternalLinkWithHttpInfo(id, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFolderPrimaryExternalLinkWithHttpInfo: " + e.Message);
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
| **200** | Folder security information |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfolders"></a>
# **GetFolders**
> FileEntryBaseArrayWrapper GetFolders (int folderId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The request folder ID. |  |

### Return type

[**FileEntryBaseArrayWrapper**](FileEntryBaseArrayWrapper.md)

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
    public class GetFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The request folder ID.

            try
            {
                FileEntryBaseArrayWrapper result = apiInstance.GetFolders(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolders: " + e.Message);
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
    ApiResponse<FileEntryBaseArrayWrapper> response = apiInstance.GetFoldersWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetFoldersWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to view the folder content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmyfolder"></a>
# **GetMyFolder**
> FolderContentIntegerWrapper GetMyFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, ApplyFilterOption? applyFilterOption = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption.md) | Specifies whether to return only files, only folders or all elements. | [optional]  |
| **count** | **int?** | The maximum number of items to retrieve in the response. | [optional]  |
| **startIndex** | **int?** | The starting position of the items to be retrieved. | [optional]  |
| **sortBy** | **string?** | The property used to specify the sorting criteria for folder contents. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text used for filtering or searching folder contents. | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetMyFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements. (optional) 
            var count = 1234;  // int? | The maximum number of items to retrieve in the response. (optional) 
            var startIndex = 1234;  // int? | The starting position of the items to be retrieved. (optional) 
            var sortBy = some text;  // string? | The property used to specify the sorting criteria for folder contents. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text used for filtering or searching folder contents. (optional) 

            try
            {
                FolderContentIntegerWrapper result = apiInstance.GetMyFolder(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetMyFolder: " + e.Message);
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
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetMyFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetMyFolderWithHttpInfo: " + e.Message);
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
| **200** | The My documents section contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnewfolderitems"></a>
# **GetNewFolderItems**
> FileEntryBaseArrayWrapper GetNewFolderItems (int folderId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The request folder ID. |  |

### Return type

[**FileEntryBaseArrayWrapper**](FileEntryBaseArrayWrapper.md)

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
    public class GetNewFolderItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The request folder ID.

            try
            {
                FileEntryBaseArrayWrapper result = apiInstance.GetNewFolderItems(folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetNewFolderItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNewFolderItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileEntryBaseArrayWrapper> response = apiInstance.GetNewFolderItemsWithHttpInfo(folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetNewFolderItemsWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to view the folder content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprivacyfolder"></a>
# **GetPrivacyFolder**
> FolderContentIntegerWrapper GetPrivacyFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **count** | **int?** | The maximum number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first item to retrieve in a paginated list. | [optional]  |
| **sortBy** | **string?** | Specifies the field by which the folder content should be sorted. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text used as a filter or search criterion for folder content queries. | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetPrivacyFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var count = 1234;  // int? | The maximum number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first item to retrieve in a paginated list. (optional) 
            var sortBy = some text;  // string? | Specifies the field by which the folder content should be sorted. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text used as a filter or search criterion for folder content queries. (optional) 

            try
            {
                FolderContentIntegerWrapper result = apiInstance.GetPrivacyFolder(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetPrivacyFolder: " + e.Message);
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
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetPrivacyFolderWithHttpInfo(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetPrivacyFolderWithHttpInfo: " + e.Message);
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
| **200** | The Private Room section contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecentfolder"></a>
# **GetRecentFolder**
> FolderContentIntegerWrapper GetRecentFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, bool? excludeSubject = null, ApplyFilterOption? applyFilterOption = null, SearchArea? searchArea = null, List<string>? extension = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-recent-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **excludeSubject** | **bool?** | Specifies whether to exclude search by user or group ID. | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption.md) | Specifies whether to return only files, only folders or all elements. | [optional]  |
| **searchArea** | [**SearchArea?**](SearchArea.md) | The search area. | [optional]  |
| **extension** | [**List&lt;string&gt;?**](string.md) | Specifies whether to search for a specific file extension in the Recent folder. | [optional]  |
| **count** | **int?** | The maximum number of items to return. | [optional]  |
| **startIndex** | **int?** | The starting position of the results to be returned in the query response. | [optional]  |
| **sortBy** | **string?** | Specifies the sorting criteria for the folder request. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text used for filtering or searching folder contents. | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetRecentFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var excludeSubject = true;  // bool? | Specifies whether to exclude search by user or group ID. (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements. (optional) 
            var searchArea = new SearchArea?(); // SearchArea? | The search area. (optional) 
            var extension = new List<string>?(); // List<string>? | Specifies whether to search for a specific file extension in the Recent folder. (optional) 
            var count = 1234;  // int? | The maximum number of items to return. (optional) 
            var startIndex = 1234;  // int? | The starting position of the results to be returned in the query response. (optional) 
            var sortBy = some text;  // string? | Specifies the sorting criteria for the folder request. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text used for filtering or searching folder contents. (optional) 

            try
            {
                FolderContentIntegerWrapper result = apiInstance.GetRecentFolder(userIdOrGroupId, filterType, excludeSubject, applyFilterOption, searchArea, extension, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetRecentFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecentFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetRecentFolderWithHttpInfo(userIdOrGroupId, filterType, excludeSubject, applyFilterOption, searchArea, extension, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetRecentFolderWithHttpInfo: " + e.Message);
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
| **200** | The Recent section contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrootfolders"></a>
# **GetRootFolders**
> FolderContentIntegerArrayWrapper GetRootFolders (Guid? userIdOrGroupId = null, FilterType? filterType = null, bool? withoutTrash = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **withoutTrash** | **bool?** | Specifies whether to return the Trash section or not. | [optional]  |
| **count** | **int?** | The maximum number of items to retrieve in the response. | [optional]  |
| **startIndex** | **int?** | The starting position of the items to be retrieved. | [optional]  |
| **sortBy** | **string?** | Specifies the field by which the folder content should be sorted. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text used as a filter for searching or retrieving folder contents. | [optional]  |

### Return type

[**FolderContentIntegerArrayWrapper**](FolderContentIntegerArrayWrapper.md)

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
    public class GetRootFoldersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var withoutTrash = true;  // bool? | Specifies whether to return the Trash section or not. (optional) 
            var count = 1234;  // int? | The maximum number of items to retrieve in the response. (optional) 
            var startIndex = 1234;  // int? | The starting position of the items to be retrieved. (optional) 
            var sortBy = some text;  // string? | Specifies the field by which the folder content should be sorted. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text used as a filter for searching or retrieving folder contents. (optional) 

            try
            {
                FolderContentIntegerArrayWrapper result = apiInstance.GetRootFolders(userIdOrGroupId, filterType, withoutTrash, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetRootFolders: " + e.Message);
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
    ApiResponse<FolderContentIntegerArrayWrapper> response = apiInstance.GetRootFoldersWithHttpInfo(userIdOrGroupId, filterType, withoutTrash, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetRootFoldersWithHttpInfo: " + e.Message);
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
| **200** | List of section contents with the following parameters |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettrashfolder"></a>
# **GetTrashFolder**
> FolderContentIntegerWrapper GetTrashFolder (Guid? userIdOrGroupId = null, FilterType? filterType = null, ApplyFilterOption? applyFilterOption = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdOrGroupId** | **Guid?** | The user or group ID. | [optional]  |
| **filterType** | [**FilterType?**](FilterType.md) | The filter type. | [optional]  |
| **applyFilterOption** | [**ApplyFilterOption?**](ApplyFilterOption.md) | Specifies whether to return only files, only folders or all elements. | [optional]  |
| **count** | **int?** | The maximum number of items to retrieve in the response. | [optional]  |
| **startIndex** | **int?** | The starting position of the items to be retrieved. | [optional]  |
| **sortBy** | **string?** | The property used to specify the sorting criteria for folder contents. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterValue** | **string?** | The text used for filtering or searching folder contents. | [optional]  |

### Return type

[**FolderContentIntegerWrapper**](FolderContentIntegerWrapper.md)

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
    public class GetTrashFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var userIdOrGroupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The user or group ID. (optional) 
            var filterType = new FilterType?(); // FilterType? | The filter type. (optional) 
            var applyFilterOption = new ApplyFilterOption?(); // ApplyFilterOption? | Specifies whether to return only files, only folders or all elements. (optional) 
            var count = 1234;  // int? | The maximum number of items to retrieve in the response. (optional) 
            var startIndex = 1234;  // int? | The starting position of the items to be retrieved. (optional) 
            var sortBy = some text;  // string? | The property used to specify the sorting criteria for folder contents. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterValue = some text;  // string? | The text used for filtering or searching folder contents. (optional) 

            try
            {
                FolderContentIntegerWrapper result = apiInstance.GetTrashFolder(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.GetTrashFolder: " + e.Message);
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
    ApiResponse<FolderContentIntegerWrapper> response = apiInstance.GetTrashFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.GetTrashFolderWithHttpInfo: " + e.Message);
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
| **200** | The Trash section contents |  -  |
| **403** | You don&#39;t have enough permission to view the folder content |  -  |
| **404** | The required folder was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="insertfile"></a>
# **InsertFile**
> FileIntegerWrapper InsertFile (int folderId, FileParameter? insertFileFile = null, string? insertFileTitle = null, bool? insertFileCreateNewIfExist = null, bool? insertFileKeepConvertStatus = null, bool? insertFileStreamCanRead = null, bool? insertFileStreamCanWrite = null, bool? insertFileStreamCanSeek = null, bool? insertFileStreamCanTimeout = null, long? insertFileStreamLength = null, long? insertFileStreamPosition = null, int? insertFileStreamReadTimeout = null, int? insertFileStreamWriteTimeout = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID for inserting a file. |  |
| **insertFileFile** | **FileParameter?****FileParameter?** | The file to be inserted. | [optional]  |
| **insertFileTitle** | **string?** | The file title to be inserted. | [optional]  |
| **insertFileCreateNewIfExist** | **bool?** | Specifies whether to create a new file if it already exists or not. | [optional]  |
| **insertFileKeepConvertStatus** | **bool?** | Specifies whether to keep the file converting status or not. | [optional]  |
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
    public class InsertFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID for inserting a file.
            var insertFileFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | The file to be inserted. (optional) 
            var insertFileTitle = "insertFileTitle_example";  // string? | The file title to be inserted. (optional) 
            var insertFileCreateNewIfExist = true;  // bool? | Specifies whether to create a new file if it already exists or not. (optional) 
            var insertFileKeepConvertStatus = true;  // bool? | Specifies whether to keep the file converting status or not. (optional) 
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
                FileIntegerWrapper result = apiInstance.InsertFile(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.InsertFile: " + e.Message);
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
    ApiResponse<FileIntegerWrapper> response = apiInstance.InsertFileWithHttpInfo(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.InsertFileWithHttpInfo: " + e.Message);
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
| **200** | Inserted file |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | Folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="insertfiletomyfrombody"></a>
# **InsertFileToMyFromBody**
> FileIntegerWrapper InsertFileToMyFromBody (FileParameter? file = null, string? title = null, bool? createNewIfExist = null, bool? keepConvertStatus = null, bool? streamCanRead = null, bool? streamCanWrite = null, bool? streamCanSeek = null, bool? streamCanTimeout = null, long? streamLength = null, long? streamPosition = null, int? streamReadTimeout = null, int? streamWriteTimeout = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **FileParameter?****FileParameter?** | The file to be inserted. | [optional]  |
| **title** | **string?** | The file title to be inserted. | [optional]  |
| **createNewIfExist** | **bool?** | Specifies whether to create a new file if it already exists or not. | [optional]  |
| **keepConvertStatus** | **bool?** | Specifies whether to keep the file converting status or not. | [optional]  |
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
    public class InsertFileToMyFromBodyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | The file to be inserted. (optional) 
            var title = "title_example";  // string? | The file title to be inserted. (optional) 
            var createNewIfExist = true;  // bool? | Specifies whether to create a new file if it already exists or not. (optional) 
            var keepConvertStatus = true;  // bool? | Specifies whether to keep the file converting status or not. (optional) 
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
                FileIntegerWrapper result = apiInstance.InsertFileToMyFromBody(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.InsertFileToMyFromBody: " + e.Message);
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
    ApiResponse<FileIntegerWrapper> response = apiInstance.InsertFileToMyFromBodyWithHttpInfo(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.InsertFileToMyFromBodyWithHttpInfo: " + e.Message);
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
| **200** | Inserted file |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | Folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="renamefolder"></a>
# **RenameFolder**
> FolderIntegerWrapper RenameFolder (int folderId, CreateFolder createFolder)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID for the folder creation. |  |
| **createFolder** | [**CreateFolder**](CreateFolder.md) | The parameters for creating a folder. |  |

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
    public class RenameFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID for the folder creation.
            var createFolder = new CreateFolder(); // CreateFolder | The parameters for creating a folder.

            try
            {
                FolderIntegerWrapper result = apiInstance.RenameFolder(folderId, createFolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.RenameFolder: " + e.Message);
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
    ApiResponse<FolderIntegerWrapper> response = apiInstance.RenameFolderWithHttpInfo(folderId, createFolder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.RenameFolderWithHttpInfo: " + e.Message);
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
| **200** | Folder parameters |  -  |
| **403** | You don&#39;t have enough permission to rename the folder |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfolderorder"></a>
# **SetFolderOrder**
> FolderIntegerWrapper SetFolderOrder (int folderId, OrderRequestDto? orderRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder unique identifier. |  |
| **orderRequestDto** | [**OrderRequestDto?**](OrderRequestDto.md) | The folder order information. | [optional]  |

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
    public class SetFolderOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder unique identifier.
            var orderRequestDto = new OrderRequestDto?(); // OrderRequestDto? | The folder order information. (optional) 

            try
            {
                FolderIntegerWrapper result = apiInstance.SetFolderOrder(folderId, orderRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.SetFolderOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFolderOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FolderIntegerWrapper> response = apiInstance.SetFolderOrderWithHttpInfo(folderId, orderRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.SetFolderOrderWithHttpInfo: " + e.Message);
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
| **200** | List of file operations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfolderprimaryexternallink"></a>
# **SetFolderPrimaryExternalLink**
> FileShareWrapper SetFolderPrimaryExternalLink (int id, FolderLinkRequest folderLinkRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-primary-external-link/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The folder ID. |  |
| **folderLinkRequest** | [**FolderLinkRequest**](FolderLinkRequest.md) | The folder link parameters. |  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

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
    public class SetFolderPrimaryExternalLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The folder ID.
            var folderLinkRequest = new FolderLinkRequest(); // FolderLinkRequest | The folder link parameters.

            try
            {
                FileShareWrapper result = apiInstance.SetFolderPrimaryExternalLink(id, folderLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.SetFolderPrimaryExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFolderPrimaryExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareWrapper> response = apiInstance.SetFolderPrimaryExternalLinkWithHttpInfo(id, folderLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.SetFolderPrimaryExternalLinkWithHttpInfo: " + e.Message);
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
| **200** | Folder information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadfile"></a>
# **UploadFile**
> ObjectWrapper UploadFile (int folderId, UploadRequestDto? uploadRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID to upload a file. |  |
| **uploadRequestDto** | [**UploadRequestDto?**](UploadRequestDto.md) | The request parameters for uploading a file. | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

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
    public class UploadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID to upload a file.
            var uploadRequestDto = new UploadRequestDto?(); // UploadRequestDto? | The request parameters for uploading a file. (optional) 

            try
            {
                ObjectWrapper result = apiInstance.UploadFile(folderId, uploadRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.UploadFile: " + e.Message);
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
    ApiResponse<ObjectWrapper> response = apiInstance.UploadFileWithHttpInfo(folderId, uploadRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.UploadFileWithHttpInfo: " + e.Message);
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
| **200** | Inserted file |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | Folder not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadfiletomy"></a>
# **UploadFileToMy**
> ObjectWrapper UploadFileToMy (UploadRequestDto? inDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inDto** | [**UploadRequestDto?**](UploadRequestDto.md) | The request parameters for uploading a file. | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

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
    public class UploadFileToMyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FoldersApi(httpClient, config, httpClientHandler);
            var inDto = new UploadRequestDto?(); // UploadRequestDto? | The request parameters for uploading a file. (optional) 

            try
            {
                ObjectWrapper result = apiInstance.UploadFileToMy(inDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FoldersApi.UploadFileToMy: " + e.Message);
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
    ApiResponse<ObjectWrapper> response = apiInstance.UploadFileToMyWithHttpInfo(inDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FoldersApi.UploadFileToMyWithHttpInfo: " + e.Message);
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
| **200** | Uploaded file(s) |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | File not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

