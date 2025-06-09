# Docspace.Api.FilesFilesApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTemplates**](FilesFilesApi.md#addtemplates) | **POST** /api/2.0/files/templates | Add template files |
| [**ChangeVersionHistory**](FilesFilesApi.md#changeversionhistory) | **PUT** /api/2.0/files/file/{fileId}/history | Change version history |
| [**CheckFillFormDraft**](FilesFilesApi.md#checkfillformdraft) | **POST** /api/2.0/files/masterform/{fileId}/checkfillformdraft | Check the form draft filling |
| [**CopyFileAs**](FilesFilesApi.md#copyfileas) | **POST** /api/2.0/files/file/{fileId}/copyas | Copy a file |
| [**CreateEditSession**](FilesFilesApi.md#createeditsession) | **POST** /api/2.0/files/file/{fileId}/edit_session | Create the editing session |
| [**CreateFile**](FilesFilesApi.md#createfile) | **POST** /api/2.0/files/{folderId}/file | Create a file |
| [**CreateFileInMyDocuments**](FilesFilesApi.md#createfileinmydocuments) | **POST** /api/2.0/files/@my/file | Create a file in the \&quot;My documents\&quot; section |
| [**CreateHtmlFile**](FilesFilesApi.md#createhtmlfile) | **POST** /api/2.0/files/{folderId}/html | Create an HTML file |
| [**CreateHtmlFileInMyDocuments**](FilesFilesApi.md#createhtmlfileinmydocuments) | **POST** /api/2.0/files/@my/html | Create an HTML file in the \&quot;My documents\&quot; section |
| [**CreatePrimaryExternalLink**](FilesFilesApi.md#createprimaryexternallink) | **POST** /api/2.0/files/file/{id}/link | Create primary external link |
| [**CreateTextFile**](FilesFilesApi.md#createtextfile) | **POST** /api/2.0/files/{folderId}/text | Create a text file |
| [**CreateTextFileInMyDocuments**](FilesFilesApi.md#createtextfileinmydocuments) | **POST** /api/2.0/files/@my/text | Create a text file in the \&quot;My documents\&quot; section |
| [**CreateThumbnails**](FilesFilesApi.md#createthumbnails) | **POST** /api/2.0/files/thumbnails | Create file thumbnails |
| [**DeleteFile**](FilesFilesApi.md#deletefile) | **DELETE** /api/2.0/files/file/{fileId} | Delete a file |
| [**DeleteRecent**](FilesFilesApi.md#deleterecent) | **DELETE** /api/2.0/files/recent | Delete recent files |
| [**DeleteTemplates**](FilesFilesApi.md#deletetemplates) | **DELETE** /api/2.0/files/templates | Delete template files |
| [**GetAllFormRoles**](FilesFilesApi.md#getallformroles) | **GET** /api/2.0/files/file/{fileId}/formroles | Get form roles |
| [**GetEditDiffUrl**](FilesFilesApi.md#geteditdiffurl) | **GET** /api/2.0/files/file/{fileId}/edit/diff | Get changes URL |
| [**GetEditHistory**](FilesFilesApi.md#getedithistory) | **GET** /api/2.0/files/file/{fileId}/edit/history | Get version history |
| [**GetFileHistory**](FilesFilesApi.md#getfilehistory) | **GET** /api/2.0/files/file/{fileId}/log | Get file history |
| [**GetFileInfo**](FilesFilesApi.md#getfileinfo) | **GET** /api/2.0/files/file/{fileId} | Get file information |
| [**GetFileLinks**](FilesFilesApi.md#getfilelinks) | **GET** /api/2.0/files/file/{id}/links | Get file external links |
| [**GetFilePrimaryExternalLink**](FilesFilesApi.md#getfileprimaryexternallink) | **GET** /api/2.0/files/file/{id}/link | Get primary external link |
| [**GetFileVersionInfo**](FilesFilesApi.md#getfileversioninfo) | **GET** /api/2.0/files/file/{fileId}/history | Get file versions |
| [**GetFillResult**](FilesFilesApi.md#getfillresult) | **GET** /api/2.0/files/file/fillresult | Get form-filling result |
| [**GetPresignedFileUri**](FilesFilesApi.md#getpresignedfileuri) | **GET** /api/2.0/files/file/{fileId}/presigned | Get file download link asynchronously |
| [**GetPresignedUri**](FilesFilesApi.md#getpresigneduri) | **GET** /api/2.0/files/file/{fileId}/presigneduri | Get file download link |
| [**GetProtectedFileUsers**](FilesFilesApi.md#getprotectedfileusers) | **GET** /api/2.0/files/file/{fileId}/protectusers | Get users access rights to the protected file |
| [**GetReferenceData**](FilesFilesApi.md#getreferencedata) | **POST** /api/2.0/files/file/referencedata | Get reference data |
| [**IsFormPDF**](FilesFilesApi.md#isformpdf) | **GET** /api/2.0/files/file/{fileId}/isformpdf | Check the PDF file |
| [**LockFile**](FilesFilesApi.md#lockfile) | **PUT** /api/2.0/files/file/{fileId}/lock | Lock a file |
| [**ManageFormFilling**](FilesFilesApi.md#manageformfilling) | **PUT** /api/2.0/files/file/{fileId}/manageformfilling | Perform form filling action |
| [**OpenEditFile**](FilesFilesApi.md#openeditfile) | **GET** /api/2.0/files/file/{fileId}/openedit | Open a file configuration |
| [**RestoreFileVersion**](FilesFilesApi.md#restorefileversion) | **GET** /api/2.0/files/file/{fileId}/restoreversion | Restore a file version |
| [**SaveEditingFileFromForm**](FilesFilesApi.md#saveeditingfilefromform) | **PUT** /api/2.0/files/file/{fileId}/saveediting | Save file edits |
| [**SaveFileAsPdf**](FilesFilesApi.md#savefileaspdf) | **POST** /api/2.0/files/file/{id}/saveaspdf | Save a file as PDF |
| [**SaveFormRoleMapping**](FilesFilesApi.md#saveformrolemapping) | **POST** /api/2.0/files/file/{fileId}/formrolemapping | Save form role mapping |
| [**SetCustomFilterTag**](FilesFilesApi.md#setcustomfiltertag) | **PUT** /api/2.0/files/file/{fileId}/customfilter | Set the Custom Filter editing mode |
| [**SetExternalLink**](FilesFilesApi.md#setexternallink) | **PUT** /api/2.0/files/file/{id}/links | Set an external link |
| [**SetFileOrder**](FilesFilesApi.md#setfileorder) | **PUT** /api/2.0/files/{fileId}/order | Set file order |
| [**SetFilesOrder**](FilesFilesApi.md#setfilesorder) | **PUT** /api/2.0/files/order | Set order of files |
| [**StartEditFile**](FilesFilesApi.md#starteditfile) | **POST** /api/2.0/files/file/{fileId}/startedit | Start file editing |
| [**StartFillingFile**](FilesFilesApi.md#startfillingfile) | **PUT** /api/2.0/files/file/{fileId}/startfilling | Start file filling |
| [**TrackEditFile**](FilesFilesApi.md#trackeditfile) | **GET** /api/2.0/files/file/{fileId}/trackeditfile | Track file editing |
| [**UpdateFile**](FilesFilesApi.md#updatefile) | **PUT** /api/2.0/files/file/{fileId} | Update a file |

<a id="addtemplates"></a>
# **AddTemplates**
> BooleanWrapper AddTemplates (TemplatesRequestDto? templatesRequestDto = null)

Add template files

Adds files with the IDs specified in the request to the template list.

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
    public class AddTemplatesExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var templatesRequestDto = new TemplatesRequestDto?(); // TemplatesRequestDto? |  (optional) 

            try
            {
                // Add template files
                BooleanWrapper result = apiInstance.AddTemplates(templatesRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.AddTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add template files
    ApiResponse<BooleanWrapper> response = apiInstance.AddTemplatesWithHttpInfo(templatesRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.AddTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templatesRequestDto** | [**TemplatesRequestDto?**](TemplatesRequestDto?.md) |  | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Boolean value: true if the operation is successful |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changeversionhistory"></a>
# **ChangeVersionHistory**
> FileIntegerArrayWrapper ChangeVersionHistory (int fileId, ChangeHistory? changeHistory = null)

Change version history

Changes the version history of a file with the ID specified in the request.

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
    public class ChangeVersionHistoryExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file Id to change its version history.
            var changeHistory = new ChangeHistory?(); // ChangeHistory? | The parameters for changing version history. (optional) 

            try
            {
                // Change version history
                FileIntegerArrayWrapper result = apiInstance.ChangeVersionHistory(fileId, changeHistory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.ChangeVersionHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeVersionHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change version history
    ApiResponse<FileIntegerArrayWrapper> response = apiInstance.ChangeVersionHistoryWithHttpInfo(fileId, changeHistory);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.ChangeVersionHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file Id to change its version history. |  |
| **changeHistory** | [**ChangeHistory?**](ChangeHistory?.md) | The parameters for changing version history. | [optional]  |

### Return type

[**FileIntegerArrayWrapper**](FileIntegerArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated information about file versions |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkfillformdraft"></a>
# **CheckFillFormDraft**
> StringWrapper CheckFillFormDraft (int fileId, CheckFillFormDraft? checkFillFormDraft = null)

Check the form draft filling

Checks if the current file is a form draft which can be filled out.

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
    public class CheckFillFormDraftExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the form draft.
            var checkFillFormDraft = new CheckFillFormDraft?(); // CheckFillFormDraft? | The parameters for checking the form draft filling. (optional) 

            try
            {
                // Check the form draft filling
                StringWrapper result = apiInstance.CheckFillFormDraft(fileId, checkFillFormDraft);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CheckFillFormDraft: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckFillFormDraftWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the form draft filling
    ApiResponse<StringWrapper> response = apiInstance.CheckFillFormDraftWithHttpInfo(fileId, checkFillFormDraft);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CheckFillFormDraftWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the form draft. |  |
| **checkFillFormDraft** | [**CheckFillFormDraft?**](CheckFillFormDraft?.md) | The parameters for checking the form draft filling. | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Link to the form |  -  |
| **403** | You don&#39;t have enough permission to view the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="copyfileas"></a>
# **CopyFileAs**
> FileEntryWrapper CopyFileAs (int fileId, CopyAsJsonElement? copyAsJsonElement = null)

Copy a file

Copies (and converts if possible) an existing file to the specified folder.

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
    public class CopyFileAsExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to copy.
            var copyAsJsonElement = new CopyAsJsonElement?(); // CopyAsJsonElement? | The parameters for copying a file. (optional) 

            try
            {
                // Copy a file
                FileEntryWrapper result = apiInstance.CopyFileAs(fileId, copyAsJsonElement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CopyFileAs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopyFileAsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Copy a file
    ApiResponse<FileEntryWrapper> response = apiInstance.CopyFileAsWithHttpInfo(fileId, copyAsJsonElement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CopyFileAsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to copy. |  |
| **copyAsJsonElement** | [**CopyAsJsonElement?**](CopyAsJsonElement?.md) | The parameters for copying a file. | [optional]  |

### Return type

[**FileEntryWrapper**](FileEntryWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Copied file entry information |  -  |
| **400** | No file id or folder id toFolderId determine provider |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |
| **404** | File not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createeditsession"></a>
# **CreateEditSession**
> ObjectWrapper CreateEditSession (int fileId, long? fileSize = null)

Create the editing session

Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  <ul>  <li><b>id:</b> unique ID of this upload session,</li>  <li><b>created:</b> UTC time when the session was created,</li>  <li><b>expired:</b> UTC time when the session will expire if no chunks are sent before that time,</li>  <li><b>location:</b> URL where you should send your next chunk,</li>  <li><b>bytes_uploaded:</b> number of bytes uploaded for the specific upload ID,</li>  <li><b>bytes_total:</b> total number of bytes which will be uploaded.</li>  </ul>

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
    public class CreateEditSessionExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID.
            var fileSize = 1234;  // long? | The file size in bytes. (optional) 

            try
            {
                // Create the editing session
                ObjectWrapper result = apiInstance.CreateEditSession(fileId, fileSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateEditSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEditSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create the editing session
    ApiResponse<ObjectWrapper> response = apiInstance.CreateEditSessionWithHttpInfo(fileId, fileSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateEditSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID. |  |
| **fileSize** | **long?** | The file size in bytes. | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information about created session |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfile"></a>
# **CreateFile**
> FileIntegerWrapper CreateFile (int folderId, CreateFileJsonElement? createFileJsonElement = null)

Create a file

Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.

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
    public class CreateFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID for the file creation.
            var createFileJsonElement = new CreateFileJsonElement?(); // CreateFileJsonElement? | The parameters for creating a file. (optional) 

            try
            {
                // Create a file
                FileIntegerWrapper result = apiInstance.CreateFile(folderId, createFileJsonElement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a file
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateFileWithHttpInfo(folderId, createFileJsonElement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID for the file creation. |  |
| **createFileJsonElement** | [**CreateFileJsonElement?**](CreateFileJsonElement?.md) | The parameters for creating a file. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfileinmydocuments"></a>
# **CreateFileInMyDocuments**
> FileIntegerWrapper CreateFileInMyDocuments (CreateFileJsonElement? createFileJsonElement = null)

Create a file in the \"My documents\" section

Creates a new file in the \"My documents\" section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.

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
    public class CreateFileInMyDocumentsExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var createFileJsonElement = new CreateFileJsonElement?(); // CreateFileJsonElement? |  (optional) 

            try
            {
                // Create a file in the \"My documents\" section
                FileIntegerWrapper result = apiInstance.CreateFileInMyDocuments(createFileJsonElement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateFileInMyDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFileInMyDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a file in the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateFileInMyDocumentsWithHttpInfo(createFileJsonElement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateFileInMyDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createFileJsonElement** | [**CreateFileJsonElement?**](CreateFileJsonElement?.md) |  | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createhtmlfile"></a>
# **CreateHtmlFile**
> FileIntegerWrapper CreateHtmlFile (int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = null)

Create an HTML file

Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.

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
    public class CreateHtmlFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID to create the text or HTML file.
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? | The parameters for creating an HTML or text file. (optional) 

            try
            {
                // Create an HTML file
                FileIntegerWrapper result = apiInstance.CreateHtmlFile(folderId, createTextOrHtmlFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateHtmlFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateHtmlFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an HTML file
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateHtmlFileWithHttpInfo(folderId, createTextOrHtmlFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateHtmlFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID to create the text or HTML file. |  |
| **createTextOrHtmlFile** | [**CreateTextOrHtmlFile?**](CreateTextOrHtmlFile?.md) | The parameters for creating an HTML or text file. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createhtmlfileinmydocuments"></a>
# **CreateHtmlFileInMyDocuments**
> FileIntegerWrapper CreateHtmlFileInMyDocuments (CreateTextOrHtmlFile? createTextOrHtmlFile = null)

Create an HTML file in the \"My documents\" section

Creates an HTML (.html) file in the \"My documents\" section with the title and contents specified in the request.

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
    public class CreateHtmlFileInMyDocumentsExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? |  (optional) 

            try
            {
                // Create an HTML file in the \"My documents\" section
                FileIntegerWrapper result = apiInstance.CreateHtmlFileInMyDocuments(createTextOrHtmlFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateHtmlFileInMyDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateHtmlFileInMyDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an HTML file in the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateHtmlFileInMyDocumentsWithHttpInfo(createTextOrHtmlFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateHtmlFileInMyDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTextOrHtmlFile** | [**CreateTextOrHtmlFile?**](CreateTextOrHtmlFile?.md) |  | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createprimaryexternallink"></a>
# **CreatePrimaryExternalLink**
> FileShareWrapper CreatePrimaryExternalLink (int id, FileLinkRequest? fileLinkRequest = null)

Create primary external link

Creates a primary external link by the identifier specified in the request.

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
    public class CreatePrimaryExternalLinkExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The file ID.
            var fileLinkRequest = new FileLinkRequest?(); // FileLinkRequest? | The file external link parameters. (optional) 

            try
            {
                // Create primary external link
                FileShareWrapper result = apiInstance.CreatePrimaryExternalLink(id, fileLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreatePrimaryExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePrimaryExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create primary external link
    ApiResponse<FileShareWrapper> response = apiInstance.CreatePrimaryExternalLinkWithHttpInfo(id, fileLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreatePrimaryExternalLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The file ID. |  |
| **fileLinkRequest** | [**FileLinkRequest?**](FileLinkRequest?.md) | The file external link parameters. | [optional]  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File security information |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtextfile"></a>
# **CreateTextFile**
> FileIntegerWrapper CreateTextFile (int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = null)

Create a text file

Creates a text (.txt) file in the selected folder with the title and contents specified in the request.

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
    public class CreateTextFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | The folder ID to create the text or HTML file.
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? | The parameters for creating an HTML or text file. (optional) 

            try
            {
                // Create a text file
                FileIntegerWrapper result = apiInstance.CreateTextFile(folderId, createTextOrHtmlFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateTextFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTextFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a text file
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateTextFileWithHttpInfo(folderId, createTextOrHtmlFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateTextFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **int** | The folder ID to create the text or HTML file. |  |
| **createTextOrHtmlFile** | [**CreateTextOrHtmlFile?**](CreateTextOrHtmlFile?.md) | The parameters for creating an HTML or text file. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtextfileinmydocuments"></a>
# **CreateTextFileInMyDocuments**
> FileIntegerWrapper CreateTextFileInMyDocuments (CreateTextOrHtmlFile? createTextOrHtmlFile = null)

Create a text file in the \"My documents\" section

Creates a text (.txt) file in the \"My documents\" section with the title and contents specified in the request.

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
    public class CreateTextFileInMyDocumentsExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? |  (optional) 

            try
            {
                // Create a text file in the \"My documents\" section
                FileIntegerWrapper result = apiInstance.CreateTextFileInMyDocuments(createTextOrHtmlFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateTextFileInMyDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTextFileInMyDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a text file in the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateTextFileInMyDocumentsWithHttpInfo(createTextOrHtmlFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateTextFileInMyDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTextOrHtmlFile** | [**CreateTextOrHtmlFile?**](CreateTextOrHtmlFile?.md) |  | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createthumbnails"></a>
# **CreateThumbnails**
> ObjectArrayWrapper CreateThumbnails (BaseBatchRequestDto? baseBatchRequestDto = null)

Create file thumbnails

Creates thumbnails for the files with the IDs specified in the request.

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
    public class CreateThumbnailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? |  (optional) 

            try
            {
                // Create file thumbnails
                ObjectArrayWrapper result = apiInstance.CreateThumbnails(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateThumbnails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateThumbnailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create file thumbnails
    ApiResponse<ObjectArrayWrapper> response = apiInstance.CreateThumbnailsWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateThumbnailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseBatchRequestDto** | [**BaseBatchRequestDto?**](BaseBatchRequestDto?.md) |  | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of file IDs |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefile"></a>
# **DeleteFile**
> FileOperationArrayWrapper DeleteFile (int fileId, Delete delete)

Delete a file

Deletes a file with the ID specified in the request.

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
    public class DeleteFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to delete.
            var delete = new Delete(); // Delete | The parameters for deleting a file.

            try
            {
                // Delete a file
                FileOperationArrayWrapper result = apiInstance.DeleteFile(fileId, delete);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.DeleteFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a file
    ApiResponse<FileOperationArrayWrapper> response = apiInstance.DeleteFileWithHttpInfo(fileId, delete);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.DeleteFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to delete. |  |
| **delete** | [**Delete**](Delete.md) | The parameters for deleting a file. |  |

### Return type

[**FileOperationArrayWrapper**](FileOperationArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of file operations |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterecent"></a>
# **DeleteRecent**
> NoContentResultWrapper DeleteRecent (BaseBatchRequestDto? baseBatchRequestDto = null)

Delete recent files

Removes files with the IDs specified in the request from the \"Recent\" section.

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
    public class DeleteRecentExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? |  (optional) 

            try
            {
                // Delete recent files
                NoContentResultWrapper result = apiInstance.DeleteRecent(baseBatchRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.DeleteRecent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRecentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete recent files
    ApiResponse<NoContentResultWrapper> response = apiInstance.DeleteRecentWithHttpInfo(baseBatchRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.DeleteRecentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseBatchRequestDto** | [**BaseBatchRequestDto?**](BaseBatchRequestDto?.md) |  | [optional]  |

### Return type

[**NoContentResultWrapper**](NoContentResultWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No content |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetemplates"></a>
# **DeleteTemplates**
> BooleanWrapper DeleteTemplates (List<int>? requestBody = null)

Delete template files

Removes files with the IDs specified in the request from the template list.

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
    public class DeleteTemplatesExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var requestBody = new List<int>?(); // List<int>? | The file IDs. (optional) 

            try
            {
                // Delete template files
                BooleanWrapper result = apiInstance.DeleteTemplates(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.DeleteTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete template files
    ApiResponse<BooleanWrapper> response = apiInstance.DeleteTemplatesWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.DeleteTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;int&gt;?**](int.md) | The file IDs. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Boolean value: true if the operation is successful |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallformroles"></a>
# **GetAllFormRoles**
> FormRoleArrayWrapper GetAllFormRoles (int fileId)

Get form roles

Returns all roles for the specified form.

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
    public class GetAllFormRolesExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Get form roles
                FormRoleArrayWrapper result = apiInstance.GetAllFormRoles(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetAllFormRoles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllFormRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get form roles
    ApiResponse<FormRoleArrayWrapper> response = apiInstance.GetAllFormRolesWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetAllFormRolesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**FormRoleArrayWrapper**](FormRoleArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved all roles for the form |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to view the form roles |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="geteditdiffurl"></a>
# **GetEditDiffUrl**
> EditHistoryDataWrapper GetEditDiffUrl (int fileId, int? version = null)

Get changes URL

Returns a URL to the changes of a file version specified in the request.

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
    public class GetEditDiffUrlExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID.
            var version = 1234;  // int? | The file version. (optional) 

            try
            {
                // Get changes URL
                EditHistoryDataWrapper result = apiInstance.GetEditDiffUrl(fileId, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetEditDiffUrl: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEditDiffUrlWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get changes URL
    ApiResponse<EditHistoryDataWrapper> response = apiInstance.GetEditDiffUrlWithHttpInfo(fileId, version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetEditDiffUrlWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID. |  |
| **version** | **int?** | The file version. | [optional]  |

### Return type

[**EditHistoryDataWrapper**](EditHistoryDataWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File version history data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getedithistory"></a>
# **GetEditHistory**
> EditHistoryArrayWrapper GetEditHistory (int fileId)

Get version history

Returns the version history of a file with the ID specified in the request.

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
    public class GetEditHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Get version history
                EditHistoryArrayWrapper result = apiInstance.GetEditHistory(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetEditHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEditHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get version history
    ApiResponse<EditHistoryArrayWrapper> response = apiInstance.GetEditHistoryWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetEditHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**EditHistoryArrayWrapper**](EditHistoryArrayWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Version history data |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilehistory"></a>
# **GetFileHistory**
> HistoryArrayWrapper GetFileHistory (int fileId, ApiDateTime? fromDate = null, ApiDateTime? toDate = null, int? count = null, int? startIndex = null)

Get file history

Returns the list of actions performed on the file with the specified identifier.

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
    public class GetFileHistoryExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the history request.
            var fromDate = new ApiDateTime?(); // ApiDateTime? | The start date of the history. (optional) 
            var toDate = new ApiDateTime?(); // ApiDateTime? | The end date of the history. (optional) 
            var count = 1234;  // int? | The number of history entries to retrieve for the file log. (optional) 
            var startIndex = 1234;  // int? | The starting index for retrieving a subset of file history entries. (optional) 

            try
            {
                // Get file history
                HistoryArrayWrapper result = apiInstance.GetFileHistory(fileId, fromDate, toDate, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetFileHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file history
    ApiResponse<HistoryArrayWrapper> response = apiInstance.GetFileHistoryWithHttpInfo(fileId, fromDate, toDate, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetFileHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the history request. |  |
| **fromDate** | [**ApiDateTime?**](ApiDateTime?.md) | The start date of the history. | [optional]  |
| **toDate** | [**ApiDateTime?**](ApiDateTime?.md) | The end date of the history. | [optional]  |
| **count** | **int?** | The number of history entries to retrieve for the file log. | [optional]  |
| **startIndex** | **int?** | The starting index for retrieving a subset of file history entries. | [optional]  |

### Return type

[**HistoryArrayWrapper**](HistoryArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of actions performed on the file |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The required file was not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfileinfo"></a>
# **GetFileInfo**
> FileIntegerWrapper GetFileInfo (int fileId, int? version = null)

Get file information

Returns the detailed information about a file with the ID specified in the request.

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
    public class GetFileInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID.
            var version = 1234;  // int? | The file version. (optional) 

            try
            {
                // Get file information
                FileIntegerWrapper result = apiInstance.GetFileInfo(fileId, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetFileInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file information
    ApiResponse<FileIntegerWrapper> response = apiInstance.GetFileInfoWithHttpInfo(fileId, version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetFileInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID. |  |
| **version** | **int?** | The file version. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File information |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilelinks"></a>
# **GetFileLinks**
> FileShareArrayWrapper GetFileLinks (int id, int? count = null, int? startIndex = null)

Get file external links

Returns the external links of a file with the ID specified in the request.

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
    public class GetFileLinksExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The file ID of the request.
            var count = 1234;  // int? | The number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 

            try
            {
                // Get file external links
                FileShareArrayWrapper result = apiInstance.GetFileLinks(id, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetFileLinks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileLinksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file external links
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetFileLinksWithHttpInfo(id, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetFileLinksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The file ID of the request. |  |
| **count** | **int?** | The number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |

### Return type

[**FileShareArrayWrapper**](FileShareArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfileprimaryexternallink"></a>
# **GetFilePrimaryExternalLink**
> FileShareWrapper GetFilePrimaryExternalLink (int id, int? count = null, int? startIndex = null)

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
    public class GetFilePrimaryExternalLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The file ID of the request.
            var count = 1234;  // int? | The number of items to retrieve in the request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 

            try
            {
                // Get primary external link
                FileShareWrapper result = apiInstance.GetFilePrimaryExternalLink(id, count, startIndex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetFilePrimaryExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilePrimaryExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get primary external link
    ApiResponse<FileShareWrapper> response = apiInstance.GetFilePrimaryExternalLinkWithHttpInfo(id, count, startIndex);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetFilePrimaryExternalLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The file ID of the request. |  |
| **count** | **int?** | The number of items to retrieve in the request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |

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
| **200** | File security information |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfileversioninfo"></a>
# **GetFileVersionInfo**
> FileIntegerArrayWrapper GetFileVersionInfo (int fileId)

Get file versions

Returns the detailed information about all the available file versions with the ID specified in the request.

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
    public class GetFileVersionInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Get file versions
                FileIntegerArrayWrapper result = apiInstance.GetFileVersionInfo(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetFileVersionInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileVersionInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file versions
    ApiResponse<FileIntegerArrayWrapper> response = apiInstance.GetFileVersionInfoWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetFileVersionInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**FileIntegerArrayWrapper**](FileIntegerArrayWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information about file versions: folder ID, version, version group, content length, pure content length, file status, URL to view a file, web URL, file type, file extension, comment, encrypted or not, thumbnail URL, thumbnail status, locked or not, user ID who locked a file, denies file downloading or not, denies file sharing or not, file accessibility |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfillresult"></a>
# **GetFillResult**
> FillingFormResultIntegerWrapper GetFillResult (string? fillingSessionId = null)

Get form-filling result

Retrieves the result of a form-filling session.

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
    public class GetFillResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fillingSessionId = some text;  // string? | The form-filling session ID. (optional) 

            try
            {
                // Get form-filling result
                FillingFormResultIntegerWrapper result = apiInstance.GetFillResult(fillingSessionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetFillResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFillResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get form-filling result
    ApiResponse<FillingFormResultIntegerWrapper> response = apiInstance.GetFillResultWithHttpInfo(fillingSessionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetFillResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fillingSessionId** | **string?** | The form-filling session ID. | [optional]  |

### Return type

[**FillingFormResultIntegerWrapper**](FillingFormResultIntegerWrapper.md)

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

<a id="getpresignedfileuri"></a>
# **GetPresignedFileUri**
> FileLinkWrapper GetPresignedFileUri (int fileId)

Get file download link asynchronously

Returns a link to download a file with the ID specified in the request asynchronously.

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
    public class GetPresignedFileUriExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Get file download link asynchronously
                FileLinkWrapper result = apiInstance.GetPresignedFileUri(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetPresignedFileUri: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPresignedFileUriWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file download link asynchronously
    ApiResponse<FileLinkWrapper> response = apiInstance.GetPresignedFileUriWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetPresignedFileUriWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**FileLinkWrapper**](FileLinkWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File download link |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpresigneduri"></a>
# **GetPresignedUri**
> StringWrapper GetPresignedUri (int fileId)

Get file download link

Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.

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
    public class GetPresignedUriExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Get file download link
                StringWrapper result = apiInstance.GetPresignedUri(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetPresignedUri: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPresignedUriWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file download link
    ApiResponse<StringWrapper> response = apiInstance.GetPresignedUriWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetPresignedUriWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File download link |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprotectedfileusers"></a>
# **GetProtectedFileUsers**
> MentionWrapperArrayWrapper GetProtectedFileUsers (int fileId)

Get users access rights to the protected file

Returns a list of users with their access rights to the protected file with the ID specified in the request.

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
    public class GetProtectedFileUsersExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Get users access rights to the protected file
                MentionWrapperArrayWrapper result = apiInstance.GetProtectedFileUsers(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetProtectedFileUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProtectedFileUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users access rights to the protected file
    ApiResponse<MentionWrapperArrayWrapper> response = apiInstance.GetProtectedFileUsersWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetProtectedFileUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**MentionWrapperArrayWrapper**](MentionWrapperArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users with their access rights to the protected file |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreferencedata"></a>
# **GetReferenceData**
> FileReferenceWrapper GetReferenceData (GetReferenceDataDtoInteger? getReferenceDataDtoInteger = null)

Get reference data

Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.

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
    public class GetReferenceDataExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var getReferenceDataDtoInteger = new GetReferenceDataDtoInteger?(); // GetReferenceDataDtoInteger? |  (optional) 

            try
            {
                // Get reference data
                FileReferenceWrapper result = apiInstance.GetReferenceData(getReferenceDataDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetReferenceData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReferenceDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get reference data
    ApiResponse<FileReferenceWrapper> response = apiInstance.GetReferenceDataWithHttpInfo(getReferenceDataDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetReferenceDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getReferenceDataDtoInteger** | [**GetReferenceDataDtoInteger?**](GetReferenceDataDtoInteger?.md) |  | [optional]  |

### Return type

[**FileReferenceWrapper**](FileReferenceWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File reference data |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="isformpdf"></a>
# **IsFormPDF**
> BooleanWrapper IsFormPDF (int fileId)

Check the PDF file

Checks if the PDF file is a form or not.

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
    public class IsFormPDFExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the request.

            try
            {
                // Check the PDF file
                BooleanWrapper result = apiInstance.IsFormPDF(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.IsFormPDF: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IsFormPDFWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check the PDF file
    ApiResponse<BooleanWrapper> response = apiInstance.IsFormPDFWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.IsFormPDFWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the request. |  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Boolean value: true - the PDF file is form, false - the PDF file is not a form |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lockfile"></a>
# **LockFile**
> FileIntegerWrapper LockFile (int fileId, LockFileParameters? lockFileParameters = null)

Lock a file

Locks a file with the ID specified in the request.

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
    public class LockFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID for locking.
            var lockFileParameters = new LockFileParameters?(); // LockFileParameters? | The parameters for locking a file. (optional) 

            try
            {
                // Lock a file
                FileIntegerWrapper result = apiInstance.LockFile(fileId, lockFileParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.LockFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LockFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lock a file
    ApiResponse<FileIntegerWrapper> response = apiInstance.LockFileWithHttpInfo(fileId, lockFileParameters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.LockFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID for locking. |  |
| **lockFileParameters** | [**LockFileParameters?**](LockFileParameters?.md) | The parameters for locking a file. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Locked file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="manageformfilling"></a>
# **ManageFormFilling**
> void ManageFormFilling (string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = null)

Perform form filling action

Performs the specified form filling action.

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
    public class ManageFormFillingExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = "fileId_example";  // string | 
            var manageFormFillingDtoInteger = new ManageFormFillingDtoInteger?(); // ManageFormFillingDtoInteger? |  (optional) 

            try
            {
                // Perform form filling action
                apiInstance.ManageFormFilling(fileId, manageFormFillingDtoInteger);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.ManageFormFilling: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ManageFormFillingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Perform form filling action
    apiInstance.ManageFormFillingWithHttpInfo(fileId, manageFormFillingDtoInteger);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.ManageFormFillingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **string** |  |  |
| **manageFormFillingDtoInteger** | [**ManageFormFillingDtoInteger?**](ManageFormFillingDtoInteger?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed the form filling action |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="openeditfile"></a>
# **OpenEditFile**
> ConfigurationIntegerWrapper OpenEditFile (int fileId, int? version = null, bool? view = null, EditorType? editorType = null, bool? edit = null, bool? fill = null)

Open a file configuration

Returns the initialization configuration of a file to open it in the editor.

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
    public class OpenEditFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to open.
            var version = 1234;  // int? | The file version to open. (optional) 
            var view = true;  // bool? | Specifies if the document will be opened for viewing only or not. (optional) 
            var editorType = new EditorType?(); // EditorType? | The editor type to open the file. (optional) 
            var edit = true;  // bool? | Specifies if the document is opened in the editing mode or not. (optional) 
            var fill = true;  // bool? | Specifies if the document is opened in the form-filling mode or not. (optional) 

            try
            {
                // Open a file configuration
                ConfigurationIntegerWrapper result = apiInstance.OpenEditFile(fileId, version, view, editorType, edit, fill);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.OpenEditFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OpenEditFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Open a file configuration
    ApiResponse<ConfigurationIntegerWrapper> response = apiInstance.OpenEditFileWithHttpInfo(fileId, version, view, editorType, edit, fill);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.OpenEditFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to open. |  |
| **version** | **int?** | The file version to open. | [optional]  |
| **view** | **bool?** | Specifies if the document will be opened for viewing only or not. | [optional]  |
| **editorType** | [**EditorType?**](EditorType?.md) | The editor type to open the file. | [optional]  |
| **edit** | **bool?** | Specifies if the document is opened in the editing mode or not. | [optional]  |
| **fill** | **bool?** | Specifies if the document is opened in the form-filling mode or not. | [optional]  |

### Return type

[**ConfigurationIntegerWrapper**](ConfigurationIntegerWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Configuration parameters |  -  |
| **403** | You don&#39;t have enough permission to view the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="restorefileversion"></a>
# **RestoreFileVersion**
> EditHistoryArrayWrapper RestoreFileVersion (int fileId, int? version = null, string? url = null)

Restore a file version

Restores a file version specified in the request.

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
    public class RestoreFileVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID of the restore version.
            var version = 1234;  // int? | The file version of the restore. (optional) 
            var url = some text;  // string? | The file version URL of the restore. (optional) 

            try
            {
                // Restore a file version
                EditHistoryArrayWrapper result = apiInstance.RestoreFileVersion(fileId, version, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.RestoreFileVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreFileVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a file version
    ApiResponse<EditHistoryArrayWrapper> response = apiInstance.RestoreFileVersionWithHttpInfo(fileId, version, url);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.RestoreFileVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID of the restore version. |  |
| **version** | **int?** | The file version of the restore. | [optional]  |
| **url** | **string?** | The file version URL of the restore. | [optional]  |

### Return type

[**EditHistoryArrayWrapper**](EditHistoryArrayWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Version history data: file ID, key, file version, version group, a user who updated a file, creation time, history changes in the string format, list of history changes, server version |  -  |
| **400** | No file id or folder id toFolderId determine provider |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="saveeditingfilefromform"></a>
# **SaveEditingFileFromForm**
> FileIntegerWrapper SaveEditingFileFromForm (int fileId, string? fileExtension = null, string? downloadUri = null, FileParameter? file = null, bool? forcesave = null)

Save file edits

Saves edits to a file with the ID specified in the request.

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
    public class SaveEditingFileFromFormExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The editing file ID from the request.
            var fileExtension = "fileExtension_example";  // string? | The editing file extension from the request. (optional) 
            var downloadUri = "downloadUri_example";  // string? | The URI to download the editing file. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | The request file stream. (optional) 
            var forcesave = true;  // bool? | Specifies whether to force save the file or not. (optional) 

            try
            {
                // Save file edits
                FileIntegerWrapper result = apiInstance.SaveEditingFileFromForm(fileId, fileExtension, downloadUri, file, forcesave);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SaveEditingFileFromForm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveEditingFileFromFormWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save file edits
    ApiResponse<FileIntegerWrapper> response = apiInstance.SaveEditingFileFromFormWithHttpInfo(fileId, fileExtension, downloadUri, file, forcesave);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SaveEditingFileFromFormWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The editing file ID from the request. |  |
| **fileExtension** | **string?** | The editing file extension from the request. | [optional]  |
| **downloadUri** | **string?** | The URI to download the editing file. | [optional]  |
| **file** | **FileParameter?****FileParameter?** | The request file stream. | [optional]  |
| **forcesave** | **bool?** | Specifies whether to force save the file or not. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Saved file parameters |  -  |
| **400** | No file id or folder id toFolderId determine provider |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savefileaspdf"></a>
# **SaveFileAsPdf**
> FileIntegerWrapper SaveFileAsPdf (int id, SaveAsPdfInteger? saveAsPdfInteger = null)

Save a file as PDF

Saves a file with the identifier specified in the request as a PDF document.

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
    public class SaveFileAsPdfExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The file ID to save as PDF.
            var saveAsPdfInteger = new SaveAsPdfInteger?(); // SaveAsPdfInteger? | The parameters for saving file as PDF. (optional) 

            try
            {
                // Save a file as PDF
                FileIntegerWrapper result = apiInstance.SaveFileAsPdf(id, saveAsPdfInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SaveFileAsPdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveFileAsPdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save a file as PDF
    ApiResponse<FileIntegerWrapper> response = apiInstance.SaveFileAsPdfWithHttpInfo(id, saveAsPdfInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SaveFileAsPdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The file ID to save as PDF. |  |
| **saveAsPdfInteger** | [**SaveAsPdfInteger?**](SaveAsPdfInteger?.md) | The parameters for saving file as PDF. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |
| **404** | File not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="saveformrolemapping"></a>
# **SaveFormRoleMapping**
> FormRoleWrapper SaveFormRoleMapping (string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = null)

Save form role mapping

Saves the form role mapping.

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
    public class SaveFormRoleMappingExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = "fileId_example";  // string | 
            var saveFormRoleMappingDtoInteger = new SaveFormRoleMappingDtoInteger?(); // SaveFormRoleMappingDtoInteger? |  (optional) 

            try
            {
                // Save form role mapping
                FormRoleWrapper result = apiInstance.SaveFormRoleMapping(fileId, saveFormRoleMappingDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SaveFormRoleMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveFormRoleMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save form role mapping
    ApiResponse<FormRoleWrapper> response = apiInstance.SaveFormRoleMappingWithHttpInfo(fileId, saveFormRoleMappingDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SaveFormRoleMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **string** |  |  |
| **saveFormRoleMappingDtoInteger** | [**SaveFormRoleMappingDtoInteger?**](SaveFormRoleMappingDtoInteger?.md) |  | [optional]  |

### Return type

[**FormRoleWrapper**](FormRoleWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated information about form role mappings |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setcustomfiltertag"></a>
# **SetCustomFilterTag**
> FileIntegerWrapper SetCustomFilterTag (int fileId, CustomFilterParameters? customFilterParameters = null)

Set the Custom Filter editing mode

Sets the Custom Filter editing mode to a file with the ID specified in the request.

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
    public class SetCustomFilterTagExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID.
            var customFilterParameters = new CustomFilterParameters?(); // CustomFilterParameters? | The parameters for setting the Custom Filter editing mode. (optional) 

            try
            {
                // Set the Custom Filter editing mode
                FileIntegerWrapper result = apiInstance.SetCustomFilterTag(fileId, customFilterParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SetCustomFilterTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetCustomFilterTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the Custom Filter editing mode
    ApiResponse<FileIntegerWrapper> response = apiInstance.SetCustomFilterTagWithHttpInfo(fileId, customFilterParameters);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SetCustomFilterTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID. |  |
| **customFilterParameters** | [**CustomFilterParameters?**](CustomFilterParameters?.md) | The parameters for setting the Custom Filter editing mode. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setexternallink"></a>
# **SetExternalLink**
> FileShareWrapper SetExternalLink (int id, FileLinkRequest? fileLinkRequest = null)

Set an external link

Sets an external link to a file with the ID specified in the request.

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
    public class SetExternalLinkExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The file ID.
            var fileLinkRequest = new FileLinkRequest?(); // FileLinkRequest? | The file external link parameters. (optional) 

            try
            {
                // Set an external link
                FileShareWrapper result = apiInstance.SetExternalLink(id, fileLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SetExternalLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetExternalLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set an external link
    ApiResponse<FileShareWrapper> response = apiInstance.SetExternalLinkWithHttpInfo(id, fileLinkRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SetExternalLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The file ID. |  |
| **fileLinkRequest** | [**FileLinkRequest?**](FileLinkRequest?.md) | The file external link parameters. | [optional]  |

### Return type

[**FileShareWrapper**](FileShareWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfileorder"></a>
# **SetFileOrder**
> FileIntegerWrapper SetFileOrder (int fileId, OrderRequestDto? orderRequestDto = null)

Set file order

Sets order of the file with ID specified in the request.

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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file unique identifier.
            var orderRequestDto = new OrderRequestDto?(); // OrderRequestDto? | The file order information. (optional) 

            try
            {
                // Set file order
                FileIntegerWrapper result = apiInstance.SetFileOrder(fileId, orderRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SetFileOrder: " + e.Message);
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
    // Set file order
    ApiResponse<FileIntegerWrapper> response = apiInstance.SetFileOrderWithHttpInfo(fileId, orderRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SetFileOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file unique identifier. |  |
| **orderRequestDto** | [**OrderRequestDto?**](OrderRequestDto?.md) | The file order information. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated file information |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfilesorder"></a>
# **SetFilesOrder**
> FileIntegerArrayWrapper SetFilesOrder (OrdersRequestDtoInteger? ordersRequestDtoInteger = null)

Set order of files

Sets order of the files.

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
    public class SetFilesOrderExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var ordersRequestDtoInteger = new OrdersRequestDtoInteger?(); // OrdersRequestDtoInteger? |  (optional) 

            try
            {
                // Set order of files
                FileIntegerArrayWrapper result = apiInstance.SetFilesOrder(ordersRequestDtoInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SetFilesOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetFilesOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set order of files
    ApiResponse<FileIntegerArrayWrapper> response = apiInstance.SetFilesOrderWithHttpInfo(ordersRequestDtoInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SetFilesOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ordersRequestDtoInteger** | [**OrdersRequestDtoInteger?**](OrdersRequestDtoInteger?.md) |  | [optional]  |

### Return type

[**FileIntegerArrayWrapper**](FileIntegerArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated file entries information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="starteditfile"></a>
# **StartEditFile**
> StringWrapper StartEditFile (int fileId, StartEdit? startEdit = null)

Start file editing

Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).

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
    public class StartEditFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to start editing.
            var startEdit = new StartEdit?(); // StartEdit? | The file parameters to start editing. (optional) 

            try
            {
                // Start file editing
                StringWrapper result = apiInstance.StartEditFile(fileId, startEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.StartEditFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartEditFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start file editing
    ApiResponse<StringWrapper> response = apiInstance.StartEditFileWithHttpInfo(fileId, startEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.StartEditFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to start editing. |  |
| **startEdit** | [**StartEdit?**](StartEdit?.md) | The file parameters to start editing. | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File key for Document Service |  -  |
| **403** | You don&#39;t have enough permission to view the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startfillingfile"></a>
# **StartFillingFile**
> FileIntegerWrapper StartFillingFile (int fileId)

Start file filling

Starts filling a file with the ID specified in the request.

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
    public class StartFillingFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to start filling.

            try
            {
                // Start file filling
                FileIntegerWrapper result = apiInstance.StartFillingFile(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.StartFillingFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartFillingFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start file filling
    ApiResponse<FileIntegerWrapper> response = apiInstance.StartFillingFileWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.StartFillingFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to start filling. |  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File information |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="trackeditfile"></a>
# **TrackEditFile**
> KeyValuePairBooleanStringWrapper TrackEditFile (int fileId, Guid? tabId = null, string? docKeyForTrack = null, bool? isFinish = null)

Track file editing

Tracks file changes when editing.

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
    public class TrackEditFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to track editing changes.
            var tabId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The tab ID to track editing changes. (optional) 
            var docKeyForTrack = some text;  // string? | The document key for tracking changes. (optional) 
            var isFinish = true;  // bool? | Specifies whether to finish file tracking or not. (optional) 

            try
            {
                // Track file editing
                KeyValuePairBooleanStringWrapper result = apiInstance.TrackEditFile(fileId, tabId, docKeyForTrack, isFinish);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.TrackEditFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrackEditFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Track file editing
    ApiResponse<KeyValuePairBooleanStringWrapper> response = apiInstance.TrackEditFileWithHttpInfo(fileId, tabId, docKeyForTrack, isFinish);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.TrackEditFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to track editing changes. |  |
| **tabId** | **Guid?** | The tab ID to track editing changes. | [optional]  |
| **docKeyForTrack** | **string?** | The document key for tracking changes. | [optional]  |
| **isFinish** | **bool?** | Specifies whether to finish file tracking or not. | [optional]  |

### Return type

[**KeyValuePairBooleanStringWrapper**](KeyValuePairBooleanStringWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File changes |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatefile"></a>
# **UpdateFile**
> FileIntegerWrapper UpdateFile (int fileId, UpdateFile? updateFile = null)

Update a file

Updates the information of the selected file with the parameters specified in the request.

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
    public class UpdateFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The file ID to update.
            var updateFile = new UpdateFile?(); // UpdateFile? | The parameters for updating a file. (optional) 

            try
            {
                // Update a file
                FileIntegerWrapper result = apiInstance.UpdateFile(fileId, updateFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.UpdateFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a file
    ApiResponse<FileIntegerWrapper> response = apiInstance.UpdateFileWithHttpInfo(fileId, updateFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.UpdateFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The file ID to update. |  |
| **updateFile** | [**UpdateFile?**](UpdateFile?.md) | The parameters for updating a file. | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated file information |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

