# DocSpace.API.SDK.Api.AgentsApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AiAgentsCreate**](#aiagentscreate) | **POST** /api/2.0/ai/agents | Create an agent |
| [**AiAgentsDelete**](#aiagentsdelete) | **DELETE** /api/2.0/ai/agents/{id} | Delete an agent |
| [**AiAgentsGet**](#aiagentsget) | **GET** /api/2.0/ai/agents/{id} | Get an agent |
| [**AiAgentsList**](#aiagentslist) | **GET** /api/2.0/ai/agents | List agents |
| [**AiAgentsNews**](#aiagentsnews) | **GET** /api/2.0/ai/agents/news | List agent news items |
| [**AiAgentsResetQuota**](#aiagentsresetquota) | **PUT** /api/2.0/ai/agents/resetquota | Reset agents' quota |
| [**AiAgentsUpdate**](#aiagentsupdate) | **PUT** /api/2.0/ai/agents/{id} | Update an agent |
| [**AiAgentsUpdateQuota**](#aiagentsupdatequota) | **PUT** /api/2.0/ai/agents/agentquota | Update agents' quota |

<a id="aiagentscreate"></a>
# **AiAgentsCreate**
> AiFolderIntegerWrapper AiAgentsCreate (AiAgentsCreateRequest aiAgentsCreateRequest)

Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAgentsCreateRequest** | [**AiAgentsCreateRequest**](AiAgentsCreateRequest.md) |  |  |

### Return type

[**AiFolderIntegerWrapper**](AiFolderIntegerWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var aiAgentsCreateRequest = new AiAgentsCreateRequest(); // AiAgentsCreateRequest | 

            try
            {
                // Create an agent
                AiFolderIntegerWrapper result = apiInstance.AiAgentsCreate(aiAgentsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an agent
    ApiResponse<AiFolderIntegerWrapper> response = apiInstance.AiAgentsCreateWithHttpInfo(aiAgentsCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsCreateWithHttpInfo: " + e.Message);
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
| **200** | The created agent room, with the model already bound to it. |  -  |
| **400** | `profileId` is missing, is not a UUID, names no existing profile, or names one that does not support chat; or `prompt` is missing. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentsdelete"></a>
# **AiAgentsDelete**
> AiFileOperationWrapper AiAgentsDelete (string id, AiAgentsDeleteRequest aiAgentsDeleteRequest)

Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The agent identifier. |  |
| **aiAgentsDeleteRequest** | [**AiAgentsDeleteRequest**](AiAgentsDeleteRequest.md) |  |  |

### Return type

[**AiFileOperationWrapper**](AiFileOperationWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var id = 1234;  // string | The agent identifier.
            var aiAgentsDeleteRequest = new AiAgentsDeleteRequest(); // AiAgentsDeleteRequest | 

            try
            {
                // Delete an agent
                AiFileOperationWrapper result = apiInstance.AiAgentsDelete(id, aiAgentsDeleteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an agent
    ApiResponse<AiFileOperationWrapper> response = apiInstance.AiAgentsDeleteWithHttpInfo(id, aiAgentsDeleteRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsDeleteWithHttpInfo: " + e.Message);
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
| **200** | The queued file operation. Deletion runs asynchronously, so poll DocSpace for its outcome. |  -  |
| **400** | The agent ID is not a positive integer. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentsget"></a>
# **AiAgentsGet**
> AiAgentsGet200Response AiAgentsGet (string id)

Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The agent identifier. |  |

### Return type

[**AiAgentsGet200Response**](AiAgentsGet200Response.md)

### Authorization

No authorization required

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
    public class AiAgentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var id = 1234;  // string | The agent identifier.

            try
            {
                // Get an agent
                AiAgentsGet200Response result = apiInstance.AiAgentsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an agent
    ApiResponse<AiAgentsGet200Response> response = apiInstance.AiAgentsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsGetWithHttpInfo: " + e.Message);
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
| **200** | The agent room, with `profileId` added when a model is bound to it. |  -  |
| **400** | The agent ID is not a positive integer. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentslist"></a>
# **AiAgentsList**
> AiFolderContentIntegerWrapper AiAgentsList (string? subjectId = null, string? subjectOwnerId = null, bool? excludeSubject = null, string? tags = null, bool? withoutTags = null, int? quotaFilter = null, string? filterValue = null, string? sortBy = null, string? sortOrder = null, int? startIndex = null, int? count = null)

Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subjectId** | **string?** | Show only the agent rooms this user takes part in. | [optional]  |
| **subjectOwnerId** | **string?** | Show only the agent rooms owned by this user. | [optional]  |
| **excludeSubject** | **bool?** | Invert the user filter: leave out what `subjectId` selects instead of keeping it. | [optional]  |
| **tags** | **string?** | Show only the agent rooms carrying these tags, comma-separated. | [optional]  |
| **withoutTags** | **bool?** | Show only the agent rooms that carry no tags at all. | [optional]  |
| **quotaFilter** | **int?** | Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. | [optional]  |
| **filterValue** | **string?** | Show only the agent rooms whose title matches this text. | [optional]  |
| **sortBy** | **string?** | Field to sort by, for example `DateAndTime`. | [optional]  |
| **sortOrder** | **string?** | Sort direction, `ascending` or `descending`. | [optional]  |
| **startIndex** | **int?** | Index of the first entry to return; 0 starts at the beginning. | [optional]  |
| **count** | **int?** | How many entries to return. The internal service applies its own default. | [optional]  |

### Return type

[**AiFolderContentIntegerWrapper**](AiFolderContentIntegerWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var subjectId = 00000000-0000-0000-0000-000000000000;  // string? | Show only the agent rooms this user takes part in. (optional) 
            var subjectOwnerId = 00000000-0000-0000-0000-000000000000;  // string? | Show only the agent rooms owned by this user. (optional) 
            var excludeSubject = false;  // bool? | Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional) 
            var tags = ai,assistant;  // string? | Show only the agent rooms carrying these tags, comma-separated. (optional) 
            var withoutTags = false;  // bool? | Show only the agent rooms that carry no tags at all. (optional) 
            var quotaFilter = 0;  // int? | Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional) 
            var filterValue = assistant;  // string? | Show only the agent rooms whose title matches this text. (optional) 
            var sortBy = DateAndTime;  // string? | Field to sort by, for example `DateAndTime`. (optional) 
            var sortOrder = descending;  // string? | Sort direction, `ascending` or `descending`. (optional) 
            var startIndex = 0;  // int? | Index of the first entry to return; 0 starts at the beginning. (optional) 
            var count = 25;  // int? | How many entries to return. The internal service applies its own default. (optional) 

            try
            {
                // List agents
                AiFolderContentIntegerWrapper result = apiInstance.AiAgentsList(subjectId, subjectOwnerId, excludeSubject, tags, withoutTags, quotaFilter, filterValue, sortBy, sortOrder, startIndex, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List agents
    ApiResponse<AiFolderContentIntegerWrapper> response = apiInstance.AiAgentsListWithHttpInfo(subjectId, subjectOwnerId, excludeSubject, tags, withoutTags, quotaFilter, filterValue, sortBy, sortOrder, startIndex, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsListWithHttpInfo: " + e.Message);
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
| **200** | The agent rooms, in the DocSpace AI service's folder-content envelope. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentsnews"></a>
# **AiAgentsNews**
> AiNewItemsAgentNewItemsArrayWrapper AiAgentsNews ()

Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/).

### Parameters
This endpoint does not need any parameter.
### Return type

[**AiNewItemsAgentNewItemsArrayWrapper**](AiNewItemsAgentNewItemsArrayWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsNewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);

            try
            {
                // List agent news items
                AiNewItemsAgentNewItemsArrayWrapper result = apiInstance.AiAgentsNews();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsNews: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsNewsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List agent news items
    ApiResponse<AiNewItemsAgentNewItemsArrayWrapper> response = apiInstance.AiAgentsNewsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsNewsWithHttpInfo: " + e.Message);
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
| **200** | The unread items of the caller's agent rooms. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentsresetquota"></a>
# **AiAgentsResetQuota**
> AiFolderIntegerArrayWrapper AiAgentsResetQuota (AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest)

Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAgentsResetQuotaRequest** | [**AiAgentsResetQuotaRequest**](AiAgentsResetQuotaRequest.md) |  |  |

### Return type

[**AiFolderIntegerArrayWrapper**](AiFolderIntegerArrayWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsResetQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var aiAgentsResetQuotaRequest = new AiAgentsResetQuotaRequest(); // AiAgentsResetQuotaRequest | 

            try
            {
                // Reset agents' quota
                AiFolderIntegerArrayWrapper result = apiInstance.AiAgentsResetQuota(aiAgentsResetQuotaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsResetQuota: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsResetQuotaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset agents' quota
    ApiResponse<AiFolderIntegerArrayWrapper> response = apiInstance.AiAgentsResetQuotaWithHttpInfo(aiAgentsResetQuotaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsResetQuotaWithHttpInfo: " + e.Message);
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
| **200** | The updated agent rooms, one entry each. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentsupdate"></a>
# **AiAgentsUpdate**
> AiFolderIntegerWrapper AiAgentsUpdate (string id, AiAgentsUpdateRequest aiAgentsUpdateRequest)

Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The agent identifier. |  |
| **aiAgentsUpdateRequest** | [**AiAgentsUpdateRequest**](AiAgentsUpdateRequest.md) |  |  |

### Return type

[**AiFolderIntegerWrapper**](AiFolderIntegerWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var id = 1234;  // string | The agent identifier.
            var aiAgentsUpdateRequest = new AiAgentsUpdateRequest(); // AiAgentsUpdateRequest | 

            try
            {
                // Update an agent
                AiFolderIntegerWrapper result = apiInstance.AiAgentsUpdate(id, aiAgentsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an agent
    ApiResponse<AiFolderIntegerWrapper> response = apiInstance.AiAgentsUpdateWithHttpInfo(id, aiAgentsUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsUpdateWithHttpInfo: " + e.Message);
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
| **200** | The updated agent room. |  -  |
| **400** | The agent ID is not a positive integer, or `profileId` is not a UUID, names no existing profile, or names one that does not support chat. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="aiagentsupdatequota"></a>
# **AiAgentsUpdateQuota**
> AiFolderIntegerArrayWrapper AiAgentsUpdateQuota (AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest)

Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aiAgentsUpdateQuotaRequest** | [**AiAgentsUpdateQuotaRequest**](AiAgentsUpdateQuotaRequest.md) |  |  |

### Return type

[**AiFolderIntegerArrayWrapper**](AiFolderIntegerArrayWrapper.md)

### Authorization

No authorization required

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
    public class AiAgentsUpdateQuotaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://your-docspace.onlyoffice.com";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AgentsApi(httpClient, config, httpClientHandler);
            var aiAgentsUpdateQuotaRequest = new AiAgentsUpdateQuotaRequest(); // AiAgentsUpdateQuotaRequest | 

            try
            {
                // Update agents' quota
                AiFolderIntegerArrayWrapper result = apiInstance.AiAgentsUpdateQuota(aiAgentsUpdateQuotaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AiAgentsUpdateQuota: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AiAgentsUpdateQuotaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update agents' quota
    ApiResponse<AiFolderIntegerArrayWrapper> response = apiInstance.AiAgentsUpdateQuotaWithHttpInfo(aiAgentsUpdateQuotaRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentsApi.AiAgentsUpdateQuotaWithHttpInfo: " + e.Message);
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
| **200** | The updated agent rooms, one entry each. |  -  |
| **401** | Missing `asc_auth_key` cookie or `Authorization` header. |  -  |
| **403** | AI is disabled for this portal, or the caller is a guest. Relayed from the DocSpace AI service. |  -  |
| **413** | The request body is larger than 100 KB, the JSON parser's limit on this route. |  -  |
| **500** | Unhandled failure. The reason is logged server-side and never echoed back. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

