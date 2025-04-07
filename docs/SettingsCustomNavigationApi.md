# Docspace.Api.SettingsCustomNavigationApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomNavigationItem**](SettingsCustomNavigationApi.md#createcustomnavigationitem) | **POST** /api/2.0/settings/customnavigation/create | Add a custom navigation item |
| [**DeleteCustomNavigationItem**](SettingsCustomNavigationApi.md#deletecustomnavigationitem) | **DELETE** /api/2.0/settings/customnavigation/delete/{id} | Delete a custom navigation item |
| [**GetCustomNavigationItem**](SettingsCustomNavigationApi.md#getcustomnavigationitem) | **GET** /api/2.0/settings/customnavigation/get/{id} | Get a custom navigation item by ID |
| [**GetCustomNavigationItemSample**](SettingsCustomNavigationApi.md#getcustomnavigationitemsample) | **GET** /api/2.0/settings/customnavigation/getsample | Get a custom navigation item sample |
| [**GetCustomNavigationItems**](SettingsCustomNavigationApi.md#getcustomnavigationitems) | **GET** /api/2.0/settings/customnavigation/getall | Get the custom navigation items |

<a id="createcustomnavigationitem"></a>
# **CreateCustomNavigationItem**
> CustomNavigationItemWrapper CreateCustomNavigationItem (CustomNavigationItem? customNavigationItem = null)

Add a custom navigation item

Adds a custom navigation item with the parameters specified in the request.

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
    public class CreateCustomNavigationItemExample
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
            var apiInstance = new SettingsCustomNavigationApi(httpClient, config, httpClientHandler);
            var customNavigationItem = new CustomNavigationItem?(); // CustomNavigationItem? |  (optional) 

            try
            {
                // Add a custom navigation item
                CustomNavigationItemWrapper result = apiInstance.CreateCustomNavigationItem(customNavigationItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCustomNavigationApi.CreateCustomNavigationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomNavigationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a custom navigation item
    ApiResponse<CustomNavigationItemWrapper> response = apiInstance.CreateCustomNavigationItemWithHttpInfo(customNavigationItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCustomNavigationApi.CreateCustomNavigationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customNavigationItem** | [**CustomNavigationItem?**](CustomNavigationItem?.md) |  | [optional]  |

### Return type

[**CustomNavigationItemWrapper**](CustomNavigationItemWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom navigation item |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomnavigationitem"></a>
# **DeleteCustomNavigationItem**
> void DeleteCustomNavigationItem (Guid id)

Delete a custom navigation item

Deletes a custom navigation item with the ID specified in the request.

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
    public class DeleteCustomNavigationItemExample
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
            var apiInstance = new SettingsCustomNavigationApi(httpClient, config, httpClientHandler);
            var id = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid | Id

            try
            {
                // Delete a custom navigation item
                apiInstance.DeleteCustomNavigationItem(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCustomNavigationApi.DeleteCustomNavigationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomNavigationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a custom navigation item
    apiInstance.DeleteCustomNavigationItemWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCustomNavigationApi.DeleteCustomNavigationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id |  |

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
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomnavigationitem"></a>
# **GetCustomNavigationItem**
> CustomNavigationItemWrapper GetCustomNavigationItem (Guid id)

Get a custom navigation item by ID

Returns a custom navigation item by the ID specified in the request.

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
    public class GetCustomNavigationItemExample
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
            var apiInstance = new SettingsCustomNavigationApi(httpClient, config, httpClientHandler);
            var id = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid | Id

            try
            {
                // Get a custom navigation item by ID
                CustomNavigationItemWrapper result = apiInstance.GetCustomNavigationItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCustomNavigationApi.GetCustomNavigationItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomNavigationItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a custom navigation item by ID
    ApiResponse<CustomNavigationItemWrapper> response = apiInstance.GetCustomNavigationItemWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCustomNavigationApi.GetCustomNavigationItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Id |  |

### Return type

[**CustomNavigationItemWrapper**](CustomNavigationItemWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom navigation item |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomnavigationitemsample"></a>
# **GetCustomNavigationItemSample**
> CustomNavigationItemWrapper GetCustomNavigationItemSample ()

Get a custom navigation item sample

Returns a custom navigation item sample.

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
    public class GetCustomNavigationItemSampleExample
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
            var apiInstance = new SettingsCustomNavigationApi(httpClient, config, httpClientHandler);

            try
            {
                // Get a custom navigation item sample
                CustomNavigationItemWrapper result = apiInstance.GetCustomNavigationItemSample();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCustomNavigationApi.GetCustomNavigationItemSample: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomNavigationItemSampleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a custom navigation item sample
    ApiResponse<CustomNavigationItemWrapper> response = apiInstance.GetCustomNavigationItemSampleWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCustomNavigationApi.GetCustomNavigationItemSampleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CustomNavigationItemWrapper**](CustomNavigationItemWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom navigation item |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcustomnavigationitems"></a>
# **GetCustomNavigationItems**
> CustomNavigationItemArrayWrapper GetCustomNavigationItems ()

Get the custom navigation items

Returns a list of the custom navigation items.

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
    public class GetCustomNavigationItemsExample
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
            var apiInstance = new SettingsCustomNavigationApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the custom navigation items
                CustomNavigationItemArrayWrapper result = apiInstance.GetCustomNavigationItems();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCustomNavigationApi.GetCustomNavigationItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomNavigationItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the custom navigation items
    ApiResponse<CustomNavigationItemArrayWrapper> response = apiInstance.GetCustomNavigationItemsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCustomNavigationApi.GetCustomNavigationItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CustomNavigationItemArrayWrapper**](CustomNavigationItemArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of the custom navigation items |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

