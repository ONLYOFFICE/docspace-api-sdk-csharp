# Docspace.Api.PeopleSearchApi

All URIs are relative to *http://localhost:8092*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountsEntriesWithShared**](PeopleSearchApi.md#getaccountsentrieswithshared) | **GET** /api/2.0/accounts/room/{id}/search | Gets accounts entries with shared |
| [**GetAdvanced**](PeopleSearchApi.md#getadvanced) | **GET** /api/2.0/people/status/{status}/search | Search users by status filter |
| [**GetFullByFilter**](PeopleSearchApi.md#getfullbyfilter) | **GET** /api/2.0/people/filter | Search users and their information by extended filter |
| [**GetPeopleSearch**](PeopleSearchApi.md#getpeoplesearch) | **GET** /api/2.0/people/search | Search users (using query parameters) |
| [**GetSearch**](PeopleSearchApi.md#getsearch) | **GET** /api/2.0/people/@search/{query} | Search users |
| [**GetSimpleByFilter**](PeopleSearchApi.md#getsimplebyfilter) | **GET** /api/2.0/people/simple/filter | Search users by extended filter |
| [**GetUsersWithRoomShared**](PeopleSearchApi.md#getuserswithroomshared) | **GET** /api/2.0/people/room/{id} | Gets users with shared in room ID specified in request |

<a id="getaccountsentrieswithshared"></a>
# **GetAccountsEntriesWithShared**
> ObjectArrayWrapper GetAccountsEntriesWithShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null)

Gets accounts entries with shared

Gets accounts entries with shared

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
    public class GetAccountsEntriesWithSharedExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | ID
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Employee status (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Activation status (optional) 
            var excludeShared = true;  // bool? | Exclude shared (optional) 
            var invitedByMe = true;  // bool? | Invited by me (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Inviter Id (optional) 
            var area = new Area?(); // Area? | Area (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Employee Types (optional) 

            try
            {
                // Gets accounts entries with shared
                ObjectArrayWrapper result = apiInstance.GetAccountsEntriesWithShared(id, employeeStatus, activationStatus, excludeShared, invitedByMe, inviterId, area, employeeTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetAccountsEntriesWithShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsEntriesWithSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets accounts entries with shared
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetAccountsEntriesWithSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, invitedByMe, inviterId, area, employeeTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetAccountsEntriesWithSharedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | Employee status | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | Activation status | [optional]  |
| **excludeShared** | **bool?** | Exclude shared | [optional]  |
| **invitedByMe** | **bool?** | Invited by me | [optional]  |
| **inviterId** | **Guid?** | Inviter Id | [optional]  |
| **area** | [**Area?**](Area?.md) | Area | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Employee Types | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getadvanced"></a>
# **GetAdvanced**
> EmployeeFullArrayWrapper GetAdvanced (EmployeeStatus status, string? query = null)

Search users by status filter

Returns a list of users matching the status filter and search query.

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
    public class GetAdvancedExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var status = (EmployeeStatus) "1";  // EmployeeStatus | User status
            var query = some text;  // string? | Search query (optional) 

            try
            {
                // Search users by status filter
                EmployeeFullArrayWrapper result = apiInstance.GetAdvanced(status, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetAdvanced: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAdvancedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users by status filter
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetAdvancedWithHttpInfo(status, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetAdvancedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **EmployeeStatus** | User status |  |
| **query** | **string?** | Search query | [optional]  |

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
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfullbyfilter"></a>
# **GetFullByFilter**
> EmployeeFullArrayWrapper GetFullByFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<EmployeeType>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null)

Search users and their information by extended filter

Returns a list of users with full information about them matching the parameters specified in the request.

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
    public class GetFullByFilterExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | User status (optional) 
            var groupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Group ID (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Activation status (optional) 
            var employeeType = new EmployeeType?(); // EmployeeType? | User type (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | List of user types (optional) 
            var isAdministrator = true;  // bool? | Specifies if the user is an administrator or not (optional) 
            var payments = new Payments?(); // Payments? | User payment status (optional) 
            var accountLoginType = new AccountLoginType?(); // AccountLoginType? | Account login type (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | Filter by quota (All - 0, Default - 1, Custom - 2) (optional) 
            var withoutGroup = true;  // bool? | Specifies whether the user should be a member of a group or not (optional) 
            var excludeGroup = true;  // bool? | Specifies whether or not the user should be a member of the group with the specified ID (optional) 
            var invitedByMe = true;  // bool? | Invited by me (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Inviter Id (optional) 
            var area = new Area?(); // Area? | Area (optional) 

            try
            {
                // Search users and their information by extended filter
                EmployeeFullArrayWrapper result = apiInstance.GetFullByFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetFullByFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFullByFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users and their information by extended filter
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetFullByFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetFullByFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | User status | [optional]  |
| **groupId** | **Guid?** | Group ID | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | Activation status | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType?.md) | User type | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | List of user types | [optional]  |
| **isAdministrator** | **bool?** | Specifies if the user is an administrator or not | [optional]  |
| **payments** | [**Payments?**](Payments?.md) | User payment status | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType?.md) | Account login type | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter?.md) | Filter by quota (All - 0, Default - 1, Custom - 2) | [optional]  |
| **withoutGroup** | **bool?** | Specifies whether the user should be a member of a group or not | [optional]  |
| **excludeGroup** | **bool?** | Specifies whether or not the user should be a member of the group with the specified ID | [optional]  |
| **invitedByMe** | **bool?** | Invited by me | [optional]  |
| **inviterId** | **Guid?** | Inviter Id | [optional]  |
| **area** | [**Area?**](Area?.md) | Area | [optional]  |

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
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpeoplesearch"></a>
# **GetPeopleSearch**
> EmployeeArrayWrapper GetPeopleSearch (string? query = null)

Search users (using query parameters)

Returns a list of users matching the search query. This method uses the query parameters.

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
    public class GetPeopleSearchExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var query = some text;  // string? | Search query (optional) 

            try
            {
                // Search users (using query parameters)
                EmployeeArrayWrapper result = apiInstance.GetPeopleSearch(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetPeopleSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPeopleSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users (using query parameters)
    ApiResponse<EmployeeArrayWrapper> response = apiInstance.GetPeopleSearchWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetPeopleSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string?** | Search query | [optional]  |

### Return type

[**EmployeeArrayWrapper**](EmployeeArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsearch"></a>
# **GetSearch**
> EmployeeFullArrayWrapper GetSearch (string query)

Search users

Returns a list of users matching the search query.

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
    public class GetSearchExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var query = some text;  // string | Search query

            try
            {
                // Search users
                EmployeeFullArrayWrapper result = apiInstance.GetSearch(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetSearchWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | Search query |  |

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
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsimplebyfilter"></a>
# **GetSimpleByFilter**
> EmployeeArrayWrapper GetSimpleByFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<EmployeeType>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null)

Search users by extended filter

Returns a list of users matching the parameters specified in the request.

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
    public class GetSimpleByFilterExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | User status (optional) 
            var groupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Group ID (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Activation status (optional) 
            var employeeType = new EmployeeType?(); // EmployeeType? | User type (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | List of user types (optional) 
            var isAdministrator = true;  // bool? | Specifies if the user is an administrator or not (optional) 
            var payments = new Payments?(); // Payments? | User payment status (optional) 
            var accountLoginType = new AccountLoginType?(); // AccountLoginType? | Account login type (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | Filter by quota (All - 0, Default - 1, Custom - 2) (optional) 
            var withoutGroup = true;  // bool? | Specifies whether the user should be a member of a group or not (optional) 
            var excludeGroup = true;  // bool? | Specifies whether or not the user should be a member of the group with the specified ID (optional) 
            var invitedByMe = true;  // bool? | Invited by me (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Inviter Id (optional) 
            var area = new Area?(); // Area? | Area (optional) 

            try
            {
                // Search users by extended filter
                EmployeeArrayWrapper result = apiInstance.GetSimpleByFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetSimpleByFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSimpleByFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users by extended filter
    ApiResponse<EmployeeArrayWrapper> response = apiInstance.GetSimpleByFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetSimpleByFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | User status | [optional]  |
| **groupId** | **Guid?** | Group ID | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | Activation status | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType?.md) | User type | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | List of user types | [optional]  |
| **isAdministrator** | **bool?** | Specifies if the user is an administrator or not | [optional]  |
| **payments** | [**Payments?**](Payments?.md) | User payment status | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType?.md) | Account login type | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter?.md) | Filter by quota (All - 0, Default - 1, Custom - 2) | [optional]  |
| **withoutGroup** | **bool?** | Specifies whether the user should be a member of a group or not | [optional]  |
| **excludeGroup** | **bool?** | Specifies whether or not the user should be a member of the group with the specified ID | [optional]  |
| **invitedByMe** | **bool?** | Invited by me | [optional]  |
| **inviterId** | **Guid?** | Inviter Id | [optional]  |
| **area** | [**Area?**](Area?.md) | Area | [optional]  |

### Return type

[**EmployeeArrayWrapper**](EmployeeArrayWrapper.md)

### Authorization

[asc_auth_key](../README.md#asc_auth_key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithroomshared"></a>
# **GetUsersWithRoomShared**
> EmployeeFullArrayWrapper GetUsersWithRoomShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null)

Gets users with shared in room ID specified in request

Gets users with shared in room ID specified in request

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
    public class GetUsersWithRoomSharedExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | Id
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Employee status (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Activation status (optional) 
            var excludeShared = true;  // bool? | Exclude shared (optional) 
            var invitedByMe = true;  // bool? | Invited by me (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | Inviter Id (optional) 
            var area = new Area?(); // Area? | Area (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Employee Types (optional) 

            try
            {
                // Gets users with shared in room ID specified in request
                EmployeeFullArrayWrapper result = apiInstance.GetUsersWithRoomShared(id, employeeStatus, activationStatus, excludeShared, invitedByMe, inviterId, area, employeeTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.GetUsersWithRoomShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithRoomSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets users with shared in room ID specified in request
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetUsersWithRoomSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, invitedByMe, inviterId, area, employeeTypes);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.GetUsersWithRoomSharedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Id |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | Employee status | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | Activation status | [optional]  |
| **excludeShared** | **bool?** | Exclude shared | [optional]  |
| **invitedByMe** | **bool?** | Invited by me | [optional]  |
| **inviterId** | **Guid?** | Inviter Id | [optional]  |
| **area** | [**Area?**](Area?.md) | Area | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Employee Types | [optional]  |

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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

