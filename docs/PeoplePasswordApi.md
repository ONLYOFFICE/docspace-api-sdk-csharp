# DocSpace.API.SDK.Api.PasswordApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeUserPassword**](#changeuserpassword) | **PUT** /api/2.0/people/{userid}/password | Change a user password |
| [**SendUserPassword**](#senduserpassword) | **POST** /api/2.0/people/password | Remind a user password |

<a id="changeuserpassword"></a>
# **ChangeUserPassword**
> EmployeeFullWrapper ChangeUserPassword (Guid userid, ChangePasswordRequest changePasswordRequest)

Sets a new password on an account, which is the step that completes a password change or a password  recovery.  The request has to carry the confirmation token from the emailed link rather than an ordinary session, and an  expired or already used token is answered with 401.  The account has to exist and be `Active`, so the password of a disabled account or of an open invitation  cannot be set, and only the portal owner may set the owner's own password.  Send either `passwordHash`, which is taken as it is, or a plain `password`, which is checked against the  portal password policy; sending neither, or a password the policy rejects, answers 400.  The change ends every other session of that account and emails it a notice that the password was changed.  The answer is the profile, which does not carry the password in any form.  To have the recovery link sent in the first place, use `POST api/2.0/people/password`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/change-user-password/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **Guid** | The ID of the account whose password is set, taken from the route. It has to match the account the  confirmation token was issued for, and the account has to be active. |  |
| **changePasswordRequest** | [**ChangePasswordRequest**](ChangePasswordRequest.md) | The new password, sent either in plain text or already hashed. Exactly one of the two fields is needed. |  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class ChangeUserPasswordExample
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
            var apiInstance = new PasswordApi(httpClient, config, httpClientHandler);
            var userid = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the account whose password is set, taken from the route. It has to match the account the  confirmation token was issued for, and the account has to be active.
            var changePasswordRequest = new ChangePasswordRequest(); // ChangePasswordRequest | The new password, sent either in plain text or already hashed. Exactly one of the two fields is needed.

            try
            {
                // Change a user password
                EmployeeFullWrapper result = apiInstance.ChangeUserPassword(userid, changePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PasswordApi.ChangeUserPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeUserPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change a user password
    ApiResponse<EmployeeFullWrapper> response = apiInstance.ChangeUserPasswordWithHttpInfo(userid, changePasswordRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PasswordApi.ChangeUserPasswordWithHttpInfo: " + e.Message);
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
| **200** | The profile whose password was changed |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The user ID is empty, no password was sent, or the password does not meet the portal policy |  -  |
| **403** | The account is not active, or only its owner may change this password |  -  |
| **404** | No account has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="senduserpassword"></a>
# **SendUserPassword**
> StringWrapper SendUserPassword (EmailMemberRequestDto? emailMemberRequestDto = null)

Emails a password recovery link to an address, and is the entry point of the recovery flow rather than the  operation that changes anything.  It needs no authentication, which is how a person who cannot sign in uses it; when the portal has a CAPTCHA  configured, an unauthenticated request has to pass it and answers 403 if it does not.  An unauthenticated caller always gets the same success message, whether or not the address belongs to an  account, so the answer cannot be used to find out which addresses are registered.  An authenticated caller does get told: a failure is answered with 403, and asking for somebody else requires  DocSpace administrator rights, while the owner's password can be asked for by the owner alone and another  administrator's only by the owner.  The link that is sent leads to `PUT api/2.0/people/{userid}/password`, which is where the new password is  set; no password is ever sent by email despite the wording of the message.  Repeated calls are throttled.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/send-user-password/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailMemberRequestDto** | [**EmailMemberRequestDto?**](EmailMemberRequestDto.md) | The request parameters for the user email. | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

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
    public class SendUserPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PasswordApi(httpClient, config, httpClientHandler);
            var emailMemberRequestDto = new EmailMemberRequestDto?(); // EmailMemberRequestDto? | The request parameters for the user email. (optional) 

            try
            {
                // Remind a user password
                StringWrapper result = apiInstance.SendUserPassword(emailMemberRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PasswordApi.SendUserPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendUserPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remind a user password
    ApiResponse<StringWrapper> response = apiInstance.SendUserPasswordWithHttpInfo(emailMemberRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PasswordApi.SendUserPasswordWithHttpInfo: " + e.Message);
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
| **200** | The message stating that the recovery link was sent to the address |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The CAPTCHA was not passed, or an authenticated caller may not ask for that account |  -  |
| **429** | Too Many Requests. |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

