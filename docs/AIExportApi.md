# DocSpace.API.SDK.Api.ExportApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiExportTextToDocx**](#aiexporttexttodocx) | **POST** /api/2.0/ai/text-to-docx | Start markdown → docx export |

<a id="aiexporttexttodocx"></a>
# **AiExportTextToDocx**
> AiExportTextToDocx200Response AiExportTextToDocx (AiExportTextToDocxRequest aiExportTextToDocxRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-export-text-to-docx/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiExportTextToDocxRequest** | [**AiExportTextToDocxRequest**](AiExportTextToDocxRequest.md) |  |  |

### Return type

[**AiExportTextToDocx200Response**](AiExportTextToDocx200Response.md)

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
    public class AiExportTextToDocxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExportApi(httpClient, config, httpClientHandler);
            var aiExportTextToDocxRequest = new AiExportTextToDocxRequest(); // AiExportTextToDocxRequest | 

            try
            {
                // Start markdown → docx export
                AiExportTextToDocx200Response result = apiInstance.AiExportTextToDocx(aiExportTextToDocxRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportApi.AiExportTextToDocx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiExportTextToDocxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start markdown → docx export
    ApiResponse<AiExportTextToDocx200Response> response = apiInstance.AiExportTextToDocxWithHttpInfo(aiExportTextToDocxRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportApi.AiExportTextToDocxWithHttpInfo: " + e.Message);
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

