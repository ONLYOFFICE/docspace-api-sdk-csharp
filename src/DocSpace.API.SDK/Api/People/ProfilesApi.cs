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
namespace DocSpace.API.SDK.Api.People
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper AddMember(MemberRequestDto? memberRequestDto = default);

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> AddMemberWithHttpInfo(MemberRequestDto? memberRequestDto = default);
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper DeleteMember(string userid);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> DeleteMemberWithHttpInfo(string userid);
        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper DeleteProfile();

        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> DeleteProfileWithHttpInfo();
        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetAllProfiles(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default);

        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetAllProfilesWithHttpInfo(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default);
        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper GetClaims();

        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> GetClaimsWithHttpInfo();
        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper GetProfileByEmail(string? email = default, string? culture = default);

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> GetProfileByEmailWithHttpInfo(string? email = default, string? culture = default);
        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper GetProfileByUserId(string userid);

        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> GetProfileByUserIdWithHttpInfo(string userid);
        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper GetSelfProfile();

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> GetSelfProfileWithHttpInfo();
        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        EmployeeArrayWrapper InviteUsers(InviteUsersRequestDto? inviteUsersRequestDto = default);

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        ApiResponse<EmployeeArrayWrapper> InviteUsersWithHttpInfo(InviteUsersRequestDto? inviteUsersRequestDto = default);
        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper RemoveUsers(UpdateMembersRequestDto? updateMembersRequestDto = default);

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> RemoveUsersWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default);
        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper ResendUserInvites(UpdateMembersRequestDto? updateMembersRequestDto = default);

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> ResendUserInvitesWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default);
        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper SendEmailChangeInstructions(UpdateMemberRequestDto? updateMemberRequestDto = default);

        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> SendEmailChangeInstructionsWithHttpInfo(UpdateMemberRequestDto? updateMemberRequestDto = default);
        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper UpdateMember(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default);

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> UpdateMemberWithHttpInfo(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default);
        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        EmployeeFullWrapper UpdateMemberCulture(string userid, Culture? culture = default);

        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        ApiResponse<EmployeeFullWrapper> UpdateMemberCultureWithHttpInfo(string userid, Culture? culture = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> AddMemberAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> AddMemberWithHttpInfoAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> DeleteMemberAsync(string userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> DeleteMemberWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> DeleteProfileAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> DeleteProfileWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetAllProfilesAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetAllProfilesWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> GetClaimsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> GetClaimsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> GetProfileByEmailAsync(string? email = default, string? culture = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> GetProfileByEmailWithHttpInfoAsync(string? email = default, string? culture = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> GetProfileByUserIdAsync(string userid, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> GetProfileByUserIdWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> GetSelfProfileAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> GetSelfProfileWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        Task<EmployeeArrayWrapper> InviteUsersAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        Task<ApiResponse<EmployeeArrayWrapper>> InviteUsersWithHttpInfoAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> RemoveUsersAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> RemoveUsersWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> ResendUserInvitesAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> ResendUserInvitesWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> SendEmailChangeInstructionsAsync(UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> SendEmailChangeInstructionsWithHttpInfoAsync(UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> UpdateMemberAsync(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberWithHttpInfoAsync(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        Task<EmployeeFullWrapper> UpdateMemberCultureAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberCultureWithHttpInfoAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfilesApi : IProfilesApiSync, IProfilesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProfilesApi : IDisposable, IProfilesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ProfilesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ProfilesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ProfilesApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ProfilesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class.
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
        public ProfilesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class using a Configuration object.
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
        public ProfilesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ProfilesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProfilesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper AddMember(MemberRequestDto? memberRequestDto = default)
        {
            var localVarResponse = AddMemberWithHttpInfo(memberRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> AddMemberWithHttpInfo(MemberRequestDto? memberRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (memberRequestDto != null) localVarRequestOptions.Data = memberRequestDto;

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
            var localVarResponse = Client.Post<EmployeeFullWrapper>("/api/2.0/people", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddMember", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> AddMemberAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddMemberWithHttpInfoAsync(memberRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add a user
        /// </summary>
        /// <remarks>
        /// Adds a new portal user with the first name, last name, email address, and several optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="memberRequestDto">The user request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-member/">REST API Reference for AddMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> AddMemberWithHttpInfoAsync(MemberRequestDto? memberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (memberRequestDto != null) localVarRequestOptions.Data = memberRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<EmployeeFullWrapper>("/api/2.0/people", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddMember", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper DeleteMember(string userid)
        {
            var localVarResponse = DeleteMemberWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> DeleteMemberWithHttpInfo(string userid)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->DeleteMember");

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
            var localVarResponse = Client.Delete<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteMember", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> DeleteMemberAsync(string userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteMemberWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <remarks>
        /// Deletes a user with the ID specified in the request from the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-member/">REST API Reference for DeleteMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> DeleteMemberWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->DeleteMember");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteMember", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper DeleteProfile()
        {
            var localVarResponse = DeleteProfileWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> DeleteProfileWithHttpInfo()
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
            var localVarResponse = Client.Delete<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteProfile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> DeleteProfileAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteProfileWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete my profile
        /// </summary>
        /// <remarks>
        /// Deletes the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-profile/">REST API Reference for DeleteProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> DeleteProfileWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteProfile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetAllProfiles(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default)
        {
            var localVarResponse = GetAllProfilesWithHttpInfo(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetAllProfilesWithHttpInfo(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "fields", fields));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllProfiles", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetAllProfilesAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllProfilesWithHttpInfoAsync(count, startIndex, filterBy, sortBy, sortOrder, filterSeparator, filterValue, fields, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get profiles
        /// </summary>
        /// <remarks>
        /// Returns a list of profiles for all the portal users.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="filterBy">Specifies the filter criteria for user-related queries. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The text value used as an additional filter criterion for profiles retrieval. (optional)</param>
        /// <param name="fields">Comma-separated list of fields to include in the response (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-profiles/">REST API Reference for GetAllProfiles Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetAllProfilesWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterBy = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, string fields = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (fields != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "fields", fields));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllProfiles", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper GetClaims()
        {
            var localVarResponse = GetClaimsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> GetClaimsWithHttpInfo()
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
            var localVarResponse = Client.Get<ObjectWrapper>("/api/2.0/people/tokendiagnostics", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClaims", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> GetClaimsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetClaimsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the user claims.
        /// </summary>
        /// <remarks>
        /// Returns the user claims.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-claims/">REST API Reference for GetClaims Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> GetClaimsWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectWrapper>("/api/2.0/people/tokendiagnostics", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetClaims", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper GetProfileByEmail(string? email = default, string? culture = default)
        {
            var localVarResponse = GetProfileByEmailWithHttpInfo(email, culture);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> GetProfileByEmailWithHttpInfo(string? email = default, string? culture = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "email", email));
            }
            if (culture != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "culture", culture));
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
            var localVarResponse = Client.Get<EmployeeFullWrapper>("/api/2.0/people/email", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByEmail", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> GetProfileByEmailAsync(string? email = default, string? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProfileByEmailWithHttpInfoAsync(email, culture, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user email
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the email specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">The user email address. (optional)</param>
        /// <param name="culture">Culture (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-email/">REST API Reference for GetProfileByEmail Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> GetProfileByEmailWithHttpInfoAsync(string? email = default, string? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (email != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "email", email));
            }
            if (culture != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "culture", culture));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullWrapper>("/api/2.0/people/email", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByEmail", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper GetProfileByUserId(string userid)
        {
            var localVarResponse = GetProfileByUserIdWithHttpInfo(userid);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> GetProfileByUserIdWithHttpInfo(string userid)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->GetProfileByUserId");

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
            var localVarResponse = Client.Get<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByUserId", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> GetProfileByUserIdAsync(string userid, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProfileByUserIdWithHttpInfoAsync(userid, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a profile by user name
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a profile of the user with the name specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-profile-by-user-id/">REST API Reference for GetProfileByUserId Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> GetProfileByUserIdWithHttpInfoAsync(string userid, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->GetProfileByUserId");

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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProfileByUserId", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper GetSelfProfile()
        {
            var localVarResponse = GetSelfProfileWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> GetSelfProfileWithHttpInfo()
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
            var localVarResponse = Client.Get<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSelfProfile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> GetSelfProfileAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSelfProfileWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get my profile
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about the current user profile.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-self-profile/">REST API Reference for GetSelfProfile Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> GetSelfProfileWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullWrapper>("/api/2.0/people/@self", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSelfProfile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        public EmployeeArrayWrapper InviteUsers(InviteUsersRequestDto? inviteUsersRequestDto = default)
        {
            var localVarResponse = InviteUsersWithHttpInfo(inviteUsersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        public ApiResponse<EmployeeArrayWrapper> InviteUsersWithHttpInfo(InviteUsersRequestDto? inviteUsersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inviteUsersRequestDto != null) localVarRequestOptions.Data = inviteUsersRequestDto;

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
            var localVarResponse = Client.Post<EmployeeArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InviteUsers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        public async Task<EmployeeArrayWrapper> InviteUsersAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await InviteUsersWithHttpInfoAsync(inviteUsersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Invite users
        /// </summary>
        /// <remarks>
        /// Invites users specified in the request to the current portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inviteUsersRequestDto">The request parameters for inviting users. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/invite-users/">REST API Reference for InviteUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeArrayWrapper>> InviteUsersWithHttpInfoAsync(InviteUsersRequestDto? inviteUsersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inviteUsersRequestDto != null) localVarRequestOptions.Data = inviteUsersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<EmployeeArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("InviteUsers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper RemoveUsers(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarResponse = RemoveUsersWithHttpInfo(updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> RemoveUsersWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveUsers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> RemoveUsersAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RemoveUsersWithHttpInfoAsync(updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete users
        /// </summary>
        /// <remarks>
        /// Deletes a list of the users with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-users/">REST API Reference for RemoveUsers Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> RemoveUsersWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveUsers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper ResendUserInvites(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarResponse = ResendUserInvitesWithHttpInfo(updateMembersRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> ResendUserInvitesWithHttpInfo(UpdateMembersRequestDto? updateMembersRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResendUserInvites", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> ResendUserInvitesAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ResendUserInvitesWithHttpInfoAsync(updateMembersRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resend activation emails
        /// </summary>
        /// <remarks>
        /// Resends emails to the users who have not activated their emails.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMembersRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-user-invites/">REST API Reference for ResendUserInvites Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> ResendUserInvitesWithHttpInfoAsync(UpdateMembersRequestDto? updateMembersRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMembersRequestDto != null) localVarRequestOptions.Data = updateMembersRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullArrayWrapper>("/api/2.0/people/invite", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResendUserInvites", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper SendEmailChangeInstructions(UpdateMemberRequestDto? updateMemberRequestDto = default)
        {
            var localVarResponse = SendEmailChangeInstructionsWithHttpInfo(updateMemberRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> SendEmailChangeInstructionsWithHttpInfo(UpdateMemberRequestDto? updateMemberRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMemberRequestDto != null) localVarRequestOptions.Data = updateMemberRequestDto;

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
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/people/email", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendEmailChangeInstructions", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> SendEmailChangeInstructionsAsync(UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SendEmailChangeInstructionsWithHttpInfoAsync(updateMemberRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send instructions to change email
        /// </summary>
        /// <remarks>
        /// Sends a message to the user email with the instructions to change the email address connected to the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-email-change-instructions/">REST API Reference for SendEmailChangeInstructions Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> SendEmailChangeInstructionsWithHttpInfoAsync(UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (updateMemberRequestDto != null) localVarRequestOptions.Data = updateMemberRequestDto;

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

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/people/email", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendEmailChangeInstructions", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper UpdateMember(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default)
        {
            var localVarResponse = UpdateMemberWithHttpInfo(userid, updateMemberRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> UpdateMemberWithHttpInfo(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMember");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (updateMemberRequestDto != null) localVarRequestOptions.Data = updateMemberRequestDto;

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
            var localVarResponse = Client.Put<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMember", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> UpdateMemberAsync(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateMemberWithHttpInfoAsync(userid, updateMemberRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <remarks>
        /// Updates the data for the selected portal user with the first name, last name, email address, and/or optional parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="updateMemberRequestDto">The request parameters for updating the user information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member/">REST API Reference for UpdateMember Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberWithHttpInfoAsync(string userid, UpdateMemberRequestDto? updateMemberRequestDto = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMember");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (updateMemberRequestDto != null) localVarRequestOptions.Data = updateMemberRequestDto;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMember", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>EmployeeFullWrapper</returns>
        public EmployeeFullWrapper UpdateMemberCulture(string userid, Culture? culture = default)
        {
            var localVarResponse = UpdateMemberCultureWithHttpInfo(userid, culture);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullWrapper</returns>
        public ApiResponse<EmployeeFullWrapper> UpdateMemberCultureWithHttpInfo(string userid, Culture? culture = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMemberCulture");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (culture != null) localVarRequestOptions.Data = culture;

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
            var localVarResponse = Client.Put<EmployeeFullWrapper>("/api/2.0/people/{userid}/culture", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMemberCulture", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of EmployeeFullWrapper</returns>
        public async Task<EmployeeFullWrapper> UpdateMemberCultureAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateMemberCultureWithHttpInfoAsync(userid, culture, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a user culture code
        /// </summary>
        /// <remarks>
        /// Updates the user culture code with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userid">The user ID.</param>
        /// <param name="culture">The culture code parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-member-culture/">REST API Reference for UpdateMemberCulture Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullWrapper>> UpdateMemberCultureWithHttpInfoAsync(string userid, Culture? culture = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userid' is set
            if (userid == null)
                throw new ApiException(400, "Missing required parameter 'userid' when calling ProfilesApi->UpdateMemberCulture");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("userid", ClientUtils.ParameterToString(userid)); // path parameter
            if (culture != null) localVarRequestOptions.Data = culture;

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

            var localVarResponse = await AsynchronousClient.PutAsync<EmployeeFullWrapper>("/api/2.0/people/{userid}/culture", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateMemberCulture", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
