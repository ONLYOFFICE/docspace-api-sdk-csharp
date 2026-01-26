# DocSpace.API.SDK.Api.SearchApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountsEntriesWithFilesShared**](#getaccountsentrieswithfilesshared) | **GET** /api/2.0/accounts/file/{id}/search | Get account entries with file sharing settings |
| [**GetAccountsEntriesWithFoldersShared**](#getaccountsentrieswithfoldersshared) | **GET** /api/2.0/accounts/folder/{id}/search | Get account entries with folder sharing settings |
| [**GetAccountsEntriesWithRoomsShared**](#getaccountsentrieswithroomsshared) | **GET** /api/2.0/accounts/room/{id}/search | Get account entries |
| [**GetSearch**](#getsearch) | **GET** /api/2.0/people/@search/{query} | Search users |
| [**GetSimpleByFilter**](#getsimplebyfilter) | **GET** /api/2.0/people/simple/filter | Search users by extended filter |
| [**GetUsersWithFilesShared**](#getuserswithfilesshared) | **GET** /api/2.0/people/file/{id} | Get users with file sharing settings |
| [**GetUsersWithFoldersShared**](#getuserswithfoldersshared) | **GET** /api/2.0/people/folder/{id} | Get users with folder sharing settings |
| [**GetUsersWithRoomShared**](#getuserswithroomshared) | **GET** /api/2.0/people/room/{id} | Get users with room sharing settings |
| [**SearchUsersByExtendedFilter**](#searchusersbyextendedfilter) | **GET** /api/2.0/people/filter | Search users with detailed information by extended filter |
| [**SearchUsersByQuery**](#searchusersbyquery) | **GET** /api/2.0/people/search | Search users (using query parameters) |
| [**SearchUsersByStatus**](#searchusersbystatus) | **GET** /api/2.0/people/status/{status}/search | Search users by status filter |

<a id="getaccountsentrieswithfilesshared"></a>
# **GetAccountsEntriesWithFilesShared**
> ObjectArrayWrapper GetAccountsEntriesWithFilesShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the account entries with their sharing settings for a file with the ID specified in request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the account sharing settings from the response. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the account sharing settings in the response. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The area of the account entries. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of the user types. | [optional]  |
| **count** | **int?** | The number of items to retrieve in a request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |
| **filterSeparator** | **string?** | Specifies the separator used in filter expressions. | [optional]  |
| **filterValue** | **string?** | The text filter applied to the accounts search query. | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

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
    public class GetAccountsEntriesWithFilesSharedExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the account sharing settings from the response. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the account sharing settings in the response. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user is invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The area of the account entries. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of the user types. (optional) 
            var count = 1234;  // int? | The number of items to retrieve in a request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 
            var filterSeparator = some text;  // string? | Specifies the separator used in filter expressions. (optional) 
            var filterValue = some text;  // string? | The text filter applied to the accounts search query. (optional) 

            try
            {
                // Get account entries with file sharing settings
                ObjectArrayWrapper result = apiInstance.GetAccountsEntriesWithFilesShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetAccountsEntriesWithFilesShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsEntriesWithFilesSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account entries with file sharing settings
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetAccountsEntriesWithFilesSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetAccountsEntriesWithFilesSharedWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithfoldersshared"></a>
# **GetAccountsEntriesWithFoldersShared**
> ObjectArrayWrapper GetAccountsEntriesWithFoldersShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the account entries with their sharing settings in a folder with the ID specified in request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the account sharing settings from the response. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the account sharing settings in the response. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The area of the account entries. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of the user types. | [optional]  |
| **count** | **int?** | The number of items to retrieve in a request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |
| **filterSeparator** | **string?** | Specifies the separator used in filter expressions. | [optional]  |
| **filterValue** | **string?** | The text filter applied to the accounts search query. | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

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
    public class GetAccountsEntriesWithFoldersSharedExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the account sharing settings from the response. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the account sharing settings in the response. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user is invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The area of the account entries. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of the user types. (optional) 
            var count = 1234;  // int? | The number of items to retrieve in a request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 
            var filterSeparator = some text;  // string? | Specifies the separator used in filter expressions. (optional) 
            var filterValue = some text;  // string? | The text filter applied to the accounts search query. (optional) 

            try
            {
                // Get account entries with folder sharing settings
                ObjectArrayWrapper result = apiInstance.GetAccountsEntriesWithFoldersShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetAccountsEntriesWithFoldersShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsEntriesWithFoldersSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account entries with folder sharing settings
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetAccountsEntriesWithFoldersSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetAccountsEntriesWithFoldersSharedWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithroomsshared"></a>
# **GetAccountsEntriesWithRoomsShared**
> ObjectArrayWrapper GetAccountsEntriesWithRoomsShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the account entries with their sharing settings in a room with the ID specified in request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the account sharing settings from the response. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the account sharing settings in the response. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The area of the account entries. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of the user types. | [optional]  |
| **count** | **int?** | The number of items to retrieve in a request. | [optional]  |
| **startIndex** | **int?** | The starting index for the query results. | [optional]  |
| **filterSeparator** | **string?** | Specifies the separator used in filter expressions. | [optional]  |
| **filterValue** | **string?** | The text filter applied to the accounts search query. | [optional]  |

### Return type

[**ObjectArrayWrapper**](ObjectArrayWrapper.md)

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
    public class GetAccountsEntriesWithRoomsSharedExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the account sharing settings from the response. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the account sharing settings in the response. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user is invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The area of the account entries. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of the user types. (optional) 
            var count = 1234;  // int? | The number of items to retrieve in a request. (optional) 
            var startIndex = 1234;  // int? | The starting index for the query results. (optional) 
            var filterSeparator = some text;  // string? | Specifies the separator used in filter expressions. (optional) 
            var filterValue = some text;  // string? | The text filter applied to the accounts search query. (optional) 

            try
            {
                // Get account entries
                ObjectArrayWrapper result = apiInstance.GetAccountsEntriesWithRoomsShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetAccountsEntriesWithRoomsShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountsEntriesWithRoomsSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get account entries
    ApiResponse<ObjectArrayWrapper> response = apiInstance.GetAccountsEntriesWithRoomsSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetAccountsEntriesWithRoomsSharedWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsearch"></a>
# **GetSearch**
> EmployeeFullArrayWrapper GetSearch (string query, string? filterBy = null, string? filterValue = null)

Returns a list of users matching the search query.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | The search query. |  |
| **filterBy** | **string?** | Specifies a filter criteria for the user search query. | [optional]  |
| **filterValue** | **string?** | The value used for filtering users, allowing additional constraints for the query. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

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
    public class GetSearchExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var query = some text;  // string | The search query.
            var filterBy = some text;  // string? | Specifies a filter criteria for the user search query. (optional) 
            var filterValue = some text;  // string? | The value used for filtering users, allowing additional constraints for the query. (optional) 

            try
            {
                // Search users
                EmployeeFullArrayWrapper result = apiInstance.GetSearch(query, filterBy, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetSearch: " + e.Message);
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
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetSearchWithHttpInfo(query, filterBy, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetSearchWithHttpInfo: " + e.Message);
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
| **200** | List of users with the detailed information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsimplebyfilter"></a>
# **GetSimpleByFilter**
> EmployeeArrayWrapper GetSimpleByFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<int>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterSeparator = null, string? filterValue = null)

Returns a list of users matching the parameters specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **groupId** | **Guid?** | The group ID. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType.md) | The user type. | [optional]  |
| **employeeTypes** | [**List&lt;int&gt;?**](int.md) | The list of user types. | [optional]  |
| **isAdministrator** | **bool?** | Specifies if the user is an administrator or not. | [optional]  |
| **payments** | [**Payments?**](Payments.md) | The user payment status. | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType.md) | The account login type. | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter.md) | The quota filter (All - 0, Default - 1, Custom - 2). | [optional]  |
| **withoutGroup** | **bool?** | Specifies whether the user should be a member of a group or not. | [optional]  |
| **excludeGroup** | **bool?** | Specifies whether the user should be a member of the group with the specified ID. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The filter area. | [optional]  |
| **count** | **int?** | The maximum number of items to be retrieved in the response. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first item to be retrieved in a filtered result set. | [optional]  |
| **sortBy** | **string?** | Specifies the property or field name by which the results should be sorted. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterSeparator** | **string?** | Represents the separator used to split filter criteria in query parameters. | [optional]  |
| **filterValue** | **string?** | The search text used to filter results based on user input. | [optional]  |

### Return type

[**EmployeeArrayWrapper**](EmployeeArrayWrapper.md)

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
    public class GetSimpleByFilterExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
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
            var count = 1234;  // int? | The maximum number of items to be retrieved in the response. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first item to be retrieved in a filtered result set. (optional) 
            var sortBy = some text;  // string? | Specifies the property or field name by which the results should be sorted. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterSeparator = some text;  // string? | Represents the separator used to split filter criteria in query parameters. (optional) 
            var filterValue = some text;  // string? | The search text used to filter results based on user input. (optional) 

            try
            {
                // Search users by extended filter
                EmployeeArrayWrapper result = apiInstance.GetSimpleByFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetSimpleByFilter: " + e.Message);
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
    ApiResponse<EmployeeArrayWrapper> response = apiInstance.GetSimpleByFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetSimpleByFilterWithHttpInfo: " + e.Message);
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
| **200** | List of users |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithfilesshared"></a>
# **GetUsersWithFilesShared**
> EmployeeFullArrayWrapper GetUsersWithFilesShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the users with the sharing settings in a file with the ID specified in request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the user sharing settings or not. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the user sharing settings or not. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user was invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The user area. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of user types. | [optional]  |
| **count** | **int?** | The maximum number of users to be retrieved in the request. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first record to retrieve in a paged query. | [optional]  |
| **filterSeparator** | **string?** | The character or string used to separate multiple filter values in a filtering query. | [optional]  |
| **filterValue** | **string?** | The filter text value used for searching or filtering user results. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

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
    public class GetUsersWithFilesSharedExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the user sharing settings or not. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the user sharing settings or not. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user was invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The user area. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of user types. (optional) 
            var count = 1234;  // int? | The maximum number of users to be retrieved in the request. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first record to retrieve in a paged query. (optional) 
            var filterSeparator = some text;  // string? | The character or string used to separate multiple filter values in a filtering query. (optional) 
            var filterValue = some text;  // string? | The filter text value used for searching or filtering user results. (optional) 

            try
            {
                // Get users with file sharing settings
                EmployeeFullArrayWrapper result = apiInstance.GetUsersWithFilesShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetUsersWithFilesShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithFilesSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users with file sharing settings
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetUsersWithFilesSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetUsersWithFilesSharedWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithfoldersshared"></a>
# **GetUsersWithFoldersShared**
> EmployeeFullArrayWrapper GetUsersWithFoldersShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the users with the sharing settings in a folder with the ID specified in request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the user sharing settings or not. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the user sharing settings or not. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user was invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The user area. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of user types. | [optional]  |
| **count** | **int?** | The maximum number of users to be retrieved in the request. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first record to retrieve in a paged query. | [optional]  |
| **filterSeparator** | **string?** | The character or string used to separate multiple filter values in a filtering query. | [optional]  |
| **filterValue** | **string?** | The filter text value used for searching or filtering user results. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

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
    public class GetUsersWithFoldersSharedExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the user sharing settings or not. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the user sharing settings or not. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user was invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The user area. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of user types. (optional) 
            var count = 1234;  // int? | The maximum number of users to be retrieved in the request. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first record to retrieve in a paged query. (optional) 
            var filterSeparator = some text;  // string? | The character or string used to separate multiple filter values in a filtering query. (optional) 
            var filterValue = some text;  // string? | The filter text value used for searching or filtering user results. (optional) 

            try
            {
                // Get users with folder sharing settings
                EmployeeFullArrayWrapper result = apiInstance.GetUsersWithFoldersShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetUsersWithFoldersShared: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithFoldersSharedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users with folder sharing settings
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetUsersWithFoldersSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetUsersWithFoldersSharedWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithroomshared"></a>
# **GetUsersWithRoomShared**
> EmployeeFullArrayWrapper GetUsersWithRoomShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the users with the sharing settings in a room with the ID specified in request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The user ID. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **excludeShared** | **bool?** | Specifies whether to exclude the user sharing settings or not. | [optional]  |
| **includeShared** | **bool?** | Specifies whether to include the user sharing settings or not. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user was invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The user area. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | The list of user types. | [optional]  |
| **count** | **int?** | The maximum number of users to be retrieved in the request. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first record to retrieve in a paged query. | [optional]  |
| **filterSeparator** | **string?** | The character or string used to separate multiple filter values in a filtering query. | [optional]  |
| **filterValue** | **string?** | The filter text value used for searching or filtering user results. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

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
    public class GetUsersWithRoomSharedExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var id = 9846;  // int | The user ID.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | The user status. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | The user activation status. (optional) 
            var excludeShared = true;  // bool? | Specifies whether to exclude the user sharing settings or not. (optional) 
            var includeShared = true;  // bool? | Specifies whether to include the user sharing settings or not. (optional) 
            var invitedByMe = true;  // bool? | Specifies whether the user was invited by the current user or not. (optional) 
            var inviterId = 75a5f745-f697-4418-b38d-0fe0d277e258;  // Guid? | The inviter ID. (optional) 
            var area = new Area?(); // Area? | The user area. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | The list of user types. (optional) 
            var count = 1234;  // int? | The maximum number of users to be retrieved in the request. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first record to retrieve in a paged query. (optional) 
            var filterSeparator = some text;  // string? | The character or string used to separate multiple filter values in a filtering query. (optional) 
            var filterValue = some text;  // string? | The filter text value used for searching or filtering user results. (optional) 

            try
            {
                // Get users with room sharing settings
                EmployeeFullArrayWrapper result = apiInstance.GetUsersWithRoomShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.GetUsersWithRoomShared: " + e.Message);
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
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetUsersWithRoomSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.GetUsersWithRoomSharedWithHttpInfo: " + e.Message);
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
| **200** | Ok |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbyextendedfilter"></a>
# **SearchUsersByExtendedFilter**
> EmployeeFullArrayWrapper SearchUsersByExtendedFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<int>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterSeparator = null, string? filterValue = null)

Returns a list of users with full information about them matching the parameters specified in the request.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | The user status. | [optional]  |
| **groupId** | **Guid?** | The group ID. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | The user activation status. | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType.md) | The user type. | [optional]  |
| **employeeTypes** | [**List&lt;int&gt;?**](int.md) | The list of user types. | [optional]  |
| **isAdministrator** | **bool?** | Specifies if the user is an administrator or not. | [optional]  |
| **payments** | [**Payments?**](Payments.md) | The user payment status. | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType.md) | The account login type. | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter.md) | The quota filter (All - 0, Default - 1, Custom - 2). | [optional]  |
| **withoutGroup** | **bool?** | Specifies whether the user should be a member of a group or not. | [optional]  |
| **excludeGroup** | **bool?** | Specifies whether the user should be a member of the group with the specified ID. | [optional]  |
| **invitedByMe** | **bool?** | Specifies whether the user is invited by the current user or not. | [optional]  |
| **inviterId** | **Guid?** | The inviter ID. | [optional]  |
| **area** | [**Area?**](Area.md) | The filter area. | [optional]  |
| **count** | **int?** | The maximum number of items to be retrieved in the response. | [optional]  |
| **startIndex** | **int?** | The zero-based index of the first item to be retrieved in a filtered result set. | [optional]  |
| **sortBy** | **string?** | Specifies the property or field name by which the results should be sorted. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The order in which the results are sorted. | [optional]  |
| **filterSeparator** | **string?** | Represents the separator used to split filter criteria in query parameters. | [optional]  |
| **filterValue** | **string?** | The search text used to filter results based on user input. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

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
    public class SearchUsersByExtendedFilterExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
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
            var count = 1234;  // int? | The maximum number of items to be retrieved in the response. (optional) 
            var startIndex = 1234;  // int? | The zero-based index of the first item to be retrieved in a filtered result set. (optional) 
            var sortBy = some text;  // string? | Specifies the property or field name by which the results should be sorted. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The order in which the results are sorted. (optional) 
            var filterSeparator = some text;  // string? | Represents the separator used to split filter criteria in query parameters. (optional) 
            var filterValue = some text;  // string? | The search text used to filter results based on user input. (optional) 

            try
            {
                // Search users with detailed information by extended filter
                EmployeeFullArrayWrapper result = apiInstance.SearchUsersByExtendedFilter(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUsersByExtendedFilter: " + e.Message);
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
    // Search users with detailed information by extended filter
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.SearchUsersByExtendedFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchUsersByExtendedFilterWithHttpInfo: " + e.Message);
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
| **200** | List of users with the detailed information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbyquery"></a>
# **SearchUsersByQuery**
> EmployeeArrayWrapper SearchUsersByQuery (string? query = null)

Returns a list of users matching the search query. This method uses the query parameters.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string?** | The search query. | [optional]  |

### Return type

[**EmployeeArrayWrapper**](EmployeeArrayWrapper.md)

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
    public class SearchUsersByQueryExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var query = some text;  // string? | The search query. (optional) 

            try
            {
                // Search users (using query parameters)
                EmployeeArrayWrapper result = apiInstance.SearchUsersByQuery(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUsersByQuery: " + e.Message);
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
    Debug.Print("Exception when calling SearchApi.SearchUsersByQueryWithHttpInfo: " + e.Message);
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
| **200** | List of users |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbystatus"></a>
# **SearchUsersByStatus**
> EmployeeFullArrayWrapper SearchUsersByStatus (EmployeeStatus status, string? query = null, string? filterBy = null, string? filterValue = null)

Returns a list of users matching the status filter and search query.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **EmployeeStatus** | The user status. |  |
| **query** | **string?** | The advanced search query. | [optional]  |
| **filterBy** | **string?** | Specifies the criteria used to filter search results in advanced queries. | [optional]  |
| **filterValue** | **string?** | The value used to filter the search query. | [optional]  |

### Return type

[**EmployeeFullArrayWrapper**](EmployeeFullArrayWrapper.md)

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
    public class SearchUsersByStatusExample
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
            var apiInstance = new SearchApi(httpClient, config, httpClientHandler);
            var status = (EmployeeStatus) "1";  // EmployeeStatus | The user status.
            var query = some text;  // string? | The advanced search query. (optional) 
            var filterBy = some text;  // string? | Specifies the criteria used to filter search results in advanced queries. (optional) 
            var filterValue = some text;  // string? | The value used to filter the search query. (optional) 

            try
            {
                // Search users by status filter
                EmployeeFullArrayWrapper result = apiInstance.SearchUsersByStatus(status, query, filterBy, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUsersByStatus: " + e.Message);
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
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.SearchUsersByStatusWithHttpInfo(status, query, filterBy, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.SearchUsersByStatusWithHttpInfo: " + e.Message);
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
| **200** | List of users with the detailed information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

