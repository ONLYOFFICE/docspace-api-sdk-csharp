# DocSpace.API.SDK.Api.PreferencesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiPreferencesClearDeepMode**](#aipreferencescleardeepmode) | **DELETE** /api/2.0/ai/preferences/clear-deep-mode | Clear deep mode |
| [**AiPreferencesGetDeepMode**](#aipreferencesgetdeepmode) | **GET** /api/2.0/ai/preferences/get-deep-mode | Get deep mode |
| [**AiPreferencesIsDeepModeSet**](#aipreferencesisdeepmodeset) | **GET** /api/2.0/ai/preferences/is-deep-mode-set | Is deep mode set |
| [**AiPreferencesSetDeepMode**](#aipreferencessetdeepmode) | **PUT** /api/2.0/ai/preferences/set-deep-mode | Set deep mode |

<a id="aipreferencescleardeepmode"></a>
# **AiPreferencesClearDeepMode**
> AiSuccessResponse AiPreferencesClearDeepMode (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-clear-deep-mode/).

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
    public class AiPreferencesClearDeepModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PreferencesApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | 

            try
            {
                // Clear deep mode
                AiSuccessResponse result = apiInstance.AiPreferencesClearDeepMode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.AiPreferencesClearDeepMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiPreferencesClearDeepModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear deep mode
    ApiResponse<AiSuccessResponse> response = apiInstance.AiPreferencesClearDeepModeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreferencesApi.AiPreferencesClearDeepModeWithHttpInfo: " + e.Message);
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

<a id="aipreferencesgetdeepmode"></a>
# **AiPreferencesGetDeepMode**
> bool AiPreferencesGetDeepMode (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-get-deep-mode/).

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
    public class AiPreferencesGetDeepModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PreferencesApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // Get deep mode
                bool result = apiInstance.AiPreferencesGetDeepMode(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.AiPreferencesGetDeepMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiPreferencesGetDeepModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get deep mode
    ApiResponse<bool> response = apiInstance.AiPreferencesGetDeepModeWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreferencesApi.AiPreferencesGetDeepModeWithHttpInfo: " + e.Message);
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

<a id="aipreferencesisdeepmodeset"></a>
# **AiPreferencesIsDeepModeSet**
> bool AiPreferencesIsDeepModeSet (string entityId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-is-deep-mode-set/).

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
    public class AiPreferencesIsDeepModeSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PreferencesApi(httpClient, config, httpClientHandler);
            var entityId = "entityId_example";  // string | 

            try
            {
                // Is deep mode set
                bool result = apiInstance.AiPreferencesIsDeepModeSet(entityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.AiPreferencesIsDeepModeSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiPreferencesIsDeepModeSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Is deep mode set
    ApiResponse<bool> response = apiInstance.AiPreferencesIsDeepModeSetWithHttpInfo(entityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreferencesApi.AiPreferencesIsDeepModeSetWithHttpInfo: " + e.Message);
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

<a id="aipreferencessetdeepmode"></a>
# **AiPreferencesSetDeepMode**
> AiSuccessResponse AiPreferencesSetDeepMode (AiPreferencesSetDeepModeRequest aiPreferencesSetDeepModeRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-preferences-set-deep-mode/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiPreferencesSetDeepModeRequest** | [**AiPreferencesSetDeepModeRequest**](AiPreferencesSetDeepModeRequest.md) |  |  |

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
    public class AiPreferencesSetDeepModeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PreferencesApi(httpClient, config, httpClientHandler);
            var aiPreferencesSetDeepModeRequest = new AiPreferencesSetDeepModeRequest(); // AiPreferencesSetDeepModeRequest | 

            try
            {
                // Set deep mode
                AiSuccessResponse result = apiInstance.AiPreferencesSetDeepMode(aiPreferencesSetDeepModeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.AiPreferencesSetDeepMode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiPreferencesSetDeepModeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set deep mode
    ApiResponse<AiSuccessResponse> response = apiInstance.AiPreferencesSetDeepModeWithHttpInfo(aiPreferencesSetDeepModeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreferencesApi.AiPreferencesSetDeepModeWithHttpInfo: " + e.Message);
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

