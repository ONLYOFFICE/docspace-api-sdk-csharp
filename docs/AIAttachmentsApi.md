# DocSpace.API.SDK.Api.AttachmentsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiAttachmentsDelete**](#aiattachmentsdelete) | **DELETE** /api/2.0/ai/attachments/delete | Delete |
| [**AiAttachmentsDeleteMany**](#aiattachmentsdeletemany) | **DELETE** /api/2.0/ai/attachments/delete-many | Delete many |
| [**AiAttachmentsGet**](#aiattachmentsget) | **POST** /api/2.0/ai/attachments/get | Get |
| [**AiAttachmentsGetMany**](#aiattachmentsgetmany) | **POST** /api/2.0/ai/attachments/get-many | Get many |
| [**AiAttachmentsLinkToMessage**](#aiattachmentslinktomessage) | **POST** /api/2.0/ai/attachments/link-to-message | Link to message |
| [**AiAttachmentsSaveFile**](#aiattachmentssavefile) | **POST** /api/2.0/ai/attachments/save-file | Save file |
| [**AiAttachmentsSaveFilesMany**](#aiattachmentssavefilesmany) | **POST** /api/2.0/ai/attachments/save-files-many | Save files many |
| [**AiAttachmentsSaveImage**](#aiattachmentssaveimage) | **POST** /api/2.0/ai/attachments/save-image | Save image |
| [**AiAttachmentsSaveImagesMany**](#aiattachmentssaveimagesmany) | **POST** /api/2.0/ai/attachments/save-images-many | Save images many |

<a id="aiattachmentsdelete"></a>
# **AiAttachmentsDelete**
> AiSuccessResponse AiAttachmentsDelete (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

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
            var body = "body_example";  // string | 

            try
            {
                // Delete
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
    // Delete
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentsdeletemany"></a>
# **AiAttachmentsDeleteMany**
> AiSuccessResponse AiAttachmentsDeleteMany (List<string> requestBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

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
            var requestBody = new List<string>(); // List<string> | 

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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentsget"></a>
# **AiAttachmentsGet**
> AiAttachment AiAttachmentsGet (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

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
            var body = "body_example";  // string | 

            try
            {
                // Get
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
    // Get
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentsgetmany"></a>
# **AiAttachmentsGetMany**
> List&lt;AiAttachment&gt; AiAttachmentsGetMany (List<string> requestBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

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
            var requestBody = new List<string>(); // List<string> | 

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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentslinktomessage"></a>
# **AiAttachmentsLinkToMessage**
> AiSuccessResponse AiAttachmentsLinkToMessage (AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest)



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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentssavefile"></a>
# **AiAttachmentsSaveFile**
> AiAttachment AiAttachmentsSaveFile (AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest)



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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentssavefilesmany"></a>
# **AiAttachmentsSaveFilesMany**
> List&lt;AiAttachment&gt; AiAttachmentsSaveFilesMany (AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest)



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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentssaveimage"></a>
# **AiAttachmentsSaveImage**
> AiAttachment AiAttachmentsSaveImage (AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAttachmentsSaveImageRequest** | [**AiAttachmentsSaveImageRequest**](AiAttachmentsSaveImageRequest.md) |  |  |

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
    public class AiAttachmentsSaveImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var aiAttachmentsSaveImageRequest = new AiAttachmentsSaveImageRequest(); // AiAttachmentsSaveImageRequest | 

            try
            {
                // Save image
                AiAttachment result = apiInstance.AiAttachmentsSaveImage(aiAttachmentsSaveImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsSaveImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save image
    ApiResponse<AiAttachment> response = apiInstance.AiAttachmentsSaveImageWithHttpInfo(aiAttachmentsSaveImageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveImageWithHttpInfo: " + e.Message);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiattachmentssaveimagesmany"></a>
# **AiAttachmentsSaveImagesMany**
> List&lt;AiAttachment&gt; AiAttachmentsSaveImagesMany (AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAttachmentsSaveImagesManyRequest** | [**AiAttachmentsSaveImagesManyRequest**](AiAttachmentsSaveImagesManyRequest.md) |  |  |

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
    public class AiAttachmentsSaveImagesManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var aiAttachmentsSaveImagesManyRequest = new AiAttachmentsSaveImagesManyRequest(); // AiAttachmentsSaveImagesManyRequest | 

            try
            {
                // Save images many
                List<AiAttachment> result = apiInstance.AiAttachmentsSaveImagesMany(aiAttachmentsSaveImagesManyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveImagesMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAttachmentsSaveImagesManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save images many
    ApiResponse<List<AiAttachment>> response = apiInstance.AiAttachmentsSaveImagesManyWithHttpInfo(aiAttachmentsSaveImagesManyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.AiAttachmentsSaveImagesManyWithHttpInfo: " + e.Message);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

