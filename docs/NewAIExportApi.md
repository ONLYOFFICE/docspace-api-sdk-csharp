# DocSpace.API.SDK.Api.ExportApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**NewAiExportTextToDocx**](#newaiexporttexttodocx) | **POST** /api/2.0/ai/text-to-docx | Start markdown → docx export |

<a id="newaiexporttexttodocx"></a>
# **NewAiExportTextToDocx**
> NewAiExportTextToDocx200Response NewAiExportTextToDocx (NewAiExportTextToDocxRequest newAiExportTextToDocxRequest)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-export-text-to-docx/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **newAiExportTextToDocxRequest** | [**NewAiExportTextToDocxRequest**](NewAiExportTextToDocxRequest.md) |  |  |

### Return type

[**NewAiExportTextToDocx200Response**](NewAiExportTextToDocx200Response.md)

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
    public class NewAiExportTextToDocxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ExportApi(httpClient, config, httpClientHandler);
            var newAiExportTextToDocxRequest = new NewAiExportTextToDocxRequest(); // NewAiExportTextToDocxRequest | 

            try
            {
                // Start markdown → docx export
                NewAiExportTextToDocx200Response result = apiInstance.NewAiExportTextToDocx(newAiExportTextToDocxRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExportApi.NewAiExportTextToDocx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NewAiExportTextToDocxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start markdown → docx export
    ApiResponse<NewAiExportTextToDocx200Response> response = apiInstance.NewAiExportTextToDocxWithHttpInfo(newAiExportTextToDocxRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExportApi.NewAiExportTextToDocxWithHttpInfo: " + e.Message);
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

