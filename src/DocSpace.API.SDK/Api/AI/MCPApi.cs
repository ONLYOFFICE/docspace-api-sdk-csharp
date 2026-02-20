// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.AI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMCPApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>McpServerStatusArrayWrapper</returns>
        McpServerStatusArrayWrapper AddRoomServers(int roomId, AddRoomServersRequestBody addRoomServersRequestBody);

        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusArrayWrapper</returns>
        ApiResponse<McpServerStatusArrayWrapper> AddRoomServersWithHttpInfo(int roomId, AddRoomServersRequestBody addRoomServersRequestBody);
        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>McpServerWrapper</returns>
        McpServerWrapper AddServer(AddMcpServerRequestBody addMcpServerRequestBody);

        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>ApiResponse of McpServerWrapper</returns>
        ApiResponse<McpServerWrapper> AddServerWithHttpInfo(AddMcpServerRequestBody addMcpServerRequestBody);
        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>McpServerStatusWrapper</returns>
        McpServerStatusWrapper ConnectServer(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody);

        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusWrapper</returns>
        ApiResponse<McpServerStatusWrapper> ConnectServerWithHttpInfo(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody);
        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns></returns>
        void DeleteRoomServers(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody);

        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteRoomServersWithHttpInfo(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody);
        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns></returns>
        void DeleteServer(DeleteServersRequestBody deleteServersRequestBody);

        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteServerWithHttpInfo(DeleteServersRequestBody deleteServersRequestBody);
        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>McpServerStatusWrapper</returns>
        McpServerStatusWrapper DisconnectServer(int roomId, Guid serverId);

        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusWrapper</returns>
        ApiResponse<McpServerStatusWrapper> DisconnectServerWithHttpInfo(int roomId, Guid serverId);
        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>McpServerShortArrayWrapper</returns>
        McpServerShortArrayWrapper GetAvailableServers(int? startIndex = default, int? count = default);

        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>ApiResponse of McpServerShortArrayWrapper</returns>
        ApiResponse<McpServerShortArrayWrapper> GetAvailableServersWithHttpInfo(int? startIndex = default, int? count = default);
        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>McpServerStatusArrayWrapper</returns>
        McpServerStatusArrayWrapper GetRoomServers(int roomId);

        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusArrayWrapper</returns>
        ApiResponse<McpServerStatusArrayWrapper> GetRoomServersWithHttpInfo(int roomId);
        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>McpServerShortWrapper</returns>
        McpServerShortWrapper GetServer(Guid id);

        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>ApiResponse of McpServerShortWrapper</returns>
        ApiResponse<McpServerShortWrapper> GetServerWithHttpInfo(Guid id);
        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>McpServerArrayWrapper</returns>
        McpServerArrayWrapper GetServers(int? startIndex = default, int? count = default);

        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>ApiResponse of McpServerArrayWrapper</returns>
        ApiResponse<McpServerArrayWrapper> GetServersWithHttpInfo(int? startIndex = default, int? count = default);
        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>McpToolArrayWrapper</returns>
        McpToolArrayWrapper GetTools(int roomId, Guid serverId);

        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>ApiResponse of McpToolArrayWrapper</returns>
        ApiResponse<McpToolArrayWrapper> GetToolsWithHttpInfo(int roomId, Guid serverId);
        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>McpServerWrapper</returns>
        McpServerWrapper SetServerStatus(Guid id, SetServerStatusRequestBody setServerStatusRequestBody);

        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>ApiResponse of McpServerWrapper</returns>
        ApiResponse<McpServerWrapper> SetServerStatusWithHttpInfo(Guid id, SetServerStatusRequestBody setServerStatusRequestBody);
        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>McpToolArrayWrapper</returns>
        McpToolArrayWrapper SetTools(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody);

        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>ApiResponse of McpToolArrayWrapper</returns>
        ApiResponse<McpToolArrayWrapper> SetToolsWithHttpInfo(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody);
        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>McpServerWrapper</returns>
        McpServerWrapper UpdateServer(Guid id, UpdateServerRequestBody updateServerRequestBody);

        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>ApiResponse of McpServerWrapper</returns>
        ApiResponse<McpServerWrapper> UpdateServerWithHttpInfo(Guid id, UpdateServerRequestBody updateServerRequestBody);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMCPApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>Task of McpServerStatusArrayWrapper</returns>
        Task<McpServerStatusArrayWrapper> AddRoomServersAsync(int roomId, AddRoomServersRequestBody addRoomServersRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusArrayWrapper)</returns>
        Task<ApiResponse<McpServerStatusArrayWrapper>> AddRoomServersWithHttpInfoAsync(int roomId, AddRoomServersRequestBody addRoomServersRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>Task of McpServerWrapper</returns>
        Task<McpServerWrapper> AddServerAsync(AddMcpServerRequestBody addMcpServerRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerWrapper)</returns>
        Task<ApiResponse<McpServerWrapper>> AddServerWithHttpInfoAsync(AddMcpServerRequestBody addMcpServerRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>Task of McpServerStatusWrapper</returns>
        Task<McpServerStatusWrapper> ConnectServerAsync(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusWrapper)</returns>
        Task<ApiResponse<McpServerStatusWrapper>> ConnectServerWithHttpInfoAsync(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteRoomServersAsync(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteRoomServersWithHttpInfoAsync(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteServerAsync(DeleteServersRequestBody deleteServersRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteServerWithHttpInfoAsync(DeleteServersRequestBody deleteServersRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>Task of McpServerStatusWrapper</returns>
        Task<McpServerStatusWrapper> DisconnectServerAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusWrapper)</returns>
        Task<ApiResponse<McpServerStatusWrapper>> DisconnectServerWithHttpInfoAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>Task of McpServerShortArrayWrapper</returns>
        Task<McpServerShortArrayWrapper> GetAvailableServersAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerShortArrayWrapper)</returns>
        Task<ApiResponse<McpServerShortArrayWrapper>> GetAvailableServersWithHttpInfoAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>Task of McpServerStatusArrayWrapper</returns>
        Task<McpServerStatusArrayWrapper> GetRoomServersAsync(int roomId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusArrayWrapper)</returns>
        Task<ApiResponse<McpServerStatusArrayWrapper>> GetRoomServersWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>Task of McpServerShortWrapper</returns>
        Task<McpServerShortWrapper> GetServerAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerShortWrapper)</returns>
        Task<ApiResponse<McpServerShortWrapper>> GetServerWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>Task of McpServerArrayWrapper</returns>
        Task<McpServerArrayWrapper> GetServersAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerArrayWrapper)</returns>
        Task<ApiResponse<McpServerArrayWrapper>> GetServersWithHttpInfoAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>Task of McpToolArrayWrapper</returns>
        Task<McpToolArrayWrapper> GetToolsAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>Task of ApiResponse (McpToolArrayWrapper)</returns>
        Task<ApiResponse<McpToolArrayWrapper>> GetToolsWithHttpInfoAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>Task of McpServerWrapper</returns>
        Task<McpServerWrapper> SetServerStatusAsync(Guid id, SetServerStatusRequestBody setServerStatusRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerWrapper)</returns>
        Task<ApiResponse<McpServerWrapper>> SetServerStatusWithHttpInfoAsync(Guid id, SetServerStatusRequestBody setServerStatusRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>Task of McpToolArrayWrapper</returns>
        Task<McpToolArrayWrapper> SetToolsAsync(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>Task of ApiResponse (McpToolArrayWrapper)</returns>
        Task<ApiResponse<McpToolArrayWrapper>> SetToolsWithHttpInfoAsync(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>Task of McpServerWrapper</returns>
        Task<McpServerWrapper> UpdateServerAsync(Guid id, UpdateServerRequestBody updateServerRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerWrapper)</returns>
        Task<ApiResponse<McpServerWrapper>> UpdateServerWithHttpInfoAsync(Guid id, UpdateServerRequestBody updateServerRequestBody, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMCPApi : IMCPApiSync, IMCPApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MCPApi : IDisposable, IMCPApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public MCPApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public MCPApi(string basePath)
        {
            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public MCPApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MCPApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MCPApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class using a Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public MCPApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public MCPApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            ApiClient.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value; 
        }

        private string? _fields;

        /// <summary>
        /// Specifies which fields should be included in the API response.
        /// </summary>
        /// <param name="fields">A comma-separated list of field paths to include in the response</param>
        /// <returns></returns>

        public MCPApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        
        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>McpServerStatusArrayWrapper</returns>
        public McpServerStatusArrayWrapper AddRoomServers(int roomId, AddRoomServersRequestBody addRoomServersRequestBody)
        {
            var localVarResponse = AddRoomServersWithHttpInfo(roomId, addRoomServersRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusArrayWrapper</returns>
        public ApiResponse<McpServerStatusArrayWrapper> AddRoomServersWithHttpInfo(int roomId, AddRoomServersRequestBody addRoomServersRequestBody)
        {
            // verify the required parameter 'addRoomServersRequestBody' is set
            if (addRoomServersRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'addRoomServersRequestBody' when calling MCPApi->AddRoomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (addRoomServersRequestBody != null) localVarRequestOptions.Data = addRoomServersRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<McpServerStatusArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddRoomServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>Task of McpServerStatusArrayWrapper</returns>
        public async Task<McpServerStatusArrayWrapper> AddRoomServersAsync(int roomId, AddRoomServersRequestBody addRoomServersRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddRoomServersWithHttpInfoAsync(roomId, addRoomServersRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign MCP servers to a room
        /// </summary>
        /// <remarks>
        /// Associates one or more MCP servers with a specific room, making them available for AI chat sessions  within that room. A maximum of 5 MCP servers can be assigned to a single room. If OAuth-based servers  are included, each room member will need to individually authorize their connection.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room to which MCP servers will be assigned.</param>
        /// <param name="addRoomServersRequestBody">Server identifiers to assign.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-servers/">REST API Reference for AddRoomServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusArrayWrapper)</returns>
        public async Task<ApiResponse<McpServerStatusArrayWrapper>> AddRoomServersWithHttpInfoAsync(int roomId, AddRoomServersRequestBody addRoomServersRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'addRoomServersRequestBody' is set
            if (addRoomServersRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'addRoomServersRequestBody' when calling MCPApi->AddRoomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (addRoomServersRequestBody != null) localVarRequestOptions.Data = addRoomServersRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<McpServerStatusArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddRoomServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>McpServerWrapper</returns>
        public McpServerWrapper AddServer(AddMcpServerRequestBody addMcpServerRequestBody)
        {
            var localVarResponse = AddServerWithHttpInfo(addMcpServerRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>ApiResponse of McpServerWrapper</returns>
        public ApiResponse<McpServerWrapper> AddServerWithHttpInfo(AddMcpServerRequestBody addMcpServerRequestBody)
        {
            // verify the required parameter 'addMcpServerRequestBody' is set
            if (addMcpServerRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'addMcpServerRequestBody' when calling MCPApi->AddServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (addMcpServerRequestBody != null) localVarRequestOptions.Data = addMcpServerRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<McpServerWrapper>("/api/2.0/ai/servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>Task of McpServerWrapper</returns>
        public async Task<McpServerWrapper> AddServerAsync(AddMcpServerRequestBody addMcpServerRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddServerWithHttpInfoAsync(addMcpServerRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Register a custom MCP server
        /// </summary>
        /// <remarks>
        /// Registers a new custom MCP (Model Context Protocol) server for the current tenant.  The system validates the server name (only letters, numbers, underscores, and hyphens are allowed),  checks that it is not reserved or already taken, and then attempts to connect to the provided endpoint  to verify reachability and credentials before persisting the configuration.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addMcpServerRequestBody">MCP server registration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-server/">REST API Reference for AddServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerWrapper)</returns>
        public async Task<ApiResponse<McpServerWrapper>> AddServerWithHttpInfoAsync(AddMcpServerRequestBody addMcpServerRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'addMcpServerRequestBody' is set
            if (addMcpServerRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'addMcpServerRequestBody' when calling MCPApi->AddServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (addMcpServerRequestBody != null) localVarRequestOptions.Data = addMcpServerRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<McpServerWrapper>("/api/2.0/ai/servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>McpServerStatusWrapper</returns>
        public McpServerStatusWrapper ConnectServer(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody)
        {
            var localVarResponse = ConnectServerWithHttpInfo(roomId, serverId, connectServerRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusWrapper</returns>
        public ApiResponse<McpServerStatusWrapper> ConnectServerWithHttpInfo(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody)
        {
            // verify the required parameter 'connectServerRequestBody' is set
            if (connectServerRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'connectServerRequestBody' when calling MCPApi->ConnectServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter
            if (connectServerRequestBody != null) localVarRequestOptions.Data = connectServerRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<McpServerStatusWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/connect", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ConnectServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>Task of McpServerStatusWrapper</returns>
        public async Task<McpServerStatusWrapper> ConnectServerAsync(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ConnectServerWithHttpInfoAsync(roomId, serverId, connectServerRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Connect an OAuth-based MCP server in a room
        /// </summary>
        /// <remarks>
        /// Completes the OAuth authorization flow for an MCP server within a specific room on behalf of the  current user. The authorization code obtained from the OAuth provider must be passed in the request body.  Upon successful token exchange, the system verifies connectivity to the server and stores  the credentials for the current user. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to connect.</param>
        /// <param name="connectServerRequestBody">OAuth authorization parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/connect-server/">REST API Reference for ConnectServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusWrapper)</returns>
        public async Task<ApiResponse<McpServerStatusWrapper>> ConnectServerWithHttpInfoAsync(int roomId, Guid serverId, ConnectServerRequestBody connectServerRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'connectServerRequestBody' is set
            if (connectServerRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'connectServerRequestBody' when calling MCPApi->ConnectServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter
            if (connectServerRequestBody != null) localVarRequestOptions.Data = connectServerRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<McpServerStatusWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/connect", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ConnectServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns></returns>
        public void DeleteRoomServers(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody)
        {
            DeleteRoomServersWithHttpInfo(roomId, deleteRoomServersRequestBody);
        }

        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteRoomServersWithHttpInfo(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody)
        {
            // verify the required parameter 'deleteRoomServersRequestBody' is set
            if (deleteRoomServersRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'deleteRoomServersRequestBody' when calling MCPApi->DeleteRoomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (deleteRoomServersRequestBody != null) localVarRequestOptions.Data = deleteRoomServersRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/ai/rooms/{roomId}/servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoomServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteRoomServersAsync(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody, CancellationToken cancellationToken = default)
        {
            await DeleteRoomServersWithHttpInfoAsync(roomId, deleteRoomServersRequestBody, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Remove MCP servers from a room
        /// </summary>
        /// <remarks>
        /// Detaches one or more MCP servers from the specified room. After removal, the servers will no longer  be available in AI chat sessions within this room. Existing connections and tool configurations for  the removed servers are also cleaned up. Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room from which MCP servers will be removed.</param>
        /// <param name="deleteRoomServersRequestBody">Server identifiers to remove.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-servers/">REST API Reference for DeleteRoomServers Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteRoomServersWithHttpInfoAsync(int roomId, DeleteRoomServersRequestBody deleteRoomServersRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'deleteRoomServersRequestBody' is set
            if (deleteRoomServersRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'deleteRoomServersRequestBody' when calling MCPApi->DeleteRoomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (deleteRoomServersRequestBody != null) localVarRequestOptions.Data = deleteRoomServersRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/ai/rooms/{roomId}/servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoomServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns></returns>
        public void DeleteServer(DeleteServersRequestBody deleteServersRequestBody)
        {
            DeleteServerWithHttpInfo(deleteServersRequestBody);
        }

        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteServerWithHttpInfo(DeleteServersRequestBody deleteServersRequestBody)
        {
            // verify the required parameter 'deleteServersRequestBody' is set
            if (deleteServersRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'deleteServersRequestBody' when calling MCPApi->DeleteServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteServersRequestBody != null) localVarRequestOptions.Data = deleteServersRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/ai/servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteServerAsync(DeleteServersRequestBody deleteServersRequestBody, CancellationToken cancellationToken = default)
        {
            await DeleteServerWithHttpInfoAsync(deleteServersRequestBody, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete MCP servers
        /// </summary>
        /// <remarks>
        /// Permanently removes one or more MCP servers from the current tenant by their IDs.  All room associations and connection data for the deleted servers are also cleaned up.  This action is irreversible. Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteServersRequestBody">Server identifiers to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-server/">REST API Reference for DeleteServer Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteServerWithHttpInfoAsync(DeleteServersRequestBody deleteServersRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'deleteServersRequestBody' is set
            if (deleteServersRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'deleteServersRequestBody' when calling MCPApi->DeleteServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteServersRequestBody != null) localVarRequestOptions.Data = deleteServersRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/ai/servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>McpServerStatusWrapper</returns>
        public McpServerStatusWrapper DisconnectServer(int roomId, Guid serverId)
        {
            var localVarResponse = DisconnectServerWithHttpInfo(roomId, serverId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusWrapper</returns>
        public ApiResponse<McpServerStatusWrapper> DisconnectServerWithHttpInfo(int roomId, Guid serverId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<McpServerStatusWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/disconnect", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DisconnectServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>Task of McpServerStatusWrapper</returns>
        public async Task<McpServerStatusWrapper> DisconnectServerAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DisconnectServerWithHttpInfoAsync(roomId, serverId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Disconnect an MCP server in a room
        /// </summary>
        /// <remarks>
        /// Revokes the current user&#39;s OAuth connection to an MCP server within the specified room. After  disconnection, the server&#39;s tools will no longer be available to this user in AI chat sessions  until they re-authorize. Other room members&#39; connections are not affected.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server to disconnect from.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/disconnect-server/">REST API Reference for DisconnectServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusWrapper)</returns>
        public async Task<ApiResponse<McpServerStatusWrapper>> DisconnectServerWithHttpInfoAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<McpServerStatusWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/disconnect", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DisconnectServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>McpServerShortArrayWrapper</returns>
        public McpServerShortArrayWrapper GetAvailableServers(int? startIndex = default, int? count = default)
        {
            var localVarResponse = GetAvailableServersWithHttpInfo(startIndex, count);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>ApiResponse of McpServerShortArrayWrapper</returns>
        public ApiResponse<McpServerShortArrayWrapper> GetAvailableServersWithHttpInfo(int? startIndex = default, int? count = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<McpServerShortArrayWrapper>("/api/2.0/ai/servers/available", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAvailableServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>Task of McpServerShortArrayWrapper</returns>
        public async Task<McpServerShortArrayWrapper> GetAvailableServersAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAvailableServersWithHttpInfoAsync(startIndex, count, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get available MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of MCP servers that are currently active (enabled) and available for  assignment to rooms. Only servers in the enabled state are included. Each entry contains a compact  summary with the server name, type, icon, and status. Supports pagination via startIndex and count.  The total count of available servers is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-available-servers/">REST API Reference for GetAvailableServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerShortArrayWrapper)</returns>
        public async Task<ApiResponse<McpServerShortArrayWrapper>> GetAvailableServersWithHttpInfoAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<McpServerShortArrayWrapper>("/api/2.0/ai/servers/available", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAvailableServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>McpServerStatusArrayWrapper</returns>
        public McpServerStatusArrayWrapper GetRoomServers(int roomId)
        {
            var localVarResponse = GetRoomServersWithHttpInfo(roomId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>ApiResponse of McpServerStatusArrayWrapper</returns>
        public ApiResponse<McpServerStatusArrayWrapper> GetRoomServersWithHttpInfo(int roomId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<McpServerStatusArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>Task of McpServerStatusArrayWrapper</returns>
        public async Task<McpServerStatusArrayWrapper> GetRoomServersAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomServersWithHttpInfoAsync(roomId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get MCP servers assigned to a room
        /// </summary>
        /// <remarks>
        /// Returns the list of MCP servers currently assigned to the specified room along with their connection  statuses for the current user. For OAuth-based servers, the connection status reflects whether the  current user has completed authorization. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room whose assigned MCP servers are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-servers/">REST API Reference for GetRoomServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerStatusArrayWrapper)</returns>
        public async Task<ApiResponse<McpServerStatusArrayWrapper>> GetRoomServersWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<McpServerStatusArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>McpServerShortWrapper</returns>
        public McpServerShortWrapper GetServer(Guid id)
        {
            var localVarResponse = GetServerWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>ApiResponse of McpServerShortWrapper</returns>
        public ApiResponse<McpServerShortWrapper> GetServerWithHttpInfo(Guid id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<McpServerShortWrapper>("/api/2.0/ai/servers/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>Task of McpServerShortWrapper</returns>
        public async Task<McpServerShortWrapper> GetServerAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetServerWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an MCP server by ID
        /// </summary>
        /// <remarks>
        /// Retrieves a summary view of a single MCP server by its unique identifier, including its name,  type, enabled state, and icon. This endpoint returns a compact representation without  sensitive details such as endpoint URL or authentication headers.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-server/">REST API Reference for GetServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerShortWrapper)</returns>
        public async Task<ApiResponse<McpServerShortWrapper>> GetServerWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<McpServerShortWrapper>("/api/2.0/ai/servers/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>McpServerArrayWrapper</returns>
        public McpServerArrayWrapper GetServers(int? startIndex = default, int? count = default)
        {
            var localVarResponse = GetServersWithHttpInfo(startIndex, count);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>ApiResponse of McpServerArrayWrapper</returns>
        public ApiResponse<McpServerArrayWrapper> GetServersWithHttpInfo(int? startIndex = default, int? count = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<McpServerArrayWrapper>("/api/2.0/ai/servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>Task of McpServerArrayWrapper</returns>
        public async Task<McpServerArrayWrapper> GetServersAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetServersWithHttpInfoAsync(startIndex, count, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all MCP servers
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all MCP servers registered for the current tenant, including both  enabled and disabled servers. Each entry contains the full configuration (endpoint, headers,  icon, type, and status). Supports pagination via the startIndex and count query parameters.  The total number of servers is included in the response metadata.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-servers/">REST API Reference for GetServers Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerArrayWrapper)</returns>
        public async Task<ApiResponse<McpServerArrayWrapper>> GetServersWithHttpInfoAsync(int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<McpServerArrayWrapper>("/api/2.0/ai/servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>McpToolArrayWrapper</returns>
        public McpToolArrayWrapper GetTools(int roomId, Guid serverId)
        {
            var localVarResponse = GetToolsWithHttpInfo(roomId, serverId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>ApiResponse of McpToolArrayWrapper</returns>
        public ApiResponse<McpToolArrayWrapper> GetToolsWithHttpInfo(int roomId, Guid serverId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<McpToolArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/tools", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTools", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>Task of McpToolArrayWrapper</returns>
        public async Task<McpToolArrayWrapper> GetToolsAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetToolsWithHttpInfoAsync(roomId, serverId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Retrieves the full list of tools exposed by an MCP server within the context of a specific room,  along with each tool&#39;s enabled or disabled state. Disabled tools will not be invoked during  AI chat sessions in this room. Requires access to the room&#39;s AI chat.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-tools/">REST API Reference for GetTools Operation</seealso>
        /// <returns>Task of ApiResponse (McpToolArrayWrapper)</returns>
        public async Task<ApiResponse<McpToolArrayWrapper>> GetToolsWithHttpInfoAsync(int roomId, Guid serverId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<McpToolArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/tools", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetTools", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>McpServerWrapper</returns>
        public McpServerWrapper SetServerStatus(Guid id, SetServerStatusRequestBody setServerStatusRequestBody)
        {
            var localVarResponse = SetServerStatusWithHttpInfo(id, setServerStatusRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>ApiResponse of McpServerWrapper</returns>
        public ApiResponse<McpServerWrapper> SetServerStatusWithHttpInfo(Guid id, SetServerStatusRequestBody setServerStatusRequestBody)
        {
            // verify the required parameter 'setServerStatusRequestBody' is set
            if (setServerStatusRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setServerStatusRequestBody' when calling MCPApi->SetServerStatus");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (setServerStatusRequestBody != null) localVarRequestOptions.Data = setServerStatusRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<McpServerWrapper>("/api/2.0/ai/servers/{id}/status", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetServerStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>Task of McpServerWrapper</returns>
        public async Task<McpServerWrapper> SetServerStatusAsync(Guid id, SetServerStatusRequestBody setServerStatusRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetServerStatusWithHttpInfoAsync(id, setServerStatusRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Enable or disable an MCP server
        /// </summary>
        /// <remarks>
        /// Toggles the enabled/disabled state of an MCP server. When a server is disabled, it becomes  unavailable for assignment to rooms and will not be used during AI chat sessions.  Enabling a previously disabled server restores its availability across the tenant.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server whose status is being changed.</param>
        /// <param name="setServerStatusRequestBody">New status value.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-server-status/">REST API Reference for SetServerStatus Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerWrapper)</returns>
        public async Task<ApiResponse<McpServerWrapper>> SetServerStatusWithHttpInfoAsync(Guid id, SetServerStatusRequestBody setServerStatusRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setServerStatusRequestBody' is set
            if (setServerStatusRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setServerStatusRequestBody' when calling MCPApi->SetServerStatus");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (setServerStatusRequestBody != null) localVarRequestOptions.Data = setServerStatusRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<McpServerWrapper>("/api/2.0/ai/servers/{id}/status", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetServerStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>McpToolArrayWrapper</returns>
        public McpToolArrayWrapper SetTools(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody)
        {
            var localVarResponse = SetToolsWithHttpInfo(roomId, serverId, setMcpToolsRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>ApiResponse of McpToolArrayWrapper</returns>
        public ApiResponse<McpToolArrayWrapper> SetToolsWithHttpInfo(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody)
        {
            // verify the required parameter 'setMcpToolsRequestBody' is set
            if (setMcpToolsRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setMcpToolsRequestBody' when calling MCPApi->SetTools");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter
            if (setMcpToolsRequestBody != null) localVarRequestOptions.Data = setMcpToolsRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<McpToolArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/tools", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetTools", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>Task of McpToolArrayWrapper</returns>
        public async Task<McpToolArrayWrapper> SetToolsAsync(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetToolsWithHttpInfoAsync(roomId, serverId, setMcpToolsRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure MCP server tools in a room
        /// </summary>
        /// <remarks>
        /// Updates the set of disabled tools for an MCP server within a specific room. Pass a list of tool names  that should be disabled — all other tools exposed by the server will remain enabled. This allows  room administrators to restrict which MCP capabilities are available during AI chat sessions.  Requires room edit permissions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">Identifier of the room containing the MCP server.</param>
        /// <param name="serverId">Unique identifier of the MCP server whose tools are being configured.</param>
        /// <param name="setMcpToolsRequestBody">Tool configuration parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-tools/">REST API Reference for SetTools Operation</seealso>
        /// <returns>Task of ApiResponse (McpToolArrayWrapper)</returns>
        public async Task<ApiResponse<McpToolArrayWrapper>> SetToolsWithHttpInfoAsync(int roomId, Guid serverId, SetMcpToolsRequestBody setMcpToolsRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setMcpToolsRequestBody' is set
            if (setMcpToolsRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setMcpToolsRequestBody' when calling MCPApi->SetTools");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            localVarRequestOptions.PathParameters.Add("serverId", ClientUtils.ParameterToString(serverId)); // path parameter
            if (setMcpToolsRequestBody != null) localVarRequestOptions.Data = setMcpToolsRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<McpToolArrayWrapper>("/api/2.0/ai/rooms/{roomId}/servers/{serverId}/tools", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetTools", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>McpServerWrapper</returns>
        public McpServerWrapper UpdateServer(Guid id, UpdateServerRequestBody updateServerRequestBody)
        {
            var localVarResponse = UpdateServerWithHttpInfo(id, updateServerRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>ApiResponse of McpServerWrapper</returns>
        public ApiResponse<McpServerWrapper> UpdateServerWithHttpInfo(Guid id, UpdateServerRequestBody updateServerRequestBody)
        {
            // verify the required parameter 'updateServerRequestBody' is set
            if (updateServerRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'updateServerRequestBody' when calling MCPApi->UpdateServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateServerRequestBody != null) localVarRequestOptions.Data = updateServerRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<McpServerWrapper>("/api/2.0/ai/servers/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>Task of McpServerWrapper</returns>
        public async Task<McpServerWrapper> UpdateServerAsync(Guid id, UpdateServerRequestBody updateServerRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateServerWithHttpInfoAsync(id, updateServerRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a custom MCP server
        /// </summary>
        /// <remarks>
        /// Updates the configuration of an existing custom MCP server identified by its unique ID.  Any combination of fields (name, description, endpoint, headers, icon) can be updated in a single request.  If the endpoint or headers are changed, the system re-validates connectivity by attempting to reach  the new endpoint before saving. Name uniqueness and format rules are enforced on every update.  Requires DocSpace administrator privileges.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Unique identifier of the MCP server to update.</param>
        /// <param name="updateServerRequestBody">Updated server configuration fields.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-server/">REST API Reference for UpdateServer Operation</seealso>
        /// <returns>Task of ApiResponse (McpServerWrapper)</returns>
        public async Task<ApiResponse<McpServerWrapper>> UpdateServerWithHttpInfoAsync(Guid id, UpdateServerRequestBody updateServerRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateServerRequestBody' is set
            if (updateServerRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'updateServerRequestBody' when calling MCPApi->UpdateServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateServerRequestBody != null) localVarRequestOptions.Data = updateServerRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<McpServerWrapper>("/api/2.0/ai/servers/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
