# DocSpace.API.SDK.Api.GroupApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGroup**](#addgroup) | **POST** /api/2.0/group | Add a new group |
| [**AddMembersTo**](#addmembersto) | **PUT** /api/2.0/group/{id}/members | Add group members |
| [**DeleteGroup**](#deletegroup) | **DELETE** /api/2.0/group/{id} | Delete a group |
| [**GetGroup**](#getgroup) | **GET** /api/2.0/group/{id} | Get a group |
| [**GetGroupByUserId**](#getgroupbyuserid) | **GET** /api/2.0/group/user/{userid} | Get user groups |
| [**GetGroups**](#getgroups) | **GET** /api/2.0/group | Get groups |
| [**MoveMembersTo**](#movemembersto) | **PUT** /api/2.0/group/{fromId}/members/{toId} | Move group members |
| [**RemoveMembersFrom**](#removemembersfrom) | **DELETE** /api/2.0/group/{id}/members | Remove group members |
| [**SetGroupManager**](#setgroupmanager) | **PUT** /api/2.0/group/{id}/manager | Set a group manager |
| [**SetMembersTo**](#setmembersto) | **POST** /api/2.0/group/{id}/members | Replace group members |
| [**UpdateGroup**](#updategroup) | **PUT** /api/2.0/group/{id} | Update a group |

<a id="addgroup"></a>
# **AddGroup**
> GroupWrapper AddGroup (GroupRequestDto? groupRequestDto = null)

Creates a group with the given name and, optionally, a manager and a first set of members.  The caller needs the permissions to edit groups and to add and remove users.  The name is required and cannot be blank, and unlike the operations that add members later, this one checks  every listed account upfront and rejects the whole call with 400 if any of them is unusable - a guest, a  disabled account or an ID that matches nobody.  The call is not idempotent: names are not unique, so repeating it creates a second group with the same name.  Creating a group raises a `GroupCreated` webhook, and the answer holds the new group with its members  included.  Members can be changed afterwards through `PUT api/2.0/group/{id}` or the dedicated member operations.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupRequestDto** | [**GroupRequestDto?**](GroupRequestDto.md) | The group request parameters. | [optional]  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class AddGroupExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var groupRequestDto = new GroupRequestDto?(); // GroupRequestDto? | The group request parameters. (optional) 

            try
            {
                // Add a new group
                GroupWrapper result = apiInstance.AddGroup(groupRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.AddGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new group
    ApiResponse<GroupWrapper> response = apiInstance.AddGroupWithHttpInfo(groupRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.AddGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The new group, with its members |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The group name is empty, or one of the listed accounts is a guest, is disabled or does not exist |  -  |
| **403** | No permissions to perform this action |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addmembersto"></a>
# **AddMembersTo**
> GroupWrapper AddMembersTo (Guid id, MembersRequest membersRequest)

Adds the listed accounts to a group, keeping the members it already has.  The caller needs the permissions to edit groups and to add and remove users, and the ID has to belong to a  group that has not been deleted, otherwise the operation answers 404.  Accounts that cannot be group members - a guest, a disabled account or an ID that matches nobody - are  silently skipped instead of failing the call, so compare the members in the answer with what was sent to see  what was actually applied.  The call is idempotent for an account that is already a member, and it does not change who manages the group;  use `PUT api/2.0/group/{id}/manager` for that.  The answer is the group with its members after the addition.  To replace the whole list instead of extending it, use `POST api/2.0/group/{id}/members`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group whose members are changed, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404. |  |
| **membersRequest** | [**MembersRequest**](MembersRequest.md) | The accounts to add, replace with, or remove. |  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class AddMembersToExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group whose members are changed, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404.
            var membersRequest = new MembersRequest(); // MembersRequest | The accounts to add, replace with, or remove.

            try
            {
                // Add group members
                GroupWrapper result = apiInstance.AddMembersTo(id, membersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.AddMembersTo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMembersToWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add group members
    ApiResponse<GroupWrapper> response = apiInstance.AddMembersToWithHttpInfo(id, membersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.AddMembersToWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group with its members after the addition |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (Guid id)

Deletes a group and withdraws the access it had been granted to rooms, folders and files.  The caller needs the permissions to edit groups and to add and remove users, and the ID has to belong to a  group that has not been deleted, otherwise the operation answers 404.  The removal is permanent and cannot be undone, and it affects sharing: everything that was shared with the  group loses that share, so members who had access only through this group lose it too.  The accounts themselves are kept - only their membership disappears.  The call answers 204 with no body and raises a `GroupDeleted` webhook; a second call with the same ID answers  404 rather than succeeding again.  To empty a group without deleting it, move its members away with  `PUT api/2.0/group/{fromId}/members/{toId}` or remove them through `DELETE api/2.0/group/{id}/members`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group to delete, taken from the route. It has to be a group that has not been deleted already,  otherwise the operation answers 404. |  |

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
    public class DeleteGroupExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group to delete, taken from the route. It has to be a group that has not been deleted already,  otherwise the operation answers 404.

            try
            {
                // Delete a group
                apiInstance.DeleteGroup(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.DeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a group
    apiInstance.DeleteGroupWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.DeleteGroupWithHttpInfo: " + e.Message);
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
| **204** | The group is deleted. No content is returned |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroup"></a>
# **GetGroup**
> GroupWrapper GetGroup (Guid id, bool? includeMembers = null)

Returns one group by its ID, with its name, its manager and - when asked for - the accounts that belong to  it.  The caller needs the permission to read groups, and the ID has to belong to a group that has not been  deleted, otherwise the operation answers 404.  The call is read-only, and the member list is left out unless `includeMembers` is set to true, so ask for it  only when the members are actually needed.  Use `GET api/2.0/group` to look a group up by name or to page through them all.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group to read, taken from the route. It has to be a group that has not been deleted, otherwise  the operation answers 404. |  |
| **includeMembers** | **bool?** | Whether to fill in the member list of the group. It defaults to true, so set it to false when only the name  and the manager are needed and the group may be large. | [optional]  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class GetGroupExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group to read, taken from the route. It has to be a group that has not been deleted, otherwise  the operation answers 404.
            var includeMembers = true;  // bool? | Whether to fill in the member list of the group. It defaults to true, so set it to false when only the name  and the manager are needed and the group may be large. (optional) 

            try
            {
                // Get a group
                GroupWrapper result = apiInstance.GetGroup(id, includeMembers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a group
    ApiResponse<GroupWrapper> response = apiInstance.GetGroupWithHttpInfo(id, includeMembers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.GetGroupWithHttpInfo: " + e.Message);
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
| **200** | The group, with its members when includeMembers was set |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroupbyuserid"></a>
# **GetGroupByUserId**
> GroupSummaryArrayWrapper GetGroupByUserId (Guid userid)

Returns every group the account with the ID in the route belongs to, as a flat list of ID and name pairs.  The caller needs the permission to read groups.  The call is read-only, is not paged, and answers an empty list both for an account that belongs to no group  and for an ID that matches no account, so an empty answer does not prove the account exists.  The entries are summaries and carry neither the manager nor the members - read `GET api/2.0/group/{id}` for  the full picture of one of them.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **Guid** | The ID of the account whose groups are listed, taken from the route. An ID that matches no account yields an  empty list rather than 404. |  |

### Return type

[**GroupSummaryArrayWrapper**](GroupSummaryArrayWrapper.md)

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
    public class GetGroupByUserIdExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var userid = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the account whose groups are listed, taken from the route. An ID that matches no account yields an  empty list rather than 404.

            try
            {
                // Get user groups
                GroupSummaryArrayWrapper result = apiInstance.GetGroupByUserId(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroupByUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupByUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get user groups
    ApiResponse<GroupSummaryArrayWrapper> response = apiInstance.GetGroupByUserIdWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.GetGroupByUserIdWithHttpInfo: " + e.Message);
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
| **200** | The groups the account belongs to, as ID and name pairs |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroups"></a>
# **GetGroups**
> GroupArrayWrapper GetGroups (Guid? userId = null, bool? manager = null, int? count = null, int? startIndex = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterValue = null)

Returns the groups of the portal, one page at a time, with the summary information about each of them - the  ID, the name and the manager - but without the member list.  The caller needs the permission to read groups.  The call is read-only, and the number of groups that match the filters is reported in the total count of the  response, so a client can page through them with `count` and `startIndex`.  Narrow the result with `filterValue` on the group name, with `userId` to keep only the groups that account  belongs to, and with `manager` set to true to keep only the groups it manages; order it with `sortBy` and  `sortOrder`, and an unknown `sortBy` falls back to sorting by title.  The entries carry no members - read `GET api/2.0/group/{id}` with `includeMembers` for one group, or  `GET api/2.0/group/user/{userid}` to find the groups of a single account.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid?** | Keeps only the groups the account with this ID takes part in. Omit it to search every group of the portal. | [optional]  |
| **manager** | **bool?** | Narrows `userId` down to the groups that account manages, instead of every group it belongs to. It has no  effect on its own and defaults to false. | [optional]  |
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matching groups to skip before the page starts. It defaults to 0, and the total number of  matches is reported in the total count of the response. | [optional]  |
| **sortBy** | **string?** | What to order the groups by: `Title`, `Manager` or `MembersCount`, compared without regard to case. Any other  value, and omitting the field, orders by title. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The direction of the ordering: `Ascending`, which is the default, or `Descending`. | [optional]  |
| **filterValue** | **string?** | The text to match against the group name. Omit it to get every group. | [optional]  |

### Return type

[**GroupArrayWrapper**](GroupArrayWrapper.md)

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
    public class GetGroupsExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var userId = 00000000-0000-0000-0000-000000000000;  // Guid? | Keeps only the groups the account with this ID takes part in. Omit it to search every group of the portal. (optional) 
            var manager = false;  // bool? | Narrows `userId` down to the groups that account manages, instead of every group it belongs to. It has no  effect on its own and defaults to false. (optional) 
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matching groups to skip before the page starts. It defaults to 0, and the total number of  matches is reported in the total count of the response. (optional) 
            var sortBy = Title;  // string? | What to order the groups by: `Title`, `Manager` or `MembersCount`, compared without regard to case. Any other  value, and omitting the field, orders by title. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional) 
            var filterValue = Marketing;  // string? | The text to match against the group name. Omit it to get every group. (optional) 

            try
            {
                // Get groups
                GroupArrayWrapper result = apiInstance.GetGroups(userId, manager, count, startIndex, sortBy, sortOrder, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.GetGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get groups
    ApiResponse<GroupArrayWrapper> response = apiInstance.GetGroupsWithHttpInfo(userId, manager, count, startIndex, sortBy, sortOrder, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.GetGroupsWithHttpInfo: " + e.Message);
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
| **200** | The matching groups, with their summary information |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="movemembersto"></a>
# **MoveMembersTo**
> GroupWrapper MoveMembersTo (Guid fromId, Guid toId)

Moves every member of one group into another group, emptying the first one.  The caller needs the permissions to edit groups and to add and remove users, and both IDs have to belong to  groups that have not been deleted, otherwise the operation answers 404.  The source group is kept, only without members, so delete it separately through  `DELETE api/2.0/group/{id}` if it is no longer needed.  Members that cannot be group members any more are silently skipped rather than failing the call, and an  account that already belongs to the destination is simply left there.  The answer is the destination group with its members, not the source one.  To move a chosen few instead of everybody, use `PUT api/2.0/group/{id}/members` and  `DELETE api/2.0/group/{id}/members`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromId** | **Guid** | The ID of the group the members are taken from. It is emptied but not deleted, and it has to be a group that  has not been deleted already. |  |
| **toId** | **Guid** | The ID of the group the members are moved into. It is the group the answer describes, and it has to be a  group that has not been deleted already. |  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class MoveMembersToExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var fromId = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group the members are taken from. It is emptied but not deleted, and it has to be a group that  has not been deleted already.
            var toId = 11111111-1111-1111-1111-111111111111;  // Guid | The ID of the group the members are moved into. It is the group the answer describes, and it has to be a  group that has not been deleted already.

            try
            {
                // Move group members
                GroupWrapper result = apiInstance.MoveMembersTo(fromId, toId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.MoveMembersTo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveMembersToWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Move group members
    ApiResponse<GroupWrapper> response = apiInstance.MoveMembersToWithHttpInfo(fromId, toId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.MoveMembersToWithHttpInfo: " + e.Message);
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
| **200** | The destination group with its members |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has one of the specified IDs |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removemembersfrom"></a>
# **RemoveMembersFrom**
> GroupWrapper RemoveMembersFrom (Guid id, MembersRequest membersRequest)

Removes the listed accounts from a group, leaving the rest of its members in place.  The caller needs the permissions to edit groups and to add and remove users, and the ID has to belong to a  group that has not been deleted, otherwise the operation answers 404.  The accounts themselves are kept; only their membership in this group ends, together with the access they had  through it.  The call is idempotent and forgiving: an ID that is not a member, and one that matches no account at all, are  both skipped without an error, and an empty list simply changes nothing.  The answer is the group with the members that remain.  Emptying a group cannot be done through `POST api/2.0/group/{id}/members`, which needs at least one valid  account, so list every member here, or move them away with `PUT api/2.0/group/{fromId}/members/{toId}`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group whose members are changed, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404. |  |
| **membersRequest** | [**MembersRequest**](MembersRequest.md) | The accounts to add, replace with, or remove. |  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class RemoveMembersFromExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group whose members are changed, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404.
            var membersRequest = new MembersRequest(); // MembersRequest | The accounts to add, replace with, or remove.

            try
            {
                // Remove group members
                GroupWrapper result = apiInstance.RemoveMembersFrom(id, membersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.RemoveMembersFrom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMembersFromWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove group members
    ApiResponse<GroupWrapper> response = apiInstance.RemoveMembersFromWithHttpInfo(id, membersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.RemoveMembersFromWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group with the members that remain |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setgroupmanager"></a>
# **SetGroupManager**
> GroupWrapper SetGroupManager (Guid id, SetManagerRequest setManagerRequest)

Makes an account the manager of a group, replacing whoever managed it before.  The caller needs the permissions to edit groups and to add and remove users.  Both the group and the account have to exist: the operation answers 404 when the ID in the route matches no  live group and also when `userId` matches no account, so the message of the error says which of the two was  not found.  The account is added to the group at the same time, so a manager does not have to be a member beforehand, and  the previous manager stays in the group as an ordinary member.  A group has one manager, which makes the call idempotent when it names the account that manages it already.  The answer is the group with its new manager.  To change the members rather than the manager, use `PUT api/2.0/group/{id}/members`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group whose manager is set, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404. |  |
| **setManagerRequest** | [**SetManagerRequest**](SetManagerRequest.md) | The account to make the manager of the group. |  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class SetGroupManagerExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group whose manager is set, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404.
            var setManagerRequest = new SetManagerRequest(); // SetManagerRequest | The account to make the manager of the group.

            try
            {
                // Set a group manager
                GroupWrapper result = apiInstance.SetGroupManager(id, setManagerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.SetGroupManager: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetGroupManagerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set a group manager
    ApiResponse<GroupWrapper> response = apiInstance.SetGroupManagerWithHttpInfo(id, setManagerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.SetGroupManagerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group with its new manager |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID, or no account has the specified userId |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setmembersto"></a>
# **SetMembersTo**
> GroupWrapper SetMembersTo (Guid id, MembersRequest membersRequest)

Replaces the whole member list of a group with the accounts given in the request, removing everybody who is  not in that list.  The caller needs the permissions to edit groups and to add and remove users, and the ID has to belong to a  group that has not been deleted, otherwise the operation answers 404.  At least one of the listed accounts has to be usable as a group member, otherwise the call is rejected with  400 and the group is left untouched; the accounts that cannot be members - a guest, a disabled account or an  ID that matches nobody - are then silently skipped while the rest are applied.  The replacement is not atomic: the current members are removed first and the new ones added afterwards, so a  failure in between can leave the group empty.  The answer is the group with the members it ends up with, which is why it should be read instead of assuming  the request was applied verbatim.  To add or remove a few accounts without touching the others, use `PUT api/2.0/group/{id}/members` and  `DELETE api/2.0/group/{id}/members`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group whose members are changed, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404. |  |
| **membersRequest** | [**MembersRequest**](MembersRequest.md) | The accounts to add, replace with, or remove. |  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class SetMembersToExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group whose members are changed, taken from the route. It has to be a group that has not been  deleted, otherwise the operation answers 404.
            var membersRequest = new MembersRequest(); // MembersRequest | The accounts to add, replace with, or remove.

            try
            {
                // Replace group members
                GroupWrapper result = apiInstance.SetMembersTo(id, membersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.SetMembersTo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMembersToWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace group members
    ApiResponse<GroupWrapper> response = apiInstance.SetMembersToWithHttpInfo(id, membersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.SetMembersToWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group with the members it ends up with |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | None of the listed accounts can be a group member |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updategroup"></a>
# **UpdateGroup**
> GroupWrapper UpdateGroup (Guid id, UpdateGroupRequest updateGroupRequest)

Changes the name and the manager of a group and adds or removes members, in one call.  The caller needs the permissions to edit groups and to add and remove users, and the ID has to belong to a  group that has not been deleted, otherwise the operation answers 404.  Every field is optional and the ones that are left out are kept: omitting `groupName` keeps the current name,  and omitting `groupManager` keeps the current manager rather than clearing it.  Accounts in `membersToAdd` that cannot be group members - a guest, a disabled account or an ID that matches  nobody - are silently skipped instead of failing the call, so compare the members in the answer with what was  sent to see what was actually applied.  Members are added first and removed afterwards, an account listed in both lists therefore ends up removed,  and removing an account that is not a member changes nothing.  The change raises a `GroupUpdated` webhook, and the answer holds the group as it is after the update.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The ID of the group to update, taken from the route. It has to be a group that has not been deleted,  otherwise the operation answers 404. |  |
| **updateGroupRequest** | [**UpdateGroupRequest**](UpdateGroupRequest.md) | The fields to change. Every field is optional and the ones that are left out keep their current values, so an  empty object changes nothing. |  |

### Return type

[**GroupWrapper**](GroupWrapper.md)

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
    public class UpdateGroupExample
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
            var apiInstance = new GroupApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | The ID of the group to update, taken from the route. It has to be a group that has not been deleted,  otherwise the operation answers 404.
            var updateGroupRequest = new UpdateGroupRequest(); // UpdateGroupRequest | The fields to change. Every field is optional and the ones that are left out keep their current values, so an  empty object changes nothing.

            try
            {
                // Update a group
                GroupWrapper result = apiInstance.UpdateGroup(id, updateGroupRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupApi.UpdateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a group
    ApiResponse<GroupWrapper> response = apiInstance.UpdateGroupWithHttpInfo(id, updateGroupRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupApi.UpdateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group as it is after the update |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | No permissions to perform this action |  -  |
| **404** | No group has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

