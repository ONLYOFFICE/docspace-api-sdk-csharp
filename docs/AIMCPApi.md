# DocSpace.API.SDK.Api.MCPApi

All URIs are relative to *https://your-docspace.onlyoffice.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddRoomServers**](#addroomservers) | **POST** /api/2.0/ai/rooms/{roomId}/servers | Assign MCP servers to a room |
| [**AddServer**](#addserver) | **POST** /api/2.0/ai/servers | Register a custom MCP server |
| [**ConnectServer**](#connectserver) | **POST** /api/2.0/ai/rooms/{roomId}/servers/{serverId}/connect | Connect an OAuth-based MCP server in a room |
| [**DeleteRoomServers**](#deleteroomservers) | **DELETE** /api/2.0/ai/rooms/{roomId}/servers | Remove MCP servers from a room |
| [**DeleteServer**](#deleteserver) | **DELETE** /api/2.0/ai/servers | Delete MCP servers |
| [**DisconnectServer**](#disconnectserver) | **POST** /api/2.0/ai/rooms/{roomId}/servers/{serverId}/disconnect | Disconnect an MCP server in a room |
| [**GetAvailableServers**](#getavailableservers) | **GET** /api/2.0/ai/servers/available | Get available MCP servers |
| [**GetRoomServers**](#getroomservers) | **GET** /api/2.0/ai/rooms/{roomId}/servers | Get MCP servers assigned to a room |
| [**GetServer**](#getserver) | **GET** /api/2.0/ai/servers/{id} | Get an MCP server by ID |
| [**GetServers**](#getservers) | **GET** /api/2.0/ai/servers | Get all MCP servers |
| [**GetTools**](#gettools) | **GET** /api/2.0/ai/rooms/{roomId}/servers/{serverId}/tools | Get MCP server tools in a room |
| [**SetServerStatus**](#setserverstatus) | **PUT** /api/2.0/ai/servers/{id}/status | Enable or disable an MCP server |
| [**SetTools**](#settools) | **PUT** /api/2.0/ai/rooms/{roomId}/servers/{serverId}/tools | Configure MCP server tools in a room |
| [**UpdateServer**](#updateserver) | **PUT** /api/2.0/ai/servers/{id} | Update a custom MCP server |

<a id="addroomservers"></a>
# **AddRoomServers**
> McpServerStatusArrayWrapper AddRoomServers (int roomId, AddRoomServersRequestBody addRoomServersRequestBody)

Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room to which MCP servers will be assigned. |  |
| **addRoomServersRequestBody** | [**AddRoomServersRequestBody**](AddRoomServersRequestBody.md) | Server identifiers to assign. |  |

### Return type

[**McpServerStatusArrayWrapper**](McpServerStatusArrayWrapper.md)

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
    public class AddRoomServersExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room to which MCP servers will be assigned.
            var addRoomServersRequestBody = new AddRoomServersRequestBody(); // AddRoomServersRequestBody | Server identifiers to assign.

            try
            {
                // Assign MCP servers to a room
                McpServerStatusArrayWrapper result = apiInstance.AddRoomServers(roomId, addRoomServersRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.AddRoomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddRoomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Assign MCP servers to a room
    ApiResponse<McpServerStatusArrayWrapper> response = apiInstance.AddRoomServersWithHttpInfo(roomId, addRoomServersRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.AddRoomServersWithHttpInfo: " + e.Message);
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
| **200** | List of MCP server statuses after assignment |  -  |
| **400** | The maximum number of servers per room has been exceeded |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room with the specified ID was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addserver"></a>
# **AddServer**
> McpServerWrapper AddServer (AddMcpServerRequestBody addMcpServerRequestBody)

Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addMcpServerRequestBody** | [**AddMcpServerRequestBody**](AddMcpServerRequestBody.md) | MCP server registration parameters. |  |

### Return type

[**McpServerWrapper**](McpServerWrapper.md)

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
    public class AddServerExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var addMcpServerRequestBody = new AddMcpServerRequestBody(); // AddMcpServerRequestBody | MCP server registration parameters.

            try
            {
                // Register a custom MCP server
                McpServerWrapper result = apiInstance.AddServer(addMcpServerRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.AddServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Register a custom MCP server
    ApiResponse<McpServerWrapper> response = apiInstance.AddServerWithHttpInfo(addMcpServerRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.AddServerWithHttpInfo: " + e.Message);
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
| **200** | Newly registered MCP server configuration |  -  |
| **400** | Invalid server name, reserved name, duplicate name, incorrect credentials, or invalid endpoint URL |  -  |
| **403** | You don&#39;t have permission to manage MCP servers |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="connectserver"></a>
# **ConnectServer**
> McpServerStatusWrapper ConnectServer (int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody)

Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room containing the MCP server. |  |
| **serverId** | **Guid** | Unique identifier of the MCP server to connect. |  |
| **connectServerRequestBody** | [**ConnectServerRequestBody**](ConnectServerRequestBody.md) | The request body containing additional data necessary for connecting to the server,  such as authentication or operation-specific information. |  |

### Return type

[**McpServerStatusWrapper**](McpServerStatusWrapper.md)

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
    public class ConnectServerExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room containing the MCP server.
            var serverId = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server to connect.
            var connectServerRequestBody = new ConnectServerRequestBody(); // ConnectServerRequestBody | The request body containing additional data necessary for connecting to the server,  such as authentication or operation-specific information.

            try
            {
                // Connect an OAuth-based MCP server in a room
                McpServerStatusWrapper result = apiInstance.ConnectServer(roomId, serverId, connectServerRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.ConnectServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConnectServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Connect an OAuth-based MCP server in a room
    ApiResponse<McpServerStatusWrapper> response = apiInstance.ConnectServerWithHttpInfo(roomId, serverId, connectServerRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.ConnectServerWithHttpInfo: " + e.Message);
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
| **200** | MCP server connection status after authorization |  -  |
| **400** | The provided authorization code is invalid |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room or MCP server connection was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteroomservers"></a>
# **DeleteRoomServers**
> void DeleteRoomServers (int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody)

Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room from which MCP servers will be removed. |  |
| **deleteRoomServersRequestBody** | [**DeleteRoomServersRequestBody**](DeleteRoomServersRequestBody.md) | Server identifiers to remove. |  |

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
    public class DeleteRoomServersExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room from which MCP servers will be removed.
            var deleteRoomServersRequestBody = new DeleteRoomServersRequestBody(); // DeleteRoomServersRequestBody | Server identifiers to remove.

            try
            {
                // Remove MCP servers from a room
                apiInstance.DeleteRoomServers(roomId, deleteRoomServersRequestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.DeleteRoomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRoomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove MCP servers from a room
    apiInstance.DeleteRoomServersWithHttpInfo(roomId, deleteRoomServersRequestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.DeleteRoomServersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | MCP servers were successfully removed from the room |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room with the specified ID was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteserver"></a>
# **DeleteServer**
> void DeleteServer (DeleteServersRequestBody deleteServersRequestBody)

Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteServersRequestBody** | [**DeleteServersRequestBody**](DeleteServersRequestBody.md) | Server identifiers to delete. |  |

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
    public class DeleteServerExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var deleteServersRequestBody = new DeleteServersRequestBody(); // DeleteServersRequestBody | Server identifiers to delete.

            try
            {
                // Delete MCP servers
                apiInstance.DeleteServer(deleteServersRequestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.DeleteServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete MCP servers
    apiInstance.DeleteServerWithHttpInfo(deleteServersRequestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.DeleteServerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | MCP servers were successfully deleted |  -  |
| **403** | You don&#39;t have permission to manage MCP servers |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="disconnectserver"></a>
# **DisconnectServer**
> McpServerStatusWrapper DisconnectServer (int roomId, Guid serverId)

Revokes the current user's OAuth connection to an MCP server within the specified room. After  disconnection, the server's tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members' connections are not affected.  Requires room edit permissions.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room containing the MCP server. |  |
| **serverId** | **Guid** | Unique identifier of the MCP server to disconnect from. |  |

### Return type

[**McpServerStatusWrapper**](McpServerStatusWrapper.md)

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
    public class DisconnectServerExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room containing the MCP server.
            var serverId = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server to disconnect from.

            try
            {
                // Disconnect an MCP server in a room
                McpServerStatusWrapper result = apiInstance.DisconnectServer(roomId, serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.DisconnectServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisconnectServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disconnect an MCP server in a room
    ApiResponse<McpServerStatusWrapper> response = apiInstance.DisconnectServerWithHttpInfo(roomId, serverId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.DisconnectServerWithHttpInfo: " + e.Message);
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
| **200** | MCP server connection status after disconnection |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room or MCP server connection was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getavailableservers"></a>
# **GetAvailableServers**
> McpServerShortArrayWrapper GetAvailableServers (int? startIndex = null, int? count = null)

Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startIndex** | **int?** | The number of items to skip before returning results (zero-based offset). Defaults to 0. | [optional]  |
| **count** | **int?** | The maximum number of items to return per page. Defaults to 100. | [optional]  |

### Return type

[**McpServerShortArrayWrapper**](McpServerShortArrayWrapper.md)

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
    public class GetAvailableServersExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var startIndex = 0;  // int? | The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional) 
            var count = 100;  // int? | The maximum number of items to return per page. Defaults to 100. (optional) 

            try
            {
                // Get available MCP servers
                McpServerShortArrayWrapper result = apiInstance.GetAvailableServers(startIndex, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.GetAvailableServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAvailableServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get available MCP servers
    ApiResponse<McpServerShortArrayWrapper> response = apiInstance.GetAvailableServersWithHttpInfo(startIndex, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.GetAvailableServersWithHttpInfo: " + e.Message);
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
| **200** | Paginated list of active MCP servers available for room assignment |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroomservers"></a>
# **GetRoomServers**
> McpServerStatusArrayWrapper GetRoomServers (int roomId)

Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room's AI chat.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room whose assigned MCP servers are being retrieved. |  |

### Return type

[**McpServerStatusArrayWrapper**](McpServerStatusArrayWrapper.md)

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
    public class GetRoomServersExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room whose assigned MCP servers are being retrieved.

            try
            {
                // Get MCP servers assigned to a room
                McpServerStatusArrayWrapper result = apiInstance.GetRoomServers(roomId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.GetRoomServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MCP servers assigned to a room
    ApiResponse<McpServerStatusArrayWrapper> response = apiInstance.GetRoomServersWithHttpInfo(roomId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.GetRoomServersWithHttpInfo: " + e.Message);
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
| **200** | List of MCP server statuses in the room |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room with the specified ID was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserver"></a>
# **GetServer**
> McpServerShortWrapper GetServer (Guid id)

Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique identifier of the MCP server to retrieve. |  |

### Return type

[**McpServerShortWrapper**](McpServerShortWrapper.md)

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
    public class GetServerExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server to retrieve.

            try
            {
                // Get an MCP server by ID
                McpServerShortWrapper result = apiInstance.GetServer(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.GetServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an MCP server by ID
    ApiResponse<McpServerShortWrapper> response = apiInstance.GetServerWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.GetServerWithHttpInfo: " + e.Message);
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
| **200** | MCP server summary information |  -  |
| **403** | You don&#39;t have permission to manage MCP servers |  -  |
| **404** | The MCP server with the specified ID was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getservers"></a>
# **GetServers**
> McpServerArrayWrapper GetServers (int? startIndex = null, int? count = null)

Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startIndex** | **int?** | The number of items to skip before returning results (zero-based offset). Defaults to 0. | [optional]  |
| **count** | **int?** | The maximum number of items to return per page. Defaults to 100. | [optional]  |

### Return type

[**McpServerArrayWrapper**](McpServerArrayWrapper.md)

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
    public class GetServersExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var startIndex = 0;  // int? | The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional) 
            var count = 100;  // int? | The maximum number of items to return per page. Defaults to 100. (optional) 

            try
            {
                // Get all MCP servers
                McpServerArrayWrapper result = apiInstance.GetServers(startIndex, count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.GetServers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all MCP servers
    ApiResponse<McpServerArrayWrapper> response = apiInstance.GetServersWithHttpInfo(startIndex, count);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.GetServersWithHttpInfo: " + e.Message);
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
| **200** | Paginated list of all registered MCP servers |  -  |
| **403** | You don&#39;t have permission to manage MCP servers |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettools"></a>
# **GetTools**
> McpToolArrayWrapper GetTools (int roomId, Guid serverId)

Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool's enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room's AI chat.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room containing the MCP server. |  |
| **serverId** | **Guid** | Unique identifier of the MCP server whose tools are being retrieved. |  |

### Return type

[**McpToolArrayWrapper**](McpToolArrayWrapper.md)

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
    public class GetToolsExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room containing the MCP server.
            var serverId = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server whose tools are being retrieved.

            try
            {
                // Get MCP server tools in a room
                McpToolArrayWrapper result = apiInstance.GetTools(roomId, serverId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.GetTools: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetToolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MCP server tools in a room
    ApiResponse<McpToolArrayWrapper> response = apiInstance.GetToolsWithHttpInfo(roomId, serverId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.GetToolsWithHttpInfo: " + e.Message);
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
| **200** | List of tools with their enabled/disabled states |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room or MCP server was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setserverstatus"></a>
# **SetServerStatus**
> McpServerWrapper SetServerStatus (Guid id, SetServerStatusRequestBody setServerStatusRequestBody)

Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique identifier of the MCP server whose status is being changed. |  |
| **setServerStatusRequestBody** | [**SetServerStatusRequestBody**](SetServerStatusRequestBody.md) | New status value. |  |

### Return type

[**McpServerWrapper**](McpServerWrapper.md)

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
    public class SetServerStatusExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server whose status is being changed.
            var setServerStatusRequestBody = new SetServerStatusRequestBody(); // SetServerStatusRequestBody | New status value.

            try
            {
                // Enable or disable an MCP server
                McpServerWrapper result = apiInstance.SetServerStatus(id, setServerStatusRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.SetServerStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetServerStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable or disable an MCP server
    ApiResponse<McpServerWrapper> response = apiInstance.SetServerStatusWithHttpInfo(id, setServerStatusRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.SetServerStatusWithHttpInfo: " + e.Message);
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
| **200** | MCP server with the updated status |  -  |
| **403** | You don&#39;t have permission to manage MCP servers |  -  |
| **404** | The MCP server with the specified ID was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settools"></a>
# **SetTools**
> McpToolArrayWrapper SetTools (int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody)

Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomId** | **int** | Identifier of the room containing the MCP server. |  |
| **serverId** | **Guid** | Unique identifier of the MCP server whose tools are being configured. |  |
| **setMcpToolsRequestBody** | [**SetMcpToolsRequestBody**](SetMcpToolsRequestBody.md) | Tool configuration parameters. |  |

### Return type

[**McpToolArrayWrapper**](McpToolArrayWrapper.md)

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
    public class SetToolsExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var roomId = 42;  // int | Identifier of the room containing the MCP server.
            var serverId = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server whose tools are being configured.
            var setMcpToolsRequestBody = new SetMcpToolsRequestBody(); // SetMcpToolsRequestBody | Tool configuration parameters.

            try
            {
                // Configure MCP server tools in a room
                McpToolArrayWrapper result = apiInstance.SetTools(roomId, serverId, setMcpToolsRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.SetTools: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetToolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Configure MCP server tools in a room
    ApiResponse<McpToolArrayWrapper> response = apiInstance.SetToolsWithHttpInfo(roomId, serverId, setMcpToolsRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.SetToolsWithHttpInfo: " + e.Message);
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
| **200** | Complete list of tools with their enabled/disabled states |  -  |
| **403** | You don&#39;t have enough permission to perform the operation |  -  |
| **404** | The room or MCP server was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateserver"></a>
# **UpdateServer**
> McpServerWrapper UpdateServer (Guid id, UpdateServerRequestBody updateServerRequestBody)

Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.

For more information, see [api.onlyoffice.com](https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/).

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Unique identifier of the MCP server to update. |  |
| **updateServerRequestBody** | [**UpdateServerRequestBody**](UpdateServerRequestBody.md) | Updated server configuration fields. |  |

### Return type

[**McpServerWrapper**](McpServerWrapper.md)

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
    public class UpdateServerExample
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
            var apiInstance = new MCPApi(httpClient, config, httpClientHandler);
            var id = 00000000-0000-0000-0000-000000000000;  // Guid | Unique identifier of the MCP server to update.
            var updateServerRequestBody = new UpdateServerRequestBody(); // UpdateServerRequestBody | Updated server configuration fields.

            try
            {
                // Update a custom MCP server
                McpServerWrapper result = apiInstance.UpdateServer(id, updateServerRequestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MCPApi.UpdateServer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateServerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a custom MCP server
    ApiResponse<McpServerWrapper> response = apiInstance.UpdateServerWithHttpInfo(id, updateServerRequestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MCPApi.UpdateServerWithHttpInfo: " + e.Message);
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
| **200** | Updated MCP server configuration |  -  |
| **400** | Invalid server name, reserved name, duplicate name, incorrect credentials, or invalid endpoint URL |  -  |
| **403** | You don&#39;t have permission to manage MCP servers |  -  |
| **404** | The MCP server with the specified ID was not found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

