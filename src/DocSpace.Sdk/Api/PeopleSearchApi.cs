// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using DocSpace.Sdk.Client;
using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleSearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper GetAccountsEntriesWithShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default);
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
    public interface IPeopleSearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        System.Threading.Tasks.Task<ObjectArrayWrapper> GetAccountsEntriesWithSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get account entries
        /// </summary>
        /// <remarks>
        /// Returns the account entries with their sharing settings.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        System.Threading.Tasks.Task<EmployeeFullArrayWrapper> GetSearchAsync(string query, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> GetSearchWithHttpInfoAsync(string query, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<EmployeeArrayWrapper> GetSimpleByFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<ApiResponse<EmployeeArrayWrapper>> GetSimpleByFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<EmployeeFullArrayWrapper> GetUsersWithRoomSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users with room sharing settings
        /// </summary>
        /// <remarks>
        /// Returns the users with the sharing settings in a room with the ID specified in request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithRoomSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<EmployeeFullArrayWrapper> SearchUsersByExtendedFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users with detaailed information by extended filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users with full information about them matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByExtendedFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        System.Threading.Tasks.Task<EmployeeArrayWrapper> SearchUsersByQueryAsync(string? query = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users (using query parameters)
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the search query. This method uses the query parameters.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmployeeArrayWrapper>> SearchUsersByQueryWithHttpInfoAsync(string? query = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        System.Threading.Tasks.Task<EmployeeFullArrayWrapper> SearchUsersByStatusAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search users by status filter
        /// </summary>
        /// <remarks>
        /// Returns a list of users matching the status filter and search query.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByStatusWithHttpInfoAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPeopleSearchApi : IPeopleSearchApiSync, IPeopleSearchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PeopleSearchApi : IDisposable, IPeopleSearchApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PeopleSearchApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PeopleSearchApi(string basePath)
        {
            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PeopleSearchApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PeopleSearchApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class.
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
        public PeopleSearchApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class using a Configuration object.
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
        public PeopleSearchApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = DocSpace.Sdk.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleSearchApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PeopleSearchApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DocSpace.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient.Dispose();
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
            return this.Configuration.BasePath;
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
        /// Get account entries Returns the account entries with their sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper GetAccountsEntriesWithShared(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
        {
            var localVarResponse = GetAccountsEntriesWithSharedWithHttpInfo(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries Returns the account entries with their sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> GetAccountsEntriesWithSharedWithHttpInfo(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default)
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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<ObjectArrayWrapper>("/api/2.0/accounts/room/{id}/search", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAccountsEntriesWithShared", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get account entries Returns the account entries with their sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectArrayWrapper> GetAccountsEntriesWithSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectArrayWrapper> localVarResponse = await GetAccountsEntriesWithSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get account entries Returns the account entries with their sharing settings.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-accounts-entries-with-shared/">REST API Reference for GetAccountsEntriesWithShared Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectArrayWrapper>> GetAccountsEntriesWithSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectArrayWrapper>("/api/2.0/accounts/room/{id}/search", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAccountsEntriesWithShared", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users Returns a list of users matching the search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Search users Returns a list of users matching the search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>ApiResponse of EmployeeFullArrayWrapper</returns>
        public ApiResponse<EmployeeFullArrayWrapper> GetSearchWithHttpInfo(string query, string? filterBy = default, string? filterValue = default)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling PeopleSearchApi->GetSearch");

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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/@search/{query}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users Returns a list of users matching the search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async System.Threading.Tasks.Task<EmployeeFullArrayWrapper> GetSearchAsync(string query, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeFullArrayWrapper> localVarResponse = await GetSearchWithHttpInfoAsync(query, filterBy, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users Returns a list of users matching the search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query.</param>
        /// <param name="filterBy">Specifies a filter criteria for the user search query. (optional)</param>
        /// <param name="filterValue">The value used for filtering users, allowing additional constraints for the query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-search/">REST API Reference for GetSearch Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> GetSearchWithHttpInfoAsync(string query, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling PeopleSearchApi->GetSearch");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/@search/{query}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by extended filter Returns a list of users matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Search users by extended filter Returns a list of users matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmployeeArrayWrapper>("/api/2.0/people/simple/filter", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSimpleByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by extended filter Returns a list of users matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<EmployeeArrayWrapper> GetSimpleByFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeArrayWrapper> localVarResponse = await GetSimpleByFilterWithHttpInfoAsync(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users by extended filter Returns a list of users matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeArrayWrapper>> GetSimpleByFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmployeeArrayWrapper>("/api/2.0/people/simple/filter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetSimpleByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with room sharing settings Returns the users with the sharing settings in a room with the ID specified in request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get users with room sharing settings Returns the users with the sharing settings in a room with the ID specified in request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/room/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetUsersWithRoomShared", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users with room sharing settings Returns the users with the sharing settings in a room with the ID specified in request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<EmployeeFullArrayWrapper> GetUsersWithRoomSharedAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeFullArrayWrapper> localVarResponse = await GetUsersWithRoomSharedWithHttpInfoAsync(id, employeeStatus, activationStatus, excludeShared, includeShared, invitedByMe, inviterId, area, employeeTypes, count, startIndex, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users with room sharing settings Returns the users with the sharing settings in a room with the ID specified in request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> GetUsersWithRoomSharedWithHttpInfoAsync(int id, EmployeeStatus? employeeStatus = default, EmployeeActivationStatus? activationStatus = default, bool? excludeShared = default, bool? includeShared = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, List<EmployeeType>? employeeTypes = default, int? count = default, int? startIndex = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/room/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetUsersWithRoomShared", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter Returns a list of users with full information about them matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Search users with detaailed information by extended filter Returns a list of users with full information about them matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/filter", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SearchUsersByExtendedFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter Returns a list of users with full information about them matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<EmployeeFullArrayWrapper> SearchUsersByExtendedFilterAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeFullArrayWrapper> localVarResponse = await SearchUsersByExtendedFilterWithHttpInfoAsync(employeeStatus, groupId, activationStatus, employeeType, employeeTypes, isAdministrator, payments, accountLoginType, quotaFilter, withoutGroup, excludeGroup, invitedByMe, inviterId, area, count, startIndex, sortBy, sortOrder, filterSeparator, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users with detaailed information by extended filter Returns a list of users with full information about them matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByExtendedFilterWithHttpInfoAsync(EmployeeStatus? employeeStatus = default, Guid? groupId = default, EmployeeActivationStatus? activationStatus = default, EmployeeType? employeeType = default, List<int>? employeeTypes = default, bool? isAdministrator = default, Payments? payments = default, AccountLoginType? accountLoginType = default, QuotaFilter? quotaFilter = default, bool? withoutGroup = default, bool? excludeGroup = default, bool? invitedByMe = default, Guid? inviterId = default, Area? area = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterSeparator = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/filter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SearchUsersByExtendedFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users (using query parameters) Returns a list of users matching the search query. This method uses the query parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>EmployeeArrayWrapper</returns>
        public EmployeeArrayWrapper SearchUsersByQuery(string? query = default)
        {
            var localVarResponse = SearchUsersByQueryWithHttpInfo(query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users (using query parameters) Returns a list of users matching the search query. This method uses the query parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmployeeArrayWrapper>("/api/2.0/people/search", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SearchUsersByQuery", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users (using query parameters) Returns a list of users matching the search query. This method uses the query parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of EmployeeArrayWrapper</returns>
        public async System.Threading.Tasks.Task<EmployeeArrayWrapper> SearchUsersByQueryAsync(string? query = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeArrayWrapper> localVarResponse = await SearchUsersByQueryWithHttpInfoAsync(query, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users (using query parameters) Returns a list of users matching the search query. This method uses the query parameters.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query">The search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-query/">REST API Reference for SearchUsersByQuery Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeArrayWrapper>> SearchUsersByQueryWithHttpInfoAsync(string? query = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmployeeArrayWrapper>("/api/2.0/people/search", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SearchUsersByQuery", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by status filter Returns a list of users matching the status filter and search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Search users by status filter Returns a list of users matching the status filter and search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}/search", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SearchUsersByStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Search users by status filter Returns a list of users matching the status filter and search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of EmployeeFullArrayWrapper</returns>
        public async System.Threading.Tasks.Task<EmployeeFullArrayWrapper> SearchUsersByStatusAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EmployeeFullArrayWrapper> localVarResponse = await SearchUsersByStatusWithHttpInfoAsync(status, query, filterBy, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Search users by status filter Returns a list of users matching the status filter and search query.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">The user status.</param>
        /// <param name="query">The advanced search query. (optional)</param>
        /// <param name="filterBy">Specifies the criteria used to filter search results in advanced queries. (optional)</param>
        /// <param name="filterValue">The value used to filter the search query. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/search-users-by-status/">REST API Reference for SearchUsersByStatus Operation</seealso>
        /// <returns>Task of ApiResponse (EmployeeFullArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmployeeFullArrayWrapper>> SearchUsersByStatusWithHttpInfoAsync(EmployeeStatus status, string? query = default, string? filterBy = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


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
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EmployeeFullArrayWrapper>("/api/2.0/people/status/{status}/search", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SearchUsersByStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
