# Docspace.Api.PeopleContactsApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteMemberContacts**](PeopleContactsApi.md#deletemembercontacts) | **DELETE** /api/2.0/people/{userid}/contacts | Delete user contacts |
| [**SetMemberContacts**](PeopleContactsApi.md#setmembercontacts) | **POST** /api/2.0/people/{userid}/contacts | Set user contacts |
| [**UpdateMemberContacts**](PeopleContactsApi.md#updatemembercontacts) | **PUT** /api/2.0/people/{userid}/contacts | Update user contacts |

<a id="deletemembercontacts"></a>
# **DeleteMemberContacts**
> EmployeeFullWrapper DeleteMemberContacts (string userid, ContactsRequest? contactsRequest = null)

Delete user contacts

Deletes the contacts of the user with the ID specified in the request from the portal.

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
    public class DeleteMemberContactsExample
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
            var apiInstance = new PeopleContactsApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID
            var contactsRequest = new ContactsRequest?(); // ContactsRequest? | Contacts (optional) 

            try
            {
                // Delete user contacts
                EmployeeFullWrapper result = apiInstance.DeleteMemberContacts(userid, contactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleContactsApi.DeleteMemberContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMemberContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete user contacts
    ApiResponse<EmployeeFullWrapper> response = apiInstance.DeleteMemberContactsWithHttpInfo(userid, contactsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleContactsApi.DeleteMemberContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |
| **contactsRequest** | [**ContactsRequest?**](ContactsRequest?.md) | Contacts | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted user profile with the detailed information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setmembercontacts"></a>
# **SetMemberContacts**
> EmployeeFullWrapper SetMemberContacts (string userid, ContactsRequest? contactsRequest = null)

Set user contacts

Sets the contacts of the user with the ID specified in the request replacing the current portal data with the new data.

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
    public class SetMemberContactsExample
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
            var apiInstance = new PeopleContactsApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID
            var contactsRequest = new ContactsRequest?(); // ContactsRequest? | Contacts (optional) 

            try
            {
                // Set user contacts
                EmployeeFullWrapper result = apiInstance.SetMemberContacts(userid, contactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleContactsApi.SetMemberContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMemberContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set user contacts
    ApiResponse<EmployeeFullWrapper> response = apiInstance.SetMemberContactsWithHttpInfo(userid, contactsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleContactsApi.SetMemberContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |
| **contactsRequest** | [**ContactsRequest?**](ContactsRequest?.md) | Contacts | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated user profile with the detailed information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemembercontacts"></a>
# **UpdateMemberContacts**
> EmployeeFullWrapper UpdateMemberContacts (string userid, ContactsRequest? contactsRequest = null)

Update user contacts

Updates the contact information of the user with the ID specified in the request merging the new data into the current portal data.

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
    public class UpdateMemberContactsExample
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
            var apiInstance = new PeopleContactsApi(httpClient, config, httpClientHandler);
            var userid = 9846;  // string | User ID
            var contactsRequest = new ContactsRequest?(); // ContactsRequest? | Contacts (optional) 

            try
            {
                // Update user contacts
                EmployeeFullWrapper result = apiInstance.UpdateMemberContacts(userid, contactsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleContactsApi.UpdateMemberContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMemberContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update user contacts
    ApiResponse<EmployeeFullWrapper> response = apiInstance.UpdateMemberContactsWithHttpInfo(userid, contactsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleContactsApi.UpdateMemberContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | User ID |  |
| **contactsRequest** | [**ContactsRequest?**](ContactsRequest?.md) | Contacts | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated user profile with the detailed information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

