# Docspace.Api.SettingsWebpluginsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddWebPluginFromFile**](SettingsWebpluginsApi.md#addwebpluginfromfile) | **POST** /api/2.0/settings/webplugins | Adds web plugins from file |
| [**DeleteWebPlugin**](SettingsWebpluginsApi.md#deletewebplugin) | **DELETE** /api/2.0/settings/webplugins/{name} | Deletes web plugins by name specified in request |
| [**GetWebPlugin**](SettingsWebpluginsApi.md#getwebplugin) | **GET** /api/2.0/settings/webplugins/{name} | Gets web plugins by name specified in request |
| [**GetWebPlugins**](SettingsWebpluginsApi.md#getwebplugins) | **GET** /api/2.0/settings/webplugins | Gets web plugins |
| [**UpdateWebPlugin**](SettingsWebpluginsApi.md#updatewebplugin) | **PUT** /api/2.0/settings/webplugins/{name} | Updates web plugins |

<a id="addwebpluginfromfile"></a>
# **AddWebPluginFromFile**
> WebPluginWrapper AddWebPluginFromFile (bool? varSystem = null)

Adds web plugins from file

Adds web plugins from file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class AddWebPluginFromFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var varSystem = true;  // bool? | System (optional) 

            try
            {
                // Adds web plugins from file
                WebPluginWrapper result = apiInstance.AddWebPluginFromFile(varSystem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebpluginsApi.AddWebPluginFromFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddWebPluginFromFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds web plugins from file
    ApiResponse<WebPluginWrapper> response = apiInstance.AddWebPluginFromFileWithHttpInfo(varSystem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebpluginsApi.AddWebPluginFromFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **varSystem** | **bool?** | System | [optional]  |

### Return type

[**WebPluginWrapper**](WebPluginWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Web plugin |  -  |
| **400** | bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Plugins disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletewebplugin"></a>
# **DeleteWebPlugin**
> void DeleteWebPlugin (string name)

Deletes web plugins by name specified in request

Deletes web plugins by name specified in request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class DeleteWebPluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var name = Winfield Upton;  // string | Name

            try
            {
                // Deletes web plugins by name specified in request
                apiInstance.DeleteWebPlugin(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebpluginsApi.DeleteWebPlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWebPluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes web plugins by name specified in request
    apiInstance.DeleteWebPluginWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebpluginsApi.DeleteWebPluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name |  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | Plugins disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebplugin"></a>
# **GetWebPlugin**
> WebPluginWrapper GetWebPlugin (string name)

Gets web plugins by name specified in request

Gets web plugins by name specified in request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class GetWebPluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var name = Winfield Upton;  // string | Name

            try
            {
                // Gets web plugins by name specified in request
                WebPluginWrapper result = apiInstance.GetWebPlugin(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebpluginsApi.GetWebPlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebPluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets web plugins by name specified in request
    ApiResponse<WebPluginWrapper> response = apiInstance.GetWebPluginWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebpluginsApi.GetWebPluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name |  |

### Return type

[**WebPluginWrapper**](WebPluginWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Web plugin |  -  |
| **401** | Unauthorized |  -  |
| **403** | Plugins disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwebplugins"></a>
# **GetWebPlugins**
> WebPluginArrayWrapper GetWebPlugins (bool? enabled = null)

Gets web plugins

Gets web plugins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class GetWebPluginsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var enabled = true;  // bool? | Enabled (optional) 

            try
            {
                // Gets web plugins
                WebPluginArrayWrapper result = apiInstance.GetWebPlugins(enabled);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebpluginsApi.GetWebPlugins: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWebPluginsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets web plugins
    ApiResponse<WebPluginArrayWrapper> response = apiInstance.GetWebPluginsWithHttpInfo(enabled);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebpluginsApi.GetWebPluginsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enabled** | **bool?** | Enabled | [optional]  |

### Return type

[**WebPluginArrayWrapper**](WebPluginArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Web plugin |  -  |
| **401** | Unauthorized |  -  |
| **403** | Plugins disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebplugin"></a>
# **UpdateWebPlugin**
> void UpdateWebPlugin (string name, WebPluginRequests? webPluginRequests = null)

Updates web plugins

Updates web plugins

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class UpdateWebPluginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var name = Winfield Upton;  // string | Name
            var webPluginRequests = new WebPluginRequests?(); // WebPluginRequests? | Web plugin (optional) 

            try
            {
                // Updates web plugins
                apiInstance.UpdateWebPlugin(name, webPluginRequests);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebpluginsApi.UpdateWebPlugin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebPluginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates web plugins
    apiInstance.UpdateWebPluginWithHttpInfo(name, webPluginRequests);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebpluginsApi.UpdateWebPluginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Name |  |
| **webPluginRequests** | [**WebPluginRequests?**](WebPluginRequests?.md) | Web plugin | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | Plugins disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

