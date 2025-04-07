# Docspace.Api.SecurityAuditTrailDataApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAuditTrailReport**](SecurityAuditTrailDataApi.md#createaudittrailreport) | **POST** /api/2.0/security/audit/events/report | Generate the audit trail report |
| [**GetAuditEventsByFilter**](SecurityAuditTrailDataApi.md#getauditeventsbyfilter) | **GET** /api/2.0/security/audit/events/filter | Get filtered audit trail data |
| [**GetAuditSettings**](SecurityAuditTrailDataApi.md#getauditsettings) | **GET** /api/2.0/security/audit/settings/lifetime | Get the audit trail settings |
| [**GetLastAuditEvents**](SecurityAuditTrailDataApi.md#getlastauditevents) | **GET** /api/2.0/security/audit/events/last | Get audit trail data |
| [**GetMappers**](SecurityAuditTrailDataApi.md#getmappers) | **GET** /api/2.0/security/audit/mappers | Get audit trail mappers |
| [**GetTypes**](SecurityAuditTrailDataApi.md#gettypes) | **GET** /api/2.0/security/audit/types | Get audit trail types |
| [**SetAuditSettings**](SecurityAuditTrailDataApi.md#setauditsettings) | **POST** /api/2.0/security/audit/settings/lifetime | Set the audit trail settings |

<a id="createaudittrailreport"></a>
# **CreateAuditTrailReport**
> StringWrapper CreateAuditTrailReport ()

Generate the audit trail report

Generates the audit trail report.

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
    public class CreateAuditTrailReportExample
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
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);

            try
            {
                // Generate the audit trail report
                StringWrapper result = apiInstance.CreateAuditTrailReport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.CreateAuditTrailReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAuditTrailReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate the audit trail report
    ApiResponse<StringWrapper> response = apiInstance.CreateAuditTrailReportWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.CreateAuditTrailReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | URL to the xlsx report file |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |
| **403** | You don&#39;t have enough permission to create |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauditeventsbyfilter"></a>
# **GetAuditEventsByFilter**
> AuditEventArrayWrapper GetAuditEventsByFilter (Guid? userId = null, ProductType? productType = null, ModuleType? moduleType = null, ActionType? actionType = null, MessageAction? action = null, EntryType? entryType = null, string? target = null, ApiDateTime? from = null, ApiDateTime? to = null)

Get filtered audit trail data

Returns a list of the audit events by the parameters specified in the request.

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
    public class GetAuditEventsByFilterExample
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
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);
            var userId = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid? | User ID (optional) 
            var productType = new ProductType?(); // ProductType? | Product (optional) 
            var moduleType = new ModuleType?(); // ModuleType? | Module (optional) 
            var actionType = new ActionType?(); // ActionType? | Action type (optional) 
            var action = new MessageAction?(); // MessageAction? | Action (optional) 
            var entryType = new EntryType?(); // EntryType? | Entry (optional) 
            var target = some text;  // string? | Target (optional) 
            var from = new ApiDateTime?(); // ApiDateTime? | Start date (optional) 
            var to = new ApiDateTime?(); // ApiDateTime? | End date (optional) 

            try
            {
                // Get filtered audit trail data
                AuditEventArrayWrapper result = apiInstance.GetAuditEventsByFilter(userId, productType, moduleType, actionType, action, entryType, target, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetAuditEventsByFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuditEventsByFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get filtered audit trail data
    ApiResponse<AuditEventArrayWrapper> response = apiInstance.GetAuditEventsByFilterWithHttpInfo(userId, productType, moduleType, actionType, action, entryType, target, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetAuditEventsByFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid?** | User ID | [optional]  |
| **productType** | [**ProductType?**](ProductType?.md) | Product | [optional]  |
| **moduleType** | [**ModuleType?**](ModuleType?.md) | Module | [optional]  |
| **actionType** | [**ActionType?**](ActionType?.md) | Action type | [optional]  |
| **action** | [**MessageAction?**](MessageAction?.md) | Action | [optional]  |
| **entryType** | [**EntryType?**](EntryType?.md) | Entry | [optional]  |
| **target** | **string?** | Target | [optional]  |
| **from** | [**ApiDateTime?**](ApiDateTime?.md) | Start date | [optional]  |
| **to** | [**ApiDateTime?**](ApiDateTime?.md) | End date | [optional]  |

### Return type

[**AuditEventArrayWrapper**](AuditEventArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of filtered audit trail data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getauditsettings"></a>
# **GetAuditSettings**
> TenantAuditSettingsWrapper GetAuditSettings ()

Get the audit trail settings

Returns the audit trail settings.

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
    public class GetAuditSettingsExample
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
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the audit trail settings
                TenantAuditSettingsWrapper result = apiInstance.GetAuditSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetAuditSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuditSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the audit trail settings
    ApiResponse<TenantAuditSettingsWrapper> response = apiInstance.GetAuditSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetAuditSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TenantAuditSettingsWrapper**](TenantAuditSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audit settings |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlastauditevents"></a>
# **GetLastAuditEvents**
> AuditEventArrayWrapper GetLastAuditEvents ()

Get audit trail data

Returns a list of the latest changes (creation, modification, deletion, etc.) made by users to the entities (tasks, opportunities, files, etc.) on the portal.

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
    public class GetLastAuditEventsExample
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
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);

            try
            {
                // Get audit trail data
                AuditEventArrayWrapper result = apiInstance.GetLastAuditEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetLastAuditEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLastAuditEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit trail data
    ApiResponse<AuditEventArrayWrapper> response = apiInstance.GetLastAuditEventsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetLastAuditEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AuditEventArrayWrapper**](AuditEventArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of audit trail data |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmappers"></a>
# **GetMappers**
> ObjectWrapper GetMappers (ProductType? productType = null, ModuleType? moduleType = null)

Get audit trail mappers

Returns the mappers for the audit trail types.

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
    public class GetMappersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);
            var productType = new ProductType?(); // ProductType? | Product (optional) 
            var moduleType = new ModuleType?(); // ModuleType? | Module (optional) 

            try
            {
                // Get audit trail mappers
                ObjectWrapper result = apiInstance.GetMappers(productType, moduleType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetMappers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMappersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit trail mappers
    ApiResponse<ObjectWrapper> response = apiInstance.GetMappersWithHttpInfo(productType, moduleType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetMappersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productType** | [**ProductType?**](ProductType?.md) | Product | [optional]  |
| **moduleType** | [**ModuleType?**](ModuleType?.md) | Module | [optional]  |

### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audit trail mappers |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettypes"></a>
# **GetTypes**
> ObjectWrapper GetTypes ()

Get audit trail types

Returns all the available audit trail types.

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
    public class GetTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);

            try
            {
                // Get audit trail types
                ObjectWrapper result = apiInstance.GetTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get audit trail types
    ApiResponse<ObjectWrapper> response = apiInstance.GetTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.GetTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audit trail types |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setauditsettings"></a>
# **SetAuditSettings**
> TenantAuditSettingsWrapper SetAuditSettings (TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = null)

Set the audit trail settings

Sets the audit trail settings for the current portal.

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
    public class SetAuditSettingsExample
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
            var apiInstance = new SecurityAuditTrailDataApi(httpClient, config, httpClientHandler);
            var tenantAuditSettingsWrapper = new TenantAuditSettingsWrapper?(); // TenantAuditSettingsWrapper? |  (optional) 

            try
            {
                // Set the audit trail settings
                TenantAuditSettingsWrapper result = apiInstance.SetAuditSettings(tenantAuditSettingsWrapper);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAuditTrailDataApi.SetAuditSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetAuditSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the audit trail settings
    ApiResponse<TenantAuditSettingsWrapper> response = apiInstance.SetAuditSettingsWithHttpInfo(tenantAuditSettingsWrapper);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAuditTrailDataApi.SetAuditSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantAuditSettingsWrapper** | [**TenantAuditSettingsWrapper?**](TenantAuditSettingsWrapper?.md) |  | [optional]  |

### Return type

[**TenantAuditSettingsWrapper**](TenantAuditSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Audit trail settings |  -  |
| **400** | Exception in LoginHistoryLifeTime or AuditTrailLifeTime |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

