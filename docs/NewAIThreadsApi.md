# DocSpace.API.SDK.Api.ThreadsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewAiThreadsAppendUserMessage**](#newaithreadsappendusermessage) | **POST** /api/2.0/ai/threads/append-user-message | Append user message |
| [**NewAiThreadsClearMessages**](#newaithreadsclearmessages) | **DELETE** /api/2.0/ai/threads/clear-messages | Clear messages |
| [**NewAiThreadsCreate**](#newaithreadscreate) | **POST** /api/2.0/ai/threads/create | Create |
| [**NewAiThreadsDelete**](#newaithreadsdelete) | **DELETE** /api/2.0/ai/threads/delete | Delete |
| [**NewAiThreadsDeleteMessage**](#newaithreadsdeletemessage) | **DELETE** /api/2.0/ai/threads/delete-message | Delete message |
| [**NewAiThreadsGetById**](#newaithreadsgetbyid) | **GET** /api/2.0/ai/threads/get-by-id | Get by id |
| [**NewAiThreadsGetMessageById**](#newaithreadsgetmessagebyid) | **GET** /api/2.0/ai/threads/get-message-by-id | Get message by id |
| [**NewAiThreadsList**](#newaithreadslist) | **GET** /api/2.0/ai/threads/list | List |
| [**NewAiThreadsOpenOrCreate**](#newaithreadsopenorcreate) | **POST** /api/2.0/ai/threads/open-or-create | Open or create |
| [**NewAiThreadsReadMessages**](#newaithreadsreadmessages) | **GET** /api/2.0/ai/threads/read-messages | Read messages |
| [**NewAiThreadsRegenerateTitle**](#newaithreadsregeneratetitle) | **POST** /api/2.0/ai/threads/regenerate-title | Regenerate title |
| [**NewAiThreadsRename**](#newaithreadsrename) | **PUT** /api/2.0/ai/threads/rename | Rename |
| [**NewAiThreadsTouch**](#newaithreadstouch) | **POST** /api/2.0/ai/threads/touch | Touch |
| [**NewAiThreadsUpdateMessage**](#newaithreadsupdatemessage) | **PUT** /api/2.0/ai/threads/update-message | Update message |

<a id="newaithreadsappendusermessage"></a>
# **NewAiThreadsAppendUserMessage**
> NewAiThreadMessageLike NewAiThreadsAppendUserMessage (NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiThreadsAppendUserMessageRequest** | [**NewAiThreadsAppendUserMessageRequest**](NewAiThreadsAppendUserMessageRequest.md) |  |  |

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
    public class NewAiThreadsAppendUserMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiThreadsAppendUserMessageRequest = new NewAiThreadsAppendUserMessageRequest(); // NewAiThreadsAppendUserMessageRequest | 

            try
            {
                // Append user message
                NewAiThreadMessageLike result = apiInstance.NewAiThreadsAppendUserMessage(newAiThreadsAppendUserMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsAppendUserMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsAppendUserMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Append user message
    ApiResponse<NewAiThreadMessageLike> response = apiInstance.NewAiThreadsAppendUserMessageWithHttpInfo(newAiThreadsAppendUserMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsAppendUserMessageWithHttpInfo: " + e.Message);
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

<a id="newaithreadsclearmessages"></a>
# **NewAiThreadsClearMessages**
> NewAiSuccessResponse NewAiThreadsClearMessages (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/).

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
    public class NewAiThreadsClearMessagesExample
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
                NewAiSuccessResponse result = apiInstance.NewAiThreadsClearMessages(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsClearMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsClearMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear messages
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiThreadsClearMessagesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsClearMessagesWithHttpInfo: " + e.Message);
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

<a id="newaithreadscreate"></a>
# **NewAiThreadsCreate**
> NewAiThread NewAiThreadsCreate (NewAiThreadsCreateRequest newAiThreadsCreateRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiThreadsCreateRequest** | [**NewAiThreadsCreateRequest**](NewAiThreadsCreateRequest.md) |  |  |

### Return type

[**NewAiThread**](NewAiThread.md)

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
    public class NewAiThreadsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiThreadsCreateRequest = new NewAiThreadsCreateRequest(); // NewAiThreadsCreateRequest | 

            try
            {
                // Create
                NewAiThread result = apiInstance.NewAiThreadsCreate(newAiThreadsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<NewAiThread> response = apiInstance.NewAiThreadsCreateWithHttpInfo(newAiThreadsCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsCreateWithHttpInfo: " + e.Message);
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

<a id="newaithreadsdelete"></a>
# **NewAiThreadsDelete**
> NewAiSuccessResponse NewAiThreadsDelete (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/).

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
    public class NewAiThreadsDeleteExample
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
                NewAiSuccessResponse result = apiInstance.NewAiThreadsDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiThreadsDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsDeleteWithHttpInfo: " + e.Message);
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

<a id="newaithreadsdeletemessage"></a>
# **NewAiThreadsDeleteMessage**
> NewAiSuccessResponse NewAiThreadsDeleteMessage (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/).

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
    public class NewAiThreadsDeleteMessageExample
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
                NewAiSuccessResponse result = apiInstance.NewAiThreadsDeleteMessage(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsDeleteMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsDeleteMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete message
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiThreadsDeleteMessageWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsDeleteMessageWithHttpInfo: " + e.Message);
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

<a id="newaithreadsgetbyid"></a>
# **NewAiThreadsGetById**
> NewAiThread NewAiThreadsGetById (string threadId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threadId** | **string** |  |  |

### Return type

[**NewAiThread**](NewAiThread.md)

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
    public class NewAiThreadsGetByIdExample
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
                NewAiThread result = apiInstance.NewAiThreadsGetById(threadId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get by id
    ApiResponse<NewAiThread> response = apiInstance.NewAiThreadsGetByIdWithHttpInfo(threadId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsGetByIdWithHttpInfo: " + e.Message);
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

<a id="newaithreadsgetmessagebyid"></a>
# **NewAiThreadsGetMessageById**
> NewAiThreadMessageLike NewAiThreadsGetMessageById (string messageId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |

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
    public class NewAiThreadsGetMessageByIdExample
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
                NewAiThreadMessageLike result = apiInstance.NewAiThreadsGetMessageById(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsGetMessageById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsGetMessageByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get message by id
    ApiResponse<NewAiThreadMessageLike> response = apiInstance.NewAiThreadsGetMessageByIdWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsGetMessageByIdWithHttpInfo: " + e.Message);
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

<a id="newaithreadslist"></a>
# **NewAiThreadsList**
> List&lt;NewAiThread&gt; NewAiThreadsList (string entityId, string count, string cursor, string query)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |
| **count** | **string** |  |  |
| **cursor** | **string** |  |  |
| **query** | **string** |  |  |

### Return type

[**List&lt;NewAiThread&gt;**](NewAiThread.md)

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
    public class NewAiThreadsListExample
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
                List<NewAiThread> result = apiInstance.NewAiThreadsList(entityId, count, cursor, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List
    ApiResponse<List<NewAiThread>> response = apiInstance.NewAiThreadsListWithHttpInfo(entityId, count, cursor, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsListWithHttpInfo: " + e.Message);
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

<a id="newaithreadsopenorcreate"></a>
# **NewAiThreadsOpenOrCreate**
> NewAiOpenOrCreateResult NewAiThreadsOpenOrCreate (NewAiOpenOrCreateInput newAiOpenOrCreateInput)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiOpenOrCreateInput** | [**NewAiOpenOrCreateInput**](NewAiOpenOrCreateInput.md) | Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`. |  |

### Return type

[**NewAiOpenOrCreateResult**](NewAiOpenOrCreateResult.md)

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
    public class NewAiThreadsOpenOrCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiOpenOrCreateInput = new NewAiOpenOrCreateInput(); // NewAiOpenOrCreateInput | Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.

            try
            {
                // Open or create
                NewAiOpenOrCreateResult result = apiInstance.NewAiThreadsOpenOrCreate(newAiOpenOrCreateInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsOpenOrCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsOpenOrCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Open or create
    ApiResponse<NewAiOpenOrCreateResult> response = apiInstance.NewAiThreadsOpenOrCreateWithHttpInfo(newAiOpenOrCreateInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsOpenOrCreateWithHttpInfo: " + e.Message);
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

<a id="newaithreadsreadmessages"></a>
# **NewAiThreadsReadMessages**
> List&lt;NewAiThreadMessageLike&gt; NewAiThreadsReadMessages (string threadId, string count, string cursor)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **threadId** | **string** |  |  |
| **count** | **string** |  |  |
| **cursor** | **string** |  |  |

### Return type

[**List&lt;NewAiThreadMessageLike&gt;**](NewAiThreadMessageLike.md)

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
    public class NewAiThreadsReadMessagesExample
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
                List<NewAiThreadMessageLike> result = apiInstance.NewAiThreadsReadMessages(threadId, count, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsReadMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsReadMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read messages
    ApiResponse<List<NewAiThreadMessageLike>> response = apiInstance.NewAiThreadsReadMessagesWithHttpInfo(threadId, count, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsReadMessagesWithHttpInfo: " + e.Message);
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

<a id="newaithreadsregeneratetitle"></a>
# **NewAiThreadsRegenerateTitle**
> string NewAiThreadsRegenerateTitle (NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiThreadsRegenerateTitleRequest** | [**NewAiThreadsRegenerateTitleRequest**](NewAiThreadsRegenerateTitleRequest.md) |  |  |

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
    public class NewAiThreadsRegenerateTitleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiThreadsRegenerateTitleRequest = new NewAiThreadsRegenerateTitleRequest(); // NewAiThreadsRegenerateTitleRequest | 

            try
            {
                // Regenerate title
                string result = apiInstance.NewAiThreadsRegenerateTitle(newAiThreadsRegenerateTitleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsRegenerateTitle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsRegenerateTitleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Regenerate title
    ApiResponse<string> response = apiInstance.NewAiThreadsRegenerateTitleWithHttpInfo(newAiThreadsRegenerateTitleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsRegenerateTitleWithHttpInfo: " + e.Message);
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

<a id="newaithreadsrename"></a>
# **NewAiThreadsRename**
> NewAiSuccessResponse NewAiThreadsRename (NewAiThreadsRenameRequest newAiThreadsRenameRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiThreadsRenameRequest** | [**NewAiThreadsRenameRequest**](NewAiThreadsRenameRequest.md) |  |  |

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
    public class NewAiThreadsRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiThreadsRenameRequest = new NewAiThreadsRenameRequest(); // NewAiThreadsRenameRequest | 

            try
            {
                // Rename
                NewAiSuccessResponse result = apiInstance.NewAiThreadsRename(newAiThreadsRenameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsRename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsRenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rename
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiThreadsRenameWithHttpInfo(newAiThreadsRenameRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsRenameWithHttpInfo: " + e.Message);
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

<a id="newaithreadstouch"></a>
# **NewAiThreadsTouch**
> NewAiSuccessResponse NewAiThreadsTouch (NewAiThreadsTouchRequest newAiThreadsTouchRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiThreadsTouchRequest** | [**NewAiThreadsTouchRequest**](NewAiThreadsTouchRequest.md) |  |  |

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
    public class NewAiThreadsTouchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiThreadsTouchRequest = new NewAiThreadsTouchRequest(); // NewAiThreadsTouchRequest | 

            try
            {
                // Touch
                NewAiSuccessResponse result = apiInstance.NewAiThreadsTouch(newAiThreadsTouchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsTouch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsTouchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Touch
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiThreadsTouchWithHttpInfo(newAiThreadsTouchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsTouchWithHttpInfo: " + e.Message);
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

<a id="newaithreadsupdatemessage"></a>
# **NewAiThreadsUpdateMessage**
> NewAiSuccessResponse NewAiThreadsUpdateMessage (NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiThreadsUpdateMessageRequest** | [**NewAiThreadsUpdateMessageRequest**](NewAiThreadsUpdateMessageRequest.md) |  |  |

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
    public class NewAiThreadsUpdateMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ThreadsApi(httpClient, config, httpClientHandler);
            var newAiThreadsUpdateMessageRequest = new NewAiThreadsUpdateMessageRequest(); // NewAiThreadsUpdateMessageRequest | 

            try
            {
                // Update message
                NewAiSuccessResponse result = apiInstance.NewAiThreadsUpdateMessage(newAiThreadsUpdateMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThreadsApi.NewAiThreadsUpdateMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiThreadsUpdateMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update message
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiThreadsUpdateMessageWithHttpInfo(newAiThreadsUpdateMessageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThreadsApi.NewAiThreadsUpdateMessageWithHttpInfo: " + e.Message);
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

