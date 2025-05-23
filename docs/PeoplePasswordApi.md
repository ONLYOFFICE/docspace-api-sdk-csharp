# Docspace.Api.PeoplePasswordApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeUserPassword**](PeoplePasswordApi.md#changeuserpassword) | **PUT** /api/2.0/people/{userid}/password | Change a user password |
| [**SendUserPassword**](PeoplePasswordApi.md#senduserpassword) | **POST** /api/2.0/people/password | Remind a user password |

<a id="changeuserpassword"></a>
# **ChangeUserPassword**
> EmployeeFullWrapper ChangeUserPassword (Guid userid, MemberBaseRequestDto? memberBaseRequestDto = null)

Change a user password

Sets a new password to the user with the ID specified in the request.

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
    public class ChangeUserPasswordExample
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
            var apiInstance = new PeoplePasswordApi(httpClient, config, httpClientHandler);
            var userid = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid | The user ID.
            var memberBaseRequestDto = new MemberBaseRequestDto?(); // MemberBaseRequestDto? | The request parameters for the user generic information. (optional) 

            try
            {
                // Change a user password
                EmployeeFullWrapper result = apiInstance.ChangeUserPassword(userid, memberBaseRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePasswordApi.ChangeUserPassword: " + e.Message);
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
    ApiResponse<EmployeeFullWrapper> response = apiInstance.ChangeUserPasswordWithHttpInfo(userid, memberBaseRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeoplePasswordApi.ChangeUserPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **Guid** | The user ID. |  |
| **memberBaseRequestDto** | [**MemberBaseRequestDto?**](MemberBaseRequestDto?.md) | The request parameters for the user generic information. | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Detailed user information |  -  |
| **400** | Incorrect email |  -  |
| **401** | Unauthorized |  -  |
| **403** | The invitation link is invalid or its validity has expired |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="senduserpassword"></a>
# **SendUserPassword**
> StringWrapper SendUserPassword (EmailMemberRequestDto? emailMemberRequestDto = null)

Remind a user password

Reminds a password to the user using the email address specified in the request.

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
    public class SendUserPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeoplePasswordApi(httpClient, config, httpClientHandler);
            var emailMemberRequestDto = new EmailMemberRequestDto?(); // EmailMemberRequestDto? |  (optional) 

            try
            {
                // Remind a user password
                StringWrapper result = apiInstance.SendUserPassword(emailMemberRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeoplePasswordApi.SendUserPassword: " + e.Message);
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
    Debug.Print("Exception when calling PeoplePasswordApi.SendUserPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailMemberRequestDto** | [**EmailMemberRequestDto?**](EmailMemberRequestDto?.md) |  | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Email with the password |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

