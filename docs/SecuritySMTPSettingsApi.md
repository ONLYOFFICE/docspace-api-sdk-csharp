# DocSpace.API.SDK.Api.SMTPSettingsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSmtpOperationStatus**](#getsmtpoperationstatus) | **GET** /api/2.0/smtpsettings/smtp/test/status | Get SMTP test status |
| [**GetSmtpSettings**](#getsmtpsettings) | **GET** /api/2.0/smtpsettings/smtp | Get SMTP settings |
| [**ResetSmtpSettings**](#resetsmtpsettings) | **DELETE** /api/2.0/smtpsettings/smtp | Reset SMTP settings |
| [**SaveSmtpSettings**](#savesmtpsettings) | **POST** /api/2.0/smtpsettings/smtp | Save SMTP settings |
| [**TestSmtpSettings**](#testsmtpsettings) | **GET** /api/2.0/smtpsettings/smtp/test | Test SMTP settings |

<a id="getsmtpoperationstatus"></a>
# **GetSmtpOperationStatus**
> SmtpOperationStatusRequestsWrapper GetSmtpOperationStatus ()

Returns the state of the test message that `GET api/2.0/smtpsettings/smtp/test` queued for this portal, and is  the operation to poll while that test runs. A test has to be queued first; the caller needs the  portal-settings right of a DocSpace administrator, and the SMTP settings section has to be enabled for the  portal, otherwise the call is answered with 402. The call changes no settings, but it is not free of  consequence: the first answer that reports `completed` true also discards the finished job, so a later call no  longer knows about it - take `error` from that answer and keep it. An empty answer means the portal has no  test on record, either because none was queued or because its result has already been read. While the job  runs, `percents` climbs to 100 and `status` names the step reached, such as `Connect to host` or  `Send test message`; `error` is empty until something fails and stays empty when the relay accepted the  message. `id` identifies the queued job, of which a portal only ever has one.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-smtp-operation-status/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**SmtpOperationStatusRequestsWrapper**](SmtpOperationStatusRequestsWrapper.md)

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
    public class GetSmtpOperationStatusExample
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
            var apiInstance = new SMTPSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get SMTP test status
                SmtpOperationStatusRequestsWrapper result = apiInstance.GetSmtpOperationStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPSettingsApi.GetSmtpOperationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmtpOperationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SMTP test status
    ApiResponse<SmtpOperationStatusRequestsWrapper> response = apiInstance.GetSmtpOperationStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPSettingsApi.GetSmtpOperationStatusWithHttpInfo: " + e.Message);
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
| **200** | The state of the test message of the portal, or an empty answer when no test is on record |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **402** | The SMTP settings section is not enabled for this portal |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsmtpsettings"></a>
# **GetSmtpSettings**
> SmtpSettingsWrapper GetSmtpSettings ()

Returns the SMTP relay this portal sends its own mail through - host, port, sender identity and authentication  flags - as it is stored for the portal. Nothing has to be called first; the caller needs the portal-settings  right of a DocSpace administrator, and the SMTP settings section has to be enabled for the portal, otherwise  the call is answered with 402. The call is read-only and safe to repeat. `isDefaultSettings` is true when the  portal has no settings of its own and runs on the mail configuration of the installation: a standalone  installation then shows those server-wide values, while a cloud portal is answered with an empty settings  object instead, so an empty `host` together with `isDefaultSettings` true means nothing was ever saved here.  `credentialsUserPassword` always comes back empty - the stored password cannot be read back, and a client that  saves the settings again has to ask the user for it once more. `port` is the port that was saved, and settings  saved without one are stored with `25`. To find out whether the returned relay actually accepts mail, queue a  test with `GET api/2.0/smtpsettings/smtp/test`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-smtp-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**SmtpSettingsWrapper**](SmtpSettingsWrapper.md)

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
    public class GetSmtpSettingsExample
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
            var apiInstance = new SMTPSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get SMTP settings
                SmtpSettingsWrapper result = apiInstance.GetSmtpSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPSettingsApi.GetSmtpSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSmtpSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SMTP settings
    ApiResponse<SmtpSettingsWrapper> response = apiInstance.GetSmtpSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPSettingsApi.GetSmtpSettingsWithHttpInfo: " + e.Message);
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
| **200** | The SMTP settings stored for the portal, with an empty password and `isDefaultSettings` telling whether the configuration of the installation is in use |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **402** | The SMTP settings section is not enabled for this portal |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resetsmtpsettings"></a>
# **ResetSmtpSettings**
> SmtpSettingsWrapper ResetSmtpSettings ()

Deletes the SMTP settings of this portal and puts it back on the mail configuration of the installation, so  the portal stops using the relay saved by `POST api/2.0/smtpsettings/smtp`. Nothing has to be called first;  the caller needs the portal-settings right of a DocSpace administrator, and the SMTP settings section has to  be enabled for the portal, otherwise the call is answered with 402. The call is destructive and cannot be  undone - the host, the sender identity and the credentials are gone and have to be entered again - but it is  idempotent, and on a portal that has no settings of its own it changes nothing. Portal mail itself keeps  working as long as the installation has a relay of its own configured. The answer holds the settings that are  in force after the reset, always with `isDefaultSettings` true: the server-wide values in a standalone  installation, an empty settings object in a cloud portal, and an empty `credentialsUserPassword` in both. Read  them back at any time with `GET api/2.0/smtpsettings/smtp`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-smtp-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**SmtpSettingsWrapper**](SmtpSettingsWrapper.md)

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
    public class ResetSmtpSettingsExample
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
            var apiInstance = new SMTPSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Reset SMTP settings
                SmtpSettingsWrapper result = apiInstance.ResetSmtpSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPSettingsApi.ResetSmtpSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetSmtpSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset SMTP settings
    ApiResponse<SmtpSettingsWrapper> response = apiInstance.ResetSmtpSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPSettingsApi.ResetSmtpSettingsWithHttpInfo: " + e.Message);
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
| **200** | The settings in force after the reset - the configuration of the installation, or an empty settings object in a cloud portal |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **402** | The SMTP settings section is not enabled for this portal |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savesmtpsettings"></a>
# **SaveSmtpSettings**
> SmtpSettingsWrapper SaveSmtpSettings (SmtpSettingsDto? smtpSettingsDto = null)

Stores the SMTP relay that this portal will hand all of its own mail to, replacing whatever was saved before  and taking the portal off the mail configuration of the installation. Nothing has to be called first; the  caller needs the portal-settings right of a DocSpace administrator, and the SMTP settings section has to be  enabled for the portal, otherwise the call is answered with 402. The call is mutating and idempotent - the  same body saved twice leaves the same settings - and it applies to the next message the portal sends. The  settings are stored unverified, no connection to `host` is attempted, so queue  `GET api/2.0/smtpsettings/smtp/test` afterwards to find out whether they work. `host` and `senderAddress` must  not be empty, `senderDisplayName` has to be present, and `enableAuth` true also requires `credentialsUserName`  and `credentialsUserPassword`; a request that misses any of them is rejected and nothing is saved. `port`  falls back to `25` when it is omitted, and `useNtlm` is accepted but not stored, so the saved settings always  authenticate with a plain user name and password. The answer repeats the stored settings with the password  emptied. Use `DELETE api/2.0/smtpsettings/smtp` to return to the configuration of the installation.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/save-smtp-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smtpSettingsDto** | [**SmtpSettingsDto?**](SmtpSettingsDto.md) | The mail server the portal sends its letters through. | [optional]  |

### Return type

[**SmtpSettingsWrapper**](SmtpSettingsWrapper.md)

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
    public class SaveSmtpSettingsExample
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
            var apiInstance = new SMTPSettingsApi(httpClient, config, httpClientHandler);
            var smtpSettingsDto = new SmtpSettingsDto?(); // SmtpSettingsDto? | The mail server the portal sends its letters through. (optional) 

            try
            {
                // Save SMTP settings
                SmtpSettingsWrapper result = apiInstance.SaveSmtpSettings(smtpSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPSettingsApi.SaveSmtpSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveSmtpSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save SMTP settings
    ApiResponse<SmtpSettingsWrapper> response = apiInstance.SaveSmtpSettingsWithHttpInfo(smtpSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPSettingsApi.SaveSmtpSettingsWithHttpInfo: " + e.Message);
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
| **200** | The SMTP settings now stored for the portal, with an empty password |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **402** | The SMTP settings section is not enabled for this portal |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="testsmtpsettings"></a>
# **TestSmtpSettings**
> SmtpOperationStatusRequestsWrapper TestSmtpSettings ()

Queues a background job that sends a test message through the SMTP settings currently stored for the portal to  the email address of the calling user, and returns the state of that job. Save the settings with  `POST api/2.0/smtpsettings/smtp` first: the job always takes the stored settings and nothing can be passed to  it here. The caller needs the portal-settings right of a DocSpace administrator, and the SMTP settings section  has to be enabled for the portal, otherwise the call is answered with 402. The call is mutating, it sends  mail, and it is rate-limited to five requests per fifteen minutes per user and path by default, answering 429  above that; while a test is still running the same job is returned instead of a second one being started. The  message has not been sent when the answer arrives: poll `GET api/2.0/smtpsettings/smtp/test/status` until  `completed` is true, then read `error` - empty means the relay accepted the message, otherwise it carries the  reason. `percents` climbs to 100 and `status` names the step reached, such as `Connect to host` or  `Send test message`. An unreachable relay is reported in `error` after a 30-second connection timeout, not as  a failed request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/test-smtp-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**SmtpOperationStatusRequestsWrapper**](SmtpOperationStatusRequestsWrapper.md)

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
    public class TestSmtpSettingsExample
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
            var apiInstance = new SMTPSettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Test SMTP settings
                SmtpOperationStatusRequestsWrapper result = apiInstance.TestSmtpSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMTPSettingsApi.TestSmtpSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TestSmtpSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test SMTP settings
    ApiResponse<SmtpOperationStatusRequestsWrapper> response = apiInstance.TestSmtpSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMTPSettingsApi.TestSmtpSettingsWithHttpInfo: " + e.Message);
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
| **200** | The state of the queued test message, to be polled until `completed` is true |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **402** | The SMTP settings section is not enabled for this portal |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

