# Docspace.Api.FilesFilesApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTemplates**](FilesFilesApi.md#addtemplates) | **POST** /api/2.0/files/templates | Add template files |
| [**ChangeHistory**](FilesFilesApi.md#changehistory) | **PUT** /api/2.0/files/file/{fileId}/history | Change version history |
| [**CheckFillFormDraft**](FilesFilesApi.md#checkfillformdraft) | **POST** /api/2.0/files/masterform/{fileId}/checkfillformdraft | Check the form draft |
| [**CopyFileAs**](FilesFilesApi.md#copyfileas) | **POST** /api/2.0/files/file/{fileId}/copyas | Copy a file |
| [**CreateEditSession**](FilesFilesApi.md#createeditsession) | **POST** /api/2.0/files/file/{fileId}/edit_session | Create the editing session |
| [**CreateFile**](FilesFilesApi.md#createfile) | **POST** /api/2.0/files/{folderId}/file | Create a file |
| [**CreateFileMyDocuments**](FilesFilesApi.md#createfilemydocuments) | **POST** /api/2.0/files/@my/file | Create a file in the \&quot;My documents\&quot; section |
| [**CreateHtmlFile**](FilesFilesApi.md#createhtmlfile) | **POST** /api/2.0/files/{folderId}/html | Create an HTML file |
| [**CreateHtmlFileInMy**](FilesFilesApi.md#createhtmlfileinmy) | **POST** /api/2.0/files/@my/html | Create an HTML file in the \&quot;My documents\&quot; section |
| [**CreatePrimaryExternalLink**](FilesFilesApi.md#createprimaryexternallink) | **POST** /api/2.0/files/file/{id}/link | Create primary external link |
| [**CreateTextFile**](FilesFilesApi.md#createtextfile) | **POST** /api/2.0/files/{folderId}/text | Create a txt file |
| [**CreateTextFileInMy**](FilesFilesApi.md#createtextfileinmy) | **POST** /api/2.0/files/@my/text | Create a text file in the \&quot;My documents\&quot; section |
| [**CreateThumbnails**](FilesFilesApi.md#createthumbnails) | **POST** /api/2.0/files/thumbnails | Create thumbnails |
| [**DeleteFile**](FilesFilesApi.md#deletefile) | **DELETE** /api/2.0/files/file/{fileId} | Delete a file |
| [**DeleteRecent**](FilesFilesApi.md#deleterecent) | **DELETE** /api/2.0/files/recent | Delete recent files |
| [**DeleteTemplates**](FilesFilesApi.md#deletetemplates) | **DELETE** /api/2.0/files/templates | Delete template files |
| [**GetEditDiffUrl**](FilesFilesApi.md#geteditdiffurl) | **GET** /api/2.0/files/file/{fileId}/edit/diff | Get changes URL |
| [**GetEditHistory**](FilesFilesApi.md#getedithistory) | **GET** /api/2.0/files/file/{fileId}/edit/history | Get version history |
| [**GetFileHistory**](FilesFilesApi.md#getfilehistory) | **GET** /api/2.0/files/file/{fileId}/log | Get file history |
| [**GetFileInfo**](FilesFilesApi.md#getfileinfo) | **GET** /api/2.0/files/file/{fileId} | Get file information |
| [**GetFilePrimaryExternalLink**](FilesFilesApi.md#getfileprimaryexternallink) | **GET** /api/2.0/files/file/{id}/link | Get primary external link |
| [**GetFileVersionInfo**](FilesFilesApi.md#getfileversioninfo) | **GET** /api/2.0/files/file/{fileId}/history | Get file versions |
| [**GetFillResult**](FilesFilesApi.md#getfillresult) | **GET** /api/2.0/files/file/fillresult | Gets fill result |
| [**GetLinks**](FilesFilesApi.md#getlinks) | **GET** /api/2.0/files/file/{id}/links | Get file external links |
| [**GetPresignedFileUri**](FilesFilesApi.md#getpresignedfileuri) | **GET** /api/2.0/files/file/{fileId}/presigned | Get file download link asynchronously |
| [**GetPresignedUri**](FilesFilesApi.md#getpresigneduri) | **GET** /api/2.0/files/file/{fileId}/presigneduri | Get file download link |
| [**GetReferenceData**](FilesFilesApi.md#getreferencedata) | **POST** /api/2.0/files/file/referencedata | Get reference data |
| [**IsFormPDF**](FilesFilesApi.md#isformpdf) | **GET** /api/2.0/files/file/{fileId}/isformpdf | Check the PDF file |
| [**LockFile**](FilesFilesApi.md#lockfile) | **PUT** /api/2.0/files/file/{fileId}/lock | Lock a file |
| [**OpenEdit**](FilesFilesApi.md#openedit) | **GET** /api/2.0/files/file/{fileId}/openedit | Open a file |
| [**ProtectUsers**](FilesFilesApi.md#protectusers) | **GET** /api/2.0/files/file/{fileId}/protectusers | Get users with the access to the protected file |
| [**RestoreVersion**](FilesFilesApi.md#restoreversion) | **GET** /api/2.0/files/file/{fileId}/restoreversion | Restore a file version |
| [**SaveAsPdf**](FilesFilesApi.md#saveaspdf) | **POST** /api/2.0/files/file/{id}/saveaspdf | Save as pdf |
| [**SaveEditingFromForm**](FilesFilesApi.md#saveeditingfromform) | **PUT** /api/2.0/files/file/{fileId}/saveediting | Save file edits |
| [**SetExternalLink**](FilesFilesApi.md#setexternallink) | **PUT** /api/2.0/files/file/{id}/links | Set an external link |
| [**SetFilesOrder**](FilesFilesApi.md#setfilesorder) | **PUT** /api/2.0/files/order | Sets order |
| [**SetOrderFile**](FilesFilesApi.md#setorderfile) | **PUT** /api/2.0/files/{fileId}/order | Sets order of a file with ID specified in the request |
| [**StartEdit**](FilesFilesApi.md#startedit) | **POST** /api/2.0/files/file/{fileId}/startedit | Start file editing |
| [**StartFilling**](FilesFilesApi.md#startfilling) | **PUT** /api/2.0/files/file/{fileId}/startfilling | Starts filling |
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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

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

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Boolean value: true if the operation is successful |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changehistory"></a>
# **ChangeHistory**
> FileIntegerArrayWrapper ChangeHistory (int fileId, ChangeHistory? changeHistory = null)

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
    public class ChangeHistoryExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File Id
            var changeHistory = new ChangeHistory?(); // ChangeHistory? | File (optional) 

            try
            {
                // Change version history
                FileIntegerArrayWrapper result = apiInstance.ChangeHistory(fileId, changeHistory);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.ChangeHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change version history
    ApiResponse<FileIntegerArrayWrapper> response = apiInstance.ChangeHistoryWithHttpInfo(fileId, changeHistory);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.ChangeHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File Id |  |
| **changeHistory** | [**ChangeHistory?**](ChangeHistory?.md) | File | [optional]  |

### Return type

[**FileIntegerArrayWrapper**](FileIntegerArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Check the form draft

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var checkFillFormDraft = new CheckFillFormDraft?(); // CheckFillFormDraft? | File (optional) 

            try
            {
                // Check the form draft
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
    // Check the form draft
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
| **fileId** | **int** | File ID |  |
| **checkFillFormDraft** | [**CheckFillFormDraft?**](CheckFillFormDraft?.md) | File | [optional]  |

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File id
            var copyAsJsonElement = new CopyAsJsonElement?(); // CopyAsJsonElement? | File (optional) 

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
| **fileId** | **int** | File id |  |
| **copyAsJsonElement** | [**CopyAsJsonElement?**](CopyAsJsonElement?.md) | File | [optional]  |

### Return type

[**FileEntryWrapper**](FileEntryWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Creates a session to edit the existing file with multiple chunks (needed for WebDAV).

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var fileSize = 1234;  // long? | File size in bytes (optional) 

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
| **fileId** | **int** | File ID |  |
| **fileSize** | **long?** | File size in bytes | [optional]  |

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var createFileJsonElement = new CreateFileJsonElement?(); // CreateFileJsonElement? | File (optional) 

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
| **folderId** | **int** | Folder ID |  |
| **createFileJsonElement** | [**CreateFileJsonElement?**](CreateFileJsonElement?.md) | File | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createfilemydocuments"></a>
# **CreateFileMyDocuments**
> FileIntegerWrapper CreateFileMyDocuments (CreateFileJsonElement? createFileJsonElement = null)

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
    public class CreateFileMyDocumentsExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var createFileJsonElement = new CreateFileJsonElement?(); // CreateFileJsonElement? |  (optional) 

            try
            {
                // Create a file in the \"My documents\" section
                FileIntegerWrapper result = apiInstance.CreateFileMyDocuments(createFileJsonElement);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateFileMyDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFileMyDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a file in the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateFileMyDocumentsWithHttpInfo(createFileJsonElement);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateFileMyDocumentsWithHttpInfo: " + e.Message);
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

[asc_auth_key](../README.md#asc_auth_key)

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? | File (optional) 

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
| **folderId** | **int** | Folder ID |  |
| **createTextOrHtmlFile** | [**CreateTextOrHtmlFile?**](CreateTextOrHtmlFile?.md) | File | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

<a id="createhtmlfileinmy"></a>
# **CreateHtmlFileInMy**
> FileIntegerWrapper CreateHtmlFileInMy (CreateTextOrHtmlFile? createTextOrHtmlFile = null)

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
    public class CreateHtmlFileInMyExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? |  (optional) 

            try
            {
                // Create an HTML file in the \"My documents\" section
                FileIntegerWrapper result = apiInstance.CreateHtmlFileInMy(createTextOrHtmlFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateHtmlFileInMy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateHtmlFileInMyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an HTML file in the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateHtmlFileInMyWithHttpInfo(createTextOrHtmlFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateHtmlFileInMyWithHttpInfo: " + e.Message);
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

[asc_auth_key](../README.md#asc_auth_key)

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | File ID
            var fileLinkRequest = new FileLinkRequest?(); // FileLinkRequest? | External link parameters (optional) 

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
| **id** | **int** | File ID |  |
| **fileLinkRequest** | [**FileLinkRequest?**](FileLinkRequest?.md) | External link parameters | [optional]  |

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
| **200** | File security information |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtextfile"></a>
# **CreateTextFile**
> FileIntegerWrapper CreateTextFile (int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = null)

Create a txt file

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var folderId = 9846;  // int | Folder ID
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? | File (optional) 

            try
            {
                // Create a txt file
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
    // Create a txt file
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
| **folderId** | **int** | Folder ID |  |
| **createTextOrHtmlFile** | [**CreateTextOrHtmlFile?**](CreateTextOrHtmlFile?.md) | File | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtextfileinmy"></a>
# **CreateTextFileInMy**
> FileIntegerWrapper CreateTextFileInMy (CreateTextOrHtmlFile? createTextOrHtmlFile = null)

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
    public class CreateTextFileInMyExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var createTextOrHtmlFile = new CreateTextOrHtmlFile?(); // CreateTextOrHtmlFile? |  (optional) 

            try
            {
                // Create a text file in the \"My documents\" section
                FileIntegerWrapper result = apiInstance.CreateTextFileInMy(createTextOrHtmlFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.CreateTextFileInMy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTextFileInMyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a text file in the \"My documents\" section
    ApiResponse<FileIntegerWrapper> response = apiInstance.CreateTextFileInMyWithHttpInfo(createTextOrHtmlFile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.CreateTextFileInMyWithHttpInfo: " + e.Message);
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

[asc_auth_key](../README.md#asc_auth_key)

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

Create thumbnails

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var baseBatchRequestDto = new BaseBatchRequestDto?(); // BaseBatchRequestDto? |  (optional) 

            try
            {
                // Create thumbnails
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
    // Create thumbnails
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
> FileOperationArrayWrapper DeleteFile (int fileId, Delete? delete = null)

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var delete = new Delete?(); // Delete? | File (optional) 

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
| **fileId** | **int** | File ID |  |
| **delete** | [**Delete?**](Delete?.md) | File | [optional]  |

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

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

[asc_auth_key](../README.md#asc_auth_key)

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var requestBody = new List<int>?(); // List<int>? | File IDs (optional) 

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
| **requestBody** | [**List&lt;int&gt;?**](int.md) | File IDs | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Boolean value: true if the operation is successful |  -  |
| **401** | Unauthorized |  -  |

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var version = 1234;  // int? | File version (optional) 

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
| **fileId** | **int** | File ID |  |
| **version** | **int?** | File version | [optional]  |

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

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
| **fileId** | **int** | File ID |  |

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
> HistoryArrayWrapper GetFileHistory (int fileId, ApiDateTime? fromDate = null, ApiDateTime? toDate = null)

Get file history

Get the list of actions performed on the file with the specified identifier

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var fromDate = new ApiDateTime?(); // ApiDateTime? | Start date (optional) 
            var toDate = new ApiDateTime?(); // ApiDateTime? | End date (optional) 

            try
            {
                // Get file history
                HistoryArrayWrapper result = apiInstance.GetFileHistory(fileId, fromDate, toDate);
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
    ApiResponse<HistoryArrayWrapper> response = apiInstance.GetFileHistoryWithHttpInfo(fileId, fromDate, toDate);
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
| **fileId** | **int** | File ID |  |
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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var version = 1234;  // int? | File version (optional) 

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
| **fileId** | **int** | File ID |  |
| **version** | **int?** | File version | [optional]  |

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

<a id="getfileprimaryexternallink"></a>
# **GetFilePrimaryExternalLink**
> FileShareWrapper GetFilePrimaryExternalLink (int id)

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | File ID

            try
            {
                // Get primary external link
                FileShareWrapper result = apiInstance.GetFilePrimaryExternalLink(id);
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
    ApiResponse<FileShareWrapper> response = apiInstance.GetFilePrimaryExternalLinkWithHttpInfo(id);
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
| **id** | **int** | File ID |  |

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

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
| **fileId** | **int** | File ID |  |

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

Gets fill result

Gets fill result

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fillingSessionId = some text;  // string? | Filling session id (optional) 

            try
            {
                // Gets fill result
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
    // Gets fill result
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
| **fillingSessionId** | **string?** | Filling session id | [optional]  |

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

<a id="getlinks"></a>
# **GetLinks**
> FileShareArrayWrapper GetLinks (int id)

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
    public class GetLinksExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | File ID

            try
            {
                // Get file external links
                FileShareArrayWrapper result = apiInstance.GetLinks(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.GetLinks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLinksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get file external links
    ApiResponse<FileShareArrayWrapper> response = apiInstance.GetLinksWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.GetLinksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | File ID |  |

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
| **200** | File security information |  -  |
| **401** | Unauthorized |  -  |

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

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
| **fileId** | **int** | File ID |  |

### Return type

[**FileLinkWrapper**](FileLinkWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

Returns a link to download a file with the ID specified in the request.

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

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
| **fileId** | **int** | File ID |  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File download link |  -  |
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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

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

[asc_auth_key](../README.md#asc_auth_key)

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

Checks if the PDF file is form or not.

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

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
| **fileId** | **int** | File ID |  |

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var lockFileParameters = new LockFileParameters?(); // LockFileParameters? | Parameters for locking a file (optional) 

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
| **fileId** | **int** | File ID |  |
| **lockFileParameters** | [**LockFileParameters?**](LockFileParameters?.md) | Parameters for locking a file | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Locked file information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="openedit"></a>
# **OpenEdit**
> ConfigurationIntegerWrapper OpenEdit (int fileId, int? version = null, bool? view = null, EditorType? editorType = null, bool? edit = null, bool? fill = null)

Open a file

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
    public class OpenEditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var version = 1234;  // int? | File version (optional) 
            var view = true;  // bool? | Specifies if a document will be opened for viewing only or not (optional) 
            var editorType = new EditorType?(); // EditorType? | Editor type (optional) 
            var edit = true;  // bool? | Edit (optional) 
            var fill = true;  // bool? | Fill (optional) 

            try
            {
                // Open a file
                ConfigurationIntegerWrapper result = apiInstance.OpenEdit(fileId, version, view, editorType, edit, fill);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.OpenEdit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OpenEditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Open a file
    ApiResponse<ConfigurationIntegerWrapper> response = apiInstance.OpenEditWithHttpInfo(fileId, version, view, editorType, edit, fill);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.OpenEditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File ID |  |
| **version** | **int?** | File version | [optional]  |
| **view** | **bool?** | Specifies if a document will be opened for viewing only or not | [optional]  |
| **editorType** | [**EditorType?**](EditorType?.md) | Editor type | [optional]  |
| **edit** | **bool?** | Edit | [optional]  |
| **fill** | **bool?** | Fill | [optional]  |

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

<a id="protectusers"></a>
# **ProtectUsers**
> MentionWrapperArrayWrapper ProtectUsers (int fileId)

Get users with the access to the protected file

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
    public class ProtectUsersExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

            try
            {
                // Get users with the access to the protected file
                MentionWrapperArrayWrapper result = apiInstance.ProtectUsers(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.ProtectUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProtectUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users with the access to the protected file
    ApiResponse<MentionWrapperArrayWrapper> response = apiInstance.ProtectUsersWithHttpInfo(fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.ProtectUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File ID |  |

### Return type

[**MentionWrapperArrayWrapper**](MentionWrapperArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users with their access rights to the protected file |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="restoreversion"></a>
# **RestoreVersion**
> EditHistoryArrayWrapper RestoreVersion (int fileId, int? version = null, string? url = null)

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
    public class RestoreVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var version = 1234;  // int? | File version (optional) 
            var url = some text;  // string? | File version URL (optional) 

            try
            {
                // Restore a file version
                EditHistoryArrayWrapper result = apiInstance.RestoreVersion(fileId, version, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.RestoreVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RestoreVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a file version
    ApiResponse<EditHistoryArrayWrapper> response = apiInstance.RestoreVersionWithHttpInfo(fileId, version, url);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.RestoreVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File ID |  |
| **version** | **int?** | File version | [optional]  |
| **url** | **string?** | File version URL | [optional]  |

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

<a id="saveaspdf"></a>
# **SaveAsPdf**
> FileIntegerWrapper SaveAsPdf (int id, SaveAsPdfInteger? saveAsPdfInteger = null)

Save as pdf

Saves a file with the identifier specified in the request as a PDF document

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
    public class SaveAsPdfExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | File ID
            var saveAsPdfInteger = new SaveAsPdfInteger?(); // SaveAsPdfInteger? | Parameters for saving file as pdf (optional) 

            try
            {
                // Save as pdf
                FileIntegerWrapper result = apiInstance.SaveAsPdf(id, saveAsPdfInteger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SaveAsPdf: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveAsPdfWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save as pdf
    ApiResponse<FileIntegerWrapper> response = apiInstance.SaveAsPdfWithHttpInfo(id, saveAsPdfInteger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SaveAsPdfWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | File ID |  |
| **saveAsPdfInteger** | [**SaveAsPdfInteger?**](SaveAsPdfInteger?.md) | Parameters for saving file as pdf | [optional]  |

### Return type

[**FileIntegerWrapper**](FileIntegerWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

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

<a id="saveeditingfromform"></a>
# **SaveEditingFromForm**
> FileIntegerWrapper SaveEditingFromForm (int fileId, string? fileExtension = null, string? downloadUri = null, FileParameter? file = null, bool? forcesave = null)

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
    public class SaveEditingFromFormExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var fileExtension = "fileExtension_example";  // string? | File extension (optional) 
            var downloadUri = "downloadUri_example";  // string? | URI to download a file (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | Request file stream (optional) 
            var forcesave = true;  // bool? | Specifies whether to force save a file or not (optional) 

            try
            {
                // Save file edits
                FileIntegerWrapper result = apiInstance.SaveEditingFromForm(fileId, fileExtension, downloadUri, file, forcesave);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SaveEditingFromForm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveEditingFromFormWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save file edits
    ApiResponse<FileIntegerWrapper> response = apiInstance.SaveEditingFromFormWithHttpInfo(fileId, fileExtension, downloadUri, file, forcesave);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SaveEditingFromFormWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File ID |  |
| **fileExtension** | **string?** | File extension | [optional]  |
| **downloadUri** | **string?** | URI to download a file | [optional]  |
| **file** | **FileParameter?****FileParameter?** | Request file stream | [optional]  |
| **forcesave** | **bool?** | Specifies whether to force save a file or not | [optional]  |

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
| **200** | Saved file parameters |  -  |
| **400** | No file id or folder id toFolderId determine provider |  -  |
| **401** | Unauthorized |  -  |
| **403** | You do not have enough permissions to edit the file |  -  |

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | File ID
            var fileLinkRequest = new FileLinkRequest?(); // FileLinkRequest? | External link parameters (optional) 

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
| **id** | **int** | File ID |  |
| **fileLinkRequest** | [**FileLinkRequest?**](FileLinkRequest?.md) | External link parameters | [optional]  |

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
| **200** | File security information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setfilesorder"></a>
# **SetFilesOrder**
> void SetFilesOrder (OrdersRequestDtoInteger? ordersRequestDtoInteger = null)

Sets order

Sets order

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
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var ordersRequestDtoInteger = new OrdersRequestDtoInteger?(); // OrdersRequestDtoInteger? |  (optional) 

            try
            {
                // Sets order
                apiInstance.SetFilesOrder(ordersRequestDtoInteger);
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
    // Sets order
    apiInstance.SetFilesOrderWithHttpInfo(ordersRequestDtoInteger);
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

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Order is set |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setorderfile"></a>
# **SetOrderFile**
> void SetOrderFile (int fileId, OrderRequestDto? orderRequestDto = null)

Sets order of a file with ID specified in the request

Sets order of a file with ID specified in the request

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
    public class SetOrderFileExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | The unique identifier of the file
            var orderRequestDto = new OrderRequestDto?(); // OrderRequestDto? | Order information for the file (optional) 

            try
            {
                // Sets order of a file with ID specified in the request
                apiInstance.SetOrderFile(fileId, orderRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.SetOrderFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetOrderFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sets order of a file with ID specified in the request
    apiInstance.SetOrderFileWithHttpInfo(fileId, orderRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.SetOrderFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | The unique identifier of the file |  |
| **orderRequestDto** | [**OrderRequestDto?**](OrderRequestDto?.md) | Order information for the file | [optional]  |

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
| **200** | Order is set |  -  |
| **401** | Unauthorized |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="startedit"></a>
# **StartEdit**
> StringWrapper StartEdit (int fileId, StartEdit? startEdit = null)

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
    public class StartEditExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var startEdit = new StartEdit?(); // StartEdit? | Parameters for starting file editing (optional) 

            try
            {
                // Start file editing
                StringWrapper result = apiInstance.StartEdit(fileId, startEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.StartEdit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartEditWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start file editing
    ApiResponse<StringWrapper> response = apiInstance.StartEditWithHttpInfo(fileId, startEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.StartEditWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File ID |  |
| **startEdit** | [**StartEdit?**](StartEdit?.md) | Parameters for starting file editing | [optional]  |

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

<a id="startfilling"></a>
# **StartFilling**
> void StartFilling (int fileId)

Starts filling

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
    public class StartFillingExample
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
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID

            try
            {
                // Starts filling
                apiInstance.StartFilling(fileId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesFilesApi.StartFilling: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartFillingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Starts filling
    apiInstance.StartFillingWithHttpInfo(fileId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FilesFilesApi.StartFillingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileId** | **int** | File ID |  |

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var tabId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Tab ID (optional) 
            var docKeyForTrack = some text;  // string? | Document key for tracking (optional) 
            var isFinish = true;  // bool? | Specifies whether to finish file tracking or not (optional) 

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
| **fileId** | **int** | File ID |  |
| **tabId** | **Guid?** | Tab ID | [optional]  |
| **docKeyForTrack** | **string?** | Document key for tracking | [optional]  |
| **isFinish** | **bool?** | Specifies whether to finish file tracking or not | [optional]  |

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
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FilesFilesApi(httpClient, config, httpClientHandler);
            var fileId = 9846;  // int | File ID
            var updateFile = new UpdateFile?(); // UpdateFile? | File (optional) 

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
| **fileId** | **int** | File ID |  |
| **updateFile** | [**UpdateFile?**](UpdateFile?.md) | File | [optional]  |

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

