# DocSpace.API.SDK.Api.AIApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiAiApproveToolCall**](#aiaiapprovetoolcall) | **POST** /api/2.0/ai/ai/approve-tool-call | Approve tool call |
| [**AiAiDenyToolCall**](#aiaidenytoolcall) | **POST** /api/2.0/ai/ai/deny-tool-call | Deny tool call |
| [**AiAiRegenerateStream**](#aiairegeneratestream) | **POST** /api/2.0/ai/ai/regenerate-stream | Regenerate stream |
| [**AiAiSend**](#aiaisend) | **POST** /api/2.0/ai/ai/send | Send |
| [**AiAiSendCustom**](#aiaisendcustom) | **POST** /api/2.0/ai/ai/send-custom | Send custom |
| [**AiAiSendWithStream**](#aiaisendwithstream) | **POST** /api/2.0/ai/ai/send-with-stream | Send with stream |
| [**AiAiSendWithStreamOpenAI**](#aiaisendwithstreamopenai) | **POST** /api/2.0/ai/ai/send-with-stream-openai | Send with stream open ai |

<a id="aiaiapprovetoolcall"></a>
# **AiAiApproveToolCall**
> AiChatEvent AiAiApproveToolCall (AiAiApproveToolCallRequest aiAiApproveToolCallRequest)

Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiApproveToolCallRequest** | [**AiAiApproveToolCallRequest**](AiAiApproveToolCallRequest.md) |  |  |

### Return type

[**AiChatEvent**](AiChatEvent.md)

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
    public class AiAiApproveToolCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiApproveToolCallRequest = new AiAiApproveToolCallRequest(); // AiAiApproveToolCallRequest | 

            try
            {
                // Approve tool call
                AiChatEvent result = apiInstance.AiAiApproveToolCall(aiAiApproveToolCallRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiApproveToolCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiApproveToolCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve tool call
    ApiResponse<AiChatEvent> response = apiInstance.AiAiApproveToolCallWithHttpInfo(aiAiApproveToolCallRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiApproveToolCallWithHttpInfo: " + e.Message);
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

<a id="aiaidenytoolcall"></a>
# **AiAiDenyToolCall**
> AiChatEvent AiAiDenyToolCall (AiAiToolCallData aiAiToolCallData)

Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiToolCallData** | [**AiAiToolCallData**](AiAiToolCallData.md) | Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields). |  |

### Return type

[**AiChatEvent**](AiChatEvent.md)

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
    public class AiAiDenyToolCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiToolCallData = new AiAiToolCallData(); // AiAiToolCallData | Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).

            try
            {
                // Deny tool call
                AiChatEvent result = apiInstance.AiAiDenyToolCall(aiAiToolCallData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiDenyToolCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiDenyToolCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deny tool call
    ApiResponse<AiChatEvent> response = apiInstance.AiAiDenyToolCallWithHttpInfo(aiAiToolCallData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiDenyToolCallWithHttpInfo: " + e.Message);
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

<a id="aiairegeneratestream"></a>
# **AiAiRegenerateStream**
> AiChatEvent AiAiRegenerateStream (AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest)

Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiRegenerateStreamRequest** | [**AiAiRegenerateStreamRequest**](AiAiRegenerateStreamRequest.md) |  |  |

### Return type

[**AiChatEvent**](AiChatEvent.md)

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
    public class AiAiRegenerateStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiRegenerateStreamRequest = new AiAiRegenerateStreamRequest(); // AiAiRegenerateStreamRequest | 

            try
            {
                // Regenerate stream
                AiChatEvent result = apiInstance.AiAiRegenerateStream(aiAiRegenerateStreamRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiRegenerateStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiRegenerateStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate stream
    ApiResponse<AiChatEvent> response = apiInstance.AiAiRegenerateStreamWithHttpInfo(aiAiRegenerateStreamRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiRegenerateStreamWithHttpInfo: " + e.Message);
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

<a id="aiaisend"></a>
# **AiAiSend**
> AiThreadMessageLike AiAiSend (AiAiSendRequest aiAiSendRequest)

Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiSendRequest** | [**AiAiSendRequest**](AiAiSendRequest.md) |  |  |

### Return type

[**AiThreadMessageLike**](AiThreadMessageLike.md)

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
    public class AiAiSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiSendRequest = new AiAiSendRequest(); // AiAiSendRequest | 

            try
            {
                // Send
                AiThreadMessageLike result = apiInstance.AiAiSend(aiAiSendRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiSend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiSendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send
    ApiResponse<AiThreadMessageLike> response = apiInstance.AiAiSendWithHttpInfo(aiAiSendRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiSendWithHttpInfo: " + e.Message);
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

<a id="aiaisendcustom"></a>
# **AiAiSendCustom**
> AiThreadMessageLike AiAiSendCustom (AiAiSendCustomRequest aiAiSendCustomRequest)

Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiSendCustomRequest** | [**AiAiSendCustomRequest**](AiAiSendCustomRequest.md) |  |  |

### Return type

[**AiThreadMessageLike**](AiThreadMessageLike.md)

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
    public class AiAiSendCustomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiSendCustomRequest = new AiAiSendCustomRequest(); // AiAiSendCustomRequest | 

            try
            {
                // Send custom
                AiThreadMessageLike result = apiInstance.AiAiSendCustom(aiAiSendCustomRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiSendCustom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiSendCustomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send custom
    ApiResponse<AiThreadMessageLike> response = apiInstance.AiAiSendCustomWithHttpInfo(aiAiSendCustomRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiSendCustomWithHttpInfo: " + e.Message);
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

<a id="aiaisendwithstream"></a>
# **AiAiSendWithStream**
> AiChatEvent AiAiSendWithStream (AiAiSendStreamBody aiAiSendStreamBody)

Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiSendStreamBody** | [**AiAiSendStreamBody**](AiAiSendStreamBody.md) | Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`. |  |

### Return type

[**AiChatEvent**](AiChatEvent.md)

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
    public class AiAiSendWithStreamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiSendStreamBody = new AiAiSendStreamBody(); // AiAiSendStreamBody | Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.

            try
            {
                // Send with stream
                AiChatEvent result = apiInstance.AiAiSendWithStream(aiAiSendStreamBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiSendWithStream: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiSendWithStreamWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send with stream
    ApiResponse<AiChatEvent> response = apiInstance.AiAiSendWithStreamWithHttpInfo(aiAiSendStreamBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiSendWithStreamWithHttpInfo: " + e.Message);
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

<a id="aiaisendwithstreamopenai"></a>
# **AiAiSendWithStreamOpenAI**
> AiOpenAIStreamChunk AiAiSendWithStreamOpenAI (AiAiSendStreamBody aiAiSendStreamBody)

The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAiSendStreamBody** | [**AiAiSendStreamBody**](AiAiSendStreamBody.md) | Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`. |  |

### Return type

[**AiOpenAIStreamChunk**](AiOpenAIStreamChunk.md)

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
    public class AiAiSendWithStreamOpenAIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AIApi(httpClient, config, httpClientHandler);
            var aiAiSendStreamBody = new AiAiSendStreamBody(); // AiAiSendStreamBody | Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.

            try
            {
                // Send with stream open ai
                AiOpenAIStreamChunk result = apiInstance.AiAiSendWithStreamOpenAI(aiAiSendStreamBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AIApi.AiAiSendWithStreamOpenAI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAiSendWithStreamOpenAIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send with stream open ai
    ApiResponse<AiOpenAIStreamChunk> response = apiInstance.AiAiSendWithStreamOpenAIWithHttpInfo(aiAiSendStreamBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AIApi.AiAiSendWithStreamOpenAIWithHttpInfo: " + e.Message);
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

