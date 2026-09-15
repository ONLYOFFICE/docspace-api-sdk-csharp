# DocSpace.API.SDK.Api.ProfilesApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMember**](#addmember) | **POST** /api/2.0/people | Add a user |
| [**CheckUserExistsByEmail**](#checkuserexistsbyemail) | **GET** /api/2.0/people/exists | Check whether an email is taken |
| [**DeleteMember**](#deletemember) | **DELETE** /api/2.0/people/{userid} | Delete a user |
| [**DeleteProfile**](#deleteprofile) | **DELETE** /api/2.0/people/@self | Close my own profile |
| [**GetAllProfiles**](#getallprofiles) | **GET** /api/2.0/people | Get the active profiles |
| [**GetClaims**](#getclaims) | **GET** /api/2.0/people/tokendiagnostics | Get user claims |
| [**GetProfileByEmail**](#getprofilebyemail) | **GET** /api/2.0/people/email | Get a profile by user email |
| [**GetProfileByUserId**](#getprofilebyuserid) | **GET** /api/2.0/people/{userid} | Get a profile by user ID |
| [**GetSelfProfile**](#getselfprofile) | **GET** /api/2.0/people/@self | Get my profile |
| [**InviteUsers**](#inviteusers) | **POST** /api/2.0/people/invite | Invite users |
| [**RemoveUsers**](#removeusers) | **PUT** /api/2.0/people/delete | Delete users |
| [**ResendUserInvites**](#resenduserinvites) | **PUT** /api/2.0/people/invite | Resend activation emails |
| [**UpdateMember**](#updatemember) | **PUT** /api/2.0/people/{userid} | Update a user |
| [**UpdateMemberCulture**](#updatememberculture) | **PUT** /api/2.0/people/{userid}/culture | Update a user culture |

<a id="addmember"></a>
# **AddMember**
> EmployeeFullWrapper AddMember (MemberRequestDto? memberRequestDto = null)

Creates a portal profile, either by an administrator adding somebody directly or by a person accepting an  invitation link, which is why the operation accepts both an authenticated session and an invitation  confirmation token.  Set `fromInviteLink` to true and pass the invitation `key` for the second case: the resulting type then comes  from the link and the `type` in the request is ignored, and an invalid or expired link answers 403.  Without a link the caller needs the permission to add users of the requested type, cannot create a guest  through this operation at all, has to be a DocSpace admin to create a room admin and the portal owner to  create another DocSpace admin; either way the portal has to allow inviting members, or guests when the link  says so.  The password is optional: `passwordHash` is taken as it is, a plain `password` is checked against the portal  password policy and rejected with 400 when it is too weak, and when both are omitted a random password is  generated and the account is created without anybody knowing it.  When the portal has no free paid seat the account is still created, silently as a `User` instead of the  requested type, so read the `type` in the answer rather than assuming the request was honoured.  Creating a profile raises a `UserCreated` webhook, downloads the avatar named in `files` if one is given, and  answers with the new profile including its ID.  To invite several people by email at once instead, use `POST api/2.0/people/invite`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **memberRequestDto** | [**MemberRequestDto?**](MemberRequestDto.md) | The user request parameters. | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class AddMemberExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var memberRequestDto = new MemberRequestDto?(); // MemberRequestDto? | The user request parameters. (optional) 

            try
            {
                // Add a user
                EmployeeFullWrapper result = apiInstance.AddMember(memberRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.AddMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a user
    ApiResponse<EmployeeFullWrapper> response = apiInstance.AddMemberWithHttpInfo(memberRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.AddMemberWithHttpInfo: " + e.Message);
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
| **200** | The new profile with its detailed information |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The password does not meet the portal password policy |  -  |
| **403** | The invitation link is invalid or has expired, the portal does not allow inviting this kind of account, or the caller may not create an account of the requested type |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="checkuserexistsbyemail"></a>
# **CheckUserExistsByEmail**
> UserExistsResponseWrapper CheckUserExistsByEmail (string? email = null, string? encemail = null, string? culture = null)

Reports whether an email address already belongs to a portal profile, and in what state that profile is.  It is meant for the invitation and sign-up screens, which is why it accepts a confirmation token as well as an  ordinary session, and why it is available on an unpaid portal.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The call is read-only, and the answer carries `exists` plus the `status` of the profile - `Active`,  `Terminated` or `Pending` - which is left out entirely when nothing matches, so a pending invitation can be  told apart from a working account and from a free address.  It reveals only that an address is taken and not who owns it - read `GET api/2.0/people/email` for the  profile itself, which needs the right to see that account.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/check-user-exists-by-email/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** | The user email address. | [optional]  |
| **encemail** | **string?** | The user encrypted email address. | [optional]  |
| **culture** | **string?** | Culture | [optional]  |

### Return type

[**UserExistsResponseWrapper**](UserExistsResponseWrapper.md)

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
    public class CheckUserExistsByEmailExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var email = john.doe@example.com;  // string? | The user email address. (optional) 
            var encemail = encrypted_email_string;  // string? | The user encrypted email address. (optional) 
            var culture = en-US;  // string? | Culture (optional) 

            try
            {
                // Check whether an email is taken
                UserExistsResponseWrapper result = apiInstance.CheckUserExistsByEmail(email, encemail, culture);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.CheckUserExistsByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckUserExistsByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check whether an email is taken
    ApiResponse<UserExistsResponseWrapper> response = apiInstance.CheckUserExistsByEmailWithHttpInfo(email, encemail, culture);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.CheckUserExistsByEmailWithHttpInfo: " + e.Message);
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
| **200** | Whether the address is taken, and the status of the profile that holds it |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Both email and encemail are missing, or the address is malformed or longer than 255 characters |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemember"></a>
# **DeleteMember**
> EmployeeFullWrapper DeleteMember (string userid)

Deletes a portal profile and queues the erasure of the data behind it.  The account has to be disabled first - set the `Terminated` status through  `PUT api/2.0/people/status/{status}`, otherwise the operation answers 403 - and it must not be a system  account or one imported from LDAP.  The caller needs the permission to add and remove users, and has to be the portal owner to delete a DocSpace  administrator.  The profile disappears at once, together with its avatar, its group memberships, its file shares and its  OAuth clients, while the data it owned is erased by a queued job afterwards, which can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  The removal is permanent and cannot be undone, so hand the rooms and the shared files over first through  `POST api/2.0/people/reassign/start` - an account whose reassignment has not finished cannot be deleted.  The call raises a `UserDeleted` webhook and answers with the profile as it was just before it was removed.  To delete several accounts at once use `PUT api/2.0/people/delete`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | The user ID. |  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class DeleteMemberExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var userid = 00000000-0000-0000-0000-000000000000;  // string | The user ID.

            try
            {
                // Delete a user
                EmployeeFullWrapper result = apiInstance.DeleteMember(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.DeleteMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a user
    ApiResponse<EmployeeFullWrapper> response = apiInstance.DeleteMemberWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.DeleteMemberWithHttpInfo: " + e.Message);
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
| **200** | The profile as it was just before it was deleted |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The account is not disabled, is a system or an LDAP account, or the caller may not delete a DocSpace administrator |  -  |
| **404** | No user has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteprofile"></a>
# **DeleteProfile**
> EmployeeFullWrapper DeleteProfile ()

Closes the calling account at its owner's request: it does not erase the profile, it disables it, ends every  session it has and tells the portal administrators that the account asked to be removed.  It is the second step of the self-service removal - the first is `PUT api/2.0/people/self/delete`, which mails  the confirmation link - so the request has to carry the confirmation token from that link rather than an  ordinary session.  It always acts on the calling account and takes no parameters; the portal owner and an account imported from  LDAP cannot close themselves and get 403.  After the call the account has the `Terminated` status and can no longer sign in, but its rooms, files and  group memberships are untouched, which is why an administrator still has to erase it through  `DELETE api/2.0/people/{userid}` - that operation requires exactly this disabled state.  The step is reversible until then: re-enabling the account through `PUT api/2.0/people/status/{status}`  restores it.  The call raises a `UserUpdated` webhook, not a delete one, and answers with the profile in its new state.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class DeleteProfileExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);

            try
            {
                // Close my own profile
                EmployeeFullWrapper result = apiInstance.DeleteProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.DeleteProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Close my own profile
    ApiResponse<EmployeeFullWrapper> response = apiInstance.DeleteProfileWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.DeleteProfileWithHttpInfo: " + e.Message);
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
| **200** | The profile of the caller with the Terminated status |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is the portal owner, an LDAP account or a system account |  -  |
| **404** | The calling account no longer exists |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallprofiles"></a>
# **GetAllProfiles**
> EmployeeFullArrayWrapper GetAllProfiles (int? count = null, int? startIndex = null, string? filterBy = null, string? sortBy = null, SortOrder? sortOrder = null, string? filterSeparator = null, string? filterValue = null)

Returns a page of the working accounts of the portal, with the full profile of each of them.  It reports only the accounts whose status is `Active`, so disabled accounts and open invitations are never  listed - use `GET api/2.0/people/status/{status}` for those, or `GET api/2.0/people/filter` to search across  every state.  The caller has to be a room admin, a DocSpace admin or a People module admin; a member or a guest gets 403.  The call is read-only, paged by `count` and `startIndex`, ordered by `sortBy` and `sortOrder`, and reports  the number of matches in the total count of the response.  Narrow it with `filterValue` on the name and the email, and with `filterBy` set to `group` to keep only the  members of the group whose ID is passed in `filterValue`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **count** | **int?** | The size of the page. It defaults to 100, which is also the largest value the operation accepts. | [optional]  |
| **startIndex** | **int?** | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. | [optional]  |
| **filterBy** | **string?** | The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. | [optional]  |
| **sortBy** | **string?** | What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. | [optional]  |
| **sortOrder** | [**SortOrder?**](SortOrder.md) | The direction of the ordering: `Ascending`, which is the default, or `Descending`. | [optional]  |
| **filterSeparator** | **string?** | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. | [optional]  |
| **filterValue** | **string?** | The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. | [optional]  |

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
    public class GetAllProfilesExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var count = 25;  // int? | The size of the page. It defaults to 100, which is also the largest value the operation accepts. (optional) 
            var startIndex = 0;  // int? | The number of matches to skip before the page starts. It defaults to 0, and the total number of matches is  reported in the total count of the response. (optional) 
            var filterBy = group;  // string? | The only recognised value is `group`, which makes `filterValue` the ID of the group to keep the members of.  Any other value, and omitting the field, applies no group filter. (optional) 
            var sortBy = DisplayName;  // string? | What to order the accounts by, compared without regard to case: `FirstName`, `LastName`, `DisplayName`,  `Type`, `Email`, `Department`, `UsedSpace`, `CreatedBy` or `RegistrationDate`. (optional) 
            var sortOrder = new SortOrder?(); // SortOrder? | The direction of the ordering: `Ascending`, which is the default, or `Descending`. (optional) 
            var filterSeparator = ,;  // string? | The character that splits `filterValue` into several terms, of which any one may match. Omit it to split  the value on spaces instead, in which case every term has to match. (optional) 
            var filterValue = John;  // string? | The text to match against the name and the email of the account, case-insensitively. Omit it to apply no  text filter. (optional) 

            try
            {
                // Get the active profiles
                EmployeeFullArrayWrapper result = apiInstance.GetAllProfiles(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.GetAllProfiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllProfilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the active profiles
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.GetAllProfilesWithHttpInfo(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.GetAllProfilesWithHttpInfo: " + e.Message);
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
| **200** | A page of active accounts, with their full profiles |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is a member or a guest |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclaims"></a>
# **GetClaims**
> TokenDiagnosticsWrapper GetClaims ()

Returns the identity the current request was authenticated with, as the portal sees it: the account name and  the full list of claims attached to the token or the cookie.  It is a diagnostics operation meant for working out why a call is rejected - which account a token really  belongs to, and which scopes and roles it carries - rather than a source of profile data.  It needs no permission of its own and reports on the caller only, so it cannot be used to inspect another  account.  The call is read-only, and every claim comes back as a single `type:value` string, in the order the  authentication produced them.  An account name of `Unknown Name` means the identity carries no name claim, not that the request is  unauthenticated.  For the profile behind the identity, read `GET api/2.0/people/@self`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**TokenDiagnosticsWrapper**](TokenDiagnosticsWrapper.md)

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
    public class GetClaimsExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);

            try
            {
                // Get user claims
                TokenDiagnosticsWrapper result = apiInstance.GetClaims();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.GetClaims: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClaimsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get user claims
    ApiResponse<TokenDiagnosticsWrapper> response = apiInstance.GetClaimsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.GetClaimsWithHttpInfo: " + e.Message);
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
| **200** | The account name and the claims of the current identity |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprofilebyemail"></a>
# **GetProfileByEmail**
> EmployeeFullWrapper GetProfileByEmail (string? email = null, string? encemail = null, string? culture = null)

Returns the full profile of the account that owns an email address.  Pass the address either in plain text as `email` or, when it arrived inside an invitation link, encrypted as  `encemail`; one of the two is required and a malformed or overlong address answers 400.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and an address that belongs to nobody answers 404.  The call is read-only, and `culture` changes nothing about the profile: it only picks the language of the  error message when the lookup fails.  To find out whether an address is taken without the right to see its owner, use  `GET api/2.0/people/exists`, and to look an account up by its ID or user name use  `GET api/2.0/people/{userid}`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string?** | The user email address. | [optional]  |
| **encemail** | **string?** | The user encrypted email address. | [optional]  |
| **culture** | **string?** | Culture | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class GetProfileByEmailExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var email = john.doe@example.com;  // string? | The user email address. (optional) 
            var encemail = encrypted_email_string;  // string? | The user encrypted email address. (optional) 
            var culture = en-US;  // string? | Culture (optional) 

            try
            {
                // Get a profile by user email
                EmployeeFullWrapper result = apiInstance.GetProfileByEmail(email, encemail, culture);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.GetProfileByEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProfileByEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a profile by user email
    ApiResponse<EmployeeFullWrapper> response = apiInstance.GetProfileByEmailWithHttpInfo(email, encemail, culture);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.GetProfileByEmailWithHttpInfo: " + e.Message);
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
| **200** | The full profile of the account that owns the address |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | Both email and encemail are missing, or the address is malformed or longer than 255 characters |  -  |
| **403** | The caller is not allowed to see that account |  -  |
| **404** | No account owns the specified address |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprofilebyuserid"></a>
# **GetProfileByUserId**
> EmployeeFullWrapper GetProfileByUserId (string userid)

Returns the profile of one account, looked up by its user name first and by its ID if the name matches  nothing, so both forms work in the route.  The caller has to be allowed to see that account - a guest, for instance, only sees the accounts it is  related to - and a value that matches neither a name nor an ID answers 404.  A request authenticated with an invitation link is treated differently: it skips that visibility check and  gets a reduced profile with the identifying fields only, which is what an invitation page needs.  The call is read-only and is available on an unpaid portal.  To read the calling account use `GET api/2.0/people/@self`, and to look an account up by address use  `GET api/2.0/people/email`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | The user ID. |  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class GetProfileByUserIdExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var userid = 00000000-0000-0000-0000-000000000000;  // string | The user ID.

            try
            {
                // Get a profile by user ID
                EmployeeFullWrapper result = apiInstance.GetProfileByUserId(userid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.GetProfileByUserId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProfileByUserIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a profile by user ID
    ApiResponse<EmployeeFullWrapper> response = apiInstance.GetProfileByUserIdWithHttpInfo(userid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.GetProfileByUserIdWithHttpInfo: " + e.Message);
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
| **200** | The full profile, or a reduced one for a request authenticated with an invitation link |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **403** | The caller is not allowed to see that account |  -  |
| **404** | No account has the specified ID or user name |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getselfprofile"></a>
# **GetSelfProfile**
> EmployeeFullWrapper GetSelfProfile ()

Returns the profile of the account the request is authenticated as, together with the session details only  this operation reports.  It takes no parameters, needs no permission and always describes the caller, so it is the operation to call  right after signing in to find out who the token belongs to and what that account may do.  The call is read-only and available on an unpaid portal.  Beyond the ordinary profile fields it fills in four that stay empty everywhere else: `theme` with the  interface theme the account chose, `loginEventId` with the identifier of the current session,  `hasPersonalFolder` with whether the account has a personal folder, and `authCookieLifetime` with the seconds  the session has left - the last one only when less than a day remains or the portal is configured to expose  it, so an absent value means neither, not an endless session.  To read somebody else use `GET api/2.0/people/{userid}`, which reports none of these four.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class GetSelfProfileExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);

            try
            {
                // Get my profile
                EmployeeFullWrapper result = apiInstance.GetSelfProfile();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.GetSelfProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSelfProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get my profile
    ApiResponse<EmployeeFullWrapper> response = apiInstance.GetSelfProfileWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.GetSelfProfileWithHttpInfo: " + e.Message);
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
| **200** | The profile of the caller, with the theme, the session and the personal folder details |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="inviteusers"></a>
# **InviteUsers**
> EmployeeArrayWrapper InviteUsers (InviteUsersRequestDto? inviteUsersRequestDto = null)

Invites people to the portal by email, creating a pending profile for each address and mailing it an  invitation link.  The caller has to be a room admin or a DocSpace admin - a member or a guest is rejected - the portal has to  allow inviting members, and inviting a room admin additionally requires DocSpace admin rights while inviting  another DocSpace admin requires the portal owner; a `Guest` type is not accepted here at all.  An address that already belongs to a profile is not mailed again: the existing account is only related to the  caller, and its type is raised when the invitation asks for a higher one, while a disabled account rejects  the whole call with 400.  The whole call is rejected before anything is sent when the invitations would need more paid seats than the  tariff has left, and a malformed or punycode address is rejected with 400, so the list is validated as a  batch but applied one address at a time - a failure partway through leaves the earlier invitations sent.  The answer is not the result of this call: it lists every profile of the portal that is still pending and  that the caller may see, so previously invited people appear in it as well.  Each newly invited profile raises a `UserInvited` webhook, and repeated calls are throttled.  Use `PUT api/2.0/people/invite` to send the invitation email again, and `POST api/2.0/people` to create a  profile without mailing anybody.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inviteUsersRequestDto** | [**InviteUsersRequestDto?**](InviteUsersRequestDto.md) | The request parameters for inviting users. | [optional]  |

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
    public class InviteUsersExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var inviteUsersRequestDto = new InviteUsersRequestDto?(); // InviteUsersRequestDto? | The request parameters for inviting users. (optional) 

            try
            {
                // Invite users
                EmployeeArrayWrapper result = apiInstance.InviteUsers(inviteUsersRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.InviteUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InviteUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invite users
    ApiResponse<EmployeeArrayWrapper> response = apiInstance.InviteUsersWithHttpInfo(inviteUsersRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.InviteUsersWithHttpInfo: " + e.Message);
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
| **200** | Every pending profile the caller may see, not only the ones just invited |  -  |
| **400** | An address is malformed or written in punycode, or it belongs to a disabled account |  -  |
| **402** | The invitations would need more paid seats than the tariff has left |  -  |
| **403** | No permissions to perform this action |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeusers"></a>
# **RemoveUsers**
> EmployeeFullArrayWrapper RemoveUsers (UpdateMembersRequestDto? updateMembersRequestDto = null)

Deletes several portal profiles in one call and queues the erasure of the data behind each of them.  Every listed account has to be disabled already - set the `Terminated` status through  `PUT api/2.0/people/status/{status}` first, because a single account that is still active rejects the whole  call with 403 - and the caller needs the permission to add and remove users.  System and LDAP accounts are dropped from the list without an error, and so are the accounts the caller may  not delete: a room admin when the caller is not a DocSpace admin, and a DocSpace admin when the caller is not  the portal owner.  The answer lists every account that was asked for, including the ones that were skipped, so it is not proof  that an account was deleted - read `GET api/2.0/people/{userid}` for that, which then answers 404.  The removal is permanent and cannot be undone, and each deleted account raises a `UserDeleted` webhook while  its data is erased by a queued job that can be watched through  `GET api/2.0/people/remove/progress/{userid}`.  Hand the rooms and the shared files over first through `POST api/2.0/people/reassign/start` - an account with  an unfinished reassignment cannot be deleted.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateMembersRequestDto** | [**UpdateMembersRequestDto?**](UpdateMembersRequestDto.md) | The request parameters for updating the user information. | [optional]  |

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
    public class RemoveUsersExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? | The request parameters for updating the user information. (optional) 

            try
            {
                // Delete users
                EmployeeFullArrayWrapper result = apiInstance.RemoveUsers(updateMembersRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.RemoveUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete users
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.RemoveUsersWithHttpInfo(updateMembersRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.RemoveUsersWithHttpInfo: " + e.Message);
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
| **200** | Every account that was asked for, including the ones that were skipped |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The userIds field is missing |  -  |
| **403** | No permissions to perform this action, or one of the listed accounts is not disabled |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="resenduserinvites"></a>
# **ResendUserInvites**
> EmployeeFullArrayWrapper ResendUserInvites (UpdateMembersRequestDto? updateMembersRequestDto = null)

Sends the invitation or activation email again to the accounts that have not finished joining the portal.  Set `resendAll` to true to reach every pending account of the portal, in which case `userIds` is ignored and  the caller has to be a room admin or a DocSpace admin; with the default false only the listed accounts are  reached, and a member or a guest may then list nothing but their own ID.  Which email goes out depends on the state of each account: a pending invitation gets a fresh invitation link,  while an account that exists but has not confirmed its address gets activation instructions instead.  Accounts that are already active or that are disabled are skipped, and so are the pending accounts the caller  has no right to invite, without an error.  The answer lists only the targeted accounts the caller is allowed to see, so it can be shorter than the  request and is not a delivery report.  Repeated calls are throttled, and each call issues new links that make the previously sent ones useless.  To invite an address that has no profile yet, use `POST api/2.0/people/invite`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateMembersRequestDto** | [**UpdateMembersRequestDto?**](UpdateMembersRequestDto.md) | The request parameters for updating the user information. | [optional]  |

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
    public class ResendUserInvitesExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? | The request parameters for updating the user information. (optional) 

            try
            {
                // Resend activation emails
                EmployeeFullArrayWrapper result = apiInstance.ResendUserInvites(updateMembersRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.ResendUserInvites: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResendUserInvitesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend activation emails
    ApiResponse<EmployeeFullArrayWrapper> response = apiInstance.ResendUserInvitesWithHttpInfo(updateMembersRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.ResendUserInvitesWithHttpInfo: " + e.Message);
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
| **200** | The targeted accounts the caller is allowed to see |  * X-RateLimit-Limit - Rate limit: 5 requests per 15 minutes per user/IP. <br>  * X-RateLimit-Remaining - Requests remaining in the current 15-minute window. <br>  * X-RateLimit-Reset -  <br>  |
| **403** | A member or a guest asked for resendAll, or listed an account other than their own |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After - Seconds to wait before retrying (5 req / 15 min limit per user/IP). <br>  |
| **500** | Internal Server Error. |  -  |
| **400** | Bad Request. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatemember"></a>
# **UpdateMember**
> EmployeeFullWrapper UpdateMember (string userid, UpdateMemberRequestDto updateMemberRequestDto)

Updates a portal profile, and which fields it accepts depends on whose profile it is - the two halves of this  operation do not overlap.  On the caller's own profile it applies `firstName`, `lastName`, `location`, `comment`, `spam`, `contacts`,  `department` and the avatar named in `files`, while `disable` and `isUser` are ignored; on somebody else's  profile only `disable` and `isUser` are applied and every descriptive field is ignored, so an administrator  cannot rename another account through this operation.  The caller needs the permission to edit that profile, cannot touch the portal owner, and has to be the portal  owner to touch another DocSpace administrator; on an account imported from LDAP or SSO the name and the  location are silently left alone even on one's own profile.  Omitted fields keep their current values, an unusable pair of names answers 400, and `disable` set to true  gives the account the `Terminated` status and ends every session it has, which is the state  `DELETE api/2.0/people/{userid}` then requires.  The `isUser` flag turns the account into a guest when true and back into a member when false, both of which  can answer 402 because either direction takes a seat; a request to make the portal owner, a DocSpace  administrator or a module administrator a guest is ignored without an error.  A change raises a `UserUpdated` webhook and the answer holds the profile as it is afterwards, so read it  instead of assuming the request was applied.  For the language use `PUT api/2.0/people/{userid}/culture`, for the type  `PUT api/2.0/people/type/{type}`, and for the status of several accounts at once  `PUT api/2.0/people/status/{status}`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | The user ID. |  |
| **updateMemberRequestDto** | [**UpdateMemberRequestDto**](UpdateMemberRequestDto.md) | The request parameters for updating the user information. |  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class UpdateMemberExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var userid = 00000000-0000-0000-0000-000000000000;  // string | The user ID.
            var updateMemberRequestDto = new UpdateMemberRequestDto(); // UpdateMemberRequestDto | The request parameters for updating the user information.

            try
            {
                // Update a user
                EmployeeFullWrapper result = apiInstance.UpdateMember(userid, updateMemberRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.UpdateMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a user
    ApiResponse<EmployeeFullWrapper> response = apiInstance.UpdateMemberWithHttpInfo(userid, updateMemberRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.UpdateMemberWithHttpInfo: " + e.Message);
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
| **200** | The profile as it is after the update |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The first and last name pair is not a valid user name |  -  |
| **402** | The tariff or the user quota does not allow the requested guest or member seat |  -  |
| **403** | The account is the portal owner or a system account, the caller may not edit it, or only the portal owner may edit a DocSpace administrator |  -  |
| **404** | No user has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatememberculture"></a>
# **UpdateMemberCulture**
> EmployeeFullWrapper UpdateMemberCulture (string userid, Culture? culture = null)

Changes the interface language of a profile, which decides the language of the portal for that account and of  the emails it receives.  The culture has to be one the portal has enabled, otherwise the operation answers 400; read the enabled list  from the portal settings rather than guessing a code.  A caller may only change their own language - the ID in the route has to be the calling account, and an  administrator gets 403 for anybody else - and the account must be allowed to edit its own profile.  The change takes effect immediately, raises a `UserUpdated` webhook, and answers with the profile carrying  the new `cultureName`.  Other profile fields are not touched here; use `PUT api/2.0/people/{userid}` for those.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userid** | **string** | The user ID. |  |
| **culture** | [**Culture?**](Culture.md) | The culture name parameters. | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

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
    public class UpdateMemberCultureExample
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
            var apiInstance = new ProfilesApi(httpClient, config, httpClientHandler);
            var userid = 00000000-0000-0000-0000-000000000000;  // string | The user ID.
            var culture = new Culture?(); // Culture? | The culture name parameters. (optional) 

            try
            {
                // Update a user culture
                EmployeeFullWrapper result = apiInstance.UpdateMemberCulture(userid, culture);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProfilesApi.UpdateMemberCulture: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMemberCultureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a user culture
    ApiResponse<EmployeeFullWrapper> response = apiInstance.UpdateMemberCultureWithHttpInfo(userid, culture);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProfilesApi.UpdateMemberCultureWithHttpInfo: " + e.Message);
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
| **200** | The profile with its new culture |  * X-RateLimit-Limit -  <br>  * X-RateLimit-Remaining -  <br>  * X-RateLimit-Reset -  <br>  |
| **400** | The specified culture is not enabled on the portal |  -  |
| **403** | The ID in the route is not the calling account, or the account may not edit its own profile |  -  |
| **404** | No user has the specified ID |  -  |
| **401** | Unauthorized |  -  |
| **429** | Too Many Requests. |  * Retry-After -  <br>  |
| **500** | Internal Server Error. |  -  |
| **502** | Bad Gateway. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |
| **503** | Service Unavailable. Returned by the reverse proxy, response body may be HTML and not JSON. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

