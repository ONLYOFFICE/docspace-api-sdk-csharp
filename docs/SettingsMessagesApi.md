# DocSpace.API.SDK.Api.MessagesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EnableAdminMessageSettings**](#enableadminmessagesettings) | **POST** /api/2.0/settings/messagesettings | Enable or disable administrator messages |
| [**SendAdminMail**](#sendadminmail) | **POST** /api/2.0/settings/sendadmmail | Send a message to the administrator |
| [**SendJoinInviteMail**](#sendjoininvitemail) | **POST** /api/2.0/settings/sendjoininvite | Send an invitation email |

<a id="enableadminmessagesettings"></a>
# **EnableAdminMessageSettings**
> StringWrapper EnableAdminMessageSettings (TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = null)

Switches on or off the contact form the sign-in page offers a visitor who cannot get into the portal, and  which delivers their message to the portal administrators. The caller needs the portal-settings right of a  DocSpace administrator - the portal owner and a DocSpace administrator qualify, any other member is refused.  Send the new state as `turnOn`: `true` publishes the form, `false` hides it. The change covers the whole  portal, applies to the next sign-in page without a restart, is recorded in the audit trail, and repeating the  call with the same value leaves the portal as it is. What comes back is a localized confirmation message  rather than the stored flag - read the flag as `enableAdmMess` from `GET api/2.0/settings`, which needs no  token. That flag is also forced on while the portal's payment has lapsed, so it can report `true` on a portal  where the form was switched off here. The form itself posts to `POST api/2.0/settings/sendadmmail` and this  setting gates nothing else: the notifications administrators receive as portal members are subscribed  separately with `POST api/2.0/settings/notification`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/enable-admin-message-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **turnOnAdminMessageSettingsRequestDto** | [**TurnOnAdminMessageSettingsRequestDto?**](TurnOnAdminMessageSettingsRequestDto.md) | Whether the sign-in page offers the form for writing to the portal administrators. | [optional]  |

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
    public class EnableAdminMessageSettingsExample
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
            var apiInstance = new MessagesApi(httpClient, config, httpClientHandler);
            var turnOnAdminMessageSettingsRequestDto = new TurnOnAdminMessageSettingsRequestDto?(); // TurnOnAdminMessageSettingsRequestDto? | Whether the sign-in page offers the form for writing to the portal administrators. (optional) 

            try
            {
                // Enable or disable administrator messages
                StringWrapper result = apiInstance.EnableAdminMessageSettings(turnOnAdminMessageSettingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.EnableAdminMessageSettings: " + e.Message);
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
    // Enable or disable administrator messages
    ApiResponse<StringWrapper> response = apiInstance.EnableAdminMessageSettingsWithHttpInfo(turnOnAdminMessageSettingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.EnableAdminMessageSettingsWithHttpInfo: " + e.Message);
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
| **200** | A localized message confirming that the administrator message setting has been saved |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendadminmail"></a>
# **SendAdminMail**
> StringWrapper SendAdminMail (AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = null)

Sends a message from someone who cannot get into the portal to its administrators - the contact form the  sign-in page offers unauthenticated visitors. No token is needed. The form has to be published first with  `POST api/2.0/settings/messagesettings` unless the portal's payment has lapsed, otherwise nothing is sent;  `enableAdmMess` in `GET api/2.0/settings` reports whether the call is worth making. `email` is the address the  administrators answer to and has to be a real address, and `message` is reduced to plain text first, so a body  carrying nothing but markup counts as empty - either fault is refused with 400. When the caller is not signed  in and this installation has a CAPTCHA configured, `recaptchaResponse` has to carry a solved challenge of the  `recaptchaType` that `GET api/2.0/settings` publishes together with the site key, and a missing or stale  answer refuses the call. `culture` picks the language of the letter. Delivery is queued and reaches the  administrators subscribed to administrator notifications, so a confirmed call means accepted rather than read,  and the answer is a localized confirmation. Attempts are rate limited per address and per operation, and  further ones are refused with 429.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/send-admin-mail/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **adminMessageSettingsRequestsDto** | [**AdminMessageSettingsRequestsDto?**](AdminMessageSettingsRequestsDto.md) | The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. | [optional]  |

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
    public class SendAdminMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagesApi(httpClient, config, httpClientHandler);
            var adminMessageSettingsRequestsDto = new AdminMessageSettingsRequestsDto?(); // AdminMessageSettingsRequestsDto? | The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it. (optional) 

            try
            {
                // Send a message to the administrator
                StringWrapper result = apiInstance.SendAdminMail(adminMessageSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.SendAdminMail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendAdminMailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a message to the administrator
    ApiResponse<StringWrapper> response = apiInstance.SendAdminMailWithHttpInfo(adminMessageSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.SendAdminMailWithHttpInfo: " + e.Message);
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
| **200** | A localized message confirming that the message has been queued for the portal administrators |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The email address is malformed, or the message is empty once its markup is stripped |  -  |
| **429** | Too many contact attempts came from the same address within the rate-limit window |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendjoininvitemail"></a>
# **SendJoinInviteMail**
> StringWrapper SendJoinInviteMail (AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = null)

Sends an invitation email with a join link to the address in the request - the self-registration the sign-in  page's register link performs. No token is needed. The portal has to publish a trusted-domain policy first,  saved with `POST api/2.0/settings/maildomainsettings`: without one there is nothing to join and every caller  alike is answered with 405 - the same condition `GET api/2.0/settings` reports as `enabledJoin`. `email` has  to be a real address written in ASCII rather than an internationalized one, must not already belong to a  portal member, and, when the policy names domains rather than accepting all of them, has to end with one of  them - each of those faults is refused with 400. `culture` picks the language of the letter. The invitation is  not an account: the invitee becomes a member only after following the link, and the role it grants, user or  room administrator, follows the trusted-domain settings and drops to user once the portal's paid places are  taken. Where the installation caps invitations, an accepted call spends one of those counted by  `invitationLimit`, and only about a dozen calls from one address in two minutes are accepted. What comes back  is a localized confirmation.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/send-join-invite-mail/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **adminMessageBaseSettingsRequestsDto** | [**AdminMessageBaseSettingsRequestsDto?**](AdminMessageBaseSettingsRequestsDto.md) | Who is invited to join the portal, and in which language the invitation is written. | [optional]  |

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
    public class SendJoinInviteMailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new MessagesApi(httpClient, config, httpClientHandler);
            var adminMessageBaseSettingsRequestsDto = new AdminMessageBaseSettingsRequestsDto?(); // AdminMessageBaseSettingsRequestsDto? | Who is invited to join the portal, and in which language the invitation is written. (optional) 

            try
            {
                // Send an invitation email
                StringWrapper result = apiInstance.SendJoinInviteMail(adminMessageBaseSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.SendJoinInviteMail: " + e.Message);
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
    // Send an invitation email
    ApiResponse<StringWrapper> response = apiInstance.SendJoinInviteMailWithHttpInfo(adminMessageBaseSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.SendJoinInviteMailWithHttpInfo: " + e.Message);
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
| **200** | A localized message confirming that the invitation with the join link has been sent |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The email address is malformed or internationalized, lies outside the trusted domains, or already belongs to a member of the portal |  -  |
| **403** | The portal is not accepting requests while it is being restored, transferred or encrypted |  -  |
| **405** | The portal publishes no trusted-domain policy, so it has nothing to join |  -  |
| **429** | Too many invitation requests came from the same network address |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

