# Docspace.Api.SettingsWebhooksApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhook**](SettingsWebhooksApi.md#createwebhook) | **POST** /api/2.0/settings/webhook | Create a webhook |
| [**DisableWebHook**](SettingsWebhooksApi.md#disablewebhook) | **PUT** /api/2.0/settings/webhook/{id} | Disable a webhook |
| [**GetJournal**](SettingsWebhooksApi.md#getjournal) | **GET** /api/2.0/settings/webhooks/log | Get webhook logs |
| [**GetTenantWebhooks**](SettingsWebhooksApi.md#gettenantwebhooks) | **GET** /api/2.0/settings/webhook | Get webhooks |
| [**RemoveWebhook**](SettingsWebhooksApi.md#removewebhook) | **DELETE** /api/2.0/settings/webhook/{id} | Remove a webhook |
| [**RetryWebhook**](SettingsWebhooksApi.md#retrywebhook) | **PUT** /api/2.0/settings/webhook/{id}/retry | Retry a webhook |
| [**RetryWebhooks**](SettingsWebhooksApi.md#retrywebhooks) | **PUT** /api/2.0/settings/webhook/retry | Retry webhooks |
| [**Settings**](SettingsWebhooksApi.md#settings) | **GET** /api/2.0/settings/webhooks | Get webhook settings |
| [**UpdateWebhook**](SettingsWebhooksApi.md#updatewebhook) | **PUT** /api/2.0/settings/webhook | Update a webhook |

<a id="createwebhook"></a>
# **CreateWebhook**
> WebhooksConfigWrapper CreateWebhook (WebhooksConfigRequestsDto? webhooksConfigRequestsDto = null)

Create a webhook

Creates a new tenant webhook with the parameters specified in the request.

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
    public class CreateWebhookExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var webhooksConfigRequestsDto = new WebhooksConfigRequestsDto?(); // WebhooksConfigRequestsDto? |  (optional) 

            try
            {
                // Create a webhook
                WebhooksConfigWrapper result = apiInstance.CreateWebhook(webhooksConfigRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.CreateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a webhook
    ApiResponse<WebhooksConfigWrapper> response = apiInstance.CreateWebhookWithHttpInfo(webhooksConfigRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.CreateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhooksConfigRequestsDto** | [**WebhooksConfigRequestsDto?**](WebhooksConfigRequestsDto?.md) |  | [optional]  |

### Return type

[**WebhooksConfigWrapper**](WebhooksConfigWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant webhook with its config parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="disablewebhook"></a>
# **DisableWebHook**
> WebhookWrapper DisableWebHook (int id)

Disable a webhook

Disables a webhook with the ID specified in the request.

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
    public class DisableWebHookExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Id

            try
            {
                // Disable a webhook
                WebhookWrapper result = apiInstance.DisableWebHook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.DisableWebHook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableWebHookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable a webhook
    ApiResponse<WebhookWrapper> response = apiInstance.DisableWebHookWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.DisableWebHookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Id |  |

### Return type

[**WebhookWrapper**](WebhookWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjournal"></a>
# **GetJournal**
> WebhooksLogArrayWrapper GetJournal (DateTime? deliveryFrom = null, DateTime? deliveryTo = null, string? hookUri = null, int? webhookId = null, int? configId = null, int? eventId = null, WebhookGroupStatus? groupStatus = null)

Get webhook logs

Returns the logs of the webhook activities.

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
    public class GetJournalExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var deliveryFrom = 2008-04-10T06:30+04:00;  // DateTime? | Delivey start time (optional) 
            var deliveryTo = 2008-04-10T06:30+04:00;  // DateTime? | Delivey end time (optional) 
            var hookUri = some text;  // string? | Hook URI (optional) 
            var webhookId = 1234;  // int? | Webhook ID (optional) 
            var configId = 1234;  // int? | Config ID (optional) 
            var eventId = 1234;  // int? | Event ID (optional) 
            var groupStatus = new WebhookGroupStatus?(); // WebhookGroupStatus? | Webhook group status (optional) 

            try
            {
                // Get webhook logs
                WebhooksLogArrayWrapper result = apiInstance.GetJournal(deliveryFrom, deliveryTo, hookUri, webhookId, configId, eventId, groupStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.GetJournal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJournalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get webhook logs
    ApiResponse<WebhooksLogArrayWrapper> response = apiInstance.GetJournalWithHttpInfo(deliveryFrom, deliveryTo, hookUri, webhookId, configId, eventId, groupStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.GetJournalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deliveryFrom** | **DateTime?** | Delivey start time | [optional]  |
| **deliveryTo** | **DateTime?** | Delivey end time | [optional]  |
| **hookUri** | **string?** | Hook URI | [optional]  |
| **webhookId** | **int?** | Webhook ID | [optional]  |
| **configId** | **int?** | Config ID | [optional]  |
| **eventId** | **int?** | Event ID | [optional]  |
| **groupStatus** | [**WebhookGroupStatus?**](WebhookGroupStatus?.md) | Webhook group status | [optional]  |

### Return type

[**WebhooksLogArrayWrapper**](WebhooksLogArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs of the webhook activities |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantwebhooks"></a>
# **GetTenantWebhooks**
> WebhooksConfigWithStatusArrayWrapper GetTenantWebhooks ()

Get webhooks

Returns a list of the tenant webhooks.

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
    public class GetTenantWebhooksExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);

            try
            {
                // Get webhooks
                WebhooksConfigWithStatusArrayWrapper result = apiInstance.GetTenantWebhooks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.GetTenantWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get webhooks
    ApiResponse<WebhooksConfigWithStatusArrayWrapper> response = apiInstance.GetTenantWebhooksWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.GetTenantWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WebhooksConfigWithStatusArrayWrapper**](WebhooksConfigWithStatusArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of tenant webhooks with their config parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removewebhook"></a>
# **RemoveWebhook**
> WebhooksConfigWrapper RemoveWebhook (int id)

Remove a webhook

Removes the tenant webhook with the ID specified in the request.

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
    public class RemoveWebhookExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Id

            try
            {
                // Remove a webhook
                WebhooksConfigWrapper result = apiInstance.RemoveWebhook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.RemoveWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a webhook
    ApiResponse<WebhooksConfigWrapper> response = apiInstance.RemoveWebhookWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.RemoveWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Id |  |

### Return type

[**WebhooksConfigWrapper**](WebhooksConfigWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant webhook with its config parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrywebhook"></a>
# **RetryWebhook**
> WebhooksLogWrapper RetryWebhook (int id)

Retry a webhook

Retries a webhook with the ID specified in the request.

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
    public class RetryWebhookExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Id

            try
            {
                // Retry a webhook
                WebhooksLogWrapper result = apiInstance.RetryWebhook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.RetryWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetryWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retry a webhook
    ApiResponse<WebhooksLogWrapper> response = apiInstance.RetryWebhookWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.RetryWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Id |  |

### Return type

[**WebhooksLogWrapper**](WebhooksLogWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs of the webhook activities |  -  |
| **400** | Id incorrect |  -  |
| **401** | Unauthorized |  -  |
| **404** | Item not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrywebhooks"></a>
# **RetryWebhooks**
> WebhooksLogArrayWrapper RetryWebhooks (WebhookRetryRequestsDto? webhookRetryRequestsDto = null)

Retry webhooks

Retries all the webhooks with the IDs specified in the request.

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
    public class RetryWebhooksExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var webhookRetryRequestsDto = new WebhookRetryRequestsDto?(); // WebhookRetryRequestsDto? |  (optional) 

            try
            {
                // Retry webhooks
                WebhooksLogArrayWrapper result = apiInstance.RetryWebhooks(webhookRetryRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.RetryWebhooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetryWebhooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retry webhooks
    ApiResponse<WebhooksLogArrayWrapper> response = apiInstance.RetryWebhooksWithHttpInfo(webhookRetryRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.RetryWebhooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhookRetryRequestsDto** | [**WebhookRetryRequestsDto?**](WebhookRetryRequestsDto?.md) |  | [optional]  |

### Return type

[**WebhooksLogArrayWrapper**](WebhooksLogArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs of the webhook activities |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settings"></a>
# **Settings**
> WebhookArrayWrapper Settings ()

Get webhook settings

Returns settings of all webhooks.

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
    public class SettingsExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);

            try
            {
                // Get webhook settings
                WebhookArrayWrapper result = apiInstance.Settings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.Settings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get webhook settings
    ApiResponse<WebhookArrayWrapper> response = apiInstance.SettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.SettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**WebhookArrayWrapper**](WebhookArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of webhook settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
> WebhooksConfigWrapper UpdateWebhook (WebhooksConfigRequestsDto? webhooksConfigRequestsDto = null)

Update a webhook

Updates the tenant webhook with the parameters specified in the request.

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
    public class UpdateWebhookExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var webhooksConfigRequestsDto = new WebhooksConfigRequestsDto?(); // WebhooksConfigRequestsDto? |  (optional) 

            try
            {
                // Update a webhook
                WebhooksConfigWrapper result = apiInstance.UpdateWebhook(webhooksConfigRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.UpdateWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a webhook
    ApiResponse<WebhooksConfigWrapper> response = apiInstance.UpdateWebhookWithHttpInfo(webhooksConfigRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.UpdateWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **webhooksConfigRequestsDto** | [**WebhooksConfigRequestsDto?**](WebhooksConfigRequestsDto?.md) |  | [optional]  |

### Return type

[**WebhooksConfigWrapper**](WebhooksConfigWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated tenant webhook with its config parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

