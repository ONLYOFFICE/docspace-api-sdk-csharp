# Docspace.Api.PeopleSearchApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountsEntriesWithShared**](PeopleSearchApi.md#getaccountsentrieswithshared) | **GET** /api/2.0/accounts/room/{id}/search | Get account entries |
| [**GetSearch**](PeopleSearchApi.md#getsearch) | **GET** /api/2.0/people/@search/{query} | Search users |
| [**GetSimpleByFilter**](PeopleSearchApi.md#getsimplebyfilter) | **GET** /api/2.0/people/simple/filter | Search users by extended filter |
| [**GetUsersWithRoomShared**](PeopleSearchApi.md#getuserswithroomshared) | **GET** /api/2.0/people/room/{id} | Get users with room sharing settings |
| [**SearchUsersByExtendedFilter**](PeopleSearchApi.md#searchusersbyextendedfilter) | **GET** /api/2.0/people/filter | Search users with detaailed information by extended filter |
| [**SearchUsersByQuery**](PeopleSearchApi.md#searchusersbyquery) | **GET** /api/2.0/people/search | Search users (using query parameters) |
| [**SearchUsersByStatus**](PeopleSearchApi.md#searchusersbystatus) | **GET** /api/2.0/people/status/{status}/search | Search users by status filter |

<a id="getaccountsentrieswithshared"></a>
# **GetAccountsEntriesWithShared**
> ObjectArrayWrapper GetAccountsEntriesWithShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null)

Get account entries

Returns the account entries with their sharing settings.

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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the account sharing settings from the response. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the account sharing settings in the response. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user is invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The area of the account entries. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of the user types. (optional) 

            try
            {
                // Get account entries
                ObjectArrayWrapper result = apiInstance.GetAccountsEntriesWithShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes);
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
    // Get account entries
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetAccountsEntriesWithSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes);
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
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the account sharing settings from the response. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the account sharing settings in the response. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area?.md) | The area of the account entries. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of the user types. | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var query = some text;  // string | The search query.

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
| **query** | **string** | The search query. |  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
> EmployeeArrayWrapper GetSimpleByFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<int>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null)

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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var groupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The group ID. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var employeeType = new EmployeeType?(); // EmployeeType? | The user type. (optional) 
            var employeeTypes = new List<int>?(); // List<int>? | The list of user types. (optional) 
            var isAdministrator = true;  // bool? | Specifies if the user is an administrator or not. (optional) 
            var payments = new Payments?(); // Payments? | The user payment status. (optional) 
            var accountLoginType = new AccountLoginType?(); // AccountLoginType? | The account login type. (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | The quota filter (All - 0, Default - 1, Custom - 2). (optional) 
            var withoutGroup = true;  // bool? | Specifies whether the user should be a member of a group or not. (optional) 
            var excludeGroup = true;  // bool? | Specifies whether the user should be a member of the group with the specified ID. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user is invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The filter area. (optional) 

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
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | The user status. | [optional]  |
| **groupId** | **Guid?** | The group ID. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | The user activation status. | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType?.md) | The user type. | [optional]  |
| **employeeTypes** | [**List&lt;int&gt;?**](int.md) | The list of user types. | [optional]  |
| **isAdministrator** | **bool?** | Specifies if the user is an administrator or not. | [optional]  |
| **payments** | [**Payments?**](Payments?.md) | The user payment status. | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType?.md) | The account login type. | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter?.md) | The quota filter (All - 0, Default - 1, Custom - 2). | [optional]  |
| **withoutGroup** | **bool?** | Specifies whether the user should be a member of a group or not. | [optional]  |
| **excludeGroup** | **bool?** | Specifies whether the user should be a member of the group with the specified ID. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area?.md) | The filter area. | [optional]  |

### Return type

[**EmployeeArrayWrapper**](EmployeeArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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
> EmployeeFullArrayWrapper GetUsersWithRoomShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null)

Get users with room sharing settings

