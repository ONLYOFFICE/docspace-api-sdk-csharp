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
namespace DocSpace.API.SDK.Api.Rooms
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>AiProjectModelWrapper</returns>
        AiProjectModelWrapper GetProjectModel(int id);

        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>ApiResponse of AiProjectModelWrapper</returns>
        ApiResponse<AiProjectModelWrapper> GetProjectModelWithHttpInfo(int id);
        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>AiProjectSourcesWrapper</returns>
        AiProjectSourcesWrapper GetProjectSources(int id);

        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>ApiResponse of AiProjectSourcesWrapper</returns>
        ApiResponse<AiProjectSourcesWrapper> GetProjectSourcesWithHttpInfo(int id);
        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>AiSkillsWrapper</returns>
        AiSkillsWrapper GetRoomSkills(int id);

        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>ApiResponse of AiSkillsWrapper</returns>
        ApiResponse<AiSkillsWrapper> GetRoomSkillsWithHttpInfo(int id);
        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>AiSkillsWrapper</returns>
        AiSkillsWrapper GetRoomsSkills(List<int>? roomIds = default);

        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>ApiResponse of AiSkillsWrapper</returns>
        ApiResponse<AiSkillsWrapper> GetRoomsSkillsWithHttpInfo(List<int>? roomIds = default);
        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns></returns>
        void LinkProjectSources(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest);

        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> LinkProjectSourcesWithHttpInfo(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest);
        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>AiProjectModelWrapper</returns>
        AiProjectModelWrapper SetProjectModel(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest);

        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>ApiResponse of AiProjectModelWrapper</returns>
        ApiResponse<AiProjectModelWrapper> SetProjectModelWithHttpInfo(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest);
        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns></returns>
        void UnlinkProjectSources(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest);

        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UnlinkProjectSourcesWithHttpInfo(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>Task of AiProjectModelWrapper</returns>
        Task<AiProjectModelWrapper> GetProjectModelAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>Task of ApiResponse (AiProjectModelWrapper)</returns>
        Task<ApiResponse<AiProjectModelWrapper>> GetProjectModelWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>Task of AiProjectSourcesWrapper</returns>
        Task<AiProjectSourcesWrapper> GetProjectSourcesAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>Task of ApiResponse (AiProjectSourcesWrapper)</returns>
        Task<ApiResponse<AiProjectSourcesWrapper>> GetProjectSourcesWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>Task of AiSkillsWrapper</returns>
        Task<AiSkillsWrapper> GetRoomSkillsAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>Task of ApiResponse (AiSkillsWrapper)</returns>
        Task<ApiResponse<AiSkillsWrapper>> GetRoomSkillsWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>Task of AiSkillsWrapper</returns>
        Task<AiSkillsWrapper> GetRoomsSkillsAsync(List<int>? roomIds = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>Task of ApiResponse (AiSkillsWrapper)</returns>
        Task<ApiResponse<AiSkillsWrapper>> GetRoomsSkillsWithHttpInfoAsync(List<int>? roomIds = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns>Task of void</returns>
        Task LinkProjectSourcesAsync(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> LinkProjectSourcesWithHttpInfoAsync(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>Task of AiProjectModelWrapper</returns>
        Task<AiProjectModelWrapper> SetProjectModelAsync(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>Task of ApiResponse (AiProjectModelWrapper)</returns>
        Task<ApiResponse<AiProjectModelWrapper>> SetProjectModelWithHttpInfoAsync(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns>Task of void</returns>
        Task UnlinkProjectSourcesAsync(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> UnlinkProjectSourcesWithHttpInfoAsync(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApi : IAIApiSync, IAIApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AIApi : IDisposable, IAIApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AIApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AIApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AIApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AIApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
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
        public AIApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class using a Configuration object.
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
        public AIApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AIApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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


        
        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>AiProjectModelWrapper</returns>
        public AiProjectModelWrapper GetProjectModel(int id)
        {
            var localVarResponse = GetProjectModelWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>ApiResponse of AiProjectModelWrapper</returns>
        public ApiResponse<AiProjectModelWrapper> GetProjectModelWithHttpInfo(int id)
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
            var localVarResponse = Client.Get<AiProjectModelWrapper>("/api/2.0/files/rooms/{id}/model", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProjectModel", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>Task of AiProjectModelWrapper</returns>
        public async Task<AiProjectModelWrapper> GetProjectModelAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProjectModelWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the AI project model
        /// </summary>
        /// <remarks>
        /// Returns the AI model selected for the chat of an AI project, as the ID of an AI model profile. Any project member with read access may call it. The call is read-only. The result holds only the project's own choice: `profileId` is null when nobody has selected a model for the project yet, or when the selected profile has been removed from the portal since. In both cases the portal-wide model is used instead, which this operation does not return. To change the model, use `PUT api/2.0/files/rooms/{id}/model`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-model/">REST API Reference for GetProjectModel Operation</seealso>
        /// <returns>Task of ApiResponse (AiProjectModelWrapper)</returns>
        public async Task<ApiResponse<AiProjectModelWrapper>> GetProjectModelWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiProjectModelWrapper>("/api/2.0/files/rooms/{id}/model", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProjectModel", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>AiProjectSourcesWrapper</returns>
        public AiProjectSourcesWrapper GetProjectSources(int id)
        {
            var localVarResponse = GetProjectSourcesWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>ApiResponse of AiProjectSourcesWrapper</returns>
        public ApiResponse<AiProjectSourcesWrapper> GetProjectSourcesWithHttpInfo(int id)
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
            var localVarResponse = Client.Get<AiProjectSourcesWrapper>("/api/2.0/files/rooms/{id}/sources", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProjectSources", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>Task of AiProjectSourcesWrapper</returns>
        public async Task<AiProjectSourcesWrapper> GetProjectSourcesAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProjectSourcesWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the AI project sources
        /// </summary>
        /// <remarks>
        /// Returns the Instructions and Knowledge rooms linked to an AI project as its sources.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-project-sources/">REST API Reference for GetProjectSources Operation</seealso>
        /// <returns>Task of ApiResponse (AiProjectSourcesWrapper)</returns>
        public async Task<ApiResponse<AiProjectSourcesWrapper>> GetProjectSourcesWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiProjectSourcesWrapper>("/api/2.0/files/rooms/{id}/sources", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProjectSources", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>AiSkillsWrapper</returns>
        public AiSkillsWrapper GetRoomSkills(int id)
        {
            var localVarResponse = GetRoomSkillsWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>ApiResponse of AiSkillsWrapper</returns>
        public ApiResponse<AiSkillsWrapper> GetRoomSkillsWithHttpInfo(int id)
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
            var localVarResponse = Client.Get<AiSkillsWrapper>("/api/2.0/files/rooms/{id}/skills", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomSkills", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>Task of AiSkillsWrapper</returns>
        public async Task<AiSkillsWrapper> GetRoomSkillsAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomSkillsWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the skills of an AI room
        /// </summary>
        /// <remarks>
        /// Returns the skills of an Instructions room, or of the Instructions rooms linked to an AI project.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room to act on, named by the identifier that `GET api/2.0/files/rooms` reports for it. Rooms kept in the  portal itself use whole numbers, while a room backed by a connected third-party account uses the string form  of the same listing.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-skills/">REST API Reference for GetRoomSkills Operation</seealso>
        /// <returns>Task of ApiResponse (AiSkillsWrapper)</returns>
        public async Task<ApiResponse<AiSkillsWrapper>> GetRoomSkillsWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSkillsWrapper>("/api/2.0/files/rooms/{id}/skills", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomSkills", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>AiSkillsWrapper</returns>
        public AiSkillsWrapper GetRoomsSkills(List<int>? roomIds = default)
        {
            var localVarResponse = GetRoomsSkillsWithHttpInfo(roomIds);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>ApiResponse of AiSkillsWrapper</returns>
        public ApiResponse<AiSkillsWrapper> GetRoomsSkillsWithHttpInfo(List<int>? roomIds = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (roomIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "roomIds", roomIds));
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
            var localVarResponse = Client.Get<AiSkillsWrapper>("/api/2.0/files/rooms/skills", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsSkills", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>Task of AiSkillsWrapper</returns>
        public async Task<AiSkillsWrapper> GetRoomsSkillsAsync(List<int>? roomIds = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomsSkillsWithHttpInfoAsync(roomIds, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the skills of Instructions rooms
        /// </summary>
        /// <remarks>
        /// Returns the skills of several Instructions rooms. Rooms the caller cannot read are left out.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomIds">IDs of the Instructions rooms, one `roomIds` query item per room; 1 to 20 items. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-skills/">REST API Reference for GetRoomsSkills Operation</seealso>
        /// <returns>Task of ApiResponse (AiSkillsWrapper)</returns>
        public async Task<ApiResponse<AiSkillsWrapper>> GetRoomsSkillsWithHttpInfoAsync(List<int>? roomIds = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (roomIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("multi", "roomIds", roomIds));
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSkillsWrapper>("/api/2.0/files/rooms/skills", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsSkills", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns></returns>
        public void LinkProjectSources(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest)
        {
            LinkProjectSourcesWithHttpInfo(id, linkAiProjectSourcesRequest);
        }

        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> LinkProjectSourcesWithHttpInfo(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest)
        {
            // verify the required parameter 'linkAiProjectSourcesRequest' is set
            if (linkAiProjectSourcesRequest == null)
                throw new ApiException(400, "Missing required parameter 'linkAiProjectSourcesRequest' when calling AIApi->LinkProjectSources");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (linkAiProjectSourcesRequest != null) localVarRequestOptions.Data = linkAiProjectSourcesRequest;

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
            var localVarResponse = Client.Post<Object>("/api/2.0/files/rooms/{id}/sources", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("LinkProjectSources", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task LinkProjectSourcesAsync(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest, CancellationToken cancellationToken = default)
        {
            await LinkProjectSourcesWithHttpInfoAsync(id, linkAiProjectSourcesRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Link sources to an AI project
        /// </summary>
        /// <remarks>
        /// Links Instructions and Knowledge rooms to an AI project as its sources, which gives every project member read access to them. The caller must manage the project and each listed room; rooms that are already linked are skipped.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="linkAiProjectSourcesRequest">The rooms to link.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/link-project-sources/">REST API Reference for LinkProjectSources Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> LinkProjectSourcesWithHttpInfoAsync(int id, LinkAiProjectSourcesRequest linkAiProjectSourcesRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'linkAiProjectSourcesRequest' is set
            if (linkAiProjectSourcesRequest == null)
                throw new ApiException(400, "Missing required parameter 'linkAiProjectSourcesRequest' when calling AIApi->LinkProjectSources");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (linkAiProjectSourcesRequest != null) localVarRequestOptions.Data = linkAiProjectSourcesRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/files/rooms/{id}/sources", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("LinkProjectSources", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>AiProjectModelWrapper</returns>
        public AiProjectModelWrapper SetProjectModel(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest)
        {
            var localVarResponse = SetProjectModelWithHttpInfo(id, updateAiProjectModelRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>ApiResponse of AiProjectModelWrapper</returns>
        public ApiResponse<AiProjectModelWrapper> SetProjectModelWithHttpInfo(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest)
        {
            // verify the required parameter 'updateAiProjectModelRequest' is set
            if (updateAiProjectModelRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateAiProjectModelRequest' when calling AIApi->SetProjectModel");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateAiProjectModelRequest != null) localVarRequestOptions.Data = updateAiProjectModelRequest;

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
            var localVarResponse = Client.Put<AiProjectModelWrapper>("/api/2.0/files/rooms/{id}/model", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetProjectModel", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>Task of AiProjectModelWrapper</returns>
        public async Task<AiProjectModelWrapper> SetProjectModelAsync(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetProjectModelWithHttpInfoAsync(id, updateAiProjectModelRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the AI project model
        /// </summary>
        /// <remarks>
        /// Selects the AI model that answers in the chat of an AI project, replacing the previous choice, and returns the model now selected. Take `profileId` from the profiles that `GET api/2.0/ai/profiles/list` returns. The caller must be able to edit the project; reading it is not enough. The change applies to every member of the project, is recorded in the audit trail and notifies the project's open clients. Repeating the call with the same profile changes nothing. A model can only be replaced by another one: there is no operation that clears the selection and returns the project to the portal-wide model. The profile must exist on the portal and be able to chat; a profile known to serve only other kinds of tasks, such as image generation, is refused with 400.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="updateAiProjectModelRequest">The model to set.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-project-model/">REST API Reference for SetProjectModel Operation</seealso>
        /// <returns>Task of ApiResponse (AiProjectModelWrapper)</returns>
        public async Task<ApiResponse<AiProjectModelWrapper>> SetProjectModelWithHttpInfoAsync(int id, UpdateAiProjectModelRequest updateAiProjectModelRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateAiProjectModelRequest' is set
            if (updateAiProjectModelRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateAiProjectModelRequest' when calling AIApi->SetProjectModel");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateAiProjectModelRequest != null) localVarRequestOptions.Data = updateAiProjectModelRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiProjectModelWrapper>("/api/2.0/files/rooms/{id}/model", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetProjectModel", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns></returns>
        public void UnlinkProjectSources(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest)
        {
            UnlinkProjectSourcesWithHttpInfo(id, unlinkAiProjectSourcesRequest);
        }

        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UnlinkProjectSourcesWithHttpInfo(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest)
        {
            // verify the required parameter 'unlinkAiProjectSourcesRequest' is set
            if (unlinkAiProjectSourcesRequest == null)
                throw new ApiException(400, "Missing required parameter 'unlinkAiProjectSourcesRequest' when calling AIApi->UnlinkProjectSources");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (unlinkAiProjectSourcesRequest != null) localVarRequestOptions.Data = unlinkAiProjectSourcesRequest;

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
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/rooms/{id}/sources", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnlinkProjectSources", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task UnlinkProjectSourcesAsync(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest, CancellationToken cancellationToken = default)
        {
            await UnlinkProjectSourcesWithHttpInfoAsync(id, unlinkAiProjectSourcesRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Unlink sources from an AI project
        /// </summary>
        /// <remarks>
        /// Unlinks Instructions and Knowledge rooms from an AI project; project members lose the access the link gave them. The caller must manage the project, rights on the rooms are not checked; the rooms themselves are not changed.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the project.</param>
        /// <param name="unlinkAiProjectSourcesRequest">The rooms to unlink.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unlink-project-sources/">REST API Reference for UnlinkProjectSources Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> UnlinkProjectSourcesWithHttpInfoAsync(int id, UnlinkAiProjectSourcesRequest unlinkAiProjectSourcesRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'unlinkAiProjectSourcesRequest' is set
            if (unlinkAiProjectSourcesRequest == null)
                throw new ApiException(400, "Missing required parameter 'unlinkAiProjectSourcesRequest' when calling AIApi->UnlinkProjectSources");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (unlinkAiProjectSourcesRequest != null) localVarRequestOptions.Data = unlinkAiProjectSourcesRequest;

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/rooms/{id}/sources", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnlinkProjectSources", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
