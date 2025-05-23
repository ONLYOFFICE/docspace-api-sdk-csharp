# Docspace.Api.SecurityLoginHistoryApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLoginHistoryReport**](SecurityLoginHistoryApi.md#createloginhistoryreport) | **POST** /api/2.0/security/audit/login/report | Generate the login history report |
| [**GetLastLoginEvents**](SecurityLoginHistoryApi.md#getlastloginevents) | **GET** /api/2.0/security/audit/login/last | Get login history |
| [**GetLoginEventsByFilter**](SecurityLoginHistoryApi.md#getlogineventsbyfilter) | **GET** /api/2.0/security/audit/login/filter | Get filtered login events |

<a id="createloginhistoryreport"></a>
# **CreateLoginHistoryReport**
> StringWrapper CreateLoginHistoryReport ()

Generate the login history report

Generates the login history report.

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
    public class CreateLoginHistoryReportExample
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
            var apiInstance = new SecurityLoginHistoryApi(httpClient, config, httpClientHandler);

            try
            {
                // Generate the login history report
                StringWrapper result = apiInstance.CreateLoginHistoryReport();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityLoginHistoryApi.CreateLoginHistoryReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLoginHistoryReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate the login history report
    ApiResponse<StringWrapper> response = apiInstance.CreateLoginHistoryReportWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityLoginHistoryApi.CreateLoginHistoryReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**StringWrapper**](StringWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | URL to the xlsx report file |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlastloginevents"></a>
# **GetLastLoginEvents**
> LoginEventArrayWrapper GetLastLoginEvents ()

Get login history

Returns all the latest user login activity, including successful logins and error logs.

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
    public class GetLastLoginEventsExample
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
            var apiInstance = new SecurityLoginHistoryApi(httpClient, config, httpClientHandler);

            try
            {
                // Get login history
                LoginEventArrayWrapper result = apiInstance.GetLastLoginEvents();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityLoginHistoryApi.GetLastLoginEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLastLoginEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get login history
    ApiResponse<LoginEventArrayWrapper> response = apiInstance.GetLastLoginEventsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityLoginHistoryApi.GetLastLoginEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LoginEventArrayWrapper**](LoginEventArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of login events |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlogineventsbyfilter"></a>
# **GetLoginEventsByFilter**
> LoginEventArrayWrapper GetLoginEventsByFilter (Guid? userId = null, MessageAction? action = null, ApiDateTime? from = null, ApiDateTime? to = null)

Get filtered login events

Returns a list of the login events by the parameters specified in the request.

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
    public class GetLoginEventsByFilterExample
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
            var apiInstance = new SecurityLoginHistoryApi(httpClient, config, httpClientHandler);
            var userId = aae1e103-bca5-9fa1-ba8c-42058b4abf28;  // Guid? | The ID of the user whose login events are being queried. (optional) 
            var action = new MessageAction?(); // MessageAction? | The login-related action to filter events by. (optional) 
            var from = new ApiDateTime?(); // ApiDateTime? | The starting date and time for filtering login events. (optional) 
            var to = new ApiDateTime?(); // ApiDateTime? | The ending date and time for filtering login events. (optional) 

            try
            {
                // Get filtered login events
                LoginEventArrayWrapper result = apiInstance.GetLoginEventsByFilter(userId, action, from, to);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityLoginHistoryApi.GetLoginEventsByFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLoginEventsByFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get filtered login events
    ApiResponse<LoginEventArrayWrapper> response = apiInstance.GetLoginEventsByFilterWithHttpInfo(userId, action, from, to);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityLoginHistoryApi.GetLoginEventsByFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid?** | The ID of the user whose login events are being queried. | [optional]  |
| **action** | [**MessageAction?**](MessageAction?.md) | The login-related action to filter events by. | [optional]  |
| **from** | [**ApiDateTime?**](ApiDateTime?.md) | The starting date and time for filtering login events. | [optional]  |
| **to** | [**ApiDateTime?**](ApiDateTime?.md) | The ending date and time for filtering login events. | [optional]  |

### Return type

[**LoginEventArrayWrapper**](LoginEventArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of filtered login events |  -  |
| **401** | Unauthorized |  -  |
| **402** | Your pricing plan does not support this option |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

