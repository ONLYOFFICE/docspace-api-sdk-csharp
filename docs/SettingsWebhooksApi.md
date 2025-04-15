# Docspace.Api.SettingsWebhooksApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWebhook**](SettingsWebhooksApi.md#createwebhook) | **POST** /api/2.0/settings/webhook | Create a webhook |
| [**EnableWebhook**](SettingsWebhooksApi.md#enablewebhook) | **PUT** /api/2.0/settings/webhook/enable | Enable a webhook |
| [**GetJournal**](SettingsWebhooksApi.md#getjournal) | **GET** /api/2.0/settings/webhooks/log | Get webhook logs |
| [**GetTenantWebhooks**](SettingsWebhooksApi.md#gettenantwebhooks) | **GET** /api/2.0/settings/webhook | Get webhooks |
| [**RemoveWebhook**](SettingsWebhooksApi.md#removewebhook) | **DELETE** /api/2.0/settings/webhook/{id} | Remove a webhook |
| [**RetryWebhook**](SettingsWebhooksApi.md#retrywebhook) | **PUT** /api/2.0/settings/webhook/{id}/retry | Retry a webhook |
| [**RetryWebhooks**](SettingsWebhooksApi.md#retrywebhooks) | **PUT** /api/2.0/settings/webhook/retry | Retry webhooks |
| [**Triggers**](SettingsWebhooksApi.md#triggers) | **GET** /api/2.0/settings/webhook/triggers | Get webhook triggers |
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

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Tenant webhook with its config parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="enablewebhook"></a>
# **EnableWebhook**
> WebhooksConfigWrapper EnableWebhook (WebhooksConfigRequestsDto? webhooksConfigRequestsDto = null)

Enable a webhook

Enables or disables a tenant webhook with the parameters specified in the request.

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
    public class EnableWebhookExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var webhooksConfigRequestsDto = new WebhooksConfigRequestsDto?(); // WebhooksConfigRequestsDto? |  (optional) 

            try
            {
                // Enable a webhook
                WebhooksConfigWrapper result = apiInstance.EnableWebhook(webhooksConfigRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.EnableWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable a webhook
    ApiResponse<WebhooksConfigWrapper> response = apiInstance.EnableWebhookWithHttpInfo(webhooksConfigRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.EnableWebhookWithHttpInfo: " + e.Message);
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

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Enable or disable tenant webhook |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjournal"></a>
# **GetJournal**
> WebhooksLogArrayWrapper GetJournal (DateTime? deliveryFrom = null, DateTime? deliveryTo = null, string? hookUri = null, int? configId = null, int? eventId = null, WebhookGroupStatus? groupStatus = null, Guid? userId = null, WebhookTrigger? trigger = null)

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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var deliveryFrom = 2008-04-10T06:30+04:00;  // DateTime? | The delivery start time for filtering webhook logs. (optional) 
            var deliveryTo = 2008-04-10T06:30+04:00;  // DateTime? | The delivery end time for filtering webhook logs. (optional) 
            var hookUri = some text;  // string? | The destination URL where webhooks are delivered. (optional) 
            var configId = 1234;  // int? | The webhook configuration identifier. (optional) 
            var eventId = 1234;  // int? | The unique identifier of the event that triggered the webhook. (optional) 
            var groupStatus = new WebhookGroupStatus?(); // WebhookGroupStatus? | The status of the webhook delivery group. (optional) 
            var userId = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid? | The identifier of the user associated with the webhook event. (optional) 
            var trigger = new WebhookTrigger?(); // WebhookTrigger? | The type of event that triggered the webhook. (optional) 

            try
            {
                // Get webhook logs
                WebhooksLogArrayWrapper result = apiInstance.GetJournal(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger);
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
    ApiResponse<WebhooksLogArrayWrapper> response = apiInstance.GetJournalWithHttpInfo(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger);
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
| **deliveryFrom** | **DateTime?** | The delivery start time for filtering webhook logs. | [optional]  |
| **deliveryTo** | **DateTime?** | The delivery end time for filtering webhook logs. | [optional]  |
| **hookUri** | **string?** | The destination URL where webhooks are delivered. | [optional]  |
| **configId** | **int?** | The webhook configuration identifier. | [optional]  |
| **eventId** | **int?** | The unique identifier of the event that triggered the webhook. | [optional]  |
| **groupStatus** | [**WebhookGroupStatus?**](WebhookGroupStatus?.md) | The status of the webhook delivery group. | [optional]  |
| **userId** | **Guid?** | The identifier of the user associated with the webhook event. | [optional]  |
| **trigger** | [**WebhookTrigger?**](WebhookTrigger?.md) | The type of event that triggered the webhook. | [optional]  |

### Return type

[**WebhooksLogArrayWrapper**](WebhooksLogArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

Removes a tenant webhook with the ID specified in the request.

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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The ID extracted from the route parameters.

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
| **id** | **int** | The ID extracted from the route parameters. |  |

### Return type

[**WebhooksConfigWrapper**](WebhooksConfigWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The ID extracted from the route parameters.

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
| **id** | **int** | The ID extracted from the route parameters. |  |

### Return type

[**WebhooksLogWrapper**](WebhooksLogWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs of the webhook activities |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="triggers"></a>
# **Triggers**
> UnknownWrapper Triggers ()

Get webhook triggers

Returns a list of triggers for a webhook.

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
    public class TriggersExample
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
            var apiInstance = new SettingsWebhooksApi(httpClient, config, httpClientHandler);

            try
            {
                // Get webhook triggers
                UnknownWrapper result = apiInstance.Triggers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsWebhooksApi.Triggers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TriggersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get webhook triggers
    ApiResponse<UnknownWrapper> response = apiInstance.TriggersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsWebhooksApi.TriggersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnknownWrapper**](UnknownWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of triggers for a webhook |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatewebhook"></a>
# **UpdateWebhook**
> WebhooksConfigWrapper UpdateWebhook (WebhooksConfigRequestsDto? webhooksConfigRequestsDto = null)

Update a webhook

Updates a tenant webhook with the parameters specified in the request.

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

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated tenant webhook with its config parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

