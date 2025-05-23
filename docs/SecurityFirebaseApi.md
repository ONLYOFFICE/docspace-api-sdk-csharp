# Docspace.Api.SecurityFirebaseApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DocRegisterPusnNotificationDevice**](SecurityFirebaseApi.md#docregisterpusnnotificationdevice) | **POST** /api/2.0/settings/push/docregisterdevice | Save the Documents Firebase device token |
| [**SubscribeDocumentsPushNotification**](SecurityFirebaseApi.md#subscribedocumentspushnotification) | **PUT** /api/2.0/settings/push/docsubscribe | Subscribe to Documents push notification |

<a id="docregisterpusnnotificationdevice"></a>
# **DocRegisterPusnNotificationDevice**
> FireBaseUserWrapper DocRegisterPusnNotificationDevice (FirebaseRequestsDto? firebaseRequestsDto = null)

Save the Documents Firebase device token

Saves the Firebase device token specified in the request for the Documents application.

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
    public class DocRegisterPusnNotificationDeviceExample
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
            var apiInstance = new SecurityFirebaseApi(httpClient, config, httpClientHandler);
            var firebaseRequestsDto = new FirebaseRequestsDto?(); // FirebaseRequestsDto? |  (optional) 

            try
            {
                // Save the Documents Firebase device token
                FireBaseUserWrapper result = apiInstance.DocRegisterPusnNotificationDevice(firebaseRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityFirebaseApi.DocRegisterPusnNotificationDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DocRegisterPusnNotificationDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Save the Documents Firebase device token
    ApiResponse<FireBaseUserWrapper> response = apiInstance.DocRegisterPusnNotificationDeviceWithHttpInfo(firebaseRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityFirebaseApi.DocRegisterPusnNotificationDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firebaseRequestsDto** | [**FirebaseRequestsDto?**](FirebaseRequestsDto?.md) |  | [optional]  |

### Return type

[**FireBaseUserWrapper**](FireBaseUserWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | FireBase user |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="subscribedocumentspushnotification"></a>
# **SubscribeDocumentsPushNotification**
> FireBaseUserWrapper SubscribeDocumentsPushNotification (FirebaseRequestsDto? firebaseRequestsDto = null)

Subscribe to Documents push notification

Subscribes to the Documents push notification.

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
    public class SubscribeDocumentsPushNotificationExample
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
            var apiInstance = new SecurityFirebaseApi(httpClient, config, httpClientHandler);
            var firebaseRequestsDto = new FirebaseRequestsDto?(); // FirebaseRequestsDto? |  (optional) 

            try
            {
                // Subscribe to Documents push notification
                FireBaseUserWrapper result = apiInstance.SubscribeDocumentsPushNotification(firebaseRequestsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityFirebaseApi.SubscribeDocumentsPushNotification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscribeDocumentsPushNotificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe to Documents push notification
    ApiResponse<FireBaseUserWrapper> response = apiInstance.SubscribeDocumentsPushNotificationWithHttpInfo(firebaseRequestsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityFirebaseApi.SubscribeDocumentsPushNotificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **firebaseRequestsDto** | [**FirebaseRequestsDto?**](FirebaseRequestsDto?.md) |  | [optional]  |

### Return type

[**FireBaseUserWrapper**](FireBaseUserWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | FireBase user |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

