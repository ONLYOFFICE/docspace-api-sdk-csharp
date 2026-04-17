# DocSpace.API.SDK.Api.MessagesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExportMessage**](#exportmessage) | **POST** /api/2.0/ai/messages/{messageId}/export | Export a single AI message to a document |

<a id="exportmessage"></a>
# **ExportMessage**
> void ExportMessage (int messageId, ExportMessageRequestBody exportMessageRequestBody)

Exports a specific AI chat message as a document into the specified folder. The system verifies that the message exists  and belongs to a chat accessible by the current user, then publishes an asynchronous export task to the event bus.  The exported document will be created in the target folder with the given title once the background task completes.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/export-message/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **int** | The unique identifier of the AI chat message to export. |  |
| **exportMessageRequestBody** | [**ExportMessageRequestBody**](ExportMessageRequestBody.md) | The export parameters including destination folder and file title. |  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
    public class ExportMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: ApiKeyBearer
            config.AddApiKey("ApiKeyBearer", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("ApiKeyBearer", "Bearer");
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagesApi(httpClient, config, httpClientHandler);
            var messageId = 1;  // int | The unique identifier of the AI chat message to export.
            var exportMessageRequestBody = new ExportMessageRequestBody(); // ExportMessageRequestBody | The export parameters including destination folder and file title.

            try
            {
                // Export a single AI message to a document
                apiInstance.ExportMessage(messageId, exportMessageRequestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.ExportMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export a single AI message to a document
    apiInstance.ExportMessageWithHttpInfo(messageId, exportMessageRequestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.ExportMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The message export task has been successfully queued for background processing |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The message identifier is invalid (must be greater than 0) |  -  |
| **404** | The specified message was not found or the current user does not have access to it |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

