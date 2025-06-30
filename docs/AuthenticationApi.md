# DocSpace.Api.AuthenticationApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthenticateMe**](AuthenticationApi.md#authenticateme) | **POST** /api/2.0/authentication | Authenticate a user |
| [**AuthenticateMeFromBodyWithCode**](AuthenticationApi.md#authenticatemefrombodywithcode) | **POST** /api/2.0/authentication/{code} | Authenticate a user by code |
| [**CheckConfirm**](AuthenticationApi.md#checkconfirm) | **POST** /api/2.0/authentication/confirm | Open confirmation email URL |
| [**GetIsAuthentificated**](AuthenticationApi.md#getisauthentificated) | **GET** /api/2.0/authentication | Check authentication |
| [**Logout**](AuthenticationApi.md#logout) | **POST** /api/2.0/authentication/logout | Log out |
| [**SaveMobilePhone**](AuthenticationApi.md#savemobilephone) | **POST** /api/2.0/authentication/setphone | Set a mobile phone |
| [**SendSmsCode**](AuthenticationApi.md#sendsmscode) | **POST** /api/2.0/authentication/sendsms | Send SMS code |

<a id="authenticateme"></a>
# **AuthenticateMe**
> AuthenticationTokenWrapper AuthenticateMe (AuthRequestsDto? authRequestsDto = null)

Authenticates the current user by SMS, authenticator app, or without two-factor authentication.

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authRequestsDto** | [**AuthRequestsDto?**](AuthRequestsDto.md) | The parameters required for the user authentication requests. | [optional]  |

### Return type

[**AuthenticationTokenWrapper**](AuthenticationTokenWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class AuthenticateMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var authRequestsDto = new AuthRequestsDto?(); // AuthRequestsDto? | The parameters required for the user authentication requests. (optional) 

            try
            {
                // Authenticate a user
                AuthenticationTokenWrapper result = apiInstance.AuthenticateMe(authRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticateMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthenticateMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authenticate a user
    ApiResponse<AuthenticationTokenWrapper> response = apiInstance.AuthenticateMeWithHttpInfo(authRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.AuthenticateMeWithHttpInfo: " + e.Message);
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
| **200** | Authentication data |  -  |
| **400** | userName, password or passworHash is empty |  -  |
| **401** | User authentication failed |  -  |
| **404** | The user could not be found |  -  |
| **429** | Too many login attempts. Please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="authenticatemefrombodywithcode"></a>
# **AuthenticateMeFromBodyWithCode**
> AuthenticationTokenWrapper AuthenticateMeFromBodyWithCode (string code, AuthRequestsDto? authRequestsDto = null)

Authenticates the current user by SMS or two-factor authentication code.

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |
| **authRequestsDto** | [**AuthRequestsDto?**](AuthRequestsDto.md) | The parameters required for the user authentication requests. | [optional]  |

### Return type

[**AuthenticationTokenWrapper**](AuthenticationTokenWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class AuthenticateMeFromBodyWithCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var code = "code_example";  // string | 
            var authRequestsDto = new AuthRequestsDto?(); // AuthRequestsDto? | The parameters required for the user authentication requests. (optional) 

            try
            {
                // Authenticate a user by code
                AuthenticationTokenWrapper result = apiInstance.AuthenticateMeFromBodyWithCode(code, authRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticateMeFromBodyWithCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthenticateMeFromBodyWithCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authenticate a user by code
    ApiResponse<AuthenticationTokenWrapper> response = apiInstance.AuthenticateMeFromBodyWithCodeWithHttpInfo(code, authRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.AuthenticateMeFromBodyWithCodeWithHttpInfo: " + e.Message);
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
| **200** | Authentication data |  -  |
| **400** | userName, password or passworHash is empty |  -  |
| **401** | User authentication failed |  -  |
| **403** | Auth code is not available |  -  |
| **429** | Too many login attempts. Please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkconfirm"></a>
# **CheckConfirm**
> ConfirmWrapper CheckConfirm (EmailValidationKeyModel? emailValidationKeyModel = null)

Opens a confirmation email URL to validate a certain action (employee invitation, portal removal, phone activation, etc.).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailValidationKeyModel** | [**EmailValidationKeyModel?**](EmailValidationKeyModel.md) | The confirmation email parameters. | [optional]  |

### Return type

[**ConfirmWrapper**](ConfirmWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class CheckConfirmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var emailValidationKeyModel = new EmailValidationKeyModel?(); // EmailValidationKeyModel? | The confirmation email parameters. (optional) 

            try
            {
                // Open confirmation email URL
                ConfirmWrapper result = apiInstance.CheckConfirm(emailValidationKeyModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.CheckConfirm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckConfirmWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Open confirmation email URL
    ApiResponse<ConfirmWrapper> response = apiInstance.CheckConfirmWithHttpInfo(emailValidationKeyModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.CheckConfirmWithHttpInfo: " + e.Message);
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
| **200** | Validation result: Ok, Invalid, or Expired |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getisauthentificated"></a>
# **GetIsAuthentificated**
> BooleanWrapper GetIsAuthentificated ()

Checks if the current user is authenticated or not.

### Parameters
This endpoint does not need any parameter.
### Return type

[**BooleanWrapper**](BooleanWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class GetIsAuthentificatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);

            try
            {
                // Check authentication
                BooleanWrapper result = apiInstance.GetIsAuthentificated();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetIsAuthentificated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIsAuthentificatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check authentication
    ApiResponse<BooleanWrapper> response = apiInstance.GetIsAuthentificatedWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetIsAuthentificatedWithHttpInfo: " + e.Message);
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
| **200** | Boolean value: true if the current user is authenticated |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logout"></a>
# **Logout**
> StringWrapper Logout ()

Logs out of the current user account.

### Parameters
This endpoint does not need any parameter.
### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);

            try
            {
                // Log out
                StringWrapper result = apiInstance.Logout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out
    ApiResponse<StringWrapper> response = apiInstance.LogoutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.LogoutWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="savemobilephone"></a>
# **SaveMobilePhone**
> AuthenticationTokenWrapper SaveMobilePhone (MobileRequestsDto? mobileRequestsDto = null)

Sets a mobile phone for the current user.

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mobileRequestsDto** | [**MobileRequestsDto?**](MobileRequestsDto.md) | The parameters required for the mobile phone verification. | [optional]  |

### Return type

[**AuthenticationTokenWrapper**](AuthenticationTokenWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class SaveMobilePhoneExample
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
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var mobileRequestsDto = new MobileRequestsDto?(); // MobileRequestsDto? | The parameters required for the mobile phone verification. (optional) 

            try
            {
                // Set a mobile phone
                AuthenticationTokenWrapper result = apiInstance.SaveMobilePhone(mobileRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SaveMobilePhone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SaveMobilePhoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a mobile phone
    ApiResponse<AuthenticationTokenWrapper> response = apiInstance.SaveMobilePhoneWithHttpInfo(mobileRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.SaveMobilePhoneWithHttpInfo: " + e.Message);
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
| **200** | Authentication data |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendsmscode"></a>
# **SendSmsCode**
> AuthenticationTokenWrapper SendSmsCode (AuthRequestsDto? authRequestsDto = null)

Sends SMS with an authentication code.

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authRequestsDto** | [**AuthRequestsDto?**](AuthRequestsDto.md) | The parameters required for the user authentication requests. | [optional]  |

### Return type

[**AuthenticationTokenWrapper**](AuthenticationTokenWrapper.md)

### Authorization

No authorization required

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using DocSpace.Api;
using DocSpace.Client;
using DocSpace.Model;

namespace Example
{
    public class SendSmsCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AuthenticationApi(httpClient, config, httpClientHandler);
            var authRequestsDto = new AuthRequestsDto?(); // AuthRequestsDto? | The parameters required for the user authentication requests. (optional) 

            try
            {
                // Send SMS code
                AuthenticationTokenWrapper result = apiInstance.SendSmsCode(authRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.SendSmsCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSmsCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send SMS code
    ApiResponse<AuthenticationTokenWrapper> response = apiInstance.SendSmsCodeWithHttpInfo(authRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.SendSmsCodeWithHttpInfo: " + e.Message);
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
| **200** | Authentication data |  -  |
| **400** | userName, password or passworHash is empty |  -  |
| **429** | Too many login attempts. Please try again later |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

