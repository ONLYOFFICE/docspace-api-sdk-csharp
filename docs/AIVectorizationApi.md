# DocSpace.API.SDK.Api.VectorizationApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiVectorizationStartTask**](#aivectorizationstarttask) | **POST** /api/2.0/ai/vectorization/tasks | Start a vectorization task |

<a id="aivectorizationstarttask"></a>
# **AiVectorizationStartTask**
> AiVectorizationStartTask200Response AiVectorizationStartTask (AiVectorizationStartTaskRequest aiVectorizationStartTaskRequest)

Queues the indexing of the portal files named in the body so their contents can be retrieved during a chat round. The body is proxied unchanged to the DocSpace AI service, which validates it and owns the job. Indexing is asynchronous and fire-and-forget: the answer acknowledges the request without carrying a job handle, so there is nothing to poll and progress is not reported here. The embedding provider used is the one in `GET api/2.0/ai/config/vectorization`, and changing that setting does not re-index anything already indexed - queue it again for that.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-vectorization-start-task/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiVectorizationStartTaskRequest** | [**AiVectorizationStartTaskRequest**](AiVectorizationStartTaskRequest.md) | The files to index, proxied unchanged to the DocSpace AI service, which owns and validates the shape. |  |

### Return type

[**AiVectorizationStartTask200Response**](AiVectorizationStartTask200Response.md)

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
    public class AiVectorizationStartTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VectorizationApi(httpClient, config, httpClientHandler);
            var aiVectorizationStartTaskRequest = new AiVectorizationStartTaskRequest(); // AiVectorizationStartTaskRequest | The files to index, proxied unchanged to the DocSpace AI service, which owns and validates the shape.

            try
            {
                // Start a vectorization task
                AiVectorizationStartTask200Response result = apiInstance.AiVectorizationStartTask(aiVectorizationStartTaskRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VectorizationApi.AiVectorizationStartTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiVectorizationStartTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start a vectorization task
    ApiResponse<AiVectorizationStartTask200Response> response = apiInstance.AiVectorizationStartTaskWithHttpInfo(aiVectorizationStartTaskRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VectorizationApi.AiVectorizationStartTaskWithHttpInfo: " + e.Message);
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
| **200** | Confirms the indexing was queued. It carries no job handle, so there is nothing to poll. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

