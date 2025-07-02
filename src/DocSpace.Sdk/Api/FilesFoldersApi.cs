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
    public interface IFilesFoldersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check file uploads
        /// </summary>
        /// <remarks>
        /// Checks the file uploads to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        STRINGArrayWrapper CheckUpload(int folderId, CheckUploadRequest? checkUploadRequest = default);

        /// <summary>
        /// Check file uploads
        /// </summary>
        /// <remarks>
        /// Checks the file uploads to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        ApiResponse<STRINGArrayWrapper> CheckUploadWithHttpInfo(int folderId, CheckUploadRequest? checkUploadRequest = default);
        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateFolder(int folderId, CreateFolder? createFolder = default);

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateFolderWithHttpInfo(int folderId, CreateFolder? createFolder = default);
        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Deletes a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteFolder(int folderId, DeleteFolder? deleteFolder = default);

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Deletes a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteFolderWithHttpInfo(int folderId, DeleteFolder? deleteFolder = default);
        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Returns the used space of files in the root folders.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>FilesStatisticsResultWrapper</returns>
        FilesStatisticsResultWrapper GetFilesUsedSpace();

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Returns the used space of files in the root folders.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>ApiResponse of FilesStatisticsResultWrapper</returns>
        ApiResponse<FilesStatisticsResultWrapper> GetFilesUsedSpaceWithHttpInfo();
        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Returns the form filter of a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>FormsItemArrayWrapper</returns>
        FormsItemArrayWrapper GetFolder(int folderId);

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Returns the form filter of a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>ApiResponse of FormsItemArrayWrapper</returns>
        ApiResponse<FormsItemArrayWrapper> GetFolderWithHttpInfo(int folderId);
        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetFolderByFolderId(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetFolderByFolderIdWithHttpInfo(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Returns the activity history of a folder with a specified identifier.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        HistoryArrayWrapper GetFolderHistory(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Returns the activity history of a folder with a specified identifier.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        ApiResponse<HistoryArrayWrapper> GetFolderHistoryWithHttpInfo(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper GetFolderInfo(int folderId);

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> GetFolderInfoWithHttpInfo(int folderId);
        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns a path to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        FileEntryArrayWrapper GetFolderPath(int folderId);

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns a path to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        ApiResponse<FileEntryArrayWrapper> GetFolderPathWithHttpInfo(int folderId);
        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper GetFolderPrimaryExternalLink(int id);

        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> GetFolderPrimaryExternalLinkWithHttpInfo(int id);
        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        FileEntryArrayWrapper GetFolders(int folderId);

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        ApiResponse<FileEntryArrayWrapper> GetFoldersWithHttpInfo(int folderId);
        /// <summary>
        /// Get the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetMyFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetMyFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        FileEntryArrayWrapper GetNewFolderItems(int folderId);

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        ApiResponse<FileEntryArrayWrapper> GetNewFolderItemsWithHttpInfo(int folderId);
        /// <summary>
        /// Get the \&quot;Private Room\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetPrivacyFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the \&quot;Private Room\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetPrivacyFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns all the sections matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>FolderContentIntegerArrayWrapper</returns>
        FolderContentIntegerArrayWrapper GetRootFolders(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns all the sections matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerArrayWrapper</returns>
        ApiResponse<FolderContentIntegerArrayWrapper> GetRootFoldersWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Get the \&quot;Trash\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetTrashFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// Get the \&quot;Trash\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetTrashFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the selected folder by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper InsertFile(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default);

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the selected folder by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> InsertFileWithHttpInfo(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default);
        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper InsertFileToMyFromBody(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default);

        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> InsertFileToMyFromBodyWithHttpInfo(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default);
        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Renames the selected folder with a new title specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper RenameFolder(int folderId, CreateFolder? createFolder = default);

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Renames the selected folder with a new title specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> RenameFolderWithHttpInfo(int folderId, CreateFolder? createFolder = default);
        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Sets the file order in the folder with ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper SetFolderOrder(int folderId, OrderRequestDto? orderRequestDto = default);

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Sets the file order in the folder with ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> SetFolderOrderWithHttpInfo(int folderId, OrderRequestDto? orderRequestDto = default);
        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper UploadFile(int folderId, UploadRequestDto? uploadRequestDto = default);

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> UploadFileWithHttpInfo(int folderId, UploadRequestDto? uploadRequestDto = default);
        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper UploadFileToMy(UploadRequestDto? inDto = default);

        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> UploadFileToMyWithHttpInfo(UploadRequestDto? inDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesFoldersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Check file uploads
        /// </summary>
        /// <remarks>
        /// Checks the file uploads to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        System.Threading.Tasks.Task<STRINGArrayWrapper> CheckUploadAsync(int folderId, CheckUploadRequest? checkUploadRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check file uploads
        /// </summary>
        /// <remarks>
        /// Checks the file uploads to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<STRINGArrayWrapper>> CheckUploadWithHttpInfoAsync(int folderId, CheckUploadRequest? checkUploadRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> CreateFolderAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a folder
        /// </summary>
        /// <remarks>
        /// Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> CreateFolderWithHttpInfoAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Deletes a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        System.Threading.Tasks.Task<FileOperationArrayWrapper> DeleteFolderAsync(int folderId, DeleteFolder? deleteFolder = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a folder
        /// </summary>
        /// <remarks>
        /// Deletes a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileOperationArrayWrapper>> DeleteFolderWithHttpInfoAsync(int folderId, DeleteFolder? deleteFolder = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Returns the used space of files in the root folders.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of FilesStatisticsResultWrapper</returns>
        System.Threading.Tasks.Task<FilesStatisticsResultWrapper> GetFilesUsedSpaceAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get used space of files
        /// </summary>
        /// <remarks>
        /// Returns the used space of files in the root folders.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of ApiResponse (FilesStatisticsResultWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FilesStatisticsResultWrapper>> GetFilesUsedSpaceWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Returns the form filter of a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of FormsItemArrayWrapper</returns>
        System.Threading.Tasks.Task<FormsItemArrayWrapper> GetFolderAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder form filter
        /// </summary>
        /// <remarks>
        /// Returns the form filter of a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FormsItemArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormsItemArrayWrapper>> GetFolderWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetFolderByFolderIdAsync(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get a folder by ID
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetFolderByFolderIdWithHttpInfoAsync(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Returns the activity history of a folder with a specified identifier.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        System.Threading.Tasks.Task<HistoryArrayWrapper> GetFolderHistoryAsync(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder history
        /// </summary>
        /// <remarks>
        /// Returns the activity history of a folder with a specified identifier.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoryArrayWrapper>> GetFolderHistoryWithHttpInfoAsync(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> GetFolderInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> GetFolderInfoWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns a path to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        System.Threading.Tasks.Task<FileEntryArrayWrapper> GetFolderPathAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the folder path
        /// </summary>
        /// <remarks>
        /// Returns a path to the folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileEntryArrayWrapper>> GetFolderPathWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        System.Threading.Tasks.Task<FileShareWrapper> GetFolderPrimaryExternalLinkAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> GetFolderPrimaryExternalLinkWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        System.Threading.Tasks.Task<FileEntryArrayWrapper> GetFoldersAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get subfolders
        /// </summary>
        /// <remarks>
        /// Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileEntryArrayWrapper>> GetFoldersWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetMyFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetMyFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        System.Threading.Tasks.Task<FileEntryArrayWrapper> GetNewFolderItemsAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get new folder items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a folder with the ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileEntryArrayWrapper>> GetNewFolderItemsWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the \&quot;Private Room\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetPrivacyFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the \&quot;Private Room\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetPrivacyFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns all the sections matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of FolderContentIntegerArrayWrapper</returns>
        System.Threading.Tasks.Task<FolderContentIntegerArrayWrapper> GetRootFoldersAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get filtered sections
        /// </summary>
        /// <remarks>
        /// Returns all the sections matching the parameters specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerArrayWrapper>> GetRootFoldersWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the \&quot;Trash\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetTrashFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the \&quot;Trash\&quot; section
        /// </summary>
        /// <remarks>
        /// Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetTrashFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the selected folder by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> InsertFileAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert a file
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the selected folder by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> InsertFileWithHttpInfoAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> InsertFileToMyFromBodyAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> InsertFileToMyFromBodyWithHttpInfoAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Renames the selected folder with a new title specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> RenameFolderAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename a folder
        /// </summary>
        /// <remarks>
        /// Renames the selected folder with a new title specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> RenameFolderWithHttpInfoAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Sets the file order in the folder with ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> SetFolderOrderAsync(int folderId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set folder order
        /// </summary>
        /// <remarks>
        /// Sets the file order in the folder with ID specified in the request.
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> SetFolderOrderWithHttpInfoAsync(int folderId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> UploadFileAsync(int folderId, UploadRequestDto? uploadRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> UploadFileWithHttpInfoAsync(int folderId, UploadRequestDto? uploadRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> UploadFileToMyAsync(UploadRequestDto? inDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </remarks>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> UploadFileToMyWithHttpInfoAsync(UploadRequestDto? inDto = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesFoldersApi : IFilesFoldersApiSync, IFilesFoldersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FilesFoldersApi : IDisposable, IFilesFoldersApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FilesFoldersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FilesFoldersApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FilesFoldersApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FilesFoldersApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class.
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
        public FilesFoldersApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class using a Configuration object.
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
        public FilesFoldersApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FilesFoldersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FilesFoldersApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Check file uploads Checks the file uploads to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>STRINGArrayWrapper</returns>
        public STRINGArrayWrapper CheckUpload(int folderId, CheckUploadRequest? checkUploadRequest = default)
        {
            var localVarResponse = CheckUploadWithHttpInfo(folderId, checkUploadRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check file uploads Checks the file uploads to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>ApiResponse of STRINGArrayWrapper</returns>
        public ApiResponse<STRINGArrayWrapper> CheckUploadWithHttpInfo(int folderId, CheckUploadRequest? checkUploadRequest = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (checkUploadRequest != null) localVarRequestOptions.Data = checkUploadRequest;

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
            var localVarResponse = this.Client.Post<STRINGArrayWrapper>("/api/2.0/files/{folderId}/upload/check", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckUpload", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check file uploads Checks the file uploads to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of STRINGArrayWrapper</returns>
        public async System.Threading.Tasks.Task<STRINGArrayWrapper> CheckUploadAsync(int folderId, CheckUploadRequest? checkUploadRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<STRINGArrayWrapper> localVarResponse = await CheckUploadWithHttpInfoAsync(folderId, checkUploadRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check file uploads Checks the file uploads to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="checkUploadRequest">The request parameters for checking file uploads. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-upload/">REST API Reference for CheckUpload Operation</seealso>
        /// <returns>Task of ApiResponse (STRINGArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<STRINGArrayWrapper>> CheckUploadWithHttpInfoAsync(int folderId, CheckUploadRequest? checkUploadRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (checkUploadRequest != null) localVarRequestOptions.Data = checkUploadRequest;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<STRINGArrayWrapper>("/api/2.0/files/{folderId}/upload/check", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckUpload", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a folder Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateFolder(int folderId, CreateFolder? createFolder = default)
        {
            var localVarResponse = CreateFolderWithHttpInfo(folderId, createFolder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a folder Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> CreateFolderWithHttpInfo(int folderId, CreateFolder? createFolder = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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
            var localVarResponse = this.Client.Post<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a folder Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> CreateFolderAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderIntegerWrapper> localVarResponse = await CreateFolderWithHttpInfoAsync(folderId, createFolder, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a folder Creates a new folder with the title specified in the request. The parent folder ID can be also specified.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-folder/">REST API Reference for CreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> CreateFolderWithHttpInfoAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a folder Deletes a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteFolder(int folderId, DeleteFolder? deleteFolder = default)
        {
            var localVarResponse = DeleteFolderWithHttpInfo(folderId, deleteFolder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a folder Deletes a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteFolderWithHttpInfo(int folderId, DeleteFolder? deleteFolder = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (deleteFolder != null) localVarRequestOptions.Data = deleteFolder;

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
            var localVarResponse = this.Client.Delete<FileOperationArrayWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a folder Deletes a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileOperationArrayWrapper> DeleteFolderAsync(int folderId, DeleteFolder? deleteFolder = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileOperationArrayWrapper> localVarResponse = await DeleteFolderWithHttpInfoAsync(folderId, deleteFolder, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a folder Deletes a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to delete.</param>
        /// <param name="deleteFolder">The parameters for deleting a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-folder/">REST API Reference for DeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileOperationArrayWrapper>> DeleteFolderWithHttpInfoAsync(int folderId, DeleteFolder? deleteFolder = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (deleteFolder != null) localVarRequestOptions.Data = deleteFolder;

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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<FileOperationArrayWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get used space of files Returns the used space of files in the root folders.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>FilesStatisticsResultWrapper</returns>
        public FilesStatisticsResultWrapper GetFilesUsedSpace()
        {
            var localVarResponse = GetFilesUsedSpaceWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get used space of files Returns the used space of files in the root folders.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>ApiResponse of FilesStatisticsResultWrapper</returns>
        public ApiResponse<FilesStatisticsResultWrapper> GetFilesUsedSpaceWithHttpInfo()
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
            var localVarResponse = this.Client.Get<FilesStatisticsResultWrapper>("/api/2.0/files/filesusedspace", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilesUsedSpace", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get used space of files Returns the used space of files in the root folders.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of FilesStatisticsResultWrapper</returns>
        public async System.Threading.Tasks.Task<FilesStatisticsResultWrapper> GetFilesUsedSpaceAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FilesStatisticsResultWrapper> localVarResponse = await GetFilesUsedSpaceWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get used space of files Returns the used space of files in the root folders.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-files-used-space/">REST API Reference for GetFilesUsedSpace Operation</seealso>
        /// <returns>Task of ApiResponse (FilesStatisticsResultWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FilesStatisticsResultWrapper>> GetFilesUsedSpaceWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FilesStatisticsResultWrapper>("/api/2.0/files/filesusedspace", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilesUsedSpace", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder form filter Returns the form filter of a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>FormsItemArrayWrapper</returns>
        public FormsItemArrayWrapper GetFolder(int folderId)
        {
            var localVarResponse = GetFolderWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder form filter Returns the form filter of a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>ApiResponse of FormsItemArrayWrapper</returns>
        public ApiResponse<FormsItemArrayWrapper> GetFolderWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<FormsItemArrayWrapper>("/api/2.0/files/{folderId}/formfilter", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder form filter Returns the form filter of a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of FormsItemArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FormsItemArrayWrapper> GetFolderAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FormsItemArrayWrapper> localVarResponse = await GetFolderWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder form filter Returns the form filter of a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder/">REST API Reference for GetFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FormsItemArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormsItemArrayWrapper>> GetFolderWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FormsItemArrayWrapper>("/api/2.0/files/{folderId}/formfilter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a folder by ID Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetFolderByFolderId(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetFolderByFolderIdWithHttpInfo(folderId, userIdOrGroupId, filterType, roomId, excludeSubject, applyFilterOption, extension, searchArea, formsItemKey, formsItemType, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a folder by ID Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetFolderByFolderIdWithHttpInfo(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (roomId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
            }
            if (extension != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "extension", extension));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (formsItemKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemKey", formsItemKey));
            }
            if (formsItemType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemType", formsItemType));
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


            // make the HTTP request
            var localVarResponse = this.Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/{folderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderByFolderId", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a folder by ID Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetFolderByFolderIdAsync(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderContentIntegerWrapper> localVarResponse = await GetFolderByFolderIdWithHttpInfoAsync(folderId, userIdOrGroupId, filterType, roomId, excludeSubject, applyFilterOption, extension, searchArea, formsItemKey, formsItemType, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a folder by ID Returns the detailed list of files and folders located in the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the request.</param>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="roomId">The room ID. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements from the specified folder. (optional)</param>
        /// <param name="extension">Specifies whether to search for the specific file extension. (optional)</param>
        /// <param name="searchArea">The search area. (optional)</param>
        /// <param name="formsItemKey">The forms item key. (optional)</param>
        /// <param name="formsItemType">The forms item type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated request. (optional)</param>
        /// <param name="sortBy">Specifies the property used for sorting the folder request results. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text value used as a filter parameter for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-by-folder-id/">REST API Reference for GetFolderByFolderId Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetFolderByFolderIdWithHttpInfoAsync(int folderId, Guid? userIdOrGroupId = default, FilterType? filterType = default, int? roomId = default, bool? excludeSubject = default, ApplyFilterOption? applyFilterOption = default, string? extension = default, SearchArea? searchArea = default, string? formsItemKey = default, string? formsItemType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (roomId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "roomId", roomId));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
            }
            if (extension != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "extension", extension));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (formsItemKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemKey", formsItemKey));
            }
            if (formsItemType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "formsItemType", formsItemType));
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


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/{folderId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderByFolderId", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder history Returns the activity history of a folder with a specified identifier.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        public HistoryArrayWrapper GetFolderHistory(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFolderHistoryWithHttpInfo(folderId, fromDate, toDate, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder history Returns the activity history of a folder with a specified identifier.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        public ApiResponse<HistoryArrayWrapper> GetFolderHistoryWithHttpInfo(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
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
            var localVarResponse = this.Client.Get<HistoryArrayWrapper>("/api/2.0/files/folder/{folderId}/log", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder history Returns the activity history of a folder with a specified identifier.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<HistoryArrayWrapper> GetFolderHistoryAsync(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<HistoryArrayWrapper> localVarResponse = await GetFolderHistoryWithHttpInfoAsync(folderId, fromDate, toDate, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder history Returns the activity history of a folder with a specified identifier.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the history request.</param>
        /// <param name="fromDate">The start date of the history request. (optional)</param>
        /// <param name="toDate">The end date of the history request. (optional)</param>
        /// <param name="count">The number of records to retrieve for the folder history. (optional)</param>
        /// <param name="startIndex">The starting index from which the history records are retrieved in the request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-history/">REST API Reference for GetFolderHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoryArrayWrapper>> GetFolderHistoryWithHttpInfoAsync(int folderId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<HistoryArrayWrapper>("/api/2.0/files/folder/{folderId}/log", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder information Returns the detailed information about a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper GetFolderInfo(int folderId)
        {
            var localVarResponse = GetFolderInfoWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder information Returns the detailed information about a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> GetFolderInfoWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder information Returns the detailed information about a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> GetFolderInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderIntegerWrapper> localVarResponse = await GetFolderInfoWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder information Returns the detailed information about a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-info/">REST API Reference for GetFolderInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> GetFolderInfoWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder path Returns a path to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        public FileEntryArrayWrapper GetFolderPath(int folderId)
        {
            var localVarResponse = GetFolderPathWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder path Returns a path to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        public ApiResponse<FileEntryArrayWrapper> GetFolderPathWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = this.Client.Get<FileEntryArrayWrapper>("/api/2.0/files/folder/{folderId}/path", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderPath", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the folder path Returns a path to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileEntryArrayWrapper> GetFolderPathAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileEntryArrayWrapper> localVarResponse = await GetFolderPathWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the folder path Returns a path to the folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-path/">REST API Reference for GetFolderPath Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileEntryArrayWrapper>> GetFolderPathWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileEntryArrayWrapper>("/api/2.0/files/folder/{folderId}/path", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderPath", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper GetFolderPrimaryExternalLink(int id)
        {
            var localVarResponse = GetFolderPrimaryExternalLinkWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> GetFolderPrimaryExternalLinkWithHttpInfo(int id)
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


            // make the HTTP request
            var localVarResponse = this.Client.Get<FileShareWrapper>("/api/2.0/files/folder/{id}/link", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderPrimaryExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareWrapper> GetFolderPrimaryExternalLinkAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileShareWrapper> localVarResponse = await GetFolderPrimaryExternalLinkWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-primary-external-link/">REST API Reference for GetFolderPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> GetFolderPrimaryExternalLinkWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
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


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileShareWrapper>("/api/2.0/files/folder/{id}/link", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolderPrimaryExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get subfolders Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        public FileEntryArrayWrapper GetFolders(int folderId)
        {
            var localVarResponse = GetFoldersWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get subfolders Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        public ApiResponse<FileEntryArrayWrapper> GetFoldersWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = this.Client.Get<FileEntryArrayWrapper>("/api/2.0/files/{folderId}/subfolders", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolders", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get subfolders Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileEntryArrayWrapper> GetFoldersAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileEntryArrayWrapper> localVarResponse = await GetFoldersWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get subfolders Returns a list of all the subfolders from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folders/">REST API Reference for GetFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileEntryArrayWrapper>> GetFoldersWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileEntryArrayWrapper>("/api/2.0/files/{folderId}/subfolders", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFolders", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;My documents\&quot; section Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetMyFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetMyFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;My documents\&quot; section Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetMyFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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
            var localVarResponse = this.Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@my", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetMyFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;My documents\&quot; section Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetMyFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderContentIntegerWrapper> localVarResponse = await GetMyFolderWithHttpInfoAsync(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;My documents\&quot; section Returns the detailed list of files and folders located in the \&quot;My documents\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-my-folder/">REST API Reference for GetMyFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetMyFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@my", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetMyFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get new folder items Returns a list of all the new items from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>FileEntryArrayWrapper</returns>
        public FileEntryArrayWrapper GetNewFolderItems(int folderId)
        {
            var localVarResponse = GetNewFolderItemsWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get new folder items Returns a list of all the new items from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryArrayWrapper</returns>
        public ApiResponse<FileEntryArrayWrapper> GetNewFolderItemsWithHttpInfo(int folderId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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
            var localVarResponse = this.Client.Get<FileEntryArrayWrapper>("/api/2.0/files/{folderId}/news", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetNewFolderItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get new folder items Returns a list of all the new items from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of FileEntryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileEntryArrayWrapper> GetNewFolderItemsAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileEntryArrayWrapper> localVarResponse = await GetNewFolderItemsWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get new folder items Returns a list of all the new items from a folder with the ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The request folder ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-folder-items/">REST API Reference for GetNewFolderItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileEntryArrayWrapper>> GetNewFolderItemsWithHttpInfoAsync(int folderId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileEntryArrayWrapper>("/api/2.0/files/{folderId}/news", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetNewFolderItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;Private Room\&quot; section Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetPrivacyFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetPrivacyFolderWithHttpInfo(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;Private Room\&quot; section Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetPrivacyFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
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
            var localVarResponse = this.Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@privacy", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPrivacyFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;Private Room\&quot; section Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetPrivacyFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderContentIntegerWrapper> localVarResponse = await GetPrivacyFolderWithHttpInfoAsync(userIdOrGroupId, filterType, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;Private Room\&quot; section Returns the detailed list of files and folders located in the \&quot;Private Room\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The zero-based index of the first item to retrieve in a paginated list. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter or search criterion for folder content queries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-privacy-folder/">REST API Reference for GetPrivacyFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetPrivacyFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@privacy", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPrivacyFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered sections Returns all the sections matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>FolderContentIntegerArrayWrapper</returns>
        public FolderContentIntegerArrayWrapper GetRootFolders(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetRootFoldersWithHttpInfo(userIdOrGroupId, filterType, withoutTrash, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered sections Returns all the sections matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerArrayWrapper</returns>
        public ApiResponse<FolderContentIntegerArrayWrapper> GetRootFoldersWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (withoutTrash != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTrash", withoutTrash));
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
            var localVarResponse = this.Client.Get<FolderContentIntegerArrayWrapper>("/api/2.0/files/@root", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetRootFolders", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get filtered sections Returns all the sections matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of FolderContentIntegerArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FolderContentIntegerArrayWrapper> GetRootFoldersAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderContentIntegerArrayWrapper> localVarResponse = await GetRootFoldersWithHttpInfoAsync(userIdOrGroupId, filterType, withoutTrash, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get filtered sections Returns all the sections matching the parameters specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="withoutTrash">Specifies whether to return the \&quot;Trash\&quot; section or not. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the folder content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used as a filter for searching or retrieving folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-root-folders/">REST API Reference for GetRootFolders Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerArrayWrapper>> GetRootFoldersWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, bool? withoutTrash = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (withoutTrash != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTrash", withoutTrash));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderContentIntegerArrayWrapper>("/api/2.0/files/@root", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetRootFolders", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;Trash\&quot; section Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetTrashFolder(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetTrashFolderWithHttpInfo(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;Trash\&quot; section Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetTrashFolderWithHttpInfo(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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
            var localVarResponse = this.Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/@trash", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetTrashFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the \&quot;Trash\&quot; section Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetTrashFolderAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderContentIntegerWrapper> localVarResponse = await GetTrashFolderWithHttpInfoAsync(userIdOrGroupId, filterType, applyFilterOption, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the \&quot;Trash\&quot; section Returns the detailed list of files and folders located in the \&quot;Trash\&quot; section.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userIdOrGroupId">The user or group ID. (optional)</param>
        /// <param name="filterType">The filter type. (optional)</param>
        /// <param name="applyFilterOption">Specifies whether to return only files, only folders or all elements. (optional)</param>
        /// <param name="count">The maximum number of items to retrieve in the response. (optional)</param>
        /// <param name="startIndex">The starting position of the items to be retrieved. (optional)</param>
        /// <param name="sortBy">The property used to specify the sorting criteria for folder contents. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text used for filtering or searching folder contents. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-trash-folder/">REST API Reference for GetTrashFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetTrashFolderWithHttpInfoAsync(Guid? userIdOrGroupId = default, FilterType? filterType = default, ApplyFilterOption? applyFilterOption = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (userIdOrGroupId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "userIdOrGroupId", userIdOrGroupId));
            }
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (applyFilterOption != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "applyFilterOption", applyFilterOption));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/@trash", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetTrashFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file Inserts a file specified in the request to the selected folder by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper InsertFile(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default)
        {
            var localVarResponse = InsertFileWithHttpInfo(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file Inserts a file specified in the request to the selected folder by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> InsertFileWithHttpInfo(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (insertFileFile != null)
            {
                localVarRequestOptions.FileParameters.Add("InsertFile.File", insertFileFile);
            }
            if (insertFileTitle != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Title",ClientUtils.ParameterToString(insertFileTitle)); // form parameter
            }
            if (insertFileCreateNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.CreateNewIfExist",ClientUtils.ParameterToString(insertFileCreateNewIfExist)); // form parameter
            }
            if (insertFileKeepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.KeepConvertStatus",ClientUtils.ParameterToString(insertFileKeepConvertStatus)); // form parameter
            }
            if (insertFileStreamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanRead",ClientUtils.ParameterToString(insertFileStreamCanRead)); // form parameter
            }
            if (insertFileStreamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanWrite",ClientUtils.ParameterToString(insertFileStreamCanWrite)); // form parameter
            }
            if (insertFileStreamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanSeek",ClientUtils.ParameterToString(insertFileStreamCanSeek)); // form parameter
            }
            if (insertFileStreamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanTimeout",ClientUtils.ParameterToString(insertFileStreamCanTimeout)); // form parameter
            }
            if (insertFileStreamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Length",ClientUtils.ParameterToString(insertFileStreamLength)); // form parameter
            }
            if (insertFileStreamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Position",ClientUtils.ParameterToString(insertFileStreamPosition)); // form parameter
            }
            if (insertFileStreamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.ReadTimeout",ClientUtils.ParameterToString(insertFileStreamReadTimeout)); // form parameter
            }
            if (insertFileStreamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.WriteTimeout",ClientUtils.ParameterToString(insertFileStreamWriteTimeout)); // form parameter
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/insert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("InsertFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file Inserts a file specified in the request to the selected folder by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> InsertFileAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await InsertFileWithHttpInfoAsync(folderId, insertFileFile, insertFileTitle, insertFileCreateNewIfExist, insertFileKeepConvertStatus, insertFileStreamCanRead, insertFileStreamCanWrite, insertFileStreamCanSeek, insertFileStreamCanTimeout, insertFileStreamLength, insertFileStreamPosition, insertFileStreamReadTimeout, insertFileStreamWriteTimeout, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file Inserts a file specified in the request to the selected folder by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for inserting a file.</param>
        /// <param name="insertFileFile">The file to be inserted. (optional)</param>
        /// <param name="insertFileTitle">The file title to be inserted. (optional)</param>
        /// <param name="insertFileCreateNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="insertFileKeepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="insertFileStreamCanRead"> (optional)</param>
        /// <param name="insertFileStreamCanWrite"> (optional)</param>
        /// <param name="insertFileStreamCanSeek"> (optional)</param>
        /// <param name="insertFileStreamCanTimeout"> (optional)</param>
        /// <param name="insertFileStreamLength"> (optional)</param>
        /// <param name="insertFileStreamPosition"> (optional)</param>
        /// <param name="insertFileStreamReadTimeout"> (optional)</param>
        /// <param name="insertFileStreamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file/">REST API Reference for InsertFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> InsertFileWithHttpInfoAsync(int folderId, FileParameter? insertFileFile = default, string? insertFileTitle = default, bool? insertFileCreateNewIfExist = default, bool? insertFileKeepConvertStatus = default, bool? insertFileStreamCanRead = default, bool? insertFileStreamCanWrite = default, bool? insertFileStreamCanSeek = default, bool? insertFileStreamCanTimeout = default, long? insertFileStreamLength = default, long? insertFileStreamPosition = default, int? insertFileStreamReadTimeout = default, int? insertFileStreamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (insertFileFile != null)
            {
                localVarRequestOptions.FileParameters.Add("InsertFile.File", insertFileFile);
            }
            if (insertFileTitle != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Title", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileTitle)); // form parameter
            }
            if (insertFileCreateNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.CreateNewIfExist", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileCreateNewIfExist)); // form parameter
            }
            if (insertFileKeepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.KeepConvertStatus", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileKeepConvertStatus)); // form parameter
            }
            if (insertFileStreamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanRead", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamCanRead)); // form parameter
            }
            if (insertFileStreamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanWrite", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamCanWrite)); // form parameter
            }
            if (insertFileStreamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanSeek", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamCanSeek)); // form parameter
            }
            if (insertFileStreamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.CanTimeout", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamCanTimeout)); // form parameter
            }
            if (insertFileStreamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Length", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamLength)); // form parameter
            }
            if (insertFileStreamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.Position", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamPosition)); // form parameter
            }
            if (insertFileStreamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.ReadTimeout", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamReadTimeout)); // form parameter
            }
            if (insertFileStreamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("InsertFile.Stream.WriteTimeout", DocSpace.Sdk.Client.ClientUtils.ParameterToString(insertFileStreamWriteTimeout)); // form parameter
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/insert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("InsertFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper InsertFileToMyFromBody(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default)
        {
            var localVarResponse = InsertFileToMyFromBodyWithHttpInfo(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> InsertFileToMyFromBodyWithHttpInfo(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (title != null)
            {
                localVarRequestOptions.FormParameters.Add("Title",ClientUtils.ParameterToString(title)); // form parameter
            }
            if (createNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("CreateNewIfExist",ClientUtils.ParameterToString(createNewIfExist)); // form parameter
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("KeepConvertStatus",ClientUtils.ParameterToString(keepConvertStatus)); // form parameter
            }
            if (streamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanRead",ClientUtils.ParameterToString(streamCanRead)); // form parameter
            }
            if (streamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanWrite",ClientUtils.ParameterToString(streamCanWrite)); // form parameter
            }
            if (streamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanSeek",ClientUtils.ParameterToString(streamCanSeek)); // form parameter
            }
            if (streamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanTimeout",ClientUtils.ParameterToString(streamCanTimeout)); // form parameter
            }
            if (streamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Length",ClientUtils.ParameterToString(streamLength)); // form parameter
            }
            if (streamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Position",ClientUtils.ParameterToString(streamPosition)); // form parameter
            }
            if (streamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.ReadTimeout",ClientUtils.ParameterToString(streamReadTimeout)); // form parameter
            }
            if (streamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.WriteTimeout",ClientUtils.ParameterToString(streamWriteTimeout)); // form parameter
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/insert", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("InsertFileToMyFromBody", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> InsertFileToMyFromBodyAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await InsertFileToMyFromBodyWithHttpInfoAsync(file, title, createNewIfExist, keepConvertStatus, streamCanRead, streamCanWrite, streamCanSeek, streamCanTimeout, streamLength, streamPosition, streamReadTimeout, streamWriteTimeout, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Insert a file to the \&quot;My documents\&quot; section Inserts a file specified in the request to the \&quot;My documents\&quot; section by single file uploading.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">The file to be inserted. (optional)</param>
        /// <param name="title">The file title to be inserted. (optional)</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists or not. (optional)</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not. (optional)</param>
        /// <param name="streamCanRead"> (optional)</param>
        /// <param name="streamCanWrite"> (optional)</param>
        /// <param name="streamCanSeek"> (optional)</param>
        /// <param name="streamCanTimeout"> (optional)</param>
        /// <param name="streamLength"> (optional)</param>
        /// <param name="streamPosition"> (optional)</param>
        /// <param name="streamReadTimeout"> (optional)</param>
        /// <param name="streamWriteTimeout"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/insert-file-to-my-from-body/">REST API Reference for InsertFileToMyFromBody Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> InsertFileToMyFromBodyWithHttpInfoAsync(FileParameter? file = default, string? title = default, bool? createNewIfExist = default, bool? keepConvertStatus = default, bool? streamCanRead = default, bool? streamCanWrite = default, bool? streamCanSeek = default, bool? streamCanTimeout = default, long? streamLength = default, long? streamPosition = default, int? streamReadTimeout = default, int? streamWriteTimeout = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (title != null)
            {
                localVarRequestOptions.FormParameters.Add("Title", DocSpace.Sdk.Client.ClientUtils.ParameterToString(title)); // form parameter
            }
            if (createNewIfExist != null)
            {
                localVarRequestOptions.FormParameters.Add("CreateNewIfExist", DocSpace.Sdk.Client.ClientUtils.ParameterToString(createNewIfExist)); // form parameter
            }
            if (keepConvertStatus != null)
            {
                localVarRequestOptions.FormParameters.Add("KeepConvertStatus", DocSpace.Sdk.Client.ClientUtils.ParameterToString(keepConvertStatus)); // form parameter
            }
            if (streamCanRead != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanRead", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamCanRead)); // form parameter
            }
            if (streamCanWrite != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanWrite", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamCanWrite)); // form parameter
            }
            if (streamCanSeek != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanSeek", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamCanSeek)); // form parameter
            }
            if (streamCanTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.CanTimeout", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamCanTimeout)); // form parameter
            }
            if (streamLength != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Length", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamLength)); // form parameter
            }
            if (streamPosition != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.Position", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamPosition)); // form parameter
            }
            if (streamReadTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.ReadTimeout", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamReadTimeout)); // form parameter
            }
            if (streamWriteTimeout != null)
            {
                localVarRequestOptions.FormParameters.Add("Stream.WriteTimeout", DocSpace.Sdk.Client.ClientUtils.ParameterToString(streamWriteTimeout)); // form parameter
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/insert", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("InsertFileToMyFromBody", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename a folder Renames the selected folder with a new title specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper RenameFolder(int folderId, CreateFolder? createFolder = default)
        {
            var localVarResponse = RenameFolderWithHttpInfo(folderId, createFolder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename a folder Renames the selected folder with a new title specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> RenameFolderWithHttpInfo(int folderId, CreateFolder? createFolder = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RenameFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename a folder Renames the selected folder with a new title specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> RenameFolderAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderIntegerWrapper> localVarResponse = await RenameFolderWithHttpInfoAsync(folderId, createFolder, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename a folder Renames the selected folder with a new title specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the folder creation.</param>
        /// <param name="createFolder">The parameters for creating a folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-folder/">REST API Reference for RenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> RenameFolderWithHttpInfoAsync(int folderId, CreateFolder? createFolder = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFolder != null) localVarRequestOptions.Data = createFolder;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RenameFolder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder order Sets the file order in the folder with ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper SetFolderOrder(int folderId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarResponse = SetFolderOrderWithHttpInfo(folderId, orderRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder order Sets the file order in the folder with ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> SetFolderOrderWithHttpInfo(int folderId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;

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
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}/order", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetFolderOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set folder order Sets the file order in the folder with ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> SetFolderOrderAsync(int folderId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FolderIntegerWrapper> localVarResponse = await SetFolderOrderWithHttpInfoAsync(folderId, orderRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set folder order Sets the file order in the folder with ID specified in the request.
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder unique identifier.</param>
        /// <param name="orderRequestDto">The folder order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-order/">REST API Reference for SetFolderOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> SetFolderOrderWithHttpInfoAsync(int folderId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;

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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/folder/{folderId}/order", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetFolderOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper UploadFile(int folderId, UploadRequestDto? uploadRequestDto = default)
        {
            var localVarResponse = UploadFileWithHttpInfo(folderId, uploadRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> UploadFileWithHttpInfo(int folderId, UploadRequestDto? uploadRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (uploadRequestDto != null) localVarRequestOptions.Data = uploadRequestDto;

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
            var localVarResponse = this.Client.Post<ObjectWrapper>("/api/2.0/files/{folderId}/upload", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UploadFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> UploadFileAsync(int folderId, UploadRequestDto? uploadRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await UploadFileWithHttpInfoAsync(folderId, uploadRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file Uploads a file specified in the request to the selected folder by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to upload a file.</param>
        /// <param name="uploadRequestDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file/">REST API Reference for UploadFile Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> UploadFileWithHttpInfoAsync(int folderId, UploadRequestDto? uploadRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (uploadRequestDto != null) localVarRequestOptions.Data = uploadRequestDto;

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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/{folderId}/upload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UploadFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper UploadFileToMy(UploadRequestDto? inDto = default)
        {
            var localVarResponse = UploadFileToMyWithHttpInfo(inDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> UploadFileToMyWithHttpInfo(UploadRequestDto? inDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
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
            var localVarResponse = this.Client.Post<ObjectWrapper>("/api/2.0/files/@my/upload", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UploadFileToMy", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> UploadFileToMyAsync(UploadRequestDto? inDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await UploadFileToMyWithHttpInfoAsync(inDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file to the \&quot;My documents\&quot; section Uploads a file specified in the request to the \&quot;My documents\&quot; section by single file uploading or standart multipart/form-data method.   **Note**:  You can upload files in two different ways:   &lt;ol&gt;  &lt;li&gt;Using single file upload. You should set the Content-Type and Content-Disposition headers to specify a file name and content type, and send the file to the request body.&lt;/li&gt;  &lt;li&gt;Using standart multipart/form-data method.&lt;/li&gt;  &lt;/ol&gt;
        /// </summary>
        /// <exception cref="DocSpace.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for uploading a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-file-to-my/">REST API Reference for UploadFileToMy Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> UploadFileToMyWithHttpInfoAsync(UploadRequestDto? inDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/@my/upload", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UploadFileToMy", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
