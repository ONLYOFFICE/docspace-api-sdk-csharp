# DocSpace.API.SDK.Api.AttachmentsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiAttachmentsDelete**](#aiattachmentsdelete) | **DELETE** /api/2.0/ai/attachments/delete | Delete one attachment |
| [**AiAttachmentsDeleteMany**](#aiattachmentsdeletemany) | **DELETE** /api/2.0/ai/attachments/delete-many | Delete many |
| [**AiAttachmentsGet**](#aiattachmentsget) | **POST** /api/2.0/ai/attachments/get | Get one attachment |
| [**AiAttachmentsGetMany**](#aiattachmentsgetmany) | **POST** /api/2.0/ai/attachments/get-many | Get many |
| [**AiAttachmentsLinkToMessage**](#aiattachmentslinktomessage) | **POST** /api/2.0/ai/attachments/link-to-message | Link to message |
| [**AiAttachmentsSaveFile**](#aiattachmentssavefile) | **POST** /api/2.0/ai/attachments/save-file | Save file |
| [**AiAttachmentsSaveFilesMany**](#aiattachmentssavefilesmany) | **POST** /api/2.0/ai/attachments/save-files-many | Save files many |

<a id="aiattachmentsdelete"></a>
# **AiAttachmentsDelete**
> AiSuccessResponse AiAttachmentsDelete (string body)

Permanently deletes one attachment, whether it is still a draft or already bound to a message. The ID is not validated here, so a malformed one surfaces as an error relayed from storage rather than as a 400, and an ID that does not exist answers success without deleting anything. Deleting a bound attachment leaves the message in place without it. The deletion cannot be undone.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | The ID of the attachment to delete, as a bare JSON string. |  |

### Return type

[**AiSuccessResponse**](AiSuccessResponse.md)

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
    public class AiAttachmentsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | The ID of the attachment to delete, as a bare JSON string.

            try
            {
                // Delete one attachment
                AiSuccessResponse result = apiInstance.AiAttachmentsDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete one attachment
    ApiResponse<AiSuccessResponse> response = apiInstance.AiAttachmentsDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsDeleteWithHttpInfo: " + e.Message);
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
| **200** | Confirms the request was accepted, whether or not anything was deleted. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentsdeletemany"></a>
# **AiAttachmentsDeleteMany**
> AiSuccessResponse AiAttachmentsDeleteMany (List<string> requestBody)

Permanently deletes several attachments in one round trip. `ids` is optional and an absent value is treated as an empty list, so a malformed request quietly deletes nothing instead of failing. IDs that do not exist are skipped without being reported, so the answer confirms only that the call was accepted. The deletions cannot be undone.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | The IDs of the attachments to delete, as a bare JSON array of strings. |  |

### Return type

[**AiSuccessResponse**](AiSuccessResponse.md)

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
    public class AiAttachmentsDeleteManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var requestBody = new List<string>(); // List<string> | The IDs of the attachments to delete, as a bare JSON array of strings.

            try
            {
                // Delete many
                AiSuccessResponse result = apiInstance.AiAttachmentsDeleteMany(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsDeleteMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsDeleteManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete many
    ApiResponse<AiSuccessResponse> response = apiInstance.AiAttachmentsDeleteManyWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsDeleteManyWithHttpInfo: " + e.Message);
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
| **200** | Confirms the request was accepted, whether or not anything was deleted. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentsget"></a>
# **AiAttachmentsGet**
> AiAttachment AiAttachmentsGet (string body)

Returns one attachment by its ID, whether it is still a draft or already bound to a message. The ID is required and has to be a non-empty string. An ID that no longer exists is not reported as 404: the answer is a null body with status 200, so treat a missing payload as no such attachment. Use `POST api/2.0/ai/attachments/get-many` to read several at once.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | The ID of the attachment to read, as a bare JSON string. |  |

### Return type

[**AiAttachment**](AiAttachment.md)

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
    public class AiAttachmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | The ID of the attachment to read, as a bare JSON string.

            try
            {
                // Get one attachment
                AiAttachment result = apiInstance.AiAttachmentsGet(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get one attachment
    ApiResponse<AiAttachment> response = apiInstance.AiAttachmentsGetWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsGetWithHttpInfo: " + e.Message);
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
| **200** | The attachment, or a null body when no attachment has that ID. |  -  |
| **400** | The attachment ID is missing. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentsgetmany"></a>
# **AiAttachmentsGetMany**
> List&lt;AiAttachment&gt; AiAttachmentsGetMany (List<string> requestBody)

Returns several attachments in one call, aligned by position with the `ids` that were sent, so the answer can be zipped straight onto the request. An ID that no longer exists leaves its slot empty rather than shortening the list, which is how a caller tells which of them are gone. `ids` has to be present and non-empty - an empty batch is rejected rather than answered with an empty list. Nothing is changed by the call.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | The IDs of the attachments to read, as a bare JSON array of strings. The answer is aligned with this array by position. |  |

### Return type

[**List&lt;AiAttachment&gt;**](AiAttachment.md)

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
    public class AiAttachmentsGetManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var requestBody = new List<string>(); // List<string> | The IDs of the attachments to read, as a bare JSON array of strings. The answer is aligned with this array by position.

            try
            {
                // Get many
                List<AiAttachment> result = apiInstance.AiAttachmentsGetMany(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsGetMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsGetManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get many
    ApiResponse<List<AiAttachment>> response = apiInstance.AiAttachmentsGetManyWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsGetManyWithHttpInfo: " + e.Message);
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
| **200** | The attachments, aligned by position with the IDs that were sent. A missing one leaves its slot empty. |  -  |
| **400** | The list of attachment IDs is malformed. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentslinktomessage"></a>
# **AiAttachmentsLinkToMessage**
> AiSuccessResponse AiAttachmentsLinkToMessage (AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest)

Binds draft attachments to the chat message that owns them, after that message has been persisted, so that deleting the message removes them too. All three of `ids`, `messageId` and `threadId` are required, and the references are verified rather than trusted: an unknown message answers 404, a message that belongs to a different thread answers 400, and attachments that no longer exist answer 404 naming each missing ID. That verification exists because the underlying binding call skips unknown IDs silently, which used to report success for a link that had not happened. Drafts stay unbound until this succeeds.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAttachmentsLinkToMessageRequest** | [**AiAttachmentsLinkToMessageRequest**](AiAttachmentsLinkToMessageRequest.md) |  |  |

### Return type

[**AiSuccessResponse**](AiSuccessResponse.md)

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
    public class AiAttachmentsLinkToMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var aiAttachmentsLinkToMessageRequest = new AiAttachmentsLinkToMessageRequest(); // AiAttachmentsLinkToMessageRequest | 

            try
            {
                // Link to message
                AiSuccessResponse result = apiInstance.AiAttachmentsLinkToMessage(aiAttachmentsLinkToMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsLinkToMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsLinkToMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Link to message
    ApiResponse<AiSuccessResponse> response = apiInstance.AiAttachmentsLinkToMessageWithHttpInfo(aiAttachmentsLinkToMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsLinkToMessageWithHttpInfo: " + e.Message);
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
| **200** | Confirms the attachments are now bound to the message. |  -  |
| **400** | The attachment or message reference is malformed. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | The message or the attachment does not exist. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentssavefile"></a>
# **AiAttachmentsSaveFile**
> AiAttachment AiAttachmentsSaveFile (AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest)

Stores one file attachment as a draft and returns it, so its ID can be attached to a message later. `input` carries the host `path` - the DocSpace entry ID the AI backend resolves server-side - the text `content` already extracted from that file, the ONLYOFFICE numeric file `type`, and optionally a `title`; the text is what the model reads, so this operation does not open the file itself. Archives are refused outright, whatever their declared name says. Drafts are not bound to a conversation until `POST api/2.0/ai/attachments/link-to-message` is called, so an unlinked draft outlives the round that created it.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAttachmentsSaveFileRequest** | [**AiAttachmentsSaveFileRequest**](AiAttachmentsSaveFileRequest.md) |  |  |

### Return type

[**AiAttachment**](AiAttachment.md)

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
    public class AiAttachmentsSaveFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var aiAttachmentsSaveFileRequest = new AiAttachmentsSaveFileRequest(); // AiAttachmentsSaveFileRequest | 

            try
            {
                // Save file
                AiAttachment result = apiInstance.AiAttachmentsSaveFile(aiAttachmentsSaveFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsSaveFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save file
    ApiResponse<AiAttachment> response = apiInstance.AiAttachmentsSaveFileWithHttpInfo(aiAttachmentsSaveFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveFileWithHttpInfo: " + e.Message);
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
| **200** | The stored draft, whose ID links it to a message later. |  -  |
| **400** | The attachment payload is malformed. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentssavefilesmany"></a>
# **AiAttachmentsSaveFilesMany**
> List&lt;AiAttachment&gt; AiAttachmentsSaveFilesMany (AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest)

Stores several file attachments as drafts in one round trip and returns them in the order they were sent. Each entry is validated exactly as the single-file operation validates its `input`, and the first bad one rejects the whole batch with its index named in the message - nothing is stored. `inputs` has to be present and an array: an absent or null value is a malformed request rather than an empty batch, and only an explicit empty array means no files. Follow up with `POST api/2.0/ai/attachments/link-to-message` to bind the drafts to a message.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAttachmentsSaveFilesManyRequest** | [**AiAttachmentsSaveFilesManyRequest**](AiAttachmentsSaveFilesManyRequest.md) |  |  |

### Return type

[**List&lt;AiAttachment&gt;**](AiAttachment.md)

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
    public class AiAttachmentsSaveFilesManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var aiAttachmentsSaveFilesManyRequest = new AiAttachmentsSaveFilesManyRequest(); // AiAttachmentsSaveFilesManyRequest | 

            try
            {
                // Save files many
                List<AiAttachment> result = apiInstance.AiAttachmentsSaveFilesMany(aiAttachmentsSaveFilesManyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveFilesMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsSaveFilesManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save files many
    ApiResponse<List<AiAttachment>> response = apiInstance.AiAttachmentsSaveFilesManyWithHttpInfo(aiAttachmentsSaveFilesManyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveFilesManyWithHttpInfo: " + e.Message);
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
| **200** | The stored drafts, in the order they were sent. |  -  |
| **400** | `inputs` is not an array, or one of its entries is malformed. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

