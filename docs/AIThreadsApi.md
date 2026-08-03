# DocSpace.API.SDK.Api.ThreadsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiThreadsAppendUserMessage**](#aithreadsappendusermessage) | **POST** /api/2.0/ai/threads/append-user-message | Append user message |
| [**AiThreadsClearMessages**](#aithreadsclearmessages) | **DELETE** /api/2.0/ai/threads/clear-messages | Clear messages |
| [**AiThreadsCreate**](#aithreadscreate) | **POST** /api/2.0/ai/threads/create | Create |
| [**AiThreadsDelete**](#aithreadsdelete) | **DELETE** /api/2.0/ai/threads/delete | Delete |
| [**AiThreadsDeleteMessage**](#aithreadsdeletemessage) | **DELETE** /api/2.0/ai/threads/delete-message | Delete message |
| [**AiThreadsGetById**](#aithreadsgetbyid) | **GET** /api/2.0/ai/threads/get-by-id | Get by id |
| [**AiThreadsGetMessageById**](#aithreadsgetmessagebyid) | **GET** /api/2.0/ai/threads/get-message-by-id | Get message by id |
| [**AiThreadsList**](#aithreadslist) | **GET** /api/2.0/ai/threads/list | List |
| [**AiThreadsOpenOrCreate**](#aithreadsopenorcreate) | **POST** /api/2.0/ai/threads/open-or-create | Open or create |
| [**AiThreadsReadMessages**](#aithreadsreadmessages) | **GET** /api/2.0/ai/threads/read-messages | Read messages |
| [**AiThreadsRegenerateTitle**](#aithreadsregeneratetitle) | **POST** /api/2.0/ai/threads/regenerate-title | Regenerate title |
| [**AiThreadsRename**](#aithreadsrename) | **PUT** /api/2.0/ai/threads/rename | Rename |
| [**AiThreadsTouch**](#aithreadstouch) | **POST** /api/2.0/ai/threads/touch | Touch |
| [**AiThreadsUpdateMessage**](#aithreadsupdatemessage) | **PUT** /api/2.0/ai/threads/update-message | Update message |

<a id="aithreadsappendusermessage"></a>
# **AiThreadsAppendUserMessage**
> AiThreadMessageLike AiThreadsAppendUserMessage (AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiThreadsAppendUserMessageRequest** | [**AiThreadsAppendUserMessageRequest**](AiThreadsAppendUserMessageRequest.md) |  |  |

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
    public class AiThreadsAppendUserMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiThreadsAppendUserMessageRequest = new AiThreadsAppendUserMessageRequest(); // AiThreadsAppendUserMessageRequest | 

            try
            {
                // Append user message
                AiThreadMessageLike result = apiInstance.AiThreadsAppendUserMessage(aiThreadsAppendUserMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsAppendUserMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsAppendUserMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Append user message
    ApiResponse<AiThreadMessageLike> response = apiInstance.AiThreadsAppendUserMessageWithHttpInfo(aiThreadsAppendUserMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsAppendUserMessageWithHttpInfo: " + e.Message);
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

<a id="aithreadsclearmessages"></a>
# **AiThreadsClearMessages**
> AiSuccessResponse AiThreadsClearMessages (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/).

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
    public class AiThreadsClearMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | 

            try
            {
                // Clear messages
                AiSuccessResponse result = apiInstance.AiThreadsClearMessages(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsClearMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsClearMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear messages
    ApiResponse<AiSuccessResponse> response = apiInstance.AiThreadsClearMessagesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsClearMessagesWithHttpInfo: " + e.Message);
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

<a id="aithreadscreate"></a>
# **AiThreadsCreate**
> AiThread AiThreadsCreate (AiThreadsCreateRequest aiThreadsCreateRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiThreadsCreateRequest** | [**AiThreadsCreateRequest**](AiThreadsCreateRequest.md) |  |  |

### Return type

[**AiThread**](AiThread.md)

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
    public class AiThreadsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiThreadsCreateRequest = new AiThreadsCreateRequest(); // AiThreadsCreateRequest | 

            try
            {
                // Create
                AiThread result = apiInstance.AiThreadsCreate(aiThreadsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<AiThread> response = apiInstance.AiThreadsCreateWithHttpInfo(aiThreadsCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsCreateWithHttpInfo: " + e.Message);
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

<a id="aithreadsdelete"></a>
# **AiThreadsDelete**
> AiSuccessResponse AiThreadsDelete (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/).

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
    public class AiThreadsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | 

            try
            {
                // Delete
                AiSuccessResponse result = apiInstance.AiThreadsDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<AiSuccessResponse> response = apiInstance.AiThreadsDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsDeleteWithHttpInfo: " + e.Message);
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

<a id="aithreadsdeletemessage"></a>
# **AiThreadsDeleteMessage**
> AiSuccessResponse AiThreadsDeleteMessage (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/).

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
    public class AiThreadsDeleteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | 

            try
            {
                // Delete message
                AiSuccessResponse result = apiInstance.AiThreadsDeleteMessage(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsDeleteMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsDeleteMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete message
    ApiResponse<AiSuccessResponse> response = apiInstance.AiThreadsDeleteMessageWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsDeleteMessageWithHttpInfo: " + e.Message);
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

<a id="aithreadsgetbyid"></a>
# **AiThreadsGetById**
> AiThread AiThreadsGetById (string threadId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threadId** | **string** |  |  |

### Return type

[**AiThread**](AiThread.md)

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
    public class AiThreadsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var threadId = "threadId_example";  // string | 

            try
            {
                // Get by id
                AiThread result = apiInstance.AiThreadsGetById(threadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get by id
    ApiResponse<AiThread> response = apiInstance.AiThreadsGetByIdWithHttpInfo(threadId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsGetByIdWithHttpInfo: " + e.Message);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aithreadsgetmessagebyid"></a>
# **AiThreadsGetMessageById**
> AiThreadMessageLike AiThreadsGetMessageById (string messageId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |

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
    public class AiThreadsGetMessageByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var messageId = "messageId_example";  // string | 

            try
            {
                // Get message by id
                AiThreadMessageLike result = apiInstance.AiThreadsGetMessageById(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsGetMessageById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsGetMessageByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get message by id
    ApiResponse<AiThreadMessageLike> response = apiInstance.AiThreadsGetMessageByIdWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsGetMessageByIdWithHttpInfo: " + e.Message);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aithreadslist"></a>
# **AiThreadsList**
> List&lt;AiThread&gt; AiThreadsList (string entityId, string count, string cursor, string query)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |
| **count** | **string** |  |  |
| **cursor** | **string** |  |  |
| **query** | **string** |  |  |

### Return type

[**List&lt;AiThread&gt;**](AiThread.md)

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
    public class AiThreadsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 
            var count = "count_example";  // string | 
            var cursor = "cursor_example";  // string | 
            var query = "query_example";  // string | 

            try
            {
                // List
                List<AiThread> result = apiInstance.AiThreadsList(entityId, count, cursor, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List
    ApiResponse<List<AiThread>> response = apiInstance.AiThreadsListWithHttpInfo(entityId, count, cursor, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsListWithHttpInfo: " + e.Message);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aithreadsopenorcreate"></a>
# **AiThreadsOpenOrCreate**
> AiOpenOrCreateResult AiThreadsOpenOrCreate (AiOpenOrCreateInput aiOpenOrCreateInput)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiOpenOrCreateInput** | [**AiOpenOrCreateInput**](AiOpenOrCreateInput.md) | Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`. |  |

### Return type

[**AiOpenOrCreateResult**](AiOpenOrCreateResult.md)

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
    public class AiThreadsOpenOrCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiOpenOrCreateInput = new AiOpenOrCreateInput(); // AiOpenOrCreateInput | Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.

            try
            {
                // Open or create
                AiOpenOrCreateResult result = apiInstance.AiThreadsOpenOrCreate(aiOpenOrCreateInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsOpenOrCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsOpenOrCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Open or create
    ApiResponse<AiOpenOrCreateResult> response = apiInstance.AiThreadsOpenOrCreateWithHttpInfo(aiOpenOrCreateInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsOpenOrCreateWithHttpInfo: " + e.Message);
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

<a id="aithreadsreadmessages"></a>
# **AiThreadsReadMessages**
> List&lt;AiThreadMessageLike&gt; AiThreadsReadMessages (string threadId, string count, string cursor)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threadId** | **string** |  |  |
| **count** | **string** |  |  |
| **cursor** | **string** |  |  |

### Return type

[**List&lt;AiThreadMessageLike&gt;**](AiThreadMessageLike.md)

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
    public class AiThreadsReadMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var threadId = "threadId_example";  // string | 
            var count = "count_example";  // string | 
            var cursor = "cursor_example";  // string | 

            try
            {
                // Read messages
                List<AiThreadMessageLike> result = apiInstance.AiThreadsReadMessages(threadId, count, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsReadMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsReadMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read messages
    ApiResponse<List<AiThreadMessageLike>> response = apiInstance.AiThreadsReadMessagesWithHttpInfo(threadId, count, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsReadMessagesWithHttpInfo: " + e.Message);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aithreadsregeneratetitle"></a>
# **AiThreadsRegenerateTitle**
> string AiThreadsRegenerateTitle (AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiThreadsRegenerateTitleRequest** | [**AiThreadsRegenerateTitleRequest**](AiThreadsRegenerateTitleRequest.md) |  |  |

### Return type

**string**

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
    public class AiThreadsRegenerateTitleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiThreadsRegenerateTitleRequest = new AiThreadsRegenerateTitleRequest(); // AiThreadsRegenerateTitleRequest | 

            try
            {
                // Regenerate title
                string result = apiInstance.AiThreadsRegenerateTitle(aiThreadsRegenerateTitleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsRegenerateTitle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsRegenerateTitleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate title
    ApiResponse<string> response = apiInstance.AiThreadsRegenerateTitleWithHttpInfo(aiThreadsRegenerateTitleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsRegenerateTitleWithHttpInfo: " + e.Message);
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

<a id="aithreadsrename"></a>
# **AiThreadsRename**
> AiSuccessResponse AiThreadsRename (AiThreadsRenameRequest aiThreadsRenameRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiThreadsRenameRequest** | [**AiThreadsRenameRequest**](AiThreadsRenameRequest.md) |  |  |

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
    public class AiThreadsRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiThreadsRenameRequest = new AiThreadsRenameRequest(); // AiThreadsRenameRequest | 

            try
            {
                // Rename
                AiSuccessResponse result = apiInstance.AiThreadsRename(aiThreadsRenameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsRename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsRenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename
    ApiResponse<AiSuccessResponse> response = apiInstance.AiThreadsRenameWithHttpInfo(aiThreadsRenameRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsRenameWithHttpInfo: " + e.Message);
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

<a id="aithreadstouch"></a>
# **AiThreadsTouch**
> AiSuccessResponse AiThreadsTouch (AiThreadsTouchRequest aiThreadsTouchRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiThreadsTouchRequest** | [**AiThreadsTouchRequest**](AiThreadsTouchRequest.md) |  |  |

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
    public class AiThreadsTouchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiThreadsTouchRequest = new AiThreadsTouchRequest(); // AiThreadsTouchRequest | 

            try
            {
                // Touch
                AiSuccessResponse result = apiInstance.AiThreadsTouch(aiThreadsTouchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsTouch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsTouchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Touch
    ApiResponse<AiSuccessResponse> response = apiInstance.AiThreadsTouchWithHttpInfo(aiThreadsTouchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsTouchWithHttpInfo: " + e.Message);
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

<a id="aithreadsupdatemessage"></a>
# **AiThreadsUpdateMessage**
> AiSuccessResponse AiThreadsUpdateMessage (AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiThreadsUpdateMessageRequest** | [**AiThreadsUpdateMessageRequest**](AiThreadsUpdateMessageRequest.md) |  |  |

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
    public class AiThreadsUpdateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var aiThreadsUpdateMessageRequest = new AiThreadsUpdateMessageRequest(); // AiThreadsUpdateMessageRequest | 

            try
            {
                // Update message
                AiSuccessResponse result = apiInstance.AiThreadsUpdateMessage(aiThreadsUpdateMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.AiThreadsUpdateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiThreadsUpdateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update message
    ApiResponse<AiSuccessResponse> response = apiInstance.AiThreadsUpdateMessageWithHttpInfo(aiThreadsUpdateMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.AiThreadsUpdateMessageWithHttpInfo: " + e.Message);
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

