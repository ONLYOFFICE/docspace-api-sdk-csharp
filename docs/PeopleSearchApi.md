# DocSpace.API.SDK.Api.SearchApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccountsEntriesWithFilesShared**](#getaccountsentrieswithfilesshared) | **GET** /api/2.0/accounts/file/{id}/search | Search accounts for a file |
| [**GetAccountsEntriesWithFilesShared**](#getaccountsentrieswithfilesshared-thirdparty) | **GET** /api/2.0/accounts/file/{id}/search | Search accounts for a file (third-party storage) |
| [**GetAccountsEntriesWithFoldersShared**](#getaccountsentrieswithfoldersshared) | **GET** /api/2.0/accounts/folder/{id}/search | Search accounts for a folder |
| [**GetAccountsEntriesWithFoldersShared**](#getaccountsentrieswithfoldersshared-thirdparty) | **GET** /api/2.0/accounts/folder/{id}/search | Search accounts for a folder (third-party storage) |
| [**GetAccountsEntriesWithRoomsShared**](#getaccountsentrieswithroomsshared) | **GET** /api/2.0/accounts/room/{id}/search | Search accounts for a room |
| [**GetAccountsEntriesWithRoomsShared**](#getaccountsentrieswithroomsshared-thirdparty) | **GET** /api/2.0/accounts/room/{id}/search | Search accounts for a room (third-party storage) |
| [**GetSearch**](#getsearch) | **GET** /api/2.0/people/@search/{query} | Search users |
| [**GetSimpleByFilter**](#getsimplebyfilter) | **GET** /api/2.0/people/simple/filter | Filter users in brief |
| [**GetUsersWithFilesShared**](#getuserswithfilesshared) | **GET** /api/2.0/people/file/{id} | Search users for a file |
| [**GetUsersWithFilesShared**](#getuserswithfilesshared-thirdparty) | **GET** /api/2.0/people/file/{id} | Search users for a file (third-party storage) |
| [**GetUsersWithFoldersShared**](#getuserswithfoldersshared) | **GET** /api/2.0/people/folder/{id} | Search users for a folder |
| [**GetUsersWithFoldersShared**](#getuserswithfoldersshared-thirdparty) | **GET** /api/2.0/people/folder/{id} | Search users for a folder (third-party storage) |
| [**GetUsersWithRoomShared**](#getuserswithroomshared) | **GET** /api/2.0/people/room/{id} | Search users for a room |
| [**GetUsersWithRoomShared**](#getuserswithroomshared-thirdparty) | **GET** /api/2.0/people/room/{id} | Search users for a room (third-party storage) |
| [**SearchUsersByExtendedFilter**](#searchusersbyextendedfilter) | **GET** /api/2.0/people/filter | Filter users in detail |
| [**SearchUsersByQuery**](#searchusersbyquery) | **GET** /api/2.0/people/search | Search users by query |
| [**SearchUsersByStatus**](#searchusersbystatus) | **GET** /api/2.0/people/status/{status}/search | Search users by status filter |

<a id="getaccountsentrieswithfilesshared"></a>
# **GetAccountsEntriesWithFilesShared**
> IAccountEntryArrayWrapper GetAccountsEntriesWithFilesShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Searches the portal users and groups that can be given access to the file with the ID given in the route, and  reports for each of them whether it already has access to that file.  The caller has to be allowed to manage the access of that file, and the ID has to belong to an existing file,  so the operation answers 403 for a file the caller cannot share and 404 for an ID that matches nothing.  The search is read-only and needs `filterValue`: while it is empty the operation returns an empty list and a  total of 0 instead of every account, so it cannot be used to enumerate the portal.  `filterValue` is matched case-insensitively against the first name, the last name and the email; without  `filterSeparator` it is split on spaces and every term has to match, and with a separator it is split on that  separator and any term may match.  Matching groups are streamed first and users after them, both paged together by `count` and `startIndex`,  while the number of matches is reported in the total count of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. | [optional]  |

### Return type

[**IAccountEntryArrayWrapper**](IAccountEntryArrayWrapper.md)

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
            var id = 1234;  // int | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. (optional) 

            try
            {
                // Search accounts for a file
                IAccountEntryArrayWrapper result = apiInstance.GetAccountsEntriesWithFilesShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
    // Search accounts for a file
    ApiResponse<IAccountEntryArrayWrapper> response = apiInstance.GetAccountsEntriesWithFilesSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
| **200** | The matching users and groups, each with its access state for the file |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No file has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithfilesshared-thirdparty"></a>
# **GetAccountsEntriesWithFilesShared** (third-party storage)
> IAccountEntryArrayWrapper GetAccountsEntriesWithFilesShared (string id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

The overload for an entry in a connected third-party storage: the identifier is a string such as `sbox-42`, and the answer carries string identifiers as well.

Searches the portal users and groups that can be given access to the file with the ID given in the route, and  reports for each of them whether it already has access to that file.  The caller has to be allowed to manage the access of that file, and the ID has to belong to an existing file,  so the operation answers 403 for a file the caller cannot share and 404 for an ID that matches nothing.  The search is read-only and needs `filterValue`: while it is empty the operation returns an empty list and a  total of 0 instead of every account, so it cannot be used to enumerate the portal.  `filterValue` is matched case-insensitively against the first name, the last name and the email; without  `filterSeparator` it is split on spaces and every term has to match, and with a separator it is split on that  separator and any term may match.  Matching groups are streamed first and users after them, both paged together by `count` and `startIndex`,  while the number of matches is reported in the total count of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. | [optional]  |

### Return type

[**IAccountEntryArrayWrapper**](IAccountEntryArrayWrapper.md)

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
            var id = 1234;  // string | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. (optional) 

            try
            {
                // Search accounts for a file (third-party storage)
                IAccountEntryArrayWrapper result = apiInstance.GetAccountsEntriesWithFilesShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
    // Search accounts for a file (third-party storage)
    ApiResponse<IAccountEntryArrayWrapper> response = apiInstance.GetAccountsEntriesWithFilesSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
| **200** | The matching users and groups, each with its access state for the file |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No file has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithfoldersshared"></a>
# **GetAccountsEntriesWithFoldersShared**
> IAccountEntryArrayWrapper GetAccountsEntriesWithFoldersShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Searches the portal users and groups that can be given access to the folder with the ID given in the route,  and reports for each of them whether it already has access to that folder.  The caller has to be allowed to manage the access of that folder, and the ID has to belong to an existing  folder, so the operation answers 403 for a folder the caller cannot share and 404 for an ID that matches  nothing.  The search is read-only and needs `filterValue`: while it is empty the operation returns an empty list and a  total of 0 instead of every account, so it cannot be used to enumerate the portal.  `filterValue` is matched case-insensitively against the first name, the last name and the email; without  `filterSeparator` it is split on spaces and every term has to match, and with a separator it is split on that  separator and any term may match.  Matching groups are streamed first and users after them, both paged together by `count` and `startIndex`,  while the number of matches is reported in the total count of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. | [optional]  |

### Return type

[**IAccountEntryArrayWrapper**](IAccountEntryArrayWrapper.md)

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
            var id = 1234;  // int | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. (optional) 

            try
            {
                // Search accounts for a folder
                IAccountEntryArrayWrapper result = apiInstance.GetAccountsEntriesWithFoldersShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
    // Search accounts for a folder
    ApiResponse<IAccountEntryArrayWrapper> response = apiInstance.GetAccountsEntriesWithFoldersSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
| **200** | The matching users and groups, each with its access state for the folder |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No folder has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithfoldersshared-thirdparty"></a>
# **GetAccountsEntriesWithFoldersShared** (third-party storage)
> IAccountEntryArrayWrapper GetAccountsEntriesWithFoldersShared (string id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

The overload for an entry in a connected third-party storage: the identifier is a string such as `sbox-42`, and the answer carries string identifiers as well.

Searches the portal users and groups that can be given access to the folder with the ID given in the route,  and reports for each of them whether it already has access to that folder.  The caller has to be allowed to manage the access of that folder, and the ID has to belong to an existing  folder, so the operation answers 403 for a folder the caller cannot share and 404 for an ID that matches  nothing.  The search is read-only and needs `filterValue`: while it is empty the operation returns an empty list and a  total of 0 instead of every account, so it cannot be used to enumerate the portal.  `filterValue` is matched case-insensitively against the first name, the last name and the email; without  `filterSeparator` it is split on spaces and every term has to match, and with a separator it is split on that  separator and any term may match.  Matching groups are streamed first and users after them, both paged together by `count` and `startIndex`,  while the number of matches is reported in the total count of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. | [optional]  |

### Return type

[**IAccountEntryArrayWrapper**](IAccountEntryArrayWrapper.md)

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
            var id = 1234;  // string | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. (optional) 

            try
            {
                // Search accounts for a folder (third-party storage)
                IAccountEntryArrayWrapper result = apiInstance.GetAccountsEntriesWithFoldersShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
    // Search accounts for a folder (third-party storage)
    ApiResponse<IAccountEntryArrayWrapper> response = apiInstance.GetAccountsEntriesWithFoldersSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
| **200** | The matching users and groups, each with its access state for the folder |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No folder has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithroomsshared"></a>
# **GetAccountsEntriesWithRoomsShared**
> IAccountEntryArrayWrapper GetAccountsEntriesWithRoomsShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Searches the portal users and groups that can be given access to the room with the ID given in the route, and  reports for each of them whether it already has access to that room.  The caller has to be allowed to manage the access of that room, and the ID has to belong to an existing room,  so the operation answers 403 for a room the caller cannot share and 404 for an ID that matches nothing.  The search is read-only and needs `filterValue`: while it is empty the operation returns an empty list and a  total of 0 instead of every account, so it cannot be used to enumerate the portal.  `filterValue` is matched case-insensitively against the first name, the last name and the email; without  `filterSeparator` it is split on spaces and every term has to match, and with a separator it is split on that  separator and any term may match.  Matching groups are streamed first and users after them, both paged together by `count` and `startIndex`,  while the number of matches is reported in the total count of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. | [optional]  |

### Return type

[**IAccountEntryArrayWrapper**](IAccountEntryArrayWrapper.md)

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
            var id = 1234;  // int | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. (optional) 

            try
            {
                // Search accounts for a room
                IAccountEntryArrayWrapper result = apiInstance.GetAccountsEntriesWithRoomsShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
    // Search accounts for a room
    ApiResponse<IAccountEntryArrayWrapper> response = apiInstance.GetAccountsEntriesWithRoomsSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
| **200** | The matching users and groups, each with its access state for the room |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No room has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccountsentrieswithroomsshared-thirdparty"></a>
# **GetAccountsEntriesWithRoomsShared** (third-party storage)
> IAccountEntryArrayWrapper GetAccountsEntriesWithRoomsShared (string id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

The overload for an entry in a connected third-party storage: the identifier is a string such as `sbox-42`, and the answer carries string identifiers as well.

Searches the portal users and groups that can be given access to the room with the ID given in the route, and  reports for each of them whether it already has access to that room.  The caller has to be allowed to manage the access of that room, and the ID has to belong to an existing room,  so the operation answers 403 for a room the caller cannot share and 404 for an ID that matches nothing.  The search is read-only and needs `filterValue`: while it is empty the operation returns an empty list and a  total of 0 instead of every account, so it cannot be used to enumerate the portal.  `filterValue` is matched case-insensitively against the first name, the last name and the email; without  `filterSeparator` it is split on spaces and every term has to match, and with a separator it is split on that  separator and any term may match.  Matching groups are streamed first and users after them, both paged together by `count` and `startIndex`,  while the number of matches is reported in the total count of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. | [optional]  |

### Return type

[**IAccountEntryArrayWrapper**](IAccountEntryArrayWrapper.md)

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
            var id = 1234;  // string | The ID of the room, folder or file whose access the search is run against, taken from the route. It is an  integer for an entry stored in DocSpace and a provider-specific string for an entry in a connected  third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the users in the given account state: `Active` for a working account, `Terminated` for a disabled  one and `Pending` for one that has not accepted its invitation yet. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the users whose activation is in the given state: `NotActivated` for an account that has never  been activated, `Activated` for one that completed the activation, `Pending` for one whose invitation is  still open, and `AutoGenerated` for an account created by the portal itself. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when adding new  members. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when  `excludeShared` is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the users invited by the caller when true, and only the users invited by somebody else when false.  Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the users invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the users of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page, counting groups and users together. It defaults to 100, which is also the largest value  the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts, counted over the groups and users together. It defaults  to 0, and the total number of matches is reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to search for, matched case-insensitively against the first name, the last name and the email. It is  required in practice: while it is empty the search returns nothing at all rather than every account. (optional) 

            try
            {
                // Search accounts for a room (third-party storage)
                IAccountEntryArrayWrapper result = apiInstance.GetAccountsEntriesWithRoomsShared(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
    // Search accounts for a room (third-party storage)
    ApiResponse<IAccountEntryArrayWrapper> response = apiInstance.GetAccountsEntriesWithRoomsSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
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
| **200** | The matching users and groups, each with its access state for the room |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No room has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsearch"></a>
# **GetSearch**
> EmployeeFullArrayWrapper GetSearch (string query, string? filterBy = null, string? filterValue = null)

Searches the active accounts of the portal by a term taken from the path, and is the same search as  `GET api/2.0/people/search`, which takes the term in the query string instead.  Only a DocSpace administrator may call it; every other account, including a room admin, gets 403.  Only accounts with the `Active` status are searched, so a pending invitation and a disabled account are never  found - use `GET api/2.0/people/filter` to search across states.  The call is read-only and is not paged: every match is streamed, without a total.  `filterBy` set to `group` turns `text` into a group ID and keeps only the members of that group, so `text`  then has to be a valid identifier.  The answer holds full profiles.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string** | The term to look for, taken from the route. Only accounts with the `Active` status are searched. |  |
| **filterBy** | **string?** | The only recognised value is `group`, which turns `filterValue` into a group ID and keeps only the members of  that group. Any other value, and omitting the field, applies no group filter. | [optional]  |
| **filterValue** | **string?** | The group ID to keep the members of, used only when `filterBy` is `group`. It has to be a valid identifier -  a group name is not accepted. | [optional]  |

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
            var query = John;  // string | The term to look for, taken from the route. Only accounts with the `Active` status are searched.
            var filterBy = group;  // string? | The only recognised value is `group`, which turns `filterValue` into a group ID and keeps only the members of  that group. Any other value, and omitting the field, applies no group filter. (optional) 
            var filterValue = 00000000-0000-0000-0000-000000000000;  // string? | The group ID to keep the members of, used only when `filterBy` is `group`. It has to be a valid identifier -  a group name is not accepted. (optional) 

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
| **200** | The full profiles of the matching active accounts |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is not a DocSpace administrator |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsimplebyfilter"></a>
# **GetSimpleByFilter**
> EmployeeArrayWrapper GetSimpleByFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<int>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterSeparator = null, string? filterValue = null)

Returns a page of portal accounts selected by the full set of account filters, with the short profile of each  of them - the identifying fields, the avatar and the display name, without the contacts, the groups or the  quota.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  It accepts exactly the same filters as `GET api/2.0/people/filter` and differs only in how much of each  profile comes back, so prefer this one for pickers, mentions and any list that shows names, and switch to the  other only when the full profile is needed.  Filters combine as conditions that all have to hold, and the same interactions apply: `withoutGroup` makes  `groupId` irrelevant, `employeeType` wins over `employeeTypes`, and `area` cancels the type filters that  contradict it.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **groupId** | **Guid?** | Keeps only the members of this group, or excludes them when `excludeGroup` is true. It is ignored when  `withoutGroup` is set. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType.md) | Keeps only the accounts of this single type: `DocSpaceAdmin`, `RoomAdmin`, `User` or `Guest`. When it is  sent it wins over `employeeTypes`, and a type that contradicts `area` is dropped. | [optional]  |
| **employeeTypes** | [**List&lt;int&gt;?**](int.md) | Keeps the accounts of any of the listed types, combined as alternatives. It is ignored when `employeeType`  is also sent. | [optional]  |
| **isAdministrator** | **bool?** | Set it to true to keep only the DocSpace administrators and the module administrators. Setting it to false  is the same as omitting it and does not exclude administrators. | [optional]  |
| **payments** | [**Payments?**](Payments.md) | Keeps only the accounts that take a paid seat when `Paid`, or only the guests and members that do not when  `Free`. Omit it to search both. | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType.md) | Keeps only the accounts that sign in this way: `SSO`, `LDAP`, or `Standart` for an ordinary portal  password. Omit it to search all of them. | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter.md) | Keeps only the accounts whose storage quota is the portal default when `Default`, or set individually when  `Custom`. `All`, which is the same as omitting the field, searches both. | [optional]  |
| **withoutGroup** | **bool?** | Set it to true to keep only the accounts that belong to no group at all, which makes `groupId` and  `excludeGroup` irrelevant. | [optional]  |
| **excludeGroup** | **bool?** | Inverts `groupId`: with true the members of that group are left out instead of being the only ones kept. It  has no effect without `groupId`. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only. It also cancels the type filters that contradict  it. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **sortBy** | **string?** | What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The direction of the ordering: `Ascending`, which is the default, or `Descending`. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to apply  no text filter at all. | [optional]  |

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
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var groupId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the members of this group, or excludes them when `excludeGroup` is true. It is ignored when  `withoutGroup` is set. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var employeeType = new EmployeeType?(); // EmployeeType? | Keeps only the accounts of this single type: `DocSpaceAdmin`, `RoomAdmin`, `User` or `Guest`. When it is  sent it wins over `employeeTypes`, and a type that contradicts `area` is dropped. (optional) 
            var employeeTypes = new List<int>?(); // List<int>? | Keeps the accounts of any of the listed types, combined as alternatives. It is ignored when `employeeType`  is also sent. (optional) 
            var isAdministrator = false;  // bool? | Set it to true to keep only the DocSpace administrators and the module administrators. Setting it to false  is the same as omitting it and does not exclude administrators. (optional) 
            var payments = new Payments?(); // Payments? | Keeps only the accounts that take a paid seat when `Paid`, or only the guests and members that do not when  `Free`. Omit it to search both. (optional) 
            var accountLoginType = new AccountLoginType?(); // AccountLoginType? | Keeps only the accounts that sign in this way: `SSO`, `LDAP`, or `Standart` for an ordinary portal  password. Omit it to search all of them. (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | Keeps only the accounts whose storage quota is the portal default when `Default`, or set individually when  `Custom`. `All`, which is the same as omitting the field, searches both. (optional) 
            var withoutGroup = false;  // bool? | Set it to true to keep only the accounts that belong to no group at all, which makes `groupId` and  `excludeGroup` irrelevant. (optional) 
            var excludeGroup = false;  // bool? | Inverts `groupId`: with true the members of that group are left out instead of being the only ones kept. It  has no effect without `groupId`. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only. It also cancels the type filters that contradict  it. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var sortBy = DisplayName;  // string? | What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to apply  no text filter at all. (optional) 

            try
            {
                // Filter users in brief
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
    // Filter users in brief
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
| **200** | A page of matching accounts, with their short profiles |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a member or a guest |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithfilesshared"></a>
# **GetUsersWithFilesShared**
> EmployeeFullArrayWrapper GetUsersWithFilesShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the accounts that are relevant to the file with the ID given in the route, and reports for each of  them whether it already has access to that file.  The caller only needs read access to the file, not the right to manage its access, but a guest may not call  it at all; an ID that matches no file answers 404.  The call is read-only, works without a filter - leaving `filterValue` empty returns every matching account  rather than nothing - and is paged by `count` and `startIndex`, with the number of matches in the total count  of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.  A DocSpace administrator additionally sees the guests that are not related to the caller.  To search users and groups together, or to build an access dialog that needs the right to manage sharing, use  `GET api/2.0/accounts/file/{id}/search` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. | [optional]  |

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
            var id = 1234;  // int | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. (optional) 

            try
            {
                // Search users for a file
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
    // Search users for a file
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
| **200** | The matching accounts, each with its access state for the file |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a guest or cannot read the file |  -  |
| **404** | No file has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithfilesshared-thirdparty"></a>
# **GetUsersWithFilesShared** (third-party storage)
> EmployeeFullArrayWrapper GetUsersWithFilesShared (string id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

The overload for an entry in a connected third-party storage: the identifier is a string such as `sbox-42`, and the answer carries string identifiers as well.

Returns the accounts that are relevant to the file with the ID given in the route, and reports for each of  them whether it already has access to that file.  The caller only needs read access to the file, not the right to manage its access, but a guest may not call  it at all; an ID that matches no file answers 404.  The call is read-only, works without a filter - leaving `filterValue` empty returns every matching account  rather than nothing - and is paged by `count` and `startIndex`, with the number of matches in the total count  of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.  A DocSpace administrator additionally sees the guests that are not related to the caller.  To search users and groups together, or to build an access dialog that needs the right to manage sharing, use  `GET api/2.0/accounts/file/{id}/search` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. | [optional]  |

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
            var id = 1234;  // string | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. (optional) 

            try
            {
                // Search users for a file (third-party storage)
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
    // Search users for a file (third-party storage)
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
| **200** | The matching accounts, each with its access state for the file |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a guest or cannot read the file |  -  |
| **404** | No file has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithfoldersshared"></a>
# **GetUsersWithFoldersShared**
> EmployeeFullArrayWrapper GetUsersWithFoldersShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the accounts that are relevant to the folder with the ID given in the route, and reports for each of  them whether it already has access to that folder.  The caller only needs read access to the folder, not the right to manage its access, but a guest may not call  it at all; an ID that matches no folder answers 404.  The call is read-only, works without a filter - leaving `filterValue` empty returns every matching account  rather than nothing - and is paged by `count` and `startIndex`, with the number of matches in the total count  of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.  A DocSpace administrator additionally sees the guests that are not related to the caller.  To search users and groups together, or to build an access dialog that needs the right to manage sharing, use  `GET api/2.0/accounts/folder/{id}/search` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. | [optional]  |

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
            var id = 1234;  // int | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. (optional) 

            try
            {
                // Search users for a folder
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
    // Search users for a folder
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
| **200** | The matching accounts, each with its access state for the folder |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a guest or cannot read the folder |  -  |
| **404** | No folder has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithfoldersshared-thirdparty"></a>
# **GetUsersWithFoldersShared** (third-party storage)
> EmployeeFullArrayWrapper GetUsersWithFoldersShared (string id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

The overload for an entry in a connected third-party storage: the identifier is a string such as `sbox-42`, and the answer carries string identifiers as well.

Returns the accounts that are relevant to the folder with the ID given in the route, and reports for each of  them whether it already has access to that folder.  The caller only needs read access to the folder, not the right to manage its access, but a guest may not call  it at all; an ID that matches no folder answers 404.  The call is read-only, works without a filter - leaving `filterValue` empty returns every matching account  rather than nothing - and is paged by `count` and `startIndex`, with the number of matches in the total count  of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.  A DocSpace administrator additionally sees the guests that are not related to the caller.  To search users and groups together, or to build an access dialog that needs the right to manage sharing, use  `GET api/2.0/accounts/folder/{id}/search` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. | [optional]  |

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
            var id = 1234;  // string | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. (optional) 

            try
            {
                // Search users for a folder (third-party storage)
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
    // Search users for a folder (third-party storage)
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
| **200** | The matching accounts, each with its access state for the folder |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a guest or cannot read the folder |  -  |
| **404** | No folder has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithroomshared"></a>
# **GetUsersWithRoomShared**
> EmployeeFullArrayWrapper GetUsersWithRoomShared (int id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

Returns the accounts that are relevant to the room with the ID given in the route, and reports for each of  them whether it already has access to that room.  The caller only needs read access to the room, not the right to manage its access, but a guest may not call  it at all; an ID that matches no room answers 404.  The call is read-only, works without a filter - leaving `filterValue` empty returns every matching account  rather than nothing - and is paged by `count` and `startIndex`, with the number of matches in the total count  of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.  A DocSpace administrator additionally sees the guests that are not related to the caller.  To search users and groups together, or to build an access dialog that needs the right to manage sharing, use  `GET api/2.0/accounts/room/{id}/search` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. | [optional]  |

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
            var id = 1234;  // int | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. (optional) 

            try
            {
                // Search users for a room
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
    // Search users for a room
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
| **200** | The matching accounts, each with its access state for the room |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a guest or cannot read the room |  -  |
| **404** | No room has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuserswithroomshared-thirdparty"></a>
# **GetUsersWithRoomShared** (third-party storage)
> EmployeeFullArrayWrapper GetUsersWithRoomShared (string id, EmployeeStatus? employeeStatus = null, EmployeeActivationStatus? activationStatus = null, bool? excludeShared = null, bool? includeShared = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, List<EmployeeType>? employeeTypes = null, int? count = null, int? startIndex = null, string? filterSeparator = null, string? filterValue = null)

The overload for an entry in a connected third-party storage: the identifier is a string such as `sbox-42`, and the answer carries string identifiers as well.

Returns the accounts that are relevant to the room with the ID given in the route, and reports for each of  them whether it already has access to that room.  The caller only needs read access to the room, not the right to manage its access, but a guest may not call  it at all; an ID that matches no room answers 404.  The call is read-only, works without a filter - leaving `filterValue` empty returns every matching account  rather than nothing - and is paged by `count` and `startIndex`, with the number of matches in the total count  of the response.  Pass `excludeShared` to keep only the accounts that have no access yet, `includeShared` to keep only those  that already have it, and neither to get both kinds with the `shared` field telling them apart.  A DocSpace administrator additionally sees the guests that are not related to the caller.  To search users and groups together, or to build an access dialog that needs the right to manage sharing, use  `GET api/2.0/accounts/room/{id}/search` instead.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage. |  |
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **excludeShared** | **bool?** | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. | [optional]  |
| **includeShared** | **bool?** | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. | [optional]  |
| **employeeTypes** | [**List&lt;EmployeeType&gt;?**](EmployeeType.md) | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. | [optional]  |

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
            var id = 1234;  // string | The ID of the room, folder or file the search is run against, taken from the route. It is an integer for an  entry stored in DocSpace and a provider-specific string for an entry in a connected third-party storage.
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var excludeShared = false;  // bool? | Keeps only the accounts that do not have access to the entry yet, which is the set to offer when granting  access. It takes precedence over `includeShared`, and every returned entry has `shared` set to false. (optional) 
            var includeShared = false;  // bool? | Keeps only the accounts that already have access to the entry, which is the set to offer when changing or  revoking access. Every returned entry has `shared` set to true, and the flag is ignored when `excludeShared`  is also set. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only - and for a caller who is not a DocSpace  administrator, only the guests that caller is related to. (optional) 
            var employeeTypes = new List<EmployeeType>?(); // List<EmployeeType>? | Keeps only the accounts of the listed types, combined as alternatives. An empty list, which is the default,  searches every type. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split the  value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to get  every account the caller may offer access to. (optional) 

            try
            {
                // Search users for a room (third-party storage)
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
    // Search users for a room (third-party storage)
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
| **200** | The matching accounts, each with its access state for the room |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a guest or cannot read the room |  -  |
| **404** | No room has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbyextendedfilter"></a>
# **SearchUsersByExtendedFilter**
> EmployeeFullArrayWrapper SearchUsersByExtendedFilter (EmployeeStatus? employeeStatus = null, Guid? groupId = null, EmployeeActivationStatus? activationStatus = null, EmployeeType? employeeType = null, List<int>? employeeTypes = null, bool? isAdministrator = null, Payments? payments = null, AccountLoginType? accountLoginType = null, QuotaFilter? quotaFilter = null, bool? withoutGroup = null, bool? excludeGroup = null, bool? invitedByMe = null, Guid? inviterId = null, Area? area = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterSeparator = null, string? filterValue = null)

Returns a page of portal accounts selected by the full set of account filters, with the complete profile of  each of them.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403,  and a DocSpace admin additionally sees the accounts an ordinary admin does not.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Filters combine as conditions that all have to hold, with three interactions worth knowing: `withoutGroup`  makes `groupId` irrelevant, `employeeType` wins over `employeeTypes` when both are sent, and `area` set to  `Guests` or `People` cancels the type filters that contradict it.  `GET api/2.0/people/simple/filter` accepts exactly the same filters and returns the short profile instead, so  use that one for pickers and lists and this one when the full profile is really needed.  It is available on an unpaid portal.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **employeeStatus** | [**EmployeeStatus?**](EmployeeStatus.md) | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. | [optional]  |
| **groupId** | **Guid?** | Keeps only the members of this group, or excludes them when `excludeGroup` is true. It is ignored when  `withoutGroup` is set. | [optional]  |
| **activationStatus** | [**EmployeeActivationStatus?**](EmployeeActivationStatus.md) | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. | [optional]  |
| **employeeType** | [**EmployeeType?**](EmployeeType.md) | Keeps only the accounts of this single type: `DocSpaceAdmin`, `RoomAdmin`, `User` or `Guest`. When it is  sent it wins over `employeeTypes`, and a type that contradicts `area` is dropped. | [optional]  |
| **employeeTypes** | [**List&lt;int&gt;?**](int.md) | Keeps the accounts of any of the listed types, combined as alternatives. It is ignored when `employeeType`  is also sent. | [optional]  |
| **isAdministrator** | **bool?** | Set it to true to keep only the DocSpace administrators and the module administrators. Setting it to false  is the same as omitting it and does not exclude administrators. | [optional]  |
| **payments** | [**Payments?**](Payments.md) | Keeps only the accounts that take a paid seat when `Paid`, or only the guests and members that do not when  `Free`. Omit it to search both. | [optional]  |
| **accountLoginType** | [**AccountLoginType?**](AccountLoginType.md) | Keeps only the accounts that sign in this way: `SSO`, `LDAP`, or `Standart` for an ordinary portal  password. Omit it to search all of them. | [optional]  |
| **quotaFilter** | [**QuotaFilter?**](QuotaFilter.md) | Keeps only the accounts whose storage quota is the portal default when `Default`, or set individually when  `Custom`. `All`, which is the same as omitting the field, searches both. | [optional]  |
| **withoutGroup** | **bool?** | Set it to true to keep only the accounts that belong to no group at all, which makes `groupId` and  `excludeGroup` irrelevant. | [optional]  |
| **excludeGroup** | **bool?** | Inverts `groupId`: with true the members of that group are left out instead of being the only ones kept. It  has no effect without `groupId`. | [optional]  |
| **invitedByMe** | **bool?** | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. | [optional]  |
| **inviterId** | **Guid?** | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. | [optional]  |
| **area** | [**Area?**](Area.md) | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only. It also cancels the type filters that contradict  it. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **sortBy** | **string?** | What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The direction of the ordering: `Ascending`, which is the default, or `Descending`. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the first name, the last name and the email, case-insensitively. Omit it to apply  no text filter at all. | [optional]  |

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
            var employeeStatus = new EmployeeStatus?(); // EmployeeStatus? | Keeps only the accounts in the given state: `Active` for working accounts, `Terminated` for disabled ones  and `Pending` for open invitations. Omit it to search every state. (optional) 
            var groupId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the members of this group, or excludes them when `excludeGroup` is true. It is ignored when  `withoutGroup` is set. (optional) 
            var activationStatus = new EmployeeActivationStatus?(); // EmployeeActivationStatus? | Keeps only the accounts whose activation is in the given state: `NotActivated`, `Activated`, `Pending` or  `AutoGenerated`. Omit it to search every state. (optional) 
            var employeeType = new EmployeeType?(); // EmployeeType? | Keeps only the accounts of this single type: `DocSpaceAdmin`, `RoomAdmin`, `User` or `Guest`. When it is  sent it wins over `employeeTypes`, and a type that contradicts `area` is dropped. (optional) 
            var employeeTypes = new List<int>?(); // List<int>? | Keeps the accounts of any of the listed types, combined as alternatives. It is ignored when `employeeType`  is also sent. (optional) 
            var isAdministrator = false;  // bool? | Set it to true to keep only the DocSpace administrators and the module administrators. Setting it to false  is the same as omitting it and does not exclude administrators. (optional) 
            var payments = new Payments?(); // Payments? | Keeps only the accounts that take a paid seat when `Paid`, or only the guests and members that do not when  `Free`. Omit it to search both. (optional) 
            var accountLoginType = new AccountLoginType?(); // AccountLoginType? | Keeps only the accounts that sign in this way: `SSO`, `LDAP`, or `Standart` for an ordinary portal  password. Omit it to search all of them. (optional) 
            var quotaFilter = new QuotaFilter?(); // QuotaFilter? | Keeps only the accounts whose storage quota is the portal default when `Default`, or set individually when  `Custom`. `All`, which is the same as omitting the field, searches both. (optional) 
            var withoutGroup = false;  // bool? | Set it to true to keep only the accounts that belong to no group at all, which makes `groupId` and  `excludeGroup` irrelevant. (optional) 
            var excludeGroup = false;  // bool? | Inverts `groupId`: with true the members of that group are left out instead of being the only ones kept. It  has no effect without `groupId`. (optional) 
            var invitedByMe = false;  // bool? | Keeps only the accounts invited by the caller when true, and only those invited by somebody else when  false. Omit it to search regardless of who sent the invitation. (optional) 
            var inviterId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the accounts invited by the account with this ID. Omit it to search regardless of who sent the  invitation. (optional) 
            var area = new Area?(); // Area? | The part of the portal to search in: `All`, the default, searches members and guests together, `People`  leaves the guests out, and `Guests` returns guests only. It also cancels the type filters that contradict  it. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var sortBy = DisplayName;  // string? | What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the first name, the last name and the email, case-insensitively. Omit it to apply  no text filter at all. (optional) 

            try
            {
                // Filter users in detail
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
    // Filter users in detail
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
| **200** | A page of matching accounts, with their full profiles |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a member or a guest |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbyquery"></a>
# **SearchUsersByQuery**
> EmployeeFullArrayWrapper SearchUsersByQuery (string? query = null)

Searches the active accounts of the portal by a term passed in the query string, and is the same search as  `GET api/2.0/people/@search/{query}`, which takes the term in the path instead.  Only a DocSpace administrator may call it; every other account, including a room admin, gets 403.  Only accounts with the `Active` status are searched, so a pending invitation and a disabled account are never  found - use `GET api/2.0/people/filter` to search across states.  The call is read-only and is not paged: every match is streamed, without a total.  It takes the search term and nothing else - the group filter of  `GET api/2.0/people/@search/{query}` is not reachable here, because the handler forwards only `query` - so  use that operation when the result has to be narrowed to one group.  The answer holds full profiles, because the handler passes the request on to the operation that builds the  complete profile.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | **string?** | The term to look for. Only accounts with the `Active` status are searched, and this is the only parameter the  operation reads. | [optional]  |

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
            var query = John;  // string? | The term to look for. Only accounts with the `Active` status are searched, and this is the only parameter the  operation reads. (optional) 

            try
            {
                // Search users by query
                EmployeeFullArrayWrapper result = apiInstance.SearchUsersByQuery(query);
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
    // Search users by query
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.SearchUsersByQueryWithHttpInfo(query);
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
| **200** | The full profiles of the matching active accounts |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is not a DocSpace administrator |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchusersbystatus"></a>
# **SearchUsersByStatus**
> EmployeeFullArrayWrapper SearchUsersByStatus (EmployeeStatus status, string? query = null, string? filterBy = null, string? filterValue = null)

Searches the accounts that are in one particular state - the status is taken from the route - and whose name,  user name, email or contacts contain the search term.  Only a DocSpace administrator may call it; every other account, including a room admin, gets 403.  The call is read-only and is not paged: it matches in memory over every account of that status and streams  all of them, so it is meant for administrative lookups rather than for a user-facing list - use  `GET api/2.0/people/filter` when a page and a total are needed.  The term is matched as a case-insensitive substring and is required; `filterBy` set to `group` turns `text`  into a group ID and keeps only the members of that group, so `text` then has to be a valid identifier.  The answer holds full profiles, in no particular order.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | **EmployeeStatus** | The account state to search in, taken from the route: `Active` for working accounts, `Terminated` for  disabled ones, `Pending` for open invitations, or `All` for every state. |  |
| **query** | **string?** | The term to look for, matched as a case-insensitive substring of the first name, the last name, the user  name, the email and the contacts. It is required in practice, because the search cannot run without it. | [optional]  |
| **filterBy** | **string?** | The only recognised value is `group`, which turns `filterValue` into a group ID and keeps only the members of  that group. Any other value, and omitting the field, applies no group filter. | [optional]  |
| **filterValue** | **string?** | The group ID to keep the members of, used only when `filterBy` is `group`. It has to be a valid identifier -  a group name is not accepted. | [optional]  |

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
            var status = Active;  // EmployeeStatus | The account state to search in, taken from the route: `Active` for working accounts, `Terminated` for  disabled ones, `Pending` for open invitations, or `All` for every state.
            var query = John;  // string? | The term to look for, matched as a case-insensitive substring of the first name, the last name, the user  name, the email and the contacts. It is required in practice, because the search cannot run without it. (optional) 
            var filterBy = group;  // string? | The only recognised value is `group`, which turns `filterValue` into a group ID and keeps only the members of  that group. Any other value, and omitting the field, applies no group filter. (optional) 
            var filterValue = 00000000-0000-0000-0000-000000000000;  // string? | The group ID to keep the members of, used only when `filterBy` is `group`. It has to be a valid identifier -  a group name is not accepted. (optional) 

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
| **200** | The full profiles of the matching accounts |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is not a DocSpace administrator |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

