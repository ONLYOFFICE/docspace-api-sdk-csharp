# DocSpace.API.SDK.Api.SettingsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContinuePortal**](#continueportal) | **PUT** /api/2.0/portal/continue | Restore a portal |
| [**DeletePortal**](#deleteportal) | **DELETE** /api/2.0/portal/delete | Delete a portal |
| [**GetPortalInformation**](#getportalinformation) | **GET** /api/2.0/portal | Get portal information |
| [**GetPortalPath**](#getportalpath) | **GET** /api/2.0/portal/path | Get a path to the portal |
| [**SendDeleteInstructions**](#senddeleteinstructions) | **POST** /api/2.0/portal/delete | Send removal instructions |
| [**SendSuspendInstructions**](#sendsuspendinstructions) | **POST** /api/2.0/portal/suspend | Send suspension instructions |
| [**SuspendPortal**](#suspendportal) | **PUT** /api/2.0/portal/suspend | Deactivate a portal |

<a id="continueportal"></a>
# **ContinuePortal**
> void ContinuePortal ()

Brings a deactivated portal back to the active state, so its users can sign in again and its domain serves the  portal as before. It is reached only with the reactivation link that `POST api/2.0/portal/suspend` mails to  the portal owner: that link authorizes the call in place of an authentication token, and no ordinary token is  accepted here. The call is mutating and idempotent - it sets the status to active, re-applies the portal's  Content Security Policy and refreshes its base domain, and a portal that is already active is simply left  active. Nothing is returned in the body; read the result from `status` in `GET api/2.0/portal`. Deactivating  the portal again means asking for a fresh letter with `POST api/2.0/portal/suspend`, because each link is  issued for one operation. This operation cannot bring back a removed portal: the deletion behind  `DELETE api/2.0/portal/delete` is final, and a removed portal has to be restored from a backup instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-portal/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

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
    public class ContinuePortalExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Restore a portal
                apiInstance.ContinuePortal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.ContinuePortal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContinuePortalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Restore a portal
    apiInstance.ContinuePortalWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.ContinuePortalWithHttpInfo: " + e.Message);
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
| **200** | OK |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteportal"></a>
# **DeletePortal**
> StringWrapper DeletePortal ()

Removes this portal for good: its rooms, files, accounts, settings and OAuth clients go with it and its domain  stops serving the portal. It is reached only with the removal link that `POST api/2.0/portal/delete` mails to  the portal owner - that link authorizes the call instead of an authentication token - and the owner is checked  again here; on a server installation the last remaining space cannot be removed. The call is destructive and  cannot be undone, and there is no restore operation, so take a backup with `POST api/2.0/backup/startbackup`  first when the content still matters. It keeps working while the portal's payment has lapsed. Along the way  the portal is dropped from the hosting cache, the owner is mailed a confirmation, the removal is written to  the audit trail and, for a portal that was paying, the support team is notified as well. The answer is the  absolute URL of the feedback form to send the departing owner to. To pause the portal instead of erasing it,  use `PUT api/2.0/portal/suspend`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-portal/).

### Parameters
This endpoint does not need any parameter.
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
    public class DeletePortalExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Delete a portal
                StringWrapper result = apiInstance.DeletePortal();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.DeletePortal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePortalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a portal
    ApiResponse<StringWrapper> response = apiInstance.DeletePortalWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.DeletePortalWithHttpInfo: " + e.Message);
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
| **200** | The absolute URL of the feedback form to send the owner of the removed portal to |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getportalinformation"></a>
# **GetPortalInformation**
> TenantWrapper GetPortalInformation ()

Returns the portal the request was addressed to - the tenant behind the current domain - with its name, alias,  owner, language, time zone, industry, trusted-domain rules, version and creation date. Nothing has to be  called first, the call is read-only and idempotent, and it keeps answering while the portal's payment has  lapsed. What comes back depends on the caller's rights: a caller with the portal-settings right gets the whole  record, while every other user gets an object in which only `tenantId` is filled and no error is raised - so  check `tenantAlias` for null before reading the rest. `status` says whether the portal is active, suspended or  pending removal, and `creationDateTime`, `statusChangeDate`, `lastModified` and `versionChanged` are UTC.  `region` names the data-center region a hosted portal is served from and stays empty on a server installation  and when the portal cache is off, while `hostedRegion` is the region written on the record itself. The  settings of the same portal are read with `GET api/2.0/settings`, its tariff with `GET api/2.0/portal/tariff`  and its quota with `GET api/2.0/portal/quota`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-information/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**TenantWrapper**](TenantWrapper.md)

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
    public class GetPortalInformationExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get portal information
                TenantWrapper result = apiInstance.GetPortalInformation();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPortalInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortalInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get portal information
    ApiResponse<TenantWrapper> response = apiInstance.GetPortalInformationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetPortalInformationWithHttpInfo: " + e.Message);
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
| **200** | The portal record, or an object in which only `tenantId` is filled when the caller has no portal-settings right |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getportalpath"></a>
# **GetPortalPath**
> StringWrapper GetPortalPath (string? virtualPath = null)

Turns a portal-relative path into the absolute URL a client can open, filling in the scheme, the current  portal domain and the virtual root the portal is hosted on. Any signed-in user may call it, nothing has to be  called first, and the call is read-only and idempotent - it neither checks that the path exists nor that the  caller is allowed to open it. `virtualPath` is taken as it is: an omitted or empty value yields the portal  root, a value starting with `/` is appended to that root, a value starting with `~/` is resolved against the  virtual root, and a value that already starts with `http://`, `https://` or `mailto:` is handed back  unchanged. The answer is a bare JSON string. The domain in the result is the one the portal answers on right  now, so a renamed portal starts returning the new domain without any change on the client. Use it to build  links that have to survive a rename; the portal's own addresses and settings are read from  `GET api/2.0/settings` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-path/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **virtualPath** | **string?** | The path to resolve. It is taken as it is: an omitted or empty value yields the portal root, a value starting  with `/` is appended to that root, a value starting with `~/` is resolved against the virtual root, and one  that already begins with `http://`, `https://` or `mailto:` is handed back unchanged. Nothing checks that the  path exists or that the caller may open it. | [optional]  |

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
    public class GetPortalPathExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);
            var virtualPath = /portal/documents;  // string? | The path to resolve. It is taken as it is: an omitted or empty value yields the portal root, a value starting  with `/` is appended to that root, a value starting with `~/` is resolved against the virtual root, and one  that already begins with `http://`, `https://` or `mailto:` is handed back unchanged. Nothing checks that the  path exists or that the caller may open it. (optional) 

            try
            {
                // Get a path to the portal
                StringWrapper result = apiInstance.GetPortalPath(virtualPath);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetPortalPath: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortalPathWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a path to the portal
    ApiResponse<StringWrapper> response = apiInstance.GetPortalPathWithHttpInfo(virtualPath);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetPortalPathWithHttpInfo: " + e.Message);
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
| **200** | The absolute URL that the given portal-relative path resolves to |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="senddeleteinstructions"></a>
# **SendDeleteInstructions**
> void SendDeleteInstructions ()

Mails the portal owner the confirmation link that removes this portal; nothing about the portal changes until  that link is used. The caller has to be the portal owner and hold the portal-settings right, and on a server  installation the last remaining space cannot be removed - the call is refused when every other space has  limited access. The letter goes to the owner's own address whoever asked for it, and it warns about the  subscription that will stop renewing when the portal is on a paid plan. The operation keeps working while the  portal's payment has lapsed, is mutating only in that it sends a message, and is rate-limited to five requests  per fifteen minutes per user and path by default, answering 429 above that. Nothing is returned in the body.  The link in the letter authorizes `DELETE api/2.0/portal/delete`, which deletes the portal with all of its  rooms, files and accounts and cannot be undone. To pause the portal instead of deleting it, send the  deactivation letter with `POST api/2.0/portal/suspend`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/send-delete-instructions/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

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
    public class SendDeleteInstructionsExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Send removal instructions
                apiInstance.SendDeleteInstructions();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.SendDeleteInstructions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendDeleteInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send removal instructions
    apiInstance.SendDeleteInstructionsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.SendDeleteInstructionsWithHttpInfo: " + e.Message);
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
| **200** | OK |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendsuspendinstructions"></a>
# **SendSuspendInstructions**
> void SendSuspendInstructions ()

Mails the portal owner the two confirmation links that deactivate this portal and bring it back again, and  records the request in the audit trail; the portal itself is not changed here. The caller has to be the portal  owner and hold the portal-settings right, and on a server installation the last remaining space cannot be  deactivated - the call is refused when every other space has limited access. The letter always goes to the  owner's own address, and the operation keeps working while the portal's payment has lapsed. It is mutating  only in that it sends a message, and it is rate-limited to five requests per fifteen minutes per user and path  by default, answering 429 above that. Nothing is returned in the body, so a client cannot tell from the answer  whether the mail was delivered. The first link in the letter authorizes `PUT api/2.0/portal/suspend`, which  suspends the portal, and the second one authorizes `PUT api/2.0/portal/continue`, which makes it active again.  To remove the portal instead of pausing it, use `POST api/2.0/portal/delete`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/send-suspend-instructions/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

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
    public class SendSuspendInstructionsExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Send suspension instructions
                apiInstance.SendSuspendInstructions();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.SendSuspendInstructions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSuspendInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send suspension instructions
    apiInstance.SendSuspendInstructionsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.SendSuspendInstructionsWithHttpInfo: " + e.Message);
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
| **200** | OK |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="suspendportal"></a>
# **SuspendPortal**
> void SuspendPortal ()

Deactivates this portal: its status becomes suspended and its users can no longer work in it, while all of its  rooms, files and accounts stay untouched. It is reached only with the deactivation link that  `POST api/2.0/portal/suspend` mails to the portal owner - that link authorizes the call instead of an  authentication token - and the owner is checked again here, so a link issued for another account is refused.  On a server installation the last remaining space cannot be deactivated. The call is mutating and idempotent:  it sets the status, records the deactivation in the audit trail and refreshes the portal's base domain, and  repeating it leaves the portal suspended. Nothing is returned in the body; the new state is read from `status`  in `GET api/2.0/portal`. Bring the portal back with `PUT api/2.0/portal/continue`, using the second link from  the same letter. To remove the portal and its content for good, use `DELETE api/2.0/portal/delete` instead -  that cannot be undone.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/suspend-portal/).

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

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
    public class SuspendPortalExample
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
            var apiInstance = new SettingsApi(httpClient, config, httpClientHandler);

            try
            {
                // Deactivate a portal
                apiInstance.SuspendPortal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.SuspendPortal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SuspendPortalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivate a portal
    apiInstance.SuspendPortalWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.SuspendPortalWithHttpInfo: " + e.Message);
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
| **200** | OK |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

