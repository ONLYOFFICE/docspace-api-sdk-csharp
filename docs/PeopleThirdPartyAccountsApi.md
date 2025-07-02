# DocSpace.Sdk.Api.PeopleThirdPartyAccountsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetThirdPartyAuthProviders**](#getthirdpartyauthproviders) | **GET** /api/2.0/people/thirdparty/providers | Get third-party accounts |
| [**LinkThirdPartyAccount**](#linkthirdpartyaccount) | **PUT** /api/2.0/people/thirdparty/linkaccount | Link a third-pary account |
| [**SignupThirdPartyAccount**](#signupthirdpartyaccount) | **POST** /api/2.0/people/thirdparty/signup | Create a third-pary account |
| [**UnlinkThirdPartyAccount**](#unlinkthirdpartyaccount) | **DELETE** /api/2.0/people/thirdparty/unlinkaccount | Unlink a third-pary account |

<a id="getthirdpartyauthproviders"></a>
# **GetThirdPartyAuthProviders**
> AccountInfoArrayWrapper GetThirdPartyAuthProviders (bool? inviteView = null, bool? settingsView = null, string? clientCallback = null, string? fromOnly = null)

Returns a list of the available third-party accounts.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-third-party-auth-providers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inviteView** | **bool?** | Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. | [optional]  |
| **settingsView** | **bool?** | Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). | [optional]  |
| **clientCallback** | **string?** | The method that is called after authentication. | [optional]  |
| **fromOnly** | **string?** | The provider name if a response is required only from this provider. | [optional]  |

### Return type

[**AccountInfoArrayWrapper**](AccountInfoArrayWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class GetThirdPartyAuthProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleThirdPartyAccountsApi(httpClient, config, httpClientHandler);
            var inviteView = true;  // bool? | Specifies whether to return providers that are available for invitation links, i.e. the user can login or register through these providers. (optional) 
            var settingsView = true;  // bool? | Specifies whether to display the provider settings in a pop-up window (true) or redirect them to the desktop application (false). (optional) 
            var clientCallback = some text;  // string? | The method that is called after authentication. (optional) 
            var fromOnly = some text;  // string? | The provider name if a response is required only from this provider. (optional) 

            try
            {
                // Get third-party accounts
                AccountInfoArrayWrapper result = apiInstance.GetThirdPartyAuthProviders(inviteView, settingsView, clientCallback, fromOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.GetThirdPartyAuthProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetThirdPartyAuthProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get third-party accounts
    ApiResponse<AccountInfoArrayWrapper> response = apiInstance.GetThirdPartyAuthProvidersWithHttpInfo(inviteView, settingsView, clientCallback, fromOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.GetThirdPartyAuthProvidersWithHttpInfo: " + e.Message);
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
| **200** | List of third-party accounts |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="linkthirdpartyaccount"></a>
# **LinkThirdPartyAccount**
> void LinkThirdPartyAccount (LinkAccountRequestDto? linkAccountRequestDto = null)

Links a third-party account specified in the request to the user profile.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/link-third-party-account/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkAccountRequestDto** | [**LinkAccountRequestDto?**](LinkAccountRequestDto.md) | The request parameters for linking accounts. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class LinkThirdPartyAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
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
            var apiInstance = new PeopleThirdPartyAccountsApi(httpClient, config, httpClientHandler);
            var linkAccountRequestDto = new LinkAccountRequestDto?(); // LinkAccountRequestDto? | The request parameters for linking accounts. (optional) 

            try
            {
                // Link a third-pary account
                apiInstance.LinkThirdPartyAccount(linkAccountRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.LinkThirdPartyAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkThirdPartyAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Link a third-pary account
    apiInstance.LinkThirdPartyAccountWithHttpInfo(linkAccountRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.LinkThirdPartyAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **405** | Error not allowed option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="signupthirdpartyaccount"></a>
# **SignupThirdPartyAccount**
> void SignupThirdPartyAccount (SignupAccountRequestDto? signupAccountRequestDto = null)

Creates a third-party account with the parameters specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/signup-third-party-account/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signupAccountRequestDto** | [**SignupAccountRequestDto?**](SignupAccountRequestDto.md) | The request parameters for creating a third-party account. | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class SignupThirdPartyAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleThirdPartyAccountsApi(httpClient, config, httpClientHandler);
            var signupAccountRequestDto = new SignupAccountRequestDto?(); // SignupAccountRequestDto? | The request parameters for creating a third-party account. (optional) 

            try
            {
                // Create a third-pary account
                apiInstance.SignupThirdPartyAccount(signupAccountRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.SignupThirdPartyAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignupThirdPartyAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a third-pary account
    apiInstance.SignupThirdPartyAccountWithHttpInfo(signupAccountRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.SignupThirdPartyAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **400** | Incorrect email |  -  |
| **403** | The invitation link is invalid or its validity has expired |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unlinkthirdpartyaccount"></a>
# **UnlinkThirdPartyAccount**
> void UnlinkThirdPartyAccount (string? provider = null)

Unlinks a third-party account specified in the request from the user profile.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-third-party-account/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string?** | The provider name. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Sdk.Api;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace Example
{
    public class UnlinkThirdPartyAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
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
            var apiInstance = new PeopleThirdPartyAccountsApi(httpClient, config, httpClientHandler);
            var provider = some text;  // string? | The provider name. (optional) 

            try
            {
                // Unlink a third-pary account
                apiInstance.UnlinkThirdPartyAccount(provider);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.UnlinkThirdPartyAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkThirdPartyAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink a third-pary account
    apiInstance.UnlinkThirdPartyAccountWithHttpInfo(provider);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.UnlinkThirdPartyAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

