# DocSpace.API.SDK.Api.ActiveConnectionsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllActiveConnections**](#getallactiveconnections) | **GET** /api/2.0/security/activeconnections | Get active connections |
| [**LogOutActiveConnection**](#logoutactiveconnection) | **PUT** /api/2.0/security/activeconnections/logout/{loginEventId} | Log out one connection |
| [**LogOutAllActiveConnectionsChangePassword**](#logoutallactiveconnectionschangepassword) | **PUT** /api/2.0/security/activeconnections/logoutallchangepassword | Log out and reset password |
| [**LogOutAllActiveConnectionsForUser**](#logoutallactiveconnectionsforuser) | **PUT** /api/2.0/security/activeconnections/logoutall/{userId} | Log out a user everywhere |
| [**LogOutAllExceptThisConnection**](#logoutallexceptthisconnection) | **PUT** /api/2.0/security/activeconnections/logoutallexceptthis | Log out other connections |

<a id="getallactiveconnections"></a>
# **GetAllActiveConnections**
> ActiveConnectionsWrapper GetAllActiveConnections ()

Lists the connections the calling user currently has open on this portal - one item per successful sign-in  that is still active - so a client can show where the account is signed in and close what does not belong  there. Any signed-in user may call it, nothing has to be called first, and the answer always covers the caller  alone: the operation is read-only, idempotent and cannot show another user's connections. Items cover the last  year and are ordered newest sign-in first, with the caller's own connection moved to the top and its browser,  platform, IP address and location refreshed from the current request. `loginEvent` is the ID of that own  connection and is `0` when the request was authenticated with a token in the `Authorization` header instead of  the portal cookie; nothing is then marked as current, and a user with no stored connections gets a single item  describing the current request. `country` and `city` are resolved from the IP address and stay empty when it  cannot be located. Pass an item's `id` to `PUT api/2.0/security/activeconnections/logout/{loginEventId}` to  end that one connection.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-active-connections/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**ActiveConnectionsWrapper**](ActiveConnectionsWrapper.md)

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
    public class GetAllActiveConnectionsExample
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
            var apiInstance = new ActiveConnectionsApi(httpClient, config, httpClientHandler);

            try
            {
                // Get active connections
                ActiveConnectionsWrapper result = apiInstance.GetAllActiveConnections();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActiveConnectionsApi.GetAllActiveConnections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllActiveConnectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get active connections
    ApiResponse<ActiveConnectionsWrapper> response = apiInstance.GetAllActiveConnectionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActiveConnectionsApi.GetAllActiveConnectionsWithHttpInfo: " + e.Message);
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
| **200** | The caller's active connections, newest sign-in first, with `loginEvent` pointing at the connection the request itself was made with |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logoutactiveconnection"></a>
# **LogOutActiveConnection**
> BooleanWrapper LogOutActiveConnection (int loginEventId)

Closes one active connection: the sign-in behind `loginEventId` is marked inactive, the token and cookie tied  to it stop working, the client holding it is disconnected and a logout entry is written to the portal audit  trail. Take `loginEventId` from the `id` of an item of `GET api/2.0/security/activeconnections`, which also  reports in `loginEvent` which connection the caller is using, so a client can avoid closing its own. A user  may close their own connections, while closing somebody else's requires a DocSpace administrator and any other  caller is refused with 403. The call is mutating, destructive for that one session and idempotent, and it  leaves every other connection of the user alone - `PUT api/2.0/security/activeconnections/logoutallexceptthis`  is the way to close the rest in one go. Only `true` means the connection was open and has just been closed;  `false` comes back when this portal has no such active connection, including one that was already closed, and  after any other failure.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/log-out-active-connection/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **loginEventId** | **int** | The sign-in to act on, by login event ID. Take it from the `id` of an item of  `GET api/2.0/security/activeconnections`, which also marks the connection the caller is using, so a client  can avoid picking its own. |  |

### Return type

[**BooleanWrapper**](BooleanWrapper.md)

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
    public class LogOutActiveConnectionExample
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
            var apiInstance = new ActiveConnectionsApi(httpClient, config, httpClientHandler);
            var loginEventId = 12345;  // int | The sign-in to act on, by login event ID. Take it from the `id` of an item of  `GET api/2.0/security/activeconnections`, which also marks the connection the caller is using, so a client  can avoid picking its own.

            try
            {
                // Log out one connection
                BooleanWrapper result = apiInstance.LogOutActiveConnection(loginEventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActiveConnectionsApi.LogOutActiveConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogOutActiveConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out one connection
    ApiResponse<BooleanWrapper> response = apiInstance.LogOutActiveConnectionWithHttpInfo(loginEventId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActiveConnectionsApi.LogOutActiveConnectionWithHttpInfo: " + e.Message);
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
| **200** | `true` when the connection was open and has been closed, `false` when this portal has no such active connection or the attempt failed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is not a DocSpace administrator and the connection belongs to another user |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logoutallactiveconnectionschangepassword"></a>
# **LogOutAllActiveConnectionsChangePassword**
> StringWrapper LogOutAllActiveConnectionsChangePassword ()

Closes every active connection of the calling user and returns the link that user has to open to set a new  password - the answer to a suspicious sign-in seen in `GET api/2.0/security/activeconnections`. Any signed-in  user may call it for their own account and nothing has to be called first; the same clean-up for somebody else  is `PUT api/2.0/security/activeconnections/logoutall/{userId}`. The call is mutating and destructive for  sessions - every token and cookie issued to the user before it stops working and the clients holding them are  disconnected - and it is not idempotent: the request is written to the portal audit trail, which invalidates  the link any earlier call returned, and the caller's own client is handed a fresh cookie in the response and  stays signed in through a new connection. The password itself is not changed here, and the link is handed back  to the caller rather than mailed to the user: the URL carries a time-limited `PasswordChange` key, which the  confirmation page it opens - or `PUT api/2.0/people/{userid}/password` - needs to accept the new password. A  failure is swallowed instead of reported, so an empty body with status 200 means nothing was done and the call  has to be repeated.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/log-out-all-active-connections-change-password/).

### Parameters
This endpoint does not need any parameter.
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
    public class LogOutAllActiveConnectionsChangePasswordExample
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
            var apiInstance = new ActiveConnectionsApi(httpClient, config, httpClientHandler);

            try
            {
                // Log out and reset password
                StringWrapper result = apiInstance.LogOutAllActiveConnectionsChangePassword();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActiveConnectionsApi.LogOutAllActiveConnectionsChangePassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogOutAllActiveConnectionsChangePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out and reset password
    ApiResponse<StringWrapper> response = apiInstance.LogOutAllActiveConnectionsChangePasswordWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActiveConnectionsApi.LogOutAllActiveConnectionsChangePasswordWithHttpInfo: " + e.Message);
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
| **200** | The URL the user has to open to set a new password, or an empty result when the operation failed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logoutallactiveconnectionsforuser"></a>
# **LogOutAllActiveConnectionsForUser**
> void LogOutAllActiveConnectionsForUser (Guid userId)

Closes every active connection of one portal user: the connections are marked inactive, every token and cookie  issued to that user before the call stops working, the clients holding them are disconnected and a logout  entry is written to the portal audit trail. Nothing has to be called first; `userId` is the portal user ID  that `GET api/2.0/people` returns. A user may pass their own ID, while ending somebody else's connections  requires a DocSpace administrator and any other caller is refused with 403. The call is mutating, destructive  for those sessions and idempotent - a user with nothing open is not an error - and it returns no content, so  the state afterwards is read from `GET api/2.0/security/activeconnections`. A caller who ends their own  connections is handed a fresh cookie in the response and stays signed in through a new connection. Nothing  else about the user changes: the account stays enabled and the password stays valid, and to keep the current  connection alive instead use `PUT api/2.0/security/activeconnections/logoutallexceptthis`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/log-out-all-active-connections-for-user/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. Acting on an account  other than the caller's own generally needs administrator rights. |  |

### Return type

void (empty response body)

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
    public class LogOutAllActiveConnectionsForUserExample
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
            var apiInstance = new ActiveConnectionsApi(httpClient, config, httpClientHandler);
            var userId = 00000000-0000-0000-0000-000000000000;  // Guid | The portal account the operation acts on, by user ID as `GET api/2.0/people` reports it. Acting on an account  other than the caller's own generally needs administrator rights.

            try
            {
                // Log out a user everywhere
                apiInstance.LogOutAllActiveConnectionsForUser(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActiveConnectionsApi.LogOutAllActiveConnectionsForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogOutAllActiveConnectionsForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out a user everywhere
    apiInstance.LogOutAllActiveConnectionsForUserWithHttpInfo(userId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActiveConnectionsApi.LogOutAllActiveConnectionsForUserWithHttpInfo: " + e.Message);
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
| **200** | The connections of that user have been closed; the response carries no content |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is not a DocSpace administrator and the ID in the path is not their own |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logoutallexceptthisconnection"></a>
# **LogOutAllExceptThisConnection**
> StringWrapper LogOutAllExceptThisConnection ()

Closes every active connection of the calling user except the one this request was made with, so the current  client keeps working while every other browser and device is signed out. Any signed-in user may call it for  their own account and nothing has to be called first. The connection to keep is the one behind the portal  authentication cookie: a request authenticated with a token in the `Authorization` header has none, and then  every connection of the user is closed, including the one that token belongs to - read `loginEvent` from  `GET api/2.0/security/activeconnections` first to see which connection, if any, will survive. The call is  mutating and destructive for the other sessions, and idempotent: the tokens behind them stop working, their  clients are disconnected at once and a logout entry is written to the portal audit trail. It answers with the  display name of the calling user, while an empty answer with status 200 means the attempt failed and nothing  can be assumed about what was closed.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/log-out-all-except-this-connection/).

### Parameters
This endpoint does not need any parameter.
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
    public class LogOutAllExceptThisConnectionExample
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
            var apiInstance = new ActiveConnectionsApi(httpClient, config, httpClientHandler);

            try
            {
                // Log out other connections
                StringWrapper result = apiInstance.LogOutAllExceptThisConnection();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActiveConnectionsApi.LogOutAllExceptThisConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogOutAllExceptThisConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Log out other connections
    ApiResponse<StringWrapper> response = apiInstance.LogOutAllExceptThisConnectionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActiveConnectionsApi.LogOutAllExceptThisConnectionWithHttpInfo: " + e.Message);
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
| **200** | The display name of the calling user, or an empty result when the operation failed |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

