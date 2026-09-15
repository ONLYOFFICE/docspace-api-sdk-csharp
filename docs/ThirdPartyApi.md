# DocSpace.API.SDK.Api.ThirdPartyApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetThirdPartyCode**](#getthirdpartycode) | **GET** /api/2.0/thirdparty/{provider} | Get provider consent URL |

<a id="getthirdpartycode"></a>
# **GetThirdPartyCode**
> StringWrapper GetThirdPartyCode (LoginProvider provider)

Builds and returns, as a string, the OAuth 2.0 consent URL of one external provider - the address a client  opens in a browser so that the user can grant this portal access to their account. The provider's client id,  secret and redirect URI have to be saved for the portal first with `POST api/2.0/settings/authservice`;  without them the URL has no `client_id` and the provider refuses it. Any signed-in portal user may call it,  and the call is read-only and safe to repeat. The URL carries `response_type=code`, the portal's `client_id`,  the provider's `redirect_uri`, the scope the portal needs (Drive with offline access for Google, `signature`  for DocuSign) and a `state` pointing back at this portal's `thirdparty/{provider}/code` page, where the code  arrives in the URL fragment as `#code=...`, or `#error/...` when the user declines. Only Google `1`, Dropbox  `2`, Docusign `3`, Box `4`, OneDrive `5`, Wordpress `10` and Github `13` produce a URL; any other value is  answered with 200 and no URL instead of an error. With `desktop=true`, the whole query string is copied into  `state` and comes back on the callback. The code is not exchanged here: pass it on as `token` to  `POST api/2.0/files/thirdparty` to connect the account.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-code/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **LoginProvider** | The provider whose consent screen is wanted. Only Google, Dropbox, Docusign, Box, OneDrive, Wordpress and  Github produce a URL; any other provider is answered with 200 and no URL rather than an error. The provider  credentials have to be saved with `POST api/2.0/settings/authservice` first, or the URL comes back without a  client identifier and the provider refuses it. |  |

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
    public class GetThirdPartyCodeExample
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
            var apiInstance = new ThirdPartyApi(httpClient, config, httpClientHandler);
            var provider = (LoginProvider) "0";  // LoginProvider | The provider whose consent screen is wanted. Only Google, Dropbox, Docusign, Box, OneDrive, Wordpress and  Github produce a URL; any other provider is answered with 200 and no URL rather than an error. The provider  credentials have to be saved with `POST api/2.0/settings/authservice` first, or the URL comes back without a  client identifier and the provider refuses it.

            try
            {
                // Get provider consent URL
                StringWrapper result = apiInstance.GetThirdPartyCode(provider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ThirdPartyApi.GetThirdPartyCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetThirdPartyCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get provider consent URL
    ApiResponse<StringWrapper> response = apiInstance.GetThirdPartyCodeWithHttpInfo(provider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ThirdPartyApi.GetThirdPartyCodeWithHttpInfo: " + e.Message);
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
| **200** | The consent URL of the provider, ready to be opened in a browser; empty when the requested provider is not one of the seven this operation supports |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

