# DocSpace.API.SDK.Api.MetadataApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiMetaFill**](#aimetafill) | **POST** /api/2.0/ai/meta/fill | Fill metadata values |
| [**AiMetaGenerate**](#aimetagenerate) | **POST** /api/2.0/ai/meta/generate | Generate metadata fields |

<a id="aimetafill"></a>
# **AiMetaFill**
> AiMetaFill200Response AiMetaFill (AiMetaFillRequest aiMetaFillRequest)

Fills the metadata of one file from its text and writes the result. `kind` names the entry's table and `id` its integer identifier; only `file` is accepted for now, a folder or a room answers 400 until it is settled whether their metadata should describe the entry itself or its files; `prompt` is an optional note for the model on what to pay attention to, passed as a hint, never as an instruction; `overwrite` (default false) also replaces the fields that already carry a value, otherwise only the empty ones are filled and the rest are reported as `already_set`; `dryRun` (default true) resolves the values but writes nothing, so the caller shows them for confirmation and saves the accepted ones itself; only an explicit `dryRun: false` writes, and it is meant for a caller that has already collected the user's confirmation. The fields are the entry's own: every field of the visible templates it carries, assigned or inherited through a cascade - a hidden template is skipped as the UI and the search skip it - and its existing custom fields - no field is created here, use `POST api/2.0/ai/meta/generate` and the Files metadata API for that. The text is the file itself, converted to plain text under the caller's rights and cut to the same budgets as the generate route. The model bound to `GenerateMeta` (`Default` when that slot is empty) runs once, without tools, and is told to answer null for a value the text does not state. Each value is then checked the way the client's info panel checks a typed value - an integer for a number, a calendar date for a date, one of the field's own options for a choice - and the ones that pass are written with `PUT api/2.0/files/metadata/{kind}/{id}/values` and `.../customFields`, so the caller needs the rights those routes need; a write the portal refuses is reported per field as `write_failed`, and the call fails with the portal's status only when nothing was written at all. The answer carries `dryRun` as it was applied, the entry's metadata after the write (or as it stands, with `dryRun`), the values written or proposed, the fields left empty with the reason for each, and the documents that were read.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-meta-fill/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiMetaFillRequest** | [**AiMetaFillRequest**](AiMetaFillRequest.md) |  |  |

### Return type

[**AiMetaFill200Response**](AiMetaFill200Response.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [bearerAuth](../README.md#bearerAuth)

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
    public class AiMetaFillExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: cookieAuth
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MetadataApi(httpClient, config, httpClientHandler);
            var aiMetaFillRequest = new AiMetaFillRequest(); // AiMetaFillRequest | 

            try
            {
                // Fill metadata values
                AiMetaFill200Response result = apiInstance.AiMetaFill(aiMetaFillRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.AiMetaFill: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiMetaFillWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fill metadata values
    ApiResponse<AiMetaFill200Response> response = apiInstance.AiMetaFillWithHttpInfo(aiMetaFillRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.AiMetaFillWithHttpInfo: " + e.Message);
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
| **200** | Whether it was a dry run, the entry's metadata, the values written or proposed, the fields left empty with the reason for each, and the documents the values were read from. |  -  |
| **400** | `kind` is not `file` (folders and rooms are not accepted for now), `id` is not an integer id, `prompt` is not a string, or `overwrite` / `dryRun` is not a boolean. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **402** | The model provider refused the request for lack of credit; `code` and `providerMessage` carry its own words. |  -  |
| **403** | The caller cannot read the entry, or cannot edit it when the values are written. |  -  |
| **404** | The entry does not exist. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **422** | The entry has no metadata fields to fill, or none of its content could be read as text. |  -  |
| **429** | The model provider is rate-limiting requests; `code` and `providerMessage` carry its own words. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |
| **502** | The model request failed; `code` says how and `providerMessage` carries the provider's own words when it gave any. |  -  |
| **503** | No profile is bound to `GenerateMeta` and the `Default` slot is empty too. |  -  |
| **504** | Reading the files or the model round did not finish within the time budget. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aimetagenerate"></a>
# **AiMetaGenerate**
> AiMetaGenerate200Response AiMetaGenerate (AiMetaGenerateRequest aiMetaGenerateRequest)

Reads one file as text and asks the model bound to the `GenerateMeta` action - the `Default` slot when that action has no profile of its own - which custom metadata fields describe it, and what their values are. `kind` names the entry's table and `id` its integer identifier, the same way as `POST api/2.0/ai/meta/fill`; only `file` is accepted for now, a folder or a room answers 400 until it is settled whether their metadata should describe the entry itself or its files; `prompt` is an optional note on the kind of fields the caller is interested in, which is passed to the model as a hint, never as an instruction. The text is the file itself, converted to plain text through the portal's own conversion (word-processing and presentation formats, pdf included, to txt; spreadsheets to csv), under the caller's rights, so a file the caller cannot read is skipped as `forbidden` rather than failing the call. Each document is cut at 40 000 characters and the whole set at 240 000, which `sources[].truncated` reports. The model runs once, without tools, and the answer is validated: field names are trimmed, deduplicated regardless of case and capped at 50, the portal's own limit for custom fields on one entry; each field carries the value the text supports as a string, or `null` when the text does not state one, since a custom field on the portal is text and cannot be saved empty. Nothing is written: the caller decides which fields to create and saves them through the Files metadata API.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-meta-generate/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiMetaGenerateRequest** | [**AiMetaGenerateRequest**](AiMetaGenerateRequest.md) |  |  |

### Return type

[**AiMetaGenerate200Response**](AiMetaGenerate200Response.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [bearerAuth](../README.md#bearerAuth)

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
    public class AiMetaGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: cookieAuth
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MetadataApi(httpClient, config, httpClientHandler);
            var aiMetaGenerateRequest = new AiMetaGenerateRequest(); // AiMetaGenerateRequest | 

            try
            {
                // Generate metadata fields
                AiMetaGenerate200Response result = apiInstance.AiMetaGenerate(aiMetaGenerateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetadataApi.AiMetaGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiMetaGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate metadata fields
    ApiResponse<AiMetaGenerate200Response> response = apiInstance.AiMetaGenerateWithHttpInfo(aiMetaGenerateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MetadataApi.AiMetaGenerateWithHttpInfo: " + e.Message);
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
| **200** | The proposed fields, each with a name and the value found or null, the documents the proposal was read from, and the entries that were left out with the reason for each. |  -  |
| **400** | `kind` is not `file` (folders and rooms are not accepted for now), `id` is not an integer id, or `prompt` is not a string. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **402** | The model provider refused the request for lack of credit; `code` and `providerMessage` carry its own words. |  -  |
| **403** | The caller cannot open the entry. |  -  |
| **404** | The entry does not exist. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **422** | The content could not be read as text; `skipped` says why. |  -  |
| **429** | The model provider is rate-limiting requests; `code` and `providerMessage` carry its own words. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |
| **502** | The model request failed; `code` says how and `providerMessage` carries the provider's own words when it gave any. |  -  |
| **503** | No profile is bound to `GenerateMeta` and the `Default` slot is empty too. |  -  |
| **504** | Reading the files or the model round did not finish within the time budget. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

