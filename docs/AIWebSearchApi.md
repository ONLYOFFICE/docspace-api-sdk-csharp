# DocSpace.API.SDK.Api.WebSearchApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiWebSearchClear**](#aiwebsearchclear) | **DELETE** /api/2.0/ai/web-search/clear | Clear |
| [**AiWebSearchConfigure**](#aiwebsearchconfigure) | **PUT** /api/2.0/ai/web-search/configure | Configure |
| [**AiWebSearchGetActiveConfig**](#aiwebsearchgetactiveconfig) | **GET** /api/2.0/ai/web-search/get-active-config | Get active config |
| [**AiWebSearchIsConfigured**](#aiwebsearchisconfigured) | **GET** /api/2.0/ai/web-search/is-configured | Is configured |
| [**AiWebSearchSetActiveConfig**](#aiwebsearchsetactiveconfig) | **PUT** /api/2.0/ai/web-search/set-active-config | Set active config |
| [**AiWebSearchTestConnection**](#aiwebsearchtestconnection) | **POST** /api/2.0/ai/web-search/test-connection | Test connection |

<a id="aiwebsearchclear"></a>
# **AiWebSearchClear**
> AiSuccessResponse AiWebSearchClear (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/).

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
            var body = "body_example";  // string | 

            try
            {
                // Clear
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
    // Clear
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchconfigure"></a>
# **AiWebSearchConfigure**
> AiWebSearchMutationResult AiWebSearchConfigure (AiWebSearchConfigureRequest aiWebSearchConfigureRequest)



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
                // Configure
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
    // Configure
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchgetactiveconfig"></a>
# **AiWebSearchGetActiveConfig**
> AiWebSearchConfig AiWebSearchGetActiveConfig (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityId** | **string** |  |  |

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
            var entityId = "entityId_example";  // string | 

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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchisconfigured"></a>
# **AiWebSearchIsConfigured**
> bool AiWebSearchIsConfigured (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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
            var entityId = "entityId_example";  // string | 

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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchsetactiveconfig"></a>
# **AiWebSearchSetActiveConfig**
> AiSuccessResponse AiWebSearchSetActiveConfig (AiWebSearchConfigureRequest aiWebSearchConfigureRequest)



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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiwebsearchtestconnection"></a>
# **AiWebSearchTestConnection**
> AiProfilesTestConnection200Response AiWebSearchTestConnection (AiWebSearchConfig aiWebSearchConfig)



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
                // Test connection
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
    // Test connection
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

