# DocSpace.API.SDK.Api.DocsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConvertFile**](#convertfile) | **POST** /api/2.0/docs/converter | Convert a file |
| [**RunBuilderScript**](#runbuilderscript) | **POST** /api/2.0/docs/builder | Run a document builder script |

<a id="convertfile"></a>
# **ConvertFile**
> FileWrapper ConvertFile (ConvertFileRequestDto? convertFileRequestDto = null)

Converts a portal file into another format and saves the result as a new file, answering with that file. The  caller needs read access to a source that may be copied and the right to create files in `folderId`; without  `folderId` the result goes to the My documents section of the caller, so a guest, who has none, has to pass  it. A file in a private room or in a room with a watermark is not converted, as it would leave the room without  its protection, and no result is saved into such a room. `outputtype` is the only parameter a plain  conversion needs; the other fields are passed to the document service under its own names, while the source  format, name and cache key are taken from the file. The call is mutating and not idempotent: the source is kept,  and each call adds another file under a free name. It answers once the conversion is done, so a large file keeps  the request open. Only files stored in the portal itself are accepted. To convert while copying into another  folder, a third-party one included, use `POST api/2.0/files/file/{fileId}/copyas`; to convert into the portal's  own editable format beside the source, use `PUT api/2.0/files/file/{fileId}/checkconversion`. A missing or  unsupported `outputtype` is refused with 400, and so is a source the document service rejects: a wrong or  missing `password`, or a file too large to convert; retrying the same request will not help. Missing access or a  protected room is refused with 403 and an unknown file or folder with 404, both before any conversion starts. A  result that does not fit the storage quota of the portal, the room or the caller is refused with 402. A  conversion the document service fails is answered with 502: the service may be down or the file damaged; a retry  helps only in the first case.  Raises the `file.created` webhook.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/convert-file/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **convertFileRequestDto** | [**ConvertFileRequestDto?**](ConvertFileRequestDto.md) | What to convert, where to keep the result, and the parameters the document service is handed. Everything below the  first two fields is the contract of the document service itself, named and shaped exactly as it names it, so that  the portal passes the request on rather than translating it. What the portal can read off the file - its format,  its name and the key of its revision - is not asked for and cannot be overridden. | [optional]  |

### Return type

[**FileWrapper**](FileWrapper.md)

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
    public class ConvertFileExample
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
            var apiInstance = new DocsApi(httpClient, config, httpClientHandler);
            var convertFileRequestDto = new ConvertFileRequestDto?(); // ConvertFileRequestDto? | What to convert, where to keep the result, and the parameters the document service is handed. Everything below the  first two fields is the contract of the document service itself, named and shaped exactly as it names it, so that  the portal passes the request on rather than translating it. What the portal can read off the file - its format,  its name and the key of its revision - is not asked for and cannot be overridden. (optional) 

            try
            {
                // Convert a file
                FileWrapper result = apiInstance.ConvertFile(convertFileRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocsApi.ConvertFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConvertFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Convert a file
    ApiResponse<FileWrapper> response = apiInstance.ConvertFileWithHttpInfo(convertFileRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocsApi.ConvertFileWithHttpInfo: " + e.Message);
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
| **200** | The converted file, as it was saved in the portal |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | `outputtype` is missing or the file cannot be converted to it, `folderId` is missing for a caller without My documents, or the document service rejects the source: a wrong or missing password, or a file too large |  -  |
| **402** | The result does not fit the storage quota of the portal, the room or the caller |  -  |
| **403** | You cannot read or copy the file or create files in the folder, the file lies in a private room or in a room with a watermark, or the folder lies in a private room or in a room with a watermark |  -  |
| **404** | The file or the folder does not exist |  -  |
| **502** | The document service is unreachable or failed the conversion without naming the reason; the source may be damaged |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="runbuilderscript"></a>
# **RunBuilderScript**
> FileOperationWrapper RunBuilderScript (RunBuilderScriptRequestDto? runBuilderScriptRequestDto = null)

Queues a background run of a document builder script and answers with the operation just started. The script  names portal files by identifier - `builder.OpenFile(1234)` - where the document builder documentation writes  an address; only portal files can be opened, and none from a private room or a room with a watermark, nor is a  result saved into such a room. A script may call OpenFile and SaveFile at most 20 times each, counting every  call written in it. The caller needs edit access to every file the script opens, which may also be copied, and  to each file `outputs` replaces, which must not be locked or open in an editor, and the right to create files in  each folder a result is saved into. Each file the script saves goes where `outputs` says, keyed by the name  given to SaveFile: `fileId` stores it as a new version of that file, `folderId` as a new file there; an unlisted  file goes to `folderId` or to the folder of the opened file. Each entry of `outputs` names exactly one of  `fileId` and `folderId`; `title` goes only with `folderId`, since a replaced file keeps its title, and a result  stored over `fileId` has to be in that file's format. The call is not idempotent: each call is a new run. Poll  `GET api/2.0/files/fileops` with the returned `id` until the operation reports `finished`: `files` then lists  the saved files, a replaced one with its new version, including those saved before a failure, and `error` the  reason a failed build gave. A build that has not finished after 10 minutes is given up and reported as failed. A  caller runs one script at a time: a new request while an earlier one is queued or running is refused with 403,  so wait for `finished` before starting the next. For a plain format change use `POST api/2.0/docs/converter`.  What can be refused in advance fails at once with 400, 403 or 404.  Raises the `file.created` and `file.updated` webhooks for each file the queued script saves: `file.created` for a new file, `file.updated` for an existing one.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/run-builder-script/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runBuilderScriptRequestDto** | [**RunBuilderScriptRequestDto?**](RunBuilderScriptRequestDto.md) | The document builder script to run and where to put what it produces. | [optional]  |

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
    public class RunBuilderScriptExample
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
            var apiInstance = new DocsApi(httpClient, config, httpClientHandler);
            var runBuilderScriptRequestDto = new RunBuilderScriptRequestDto?(); // RunBuilderScriptRequestDto? | The document builder script to run and where to put what it produces. (optional) 

            try
            {
                // Run a document builder script
                FileOperationWrapper result = apiInstance.RunBuilderScript(runBuilderScriptRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocsApi.RunBuilderScript: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunBuilderScriptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Run a document builder script
    ApiResponse<FileOperationWrapper> response = apiInstance.RunBuilderScriptWithHttpInfo(runBuilderScriptRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocsApi.RunBuilderScriptWithHttpInfo: " + e.Message);
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
| **200** | The queued document builder operation to poll |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The script or the argument is malformed or too long, the script calls OpenFile or SaveFile too often, a file is addressed by an address, an `outputs` entry breaks the rules above, or a saved file has nowhere to go |  -  |
| **403** | You cannot edit or copy a file the script opens or write a result, a file the script opens lies in a private room or in a room with a watermark, the file to replace or a target folder lies in a private room or in a room with a watermark, the file to replace is locked, being edited or in the trash, or another script of yours is still queued or running |  -  |
| **404** | A file the script opens or replaces, or a target folder, does not exist |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

