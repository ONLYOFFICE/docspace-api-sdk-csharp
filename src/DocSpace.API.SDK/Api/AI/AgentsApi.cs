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
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        AiFolderIntegerWrapper AiAgentsCreate(AiAgentsCreateRequest aiAgentsCreateRequest);

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        ApiResponse<AiFolderIntegerWrapper> AiAgentsCreateWithHttpInfo(AiAgentsCreateRequest aiAgentsCreateRequest);
        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>AiFileOperationWrapper</returns>
        AiFileOperationWrapper AiAgentsDelete(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest);

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>ApiResponse of AiFileOperationWrapper</returns>
        ApiResponse<AiFileOperationWrapper> AiAgentsDeleteWithHttpInfo(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest);
        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>AiAgentsGet200Response</returns>
        AiAgentsGet200Response AiAgentsGet(string id);

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>ApiResponse of AiAgentsGet200Response</returns>
        ApiResponse<AiAgentsGet200Response> AiAgentsGetWithHttpInfo(string id);
        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>AiFolderContentIntegerWrapper</returns>
        AiFolderContentIntegerWrapper AiAgentsList(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default);

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>ApiResponse of AiFolderContentIntegerWrapper</returns>
        ApiResponse<AiFolderContentIntegerWrapper> AiAgentsListWithHttpInfo(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default);
        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>AiNewItemsAgentNewItemsArrayWrapper</returns>
        AiNewItemsAgentNewItemsArrayWrapper AiAgentsNews();

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>ApiResponse of AiNewItemsAgentNewItemsArrayWrapper</returns>
        ApiResponse<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsWithHttpInfo();
        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        AiFolderIntegerArrayWrapper AiAgentsResetQuota(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest);

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaWithHttpInfo(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest);
        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        AiFolderIntegerWrapper AiAgentsUpdate(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest);

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        ApiResponse<AiFolderIntegerWrapper> AiAgentsUpdateWithHttpInfo(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest);
        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        AiFolderIntegerArrayWrapper AiAgentsUpdateQuota(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest);

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaWithHttpInfo(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        Task<AiFolderIntegerWrapper> AiAgentsCreateAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsCreateWithHttpInfoAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of AiFileOperationWrapper</returns>
        Task<AiFileOperationWrapper> AiAgentsDeleteAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiFileOperationWrapper)</returns>
        Task<ApiResponse<AiFileOperationWrapper>> AiAgentsDeleteWithHttpInfoAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of AiAgentsGet200Response</returns>
        Task<AiAgentsGet200Response> AiAgentsGetAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiAgentsGet200Response)</returns>
        Task<ApiResponse<AiAgentsGet200Response>> AiAgentsGetWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of AiFolderContentIntegerWrapper</returns>
        Task<AiFolderContentIntegerWrapper> AiAgentsListAsync(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderContentIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderContentIntegerWrapper>> AiAgentsListWithHttpInfoAsync(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of AiNewItemsAgentNewItemsArrayWrapper</returns>
        Task<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of ApiResponse (AiNewItemsAgentNewItemsArrayWrapper)</returns>
        Task<ApiResponse<AiNewItemsAgentNewItemsArrayWrapper>> AiAgentsNewsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        Task<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsResetQuotaWithHttpInfoAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        Task<AiFolderIntegerWrapper> AiAgentsUpdateAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsUpdateWithHttpInfoAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        Task<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsUpdateQuotaWithHttpInfoAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default);
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
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        public AiFolderIntegerWrapper AiAgentsCreate(AiAgentsCreateRequest aiAgentsCreateRequest)
        {
            var localVarResponse = AiAgentsCreateWithHttpInfo(aiAgentsCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        public ApiResponse<AiFolderIntegerWrapper> AiAgentsCreateWithHttpInfo(AiAgentsCreateRequest aiAgentsCreateRequest)
        {
            // verify the required parameter 'aiAgentsCreateRequest' is set
            if (aiAgentsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsCreateRequest' when calling AgentsApi->AiAgentsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsCreateRequest != null) localVarRequestOptions.Data = aiAgentsCreateRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiFolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsCreate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        public async Task<AiFolderIntegerWrapper> AiAgentsCreateAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsCreateWithHttpInfoAsync(aiAgentsCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an agent
        /// </summary>
        /// <remarks>
        /// Creates an AI agent room and binds a model to it, in that order. `profileId` is required, has to be a UUID, has to name an existing profile, and that profile has to support chat - an image-only model is refused here rather than failing on every later request. `prompt` is required and is stored on the room as its standing instruction with any markup stripped, so it cannot round-trip HTML into another user's reply. The two steps are not atomic: when the room is created but the model binding fails, the call reports an error and the room is left behind, so re-bind it with `PUT api/2.0/ai/agents/{id}` rather than creating a second one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-create/">REST API Reference for AiAgentsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsCreateWithHttpInfoAsync(AiAgentsCreateRequest aiAgentsCreateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAgentsCreateRequest' is set
            if (aiAgentsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsCreateRequest' when calling AgentsApi->AiAgentsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsCreateRequest != null) localVarRequestOptions.Data = aiAgentsCreateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiFolderIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsCreate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>AiFileOperationWrapper</returns>
        public AiFileOperationWrapper AiAgentsDelete(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest)
        {
            var localVarResponse = AiAgentsDeleteWithHttpInfo(id, aiAgentsDeleteRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>ApiResponse of AiFileOperationWrapper</returns>
        public ApiResponse<AiFileOperationWrapper> AiAgentsDeleteWithHttpInfo(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsDelete");

            // verify the required parameter 'aiAgentsDeleteRequest' is set
            if (aiAgentsDeleteRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsDeleteRequest' when calling AgentsApi->AiAgentsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsDeleteRequest != null) localVarRequestOptions.Data = aiAgentsDeleteRequest;


            // make the HTTP request
            var localVarResponse = Client.Delete<AiFileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsDelete", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of AiFileOperationWrapper</returns>
        public async Task<AiFileOperationWrapper> AiAgentsDeleteAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsDeleteWithHttpInfoAsync(id, aiAgentsDeleteRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an agent
        /// </summary>
        /// <remarks>
        /// Deletes an AI agent room. The ID has to be the room's integer identifier, and the body is forwarded to the DocSpace AI service unchanged, so it accepts the same options as deleting an ordinary room - `deleteAfter` among them. Deletion is asynchronous there: the answer is a file-operation payload to poll, not a completed result. The agent's model binding is deliberately left behind, because the upstream assignment API has no per-entry delete, so an orphaned assignment row survives the room.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsDeleteRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-delete/">REST API Reference for AiAgentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiFileOperationWrapper)</returns>
        public async Task<ApiResponse<AiFileOperationWrapper>> AiAgentsDeleteWithHttpInfoAsync(string id, AiAgentsDeleteRequest aiAgentsDeleteRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsDelete");

            // verify the required parameter 'aiAgentsDeleteRequest' is set
            if (aiAgentsDeleteRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsDeleteRequest' when calling AgentsApi->AiAgentsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsDeleteRequest != null) localVarRequestOptions.Data = aiAgentsDeleteRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiFileOperationWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>AiAgentsGet200Response</returns>
        public AiAgentsGet200Response AiAgentsGet(string id)
        {
            var localVarResponse = AiAgentsGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>ApiResponse of AiAgentsGet200Response</returns>
        public ApiResponse<AiAgentsGet200Response> AiAgentsGetWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsGet");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<AiAgentsGet200Response>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsGet", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of AiAgentsGet200Response</returns>
        public async Task<AiAgentsGet200Response> AiAgentsGetAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsGetWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an agent
        /// </summary>
        /// <remarks>
        /// Returns one AI agent room, enriched with the `profileId` currently bound to it so an edit form can prefill its model selector. The ID is the room's integer identifier, and a non-integer value is refused rather than passed on to fail opaquely upstream. The binding lives in an assignment rather than on the room, so it is looked up separately: a missing or unreadable assignment simply leaves `profileId` out of the answer instead of failing the call. The standing instruction comes back on the room as `chatSettings.prompt`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-get/">REST API Reference for AiAgentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiAgentsGet200Response)</returns>
        public async Task<ApiResponse<AiAgentsGet200Response>> AiAgentsGetWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsGet");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiAgentsGet200Response>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsGet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>AiFolderContentIntegerWrapper</returns>
        public AiFolderContentIntegerWrapper AiAgentsList(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default)
        {
            var localVarResponse = AiAgentsListWithHttpInfo(subjectId, subjectOwnerId, excludeSubject, tags, withoutTags, quotaFilter, filterValue, sortBy, sortOrder, startIndex, count);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>ApiResponse of AiFolderContentIntegerWrapper</returns>
        public ApiResponse<AiFolderContentIntegerWrapper> AiAgentsListWithHttpInfo(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default)
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
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
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


            // make the HTTP request
            var localVarResponse = Client.Get<AiFolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsList", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of AiFolderContentIntegerWrapper</returns>
        public async Task<AiFolderContentIntegerWrapper> AiAgentsListAsync(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsListWithHttpInfoAsync(subjectId, subjectOwnerId, excludeSubject, tags, withoutTags, quotaFilter, filterValue, sortBy, sortOrder, startIndex, count, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agents
        /// </summary>
        /// <remarks>
        /// Lists the portal's AI agent rooms. The query is forwarded unchanged to the DocSpace AI service, so it takes the same paging, sorting and filtering parameters as an ordinary room listing, and the answer is that service's folder-content payload rather than a shape of this API's own. Array and object query values are dropped rather than guessed at, so send flat strings. The profile bound to each agent is not included here - read one agent with `GET api/2.0/ai/agents/{id}` for that.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subjectId">Show only the agent rooms this user takes part in. (optional)</param>
        /// <param name="subjectOwnerId">Show only the agent rooms owned by this user. (optional)</param>
        /// <param name="excludeSubject">Invert the user filter: leave out what `subjectId` selects instead of keeping it. (optional)</param>
        /// <param name="tags">Show only the agent rooms carrying these tags, comma-separated. (optional)</param>
        /// <param name="withoutTags">Show only the agent rooms that carry no tags at all. (optional)</param>
        /// <param name="quotaFilter">Filter by quota kind: 0 for all, 1 for the default quota, 2 for a custom one. (optional)</param>
        /// <param name="filterValue">Show only the agent rooms whose title matches this text. (optional)</param>
        /// <param name="sortBy">Field to sort by, for example `DateAndTime`. (optional)</param>
        /// <param name="sortOrder">Sort direction, `ascending` or `descending`. (optional)</param>
        /// <param name="startIndex">Index of the first entry to return; 0 starts at the beginning. (optional)</param>
        /// <param name="count">How many entries to return. The internal service applies its own default. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-list/">REST API Reference for AiAgentsList Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderContentIntegerWrapper>> AiAgentsListWithHttpInfoAsync(string? subjectId = default, string? subjectOwnerId = default, bool? excludeSubject = default, string? tags = default, bool? withoutTags = default, int? quotaFilter = default, string? filterValue = default, string? sortBy = default, string? sortOrder = default, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
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
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiFolderContentIntegerWrapper>("/api/2.0/ai/agents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsList", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>AiNewItemsAgentNewItemsArrayWrapper</returns>
        public AiNewItemsAgentNewItemsArrayWrapper AiAgentsNews()
        {
            var localVarResponse = AiAgentsNewsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>ApiResponse of AiNewItemsAgentNewItemsArrayWrapper</returns>
        public ApiResponse<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<AiNewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsNews", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of AiNewItemsAgentNewItemsArrayWrapper</returns>
        public async Task<AiNewItemsAgentNewItemsArrayWrapper> AiAgentsNewsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsNewsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List agent news items
        /// </summary>
        /// <remarks>
        /// Lists the unread items across the caller's AI agent rooms, so a badge can be rendered without walking each room. It takes no parameters and is scoped to the caller by the DocSpace AI service. The answer is that service's new-items payload. This is a read-only operation and does not mark anything as seen.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-news/">REST API Reference for AiAgentsNews Operation</seealso>
        /// <returns>Task of ApiResponse (AiNewItemsAgentNewItemsArrayWrapper)</returns>
        public async Task<ApiResponse<AiNewItemsAgentNewItemsArrayWrapper>> AiAgentsNewsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiNewItemsAgentNewItemsArrayWrapper>("/api/2.0/ai/agents/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsNews", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        public AiFolderIntegerArrayWrapper AiAgentsResetQuota(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest)
        {
            var localVarResponse = AiAgentsResetQuotaWithHttpInfo(aiAgentsResetQuotaRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        public ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaWithHttpInfo(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest)
        {
            // verify the required parameter 'aiAgentsResetQuotaRequest' is set
            if (aiAgentsResetQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsResetQuotaRequest' when calling AgentsApi->AiAgentsResetQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsResetQuotaRequest != null) localVarRequestOptions.Data = aiAgentsResetQuotaRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsResetQuota", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        public async Task<AiFolderIntegerArrayWrapper> AiAgentsResetQuotaAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsResetQuotaWithHttpInfoAsync(aiAgentsResetQuotaRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reset agents' quota
        /// </summary>
        /// <remarks>
        /// Returns the listed AI agent rooms to the portal's default storage quota, forwarding `roomIds` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. This is the counterpart of `PUT api/2.0/ai/agents/agentquota` and takes no quota value of its own. Rooms already on the default are unaffected.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsResetQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-reset-quota/">REST API Reference for AiAgentsResetQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsResetQuotaWithHttpInfoAsync(AiAgentsResetQuotaRequest aiAgentsResetQuotaRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAgentsResetQuotaRequest' is set
            if (aiAgentsResetQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsResetQuotaRequest' when calling AgentsApi->AiAgentsResetQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsResetQuotaRequest != null) localVarRequestOptions.Data = aiAgentsResetQuotaRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/resetquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsResetQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>AiFolderIntegerWrapper</returns>
        public AiFolderIntegerWrapper AiAgentsUpdate(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest)
        {
            var localVarResponse = AiAgentsUpdateWithHttpInfo(id, aiAgentsUpdateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerWrapper</returns>
        public ApiResponse<AiFolderIntegerWrapper> AiAgentsUpdateWithHttpInfo(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsUpdate");

            // verify the required parameter 'aiAgentsUpdateRequest' is set
            if (aiAgentsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateRequest' when calling AgentsApi->AiAgentsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsUpdateRequest != null) localVarRequestOptions.Data = aiAgentsUpdateRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of AiFolderIntegerWrapper</returns>
        public async Task<AiFolderIntegerWrapper> AiAgentsUpdateAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsUpdateWithHttpInfoAsync(id, aiAgentsUpdateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update an agent
        /// </summary>
        /// <remarks>
        /// Changes an AI agent room - its title, tags or standing instruction - and optionally rebinds its model. The ID has to be the room's integer identifier. `profileId` is not part of the room contract: it is taken out of the forwarded body and applied afterwards as the agent's assignment, and it has to be a UUID naming an existing chat-capable profile. An instruction sent as `chatSettings.prompt` has its markup stripped, as on create; note that when `chatSettings` is present the upstream service still requires the rest of that object to be valid, so send it whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The agent identifier.</param>
        /// <param name="aiAgentsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update/">REST API Reference for AiAgentsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerWrapper>> AiAgentsUpdateWithHttpInfoAsync(string id, AiAgentsUpdateRequest aiAgentsUpdateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AgentsApi->AiAgentsUpdate");

            // verify the required parameter 'aiAgentsUpdateRequest' is set
            if (aiAgentsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateRequest' when calling AgentsApi->AiAgentsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (aiAgentsUpdateRequest != null) localVarRequestOptions.Data = aiAgentsUpdateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderIntegerWrapper>("/api/2.0/ai/agents/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>AiFolderIntegerArrayWrapper</returns>
        public AiFolderIntegerArrayWrapper AiAgentsUpdateQuota(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest)
        {
            var localVarResponse = AiAgentsUpdateQuotaWithHttpInfo(aiAgentsUpdateQuotaRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>ApiResponse of AiFolderIntegerArrayWrapper</returns>
        public ApiResponse<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaWithHttpInfo(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest)
        {
            // verify the required parameter 'aiAgentsUpdateQuotaRequest' is set
            if (aiAgentsUpdateQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateQuotaRequest' when calling AgentsApi->AiAgentsUpdateQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsUpdateQuotaRequest != null) localVarRequestOptions.Data = aiAgentsUpdateQuotaRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdateQuota", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of AiFolderIntegerArrayWrapper</returns>
        public async Task<AiFolderIntegerArrayWrapper> AiAgentsUpdateQuotaAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAgentsUpdateQuotaWithHttpInfoAsync(aiAgentsUpdateQuotaRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update agents' quota
        /// </summary>
        /// <remarks>
        /// Sets the storage quota of the listed AI agent rooms in one call, forwarding `roomIds` and `quota` to the DocSpace AI service unchanged. The answer is that service's payload, one updated room per entry. A quota applies to the room's stored files, not to the model usage of its chats. Use `PUT api/2.0/ai/agents/resetquota` to return rooms to the portal default instead of naming a number.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAgentsUpdateQuotaRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-agents-update-quota/">REST API Reference for AiAgentsUpdateQuota Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderIntegerArrayWrapper)</returns>
        public async Task<ApiResponse<AiFolderIntegerArrayWrapper>> AiAgentsUpdateQuotaWithHttpInfoAsync(AiAgentsUpdateQuotaRequest aiAgentsUpdateQuotaRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAgentsUpdateQuotaRequest' is set
            if (aiAgentsUpdateQuotaRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAgentsUpdateQuotaRequest' when calling AgentsApi->AiAgentsUpdateQuota");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAgentsUpdateQuotaRequest != null) localVarRequestOptions.Data = aiAgentsUpdateQuotaRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderIntegerArrayWrapper>("/api/2.0/ai/agents/agentquota", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAgentsUpdateQuota", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
