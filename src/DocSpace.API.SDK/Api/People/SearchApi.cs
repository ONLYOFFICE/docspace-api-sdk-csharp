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
    public interface ISearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper GetAccountsEntriesWithFilesShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithFilesSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper GetAccountsEntriesWithFoldersShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithFoldersSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper GetAccountsEntriesWithRoomsShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithRoomsSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetSearch(string query, string? filterBy = default, string? filterValue = default);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetSearchWithHttpInfo(string query, string? filterBy = default, string? filterValue = default);
        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        EmployeeArrayWrapper GetSimpleByFilter(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        ApiResponse<EmployeeArrayWrapper> GetSimpleByFilterWithHttpInfo(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetUsersWithFilesShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetUsersWithFilesSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetUsersWithFoldersShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetUsersWithFoldersSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper GetUsersWithRoomShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> GetUsersWithRoomSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper SearchUsersByExtendedFilter(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> SearchUsersByExtendedFilterWithHttpInfo(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        EmployeeArrayWrapper SearchUsersByQuery(string? query = default);

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        ApiResponse<EmployeeArrayWrapper> SearchUsersByQueryWithHttpInfo(string? query = default);
        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        EmployeeFullArrayWrapper SearchUsersByStatus(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default);

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        ApiResponse<EmployeeFullArrayWrapper> SearchUsersByStatusWithHttpInfo(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        Task<ObjectArrayWrapper> GetAccountsEntriesWithFilesSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithFilesSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        Task<ObjectArrayWrapper> GetAccountsEntriesWithFoldersSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithFoldersSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        Task<ObjectArrayWrapper> GetAccountsEntriesWithRoomsSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithRoomsSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetSearchAsync(string query, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetSearchWithHttpInfoAsync(string query, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        Task<EmployeeArrayWrapper> GetSimpleByFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        Task<ApiResponse<EmployeeArrayWrapper>> GetSimpleByFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetUsersWithFilesSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithFilesSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetUsersWithFoldersSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithFoldersSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> GetUsersWithRoomSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithRoomSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> SearchUsersByExtendedFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByExtendedFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        Task<EmployeeArrayWrapper> SearchUsersByQueryAsync(string? query = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        Task<ApiResponse<EmployeeArrayWrapper>> SearchUsersByQueryWithHttpInfoAsync(string? query = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        Task<EmployeeFullArrayWrapper> SearchUsersByStatusAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByStatusWithHttpInfoAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi : ISearchApiSync, ISearchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : IDisposable, ISearchApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SearchApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SearchApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SearchApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SearchApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SearchApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
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
        public SearchApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SearchApi"/> class using a Configuration object.
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
        public SearchApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SearchApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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

        public SearchApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper GetAccountsEntriesWithFilesShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetAccountsEntriesWithFilesSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithFilesSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<ObjectArrayWrapper>("/api/2.0/accounts/file/{id}/search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountsEntriesWithFilesShared", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async Task<ObjectArrayWrapper> GetAccountsEntriesWithFilesSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAccountsEntriesWithFilesSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings for a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-files-shared/">REST API Reference for GetAccountsEntriesWithFilesShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithFilesSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectArrayWrapper>("/api/2.0/accounts/file/{id}/search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountsEntriesWithFilesShared", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper GetAccountsEntriesWithFoldersShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetAccountsEntriesWithFoldersSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithFoldersSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<ObjectArrayWrapper>("/api/2.0/accounts/folder/{id}/search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountsEntriesWithFoldersShared", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async Task<ObjectArrayWrapper> GetAccountsEntriesWithFoldersSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAccountsEntriesWithFoldersSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-folders-shared/">REST API Reference for GetAccountsEntriesWithFoldersShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithFoldersSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectArrayWrapper>("/api/2.0/accounts/folder/{id}/search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountsEntriesWithFoldersShared", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper GetAccountsEntriesWithRoomsShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetAccountsEntriesWithRoomsSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithRoomsSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<ObjectArrayWrapper>("/api/2.0/accounts/room/{id}/search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountsEntriesWithRoomsShared", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async Task<ObjectArrayWrapper> GetAccountsEntriesWithRoomsSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAccountsEntriesWithRoomsSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the account sharing settings from the response. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the account sharing settings in the response. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The area of the account entries. (optional)</param>
        /// <param name="employeeTypes">The list of the user types. (optional)</param>
        /// <param name="count">The number of items to retrieve in a request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="filterSeparator">Specifies the separator used in filter expressions. (optional)</param>
        /// <param name="filterValue">The text filter applied to the accounts search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-rooms-shared/">REST API Reference for GetAccountsEntriesWithRoomsShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithRoomsSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectArrayWrapper>("/api/2.0/accounts/room/{id}/search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAccountsEntriesWithRoomsShared", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetSearch(string query, string? filterBy = default, string? filterValue = default)
        {
            var localVarResponse = GetSearchWithHttpInfo(query, filterBy, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetSearchWithHttpInfo(string query, string? filterBy = default, string? filterValue = default)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SearchApi->GetSearch");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("query", ClientUtils.ParameterToString(query)); // path parameter
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/@search/{query}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetSearchAsync(string query, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSearchWithHttpInfoAsync(query, filterBy, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetSearchWithHttpInfoAsync(string query, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SearchApi->GetSearch");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("query", ClientUtils.ParameterToString(query)); // path parameter
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/@search/{query}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        public EmployeeArrayWrapper GetSimpleByFilter(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetSimpleByFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        public ApiResponse<EmployeeArrayWrapper> GetSimpleByFilterWithHttpInfo(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (groupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupId", groupId));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (employeeType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeType", employeeType));
            }
            if (employeeTypes != null)
            {
            }
            if (isAdministrator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isAdministrator", isAdministrator));
            }
            if (payments != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "payments", payments));
            }
            if (accountLoginType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "accountLoginType", accountLoginType));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (withoutGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutGroup", withoutGroup));
            }
            if (excludeGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeGroup", excludeGroup));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
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
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<EmployeeArrayWrapper>("/api/2.0/people/simple/filter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSimpleByFilter", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        public async Task<EmployeeArrayWrapper> GetSimpleByFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSimpleByFilterWithHttpInfoAsync(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-simple-by-filter/">REST API Reference for GetSimpleByFilter Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeArrayWrapper>> GetSimpleByFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (groupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupId", groupId));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (employeeType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeType", employeeType));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (isAdministrator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isAdministrator", isAdministrator));
            }
            if (payments != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "payments", payments));
            }
            if (accountLoginType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "accountLoginType", accountLoginType));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (withoutGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutGroup", withoutGroup));
            }
            if (excludeGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeGroup", excludeGroup));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
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
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeArrayWrapper>("/api/2.0/people/simple/filter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSimpleByFilter", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetUsersWithFilesShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetUsersWithFilesSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetUsersWithFilesSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/file/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUsersWithFilesShared", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetUsersWithFilesSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUsersWithFilesSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with file sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a file with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-files-shared/">REST API Reference for GetUsersWithFilesShared Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithFilesSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/file/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUsersWithFilesShared", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetUsersWithFoldersShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetUsersWithFoldersSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetUsersWithFoldersSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/folder/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUsersWithFoldersShared", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetUsersWithFoldersSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUsersWithFoldersSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with folder sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a folder with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-folders-shared/">REST API Reference for GetUsersWithFoldersShared Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithFoldersSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/folder/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUsersWithFoldersShared", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper GetUsersWithRoomShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetUsersWithRoomSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetUsersWithRoomSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/room/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUsersWithRoomShared", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> GetUsersWithRoomSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUsersWithRoomSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The user ID.</param>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="excludeShared">Specifies whether to exclude the user sharing settings or not. (optional)</param>
        /// <param name="includeShared">Specifies whether to include the user sharing settings or not. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user was invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The user area. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="count">The maximum number of users to be retrieved in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first record to retrieve in a paged query. (optional)</param>
        /// <param name="filterSeparator">The character or string used to separate multiple filter values in a filtering query. (optional)</param>
        /// <param name="filterValue">The filter text value used for searching or filtering user results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-users-with-room-shared/">REST API Reference for GetUsersWithRoomShared Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithRoomSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
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
            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (excludeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeShared", excludeShared));
            }
            if (includeShared != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "includeShared", includeShared));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/room/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUsersWithRoomShared", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper SearchUsersByExtendedFilter(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = SearchUsersByExtendedFilterWithHttpInfo(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> SearchUsersByExtendedFilterWithHttpInfo(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (groupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupId", groupId));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (employeeType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeType", employeeType));
            }
            if (employeeTypes != null)
            {
            }
            if (isAdministrator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isAdministrator", isAdministrator));
            }
            if (payments != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "payments", payments));
            }
            if (accountLoginType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "accountLoginType", accountLoginType));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (withoutGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutGroup", withoutGroup));
            }
            if (excludeGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeGroup", excludeGroup));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
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
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/filter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SearchUsersByExtendedFilter", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> SearchUsersByExtendedFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SearchUsersByExtendedFilterWithHttpInfoAsync(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="employeeStatus">The user status. (optional)</param>
        /// <param name="groupId">The group ID. (optional)</param>
        /// <param name="activationStatus">The user activation status. (optional)</param>
        /// <param name="employeeType">The user type. (optional)</param>
        /// <param name="employeeTypes">The list of user types. (optional)</param>
        /// <param name="isAdministrator">Specifies if the user is an administrator or not. (optional)</param>
        /// <param name="payments">The user payment status. (optional)</param>
        /// <param name="accountLoginType">The account login type. (optional)</param>
        /// <param name="quotaFilter">The quota filter (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="withoutGroup">Specifies whether the user should be a member of a group or not. (optional)</param>
        /// <param name="excludeGroup">Specifies whether the user should be a member of the group with the specified ID. (optional)</param>
        /// <param name="invitedByMe">Specifies whether the user is invited by the current user or not. (optional)</param>
        /// <param name="inviterId">The inviter ID. (optional)</param>
        /// <param name="area">The filter area. (optional)</param>
        /// <param name="count">The maximum number of items to be retrieved in the response. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to be retrieved in a filtered result set. (optional)</param>
        /// <param name="sortBy">Specifies the property or field name by which the results should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterSeparator">Represents the separator used to split filter criteria in query parameters. (optional)</param>
        /// <param name="filterValue">The search text used to filter results based on user input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-extended-filter/">REST API Reference for SearchUsersByExtendedFilter Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByExtendedFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (employeeStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeStatus", employeeStatus));
            }
            if (groupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "groupId", groupId));
            }
            if (activationStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activationStatus", activationStatus));
            }
            if (employeeType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "employeeType", employeeType));
            }
            if (employeeTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "employeeTypes", employeeTypes));
            }
            if (isAdministrator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isAdministrator", isAdministrator));
            }
            if (payments != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "payments", payments));
            }
            if (accountLoginType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "accountLoginType", accountLoginType));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (withoutGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutGroup", withoutGroup));
            }
            if (excludeGroup != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeGroup", excludeGroup));
            }
            if (invitedByMe != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "invitedByMe", invitedByMe));
            }
            if (inviterId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inviterId", inviterId));
            }
            if (area != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "area", area));
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
            if (filterSeparator != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterSeparator", filterSeparator));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/filter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SearchUsersByExtendedFilter", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        public EmployeeArrayWrapper SearchUsersByQuery(string? query = default)
        {
            var localVarResponse = SearchUsersByQueryWithHttpInfo(query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>ApiResponse of EmployeeArrayWrapper</returns>
        public ApiResponse<EmployeeArrayWrapper> SearchUsersByQueryWithHttpInfo(string? query = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
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
            var localVarResponse = Client.Get<EmployeeArrayWrapper>("/api/2.0/people/search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SearchUsersByQuery", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        public async Task<EmployeeArrayWrapper> SearchUsersByQueryAsync(string? query = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SearchUsersByQueryWithHttpInfoAsync(query, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeArrayWrapper>> SearchUsersByQueryWithHttpInfoAsync(string? query = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeArrayWrapper>("/api/2.0/people/search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SearchUsersByQuery", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>EmployeeFullArrayWrapper</returns>
        public EmployeeFullArrayWrapper SearchUsersByStatus(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default)
        {
            var localVarResponse = SearchUsersByStatusWithHttpInfo(status, query, filterBy, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> SearchUsersByStatusWithHttpInfo(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("status", ClientUtils.ParameterToString(status)); // path parameter
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
            }
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
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
            var localVarResponse = Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}/search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SearchUsersByStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async Task<EmployeeFullArrayWrapper> SearchUsersByStatusAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SearchUsersByStatusWithHttpInfoAsync(status, query, filterBy, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByStatusWithHttpInfoAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("status", ClientUtils.ParameterToString(status)); // path parameter
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
            }
            if (filterBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterBy", filterBy));
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

            var localVarResponse = await AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}/search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SearchUsersByStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
