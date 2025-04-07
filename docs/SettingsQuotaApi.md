# Docspace.Api.SettingsQuotaApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetUserQuotaSettings**](SettingsQuotaApi.md#getuserquotasettings) | **GET** /api/2.0/settings/userquotasettings | Gets user quota |
| [**SaveRoomQuotaSettings**](SettingsQuotaApi.md#saveroomquotasettings) | **POST** /api/2.0/settings/roomquotasettings | Save the room quota settings |
| [**SetTenantQuotaSettings**](SettingsQuotaApi.md#settenantquotasettings) | **PUT** /api/2.0/settings/tenantquotasettings | Save the tenant quota settings |

<a id="getuserquotasettings"></a>
# **GetUserQuotaSettings**
> TenantUserQuotaSettingsWrapper GetUserQuotaSettings ()

Gets user quota

Gets user quota

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
    public class GetUserQuotaSettingsExample
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
            var apiInstance = new SettingsQuotaApi(httpClient, config, httpClientHandler);

            try
            {
                // Gets user quota
                TenantUserQuotaSettingsWrapper result = apiInstance.GetUserQuotaSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsQuotaApi.GetUserQuotaSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserQuotaSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets user quota
    ApiResponse<TenantUserQuotaSettingsWrapper> response = apiInstance.GetUserQuotaSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsQuotaApi.GetUserQuotaSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TenantUserQuotaSettingsWrapper**](TenantUserQuotaSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="saveroomquotasettings"></a>
# **SaveRoomQuotaSettings**
> TenantRoomQuotaSettingsWrapper SaveRoomQuotaSettings (QuotaSettingsRequestsDto? quotaSettingsRequestsDto = null)

Save the room quota settings

Saves the room quota settings specified in the request to the current portal.

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
    public class SaveRoomQuotaSettingsExample
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
            var apiInstance = new SettingsQuotaApi(httpClient, config, httpClientHandler);
            var quotaSettingsRequestsDto = new QuotaSettingsRequestsDto?(); // QuotaSettingsRequestsDto? |  (optional) 

            try
            {
                // Save the room quota settings
                TenantRoomQuotaSettingsWrapper result = apiInstance.SaveRoomQuotaSettings(quotaSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsQuotaApi.SaveRoomQuotaSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveRoomQuotaSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the room quota settings
    ApiResponse<TenantRoomQuotaSettingsWrapper> response = apiInstance.SaveRoomQuotaSettingsWithHttpInfo(quotaSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsQuotaApi.SaveRoomQuotaSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **quotaSettingsRequestsDto** | [**QuotaSettingsRequestsDto?**](QuotaSettingsRequestsDto?.md) |  | [optional]  |

### Return type

[**TenantRoomQuotaSettingsWrapper**](TenantRoomQuotaSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant room quota settings |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settenantquotasettings"></a>
# **SetTenantQuotaSettings**
> TenantQuotaSettingsWrapper SetTenantQuotaSettings (TenantQuotaSettingsRequestsDto? tenantQuotaSettingsRequestsDto = null)

Save the tenant quota settings

Saves the tenant quota settings specified in the request to the current portal.

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
    public class SetTenantQuotaSettingsExample
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
            var apiInstance = new SettingsQuotaApi(httpClient, config, httpClientHandler);
            var tenantQuotaSettingsRequestsDto = new TenantQuotaSettingsRequestsDto?(); // TenantQuotaSettingsRequestsDto? |  (optional) 

            try
            {
                // Save the tenant quota settings
                TenantQuotaSettingsWrapper result = apiInstance.SetTenantQuotaSettings(tenantQuotaSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsQuotaApi.SetTenantQuotaSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetTenantQuotaSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the tenant quota settings
    ApiResponse<TenantQuotaSettingsWrapper> response = apiInstance.SetTenantQuotaSettingsWithHttpInfo(tenantQuotaSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsQuotaApi.SetTenantQuotaSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantQuotaSettingsRequestsDto** | [**TenantQuotaSettingsRequestsDto?**](TenantQuotaSettingsRequestsDto?.md) |  | [optional]  |

### Return type

[**TenantQuotaSettingsWrapper**](TenantQuotaSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant quota settings |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |
| **405** | Not available |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

