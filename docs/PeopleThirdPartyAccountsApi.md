# Docspace.Api.PeopleThirdPartyAccountsApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAuthProviders**](PeopleThirdPartyAccountsApi.md#getauthproviders) | **GET** /api/2.0/people/thirdparty/providers | Get third-party accounts |
| [**LinkAccount**](PeopleThirdPartyAccountsApi.md#linkaccount) | **PUT** /api/2.0/people/thirdparty/linkaccount | Link a third-pary account |
| [**SignupAccount**](PeopleThirdPartyAccountsApi.md#signupaccount) | **POST** /api/2.0/people/thirdparty/signup | Create a third-pary account |
| [**UnlinkAccount**](PeopleThirdPartyAccountsApi.md#unlinkaccount) | **DELETE** /api/2.0/people/thirdparty/unlinkaccount | Unlink a third-pary account |

<a id="getauthproviders"></a>
# **GetAuthProviders**
> AccountInfoArrayWrapper GetAuthProviders (bool? inviteView = null, bool? settingsView = null, string? clientCallback = null, string? fromOnly = null)

Get third-party accounts

Returns a list of the available third-party accounts.

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
    public class GetAuthProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
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
                AccountInfoArrayWrapper result = apiInstance.GetAuthProviders(inviteView, settingsView, clientCallback, fromOnly);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.GetAuthProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get third-party accounts
    ApiResponse<AccountInfoArrayWrapper> response = apiInstance.GetAuthProvidersWithHttpInfo(inviteView, settingsView, clientCallback, fromOnly);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.GetAuthProvidersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of third-party accounts |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="linkaccount"></a>
# **LinkAccount**
> void LinkAccount (LinkAccountRequestDto? linkAccountRequestDto = null)

Link a third-pary account

Links a third-party account specified in the request to the user profile.

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
    public class LinkAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
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
            var linkAccountRequestDto = new LinkAccountRequestDto?(); // LinkAccountRequestDto? |  (optional) 

            try
            {
                // Link a third-pary account
                apiInstance.LinkAccount(linkAccountRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.LinkAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LinkAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Link a third-pary account
    apiInstance.LinkAccountWithHttpInfo(linkAccountRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.LinkAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linkAccountRequestDto** | [**LinkAccountRequestDto?**](LinkAccountRequestDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

<a id="signupaccount"></a>
# **SignupAccount**
> void SignupAccount (SignupAccountRequestDto? signupAccountRequestDto = null)

Create a third-pary account

Creates a third-party account with the parameters specified in the request.

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
    public class SignupAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleThirdPartyAccountsApi(httpClient, config, httpClientHandler);
            var signupAccountRequestDto = new SignupAccountRequestDto?(); // SignupAccountRequestDto? |  (optional) 

            try
            {
                // Create a third-pary account
                apiInstance.SignupAccount(signupAccountRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.SignupAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignupAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a third-pary account
    apiInstance.SignupAccountWithHttpInfo(signupAccountRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.SignupAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **signupAccountRequestDto** | [**SignupAccountRequestDto?**](SignupAccountRequestDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

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

<a id="unlinkaccount"></a>
# **UnlinkAccount**
> void UnlinkAccount (string? provider = null)

Unlink a third-pary account

Unlinks a third-party account specified in the request from the user profile.

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
    public class UnlinkAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
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
                apiInstance.UnlinkAccount(provider);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.UnlinkAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlinkAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink a third-pary account
    apiInstance.UnlinkAccountWithHttpInfo(provider);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleThirdPartyAccountsApi.UnlinkAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **provider** | **string?** | The provider name. | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

