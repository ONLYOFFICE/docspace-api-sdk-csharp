# DocSpace.API.SDK.Api.LicenseApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptLicense**](#acceptlicense) | **POST** /api/2.0/settings/license/accept | Activate a license |
| [**GetIsLicenseRequired**](#getislicenserequired) | **GET** /api/2.0/settings/license/required | Check if a license is required |
| [**RefreshLicense**](#refreshlicense) | **GET** /api/2.0/settings/license/refresh | Refresh the license |
| [**UploadLicense**](#uploadlicense) | **POST** /api/2.0/settings/license | Upload a license |

<a id="acceptlicense"></a>
# **AcceptLicense**
> StringWrapper AcceptLicense ()

Activates the license staged by `POST api/2.0/settings/license` on this self-hosted Enterprise installation:  it records that the license was accepted, promotes the staged file to the active one and rewrites the  portal-wide quota and tariff from it. Upload a file first: with nothing staged and no license on disk there is  nothing to activate. The caller only has to be signed in, and the activation is recorded in the audit trail.  Repeating the call is safe: the acceptance stamp is written only once and the same license is simply applied  again. Read the outcome from the body rather than the status code - an empty string means the license is now  active, and any other string is a message explaining why it is not: no license key was found, the key is not  correct, the installed edition does not match the license type, or the license is expired or too small for the  current user count. The acceptance stamp survives a failed activation, so a corrected file needs nothing  extra. An installation with no license path configured answers that its pricing plan does not support the  option and changes nothing. The operation stays reachable while the portal is unpaid.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/accept-license/).

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
    public class AcceptLicenseExample
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
            var apiInstance = new LicenseApi(httpClient, config, httpClientHandler);

            try
            {
                // Activate a license
                StringWrapper result = apiInstance.AcceptLicense();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.AcceptLicense: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptLicenseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate a license
    ApiResponse<StringWrapper> response = apiInstance.AcceptLicenseWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.AcceptLicenseWithHttpInfo: " + e.Message);
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
| **200** | An empty string when the license is now active, or a localized sentence explaining why it was not activated |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getislicenserequired"></a>
# **GetIsLicenseRequired**
> BooleanWrapper GetIsLicenseRequired ()

Reports whether this installation still has to be given a license file before it can be used, which is the  question the setup wizard asks before offering its license upload step. No authentication is needed, so it can  be called on a portal nobody has signed in to yet, and the call is read-only. The answer is `true` only for a  self-hosted Enterprise build whose license file is not on disk yet; an open-source or SaaS portal, a portal  configured to let anyone in without an account, an installation whose configuration hides the pricing section,  and one that takes its setup from cloud-image metadata all answer `false`. A `false` answer therefore does not  mean the portal is licensed - it also covers every build that needs no license at all. Nothing here describes  a license already in place, neither its due date nor whether the editing service still accepts it, and the  answer turns to `false` only once a staged file has been activated by `POST api/2.0/settings/license/accept`,  not when it is uploaded. The operation stays reachable while the portal is unpaid.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-is-license-required/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [bearerAuth](../README.md#bearerAuth)

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
    public class GetIsLicenseRequiredExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // Configure API key authorization: cookieAuth
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LicenseApi(httpClient, config, httpClientHandler);

            try
            {
                // Check if a license is required
                BooleanWrapper result = apiInstance.GetIsLicenseRequired();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.GetIsLicenseRequired: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIsLicenseRequiredWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if a license is required
    ApiResponse<BooleanWrapper> response = apiInstance.GetIsLicenseRequiredWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.GetIsLicenseRequiredWithHttpInfo: " + e.Message);
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
| **200** | `true` when this Enterprise installation still needs a license file, `false` when one is already active or the build needs none |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refreshlicense"></a>
# **RefreshLicense**
> BooleanWrapper RefreshLicense ()

Re-reads the license file of this self-hosted Enterprise installation and rewrites the portal-wide quota and  tariff from it, so a file replaced on disk or a renewal issued by the vendor takes effect without a restart. A  license staged by `POST api/2.0/settings/license` is promoted to the active one here as well, but the usual  first-time order is upload and then `POST api/2.0/settings/license/accept`; this operation is for later  refreshes. The caller only has to be signed in - no administrator right is checked. Despite the `GET`, the  call rewrites stored data, and it is idempotent: repeating it applies the same license again. The editing  service is asked to confirm the license as part of the check, and the license it reports must match the file.  The answer is `true` when the license was applied and `false` on an installation with no license path  configured at all, such as a SaaS or open-source portal, where nothing is read and nothing changes. A missing  or unreadable file, a mismatched customer or edition, and an editing service that rejects the license all fail  the call instead of answering `false`. The operation stays reachable while the portal is unpaid.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/refresh-license/).

### Parameters
This endpoint does not need any parameter.
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
    public class RefreshLicenseExample
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
            var apiInstance = new LicenseApi(httpClient, config, httpClientHandler);

            try
            {
                // Refresh the license
                BooleanWrapper result = apiInstance.RefreshLicense();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.RefreshLicense: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefreshLicenseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refresh the license
    ApiResponse<BooleanWrapper> response = apiInstance.RefreshLicenseWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.RefreshLicenseWithHttpInfo: " + e.Message);
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
| **200** | `true` when the license file was re-read and the portal quota and tariff rewritten from it, `false` on an installation that has no license path configured |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadlicense"></a>
# **UploadLicense**
> StringWrapper UploadLicense (List<FileParameter> files)

Takes the license file of this self-hosted Enterprise installation as `multipart/form-data` and stages it for  activation; only the first entry of `Files` is read and the rest are ignored. The file is validated but not  put in force here - follow with `POST api/2.0/settings/license/accept` to activate it, and until then the  portal keeps the license it already had. The caller must be a DocSpace administrator, or hold a wizard or  administrator confirmation link while the setup wizard is still unfinished; after the wizard is complete such  a link alone is refused. An earlier staged file is overwritten, so the upload can be repeated safely. The  answer is a localized sentence, not a structured result: `Uploaded successfully` on its own, or the same words  plus the date since when support and updates are not covered, because a file already past its due date is  still accepted. A request carrying no file, and a license whose start date has not arrived yet, are rejected  as invalid; a file that cannot be read as a license, carries no customer id or signature, or was issued for  the other edition fails the call. Whether the editing service accepts it is only checked at activation.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-license/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **files** | **List&lt;FileParameter&gt;** | The license file, sent as `multipart/form-data`. Only the first entry is read and the rest are ignored, and a  request carrying none is refused with 400. A file that cannot be read as a license, that carries no customer  id or signature, or that was issued for the other edition fails the call; one whose start date has not  arrived yet is refused, while one already past its due date is still accepted. Staging only stores the file -  `POST api/2.0/settings/license/accept` puts it in force - and a file staged earlier is overwritten. |  |

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
    public class UploadLicenseExample
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
            var apiInstance = new LicenseApi(httpClient, config, httpClientHandler);
            var files = new List<FileParameter>(); // List<FileParameter> | The license file, sent as `multipart/form-data`. Only the first entry is read and the rest are ignored, and a  request carrying none is refused with 400. A file that cannot be read as a license, that carries no customer  id or signature, or that was issued for the other edition fails the call; one whose start date has not  arrived yet is refused, while one already past its due date is still accepted. Staging only stores the file -  `POST api/2.0/settings/license/accept` puts it in force - and a file staged earlier is overwritten.

            try
            {
                // Upload a license
                StringWrapper result = apiInstance.UploadLicense(files);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicenseApi.UploadLicense: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadLicenseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload a license
    ApiResponse<StringWrapper> response = apiInstance.UploadLicenseWithHttpInfo(files);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicenseApi.UploadLicenseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A localized confirmation that the file was staged, carrying the date support and updates ended when the license is already overdue |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The request carried no license file, or the license does not start until a later date |  -  |
| **403** | The caller is not a DocSpace administrator, or a confirmation link was used after the setup wizard had already been completed |  -  |
| **405** | The installation has no license path configured, so it cannot be given a license file |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

