# DocSpace.API.SDK.Api.WebSearchApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiWebSearchClear**](#aiwebsearchclear) | **DELETE** /api/2.0/ai/web-search/clear | Clear the web-search configuration |
| [**AiWebSearchConfigure**](#aiwebsearchconfigure) | **PUT** /api/2.0/ai/web-search/configure | Configure and verify web search |
| [**AiWebSearchGetActiveConfig**](#aiwebsearchgetactiveconfig) | **GET** /api/2.0/ai/web-search/get-active-config | Get active config |
| [**AiWebSearchIsConfigured**](#aiwebsearchisconfigured) | **GET** /api/2.0/ai/web-search/is-configured | Is configured |
| [**AiWebSearchPassthroughContents**](#aiwebsearchpassthroughcontents) | **POST** /api/2.0/ai/websearch/v1/contents | Web page contents passthrough |
| [**AiWebSearchPassthroughSearch**](#aiwebsearchpassthroughsearch) | **POST** /api/2.0/ai/websearch/v1/search | Web search passthrough |
| [**AiWebSearchSetActiveConfig**](#aiwebsearchsetactiveconfig) | **PUT** /api/2.0/ai/web-search/set-active-config | Set active config |
| [**AiWebSearchTestConnection**](#aiwebsearchtestconnection) | **POST** /api/2.0/ai/web-search/test-connection | Test a web-search provider |

<a id="aiwebsearchclear"></a>
# **AiWebSearchClear**
> AiSuccessResponse AiWebSearchClear (string body)

Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room. |  |

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
    public class AiWebSearchClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.

            try
            {
                // Clear the web-search configuration
                AiSuccessResponse result = apiInstance.AiWebSearchClear(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchClear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchClearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear the web-search configuration
    ApiResponse<AiSuccessResponse> response = apiInstance.AiWebSearchClearWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchClearWithHttpInfo: " + e.Message);
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
| **200** | Confirms the portal has no web-search configuration any more. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchconfigure"></a>
# **AiWebSearchConfigure**
> AiWebSearchMutationResult AiWebSearchConfigure (AiWebSearchConfigureRequest aiWebSearchConfigureRequest)

Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiWebSearchConfigureRequest** | [**AiWebSearchConfigureRequest**](AiWebSearchConfigureRequest.md) |  |  |

### Return type

[**AiWebSearchMutationResult**](AiWebSearchMutationResult.md)

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
    public class AiWebSearchConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var aiWebSearchConfigureRequest = new AiWebSearchConfigureRequest(); // AiWebSearchConfigureRequest | 

            try
            {
                // Configure and verify web search
                AiWebSearchMutationResult result = apiInstance.AiWebSearchConfigure(aiWebSearchConfigureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchConfigure: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchConfigureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure and verify web search
    ApiResponse<AiWebSearchMutationResult> response = apiInstance.AiWebSearchConfigureWithHttpInfo(aiWebSearchConfigureRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchConfigureWithHttpInfo: " + e.Message);
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
| **200** | Whether the configuration was stored, after the provider answered. |  -  |
| **400** | The provider URL is missing, malformed, or points at a private network address. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | The referenced object does not exist, or the caller cannot access it - the two are deliberately indistinguishable, so a room the caller may not open answers 404 rather than 403. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchgetactiveconfig"></a>
# **AiWebSearchGetActiveConfig**
> AiWebSearchConfig AiWebSearchGetActiveConfig (string? entityId = null)

Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

### Return type

[**AiWebSearchConfig**](AiWebSearchConfig.md)

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
    public class AiWebSearchGetActiveConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var entityId = 1234;  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Get active config
                AiWebSearchConfig result = apiInstance.AiWebSearchGetActiveConfig(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchGetActiveConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchGetActiveConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get active config
    ApiResponse<AiWebSearchConfig> response = apiInstance.AiWebSearchGetActiveConfigWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchGetActiveConfigWithHttpInfo: " + e.Message);
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
| **200** | The configuration in force for the scope, without the provider key, or an empty result when web search is not configured. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | The referenced object does not exist, or the caller cannot access it - the two are deliberately indistinguishable, so a room the caller may not open answers 404 rather than 403. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchisconfigured"></a>
# **AiWebSearchIsConfigured**
> bool AiWebSearchIsConfigured (string? entityId = null)

Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

### Return type

**bool**

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
    public class AiWebSearchIsConfiguredExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var entityId = 1234;  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Is configured
                bool result = apiInstance.AiWebSearchIsConfigured(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchIsConfigured: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchIsConfiguredWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Is configured
    ApiResponse<bool> response = apiInstance.AiWebSearchIsConfiguredWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchIsConfiguredWithHttpInfo: " + e.Message);
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
| **200** | Whether a web-search provider is stored for the scope. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | The referenced object does not exist, or the caller cannot access it - the two are deliberately indistinguishable, so a room the caller may not open answers 404 rather than 403. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchpassthroughcontents"></a>
# **AiWebSearchPassthroughContents**
> Dictionary&lt;string, Object&gt; AiWebSearchPassthroughContents (Dictionary<string, Object> requestBody)

Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) | A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration. |  |

### Return type

**Dictionary<string, Object>**

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
    public class AiWebSearchPassthroughContentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.

            try
            {
                // Web page contents passthrough
                Dictionary<string, Object> result = apiInstance.AiWebSearchPassthroughContents(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchPassthroughContents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchPassthroughContentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Web page contents passthrough
    ApiResponse<Dictionary<string, Object>> response = apiInstance.AiWebSearchPassthroughContentsWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchPassthroughContentsWithHttpInfo: " + e.Message);
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
| **200** | The provider's own response, relayed verbatim with its status and content type. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | Web search is not configured for this portal. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **429** | Relayed verbatim from the AI provider, which is rate-limiting this portal's key. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |
| **502** | The AI provider could not be reached, or answered with a failure of its own. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchpassthroughsearch"></a>
# **AiWebSearchPassthroughSearch**
> Dictionary&lt;string, Object&gt; AiWebSearchPassthroughSearch (Dictionary<string, Object> requestBody)

Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md) | A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here. |  |

### Return type

**Dictionary<string, Object>**

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
    public class AiWebSearchPassthroughSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.

            try
            {
                // Web search passthrough
                Dictionary<string, Object> result = apiInstance.AiWebSearchPassthroughSearch(requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchPassthroughSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchPassthroughSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Web search passthrough
    ApiResponse<Dictionary<string, Object>> response = apiInstance.AiWebSearchPassthroughSearchWithHttpInfo(requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchPassthroughSearchWithHttpInfo: " + e.Message);
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
| **200** | The provider's own response, relayed verbatim with its status and content type. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | Web search is not configured for this portal. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **429** | Relayed verbatim from the AI provider, which is rate-limiting this portal's key. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |
| **502** | The AI provider could not be reached, or answered with a failure of its own. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchsetactiveconfig"></a>
# **AiWebSearchSetActiveConfig**
> AiSuccessResponse AiWebSearchSetActiveConfig (AiWebSearchConfigureRequest aiWebSearchConfigureRequest)

Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiWebSearchConfigureRequest** | [**AiWebSearchConfigureRequest**](AiWebSearchConfigureRequest.md) |  |  |

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
    public class AiWebSearchSetActiveConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var aiWebSearchConfigureRequest = new AiWebSearchConfigureRequest(); // AiWebSearchConfigureRequest | 

            try
            {
                // Set active config
                AiSuccessResponse result = apiInstance.AiWebSearchSetActiveConfig(aiWebSearchConfigureRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchSetActiveConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchSetActiveConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set active config
    ApiResponse<AiSuccessResponse> response = apiInstance.AiWebSearchSetActiveConfigWithHttpInfo(aiWebSearchConfigureRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchSetActiveConfigWithHttpInfo: " + e.Message);
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
| **200** | Confirms the configuration was stored, unverified. |  -  |
| **400** | The provider URL is missing, malformed, or points at a private network address. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | The referenced object does not exist, or the caller cannot access it - the two are deliberately indistinguishable, so a room the caller may not open answers 404 rather than 403. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchtestconnection"></a>
# **AiWebSearchTestConnection**
> AiProfilesTestConnection200Response AiWebSearchTestConnection (AiWebSearchConfig aiWebSearchConfig)

Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiWebSearchConfig** | [**AiWebSearchConfig**](AiWebSearchConfig.md) | Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group. |  |

### Return type

[**AiProfilesTestConnection200Response**](AiProfilesTestConnection200Response.md)

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
    public class AiWebSearchTestConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WebSearchApi(httpClient, config, httpClientHandler);
            var aiWebSearchConfig = new AiWebSearchConfig(); // AiWebSearchConfig | Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.

            try
            {
                // Test a web-search provider
                AiProfilesTestConnection200Response result = apiInstance.AiWebSearchTestConnection(aiWebSearchConfig);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebSearchApi.AiWebSearchTestConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiWebSearchTestConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test a web-search provider
    ApiResponse<AiProfilesTestConnection200Response> response = apiInstance.AiWebSearchTestConnectionWithHttpInfo(aiWebSearchConfig);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebSearchApi.AiWebSearchTestConnectionWithHttpInfo: " + e.Message);
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
| **200** | The outcome of the probe. A failed probe is reported here, not as a status. |  -  |
| **400** | The provider URL is missing, malformed, or points at a private network address. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

