# DocSpace.API.SDK.Api.CookiesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCookieSettings**](#getcookiesettings) | **GET** /api/2.0/settings/cookiesettings | Get the cookie lifetime settings |
| [**UpdateCookieSettings**](#updatecookiesettings) | **PUT** /api/2.0/settings/cookiesettings | Update the cookie lifetime settings |

<a id="getcookiesettings"></a>
# **GetCookieSettings**
> CookieSettingsWrapper GetCookieSettings ()

Returns how long an authentication session of this portal stays valid: `lifeTime` in minutes together with the  `enabled` flag that says whether that limit is applied at all. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused -  and the call is read-only. The pair describes the whole portal rather than the calling user, and it is never  empty: a portal nobody has configured answers `lifeTime` 1440, one day, with `enabled` false. Read the two  fields together, because the number alone does not say how long a session lasts - while `enabled` is false the  stored number is ignored and an issued session is honoured for a year, and `lifeTime` 0 with `enabled` true  means a session that never expires on its own. On an installation whose configuration hides the cookie section  the built-in default pair comes back instead of the stored one. `GET api/2.0/settings` carries the same flag  as `cookieSettingsEnabled` without the number; change the pair with `PUT api/2.0/settings/cookiesettings`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-cookie-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**CookieSettingsWrapper**](CookieSettingsWrapper.md)

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
    public class GetCookieSettingsExample
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
            var apiInstance = new CookiesApi(httpClient, config, httpClientHandler);

            try
            {
                // Get the cookie lifetime settings
                CookieSettingsWrapper result = apiInstance.GetCookieSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CookiesApi.GetCookieSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCookieSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the cookie lifetime settings
    ApiResponse<CookieSettingsWrapper> response = apiInstance.GetCookieSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CookiesApi.GetCookieSettingsWithHttpInfo: " + e.Message);
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
| **200** | The authentication session lifetime of the portal in minutes together with the flag that says whether that limit is applied |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecookiesettings"></a>
# **UpdateCookieSettings**
> StringWrapper UpdateCookieSettings (CookieSettingsRequestsDto? cookieSettingsRequestsDto = null)

Stores how long an authentication session of this portal stays valid: `lifeTime` in minutes together with the  `enabled` flag that switches the limit on. The caller needs the portal-settings right of a DocSpace  administrator - the portal owner and a DocSpace administrator qualify, any other member is refused - and on an  installation whose configuration hides the cookie section nothing is stored and the call is answered with 402.  A `lifeTime` above 9999 minutes is not rejected but clamped to 9999, while 0 or less clears the number  instead, which with `enabled` true leaves sessions that never expire on their own. Any positive `lifeTime`  raises the session version of the portal: every session issued before the call stops being accepted, and with  `enabled` true the connections behind them are dropped as well. The caller is signed in again inside the same  call and gets a fresh session cookie in the response, so a client that keeps sending the token it held before  this call is the one locked out. The change is recorded in the audit trail. What comes back is a localized  confirmation message; read the stored pair with `GET api/2.0/settings/cookiesettings`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-cookie-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cookieSettingsRequestsDto** | [**CookieSettingsRequestsDto?**](CookieSettingsRequestsDto.md) | How long an authentication session of the portal stays valid, and whether that limit is applied. | [optional]  |

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
    public class UpdateCookieSettingsExample
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
            var apiInstance = new CookiesApi(httpClient, config, httpClientHandler);
            var cookieSettingsRequestsDto = new CookieSettingsRequestsDto?(); // CookieSettingsRequestsDto? | How long an authentication session of the portal stays valid, and whether that limit is applied. (optional) 

            try
            {
                // Update the cookie lifetime settings
                StringWrapper result = apiInstance.UpdateCookieSettings(cookieSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CookiesApi.UpdateCookieSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCookieSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the cookie lifetime settings
    ApiResponse<StringWrapper> response = apiInstance.UpdateCookieSettingsWithHttpInfo(cookieSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CookiesApi.UpdateCookieSettingsWithHttpInfo: " + e.Message);
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
| **200** | A localized message confirming that the session lifetime has been saved |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **402** | The installation hides the cookie lifetime section, or the portal's payment has lapsed |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

