# Docspace.Api.PeopleUserStatusApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetByStatus**](PeopleUserStatusApi.md#getbystatus) | **GET** /api/2.0/people/status/{status} | Get profiles by status |
| [**UpdateEmployeeActivationStatus**](PeopleUserStatusApi.md#updateemployeeactivationstatus) | **PUT** /api/2.0/people/activationstatus/{activationstatus} | Set an activation status to the users |
| [**UpdateUserStatus**](PeopleUserStatusApi.md#updateuserstatus) | **PUT** /api/2.0/people/status/{status} | Change a user status |

<a id="getbystatus"></a>
# **GetByStatus**
> EmployeeFullArrayWrapper GetByStatus (EmployeeStatus status)

Get profiles by status

Returns a list of profiles filtered by user status.

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
    public class GetByStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleUserStatusApi(httpClient, config, httpClientHandler);
            var status = (EmployeeStatus) "1";  // EmployeeStatus | User status

            try
            {
                // Get profiles by status
                EmployeeFullArrayWrapper result = apiInstance.GetByStatus(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleUserStatusApi.GetByStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get profiles by status
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetByStatusWithHttpInfo(status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleUserStatusApi.GetByStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **EmployeeStatus** | User status |  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users with the detailed information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateemployeeactivationstatus"></a>
# **UpdateEmployeeActivationStatus**
> EmployeeFullArrayWrapper UpdateEmployeeActivationStatus (EmployeeActivationStatus activationstatus, UpdateMembersRequestDto? updateMembersRequestDto = null)

Set an activation status to the users

Sets the required activation status to the list of users with the IDs specified in the request.

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
    public class UpdateEmployeeActivationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleUserStatusApi(httpClient, config, httpClientHandler);
            var activationstatus = (EmployeeActivationStatus) "0";  // EmployeeActivationStatus | Activation status
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? | Update members (optional) 

            try
            {
                // Set an activation status to the users
                EmployeeFullArrayWrapper result = apiInstance.UpdateEmployeeActivationStatus(activationstatus, updateMembersRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleUserStatusApi.UpdateEmployeeActivationStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEmployeeActivationStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set an activation status to the users
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.UpdateEmployeeActivationStatusWithHttpInfo(activationstatus, updateMembersRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleUserStatusApi.UpdateEmployeeActivationStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activationstatus** | **EmployeeActivationStatus** | Activation status |  |
| **updateMembersRequestDto** | [**UpdateMembersRequestDto?**](UpdateMembersRequestDto?.md) | Update members | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users with the detailed information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuserstatus"></a>
# **UpdateUserStatus**
> EmployeeFullArrayWrapper UpdateUserStatus (EmployeeStatus status, UpdateMembersRequestDto? updateMembersRequestDto = null)

Change a user status

Changes a status for the users with the IDs specified in the request.

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
    public class UpdateUserStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8092";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PeopleUserStatusApi(httpClient, config, httpClientHandler);
            var status = (EmployeeStatus) "1";  // EmployeeStatus | New user status
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? | Update members (optional) 

            try
            {
                // Change a user status
                EmployeeFullArrayWrapper result = apiInstance.UpdateUserStatus(status, updateMembersRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleUserStatusApi.UpdateUserStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change a user status
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.UpdateUserStatusWithHttpInfo(status, updateMembersRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleUserStatusApi.UpdateUserStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **EmployeeStatus** | New user status |  |
| **updateMembersRequestDto** | [**UpdateMembersRequestDto?**](UpdateMembersRequestDto?.md) | Update members | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users with the detailed information |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

