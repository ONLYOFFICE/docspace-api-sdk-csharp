# Docspace.Api.SettingsAuthorizationApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAuthServices**](SettingsAuthorizationApi.md#getauthservices) | **GET** /api/2.0/settings/authservice | Get the authorization services |
| [**SaveAuthKeys**](SettingsAuthorizationApi.md#saveauthkeys) | **POST** /api/2.0/settings/authservice | Save the authorization keys |

<a id="getauthservices"></a>
# **GetAuthServices**
> AuthServiceRequestsArrayWrapper GetAuthServices ()

Get the authorization services

Returns the authorization services.

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
    public class GetAuthServicesExample
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
            var apiInstance = new SettingsAuthorizationApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the authorization services
                AuthServiceRequestsArrayWrapper result = apiInstance.GetAuthServices();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsAuthorizationApi.GetAuthServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the authorization services
    ApiResponse<AuthServiceRequestsArrayWrapper> response = apiInstance.GetAuthServicesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsAuthorizationApi.GetAuthServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AuthServiceRequestsArrayWrapper**](AuthServiceRequestsArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Authorization services |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="saveauthkeys"></a>
# **SaveAuthKeys**
> BooleanWrapper SaveAuthKeys (AuthServiceRequestsDto? authServiceRequestsDto = null)

Save the authorization keys

Saves the authorization keys.

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
    public class SaveAuthKeysExample
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
            var apiInstance = new SettingsAuthorizationApi(httpClient, config, httpClientHandler);
            var authServiceRequestsDto = new AuthServiceRequestsDto?(); // AuthServiceRequestsDto? |  (optional) 

            try
            {
                // Save the authorization keys
                BooleanWrapper result = apiInstance.SaveAuthKeys(authServiceRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsAuthorizationApi.SaveAuthKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveAuthKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the authorization keys
    ApiResponse<BooleanWrapper> response = apiInstance.SaveAuthKeysWithHttpInfo(authServiceRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsAuthorizationApi.SaveAuthKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authServiceRequestsDto** | [**AuthServiceRequestsDto?**](AuthServiceRequestsDto?.md) |  | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Boolean value: true if the authorization keys are changed |  -  |
| **400** | Bad keys |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

