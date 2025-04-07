# Docspace.Api.SettingsTeamTemplatesApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PeopleSchema**](SettingsTeamTemplatesApi.md#peopleschema) | **GET** /api/2.0/settings/customschemas/{id} | Get a team template by ID |
| [**PeopleSchemas**](SettingsTeamTemplatesApi.md#peopleschemas) | **GET** /api/2.0/settings/customschemas | Get team templates |
| [**SaveCustomNamingSettings**](SettingsTeamTemplatesApi.md#savecustomnamingsettings) | **PUT** /api/2.0/settings/customschemas | Create a custom team template |
| [**SaveNamingSettings**](SettingsTeamTemplatesApi.md#savenamingsettings) | **POST** /api/2.0/settings/customschemas | Save the naming settings |

<a id="peopleschema"></a>
# **PeopleSchema**
> SchemaRequestsWrapper PeopleSchema (string id)

Get a team template by ID

Returns a team template by the ID specified in the request.

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
    public class PeopleSchemaExample
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
            var apiInstance = new SettingsTeamTemplatesApi(httpClient, config, httpClientHandler);
            var id = 9846;  // string | Id

            try
            {
                // Get a team template by ID
                SchemaRequestsWrapper result = apiInstance.PeopleSchema(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsTeamTemplatesApi.PeopleSchema: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PeopleSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a team template by ID
    ApiResponse<SchemaRequestsWrapper> response = apiInstance.PeopleSchemaWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsTeamTemplatesApi.PeopleSchemaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Id |  |

### Return type

[**SchemaRequestsWrapper**](SchemaRequestsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team template with the following parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="peopleschemas"></a>
# **PeopleSchemas**
> SchemaRequestsArrayWrapper PeopleSchemas ()

Get team templates

Returns all portal team templates that allow users to name their organization (or group), add members, and define their activities within the portal.

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
    public class PeopleSchemasExample
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
            var apiInstance = new SettingsTeamTemplatesApi(httpClient, config, httpClientHandler);

            try
            {
                // Get team templates
                SchemaRequestsArrayWrapper result = apiInstance.PeopleSchemas();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsTeamTemplatesApi.PeopleSchemas: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PeopleSchemasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get team templates
    ApiResponse<SchemaRequestsArrayWrapper> response = apiInstance.PeopleSchemasWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsTeamTemplatesApi.PeopleSchemasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SchemaRequestsArrayWrapper**](SchemaRequestsArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of team templates with the following parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savecustomnamingsettings"></a>
# **SaveCustomNamingSettings**
> SchemaRequestsWrapper SaveCustomNamingSettings (SchemaRequestsDto? schemaRequestsDto = null)

Create a custom team template

Creates a custom team template with the parameters specified in the request.

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
    public class SaveCustomNamingSettingsExample
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
            var apiInstance = new SettingsTeamTemplatesApi(httpClient, config, httpClientHandler);
            var schemaRequestsDto = new SchemaRequestsDto?(); // SchemaRequestsDto? |  (optional) 

            try
            {
                // Create a custom team template
                SchemaRequestsWrapper result = apiInstance.SaveCustomNamingSettings(schemaRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsTeamTemplatesApi.SaveCustomNamingSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveCustomNamingSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a custom team template
    ApiResponse<SchemaRequestsWrapper> response = apiInstance.SaveCustomNamingSettingsWithHttpInfo(schemaRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsTeamTemplatesApi.SaveCustomNamingSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schemaRequestsDto** | [**SchemaRequestsDto?**](SchemaRequestsDto?.md) |  | [optional]  |

### Return type

[**SchemaRequestsWrapper**](SchemaRequestsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Custom team template with the following parameters |  -  |
| **400** | Please fill in all fields |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savenamingsettings"></a>
# **SaveNamingSettings**
> SchemaRequestsWrapper SaveNamingSettings (SchemaBaseRequestsDto? schemaBaseRequestsDto = null)

Save the naming settings

Saves the names from the team template with the ID specified in the request.

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
    public class SaveNamingSettingsExample
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
            var apiInstance = new SettingsTeamTemplatesApi(httpClient, config, httpClientHandler);
            var schemaBaseRequestsDto = new SchemaBaseRequestsDto?(); // SchemaBaseRequestsDto? |  (optional) 

            try
            {
                // Save the naming settings
                SchemaRequestsWrapper result = apiInstance.SaveNamingSettings(schemaBaseRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsTeamTemplatesApi.SaveNamingSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveNamingSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the naming settings
    ApiResponse<SchemaRequestsWrapper> response = apiInstance.SaveNamingSettingsWithHttpInfo(schemaBaseRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsTeamTemplatesApi.SaveNamingSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schemaBaseRequestsDto** | [**SchemaBaseRequestsDto?**](SchemaBaseRequestsDto?.md) |  | [optional]  |

### Return type

[**SchemaRequestsWrapper**](SchemaRequestsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team template with the following parameters |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

