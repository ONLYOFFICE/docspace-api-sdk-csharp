# DocSpace.API.SDK.Api.OperationsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFavorites**](#addfavorites) | **POST** /api/2.0/files/favorites |  |
| [**BulkDownload**](#bulkdownload) | **PUT** /api/2.0/files/fileops/bulkdownload |  |
| [**CheckConversionStatus**](#checkconversionstatus) | **GET** /api/2.0/files/file/{fileId}/checkconversion |  |
| [**CheckMoveOrCopyBatchItems**](#checkmoveorcopybatchitems) | **GET** /api/2.0/files/fileops/move |  |
| [**CheckMoveOrCopyDestFolder**](#checkmoveorcopydestfolder) | **GET** /api/2.0/files/fileops/checkdestfolder |  |
| [**CopyBatchItems**](#copybatchitems) | **PUT** /api/2.0/files/fileops/copy |  |
| [**CreateUploadSession**](#createuploadsession) | **POST** /api/2.0/files/{folderId}/upload/create_session |  |
| [**DeleteBatchItems**](#deletebatchitems) | **PUT** /api/2.0/files/fileops/delete |  |
| [**DeleteFavoritesFromBody**](#deletefavoritesfrombody) | **DELETE** /api/2.0/files/favorites |  |
| [**DeleteFileVersions**](#deletefileversions) | **PUT** /api/2.0/files/fileops/deleteversion |  |
| [**DuplicateBatchItems**](#duplicatebatchitems) | **PUT** /api/2.0/files/fileops/duplicate |  |
| [**EmptyTrash**](#emptytrash) | **PUT** /api/2.0/files/fileops/emptytrash |  |
| [**GetOperationStatuses**](#getoperationstatuses) | **GET** /api/2.0/files/fileops |  |
| [**GetOperationStatusesByType**](#getoperationstatusesbytype) | **GET** /api/2.0/files/fileops/{operationType} |  |
| [**MarkAsRead**](#markasread) | **PUT** /api/2.0/files/fileops/markasread |  |
| [**MoveBatchItems**](#movebatchitems) | **PUT** /api/2.0/files/fileops/move |  |
| [**StartFileConversion**](#startfileconversion) | **PUT** /api/2.0/files/file/{fileId}/checkconversion |  |
| [**TerminateTasks**](#terminatetasks) | **PUT** /api/2.0/files/fileops/terminate/{id} |  |
| [**UpdateFileComment**](#updatefilecomment) | **PUT** /api/2.0/files/file/{fileId}/comment |  |

<a id="addfavorites"></a>
# **AddFavorites**
> BooleanWrapper AddFavorites (BaseBatchRequestDto? baseBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-favorites/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseBatchRequestDto** | [**BaseBatchRequestDto?**](BaseBatchRequestDto.md) | The base batch request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class AddFavoritesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? | The base batch request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.AddFavorites(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.AddFavorites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFavoritesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.AddFavoritesWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.AddFavoritesWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkdownload"></a>
# **BulkDownload**
> FileOperationArrayWrapper BulkDownload (DownloadRequestDto? downloadRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **downloadRequestDto** | [**DownloadRequestDto?**](DownloadRequestDto.md) | The request parameters for downloading files. | [optional]  |

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
    public class BulkDownloadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var downloadRequestDto = new DownloadRequestDto?(); // DownloadRequestDto? | The request parameters for downloading files. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.BulkDownload(downloadRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.BulkDownload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkDownloadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.BulkDownloadWithHttpInfo(downloadRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.BulkDownloadWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to download |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkconversionstatus"></a>
# **CheckConversionStatus**
> ConversationResultArrayWrapper CheckConversionStatus (int fileId, bool? start = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to check conversion status. |  |
| **start** | **bool?** | Specifies whether a conversion operation is started or not. | [optional]  |

### Return type

[**ConversationResultArrayWrapper**](ConversationResultArrayWrapper.md)

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
    public class CheckConversionStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to check conversion status.
            var start = true;  // bool? | Specifies whether a conversion operation is started or not. (optional) 

            try
            {
                ConversationResultArrayWrapper result = apiInstance.CheckConversionStatus(fileId, start);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.CheckConversionStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckConversionStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConversationResultArrayWrapper> response = apiInstance.CheckConversionStatusWithHttpInfo(fileId, start);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.CheckConversionStatusWithHttpInfo: " + e.Message);
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
| **200** | Conversion result |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkmoveorcopybatchitems"></a>
# **CheckMoveOrCopyBatchItems**
> FileEntryBaseArrayWrapper CheckMoveOrCopyBatchItems (BatchRequestDto? inDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inDto** | [**BatchRequestDto?**](BatchRequestDto.md) | The request parameters for copying/moving files. | [optional]  |

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
    public class CheckMoveOrCopyBatchItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var inDto = new BatchRequestDto?(); // BatchRequestDto? | The request parameters for copying/moving files. (optional) 

            try
            {
                FileEntryBaseArrayWrapper result = apiInstance.CheckMoveOrCopyBatchItems(inDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.CheckMoveOrCopyBatchItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckMoveOrCopyBatchItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileEntryBaseArrayWrapper> response = apiInstance.CheckMoveOrCopyBatchItemsWithHttpInfo(inDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.CheckMoveOrCopyBatchItemsWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to create |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkmoveorcopydestfolder"></a>
# **CheckMoveOrCopyDestFolder**
> CheckDestFolderWrapper CheckMoveOrCopyDestFolder (BatchRequestDto? inDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inDto** | [**BatchRequestDto?**](BatchRequestDto.md) | The request parameters for copying/moving files. | [optional]  |

### Return type

[**CheckDestFolderWrapper**](CheckDestFolderWrapper.md)

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
    public class CheckMoveOrCopyDestFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var inDto = new BatchRequestDto?(); // BatchRequestDto? | The request parameters for copying/moving files. (optional) 

            try
            {
                CheckDestFolderWrapper result = apiInstance.CheckMoveOrCopyDestFolder(inDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.CheckMoveOrCopyDestFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckMoveOrCopyDestFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CheckDestFolderWrapper> response = apiInstance.CheckMoveOrCopyDestFolderWithHttpInfo(inDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.CheckMoveOrCopyDestFolderWithHttpInfo: " + e.Message);
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
| **200** | Result |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="copybatchitems"></a>
# **CopyBatchItems**
> FileOperationArrayWrapper CopyBatchItems (BatchRequestDto? batchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchRequestDto** | [**BatchRequestDto?**](BatchRequestDto.md) | The request parameters for copying/moving files. | [optional]  |

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
    public class CopyBatchItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var batchRequestDto = new BatchRequestDto?(); // BatchRequestDto? | The request parameters for copying/moving files. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.CopyBatchItems(batchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.CopyBatchItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyBatchItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.CopyBatchItemsWithHttpInfo(batchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.CopyBatchItemsWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to copy |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createuploadsession"></a>
# **CreateUploadSession**
> ObjectWrapper CreateUploadSession (int folderId, SessionRequest sessionRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID of the session. |  |
| **sessionRequest** | [**SessionRequest**](SessionRequest.md) | The session parameters. |  |

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
    public class CreateUploadSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID of the session.
            var sessionRequest = new SessionRequest(); // SessionRequest | The session parameters.

            try
            {
                ObjectWrapper result = apiInstance.CreateUploadSession(folderId, sessionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.CreateUploadSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUploadSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ObjectWrapper> response = apiInstance.CreateUploadSessionWithHttpInfo(folderId, sessionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.CreateUploadSessionWithHttpInfo: " + e.Message);
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
| **200** | Information about created session |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletebatchitems"></a>
# **DeleteBatchItems**
> FileOperationArrayWrapper DeleteBatchItems (DeleteBatchRequestDto? deleteBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteBatchRequestDto** | [**DeleteBatchRequestDto?**](DeleteBatchRequestDto.md) | The request parameters for deleting files. | [optional]  |

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
    public class DeleteBatchItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var deleteBatchRequestDto = new DeleteBatchRequestDto?(); // DeleteBatchRequestDto? | The request parameters for deleting files. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.DeleteBatchItems(deleteBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.DeleteBatchItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBatchItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.DeleteBatchItemsWithHttpInfo(deleteBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.DeleteBatchItemsWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to delete |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefavoritesfrombody"></a>
# **DeleteFavoritesFromBody**
> BooleanWrapper DeleteFavoritesFromBody (BaseBatchRequestDto? baseBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-favorites-from-body/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseBatchRequestDto** | [**BaseBatchRequestDto?**](BaseBatchRequestDto.md) | The base batch request parameters. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class DeleteFavoritesFromBodyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? | The base batch request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.DeleteFavoritesFromBody(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.DeleteFavoritesFromBody: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFavoritesFromBodyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.DeleteFavoritesFromBodyWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.DeleteFavoritesFromBodyWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the operation is successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefileversions"></a>
# **DeleteFileVersions**
> FileOperationWrapper DeleteFileVersions (DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteVersionBatchRequestDto** | [**DeleteVersionBatchRequestDto?**](DeleteVersionBatchRequestDto.md) | The request parameters for deleting file versions. | [optional]  |

### Return type

[**FileOperationWrapper**](FileOperationWrapper.md)

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
    public class DeleteFileVersionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var deleteVersionBatchRequestDto = new DeleteVersionBatchRequestDto?(); // DeleteVersionBatchRequestDto? | The request parameters for deleting file versions. (optional) 

            try
            {
                FileOperationWrapper result = apiInstance.DeleteFileVersions(deleteVersionBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.DeleteFileVersions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFileVersionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationWrapper> response = apiInstance.DeleteFileVersionsWithHttpInfo(deleteVersionBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.DeleteFileVersionsWithHttpInfo: " + e.Message);
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

<a id="duplicatebatchitems"></a>
# **DuplicateBatchItems**
> FileOperationArrayWrapper DuplicateBatchItems (DuplicateRequestDto? duplicateRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **duplicateRequestDto** | [**DuplicateRequestDto?**](DuplicateRequestDto.md) | The duplicate request parameters. | [optional]  |

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
    public class DuplicateBatchItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var duplicateRequestDto = new DuplicateRequestDto?(); // DuplicateRequestDto? | The duplicate request parameters. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.DuplicateBatchItems(duplicateRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.DuplicateBatchItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DuplicateBatchItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.DuplicateBatchItemsWithHttpInfo(duplicateRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.DuplicateBatchItemsWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to duplicate |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="emptytrash"></a>
# **EmptyTrash**
> FileOperationArrayWrapper EmptyTrash (bool? single = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **single** | **bool?** | Specifies whether to return only the current operation | [optional]  |

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
    public class EmptyTrashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var single = true;  // bool? | Specifies whether to return only the current operation (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.EmptyTrash(single);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.EmptyTrash: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EmptyTrashWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.EmptyTrashWithHttpInfo(single);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.EmptyTrashWithHttpInfo: " + e.Message);
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
| **200** | List of file operations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoperationstatuses"></a>
# **GetOperationStatuses**
> FileOperationArrayWrapper GetOperationStatuses (string? id = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string?** | The ID of the file operation. | [optional]  |

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
    public class GetOperationStatusesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // string? | The ID of the file operation. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.GetOperationStatuses(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.GetOperationStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOperationStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.GetOperationStatusesWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.GetOperationStatusesWithHttpInfo: " + e.Message);
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
| **200** | List of file operations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoperationstatusesbytype"></a>
# **GetOperationStatusesByType**
> FileOperationArrayWrapper GetOperationStatusesByType (FileOperationType operationType, string? id = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **operationType** | **FileOperationType** | Specifies the type of file operation to be retrieved. |  |
| **id** | **string?** | The ID of the file operation. | [optional]  |

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
    public class GetOperationStatusesByTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var operationType = (FileOperationType) "0";  // FileOperationType | Specifies the type of file operation to be retrieved.
            var id = 9846;  // string? | The ID of the file operation. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.GetOperationStatusesByType(operationType, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.GetOperationStatusesByType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOperationStatusesByTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.GetOperationStatusesByTypeWithHttpInfo(operationType, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.GetOperationStatusesByTypeWithHttpInfo: " + e.Message);
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
| **200** | List of file operations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="markasread"></a>
# **MarkAsRead**
> FileOperationArrayWrapper MarkAsRead (BaseBatchRequestDto? baseBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseBatchRequestDto** | [**BaseBatchRequestDto?**](BaseBatchRequestDto.md) | The base batch request parameters. | [optional]  |

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
    public class MarkAsReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? | The base batch request parameters. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.MarkAsRead(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.MarkAsRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MarkAsReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.MarkAsReadWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.MarkAsReadWithHttpInfo: " + e.Message);
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

<a id="movebatchitems"></a>
# **MoveBatchItems**
> FileOperationArrayWrapper MoveBatchItems (BatchRequestDto? batchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchRequestDto** | [**BatchRequestDto?**](BatchRequestDto.md) | The request parameters for copying/moving files. | [optional]  |

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
    public class MoveBatchItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var batchRequestDto = new BatchRequestDto?(); // BatchRequestDto? | The request parameters for copying/moving files. (optional) 

            try
            {
                FileOperationArrayWrapper result = apiInstance.MoveBatchItems(batchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.MoveBatchItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveBatchItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.MoveBatchItemsWithHttpInfo(batchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.MoveBatchItemsWithHttpInfo: " + e.Message);
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
| **403** | You don&#39;t have enough permission to move |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startfileconversion"></a>
# **StartFileConversion**
> ConversationResultArrayWrapper StartFileConversion (int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to start conversion proccess. |  |
| **checkConversionRequestDtoInteger** | [**CheckConversionRequestDtoInteger?**](CheckConversionRequestDtoInteger.md) | The parameters for checking file conversion. | [optional]  |

### Return type

[**ConversationResultArrayWrapper**](ConversationResultArrayWrapper.md)

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
    public class StartFileConversionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to start conversion proccess.
            var checkConversionRequestDtoInteger = new CheckConversionRequestDtoInteger?(); // CheckConversionRequestDtoInteger? | The parameters for checking file conversion. (optional) 

            try
            {
                ConversationResultArrayWrapper result = apiInstance.StartFileConversion(fileId, checkConversionRequestDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.StartFileConversion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartFileConversionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConversationResultArrayWrapper> response = apiInstance.StartFileConversionWithHttpInfo(fileId, checkConversionRequestDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.StartFileConversionWithHttpInfo: " + e.Message);
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
| **200** | Conversion result |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="terminatetasks"></a>
# **TerminateTasks**
> FileOperationArrayWrapper TerminateTasks (string id)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The operation ID of the request. |  |

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
    public class TerminateTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // string | The operation ID of the request.

            try
            {
                FileOperationArrayWrapper result = apiInstance.TerminateTasks(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.TerminateTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TerminateTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.TerminateTasksWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.TerminateTasksWithHttpInfo: " + e.Message);
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
| **200** | List of file operations |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefilecomment"></a>
# **UpdateFileComment**
> StringWrapper UpdateFileComment (int fileId, UpdateComment updateComment)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID where the comment is located. |  |
| **updateComment** | [**UpdateComment**](UpdateComment.md) | The parameters for updating a comment. |  |

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
    public class UpdateFileCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new OperationsApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID where the comment is located.
            var updateComment = new UpdateComment(); // UpdateComment | The parameters for updating a comment.

            try
            {
                StringWrapper result = apiInstance.UpdateFileComment(fileId, updateComment);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperationsApi.UpdateFileComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFileCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StringWrapper> response = apiInstance.UpdateFileCommentWithHttpInfo(fileId, updateComment);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperationsApi.UpdateFileCommentWithHttpInfo: " + e.Message);
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
| **200** | Updated comment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

