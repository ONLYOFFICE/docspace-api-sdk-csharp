# DocSpace.API.SDK.Api.ProfilesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiProfilesCreate**](#aiprofilescreate) | **POST** /api/2.0/ai/profiles/create | Create a provider profile |
| [**AiProfilesDelete**](#aiprofilesdelete) | **DELETE** /api/2.0/ai/profiles/delete | Delete a provider profile |
| [**AiProfilesGetById**](#aiprofilesgetbyid) | **GET** /api/2.0/ai/profiles/get-by-id | Get a provider profile |
| [**AiProfilesList**](#aiprofileslist) | **GET** /api/2.0/ai/profiles/list | List provider profiles |
| [**AiProfilesListModels**](#aiprofileslistmodels) | **GET** /api/2.0/ai/profiles/list-models | List models |
| [**AiProfilesListProviderModels**](#aiprofileslistprovidermodels) | **POST** /api/2.0/ai/profiles/list-provider-models | List provider models |
| [**AiProfilesTestConnection**](#aiprofilestestconnection) | **POST** /api/2.0/ai/profiles/test-connection | Test a profile's provider |
| [**AiProfilesUpdate**](#aiprofilesupdate) | **PUT** /api/2.0/ai/profiles/update | Update a provider profile |

<a id="aiprofilescreate"></a>
# **AiProfilesCreate**
> AiProfileMutationResult AiProfilesCreate (AiCreateProfileInput aiCreateProfileInput)

Creates an AI provider profile - the endpoint, credentials and model that a chat round runs on - and returns it. The name has to be unique, the credentials are probed against the live provider before anything is stored, and the portal's first profile also takes the `Default` assignment slot. Two inputs are refused outright: a `baseUrl` pointing at a private network address, and `providerType: external`, which delegates transport to the host application and therefore cannot work for a profile the server manages. On a portal running the AI gateway, profiles are managed centrally and this operation answers 403.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiCreateProfileInput** | [**AiCreateProfileInput**](AiCreateProfileInput.md) | Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`). |  |

### Return type

[**AiProfileMutationResult**](AiProfileMutationResult.md)

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
    public class AiProfilesCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var aiCreateProfileInput = new AiCreateProfileInput(); // AiCreateProfileInput | Input for creating a new profile — the same shape as `Profile` without the engine-generated fields (`id`, `createdAt`).

            try
            {
                // Create a provider profile
                AiProfileMutationResult result = apiInstance.AiProfilesCreate(aiCreateProfileInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a provider profile
    ApiResponse<AiProfileMutationResult> response = apiInstance.AiProfilesCreateWithHttpInfo(aiCreateProfileInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesCreateWithHttpInfo: " + e.Message);
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
| **200** | Whether the profile was created, with it in `profile`. A refusal is reported in `error` rather than as a status. |  -  |
| **400** | The provider URL is missing, malformed, or points at a private network address. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI profiles are read-only on this portal because they are managed by the AI gateway. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilesdelete"></a>
# **AiProfilesDelete**
> AiSuccessResponse AiProfilesDelete (string body)

Deletes an AI provider profile and cleans up every assignment pointing at it: the `Default` slot moves to the first remaining profile and the other slots are left unbound. The ID is required and may be sent in the body or as a query parameter. An unknown ID is not reported - the call answers success without deleting anything. Threads already bound to the profile keep the stored reference, so a round on such a thread falls back to whatever the scope resolves to.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | The ID of the profile to delete, as a bare JSON string. |  |

### Return type

[**AiSuccessResponse**](AiSuccessResponse.md)

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
    public class AiProfilesDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | The ID of the profile to delete, as a bare JSON string.

            try
            {
                // Delete a provider profile
                AiSuccessResponse result = apiInstance.AiProfilesDelete(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a provider profile
    ApiResponse<AiSuccessResponse> response = apiInstance.AiProfilesDeleteWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesDeleteWithHttpInfo: " + e.Message);
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
| **200** | Confirms the request was accepted, whether or not a profile was deleted. |  -  |
| **400** | The profile ID is missing. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilesgetbyid"></a>
# **AiProfilesGetById**
> AiProfilesGetById200Response AiProfilesGetById (string id)

Returns one AI provider profile by its ID, with its secrets stripped: neither the API key nor the custom headers are ever sent back, on any portal. The ID is required and is read from the query, and an unknown one answers 404. The `baseUrl` in the answer is the one that was stored, not the internal gateway address a round actually dials, so it cannot be used to reach the provider directly. Use `GET api/2.0/ai/profiles/list` to enumerate profiles instead of reading them one by one.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The AI provider profile identifier. |  |

### Return type

[**AiProfilesGetById200Response**](AiProfilesGetById200Response.md)

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
    public class AiProfilesGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // string | The AI provider profile identifier.

            try
            {
                // Get a provider profile
                AiProfilesGetById200Response result = apiInstance.AiProfilesGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a provider profile
    ApiResponse<AiProfilesGetById200Response> response = apiInstance.AiProfilesGetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The profile, with its key and headers stripped. |  -  |
| **400** | The profile ID is missing. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **404** | No profile has this ID. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofileslist"></a>
# **AiProfilesList**
> List&lt;AiProfile&gt; AiProfilesList ()

Lists the portal's AI provider profiles with their secrets stripped, the same way the single-profile read does. It takes no parameters and is not paginated, because a portal holds few profiles. On a portal running the AI gateway the answer is synthesised from the gateway's own catalogue rather than from stored records. The IDs in the answer are what the assignment operations and every round's `profileId` accept.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;AiProfile&gt;**](AiProfile.md)

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
    public class AiProfilesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);

            try
            {
                // List provider profiles
                List<AiProfile> result = apiInstance.AiProfilesList();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List provider profiles
    ApiResponse<List<AiProfile>> response = apiInstance.AiProfilesListWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portal's profiles, with their keys and headers stripped. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofileslistmodels"></a>
# **AiProfilesListModels**
> List&lt;AiModel&gt; AiProfilesListModels (string profileId)

Lists the models a stored profile's provider currently offers, asking the provider itself rather than reading a cached list. `profileId` is required and is read from the query. A failure is reported with the provider's own verdict: an unusable key comes back as 400 and a provider that is unreachable or broken as 502, while a missing profile or a caller without access keeps the status the portal gave it. Use `POST api/2.0/ai/profiles/list-provider-models` to probe an endpoint that has no profile yet.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** | The AI provider profile identifier. |  |

### Return type

[**List&lt;AiModel&gt;**](AiModel.md)

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
    public class AiProfilesListModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var profileId = 00000000-0000-0000-0000-000000000000;  // string | The AI provider profile identifier.

            try
            {
                // List models
                List<AiModel> result = apiInstance.AiProfilesListModels(profileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesListModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesListModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List models
    ApiResponse<List<AiModel>> response = apiInstance.AiProfilesListModelsWithHttpInfo(profileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesListModelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The models the profile's provider currently offers. |  -  |
| **400** | `profileId` is missing, or the provider rejected the profile's API key. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |
| **502** | The AI provider could not be reached, or answered with a failure of its own. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofileslistprovidermodels"></a>
# **AiProfilesListProviderModels**
> List&lt;AiModel&gt; AiProfilesListProviderModels (AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest)

Lists the models an endpoint offers for credentials supplied in the request, before any profile exists - this is what a provider-setup form calls to fill its model picker. `providerType` and `baseUrl` are both required, and a 400 for either names the offending input in a `field` member so the form can highlight it; a `baseUrl` pointing at a private network address is refused as well. For `providerType: onlyoffice` the answer comes from the portal gateway's catalogue, which carries richer capability data than the provider's own listing and matches what `GET api/2.0/ai/profiles/list` reports; a portal without that gateway falls back to asking the provider. A provider that is unreachable or broken is reported as 502, and one that rejects the key as 400.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-provider-models/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiProfilesListProviderModelsRequest** | [**AiProfilesListProviderModelsRequest**](AiProfilesListProviderModelsRequest.md) |  |  |

### Return type

[**List&lt;AiModel&gt;**](AiModel.md)

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
    public class AiProfilesListProviderModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var aiProfilesListProviderModelsRequest = new AiProfilesListProviderModelsRequest(); // AiProfilesListProviderModelsRequest | 

            try
            {
                // List provider models
                List<AiModel> result = apiInstance.AiProfilesListProviderModels(aiProfilesListProviderModelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesListProviderModels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesListProviderModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List provider models
    ApiResponse<List<AiModel>> response = apiInstance.AiProfilesListProviderModelsWithHttpInfo(aiProfilesListProviderModelsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesListProviderModelsWithHttpInfo: " + e.Message);
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
| **200** | The models the endpoint offers for the supplied credentials. |  -  |
| **400** | `baseUrl` is missing, points at a private network address, or the provider rejected the supplied API key. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |
| **502** | The AI provider could not be reached, or answered with a failure of its own. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilestestconnection"></a>
# **AiProfilesTestConnection**
> AiProfilesTestConnection200Response AiProfilesTestConnection (string body)

Probes a stored profile's credentials against its provider and reports the outcome in the answer, writing nothing - this is what a Test button calls so that a failure does not commit anything. `profileId` is required and may be sent in the body or as a query parameter. The result is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload. To validate credentials that are not stored yet, use `POST api/2.0/ai/profiles/list-provider-models`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | The ID of the profile to probe, as a bare JSON string. |  |

### Return type

[**AiProfilesTestConnection200Response**](AiProfilesTestConnection200Response.md)

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
    public class AiProfilesTestConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var body = "body_example";  // string | The ID of the profile to probe, as a bare JSON string.

            try
            {
                // Test a profile's provider
                AiProfilesTestConnection200Response result = apiInstance.AiProfilesTestConnection(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesTestConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesTestConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test a profile's provider
    ApiResponse<AiProfilesTestConnection200Response> response = apiInstance.AiProfilesTestConnectionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesTestConnectionWithHttpInfo: " + e.Message);
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
| **200** | The outcome of the probe. A failed probe is reported here, not as a status. |  -  |
| **400** | `profileId` is missing. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilesupdate"></a>
# **AiProfilesUpdate**
> AiProfileMutationResult AiProfilesUpdate (AiProfile aiProfile)

Replaces a stored AI provider profile and returns it, re-checking name uniqueness and probing the credentials against the live provider again. The same two inputs are refused as on create - a private-network `baseUrl` and `providerType: external` - and the whole profile is overwritten by the one supplied rather than merged. On a portal running the AI gateway this answers 403, because profiles are managed centrally there. A profile that is bound to an action or an agent keeps those bindings.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-update/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiProfile** | [**AiProfile**](AiProfile.md) | Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations. |  |

### Return type

[**AiProfileMutationResult**](AiProfileMutationResult.md)

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
    public class AiProfilesUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var aiProfile = new AiProfile(); // AiProfile | Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.

            try
            {
                // Update a provider profile
                AiProfileMutationResult result = apiInstance.AiProfilesUpdate(aiProfile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AiProfilesUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiProfilesUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a provider profile
    ApiResponse<AiProfileMutationResult> response = apiInstance.AiProfilesUpdateWithHttpInfo(aiProfile);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AiProfilesUpdateWithHttpInfo: " + e.Message);
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
| **200** | Whether the profile was updated, with the stored profile in `profile`. |  -  |
| **400** | The provider URL is missing, malformed, or points at a private network address. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI profiles are read-only on this portal because they are managed by the AI gateway. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

