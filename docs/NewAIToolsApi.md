# DocSpace.API.SDK.Api.ToolsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewAiToolsAddCustomServer**](#newaitoolsaddcustomserver) | **POST** /api/2.0/ai/tools/add-custom-server | Add custom server |
| [**NewAiToolsGetAllowAlways**](#newaitoolsgetallowalways) | **GET** /api/2.0/ai/tools/get-allow-always | Get allow always |
| [**NewAiToolsGetCustomServer**](#newaitoolsgetcustomserver) | **GET** /api/2.0/ai/tools/get-custom-server | Get custom server |
| [**NewAiToolsGetDisabled**](#newaitoolsgetdisabled) | **GET** /api/2.0/ai/tools/get-disabled | Get disabled |
| [**NewAiToolsIsAllowAlways**](#newaitoolsisallowalways) | **GET** /api/2.0/ai/tools/is-allow-always | Is allow always |
| [**NewAiToolsIsToolDisabled**](#newaitoolsistooldisabled) | **GET** /api/2.0/ai/tools/is-tool-disabled | Is tool disabled |
| [**NewAiToolsListCustomServers**](#newaitoolslistcustomservers) | **GET** /api/2.0/ai/tools/list-custom-servers | List custom servers |
| [**NewAiToolsListSystemTools**](#newaitoolslistsystemtools) | **GET** /api/2.0/ai/tools/list-system-tools | List system tools |
| [**NewAiToolsRemoveCustomServer**](#newaitoolsremovecustomserver) | **DELETE** /api/2.0/ai/tools/remove-custom-server | Remove custom server |
| [**NewAiToolsReplaceAllCustomServers**](#newaitoolsreplaceallcustomservers) | **PUT** /api/2.0/ai/tools/replace-all-custom-servers | Replace all custom servers |
| [**NewAiToolsSetAllowAlways**](#newaitoolssetallowalways) | **PUT** /api/2.0/ai/tools/set-allow-always | Set allow always |
| [**NewAiToolsSetDisabled**](#newaitoolssetdisabled) | **PUT** /api/2.0/ai/tools/set-disabled | Set disabled |
| [**NewAiToolsUpdateCustomServer**](#newaitoolsupdatecustomserver) | **PUT** /api/2.0/ai/tools/update-custom-server | Update custom server |

<a id="newaitoolsaddcustomserver"></a>
# **NewAiToolsAddCustomServer**
> NewAiToolsMutationResult NewAiToolsAddCustomServer (NewAiToolsAddCustomServerRequest newAiToolsAddCustomServerRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-add-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiToolsAddCustomServerRequest** | [**NewAiToolsAddCustomServerRequest**](NewAiToolsAddCustomServerRequest.md) |  |  |

### Return type

[**NewAiToolsMutationResult**](NewAiToolsMutationResult.md)

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
    public class NewAiToolsAddCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var newAiToolsAddCustomServerRequest = new NewAiToolsAddCustomServerRequest(); // NewAiToolsAddCustomServerRequest | 

            try
            {
                // Add custom server
                NewAiToolsMutationResult result = apiInstance.NewAiToolsAddCustomServer(newAiToolsAddCustomServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsAddCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsAddCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add custom server
    ApiResponse<NewAiToolsMutationResult> response = apiInstance.NewAiToolsAddCustomServerWithHttpInfo(newAiToolsAddCustomServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsAddCustomServerWithHttpInfo: " + e.Message);
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

<a id="newaitoolsgetallowalways"></a>
# **NewAiToolsGetAllowAlways**
> List&lt;string&gt; NewAiToolsGetAllowAlways (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-allow-always/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |

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
    public class NewAiToolsGetAllowAlwaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // Get allow always
                List<string> result = apiInstance.NewAiToolsGetAllowAlways(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsGetAllowAlways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsGetAllowAlwaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get allow always
    ApiResponse<List<string>> response = apiInstance.NewAiToolsGetAllowAlwaysWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsGetAllowAlwaysWithHttpInfo: " + e.Message);
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

<a id="newaitoolsgetcustomserver"></a>
# **NewAiToolsGetCustomServer**
> Object NewAiToolsGetCustomServer (string name, string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** |  |  |
| **entityId** | **string** |  |  |

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
    public class NewAiToolsGetCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | 
            var entityId = "entityId_example";  // string | 

            try
            {
                // Get custom server
                Object result = apiInstance.NewAiToolsGetCustomServer(name, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsGetCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsGetCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get custom server
    ApiResponse<Object> response = apiInstance.NewAiToolsGetCustomServerWithHttpInfo(name, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsGetCustomServerWithHttpInfo: " + e.Message);
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

<a id="newaitoolsgetdisabled"></a>
# **NewAiToolsGetDisabled**
> Dictionary&lt;string, List&lt;string&gt;&gt; NewAiToolsGetDisabled (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-get-disabled/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |

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
    public class NewAiToolsGetDisabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // Get disabled
                Dictionary<string, List<string>> result = apiInstance.NewAiToolsGetDisabled(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsGetDisabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsGetDisabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get disabled
    ApiResponse<Dictionary<string, List<string>>> response = apiInstance.NewAiToolsGetDisabledWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsGetDisabledWithHttpInfo: " + e.Message);
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

<a id="newaitoolsisallowalways"></a>
# **NewAiToolsIsAllowAlways**
> bool NewAiToolsIsAllowAlways (string serverType, string toolName, string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-allow-always/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverType** | **string** |  |  |
| **toolName** | **string** |  |  |
| **entityId** | **string** |  |  |

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
    public class NewAiToolsIsAllowAlwaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var serverType = "serverType_example";  // string | 
            var toolName = "toolName_example";  // string | 
            var entityId = "entityId_example";  // string | 

            try
            {
                // Is allow always
                bool result = apiInstance.NewAiToolsIsAllowAlways(serverType, toolName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsIsAllowAlways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsIsAllowAlwaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Is allow always
    ApiResponse<bool> response = apiInstance.NewAiToolsIsAllowAlwaysWithHttpInfo(serverType, toolName, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsIsAllowAlwaysWithHttpInfo: " + e.Message);
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

<a id="newaitoolsistooldisabled"></a>
# **NewAiToolsIsToolDisabled**
> bool NewAiToolsIsToolDisabled (string serverType, string toolName, string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-is-tool-disabled/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverType** | **string** |  |  |
| **toolName** | **string** |  |  |
| **entityId** | **string** |  |  |

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
    public class NewAiToolsIsToolDisabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var serverType = "serverType_example";  // string | 
            var toolName = "toolName_example";  // string | 
            var entityId = "entityId_example";  // string | 

            try
            {
                // Is tool disabled
                bool result = apiInstance.NewAiToolsIsToolDisabled(serverType, toolName, entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsIsToolDisabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsIsToolDisabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Is tool disabled
    ApiResponse<bool> response = apiInstance.NewAiToolsIsToolDisabledWithHttpInfo(serverType, toolName, entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsIsToolDisabledWithHttpInfo: " + e.Message);
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

<a id="newaitoolslistcustomservers"></a>
# **NewAiToolsListCustomServers**
> Dictionary&lt;string, Object&gt; NewAiToolsListCustomServers (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-custom-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |

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
    public class NewAiToolsListCustomServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // List custom servers
                Dictionary<string, Object> result = apiInstance.NewAiToolsListCustomServers(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsListCustomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsListCustomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List custom servers
    ApiResponse<Dictionary<string, Object>> response = apiInstance.NewAiToolsListCustomServersWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsListCustomServersWithHttpInfo: " + e.Message);
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

<a id="newaitoolslistsystemtools"></a>
# **NewAiToolsListSystemTools**
> Dictionary&lt;string, List&lt;NewAiTMCPItem&gt;&gt; NewAiToolsListSystemTools (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-list-system-tools/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |

### Return type

**Dictionary<string, List<NewAiTMCPItem>>**

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
    public class NewAiToolsListSystemToolsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // List system tools
                Dictionary<string, List<NewAiTMCPItem>> result = apiInstance.NewAiToolsListSystemTools(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsListSystemTools: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsListSystemToolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List system tools
    ApiResponse<Dictionary<string, List<NewAiTMCPItem>>> response = apiInstance.NewAiToolsListSystemToolsWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsListSystemToolsWithHttpInfo: " + e.Message);
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

<a id="newaitoolsremovecustomserver"></a>
# **NewAiToolsRemoveCustomServer**
> NewAiSuccessResponse NewAiToolsRemoveCustomServer (NewAiToolsRemoveCustomServerRequest newAiToolsRemoveCustomServerRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-remove-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiToolsRemoveCustomServerRequest** | [**NewAiToolsRemoveCustomServerRequest**](NewAiToolsRemoveCustomServerRequest.md) |  |  |

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
    public class NewAiToolsRemoveCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var newAiToolsRemoveCustomServerRequest = new NewAiToolsRemoveCustomServerRequest(); // NewAiToolsRemoveCustomServerRequest | 

            try
            {
                // Remove custom server
                NewAiSuccessResponse result = apiInstance.NewAiToolsRemoveCustomServer(newAiToolsRemoveCustomServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsRemoveCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsRemoveCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove custom server
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiToolsRemoveCustomServerWithHttpInfo(newAiToolsRemoveCustomServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsRemoveCustomServerWithHttpInfo: " + e.Message);
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

<a id="newaitoolsreplaceallcustomservers"></a>
# **NewAiToolsReplaceAllCustomServers**
> NewAiToolsBulkResult NewAiToolsReplaceAllCustomServers (NewAiToolsReplaceAllCustomServersRequest newAiToolsReplaceAllCustomServersRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-replace-all-custom-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiToolsReplaceAllCustomServersRequest** | [**NewAiToolsReplaceAllCustomServersRequest**](NewAiToolsReplaceAllCustomServersRequest.md) |  |  |

### Return type

[**NewAiToolsBulkResult**](NewAiToolsBulkResult.md)

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
    public class NewAiToolsReplaceAllCustomServersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var newAiToolsReplaceAllCustomServersRequest = new NewAiToolsReplaceAllCustomServersRequest(); // NewAiToolsReplaceAllCustomServersRequest | 

            try
            {
                // Replace all custom servers
                NewAiToolsBulkResult result = apiInstance.NewAiToolsReplaceAllCustomServers(newAiToolsReplaceAllCustomServersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsReplaceAllCustomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsReplaceAllCustomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace all custom servers
    ApiResponse<NewAiToolsBulkResult> response = apiInstance.NewAiToolsReplaceAllCustomServersWithHttpInfo(newAiToolsReplaceAllCustomServersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsReplaceAllCustomServersWithHttpInfo: " + e.Message);
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

<a id="newaitoolssetallowalways"></a>
# **NewAiToolsSetAllowAlways**
> NewAiSuccessResponse NewAiToolsSetAllowAlways (NewAiToolsSetAllowAlwaysRequest newAiToolsSetAllowAlwaysRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-allow-always/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiToolsSetAllowAlwaysRequest** | [**NewAiToolsSetAllowAlwaysRequest**](NewAiToolsSetAllowAlwaysRequest.md) |  |  |

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
    public class NewAiToolsSetAllowAlwaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var newAiToolsSetAllowAlwaysRequest = new NewAiToolsSetAllowAlwaysRequest(); // NewAiToolsSetAllowAlwaysRequest | 

            try
            {
                // Set allow always
                NewAiSuccessResponse result = apiInstance.NewAiToolsSetAllowAlways(newAiToolsSetAllowAlwaysRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsSetAllowAlways: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsSetAllowAlwaysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set allow always
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiToolsSetAllowAlwaysWithHttpInfo(newAiToolsSetAllowAlwaysRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsSetAllowAlwaysWithHttpInfo: " + e.Message);
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

<a id="newaitoolssetdisabled"></a>
# **NewAiToolsSetDisabled**
> NewAiSuccessResponse NewAiToolsSetDisabled (NewAiToolsSetDisabledRequest newAiToolsSetDisabledRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-set-disabled/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiToolsSetDisabledRequest** | [**NewAiToolsSetDisabledRequest**](NewAiToolsSetDisabledRequest.md) |  |  |

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
    public class NewAiToolsSetDisabledExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var newAiToolsSetDisabledRequest = new NewAiToolsSetDisabledRequest(); // NewAiToolsSetDisabledRequest | 

            try
            {
                // Set disabled
                NewAiSuccessResponse result = apiInstance.NewAiToolsSetDisabled(newAiToolsSetDisabledRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsSetDisabled: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsSetDisabledWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set disabled
    ApiResponse<NewAiSuccessResponse> response = apiInstance.NewAiToolsSetDisabledWithHttpInfo(newAiToolsSetDisabledRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsSetDisabledWithHttpInfo: " + e.Message);
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

<a id="newaitoolsupdatecustomserver"></a>
# **NewAiToolsUpdateCustomServer**
> NewAiToolsMutationResult NewAiToolsUpdateCustomServer (NewAiToolsUpdateCustomServerRequest newAiToolsUpdateCustomServerRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-tools-update-custom-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiToolsUpdateCustomServerRequest** | [**NewAiToolsUpdateCustomServerRequest**](NewAiToolsUpdateCustomServerRequest.md) |  |  |

### Return type

[**NewAiToolsMutationResult**](NewAiToolsMutationResult.md)

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
    public class NewAiToolsUpdateCustomServerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ToolsApi(httpClient, config, httpClientHandler);
            var newAiToolsUpdateCustomServerRequest = new NewAiToolsUpdateCustomServerRequest(); // NewAiToolsUpdateCustomServerRequest | 

            try
            {
                // Update custom server
                NewAiToolsMutationResult result = apiInstance.NewAiToolsUpdateCustomServer(newAiToolsUpdateCustomServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToolsApi.NewAiToolsUpdateCustomServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiToolsUpdateCustomServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update custom server
    ApiResponse<NewAiToolsMutationResult> response = apiInstance.NewAiToolsUpdateCustomServerWithHttpInfo(newAiToolsUpdateCustomServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ToolsApi.NewAiToolsUpdateCustomServerWithHttpInfo: " + e.Message);
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

