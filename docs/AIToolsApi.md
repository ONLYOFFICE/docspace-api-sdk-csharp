# DocSpace.API.SDK.Api.ToolsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiToolsAddCustomServer**](#aitoolsaddcustomserver) | **POST** /api/2.0/ai/tools/add-custom-server | Add custom server |
| [**AiToolsGetAllowAlways**](#aitoolsgetallowalways) | **GET** /api/2.0/ai/tools/get-allow-always | Get allow always |
| [**AiToolsGetCustomServer**](#aitoolsgetcustomserver) | **GET** /api/2.0/ai/tools/get-custom-server | Get custom server |
| [**AiToolsGetDisabled**](#aitoolsgetdisabled) | **GET** /api/2.0/ai/tools/get-disabled | Get disabled |
| [**AiToolsIsAllowAlways**](#aitoolsisallowalways) | **GET** /api/2.0/ai/tools/is-allow-always | Is allow always |
| [**AiToolsIsToolDisabled**](#aitoolsistooldisabled) | **GET** /api/2.0/ai/tools/is-tool-disabled | Is tool disabled |
| [**AiToolsListCustomServers**](#aitoolslistcustomservers) | **GET** /api/2.0/ai/tools/list-custom-servers | List custom servers |
| [**AiToolsListSystemTools**](#aitoolslistsystemtools) | **GET** /api/2.0/ai/tools/list-system-tools | List system tools |
| [**AiToolsRemoveCustomServer**](#aitoolsremovecustomserver) | **DELETE** /api/2.0/ai/tools/remove-custom-server | Remove custom server |
| [**AiToolsReplaceAllCustomServers**](#aitoolsreplaceallcustomservers) | **PUT** /api/2.0/ai/tools/replace-all-custom-servers | Replace all custom servers |
| [**AiToolsSetAllowAlways**](#aitoolssetallowalways) | **PUT** /api/2.0/ai/tools/set-allow-always | Set allow always |
| [**AiToolsSetDisabled**](#aitoolssetdisabled) | **PUT** /api/2.0/ai/tools/set-disabled | Set disabled |
| [**AiToolsUpdateCustomServer**](#aitoolsupdatecustomserver) | **PUT** /api/2.0/ai/tools/update-custom-server | Update custom server |

<a id="aitoolsaddcustomserver"></a>
# **AiToolsAddCustomServer**
> AiToolsMutationResult AiToolsAddCustomServer (AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest)

Registers a custom MCP server in the scope under the given name.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiToolsAddCustomServerRequest** | [**AiToolsAddCustomServerRequest**](AiToolsAddCustomServerRequest.md) |  |  |

### Return type

[**AiToolsMutationResult**](AiToolsMutationResult.md)

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
    public class AiToolsAddCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var aiToolsAddCustomServerRequest = new AiToolsAddCustomServerRequest(); // AiToolsAddCustomServerRequest | 

            try
            {
                // Add custom server
                AiToolsMutationResult result = apiInstance.AiToolsAddCustomServer(aiToolsAddCustomServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsAddCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsAddCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add custom server
    ApiResponse<AiToolsMutationResult> response = apiInstance.AiToolsAddCustomServerWithHttpInfo(aiToolsAddCustomServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsAddCustomServerWithHttpInfo: " + e.Message);
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

<a id="aitoolsgetallowalways"></a>
# **AiToolsGetAllowAlways**
> List&lt;string&gt; AiToolsGetAllowAlways (string? entityId = null)

Lists the tools on the always-allow list of the scope.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

### Return type

**List<string>**

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
    public class AiToolsGetAllowAlwaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Get allow always
                List<string> result = apiInstance.AiToolsGetAllowAlways(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsGetAllowAlways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsGetAllowAlwaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get allow always
    ApiResponse<List<string>> response = apiInstance.AiToolsGetAllowAlwaysWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsGetAllowAlwaysWithHttpInfo: " + e.Message);
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

<a id="aitoolsgetcustomserver"></a>
# **AiToolsGetCustomServer**
> Object AiToolsGetCustomServer (string name, string? entityId = null)

Returns the configuration of one custom MCP server, or an empty result when it is not registered.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The custom MCP server name. |  |
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

### Return type

**Object**

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
    public class AiToolsGetCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The custom MCP server name.
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Get custom server
                Object result = apiInstance.AiToolsGetCustomServer(name, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsGetCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsGetCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get custom server
    ApiResponse<Object> response = apiInstance.AiToolsGetCustomServerWithHttpInfo(name, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsGetCustomServerWithHttpInfo: " + e.Message);
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

<a id="aitoolsgetdisabled"></a>
# **AiToolsGetDisabled**
> Dictionary&lt;string, List&lt;string&gt;&gt; AiToolsGetDisabled (string? entityId = null)

Returns the switched-off tools of the scope, grouped by server type.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

### Return type

**Dictionary<string, List<string>>**

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
    public class AiToolsGetDisabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Get disabled
                Dictionary<string, List<string>> result = apiInstance.AiToolsGetDisabled(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsGetDisabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsGetDisabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get disabled
    ApiResponse<Dictionary<string, List<string>>> response = apiInstance.AiToolsGetDisabledWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsGetDisabledWithHttpInfo: " + e.Message);
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

<a id="aitoolsisallowalways"></a>
# **AiToolsIsAllowAlways**
> bool AiToolsIsAllowAlways (string serverType, string toolName, string? entityId = null)

Tells whether one tool is on the always-allow list.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverType** | **string** | The MCP server type the tool belongs to. |  |
| **toolName** | **string** | The tool name. |  |
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
    public class AiToolsIsAllowAlwaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var serverType = "serverType_example";  // string | The MCP server type the tool belongs to.
            var toolName = "toolName_example";  // string | The tool name.
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Is allow always
                bool result = apiInstance.AiToolsIsAllowAlways(serverType, toolName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsIsAllowAlways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsIsAllowAlwaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Is allow always
    ApiResponse<bool> response = apiInstance.AiToolsIsAllowAlwaysWithHttpInfo(serverType, toolName, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsIsAllowAlwaysWithHttpInfo: " + e.Message);
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

<a id="aitoolsistooldisabled"></a>
# **AiToolsIsToolDisabled**
> bool AiToolsIsToolDisabled (string serverType, string toolName, string? entityId = null)

Tells whether one tool of a server type is switched off.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverType** | **string** | The MCP server type the tool belongs to. |  |
| **toolName** | **string** | The tool name. |  |
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
    public class AiToolsIsToolDisabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var serverType = "serverType_example";  // string | The MCP server type the tool belongs to.
            var toolName = "toolName_example";  // string | The tool name.
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // Is tool disabled
                bool result = apiInstance.AiToolsIsToolDisabled(serverType, toolName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsIsToolDisabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsIsToolDisabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Is tool disabled
    ApiResponse<bool> response = apiInstance.AiToolsIsToolDisabledWithHttpInfo(serverType, toolName, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsIsToolDisabledWithHttpInfo: " + e.Message);
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

<a id="aitoolslistcustomservers"></a>
# **AiToolsListCustomServers**
> Dictionary&lt;string, Object&gt; AiToolsListCustomServers (string? entityId = null)

Lists the custom MCP servers registered in the scope, keyed by name.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

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
    public class AiToolsListCustomServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // List custom servers
                Dictionary<string, Object> result = apiInstance.AiToolsListCustomServers(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsListCustomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsListCustomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List custom servers
    ApiResponse<Dictionary<string, Object>> response = apiInstance.AiToolsListCustomServersWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsListCustomServersWithHttpInfo: " + e.Message);
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

<a id="aitoolslistsystemtools"></a>
# **AiToolsListSystemTools**
> Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt; AiToolsListSystemTools (string? entityId = null)

Lists the tools of the host-configured system MCP servers, grouped by server type. The servers are connected and listed server-side, so the client renders its permission cards from one request and never opens an MCP connection of its own.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string?** | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. | [optional]  |

### Return type

**Dictionary<string, List<AiTMCPItem>>**

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
    public class AiToolsListSystemToolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string? | The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional) 

            try
            {
                // List system tools
                Dictionary<string, List<AiTMCPItem>> result = apiInstance.AiToolsListSystemTools(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsListSystemTools: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsListSystemToolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List system tools
    ApiResponse<Dictionary<string, List<AiTMCPItem>>> response = apiInstance.AiToolsListSystemToolsWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsListSystemToolsWithHttpInfo: " + e.Message);
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

<a id="aitoolsremovecustomserver"></a>
# **AiToolsRemoveCustomServer**
> AiSuccessResponse AiToolsRemoveCustomServer (AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest)

Removes a custom MCP server from the registry.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiToolsRemoveCustomServerRequest** | [**AiToolsRemoveCustomServerRequest**](AiToolsRemoveCustomServerRequest.md) |  |  |

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
    public class AiToolsRemoveCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var aiToolsRemoveCustomServerRequest = new AiToolsRemoveCustomServerRequest(); // AiToolsRemoveCustomServerRequest | 

            try
            {
                // Remove custom server
                AiSuccessResponse result = apiInstance.AiToolsRemoveCustomServer(aiToolsRemoveCustomServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsRemoveCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsRemoveCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove custom server
    ApiResponse<AiSuccessResponse> response = apiInstance.AiToolsRemoveCustomServerWithHttpInfo(aiToolsRemoveCustomServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsRemoveCustomServerWithHttpInfo: " + e.Message);
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

<a id="aitoolsreplaceallcustomservers"></a>
# **AiToolsReplaceAllCustomServers**
> AiToolsBulkResult AiToolsReplaceAllCustomServers (AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest)

Replaces the whole custom MCP server registry of the scope with the supplied map.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiToolsReplaceAllCustomServersRequest** | [**AiToolsReplaceAllCustomServersRequest**](AiToolsReplaceAllCustomServersRequest.md) |  |  |

### Return type

[**AiToolsBulkResult**](AiToolsBulkResult.md)

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
    public class AiToolsReplaceAllCustomServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var aiToolsReplaceAllCustomServersRequest = new AiToolsReplaceAllCustomServersRequest(); // AiToolsReplaceAllCustomServersRequest | 

            try
            {
                // Replace all custom servers
                AiToolsBulkResult result = apiInstance.AiToolsReplaceAllCustomServers(aiToolsReplaceAllCustomServersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsReplaceAllCustomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsReplaceAllCustomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace all custom servers
    ApiResponse<AiToolsBulkResult> response = apiInstance.AiToolsReplaceAllCustomServersWithHttpInfo(aiToolsReplaceAllCustomServersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsReplaceAllCustomServersWithHttpInfo: " + e.Message);
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

<a id="aitoolssetallowalways"></a>
# **AiToolsSetAllowAlways**
> AiSuccessResponse AiToolsSetAllowAlways (AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest)

Adds a tool to the always-allow list, or removes it - the tools on that list run without an approval dialog.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiToolsSetAllowAlwaysRequest** | [**AiToolsSetAllowAlwaysRequest**](AiToolsSetAllowAlwaysRequest.md) |  |  |

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
    public class AiToolsSetAllowAlwaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var aiToolsSetAllowAlwaysRequest = new AiToolsSetAllowAlwaysRequest(); // AiToolsSetAllowAlwaysRequest | 

            try
            {
                // Set allow always
                AiSuccessResponse result = apiInstance.AiToolsSetAllowAlways(aiToolsSetAllowAlwaysRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsSetAllowAlways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsSetAllowAlwaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set allow always
    ApiResponse<AiSuccessResponse> response = apiInstance.AiToolsSetAllowAlwaysWithHttpInfo(aiToolsSetAllowAlwaysRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsSetAllowAlwaysWithHttpInfo: " + e.Message);
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

<a id="aitoolssetdisabled"></a>
# **AiToolsSetDisabled**
> AiSuccessResponse AiToolsSetDisabled (AiToolsSetDisabledRequest aiToolsSetDisabledRequest)

Marks the listed tools of one server type as switched off, so the model is no longer offered them.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiToolsSetDisabledRequest** | [**AiToolsSetDisabledRequest**](AiToolsSetDisabledRequest.md) |  |  |

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
    public class AiToolsSetDisabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var aiToolsSetDisabledRequest = new AiToolsSetDisabledRequest(); // AiToolsSetDisabledRequest | 

            try
            {
                // Set disabled
                AiSuccessResponse result = apiInstance.AiToolsSetDisabled(aiToolsSetDisabledRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsSetDisabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsSetDisabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set disabled
    ApiResponse<AiSuccessResponse> response = apiInstance.AiToolsSetDisabledWithHttpInfo(aiToolsSetDisabledRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsSetDisabledWithHttpInfo: " + e.Message);
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

<a id="aitoolsupdatecustomserver"></a>
# **AiToolsUpdateCustomServer**
> AiToolsMutationResult AiToolsUpdateCustomServer (AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest)

Updates the configuration of a registered custom MCP server.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiToolsUpdateCustomServerRequest** | [**AiToolsUpdateCustomServerRequest**](AiToolsUpdateCustomServerRequest.md) |  |  |

### Return type

[**AiToolsMutationResult**](AiToolsMutationResult.md)

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
    public class AiToolsUpdateCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var aiToolsUpdateCustomServerRequest = new AiToolsUpdateCustomServerRequest(); // AiToolsUpdateCustomServerRequest | 

            try
            {
                // Update custom server
                AiToolsMutationResult result = apiInstance.AiToolsUpdateCustomServer(aiToolsUpdateCustomServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.AiToolsUpdateCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiToolsUpdateCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update custom server
    ApiResponse<AiToolsMutationResult> response = apiInstance.AiToolsUpdateCustomServerWithHttpInfo(aiToolsUpdateCustomServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.AiToolsUpdateCustomServerWithHttpInfo: " + e.Message);
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

