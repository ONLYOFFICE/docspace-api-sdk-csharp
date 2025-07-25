# Docspace.Api.SettingsMessagesApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EnableAdminMessageSettings**](SettingsMessagesApi.md#enableadminmessagesettings) | **POST** /api/2.0/settings/messagesettings | Enable the administrator message settings |
| [**SendAdmMail**](SettingsMessagesApi.md#sendadmmail) | **POST** /api/2.0/settings/sendadmmail | Send a message to the administrator |
| [**SendJoinInviteMail**](SettingsMessagesApi.md#sendjoininvitemail) | **POST** /api/2.0/settings/sendjoininvite | Sends an invitation email |

<a id="enableadminmessagesettings"></a>
# **EnableAdminMessageSettings**
> StringWrapper EnableAdminMessageSettings (TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = null)

Enable the administrator message settings

Displays the contact form on the \"Sign In\" page, allowing users to send a message to the DocSpace administrator in case they encounter any issues while accessing DocSpace.

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
    public class EnableAdminMessageSettingsExample
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
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsMessagesApi(httpClient, config, httpClientHandler);
            var turnOnAdminMessageSettingsRequestDto = new TurnOnAdminMessageSettingsRequestDto?(); // TurnOnAdminMessageSettingsRequestDto? |  (optional) 

            try
            {
                // Enable the administrator message settings
                StringWrapper result = apiInstance.EnableAdminMessageSettings(turnOnAdminMessageSettingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsMessagesApi.EnableAdminMessageSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableAdminMessageSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable the administrator message settings
    ApiResponse<StringWrapper> response = apiInstance.EnableAdminMessageSettingsWithHttpInfo(turnOnAdminMessageSettingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsMessagesApi.EnableAdminMessageSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **turnOnAdminMessageSettingsRequestDto** | [**TurnOnAdminMessageSettingsRequestDto?**](TurnOnAdminMessageSettingsRequestDto?.md) |  | [optional]  |

### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Message about the result of saving new settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendadmmail"></a>
# **SendAdmMail**
> StringWrapper SendAdmMail (AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = null)

Send a message to the administrator

Sends a message to the administrator email when unauthorized users encounter issues accessing DocSpace.

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
    public class SendAdmMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsMessagesApi(httpClient, config, httpClientHandler);
            var adminMessageSettingsRequestsDto = new AdminMessageSettingsRequestsDto?(); // AdminMessageSettingsRequestsDto? |  (optional) 

            try
            {
                // Send a message to the administrator
                StringWrapper result = apiInstance.SendAdmMail(adminMessageSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsMessagesApi.SendAdmMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendAdmMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a message to the administrator
    ApiResponse<StringWrapper> response = apiInstance.SendAdmMailWithHttpInfo(adminMessageSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsMessagesApi.SendAdmMailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **adminMessageSettingsRequestsDto** | [**AdminMessageSettingsRequestsDto?**](AdminMessageSettingsRequestsDto?.md) |  | [optional]  |

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
| **200** | Message about the result of sending a message |  -  |
| **400** | Incorrect email or message text is empty |  -  |
| **429** | Request limit is exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendjoininvitemail"></a>
# **SendJoinInviteMail**
> StringWrapper SendJoinInviteMail (AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = null)

Sends an invitation email

Sends an invitation email with a link to the DocSpace.

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
    public class SendJoinInviteMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SettingsMessagesApi(httpClient, config, httpClientHandler);
            var adminMessageBaseSettingsRequestsDto = new AdminMessageBaseSettingsRequestsDto?(); // AdminMessageBaseSettingsRequestsDto? |  (optional) 

            try
            {
                // Sends an invitation email
                StringWrapper result = apiInstance.SendJoinInviteMail(adminMessageBaseSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsMessagesApi.SendJoinInviteMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendJoinInviteMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sends an invitation email
    ApiResponse<StringWrapper> response = apiInstance.SendJoinInviteMailWithHttpInfo(adminMessageBaseSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsMessagesApi.SendJoinInviteMailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **adminMessageBaseSettingsRequestsDto** | [**AdminMessageBaseSettingsRequestsDto?**](AdminMessageBaseSettingsRequestsDto?.md) |  | [optional]  |

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
| **200** | Message about sending a link to confirm joining the DocSpace |  -  |
| **400** | Incorrect email or email already exists |  -  |
| **403** | No permissions to perform this action |  -  |
| **429** | Request limit is exceeded |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

