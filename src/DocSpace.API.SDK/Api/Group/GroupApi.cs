// (c) Copyright Ascensio System SIA 2025
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
namespace DocSpace.API.SDK.Api.Group
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper AddGroup(GroupRequestDto? groupRequestDto = default);

        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> AddGroupWithHttpInfo(GroupRequestDto? groupRequestDto = default);
        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper AddMembersTo(Guid id, MembersRequest membersRequest);

        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> AddMembersToWithHttpInfo(Guid id, MembersRequest membersRequest);
        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>NoContentResultWrapper</returns>
        NoContentResultWrapper DeleteGroup(Guid id);

        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>ApiResponse of NoContentResultWrapper</returns>
        ApiResponse<NoContentResultWrapper> DeleteGroupWithHttpInfo(Guid id);
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper GetGroup(Guid id, bool? includeMembers = default);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> GetGroupWithHttpInfo(Guid id, bool? includeMembers = default);
        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>GroupSummaryArrayWrapper</returns>
        GroupSummaryArrayWrapper GetGroupByUserId(Guid userid);

        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>ApiResponse of GroupSummaryArrayWrapper</returns>
        ApiResponse<GroupSummaryArrayWrapper> GetGroupByUserIdWithHttpInfo(Guid userid);
        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>GroupArrayWrapper</returns>
        GroupArrayWrapper GetGroups(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>ApiResponse of GroupArrayWrapper</returns>
        ApiResponse<GroupArrayWrapper> GetGroupsWithHttpInfo(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper MoveMembersTo(Guid fromId, Guid toId);

        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> MoveMembersToWithHttpInfo(Guid fromId, Guid toId);
        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper RemoveMembersFrom(Guid id, MembersRequest membersRequest);

        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> RemoveMembersFromWithHttpInfo(Guid id, MembersRequest membersRequest);
        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper SetGroupManager(Guid id, SetManagerRequest setManagerRequest);

        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> SetGroupManagerWithHttpInfo(Guid id, SetManagerRequest setManagerRequest);
        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper SetMembersTo(Guid id, MembersRequest membersRequest);

        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> SetMembersToWithHttpInfo(Guid id, MembersRequest membersRequest);
        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>GroupWrapper</returns>
        GroupWrapper UpdateGroup(Guid id, UpdateGroupRequest updateGroupRequest);

        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        ApiResponse<GroupWrapper> UpdateGroupWithHttpInfo(Guid id, UpdateGroupRequest updateGroupRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> AddGroupAsync(GroupRequestDto? groupRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> AddGroupWithHttpInfoAsync(GroupRequestDto? groupRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> AddMembersToAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> AddMembersToWithHttpInfoAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>Task of NoContentResultWrapper</returns>
        Task<NoContentResultWrapper> DeleteGroupAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>Task of ApiResponse (NoContentResultWrapper)</returns>
        Task<ApiResponse<NoContentResultWrapper>> DeleteGroupWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> GetGroupAsync(Guid id, bool? includeMembers = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> GetGroupWithHttpInfoAsync(Guid id, bool? includeMembers = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>Task of GroupSummaryArrayWrapper</returns>
        Task<GroupSummaryArrayWrapper> GetGroupByUserIdAsync(Guid userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>Task of ApiResponse (GroupSummaryArrayWrapper)</returns>
        Task<ApiResponse<GroupSummaryArrayWrapper>> GetGroupByUserIdWithHttpInfoAsync(Guid userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>Task of GroupArrayWrapper</returns>
        Task<GroupArrayWrapper> GetGroupsAsync(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>Task of ApiResponse (GroupArrayWrapper)</returns>
        Task<ApiResponse<GroupArrayWrapper>> GetGroupsWithHttpInfoAsync(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> MoveMembersToAsync(Guid fromId, Guid toId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> MoveMembersToWithHttpInfoAsync(Guid fromId, Guid toId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> RemoveMembersFromAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> RemoveMembersFromWithHttpInfoAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> SetGroupManagerAsync(Guid id, SetManagerRequest setManagerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> SetGroupManagerWithHttpInfoAsync(Guid id, SetManagerRequest setManagerRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> SetMembersToAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> SetMembersToWithHttpInfoAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        Task<GroupWrapper> UpdateGroupAsync(Guid id, UpdateGroupRequest updateGroupRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        Task<ApiResponse<GroupWrapper>> UpdateGroupWithHttpInfoAsync(Guid id, UpdateGroupRequest updateGroupRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupApi : IGroupApiSync, IGroupApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GroupApi : IDisposable, IGroupApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public GroupApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public GroupApi(string basePath)
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
        /// Initializes a new instance of the <see cref="GroupApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public GroupApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="GroupApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GroupApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApi"/> class.
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
        public GroupApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="GroupApi"/> class using a Configuration object.
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
        public GroupApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="GroupApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public GroupApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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

        public GroupApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper AddGroup(GroupRequestDto? groupRequestDto = default)
        {
            var localVarResponse = AddGroupWithHttpInfo(groupRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> AddGroupWithHttpInfo(GroupRequestDto? groupRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (groupRequestDto != null) localVarRequestOptions.Data = groupRequestDto;

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
            var localVarResponse = Client.Post<GroupWrapper>("/api/2.0/group", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddGroup", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> AddGroupAsync(GroupRequestDto? groupRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddGroupWithHttpInfoAsync(groupRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a new group
        /// </summary>
        /// <remarks>
        /// Adds a new group with the group manager, name, and members specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupRequestDto">The group request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-group/">REST API Reference for AddGroup Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> AddGroupWithHttpInfoAsync(GroupRequestDto? groupRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (groupRequestDto != null) localVarRequestOptions.Data = groupRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<GroupWrapper>("/api/2.0/group", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddGroup", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper AddMembersTo(Guid id, MembersRequest membersRequest)
        {
            var localVarResponse = AddMembersToWithHttpInfo(id, membersRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> AddMembersToWithHttpInfo(Guid id, MembersRequest membersRequest)
        {
            // verify the required parameter 'membersRequest' is set
            if (membersRequest == null)
                throw new ApiException(400, "Missing required parameter 'membersRequest' when calling GroupApi->AddMembersTo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (membersRequest != null) localVarRequestOptions.Data = membersRequest;

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
            var localVarResponse = Client.Put<GroupWrapper>("/api/2.0/group/{id}/members", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddMembersTo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> AddMembersToAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddMembersToWithHttpInfoAsync(id, membersRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add group members
        /// </summary>
        /// <remarks>
        /// Adds new group members to the group with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-members-to/">REST API Reference for AddMembersTo Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> AddMembersToWithHttpInfoAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'membersRequest' is set
            if (membersRequest == null)
                throw new ApiException(400, "Missing required parameter 'membersRequest' when calling GroupApi->AddMembersTo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (membersRequest != null) localVarRequestOptions.Data = membersRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<GroupWrapper>("/api/2.0/group/{id}/members", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddMembersTo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>NoContentResultWrapper</returns>
        public NoContentResultWrapper DeleteGroup(Guid id)
        {
            var localVarResponse = DeleteGroupWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>ApiResponse of NoContentResultWrapper</returns>
        public ApiResponse<NoContentResultWrapper> DeleteGroupWithHttpInfo(Guid id)
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
            var localVarResponse = Client.Delete<NoContentResultWrapper>("/api/2.0/group/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteGroup", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>Task of NoContentResultWrapper</returns>
        public async Task<NoContentResultWrapper> DeleteGroupAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteGroupWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a group
        /// </summary>
        /// <remarks>
        /// Deletes a group with the ID specified in the request from the list of groups on the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-group/">REST API Reference for DeleteGroup Operation</seealso>
        /// <returns>Task of ApiResponse (NoContentResultWrapper)</returns>
        public async Task<ApiResponse<NoContentResultWrapper>> DeleteGroupWithHttpInfoAsync(Guid id, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NoContentResultWrapper>("/api/2.0/group/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteGroup", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper GetGroup(Guid id, bool? includeMembers = default)
        {
            var localVarResponse = GetGroupWithHttpInfo(id, includeMembers);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> GetGroupWithHttpInfo(Guid id, bool? includeMembers = default)
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
            if (includeMembers != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeMembers", includeMembers));
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
            var localVarResponse = Client.Get<GroupWrapper>("/api/2.0/group/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroup", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> GetGroupAsync(Guid id, bool? includeMembers = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetGroupWithHttpInfoAsync(id, includeMembers, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the selected group.   **Note**: This method returns full group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="includeMembers">Specifies whether to include the group members or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group/">REST API Reference for GetGroup Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> GetGroupWithHttpInfoAsync(Guid id, bool? includeMembers = default, CancellationToken cancellationToken = default)
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
            if (includeMembers != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeMembers", includeMembers));
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

            var localVarResponse = await AsynchronousClient.GetAsync<GroupWrapper>("/api/2.0/group/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroup", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>GroupSummaryArrayWrapper</returns>
        public GroupSummaryArrayWrapper GetGroupByUserId(Guid userid)
        {
            var localVarResponse = GetGroupByUserIdWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>ApiResponse of GroupSummaryArrayWrapper</returns>
        public ApiResponse<GroupSummaryArrayWrapper> GetGroupByUserIdWithHttpInfo(Guid userid)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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
            var localVarResponse = Client.Get<GroupSummaryArrayWrapper>("/api/2.0/group/user/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroupByUserId", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>Task of GroupSummaryArrayWrapper</returns>
        public async Task<GroupSummaryArrayWrapper> GetGroupByUserIdAsync(Guid userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetGroupByUserIdWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user groups
        /// </summary>
        /// <remarks>
        /// Returns a list of groups for the user with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-group-by-user-id/">REST API Reference for GetGroupByUserId Operation</seealso>
        /// <returns>Task of ApiResponse (GroupSummaryArrayWrapper)</returns>
        public async Task<ApiResponse<GroupSummaryArrayWrapper>> GetGroupByUserIdWithHttpInfoAsync(Guid userid, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter

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

            var localVarResponse = await AsynchronousClient.GetAsync<GroupSummaryArrayWrapper>("/api/2.0/group/user/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroupByUserId", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>GroupArrayWrapper</returns>
        public GroupArrayWrapper GetGroups(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetGroupsWithHttpInfo(userId, manager, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>ApiResponse of GroupArrayWrapper</returns>
        public ApiResponse<GroupArrayWrapper> GetGroupsWithHttpInfo(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (manager != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "manager", manager));
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
            var localVarResponse = Client.Get<GroupArrayWrapper>("/api/2.0/group", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroups", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>Task of GroupArrayWrapper</returns>
        public async Task<GroupArrayWrapper> GetGroupsAsync(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetGroupsWithHttpInfoAsync(userId, manager, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get groups
        /// </summary>
        /// <remarks>
        /// Returns the general information about all the groups, such as group ID and group manager.   **Note**: This method returns partial group information.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The user ID. (optional)</param>
        /// <param name="manager">Specifies if the user is a manager or not. (optional)</param>
        /// <param name="count">The number of records to retrieve. (optional)</param>
        /// <param name="startIndex">The starting index for paginated results. (optional)</param>
        /// <param name="sortBy">Specifies the property used to sort the query results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching group data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups/">REST API Reference for GetGroups Operation</seealso>
        /// <returns>Task of ApiResponse (GroupArrayWrapper)</returns>
        public async Task<ApiResponse<GroupArrayWrapper>> GetGroupsWithHttpInfoAsync(Guid? userId = default, bool? manager = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userId", userId));
            }
            if (manager != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "manager", manager));
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

            var localVarResponse = await AsynchronousClient.GetAsync<GroupArrayWrapper>("/api/2.0/group", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroups", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper MoveMembersTo(Guid fromId, Guid toId)
        {
            var localVarResponse = MoveMembersToWithHttpInfo(fromId, toId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> MoveMembersToWithHttpInfo(Guid fromId, Guid toId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fromId", ClientUtils.ParameterToString(fromId)); // path parameter
            localVarRequestOptions.PathParameters.Add("toId", ClientUtils.ParameterToString(toId)); // path parameter

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
            var localVarResponse = Client.Put<GroupWrapper>("/api/2.0/group/{fromId}/members/{toId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveMembersTo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> MoveMembersToAsync(Guid fromId, Guid toId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MoveMembersToWithHttpInfoAsync(fromId, toId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move group members
        /// </summary>
        /// <remarks>
        /// Moves all the members from the selected group to another one specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromId">The group ID to move from.</param>
        /// <param name="toId">The group ID to move to.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-members-to/">REST API Reference for MoveMembersTo Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> MoveMembersToWithHttpInfoAsync(Guid fromId, Guid toId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fromId", ClientUtils.ParameterToString(fromId)); // path parameter
            localVarRequestOptions.PathParameters.Add("toId", ClientUtils.ParameterToString(toId)); // path parameter

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

            var localVarResponse = await AsynchronousClient.PutAsync<GroupWrapper>("/api/2.0/group/{fromId}/members/{toId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveMembersTo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper RemoveMembersFrom(Guid id, MembersRequest membersRequest)
        {
            var localVarResponse = RemoveMembersFromWithHttpInfo(id, membersRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> RemoveMembersFromWithHttpInfo(Guid id, MembersRequest membersRequest)
        {
            // verify the required parameter 'membersRequest' is set
            if (membersRequest == null)
                throw new ApiException(400, "Missing required parameter 'membersRequest' when calling GroupApi->RemoveMembersFrom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (membersRequest != null) localVarRequestOptions.Data = membersRequest;

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
            var localVarResponse = Client.Delete<GroupWrapper>("/api/2.0/group/{id}/members", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveMembersFrom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> RemoveMembersFromAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RemoveMembersFromWithHttpInfoAsync(id, membersRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove group members
        /// </summary>
        /// <remarks>
        /// Removes the group members specified in the request from the selected group.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-members-from/">REST API Reference for RemoveMembersFrom Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> RemoveMembersFromWithHttpInfoAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'membersRequest' is set
            if (membersRequest == null)
                throw new ApiException(400, "Missing required parameter 'membersRequest' when calling GroupApi->RemoveMembersFrom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (membersRequest != null) localVarRequestOptions.Data = membersRequest;

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<GroupWrapper>("/api/2.0/group/{id}/members", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveMembersFrom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper SetGroupManager(Guid id, SetManagerRequest setManagerRequest)
        {
            var localVarResponse = SetGroupManagerWithHttpInfo(id, setManagerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> SetGroupManagerWithHttpInfo(Guid id, SetManagerRequest setManagerRequest)
        {
            // verify the required parameter 'setManagerRequest' is set
            if (setManagerRequest == null)
                throw new ApiException(400, "Missing required parameter 'setManagerRequest' when calling GroupApi->SetGroupManager");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (setManagerRequest != null) localVarRequestOptions.Data = setManagerRequest;

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
            var localVarResponse = Client.Put<GroupWrapper>("/api/2.0/group/{id}/manager", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetGroupManager", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> SetGroupManagerAsync(Guid id, SetManagerRequest setManagerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetGroupManagerWithHttpInfoAsync(id, setManagerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set a group manager
        /// </summary>
        /// <remarks>
        /// Sets a user with the ID specified in the request as a group manager.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="setManagerRequest">The request for setting a group manager.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-group-manager/">REST API Reference for SetGroupManager Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> SetGroupManagerWithHttpInfoAsync(Guid id, SetManagerRequest setManagerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setManagerRequest' is set
            if (setManagerRequest == null)
                throw new ApiException(400, "Missing required parameter 'setManagerRequest' when calling GroupApi->SetGroupManager");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (setManagerRequest != null) localVarRequestOptions.Data = setManagerRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<GroupWrapper>("/api/2.0/group/{id}/manager", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetGroupManager", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper SetMembersTo(Guid id, MembersRequest membersRequest)
        {
            var localVarResponse = SetMembersToWithHttpInfo(id, membersRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> SetMembersToWithHttpInfo(Guid id, MembersRequest membersRequest)
        {
            // verify the required parameter 'membersRequest' is set
            if (membersRequest == null)
                throw new ApiException(400, "Missing required parameter 'membersRequest' when calling GroupApi->SetMembersTo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (membersRequest != null) localVarRequestOptions.Data = membersRequest;

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
            var localVarResponse = Client.Post<GroupWrapper>("/api/2.0/group/{id}/members", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetMembersTo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> SetMembersToAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetMembersToWithHttpInfoAsync(id, membersRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace group members
        /// </summary>
        /// <remarks>
        /// Replaces the group members with those specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="membersRequest">The member request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-members-to/">REST API Reference for SetMembersTo Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> SetMembersToWithHttpInfoAsync(Guid id, MembersRequest membersRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'membersRequest' is set
            if (membersRequest == null)
                throw new ApiException(400, "Missing required parameter 'membersRequest' when calling GroupApi->SetMembersTo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (membersRequest != null) localVarRequestOptions.Data = membersRequest;

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

            var localVarResponse = await AsynchronousClient.PostAsync<GroupWrapper>("/api/2.0/group/{id}/members", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetMembersTo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>GroupWrapper</returns>
        public GroupWrapper UpdateGroup(Guid id, UpdateGroupRequest updateGroupRequest)
        {
            var localVarResponse = UpdateGroupWithHttpInfo(id, updateGroupRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>ApiResponse of GroupWrapper</returns>
        public ApiResponse<GroupWrapper> UpdateGroupWithHttpInfo(Guid id, UpdateGroupRequest updateGroupRequest)
        {
            // verify the required parameter 'updateGroupRequest' is set
            if (updateGroupRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateGroupRequest' when calling GroupApi->UpdateGroup");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateGroupRequest != null) localVarRequestOptions.Data = updateGroupRequest;

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
            var localVarResponse = Client.Put<GroupWrapper>("/api/2.0/group/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateGroup", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>Task of GroupWrapper</returns>
        public async Task<GroupWrapper> UpdateGroupAsync(Guid id, UpdateGroupRequest updateGroupRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateGroupWithHttpInfoAsync(id, updateGroupRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a group
        /// </summary>
        /// <remarks>
        /// Updates the existing group changing the group manager, name, and/or members.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The group ID.</param>
        /// <param name="updateGroupRequest">The request for updating a group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-group/">REST API Reference for UpdateGroup Operation</seealso>
        /// <returns>Task of ApiResponse (GroupWrapper)</returns>
        public async Task<ApiResponse<GroupWrapper>> UpdateGroupWithHttpInfoAsync(Guid id, UpdateGroupRequest updateGroupRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateGroupRequest' is set
            if (updateGroupRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateGroupRequest' when calling GroupApi->UpdateGroup");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateGroupRequest != null) localVarRequestOptions.Data = updateGroupRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<GroupWrapper>("/api/2.0/group/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateGroup", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
