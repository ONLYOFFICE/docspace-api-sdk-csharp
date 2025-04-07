# Docspace.Api.SettingsOwnerApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Owner**](SettingsOwnerApi.md#owner) | **PUT** /api/2.0/settings/owner | Update the portal owner |
| [**SendOwnerChangeInstructions**](SettingsOwnerApi.md#sendownerchangeinstructions) | **POST** /api/2.0/settings/owner | Send the owner change instructions |

<a id="owner"></a>
# **Owner**
> void Owner (OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = null)

Update the portal owner

Updates the current portal owner with a new one specified in the request.

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
    public class OwnerExample
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
            var apiInstance = new SettingsOwnerApi(httpClient, config, httpClientHandler);
            var ownerIdSettingsRequestDto = new OwnerIdSettingsRequestDto?(); // OwnerIdSettingsRequestDto? |  (optional) 

            try
            {
                // Update the portal owner
                apiInstance.Owner(ownerIdSettingsRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsOwnerApi.Owner: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OwnerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the portal owner
    apiInstance.OwnerWithHttpInfo(ownerIdSettingsRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsOwnerApi.OwnerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownerIdSettingsRequestDto** | [**OwnerIdSettingsRequestDto?**](OwnerIdSettingsRequestDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | The user could not be found |  -  |
| **401** | Unauthorized |  -  |
| **409** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendownerchangeinstructions"></a>
# **SendOwnerChangeInstructions**
> OwnerChangeInstructionsWrapper SendOwnerChangeInstructions (OwnerIdSettingsRequestDto? ownerIdSettingsRequestDto = null)

Send the owner change instructions

Sends the instructions to change the DocSpace owner.

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
    public class SendOwnerChangeInstructionsExample
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
            var apiInstance = new SettingsOwnerApi(httpClient, config, httpClientHandler);
            var ownerIdSettingsRequestDto = new OwnerIdSettingsRequestDto?(); // OwnerIdSettingsRequestDto? |  (optional) 

            try
            {
                // Send the owner change instructions
                OwnerChangeInstructionsWrapper result = apiInstance.SendOwnerChangeInstructions(ownerIdSettingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsOwnerApi.SendOwnerChangeInstructions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendOwnerChangeInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send the owner change instructions
    ApiResponse<OwnerChangeInstructionsWrapper> response = apiInstance.SendOwnerChangeInstructionsWithHttpInfo(ownerIdSettingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsOwnerApi.SendOwnerChangeInstructionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownerIdSettingsRequestDto** | [**OwnerIdSettingsRequestDto?**](OwnerIdSettingsRequestDto?.md) |  | [optional]  |

### Return type

[**OwnerChangeInstructionsWrapper**](OwnerChangeInstructionsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message about changing the portal owner |  -  |
| **401** | Unauthorized |  -  |
| **403** | Collaborator can not be an owner |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

