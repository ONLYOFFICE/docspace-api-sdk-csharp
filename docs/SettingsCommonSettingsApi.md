# Docspace.Api.SettingsCommonSettingsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CloseAdminHelper**](SettingsCommonSettingsApi.md#closeadminhelper) | **PUT** /api/2.0/settings/closeadminhelper | Close the admin helper notification |
| [**CompleteWizard**](SettingsCommonSettingsApi.md#completewizard) | **PUT** /api/2.0/settings/wizard/complete | Complete the Wizard settings |
| [**DeleteColorTheme**](SettingsCommonSettingsApi.md#deletecolortheme) | **DELETE** /api/2.0/settings/colortheme | Delete a color theme |
| [**GetColorTheme**](SettingsCommonSettingsApi.md#getcolortheme) | **GET** /api/2.0/settings/colortheme | Get a color theme |
| [**GetLogo**](SettingsCommonSettingsApi.md#getlogo) | **GET** /api/2.0/settings/logo | Get a portal logo |
| [**GetMachineName**](SettingsCommonSettingsApi.md#getmachinename) | **GET** /api/2.0/settings/machine | Get hostname |
| [**GetSettings**](SettingsCommonSettingsApi.md#getsettings) | **GET** /api/2.0/settings | Get the portal settings |
| [**GetSocketSettings**](SettingsCommonSettingsApi.md#getsocketsettings) | **GET** /api/2.0/settings/socket | Get the socket settings |
| [**GetSupportedCultures**](SettingsCommonSettingsApi.md#getsupportedcultures) | **GET** /api/2.0/settings/cultures | Get supported languages |
| [**GetTimeZonesAsync**](SettingsCommonSettingsApi.md#gettimezonesasync) | **GET** /api/2.0/settings/timezones | Get time zones |
| [**GettDeepLinkSettings**](SettingsCommonSettingsApi.md#gettdeeplinksettings) | **GET** /api/2.0/settings/deeplink | Gets deeplink settings |
| [**PaymentSettings**](SettingsCommonSettingsApi.md#paymentsettings) | **GET** /api/2.0/settings/payment | Get the payment settings |
| [**SaveColorTheme**](SettingsCommonSettingsApi.md#savecolortheme) | **PUT** /api/2.0/settings/colortheme | Save a color theme |
| [**SaveConfigureDeepLink**](SettingsCommonSettingsApi.md#saveconfiguredeeplink) | **POST** /api/2.0/settings/deeplink | Configure deep link settings |
| [**SaveDnsSettings**](SettingsCommonSettingsApi.md#savednssettings) | **PUT** /api/2.0/settings/dns | Save the DNS settings |
| [**SaveMailDomainSettings**](SettingsCommonSettingsApi.md#savemaildomainsettings) | **POST** /api/2.0/settings/maildomainsettings | Save the mail domain settings |
| [**UpdateEmailActivationSettings**](SettingsCommonSettingsApi.md#updateemailactivationsettings) | **PUT** /api/2.0/settings/emailactivation | Update the email activation settings |

<a id="closeadminhelper"></a>
# **CloseAdminHelper**
> void CloseAdminHelper ()

Close the admin helper notification

Closes the admin helper notification.

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
    public class CloseAdminHelperExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Close the admin helper notification
                apiInstance.CloseAdminHelper();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.CloseAdminHelper: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CloseAdminHelperWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Close the admin helper notification
    apiInstance.CloseAdminHelperWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.CloseAdminHelperWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **405** | Not available |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="completewizard"></a>
# **CompleteWizard**
> WizardSettingsWrapper CompleteWizard (WizardRequestsDto? wizardRequestsDto = null)

Complete the Wizard settings

Completes the Wizard settings.

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
    public class CompleteWizardExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var wizardRequestsDto = new WizardRequestsDto?(); // WizardRequestsDto? |  (optional) 

            try
            {
                // Complete the Wizard settings
                WizardSettingsWrapper result = apiInstance.CompleteWizard(wizardRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.CompleteWizard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CompleteWizardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Complete the Wizard settings
    ApiResponse<WizardSettingsWrapper> response = apiInstance.CompleteWizardWithHttpInfo(wizardRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.CompleteWizardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **wizardRequestsDto** | [**WizardRequestsDto?**](WizardRequestsDto?.md) |  | [optional]  |

### Return type

[**WizardSettingsWrapper**](WizardSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wizard settings |  -  |
| **400** | Incorrect email address/The password is empty |  -  |
| **401** | Unauthorized |  -  |
| **402** | You must enter a license key or license key is not correct or license expired or user quota does not match the license |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecolortheme"></a>
# **DeleteColorTheme**
> CustomColorThemesSettingsWrapper DeleteColorTheme (int? id = null)

Delete a color theme

Deletes the portal color theme with the ID specified in the request.

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
    public class DeleteColorThemeExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int? | Portal theme ID (optional) 

            try
            {
                // Delete a color theme
                CustomColorThemesSettingsWrapper result = apiInstance.DeleteColorTheme(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.DeleteColorTheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteColorThemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a color theme
    ApiResponse<CustomColorThemesSettingsWrapper> response = apiInstance.DeleteColorThemeWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.DeleteColorThemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | Portal theme ID | [optional]  |

### Return type

[**CustomColorThemesSettingsWrapper**](CustomColorThemesSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Portal theme settings: custom color theme settings, selected or not, limit |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcolortheme"></a>
# **GetColorTheme**
> CustomColorThemesSettingsWrapper GetColorTheme ()

Get a color theme

Returns the portal color theme.

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
    public class GetColorThemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get a color theme
                CustomColorThemesSettingsWrapper result = apiInstance.GetColorTheme();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetColorTheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetColorThemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a color theme
    ApiResponse<CustomColorThemesSettingsWrapper> response = apiInstance.GetColorThemeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetColorThemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CustomColorThemesSettingsWrapper**](CustomColorThemesSettingsWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Settings of the portal themes |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlogo"></a>
# **GetLogo**
> StringWrapper GetLogo ()

Get a portal logo

Returns the portal logo image URL.

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
    public class GetLogoExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get a portal logo
                StringWrapper result = apiInstance.GetLogo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetLogo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLogoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a portal logo
    ApiResponse<StringWrapper> response = apiInstance.GetLogoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetLogoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Portal logo image URL |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmachinename"></a>
# **GetMachineName**
> ObjectWrapper GetMachineName ()

Get hostname

Returns the portal hostname.

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
    public class GetMachineNameExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get hostname
                ObjectWrapper result = apiInstance.GetMachineName();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetMachineName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMachineNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get hostname
    ApiResponse<ObjectWrapper> response = apiInstance.GetMachineNameWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetMachineNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Portal hostname |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsettings"></a>
# **GetSettings**
> SettingsWrapper GetSettings (bool? withpassword = null)

Get the portal settings

Returns a list of all the available portal settings with the current values for each parameter.

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
    public class GetSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var withpassword = true;  // bool? | Specifies if the password hasher settings will be returned or not (optional) 

            try
            {
                // Get the portal settings
                SettingsWrapper result = apiInstance.GetSettings(withpassword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the portal settings
    ApiResponse<SettingsWrapper> response = apiInstance.GetSettingsWithHttpInfo(withpassword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **withpassword** | **bool?** | Specifies if the password hasher settings will be returned or not | [optional]  |

### Return type

[**SettingsWrapper**](SettingsWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Settings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsocketsettings"></a>
# **GetSocketSettings**
> ObjectWrapper GetSocketSettings ()

Get the socket settings

Returns the socket settings.

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
    public class GetSocketSettingsExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the socket settings
                ObjectWrapper result = apiInstance.GetSocketSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetSocketSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSocketSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the socket settings
    ApiResponse<ObjectWrapper> response = apiInstance.GetSocketSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetSocketSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ObjectWrapper**](ObjectWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Socket settings: hub URL |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsupportedcultures"></a>
# **GetSupportedCultures**
> STRINGArrayWrapper GetSupportedCultures ()

Get supported languages

Returns a list of all the available portal languages in the format of a two-letter or four-letter language code (e.g. \"de\", \"en-US\", etc.).

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
    public class GetSupportedCulturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get supported languages
                STRINGArrayWrapper result = apiInstance.GetSupportedCultures();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetSupportedCultures: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupportedCulturesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get supported languages
    ApiResponse<STRINGArrayWrapper> response = apiInstance.GetSupportedCulturesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetSupportedCulturesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**STRINGArrayWrapper**](STRINGArrayWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all the available portal languages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettimezonesasync"></a>
# **GetTimeZonesAsync**
> TimezonesRequestsArrayWrapper GetTimeZonesAsync ()

Get time zones

Returns a list of all the available portal time zones.

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
    public class GetTimeZonesAsyncExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get time zones
                TimezonesRequestsArrayWrapper result = apiInstance.GetTimeZonesAsync();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GetTimeZonesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTimeZonesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get time zones
    ApiResponse<TimezonesRequestsArrayWrapper> response = apiInstance.GetTimeZonesAsyncWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GetTimeZonesAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TimezonesRequestsArrayWrapper**](TimezonesRequestsArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all the available time zones with their IDs and display names |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettdeeplinksettings"></a>
# **GettDeepLinkSettings**
> TenantDeepLinkSettingsWrapper GettDeepLinkSettings ()

Gets deeplink settings

Gets deeplink settings

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
    public class GettDeepLinkSettingsExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Gets deeplink settings
                TenantDeepLinkSettingsWrapper result = apiInstance.GettDeepLinkSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.GettDeepLinkSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GettDeepLinkSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets deeplink settings
    ApiResponse<TenantDeepLinkSettingsWrapper> response = apiInstance.GettDeepLinkSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.GettDeepLinkSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**TenantDeepLinkSettingsWrapper**](TenantDeepLinkSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="paymentsettings"></a>
# **PaymentSettings**
> PaymentSettingsWrapper PaymentSettings ()

Get the payment settings

Returns the portal payment settings.

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
    public class PaymentSettingsExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the payment settings
                PaymentSettingsWrapper result = apiInstance.PaymentSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.PaymentSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the payment settings
    ApiResponse<PaymentSettingsWrapper> response = apiInstance.PaymentSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.PaymentSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PaymentSettingsWrapper**](PaymentSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment settings: sales email, feedback and support URL, link to pay for a portal, Standalone or not, current license, maximum quota quantity |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savecolortheme"></a>
# **SaveColorTheme**
> CustomColorThemesSettingsWrapper SaveColorTheme (CustomColorThemesSettingsRequestsDto? customColorThemesSettingsRequestsDto = null)

Save a color theme

Saves the portal color theme specified in the request.

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
    public class SaveColorThemeExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var customColorThemesSettingsRequestsDto = new CustomColorThemesSettingsRequestsDto?(); // CustomColorThemesSettingsRequestsDto? |  (optional) 

            try
            {
                // Save a color theme
                CustomColorThemesSettingsWrapper result = apiInstance.SaveColorTheme(customColorThemesSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveColorTheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveColorThemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save a color theme
    ApiResponse<CustomColorThemesSettingsWrapper> response = apiInstance.SaveColorThemeWithHttpInfo(customColorThemesSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveColorThemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customColorThemesSettingsRequestsDto** | [**CustomColorThemesSettingsRequestsDto?**](CustomColorThemesSettingsRequestsDto?.md) |  | [optional]  |

### Return type

[**CustomColorThemesSettingsWrapper**](CustomColorThemesSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Portal theme settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="saveconfiguredeeplink"></a>
# **SaveConfigureDeepLink**
> TenantDeepLinkSettingsWrapper SaveConfigureDeepLink (DeepLinkConfigurationRequestsDto? deepLinkConfigurationRequestsDto = null)

Configure deep link settings

Saves the deep link configuration settings for the portal.

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
    public class SaveConfigureDeepLinkExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var deepLinkConfigurationRequestsDto = new DeepLinkConfigurationRequestsDto?(); // DeepLinkConfigurationRequestsDto? |  (optional) 

            try
            {
                // Configure deep link settings
                TenantDeepLinkSettingsWrapper result = apiInstance.SaveConfigureDeepLink(deepLinkConfigurationRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveConfigureDeepLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveConfigureDeepLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure deep link settings
    ApiResponse<TenantDeepLinkSettingsWrapper> response = apiInstance.SaveConfigureDeepLinkWithHttpInfo(deepLinkConfigurationRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveConfigureDeepLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deepLinkConfigurationRequestsDto** | [**DeepLinkConfigurationRequestsDto?**](DeepLinkConfigurationRequestsDto?.md) |  | [optional]  |

### Return type

[**TenantDeepLinkSettingsWrapper**](TenantDeepLinkSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deep link configuration updated |  -  |
| **400** | Invalid deep link configuration |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savednssettings"></a>
# **SaveDnsSettings**
> StringWrapper SaveDnsSettings (DnsSettingsRequestsDto? dnsSettingsRequestsDto = null)

Save the DNS settings

Saves the DNS settings specified in the request to the current portal.

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
    public class SaveDnsSettingsExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var dnsSettingsRequestsDto = new DnsSettingsRequestsDto?(); // DnsSettingsRequestsDto? |  (optional) 

            try
            {
                // Save the DNS settings
                StringWrapper result = apiInstance.SaveDnsSettings(dnsSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveDnsSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveDnsSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the DNS settings
    ApiResponse<StringWrapper> response = apiInstance.SaveDnsSettingsWithHttpInfo(dnsSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveDnsSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dnsSettingsRequestsDto** | [**DnsSettingsRequestsDto?**](DnsSettingsRequestsDto?.md) |  | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message about changing DNS |  -  |
| **400** | Invalid domain name/incorrect length of doman name |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |
| **405** | Method not allowed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savemaildomainsettings"></a>
# **SaveMailDomainSettings**
> StringWrapper SaveMailDomainSettings (MailDomainSettingsRequestsDto? mailDomainSettingsRequestsDto = null)

Save the mail domain settings

Saves the mail domain settings specified in the request to the portal.

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
    public class SaveMailDomainSettingsExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var mailDomainSettingsRequestsDto = new MailDomainSettingsRequestsDto?(); // MailDomainSettingsRequestsDto? |  (optional) 

            try
            {
                // Save the mail domain settings
                StringWrapper result = apiInstance.SaveMailDomainSettings(mailDomainSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveMailDomainSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveMailDomainSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the mail domain settings
    ApiResponse<StringWrapper> response = apiInstance.SaveMailDomainSettingsWithHttpInfo(mailDomainSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.SaveMailDomainSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mailDomainSettingsRequestsDto** | [**MailDomainSettingsRequestsDto?**](MailDomainSettingsRequestsDto?.md) |  | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message about the result of saving the mail domain settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateemailactivationsettings"></a>
# **UpdateEmailActivationSettings**
> EmailActivationSettingsWrapper UpdateEmailActivationSettings (EmailActivationSettings? emailActivationSettings = null)

Update the email activation settings

Updates the email activation settings.

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
    public class UpdateEmailActivationSettingsExample
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
            var apiInstance = new SettingsCommonSettingsApi(httpClient, config, httpClientHandler);
            var emailActivationSettings = new EmailActivationSettings?(); // EmailActivationSettings? |  (optional) 

            try
            {
                // Update the email activation settings
                EmailActivationSettingsWrapper result = apiInstance.UpdateEmailActivationSettings(emailActivationSettings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsCommonSettingsApi.UpdateEmailActivationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEmailActivationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the email activation settings
    ApiResponse<EmailActivationSettingsWrapper> response = apiInstance.UpdateEmailActivationSettingsWithHttpInfo(emailActivationSettings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsCommonSettingsApi.UpdateEmailActivationSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailActivationSettings** | [**EmailActivationSettings?**](EmailActivationSettings?.md) |  | [optional]  |

### Return type

[**EmailActivationSettingsWrapper**](EmailActivationSettingsWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated email activation settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

