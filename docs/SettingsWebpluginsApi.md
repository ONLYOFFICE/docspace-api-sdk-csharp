# Docspace.Api.SettingsWebpluginsApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddWebPluginFromFile**](SettingsWebpluginsApi.md#addwebpluginfromfile) | **POST** /api/2.0/settings/webplugins | Add a web plugin |
| [**DeleteWebPlugin**](SettingsWebpluginsApi.md#deletewebplugin) | **DELETE** /api/2.0/settings/webplugins/{name} | Delete a web plugin |
| [**GetWebPlugin**](SettingsWebpluginsApi.md#getwebplugin) | **GET** /api/2.0/settings/webplugins/{name} | Get a web plugin by name |
| [**GetWebPlugins**](SettingsWebpluginsApi.md#getwebplugins) | **GET** /api/2.0/settings/webplugins | Get web plugins |
| [**UpdateWebPlugin**](SettingsWebpluginsApi.md#updatewebplugin) | **PUT** /api/2.0/settings/webplugins/{name} | Update a web plugin |

<a id="addwebpluginfromfile"></a>
# **AddWebPluginFromFile**
> WebPluginWrapper AddWebPluginFromFile (bool? varSystem = null)

Add a web plugin

Adds a web plugin from a file to the current portal.

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
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var varSystem = true;  // bool? | Specifies whether to load the system plugins or not. (optional) 

            try
            {
                // Add a web plugin
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
    // Add a web plugin
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
| **varSystem** | **bool?** | Specifies whether to load the system plugins or not. | [optional]  |

### Return type

[**WebPluginWrapper**](WebPluginWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

Delete a web plugin

Deletes a web plugin by the name specified in the request.

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
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var name = Winfield Upton;  // string | The web plugin name.

            try
            {
                // Delete a web plugin
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
    // Delete a web plugin
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
| **name** | **string** | The web plugin name. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

Get a web plugin by name

Returns a web plugin by the name specified in the request.

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
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var name = Winfield Upton;  // string | The web plugin name.

            try
            {
                // Get a web plugin by name
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
    // Get a web plugin by name
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
| **name** | **string** | The web plugin name. |  |

### Return type

[**WebPluginWrapper**](WebPluginWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

Get web plugins

Returns the portal web plugins.

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
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var enabled = true;  // bool? | The optional filter for the plugin enabled state. (optional) 

            try
            {
                // Get web plugins
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
    // Get web plugins
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
| **enabled** | **bool?** | The optional filter for the plugin enabled state. | [optional]  |

### Return type

[**WebPluginArrayWrapper**](WebPluginArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

Update a web plugin

Updates a web plugin with the parameters specified in the request.

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
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsWebpluginsApi(httpClient, config, httpClientHandler);
            var name = Winfield Upton;  // string | The web plugin name.
            var webPluginRequests = new WebPluginRequests?(); // WebPluginRequests? | The configuration settings for the web plugin instance. (optional) 

            try
            {
                // Update a web plugin
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
    // Update a web plugin
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
| **name** | **string** | The web plugin name. |  |
| **webPluginRequests** | [**WebPluginRequests?**](WebPluginRequests?.md) | The configuration settings for the web plugin instance. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

