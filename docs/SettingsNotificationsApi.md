# DocSpace.API.SDK.Api.NotificationsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetNotificationChannels**](#getnotificationchannels) | **GET** /api/2.0/settings/notification/channels | Get notification channels |
| [**GetNotificationSettings**](#getnotificationsettings) | **GET** /api/2.0/settings/notification/{type} | Check notification availability |
| [**GetRoomsNotificationSettings**](#getroomsnotificationsettings) | **GET** /api/2.0/settings/notification/rooms | Get muted rooms |
| [**SetNotificationSettings**](#setnotificationsettings) | **POST** /api/2.0/settings/notification | Set notification status |
| [**SetRoomsNotificationStatus**](#setroomsnotificationstatus) | **POST** /api/2.0/settings/notification/rooms | Mute or unmute a room |

<a id="getnotificationchannels"></a>
# **GetNotificationChannels**
> NotificationChannelStatusWrapper GetNotificationChannels ()

Lists the ways this installation can deliver a notification, each as the internal name of the channel together  with `isEnabled`: `email.sender` for letters and `telegram.sender` for Telegram messages. The list describes  the installation and the portal rather than the calling user, so every member gets the same answer, and the  call is read-only. Any signed-in member may ask for it, whatever its role, and no permission is demanded. A  channel appears only when the notification service of the running installation is configured with a sender of  that name, so the list can be shorter than the two names above, and an empty list means that configuration  names no channel this build implements. `email.sender` is reported as enabled whenever it is listed, while  `telegram.sender` is reported as enabled only while the portal has a Telegram bot name and token stored, which  is what `POST api/2.0/settings/authservice` writes. An enabled channel says nothing about the caller: a member  also has to connect their own Telegram account, for which `GET api/2.0/settings/telegram/link` hands out the  link and `GET api/2.0/settings/telegram/check` reports the outcome. Which kinds of notification a member  receives is a separate setting, read with `GET api/2.0/settings/notification/{type}`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-channels/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**NotificationChannelStatusWrapper**](NotificationChannelStatusWrapper.md)

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
    public class GetNotificationChannelsExample
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
            var apiInstance = new NotificationsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get notification channels
                NotificationChannelStatusWrapper result = apiInstance.GetNotificationChannels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationChannels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNotificationChannelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get notification channels
    ApiResponse<NotificationChannelStatusWrapper> response = apiInstance.GetNotificationChannelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.GetNotificationChannelsWithHttpInfo: " + e.Message);
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
| **200** | The notification channels this installation can deliver through, each with the flag that says whether it is enabled |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnotificationsettings"></a>
# **GetNotificationSettings**
> NotificationSettingsWrapper GetNotificationSettings (NotificationType type)

Reports whether one kind of notification is switched on for the calling user, taking the kind as the integer  `type` in the route: 0 the new-item badges the Files responses carry, 1 the room activity letters, 2 the daily  feed digest, 3 the periodic tips letters. The answer describes the caller's own account only - there is no way  to read another member's settings - and the call is read-only and safe to repeat. Every signed-in member reads  its own settings: the portal owner, a DocSpace administrator, a room administrator, a user and a guest are all  accepted, and no permission is demanded. Badges come back switched on for an account that has not changed  them, while the kinds 1, 2 and 3 come back switched off until they are switched on with  `POST api/2.0/settings/notification`. What comes back is the kind that was asked for together with  `isEnabled`. A `type` outside 0-3 is not recognised and the call fails instead of falling back to a default.  The rooms silenced one by one are listed by `GET api/2.0/settings/notification/rooms`, and the delivery  channels of the installation by `GET api/2.0/settings/notification/channels`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-notification-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **NotificationType** | The kind of notification being asked about. A value outside the defined set fails the call rather than  falling back to a default. |  |

### Return type

[**NotificationSettingsWrapper**](NotificationSettingsWrapper.md)

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
    public class GetNotificationSettingsExample
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
            var apiInstance = new NotificationsApi(httpClient, config, httpClientHandler);
            var type = 0;  // NotificationType | The kind of notification being asked about. A value outside the defined set fails the call rather than  falling back to a default.

            try
            {
                // Check notification availability
                NotificationSettingsWrapper result = apiInstance.GetNotificationSettings(type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check notification availability
    ApiResponse<NotificationSettingsWrapper> response = apiInstance.GetNotificationSettingsWithHttpInfo(type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.GetNotificationSettingsWithHttpInfo: " + e.Message);
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
| **200** | The notification kind that was asked for together with the flag that says whether it is switched on for the calling user |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomsnotificationsettings"></a>
# **GetRoomsNotificationSettings**
> RoomsNotificationSettingsWrapper GetRoomsNotificationSettings ()

Returns the rooms the calling user has silenced, as the `disabledRooms` list of their identifiers. The list  describes the caller's own account only, the call is read-only, and an empty list means nothing is silenced.  Every signed-in member reads its own list, whatever its role - owner, administrator, user or guest - and no  permission is demanded. The identifiers come back the way `POST api/2.0/settings/notification/rooms` stored  them, in the order they were added and without paging; they are kept as opaque values, so both the numeric  identifier of a portal room and the string identifier of a room on a connected third-party account appear  here, and an identifier stays in the list after the room itself is deleted. While a room is on this list its  activity is left out of the hourly room digest and of the daily feed, the letters that room would send at once  are not sent, and its new-item counters are hidden from the Files responses. Silencing a room changes nothing  for its other members. The kinds of notification this list is applied to are switched with  `POST api/2.0/settings/notification`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-notification-settings/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**RoomsNotificationSettingsWrapper**](RoomsNotificationSettingsWrapper.md)

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
    public class GetRoomsNotificationSettingsExample
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
            var apiInstance = new NotificationsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get muted rooms
                RoomsNotificationSettingsWrapper result = apiInstance.GetRoomsNotificationSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetRoomsNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomsNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get muted rooms
    ApiResponse<RoomsNotificationSettingsWrapper> response = apiInstance.GetRoomsNotificationSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.GetRoomsNotificationSettingsWithHttpInfo: " + e.Message);
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
| **200** | The identifiers of the rooms the calling user has silenced |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setnotificationsettings"></a>
# **SetNotificationSettings**
> NotificationSettingsWrapper SetNotificationSettings (NotificationSettingsRequestsDto? notificationSettingsRequestsDto = null)

Switches one kind of notification on or off for the calling user: send the kind as `type` - 0 the new-item  badges, 1 the room activity letters, 2 the daily feed digest, 3 the periodic tips letters - together with  `isEnabled`. The change touches the caller's own account only, and repeating the call with the same pair  leaves the account as it is. Every signed-in member configures its own settings: the portal owner, a DocSpace  administrator, a room administrator, a user and a guest are all accepted, and no permission is demanded. With  0 switched off the Files responses report `new` as 0 and mark files as muted; with 1 switched off both the  hourly room digest and the letters a room sends at once, such as an editor mention, stop; with 2 switched off  the daily digest stops; with 3 switched off the tips letters stop. What comes back is an echo of the request  rather than a re-read of the stored state, and a `type` outside 0-3 is echoed as well while nothing is stored,  so confirm the result with `GET api/2.0/settings/notification/{type}`. To silence a single room instead of a  whole kind use `POST api/2.0/settings/notification/rooms`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-notification-settings/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notificationSettingsRequestsDto** | [**NotificationSettingsRequestsDto?**](NotificationSettingsRequestsDto.md) | Which kind of notification the calling user switches, and which way. | [optional]  |

### Return type

[**NotificationSettingsWrapper**](NotificationSettingsWrapper.md)

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
    public class SetNotificationSettingsExample
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
            var apiInstance = new NotificationsApi(httpClient, config, httpClientHandler);
            var notificationSettingsRequestsDto = new NotificationSettingsRequestsDto?(); // NotificationSettingsRequestsDto? | Which kind of notification the calling user switches, and which way. (optional) 

            try
            {
                // Set notification status
                NotificationSettingsWrapper result = apiInstance.SetNotificationSettings(notificationSettingsRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.SetNotificationSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetNotificationSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set notification status
    ApiResponse<NotificationSettingsWrapper> response = apiInstance.SetNotificationSettingsWithHttpInfo(notificationSettingsRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.SetNotificationSettingsWithHttpInfo: " + e.Message);
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
| **200** | The notification kind and state as they were sent in the request |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setroomsnotificationstatus"></a>
# **SetRoomsNotificationStatus**
> RoomsNotificationSettingsWrapper SetRoomsNotificationStatus (RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = null)

Adds one room to the calling user's silenced list or takes it off again: `mute` true silences the room, false  lets its notifications through. One call carries one room, so several rooms take several calls, and repeating  a call with the same pair changes nothing. The room is named by `roomsId` and kept as an opaque value: the  numeric identifier of a portal room and the string identifier of a room on a connected third-party account are  both accepted, and neither the room's existence nor the caller's access to it is checked, so a mistyped  identifier is stored as sent. Every signed-in member manages its own list, whatever its role, and the list of  another member cannot be touched. While a room is silenced its activity is left out of the hourly room digest  and of the daily feed, the letters it would send at once are not sent, and its new-item counters are hidden.  The Files responses stop offering the `mute` action on a room once badges, room activity and the daily feed  are all switched off, while this call keeps working. What comes back is the whole updated list, the same shape  `GET api/2.0/settings/notification/rooms` returns.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-rooms-notification-status/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomsNotificationsSettingsRequestDto** | [**RoomsNotificationsSettingsRequestDto?**](RoomsNotificationsSettingsRequestDto.md) | Which single room the calling user silences, and which way. | [optional]  |

### Return type

[**RoomsNotificationSettingsWrapper**](RoomsNotificationSettingsWrapper.md)

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
    public class SetRoomsNotificationStatusExample
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
            var apiInstance = new NotificationsApi(httpClient, config, httpClientHandler);
            var roomsNotificationsSettingsRequestDto = new RoomsNotificationsSettingsRequestDto?(); // RoomsNotificationsSettingsRequestDto? | Which single room the calling user silences, and which way. (optional) 

            try
            {
                // Mute or unmute a room
                RoomsNotificationSettingsWrapper result = apiInstance.SetRoomsNotificationStatus(roomsNotificationsSettingsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsApi.SetRoomsNotificationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetRoomsNotificationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mute or unmute a room
    ApiResponse<RoomsNotificationSettingsWrapper> response = apiInstance.SetRoomsNotificationStatusWithHttpInfo(roomsNotificationsSettingsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsApi.SetRoomsNotificationStatusWithHttpInfo: " + e.Message);
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
| **200** | The identifiers of the rooms the calling user has silenced, as the list stands after the change |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

