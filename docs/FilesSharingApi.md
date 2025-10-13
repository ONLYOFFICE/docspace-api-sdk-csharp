# DocSpace.API.SDK.Api.SharingApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplyExternalSharePassword**](#applyexternalsharepassword) | **POST** /api/2.0/files/share/{key}/password |  |
| [**ChangeFileOwner**](#changefileowner) | **POST** /api/2.0/files/owner |  |
| [**GetExternalShareData**](#getexternalsharedata) | **GET** /api/2.0/files/share/{key} |  |
| [**GetFileSecurityInfo**](#getfilesecurityinfo) | **GET** /api/2.0/files/file/{id}/share |  |
| [**GetFolderSecurityInfo**](#getfoldersecurityinfo) | **GET** /api/2.0/files/folder/{id}/share |  |
| [**GetGroupsMembersWithFileSecurity**](#getgroupsmemberswithfilesecurity) | **GET** /api/2.0/files/file/{fileId}/group/{groupId}/share |  |
| [**GetGroupsMembersWithFolderSecurity**](#getgroupsmemberswithfoldersecurity) | **GET** /api/2.0/files/folder/{folderId}/group/{groupId}/share |  |
| [**GetSecurityInfo**](#getsecurityinfo) | **POST** /api/2.0/files/share |  |
| [**GetSharedUsers**](#getsharedusers) | **GET** /api/2.0/files/file/{fileId}/sharedusers |  |
| [**RemoveSecurityInfo**](#removesecurityinfo) | **DELETE** /api/2.0/files/share |  |
| [**SendEditorNotify**](#sendeditornotify) | **POST** /api/2.0/files/file/{fileId}/sendeditornotify |  |
| [**SetFileSecurityInfo**](#setfilesecurityinfo) | **PUT** /api/2.0/files/file/{fileId}/share |  |
| [**SetFolderSecurityInfo**](#setfoldersecurityinfo) | **PUT** /api/2.0/files/folder/{folderId}/share |  |
| [**SetSecurityInfo**](#setsecurityinfo) | **PUT** /api/2.0/files/share |  |

<a id="applyexternalsharepassword"></a>
# **ApplyExternalSharePassword**
> ExternalShareWrapper ApplyExternalSharePassword (string key, ExternalShareRequestParam externalShareRequestParam)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **key** | **string** | The unique document identifier. |  |
| **externalShareRequestParam** | [**ExternalShareRequestParam**](ExternalShareRequestParam.md) | The external data share request parameters. |  |

### Return type

[**ExternalShareWrapper**](ExternalShareWrapper.md)

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
    public class ApplyExternalSharePasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var key = some text;  // string | The unique document identifier.
            var externalShareRequestParam = new ExternalShareRequestParam(); // ExternalShareRequestParam | The external data share request parameters.

            try
            {
                ExternalShareWrapper result = apiInstance.ApplyExternalSharePassword(key, externalShareRequestParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.ApplyExternalSharePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplyExternalSharePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalShareWrapper> response = apiInstance.ApplyExternalSharePasswordWithHttpInfo(key, externalShareRequestParam);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.ApplyExternalSharePasswordWithHttpInfo: " + e.Message);
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
| **200** | External data |  -  |
| **429** | Too many requests |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changefileowner"></a>
# **ChangeFileOwner**
> FileEntryBaseArrayWrapper ChangeFileOwner (ChangeOwnerRequestDto? changeOwnerRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **changeOwnerRequestDto** | [**ChangeOwnerRequestDto?**](ChangeOwnerRequestDto.md) | The request parameters for changing the file owner. | [optional]  |

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
    public class ChangeFileOwnerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var changeOwnerRequestDto = new ChangeOwnerRequestDto?(); // ChangeOwnerRequestDto? | The request parameters for changing the file owner. (optional) 

            try
            {
                FileEntryBaseArrayWrapper result = apiInstance.ChangeFileOwner(changeOwnerRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.ChangeFileOwner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeFileOwnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileEntryBaseArrayWrapper> response = apiInstance.ChangeFileOwnerWithHttpInfo(changeOwnerRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.ChangeFileOwnerWithHttpInfo: " + e.Message);
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
| **200** | File entry information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getexternalsharedata"></a>
# **GetExternalShareData**
> ExternalShareWrapper GetExternalShareData (string key, string? fileId = null, string? folderId = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **key** | **string** | The unique key of the external shared data. |  |
| **fileId** | **string?** | The unique document identifier. | [optional]  |
| **folderId** | **string?** | The unique folder identifier. | [optional]  |

### Return type

[**ExternalShareWrapper**](ExternalShareWrapper.md)

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
    public class GetExternalShareDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var key = some text;  // string | The unique key of the external shared data.
            var fileId = 9846;  // string? | The unique document identifier. (optional) 
            var folderId = 9846;  // string? | The unique folder identifier. (optional) 

            try
            {
                ExternalShareWrapper result = apiInstance.GetExternalShareData(key, fileId, folderId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetExternalShareData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExternalShareDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ExternalShareWrapper> response = apiInstance.GetExternalShareDataWithHttpInfo(key, fileId, folderId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetExternalShareDataWithHttpInfo: " + e.Message);
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
| **200** | External data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilesecurityinfo"></a>
# **GetFileSecurityInfo**
> FileShareArrayWrapper GetFileSecurityInfo (int id, int? count = null, int? startIndex = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The file ID of the request. |  |
| **count** | **int?** | The number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |

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
    public class GetFileSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The file ID of the request.
            var count = 1234;  // int? | The number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 

            try
            {
                FileShareArrayWrapper result = apiInstance.GetFileSecurityInfo(id, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetFileSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetFileSecurityInfoWithHttpInfo(id, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetFileSecurityInfoWithHttpInfo: " + e.Message);
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
| **200** | List of shared file information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfoldersecurityinfo"></a>
# **GetFolderSecurityInfo**
> FileShareArrayWrapper GetFolderSecurityInfo (int id, int? count = null, int? startIndex = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The request folder ID. |  |
| **count** | **int?** | The number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |

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
    public class GetFolderSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The request folder ID.
            var count = 1234;  // int? | The number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 

            try
            {
                FileShareArrayWrapper result = apiInstance.GetFolderSecurityInfo(id, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetFolderSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFolderSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetFolderSecurityInfoWithHttpInfo(id, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetFolderSecurityInfoWithHttpInfo: " + e.Message);
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
| **200** | List of shared file information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroupsmemberswithfilesecurity"></a>
# **GetGroupsMembersWithFileSecurity**
> GroupMemberSecurityRequestArrayWrapper GetGroupsMembersWithFileSecurity (int fileId, Guid groupId, int? count = null, int? startIndex = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID. |  |
| **groupId** | **Guid** | The group ID. |  |
| **count** | **int?** | The number of items to be retrieved in the current query. | [optional]  |
| **startIndex** | **int?** | The starting index for the query result set. | [optional]  |
| **filterValue** | **string?** | The filter value used for searching or querying group members based on text input. | [optional]  |

### Return type

[**GroupMemberSecurityRequestArrayWrapper**](GroupMemberSecurityRequestArrayWrapper.md)

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
    public class GetGroupsMembersWithFileSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID.
            var groupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid | The group ID.
            var count = 1234;  // int? | The number of items to be retrieved in the current query. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query result set. (optional) 
            var filterValue = some text;  // string? | The filter value used for searching or querying group members based on text input. (optional) 

            try
            {
                GroupMemberSecurityRequestArrayWrapper result = apiInstance.GetGroupsMembersWithFileSecurity(fileId, groupId, count, startIndex, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetGroupsMembersWithFileSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsMembersWithFileSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupMemberSecurityRequestArrayWrapper> response = apiInstance.GetGroupsMembersWithFileSecurityWithHttpInfo(fileId, groupId, count, startIndex, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetGroupsMembersWithFileSecurityWithHttpInfo: " + e.Message);
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

<a id="getgroupsmemberswithfoldersecurity"></a>
# **GetGroupsMembersWithFolderSecurity**
> GroupMemberSecurityRequestArrayWrapper GetGroupsMembersWithFolderSecurity (int folderId, Guid groupId, int? count = null, int? startIndex = null, string? filterValue = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID. |  |
| **groupId** | **Guid** | The group ID. |  |
| **count** | **int?** | The number of items to be retrieved in the current query. | [optional]  |
| **startIndex** | **int?** | The starting index for the query result set. | [optional]  |
| **filterValue** | **string?** | The filter value used for searching or querying group members based on text input. | [optional]  |

### Return type

[**GroupMemberSecurityRequestArrayWrapper**](GroupMemberSecurityRequestArrayWrapper.md)

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
    public class GetGroupsMembersWithFolderSecurityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID.
            var groupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid | The group ID.
            var count = 1234;  // int? | The number of items to be retrieved in the current query. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query result set. (optional) 
            var filterValue = some text;  // string? | The filter value used for searching or querying group members based on text input. (optional) 

            try
            {
                GroupMemberSecurityRequestArrayWrapper result = apiInstance.GetGroupsMembersWithFolderSecurity(folderId, groupId, count, startIndex, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetGroupsMembersWithFolderSecurity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsMembersWithFolderSecurityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupMemberSecurityRequestArrayWrapper> response = apiInstance.GetGroupsMembersWithFolderSecurityWithHttpInfo(folderId, groupId, count, startIndex, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetGroupsMembersWithFolderSecurityWithHttpInfo: " + e.Message);
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

<a id="getsecurityinfo"></a>
# **GetSecurityInfo**
> FileShareArrayWrapper GetSecurityInfo (BaseBatchRequestDto? baseBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseBatchRequestDto** | [**BaseBatchRequestDto?**](BaseBatchRequestDto.md) | The base batch request parameters. | [optional]  |

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
    public class GetSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? | The base batch request parameters. (optional) 

            try
            {
                FileShareArrayWrapper result = apiInstance.GetSecurityInfo(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetSecurityInfoWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetSecurityInfoWithHttpInfo: " + e.Message);
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
| **200** | List of shared files and folders information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsharedusers"></a>
# **GetSharedUsers**
> MentionWrapperArrayWrapper GetSharedUsers (int fileId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**MentionWrapperArrayWrapper**](MentionWrapperArrayWrapper.md)

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
    public class GetSharedUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                MentionWrapperArrayWrapper result = apiInstance.GetSharedUsers(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.GetSharedUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSharedUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MentionWrapperArrayWrapper> response = apiInstance.GetSharedUsersWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.GetSharedUsersWithHttpInfo: " + e.Message);
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
| **200** | List of users with their access rights to the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removesecurityinfo"></a>
# **RemoveSecurityInfo**
> BooleanWrapper RemoveSecurityInfo (BaseBatchRequestDto? baseBatchRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/).

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
    public class RemoveSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? | The base batch request parameters. (optional) 

            try
            {
                BooleanWrapper result = apiInstance.RemoveSecurityInfo(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.RemoveSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanWrapper> response = apiInstance.RemoveSecurityInfoWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.RemoveSecurityInfoWithHttpInfo: " + e.Message);
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

<a id="sendeditornotify"></a>
# **SendEditorNotify**
> AceShortWrapperArrayWrapper SendEditorNotify (int fileId, MentionMessageWrapper? mentionMessageWrapper = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the mention message. |  |
| **mentionMessageWrapper** | [**MentionMessageWrapper?**](MentionMessageWrapper.md) | The mention message. | [optional]  |

### Return type

[**AceShortWrapperArrayWrapper**](AceShortWrapperArrayWrapper.md)

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
    public class SendEditorNotifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the mention message.
            var mentionMessageWrapper = new MentionMessageWrapper?(); // MentionMessageWrapper? | The mention message. (optional) 

            try
            {
                AceShortWrapperArrayWrapper result = apiInstance.SendEditorNotify(fileId, mentionMessageWrapper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.SendEditorNotify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendEditorNotifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AceShortWrapperArrayWrapper> response = apiInstance.SendEditorNotifyWithHttpInfo(fileId, mentionMessageWrapper);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.SendEditorNotifyWithHttpInfo: " + e.Message);
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
| **200** | List of access rights information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfilesecurityinfo"></a>
# **SetFileSecurityInfo**
> FileShareArrayWrapper SetFileSecurityInfo (int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID. |  |
| **securityInfoSimpleRequestDto** | [**SecurityInfoSimpleRequestDto**](SecurityInfoSimpleRequestDto.md) | The parameters of the security information simple request. |  |

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
    public class SetFileSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID.
            var securityInfoSimpleRequestDto = new SecurityInfoSimpleRequestDto(); // SecurityInfoSimpleRequestDto | The parameters of the security information simple request.

            try
            {
                FileShareArrayWrapper result = apiInstance.SetFileSecurityInfo(fileId, securityInfoSimpleRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.SetFileSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFileSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.SetFileSecurityInfoWithHttpInfo(fileId, securityInfoSimpleRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.SetFileSecurityInfoWithHttpInfo: " + e.Message);
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
| **200** | List of shared file information: sharing rights, a user who has the access to the specified file, the file is locked by this user or not, this user is an owner of the specified file or not, this user can edit the access to the specified file or not |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfoldersecurityinfo"></a>
# **SetFolderSecurityInfo**
> FileShareArrayWrapper SetFolderSecurityInfo (int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID. |  |
| **securityInfoSimpleRequestDto** | [**SecurityInfoSimpleRequestDto**](SecurityInfoSimpleRequestDto.md) | The parameters of the security information simple request. |  |

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
    public class SetFolderSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID.
            var securityInfoSimpleRequestDto = new SecurityInfoSimpleRequestDto(); // SecurityInfoSimpleRequestDto | The parameters of the security information simple request.

            try
            {
                FileShareArrayWrapper result = apiInstance.SetFolderSecurityInfo(folderId, securityInfoSimpleRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.SetFolderSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFolderSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.SetFolderSecurityInfoWithHttpInfo(folderId, securityInfoSimpleRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.SetFolderSecurityInfoWithHttpInfo: " + e.Message);
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
| **200** | List of shared folder information: sharing rights, a user who has the access to the specified folder, the folder is locked by this user or not, this user is an owner of the specified folder or not, this user can edit the access to the specified folder or not |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setsecurityinfo"></a>
# **SetSecurityInfo**
> FileShareArrayWrapper SetSecurityInfo (SecurityInfoRequestDto? securityInfoRequestDto = null)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **securityInfoRequestDto** | [**SecurityInfoRequestDto?**](SecurityInfoRequestDto.md) | The security information request parameters. | [optional]  |

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
    public class SetSecurityInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SharingApi(httpClient, config, httpClientHandler);
            var securityInfoRequestDto = new SecurityInfoRequestDto?(); // SecurityInfoRequestDto? | The security information request parameters. (optional) 

            try
            {
                FileShareArrayWrapper result = apiInstance.SetSecurityInfo(securityInfoRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SharingApi.SetSecurityInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetSecurityInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FileShareArrayWrapper> response = apiInstance.SetSecurityInfoWithHttpInfo(securityInfoRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SharingApi.SetSecurityInfoWithHttpInfo: " + e.Message);
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
| **200** | List of shared files and folders information: sharing rights, a user who has the access to the specified folder, the folder is locked by this user or not, this user is an owner of the specified folder or not, this user can edit the access to the specified folder or not |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

