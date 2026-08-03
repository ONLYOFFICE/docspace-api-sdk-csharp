# DocSpace.API.SDK.Api.ProfilesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiProfilesCreate**](#aiprofilescreate) | **POST** /api/2.0/ai/profiles/create | Create |
| [**AiProfilesDelete**](#aiprofilesdelete) | **DELETE** /api/2.0/ai/profiles/delete | Delete |
| [**AiProfilesGetById**](#aiprofilesgetbyid) | **GET** /api/2.0/ai/profiles/get-by-id | Get by id |
| [**AiProfilesList**](#aiprofileslist) | **GET** /api/2.0/ai/profiles/list | List |
| [**AiProfilesListModels**](#aiprofileslistmodels) | **GET** /api/2.0/ai/profiles/list-models | List models |
| [**AiProfilesListProviderModels**](#aiprofileslistprovidermodels) | **POST** /api/2.0/ai/profiles/list-provider-models | List provider models |
| [**AiProfilesTestConnection**](#aiprofilestestconnection) | **POST** /api/2.0/ai/profiles/test-connection | Test connection |
| [**AiProfilesUpdate**](#aiprofilesupdate) | **PUT** /api/2.0/ai/profiles/update | Update |

<a id="aiprofilescreate"></a>
# **AiProfilesCreate**
> AiProfileMutationResult AiProfilesCreate (AiCreateProfileInput aiCreateProfileInput)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiCreateProfileInput** | [**AiCreateProfileInput**](AiCreateProfileInput.md) | Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`). |  |

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
            var aiCreateProfileInput = new AiCreateProfileInput(); // AiCreateProfileInput | Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).

            try
            {
                // Create
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
    // Create
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilesdelete"></a>
# **AiProfilesDelete**
> AiSuccessResponse AiProfilesDelete (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

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
            var body = "body_example";  // string | 

            try
            {
                // Delete
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
    // Delete
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilesgetbyid"></a>
# **AiProfilesGetById**
> AiProfile AiProfilesGetById (string id)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-get-by-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**AiProfile**](AiProfile.md)

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
            var id = "id_example";  // string | 

            try
            {
                // Get by id
                AiProfile result = apiInstance.AiProfilesGetById(id);
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
    // Get by id
    ApiResponse<AiProfile> response = apiInstance.AiProfilesGetByIdWithHttpInfo(id);
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofileslist"></a>
# **AiProfilesList**
> List&lt;AiProfile&gt; AiProfilesList ()



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
                // List
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
    // List
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofileslistmodels"></a>
# **AiProfilesListModels**
> List&lt;AiModel&gt; AiProfilesListModels (string profileId)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-list-models/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **profileId** | **string** |  |  |

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
            var profileId = "profileId_example";  // string | 

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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofileslistprovidermodels"></a>
# **AiProfilesListProviderModels**
> List&lt;AiModel&gt; AiProfilesListProviderModels (AiProfilesListProviderModelsRequest aiProfilesListProviderModelsRequest)



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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilestestconnection"></a>
# **AiProfilesTestConnection**
> AiProfilesTestConnection200Response AiProfilesTestConnection (string body)



For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-profiles-test-connection/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** |  |  |

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
            var body = "body_example";  // string | 

            try
            {
                // Test connection
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
    // Test connection
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiprofilesupdate"></a>
# **AiProfilesUpdate**
> AiProfileMutationResult AiProfilesUpdate (AiProfile aiProfile)



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
                // Update
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
    // Update
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
| **200** | Success. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

