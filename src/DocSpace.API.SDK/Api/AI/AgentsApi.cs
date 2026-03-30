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


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.AI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateAgent(CreateAgentRequestDto? createAgentRequestDto = default);

        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateAgentWithHttpInfo(CreateAgentRequestDto? createAgentRequestDto = default);
        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper DeleteAgent(int id, DeleteRoomRequest deleteRoomRequest);

        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> DeleteAgentWithHttpInfo(int id, DeleteRoomRequest deleteRoomRequest);
        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper GetAgentInfo(int id);

        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> GetAgentInfoWithHttpInfo(int id);
        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetAgents(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetAgentsWithHttpInfo(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>NewItemsAgentNewItemsArrayWrapper</returns>
        NewItemsAgentNewItemsArrayWrapper GetAgentsNewItems();

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsAgentNewItemsArrayWrapper</returns>
        ApiResponse<NewItemsAgentNewItemsArrayWrapper> GetAgentsNewItemsWithHttpInfo();
        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>FolderIntegerArrayWrapper</returns>
        FolderIntegerArrayWrapper ResetAgentsQuota(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default);

        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerArrayWrapper</returns>
        ApiResponse<FolderIntegerArrayWrapper> ResetAgentsQuotaWithHttpInfo(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default);
        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper UpdateAgent(int id, UpdateRoomRequest updateRoomRequest);

        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> UpdateAgentWithHttpInfo(int id, UpdateRoomRequest updateRoomRequest);
        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>FolderIntegerArrayWrapper</returns>
        FolderIntegerArrayWrapper UpdateAgentsQuota(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default);

        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerArrayWrapper</returns>
        ApiResponse<FolderIntegerArrayWrapper> UpdateAgentsQuotaWithHttpInfo(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> CreateAgentAsync(CreateAgentRequestDto? createAgentRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> CreateAgentWithHttpInfoAsync(CreateAgentRequestDto? createAgentRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        Task<FileOperationWrapper> DeleteAgentAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        Task<ApiResponse<FileOperationWrapper>> DeleteAgentWithHttpInfoAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> GetAgentInfoAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> GetAgentInfoWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetAgentsAsync(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetAgentsWithHttpInfoAsync(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>Task of NewItemsAgentNewItemsArrayWrapper</returns>
        Task<NewItemsAgentNewItemsArrayWrapper> GetAgentsNewItemsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsAgentNewItemsArrayWrapper)</returns>
        Task<ApiResponse<NewItemsAgentNewItemsArrayWrapper>> GetAgentsNewItemsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>Task of FolderIntegerArrayWrapper</returns>
        Task<FolderIntegerArrayWrapper> ResetAgentsQuotaAsync(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<FolderIntegerArrayWrapper>> ResetAgentsQuotaWithHttpInfoAsync(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> UpdateAgentAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> UpdateAgentWithHttpInfoAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>Task of FolderIntegerArrayWrapper</returns>
        Task<FolderIntegerArrayWrapper> UpdateAgentsQuotaAsync(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<FolderIntegerArrayWrapper>> UpdateAgentsQuotaWithHttpInfoAsync(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentsApi : IAgentsApiSync, IAgentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgentsApi : IDisposable, IAgentsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AgentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AgentsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AgentsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AgentsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsApi"/> class.
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
        public AgentsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class using a Configuration object.
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
        public AgentsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AgentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AgentsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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

        public AgentsApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        
        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateAgent(CreateAgentRequestDto? createAgentRequestDto = default)
        {
            var localVarResponse = CreateAgentWithHttpInfo(createAgentRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> CreateAgentWithHttpInfo(CreateAgentRequestDto? createAgentRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createAgentRequestDto != null) localVarRequestOptions.Data = createAgentRequestDto;

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
            var localVarResponse = Client.Post<FolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateAgent", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> CreateAgentAsync(CreateAgentRequestDto? createAgentRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateAgentWithHttpInfoAsync(createAgentRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an ai agent
        /// </summary>
        /// <remarks>
        /// Creates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAgentRequestDto">Request to create a new AI agent room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-agent/">REST API Reference for CreateAgent Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> CreateAgentWithHttpInfoAsync(CreateAgentRequestDto? createAgentRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createAgentRequestDto != null) localVarRequestOptions.Data = createAgentRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateAgent", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper DeleteAgent(int id, DeleteRoomRequest deleteRoomRequest)
        {
            var localVarResponse = DeleteAgentWithHttpInfo(id, deleteRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public ApiResponse<FileOperationWrapper> DeleteAgentWithHttpInfo(int id, DeleteRoomRequest deleteRoomRequest)
        {
            // verify the required parameter 'deleteRoomRequest' is set
            if (deleteRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'deleteRoomRequest' when calling AgentsApi->DeleteAgent");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (deleteRoomRequest != null) localVarRequestOptions.Data = deleteRoomRequest;

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
            var localVarResponse = Client.Delete<FileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteAgent", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async Task<FileOperationWrapper> DeleteAgentAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteAgentWithHttpInfoAsync(id, deleteRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove an ai agent
        /// </summary>
        /// <remarks>
        /// Removes an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-agent/">REST API Reference for DeleteAgent Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async Task<ApiResponse<FileOperationWrapper>> DeleteAgentWithHttpInfoAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'deleteRoomRequest' is set
            if (deleteRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'deleteRoomRequest' when calling AgentsApi->DeleteAgent");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (deleteRoomRequest != null) localVarRequestOptions.Data = deleteRoomRequest;

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<FileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteAgent", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper GetAgentInfo(int id)
        {
            var localVarResponse = GetAgentInfoWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> GetAgentInfoWithHttpInfo(int id)
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
            var localVarResponse = Client.Get<FolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAgentInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> GetAgentInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAgentInfoWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return an ai agent
        /// </summary>
        /// <remarks>
        /// Returns an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agent-info/">REST API Reference for GetAgentInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> GetAgentInfoWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAgentInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetAgents(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetAgentsWithHttpInfo(subjectId, subjectOwnerId, withoutTags, tags, excludeSubject, subjectFilter, quotaFilter, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetAgentsWithHttpInfo(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (subjectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectId", subjectId));
            }
            if (subjectOwnerId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectOwnerId", subjectOwnerId));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (subjectFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectFilter", subjectFilter));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
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
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAgents", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetAgentsAsync(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAgentsWithHttpInfoAsync(subjectId, subjectOwnerId, withoutTags, tags, excludeSubject, subjectFilter, quotaFilter, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get ai agents
        /// </summary>
        /// <remarks>
        /// Get ai agents
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="subjectOwnerId">The filter by room owner ID. (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents/">REST API Reference for GetAgents Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetAgentsWithHttpInfoAsync(string? subjectId = default, string? subjectOwnerId = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (subjectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectId", subjectId));
            }
            if (subjectOwnerId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectOwnerId", subjectOwnerId));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (subjectFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectFilter", subjectFilter));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
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

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAgents", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>NewItemsAgentNewItemsArrayWrapper</returns>
        public NewItemsAgentNewItemsArrayWrapper GetAgentsNewItems()
        {
            var localVarResponse = GetAgentsNewItemsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsAgentNewItemsArrayWrapper</returns>
        public ApiResponse<NewItemsAgentNewItemsArrayWrapper> GetAgentsNewItemsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = Client.Get<NewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAgentsNewItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>Task of NewItemsAgentNewItemsArrayWrapper</returns>
        public async Task<NewItemsAgentNewItemsArrayWrapper> GetAgentsNewItemsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAgentsNewItemsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-agents-new-items/">REST API Reference for GetAgentsNewItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsAgentNewItemsArrayWrapper)</returns>
        public async Task<ApiResponse<NewItemsAgentNewItemsArrayWrapper>> GetAgentsNewItemsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<NewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAgentsNewItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>FolderIntegerArrayWrapper</returns>
        public FolderIntegerArrayWrapper ResetAgentsQuota(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default)
        {
            var localVarResponse = ResetAgentsQuotaWithHttpInfo(updateRoomsRoomIdsRequestDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerArrayWrapper</returns>
        public ApiResponse<FolderIntegerArrayWrapper> ResetAgentsQuotaWithHttpInfo(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateRoomsRoomIdsRequestDtoInteger != null) localVarRequestOptions.Data = updateRoomsRoomIdsRequestDtoInteger;

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
            var localVarResponse = Client.Put<FolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResetAgentsQuota", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>Task of FolderIntegerArrayWrapper</returns>
        public async Task<FolderIntegerArrayWrapper> ResetAgentsQuotaAsync(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ResetAgentsQuotaWithHttpInfoAsync(updateRoomsRoomIdsRequestDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset the AI agents quota limit
        /// </summary>
        /// <remarks>
        /// Resets the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsRoomIdsRequestDtoInteger">The request parameters for updating the rooms. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reset-agents-quota/">REST API Reference for ResetAgentsQuota Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerArrayWrapper>> ResetAgentsQuotaWithHttpInfoAsync(UpdateRoomsRoomIdsRequestDtoInteger? updateRoomsRoomIdsRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateRoomsRoomIdsRequestDtoInteger != null) localVarRequestOptions.Data = updateRoomsRoomIdsRequestDtoInteger;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResetAgentsQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper UpdateAgent(int id, UpdateRoomRequest updateRoomRequest)
        {
            var localVarResponse = UpdateAgentWithHttpInfo(id, updateRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> UpdateAgentWithHttpInfo(int id, UpdateRoomRequest updateRoomRequest)
        {
            // verify the required parameter 'updateRoomRequest' is set
            if (updateRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateRoomRequest' when calling AgentsApi->UpdateAgent");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateRoomRequest != null) localVarRequestOptions.Data = updateRoomRequest;

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
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateAgent", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> UpdateAgentAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateAgentWithHttpInfoAsync(id, updateRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an ai agent
        /// </summary>
        /// <remarks>
        /// Updates an ai agent.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agent/">REST API Reference for UpdateAgent Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> UpdateAgentWithHttpInfoAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateRoomRequest' is set
            if (updateRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateRoomRequest' when calling AgentsApi->UpdateAgent");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateRoomRequest != null) localVarRequestOptions.Data = updateRoomRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateAgent", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>FolderIntegerArrayWrapper</returns>
        public FolderIntegerArrayWrapper UpdateAgentsQuota(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default)
        {
            var localVarResponse = UpdateAgentsQuotaWithHttpInfo(updateRoomsQuotaRequestDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerArrayWrapper</returns>
        public ApiResponse<FolderIntegerArrayWrapper> UpdateAgentsQuotaWithHttpInfo(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateRoomsQuotaRequestDtoInteger != null) localVarRequestOptions.Data = updateRoomsQuotaRequestDtoInteger;

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
            var localVarResponse = Client.Put<FolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateAgentsQuota", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>Task of FolderIntegerArrayWrapper</returns>
        public async Task<FolderIntegerArrayWrapper> UpdateAgentsQuotaAsync(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateAgentsQuotaWithHttpInfoAsync(updateRoomsQuotaRequestDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the AI agent quota limit
        /// </summary>
        /// <remarks>
        /// Changes the quota limit for the AI agents with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateRoomsQuotaRequestDtoInteger">The request parameters for updating the room quota. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-agents-quota/">REST API Reference for UpdateAgentsQuota Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerArrayWrapper>> UpdateAgentsQuotaWithHttpInfoAsync(UpdateRoomsQuotaRequestDtoInteger? updateRoomsQuotaRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateRoomsQuotaRequestDtoInteger != null) localVarRequestOptions.Data = updateRoomsQuotaRequestDtoInteger;

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

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateAgentsQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
