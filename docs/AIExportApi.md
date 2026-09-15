# DocSpace.API.SDK.Api.ExportApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiExportTextToDocx**](#aiexporttexttodocx) | **POST** /api/2.0/ai/text-to-docx | Start markdown → docx export |

<a id="aiexporttexttodocx"></a>
# **AiExportTextToDocx**
> AiExportTextToDocx202Response AiExportTextToDocx (AiExportTextToDocxRequest aiExportTextToDocxRequest)

Queues a markdown-to-docx export and answers 202 as soon as the job is accepted, without waiting for it. `title`, `content` and `folderId` are all required, and a `content` of only whitespace counts as missing even though it is not empty. The conversion runs in the AI worker, which saves the .docx into the target folder - an agent room resolves to its own result-storage subfolder - so there is nothing to poll here: completion arrives as the ordinary folder-modified socket event. This route accepts a body of up to 15 MB rather than the 100 KB the rest of the API allows, because a whole thread transcript is sent in one request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-export-text-to-docx/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiExportTextToDocxRequest** | [**AiExportTextToDocxRequest**](AiExportTextToDocxRequest.md) |  |  |

### Return type

[**AiExportTextToDocx202Response**](AiExportTextToDocx202Response.md)

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
    public class AiExportTextToDocxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExportApi(httpClient, config, httpClientHandler);
            var aiExportTextToDocxRequest = new AiExportTextToDocxRequest(); // AiExportTextToDocxRequest | 

            try
            {
                // Start markdown → docx export
                AiExportTextToDocx202Response result = apiInstance.AiExportTextToDocx(aiExportTextToDocxRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportApi.AiExportTextToDocx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiExportTextToDocxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start markdown → docx export
    ApiResponse<AiExportTextToDocx202Response> response = apiInstance.AiExportTextToDocxWithHttpInfo(aiExportTextToDocxRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportApi.AiExportTextToDocxWithHttpInfo: " + e.Message);
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
| **202** | Confirms the export was queued. The .docx arrives in the target folder later, announced by a folder-modified socket event. |  -  |
| **400** | `title`, `content` or `folderId` is missing. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The transcript is larger than 15 MB, this route's own parser limit. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

