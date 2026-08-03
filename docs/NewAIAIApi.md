# DocSpace.API.SDK.Api.AIApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewAiAiApproveToolCall**](#newaiaiapprovetoolcall) | **POST** /api/2.0/ai/ai/approve-tool-call | Approve tool call |
| [**NewAiAiDenyToolCall**](#newaiaidenytoolcall) | **POST** /api/2.0/ai/ai/deny-tool-call | Deny tool call |
| [**NewAiAiRegenerateStream**](#newaiairegeneratestream) | **POST** /api/2.0/ai/ai/regenerate-stream | Regenerate stream |
| [**NewAiAiSend**](#newaiaisend) | **POST** /api/2.0/ai/ai/send | Send |
| [**NewAiAiSendCustom**](#newaiaisendcustom) | **POST** /api/2.0/ai/ai/send-custom | Send custom |
| [**NewAiAiSendWithStream**](#newaiaisendwithstream) | **POST** /api/2.0/ai/ai/send-with-stream | Send with stream |
| [**NewAiAiSendWithStreamOpenAI**](#newaiaisendwithstreamopenai) | **POST** /api/2.0/ai/ai/send-with-stream-openai | Send with stream open ai |

<a id="newaiaiapprovetoolcall"></a>
# **NewAiAiApproveToolCall**
> NewAiChatEvent NewAiAiApproveToolCall (NewAiAiApproveToolCallRequest newAiAiApproveToolCallRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-approve-tool-call/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiApproveToolCallRequest** | [**NewAiAiApproveToolCallRequest**](NewAiAiApproveToolCallRequest.md) |  |  |

### Return type

[**NewAiChatEvent**](NewAiChatEvent.md)

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
    public class NewAiAiApproveToolCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiApproveToolCallRequest = new NewAiAiApproveToolCallRequest(); // NewAiAiApproveToolCallRequest | 

            try
            {
                // Approve tool call
                NewAiChatEvent result = apiInstance.NewAiAiApproveToolCall(newAiAiApproveToolCallRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiApproveToolCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiApproveToolCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve tool call
    ApiResponse<NewAiChatEvent> response = apiInstance.NewAiAiApproveToolCallWithHttpInfo(newAiAiApproveToolCallRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiApproveToolCallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/x-ndjson, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Newline-delimited stream of chat events — one JSON `ChatEvent` object per line. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiaidenytoolcall"></a>
# **NewAiAiDenyToolCall**
> NewAiChatEvent NewAiAiDenyToolCall (NewAiAiToolCallData newAiAiToolCallData)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-deny-tool-call/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiToolCallData** | [**NewAiAiToolCallData**](NewAiAiToolCallData.md) |  |  |

### Return type

[**NewAiChatEvent**](NewAiChatEvent.md)

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
    public class NewAiAiDenyToolCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiToolCallData = new NewAiAiToolCallData(); // NewAiAiToolCallData | 

            try
            {
                // Deny tool call
                NewAiChatEvent result = apiInstance.NewAiAiDenyToolCall(newAiAiToolCallData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiDenyToolCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiDenyToolCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deny tool call
    ApiResponse<NewAiChatEvent> response = apiInstance.NewAiAiDenyToolCallWithHttpInfo(newAiAiToolCallData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiDenyToolCallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/x-ndjson, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Newline-delimited stream of chat events — one JSON `ChatEvent` object per line. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiairegeneratestream"></a>
# **NewAiAiRegenerateStream**
> NewAiChatEvent NewAiAiRegenerateStream (NewAiAiRegenerateStreamRequest newAiAiRegenerateStreamRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-regenerate-stream/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiRegenerateStreamRequest** | [**NewAiAiRegenerateStreamRequest**](NewAiAiRegenerateStreamRequest.md) |  |  |

### Return type

[**NewAiChatEvent**](NewAiChatEvent.md)

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
    public class NewAiAiRegenerateStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiRegenerateStreamRequest = new NewAiAiRegenerateStreamRequest(); // NewAiAiRegenerateStreamRequest | 

            try
            {
                // Regenerate stream
                NewAiChatEvent result = apiInstance.NewAiAiRegenerateStream(newAiAiRegenerateStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiRegenerateStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiRegenerateStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate stream
    ApiResponse<NewAiChatEvent> response = apiInstance.NewAiAiRegenerateStreamWithHttpInfo(newAiAiRegenerateStreamRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiRegenerateStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/x-ndjson, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Newline-delimited stream of chat events — one JSON `ChatEvent` object per line. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiaisend"></a>
# **NewAiAiSend**
> NewAiThreadMessageLike NewAiAiSend (NewAiAiSendRequest newAiAiSendRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiSendRequest** | [**NewAiAiSendRequest**](NewAiAiSendRequest.md) |  |  |

### Return type

[**NewAiThreadMessageLike**](NewAiThreadMessageLike.md)

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
    public class NewAiAiSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiSendRequest = new NewAiAiSendRequest(); // NewAiAiSendRequest | 

            try
            {
                // Send
                NewAiThreadMessageLike result = apiInstance.NewAiAiSend(newAiAiSendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiSend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiSendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send
    ApiResponse<NewAiThreadMessageLike> response = apiInstance.NewAiAiSendWithHttpInfo(newAiAiSendRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiSendWithHttpInfo: " + e.Message);
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

<a id="newaiaisendcustom"></a>
# **NewAiAiSendCustom**
> NewAiThreadMessageLike NewAiAiSendCustom (NewAiAiSendCustomRequest newAiAiSendCustomRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-custom/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiSendCustomRequest** | [**NewAiAiSendCustomRequest**](NewAiAiSendCustomRequest.md) |  |  |

### Return type

[**NewAiThreadMessageLike**](NewAiThreadMessageLike.md)

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
    public class NewAiAiSendCustomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiSendCustomRequest = new NewAiAiSendCustomRequest(); // NewAiAiSendCustomRequest | 

            try
            {
                // Send custom
                NewAiThreadMessageLike result = apiInstance.NewAiAiSendCustom(newAiAiSendCustomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiSendCustom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiSendCustomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send custom
    ApiResponse<NewAiThreadMessageLike> response = apiInstance.NewAiAiSendCustomWithHttpInfo(newAiAiSendCustomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiSendCustomWithHttpInfo: " + e.Message);
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

<a id="newaiaisendwithstream"></a>
# **NewAiAiSendWithStream**
> NewAiChatEvent NewAiAiSendWithStream (NewAiAiSendStreamBody newAiAiSendStreamBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiSendStreamBody** | [**NewAiAiSendStreamBody**](NewAiAiSendStreamBody.md) |  |  |

### Return type

[**NewAiChatEvent**](NewAiChatEvent.md)

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
    public class NewAiAiSendWithStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiSendStreamBody = new NewAiAiSendStreamBody(); // NewAiAiSendStreamBody | 

            try
            {
                // Send with stream
                NewAiChatEvent result = apiInstance.NewAiAiSendWithStream(newAiAiSendStreamBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiSendWithStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiSendWithStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send with stream
    ApiResponse<NewAiChatEvent> response = apiInstance.NewAiAiSendWithStreamWithHttpInfo(newAiAiSendStreamBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiSendWithStreamWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/x-ndjson, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Newline-delimited stream of chat events — one JSON `ChatEvent` object per line. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="newaiaisendwithstreamopenai"></a>
# **NewAiAiSendWithStreamOpenAI**
> NewAiOpenAIStreamChunk NewAiAiSendWithStreamOpenAI (NewAiAiSendStreamBody newAiAiSendStreamBody)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-ai-send-with-stream-open-ai/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiAiSendStreamBody** | [**NewAiAiSendStreamBody**](NewAiAiSendStreamBody.md) |  |  |

### Return type

[**NewAiOpenAIStreamChunk**](NewAiOpenAIStreamChunk.md)

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
    public class NewAiAiSendWithStreamOpenAIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var newAiAiSendStreamBody = new NewAiAiSendStreamBody(); // NewAiAiSendStreamBody | 

            try
            {
                // Send with stream open ai
                NewAiOpenAIStreamChunk result = apiInstance.NewAiAiSendWithStreamOpenAI(newAiAiSendStreamBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.NewAiAiSendWithStreamOpenAI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiAiSendWithStreamOpenAIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send with stream open ai
    ApiResponse<NewAiOpenAIStreamChunk> response = apiInstance.NewAiAiSendWithStreamOpenAIWithHttpInfo(newAiAiSendStreamBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.NewAiAiSendWithStreamOpenAIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/event-stream, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Server-sent events stream of OpenAI `chat.completion.chunk` objects, terminated by a `[DONE]` sentinel. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