Returns the users with the sharing settings in a room with the ID specified in request.

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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the user sharing settings or not. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the user sharing settings or not. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user was invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The user area. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of user types. (optional) 

            try
            {
                // Get users with room sharing settings
                EmployeeFullArrayWrapper result = apiInstance.GetUsersWithRoomShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes);
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
    // Get users with room sharing settings
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetUsersWithRoomSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes);
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
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the user sharing settings or not. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the user sharing settings or not. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user was invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area?.md) | The user area. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of user types. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

<a id="searchusersbyextendedfilter"></a>
# **SearchUsersByExtendedFilter**
> EmployeeFullArrayWrapper SearchUsersByExtendedFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<int>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null)

Search users with detaailed information by extended filter

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
    public class SearchUsersByExtendedFilterExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var groupId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The group ID. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var employeeType = new EmployeeType?(); // EmployeeType? | The user type. (optional) 
            var employeeTypes = new List<int>?(); // List<int>? | The list of user types. (optional) 
            var isAdministrator = true;  // bool? | Specifies if the user is an administrator or not. (optional) 
            var payments = new Payments?(); // Payments? | The user payment status. (optional) 
            var accountLoginType = new AccountLoginType?(); // AccountLoginType? | The account login type. (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | The quota filter (All - 0, Default - 1, Custom - 2). (optional) 
            var withoutGroup = true;  // bool? | Specifies whether the user should be a member of a group or not. (optional) 
            var excludeGroup = true;  // bool? | Specifies whether the user should be a member of the group with the specified ID. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user is invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The filter area. (optional) 

            try
            {
                // Search users with detaailed information by extended filter
                EmployeeFullArrayWrapper result = apiInstance.SearchUsersByExtendedFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.SearchUsersByExtendedFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchUsersByExtendedFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users with detaailed information by extended filter
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.SearchUsersByExtendedFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.SearchUsersByExtendedFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus?.md) | The user status. | [optional]  |
| **groupId** | **Guid?** | The group ID. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus?.md) | The user activation status. | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType?.md) | The user type. | [optional]  |
| **employeeTypes** | [**List&lt;int&gt;?**](int.md) | The list of user types. | [optional]  |
| **isAdministrator** | **bool?** | Specifies if the user is an administrator or not. | [optional]  |
| **payments** | [**Payments?**](Payments?.md) | The user payment status. | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType?.md) | The account login type. | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter?.md) | The quota filter (All - 0, Default - 1, Custom - 2). | [optional]  |
| **withoutGroup** | **bool?** | Specifies whether the user should be a member of a group or not. | [optional]  |
| **excludeGroup** | **bool?** | Specifies whether the user should be a member of the group with the specified ID. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area?.md) | The filter area. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

<a id="searchusersbyquery"></a>
# **SearchUsersByQuery**
> EmployeeArrayWrapper SearchUsersByQuery (string? query = null)

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
    public class SearchUsersByQueryExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var query = some text;  // string? | The search query. (optional) 

            try
            {
                // Search users (using query parameters)
                EmployeeArrayWrapper result = apiInstance.SearchUsersByQuery(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.SearchUsersByQuery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchUsersByQueryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users (using query parameters)
    ApiResponse<EmployeeArrayWrapper> response = apiInstance.SearchUsersByQueryWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.SearchUsersByQueryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string?** | The search query. | [optional]  |

### Return type

[**EmployeeArrayWrapper**](EmployeeArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of users |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbystatus"></a>
# **SearchUsersByStatus**
> EmployeeFullArrayWrapper SearchUsersByStatus (EmployeeStatus status, string? query = null)

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
    public class SearchUsersByStatusExample
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
            var apiInstance = new PeopleSearchApi(httpClient, config, httpClientHandler);
            var status = (EmployeeStatus) "1";  // EmployeeStatus | The user status.
            var query = some text;  // string? | The advanced search query. (optional) 

            try
            {
                // Search users by status filter
                EmployeeFullArrayWrapper result = apiInstance.SearchUsersByStatus(status, query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleSearchApi.SearchUsersByStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchUsersByStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search users by status filter
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.SearchUsersByStatusWithHttpInfo(status, query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleSearchApi.SearchUsersByStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **EmployeeStatus** | The user status. |  |
| **query** | **string?** | The advanced search query. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

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

