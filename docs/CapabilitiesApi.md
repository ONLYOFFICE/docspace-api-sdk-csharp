# DocSpace.API.SDK.Api.CapabilitiesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPortalCapabilities**](#getportalcapabilities) | **GET** /api/2.0/capabilities | Get portal capabilities |

<a id="getportalcapabilities"></a>
# **GetPortalCapabilities**
> CapabilitiesWrapper GetPortalCapabilities ()

Returns the sign-in methods this portal offers, which a login client needs before anyone has signed in: LDAP  authentication and its domain, the external identity providers to show, the SAML single sign-on URL and its  label, and whether the built-in identity server is available. No token is needed and nothing has to be called  first - the operation is open to unauthenticated callers, answers even while the portal's payment has lapsed,  and is read-only and idempotent. `providers` holds provider keys such as `google` or `facebook`, ordered for  the country detected from the caller's IP address and reduced to the ones this installation has configured;  pass one of them as `provider` to `POST api/2.0/authentication`. An empty `providers` means external sign-in  is off and an empty `ssoUrl` means single sign-on is off; a capability whose settings cannot be read is  reported as disabled rather than failing the call, so a false flag means the method is not offered, not that  it is unknown. The answer describes the portal and never a user, and carries none of the configuration behind  these methods: an administrator reads that from `GET api/2.0/settings/ssov2` and  `GET api/2.0/settings/authservice`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-portal-capabilities/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**CapabilitiesWrapper**](CapabilitiesWrapper.md)

### Authorization

No authorization required

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
    public class GetPortalCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new CapabilitiesApi(httpClient, config, httpClientHandler);

            try
            {
                // Get portal capabilities
                CapabilitiesWrapper result = apiInstance.GetPortalCapabilities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CapabilitiesApi.GetPortalCapabilities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortalCapabilitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get portal capabilities
    ApiResponse<CapabilitiesWrapper> response = apiInstance.GetPortalCapabilitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CapabilitiesApi.GetPortalCapabilitiesWithHttpInfo: " + e.Message);
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
| **200** | The sign-in methods the portal offers: LDAP, the external identity providers, single sign-on and the identity server, each with the state it has for this portal |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

