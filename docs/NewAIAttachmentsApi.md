# DocSpace.API.SDK.Api.AttachmentsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewAiAttachmentsDelete**](#newaiattachmentsdelete) | **DELETE** /api/2.0/ai/attachments/delete | Delete |
| [**NewAiAttachmentsDeleteMany**](#newaiattachmentsdeletemany) | **DELETE** /api/2.0/ai/attachments/delete-many | Delete many |
| [**NewAiAttachmentsGet**](#newaiattachmentsget) | **POST** /api/2.0/ai/attachments/get | Get |
| [**NewAiAttachmentsGetMany**](#newaiattachmentsgetmany) | **POST** /api/2.0/ai/attachments/get-many | Get many |
| [**NewAiAttachmentsLinkToMessage**](#newaiattachmentslinktomessage) | **POST** /api/2.0/ai/attachments/link-to-message | Link to message |
| [**NewAiAttachmentsSaveFile**](#newaiattachmentssavefile) | **POST** /api/2.0/ai/attachments/save-file | Save file |
| [**NewAiAttachmentsSaveFilesMany**](#newaiattachmentssavefilesmany) | **POST** /api/2.0/ai/attachments/save-files-many | Save files many |
| [**NewAiAttachmentsSaveImage**](#newaiattachmentssaveimage) | **POST** /api/2.0/ai/attachments/save-image | Save image |
| [**NewAiAttachmentsSaveImagesMany**](#newaiattachmentssaveimagesmany) | **POST** /api/2.0/ai/attachments/save-images-many | Save images many |

<a id="newaiattachmentsdelete"></a>
# **NewAiAttachmentsDelete**
> NewAiSuccessResponse NewAiAttachmentsDelete (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

### Return type

[**NewAiSuccessResponse**](NewAiSuccessResponse.md)

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
    public class NewAiAttachmentsDeleteExample
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
                NewAiSuccessResponse result = apiInstance.NewAiAttachmentsDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiAttachmentsDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsDeleteWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentsdeletemany"></a>
# **NewAiAttachmentsDeleteMany**
> NewAiSuccessResponse NewAiAttachmentsDeleteMany (List<string> requestBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**NewAiSuccessResponse**](NewAiSuccessResponse.md)

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
    public class NewAiAttachmentsDeleteManyExample
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
                NewAiSuccessResponse result = apiInstance.NewAiAttachmentsDeleteMany(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsDeleteMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsDeleteManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete many
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiAttachmentsDeleteManyWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsDeleteManyWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentsget"></a>
# **NewAiAttachmentsGet**
> NewAiAttachment NewAiAttachmentsGet (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

### Return type

[**NewAiAttachment**](NewAiAttachment.md)

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
    public class NewAiAttachmentsGetExample
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
                NewAiAttachment result = apiInstance.NewAiAttachmentsGet(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get
    ApiResponse<NewAiAttachment> response = apiInstance.NewAiAttachmentsGetWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsGetWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentsgetmany"></a>
# **NewAiAttachmentsGetMany**
> List&lt;NewAiAttachment&gt; NewAiAttachmentsGetMany (List<string> requestBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) |  |  |

### Return type

[**List&lt;NewAiAttachment&gt;**](NewAiAttachment.md)

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
    public class NewAiAttachmentsGetManyExample
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
                List<NewAiAttachment> result = apiInstance.NewAiAttachmentsGetMany(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsGetMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsGetManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get many
    ApiResponse<List<NewAiAttachment>> response = apiInstance.NewAiAttachmentsGetManyWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsGetManyWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentslinktomessage"></a>
# **NewAiAttachmentsLinkToMessage**
> NewAiSuccessResponse NewAiAttachmentsLinkToMessage (NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAttachmentsLinkToMessageRequest** | [**NewAiAttachmentsLinkToMessageRequest**](NewAiAttachmentsLinkToMessageRequest.md) |  |  |

### Return type

[**NewAiSuccessResponse**](NewAiSuccessResponse.md)

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
    public class NewAiAttachmentsLinkToMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var newAiAttachmentsLinkToMessageRequest = new NewAiAttachmentsLinkToMessageRequest(); // NewAiAttachmentsLinkToMessageRequest | 

            try
            {
                // Link to message
                NewAiSuccessResponse result = apiInstance.NewAiAttachmentsLinkToMessage(newAiAttachmentsLinkToMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsLinkToMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsLinkToMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Link to message
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiAttachmentsLinkToMessageWithHttpInfo(newAiAttachmentsLinkToMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsLinkToMessageWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentssavefile"></a>
# **NewAiAttachmentsSaveFile**
> NewAiAttachment NewAiAttachmentsSaveFile (NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAttachmentsSaveFileRequest** | [**NewAiAttachmentsSaveFileRequest**](NewAiAttachmentsSaveFileRequest.md) |  |  |

### Return type

[**NewAiAttachment**](NewAiAttachment.md)

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
    public class NewAiAttachmentsSaveFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var newAiAttachmentsSaveFileRequest = new NewAiAttachmentsSaveFileRequest(); // NewAiAttachmentsSaveFileRequest | 

            try
            {
                // Save file
                NewAiAttachment result = apiInstance.NewAiAttachmentsSaveFile(newAiAttachmentsSaveFileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsSaveFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save file
    ApiResponse<NewAiAttachment> response = apiInstance.NewAiAttachmentsSaveFileWithHttpInfo(newAiAttachmentsSaveFileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveFileWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentssavefilesmany"></a>
# **NewAiAttachmentsSaveFilesMany**
> List&lt;NewAiAttachment&gt; NewAiAttachmentsSaveFilesMany (NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAttachmentsSaveFilesManyRequest** | [**NewAiAttachmentsSaveFilesManyRequest**](NewAiAttachmentsSaveFilesManyRequest.md) |  |  |

### Return type

[**List&lt;NewAiAttachment&gt;**](NewAiAttachment.md)

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
    public class NewAiAttachmentsSaveFilesManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var newAiAttachmentsSaveFilesManyRequest = new NewAiAttachmentsSaveFilesManyRequest(); // NewAiAttachmentsSaveFilesManyRequest | 

            try
            {
                // Save files many
                List<NewAiAttachment> result = apiInstance.NewAiAttachmentsSaveFilesMany(newAiAttachmentsSaveFilesManyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveFilesMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsSaveFilesManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save files many
    ApiResponse<List<NewAiAttachment>> response = apiInstance.NewAiAttachmentsSaveFilesManyWithHttpInfo(newAiAttachmentsSaveFilesManyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveFilesManyWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentssaveimage"></a>
# **NewAiAttachmentsSaveImage**
> NewAiAttachment NewAiAttachmentsSaveImage (NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAttachmentsSaveImageRequest** | [**NewAiAttachmentsSaveImageRequest**](NewAiAttachmentsSaveImageRequest.md) |  |  |

### Return type

[**NewAiAttachment**](NewAiAttachment.md)

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
    public class NewAiAttachmentsSaveImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var newAiAttachmentsSaveImageRequest = new NewAiAttachmentsSaveImageRequest(); // NewAiAttachmentsSaveImageRequest | 

            try
            {
                // Save image
                NewAiAttachment result = apiInstance.NewAiAttachmentsSaveImage(newAiAttachmentsSaveImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsSaveImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save image
    ApiResponse<NewAiAttachment> response = apiInstance.NewAiAttachmentsSaveImageWithHttpInfo(newAiAttachmentsSaveImageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveImageWithHttpInfo: " + e.Message);
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

<a id="newaiattachmentssaveimagesmany"></a>
# **NewAiAttachmentsSaveImagesMany**
> List&lt;NewAiAttachment&gt; NewAiAttachmentsSaveImagesMany (NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAttachmentsSaveImagesManyRequest** | [**NewAiAttachmentsSaveImagesManyRequest**](NewAiAttachmentsSaveImagesManyRequest.md) |  |  |

### Return type

[**List&lt;NewAiAttachment&gt;**](NewAiAttachment.md)

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
    public class NewAiAttachmentsSaveImagesManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AttachmentsApi(httpClient, config, httpClientHandler);
            var newAiAttachmentsSaveImagesManyRequest = new NewAiAttachmentsSaveImagesManyRequest(); // NewAiAttachmentsSaveImagesManyRequest | 

            try
            {
                // Save images many
                List<NewAiAttachment> result = apiInstance.NewAiAttachmentsSaveImagesMany(newAiAttachmentsSaveImagesManyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveImagesMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAttachmentsSaveImagesManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save images many
    ApiResponse<List<NewAiAttachment>> response = apiInstance.NewAiAttachmentsSaveImagesManyWithHttpInfo(newAiAttachmentsSaveImagesManyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AttachmentsApi.NewAiAttachmentsSaveImagesManyWithHttpInfo: " + e.Message);
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

