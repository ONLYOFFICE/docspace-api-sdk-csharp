# DocSpace.API.SDK.Api.TFASettingsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTfaAppCodes**](#gettfaappcodes) | **GET** /api/2.0/settings/tfaappcodes | Get the TFA codes |
| [**GetTfaConfirmData**](#gettfaconfirmdata) | **GET** /api/2.0/settings/tfaapp/confirm | Get TFA confirmation data |
| [**GetTfaSettings**](#gettfasettings) | **GET** /api/2.0/settings/tfaapp | Get the TFA settings |
| [**TfaAppGenerateSetupCode**](#tfaappgeneratesetupcode) | **GET** /api/2.0/settings/tfaapp/setup | Generate setup code |
| [**TfaValidateAuthCode**](#tfavalidateauthcode) | **POST** /api/2.0/settings/tfaapp/validate | Validate the TFA code |
| [**UnlinkTfaApp**](#unlinktfaapp) | **PUT** /api/2.0/settings/tfaappnewapp | Unlink the TFA application |
| [**UpdateTfaAppCodes**](#updatetfaappcodes) | **PUT** /api/2.0/settings/tfaappnewcodes | Update the TFA codes |
| [**UpdateTfaSettings**](#updatetfasettings) | **PUT** /api/2.0/settings/tfaapp | Update the TFA settings |
| [**UpdateTfaSettingsLink**](#updatetfasettingslink) | **PUT** /api/2.0/settings/tfaappwithlink | Updates TFA settings |

<a id="gettfaappcodes"></a>
# **GetTfaAppCodes**
> TfaAppCodeArrayWrapper GetTfaAppCodes ()

Returns the two-factor authentication application codes.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tfa-app-codes/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**TfaAppCodeArrayWrapper**](TfaAppCodeArrayWrapper.md)

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
    public class GetTfaAppCodesExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the TFA codes
                TfaAppCodeArrayWrapper result = apiInstance.GetTfaAppCodes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.GetTfaAppCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTfaAppCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the TFA codes
    ApiResponse<TfaAppCodeArrayWrapper> response = apiInstance.GetTfaAppCodesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.GetTfaAppCodesWithHttpInfo: " + e.Message);
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
| **200** | List of TFA application codes |  -  |
| **405** | TFA application settings are not available |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettfaconfirmdata"></a>
# **GetTfaConfirmData**
> TfaConfirmDataWrapper GetTfaConfirmData ()

Returns the confirmation data for authorization via SMS or TFA application.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tfa-confirm-data/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**TfaConfirmDataWrapper**](TfaConfirmDataWrapper.md)

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
    public class GetTfaConfirmDataExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get TFA confirmation data
                TfaConfirmDataWrapper result = apiInstance.GetTfaConfirmData();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.GetTfaConfirmData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTfaConfirmDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get TFA confirmation data
    ApiResponse<TfaConfirmDataWrapper> response = apiInstance.GetTfaConfirmDataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.GetTfaConfirmDataWithHttpInfo: " + e.Message);
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
| **200** | TFA confirmation data |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettfasettings"></a>
# **GetTfaSettings**
> TfaSettingsArrayWrapper GetTfaSettings ()

Returns the current two-factor authentication settings.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tfa-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**TfaSettingsArrayWrapper**](TfaSettingsArrayWrapper.md)

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
    public class GetTfaSettingsExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the TFA settings
                TfaSettingsArrayWrapper result = apiInstance.GetTfaSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.GetTfaSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTfaSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the TFA settings
    ApiResponse<TfaSettingsArrayWrapper> response = apiInstance.GetTfaSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.GetTfaSettingsWithHttpInfo: " + e.Message);
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
| **200** | TFA settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tfaappgeneratesetupcode"></a>
# **TfaAppGenerateSetupCode**
> SetupCodeWrapper TfaAppGenerateSetupCode ()

Generates the setup TFA code for the current user.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/tfa-app-generate-setup-code/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**SetupCodeWrapper**](SetupCodeWrapper.md)

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
    public class TfaAppGenerateSetupCodeExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Generate setup code
                SetupCodeWrapper result = apiInstance.TfaAppGenerateSetupCode();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.TfaAppGenerateSetupCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TfaAppGenerateSetupCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate setup code
    ApiResponse<SetupCodeWrapper> response = apiInstance.TfaAppGenerateSetupCodeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.TfaAppGenerateSetupCodeWithHttpInfo: " + e.Message);
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
| **200** | Setup code |  -  |
| **405** | TFA application settings are not available |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tfavalidateauthcode"></a>
# **TfaValidateAuthCode**
> BooleanWrapper TfaValidateAuthCode (TfaValidateRequestsDto? tfaValidateRequestsDto = null)

Validates the two-factor authentication code specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/tfa-validate-auth-code/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tfaValidateRequestsDto** | [**TfaValidateRequestsDto?**](TfaValidateRequestsDto.md) | The request parameters for validating the two-factor authentication codes. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class TfaValidateAuthCodeExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);
            var tfaValidateRequestsDto = new TfaValidateRequestsDto?(); // TfaValidateRequestsDto? | The request parameters for validating the two-factor authentication codes. (optional) 

            try
            {
                // Validate the TFA code
                BooleanWrapper result = apiInstance.TfaValidateAuthCode(tfaValidateRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.TfaValidateAuthCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TfaValidateAuthCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate the TFA code
    ApiResponse<BooleanWrapper> response = apiInstance.TfaValidateAuthCodeWithHttpInfo(tfaValidateRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.TfaValidateAuthCodeWithHttpInfo: " + e.Message);
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
| **200** | True if the code is valid |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unlinktfaapp"></a>
# **UnlinkTfaApp**
> StringWrapper UnlinkTfaApp (TfaRequestsDto? tfaRequestsDto = null)

Unlinks the current two-factor authentication application from the user account specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-tfa-app/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tfaRequestsDto** | [**TfaRequestsDto?**](TfaRequestsDto.md) | The request parameters for configuring the Two-Factor Authentication (TFA) settings. | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

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
    public class UnlinkTfaAppExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);
            var tfaRequestsDto = new TfaRequestsDto?(); // TfaRequestsDto? | The request parameters for configuring the Two-Factor Authentication (TFA) settings. (optional) 

            try
            {
                // Unlink the TFA application
                StringWrapper result = apiInstance.UnlinkTfaApp(tfaRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.UnlinkTfaApp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkTfaAppWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink the TFA application
    ApiResponse<StringWrapper> response = apiInstance.UnlinkTfaAppWithHttpInfo(tfaRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.UnlinkTfaAppWithHttpInfo: " + e.Message);
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
| **200** | Login URL |  -  |
| **403** | No permissions to perform this action |  -  |
| **405** | TFA application settings are not available |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetfaappcodes"></a>
# **UpdateTfaAppCodes**
> TfaAppCodeArrayWrapper UpdateTfaAppCodes ()

Requests the new backup codes for the two-factor authentication application.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-tfa-app-codes/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**TfaAppCodeArrayWrapper**](TfaAppCodeArrayWrapper.md)

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
    public class UpdateTfaAppCodesExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Update the TFA codes
                TfaAppCodeArrayWrapper result = apiInstance.UpdateTfaAppCodes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.UpdateTfaAppCodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTfaAppCodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the TFA codes
    ApiResponse<TfaAppCodeArrayWrapper> response = apiInstance.UpdateTfaAppCodesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.UpdateTfaAppCodesWithHttpInfo: " + e.Message);
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
| **200** | New backup codes |  -  |
| **405** | TFA application settings are not available |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetfasettings"></a>
# **UpdateTfaSettings**
> BooleanWrapper UpdateTfaSettings (TfaRequestsDto? tfaRequestsDto = null)

Updates the two-factor authentication settings with the parameters specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-tfa-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tfaRequestsDto** | [**TfaRequestsDto?**](TfaRequestsDto.md) | The request parameters for configuring the Two-Factor Authentication (TFA) settings. | [optional]  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class UpdateTfaSettingsExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);
            var tfaRequestsDto = new TfaRequestsDto?(); // TfaRequestsDto? | The request parameters for configuring the Two-Factor Authentication (TFA) settings. (optional) 

            try
            {
                // Update the TFA settings
                BooleanWrapper result = apiInstance.UpdateTfaSettings(tfaRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.UpdateTfaSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTfaSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the TFA settings
    ApiResponse<BooleanWrapper> response = apiInstance.UpdateTfaSettingsWithHttpInfo(tfaRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.UpdateTfaSettingsWithHttpInfo: " + e.Message);
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
| **200** | True if the operation is successful |  -  |
| **405** | SMS settings are not available/TFA application settings are not available |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetfasettingslink"></a>
# **UpdateTfaSettingsLink**
> StringWrapper UpdateTfaSettingsLink (TfaRequestsDto? tfaRequestsDto = null)

Updates TFA settings and returns the confirmation URL for authorization via SMS or TFA application.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-tfa-settings-link/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tfaRequestsDto** | [**TfaRequestsDto?**](TfaRequestsDto.md) | The request parameters for configuring the Two-Factor Authentication (TFA) settings. | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

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
    public class UpdateTfaSettingsLinkExample
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
            var apiInstance = new TFASettingsApi(httpClient, config, httpClientHandler);
            var tfaRequestsDto = new TfaRequestsDto?(); // TfaRequestsDto? | The request parameters for configuring the Two-Factor Authentication (TFA) settings. (optional) 

            try
            {
                // Updates TFA settings
                StringWrapper result = apiInstance.UpdateTfaSettingsLink(tfaRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TFASettingsApi.UpdateTfaSettingsLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTfaSettingsLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates TFA settings
    ApiResponse<StringWrapper> response = apiInstance.UpdateTfaSettingsLinkWithHttpInfo(tfaRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TFASettingsApi.UpdateTfaSettingsLinkWithHttpInfo: " + e.Message);
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
| **200** | TFA confirmation URL |  -  |
| **403** | No permissions to perform this action |  -  |
| **405** | SMS settings are not available/TFA application settings are not available |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

