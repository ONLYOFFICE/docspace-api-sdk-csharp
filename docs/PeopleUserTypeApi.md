# Docspace.Api.PeopleUserTypeApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateUserType**](PeopleUserTypeApi.md#updateusertype) | **PUT** /api/2.0/people/type/{type} | Change a user type |

<a id="updateusertype"></a>
# **UpdateUserType**
> EmployeeFullArrayWrapper UpdateUserType (EmployeeType type, UpdateMembersRequestDto? updateMembersRequestDto = null)

Change a user type

Changes a type for the users with the IDs specified in the request.

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
    public class UpdateUserTypeExample
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
            var apiInstance = new PeopleUserTypeApi(httpClient, config, httpClientHandler);
            var type = (EmployeeType) "0";  // EmployeeType | New user type
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? | Update members (optional) 

            try
            {
                // Change a user type
                EmployeeFullArrayWrapper result = apiInstance.UpdateUserType(type, updateMembersRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleUserTypeApi.UpdateUserType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change a user type
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.UpdateUserTypeWithHttpInfo(type, updateMembersRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleUserTypeApi.UpdateUserTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **EmployeeType** | New user type |  |
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

