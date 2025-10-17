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
namespace DocSpace.API.SDK.Api.Files
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISharingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        ExternalShareWrapper ApplyExternalSharePassword(string key, ExternalShareRequestParam externalShareRequestParam);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        ApiResponse<ExternalShareWrapper> ApplyExternalSharePasswordWithHttpInfo(string key, ExternalShareRequestParam externalShareRequestParam);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        FileEntryBaseArrayWrapper ChangeFileOwner(ChangeOwnerRequestDto? changeOwnerRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        ApiResponse<FileEntryBaseArrayWrapper> ChangeFileOwnerWithHttpInfo(ChangeOwnerRequestDto? changeOwnerRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        ExternalShareWrapper GetExternalShareData(string key, string? fileId = default, string? folderId = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        ApiResponse<ExternalShareWrapper> GetExternalShareDataWithHttpInfo(string key, string? fileId = default, string? folderId = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetFileSecurityInfo(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetFileSecurityInfoWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetFolderSecurityInfo(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetFolderSecurityInfoWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>GroupMemberSecurityRequestArrayWrapper</returns>
        GroupMemberSecurityRequestArrayWrapper GetGroupsMembersWithFileSecurity(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>ApiResponse of GroupMemberSecurityRequestArrayWrapper</returns>
        ApiResponse<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFileSecurityWithHttpInfo(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>GroupMemberSecurityRequestArrayWrapper</returns>
        GroupMemberSecurityRequestArrayWrapper GetGroupsMembersWithFolderSecurity(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>ApiResponse of GroupMemberSecurityRequestArrayWrapper</returns>
        ApiResponse<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFolderSecurityWithHttpInfo(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetSecurityInfo(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetSecurityInfoWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        MentionWrapperArrayWrapper GetSharedUsers(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        ApiResponse<MentionWrapperArrayWrapper> GetSharedUsersWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper RemoveSecurityInfo(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> RemoveSecurityInfoWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>AceShortWrapperArrayWrapper</returns>
        AceShortWrapperArrayWrapper SendEditorNotify(int fileId, MentionMessageWrapper? mentionMessageWrapper = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>ApiResponse of AceShortWrapperArrayWrapper</returns>
        ApiResponse<AceShortWrapperArrayWrapper> SendEditorNotifyWithHttpInfo(int fileId, MentionMessageWrapper? mentionMessageWrapper = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper SetFileSecurityInfo(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> SetFileSecurityInfoWithHttpInfo(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper SetFolderSecurityInfo(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> SetFolderSecurityInfoWithHttpInfo(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper SetSecurityInfo(SecurityInfoRequestDto? securityInfoRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> SetSecurityInfoWithHttpInfo(SecurityInfoRequestDto? securityInfoRequestDto = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISharingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        Task<ExternalShareWrapper> ApplyExternalSharePasswordAsync(string key, ExternalShareRequestParam externalShareRequestParam, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        Task<ApiResponse<ExternalShareWrapper>> ApplyExternalSharePasswordWithHttpInfoAsync(string key, ExternalShareRequestParam externalShareRequestParam, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        Task<FileEntryBaseArrayWrapper> ChangeFileOwnerAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<FileEntryBaseArrayWrapper>> ChangeFileOwnerWithHttpInfoAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        Task<ExternalShareWrapper> GetExternalShareDataAsync(string key, string? fileId = default, string? folderId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        Task<ApiResponse<ExternalShareWrapper>> GetExternalShareDataWithHttpInfoAsync(string key, string? fileId = default, string? folderId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetFileSecurityInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetFileSecurityInfoWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetFolderSecurityInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetFolderSecurityInfoWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>Task of GroupMemberSecurityRequestArrayWrapper</returns>
        Task<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFileSecurityAsync(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (GroupMemberSecurityRequestArrayWrapper)</returns>
        Task<ApiResponse<GroupMemberSecurityRequestArrayWrapper>> GetGroupsMembersWithFileSecurityWithHttpInfoAsync(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>Task of GroupMemberSecurityRequestArrayWrapper</returns>
        Task<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFolderSecurityAsync(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (GroupMemberSecurityRequestArrayWrapper)</returns>
        Task<ApiResponse<GroupMemberSecurityRequestArrayWrapper>> GetGroupsMembersWithFolderSecurityWithHttpInfoAsync(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetSecurityInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetSecurityInfoWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        Task<MentionWrapperArrayWrapper> GetSharedUsersAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        Task<ApiResponse<MentionWrapperArrayWrapper>> GetSharedUsersWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> RemoveSecurityInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> RemoveSecurityInfoWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of AceShortWrapperArrayWrapper</returns>
        Task<AceShortWrapperArrayWrapper> SendEditorNotifyAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of ApiResponse (AceShortWrapperArrayWrapper)</returns>
        Task<ApiResponse<AceShortWrapperArrayWrapper>> SendEditorNotifyWithHttpInfoAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> SetFileSecurityInfoAsync(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> SetFileSecurityInfoWithHttpInfoAsync(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> SetFolderSecurityInfoAsync(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> SetFolderSecurityInfoWithHttpInfoAsync(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> SetSecurityInfoAsync(SecurityInfoRequestDto? securityInfoRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> SetSecurityInfoWithHttpInfoAsync(SecurityInfoRequestDto? securityInfoRequestDto = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISharingApi : ISharingApiSync, ISharingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SharingApi : IDisposable, ISharingApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SharingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SharingApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SharingApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SharingApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SharingApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SharingApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingApi"/> class.
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
        public SharingApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SharingApi"/> class using a Configuration object.
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
        public SharingApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SharingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SharingApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        public ExternalShareWrapper ApplyExternalSharePassword(string key, ExternalShareRequestParam externalShareRequestParam)
        {
            var localVarResponse = ApplyExternalSharePasswordWithHttpInfo(key, externalShareRequestParam);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        public ApiResponse<ExternalShareWrapper> ApplyExternalSharePasswordWithHttpInfo(string key, ExternalShareRequestParam externalShareRequestParam)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling SharingApi->ApplyExternalSharePassword");

            // verify the required parameter 'externalShareRequestParam' is set
            if (externalShareRequestParam == null)
                throw new ApiException(400, "Missing required parameter 'externalShareRequestParam' when calling SharingApi->ApplyExternalSharePassword");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (externalShareRequestParam != null) localVarRequestOptions.Data = externalShareRequestParam;


            // make the HTTP request
            var localVarResponse = Client.Post<ExternalShareWrapper>("/api/2.0/files/share/{key}/password", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ApplyExternalSharePassword", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        public async Task<ExternalShareWrapper> ApplyExternalSharePasswordAsync(string key, ExternalShareRequestParam externalShareRequestParam, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ApplyExternalSharePasswordWithHttpInfoAsync(key, externalShareRequestParam, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique document identifier.</param>
        /// <param name="externalShareRequestParam">The external data share request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/apply-external-share-password/">REST API Reference for ApplyExternalSharePassword Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        public async Task<ApiResponse<ExternalShareWrapper>> ApplyExternalSharePasswordWithHttpInfoAsync(string key, ExternalShareRequestParam externalShareRequestParam, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling SharingApi->ApplyExternalSharePassword");

            // verify the required parameter 'externalShareRequestParam' is set
            if (externalShareRequestParam == null)
                throw new ApiException(400, "Missing required parameter 'externalShareRequestParam' when calling SharingApi->ApplyExternalSharePassword");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (externalShareRequestParam != null) localVarRequestOptions.Data = externalShareRequestParam;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ExternalShareWrapper>("/api/2.0/files/share/{key}/password", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ApplyExternalSharePassword", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        public FileEntryBaseArrayWrapper ChangeFileOwner(ChangeOwnerRequestDto? changeOwnerRequestDto = default)
        {
            var localVarResponse = ChangeFileOwnerWithHttpInfo(changeOwnerRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        public ApiResponse<FileEntryBaseArrayWrapper> ChangeFileOwnerWithHttpInfo(ChangeOwnerRequestDto? changeOwnerRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (changeOwnerRequestDto != null) localVarRequestOptions.Data = changeOwnerRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<FileEntryBaseArrayWrapper>("/api/2.0/files/owner", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeFileOwner", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        public async Task<FileEntryBaseArrayWrapper> ChangeFileOwnerAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeFileOwnerWithHttpInfoAsync(changeOwnerRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="changeOwnerRequestDto">The request parameters for changing the file owner. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-file-owner/">REST API Reference for ChangeFileOwner Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseArrayWrapper>> ChangeFileOwnerWithHttpInfoAsync(ChangeOwnerRequestDto? changeOwnerRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (changeOwnerRequestDto != null) localVarRequestOptions.Data = changeOwnerRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileEntryBaseArrayWrapper>("/api/2.0/files/owner", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeFileOwner", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ExternalShareWrapper</returns>
        public ExternalShareWrapper GetExternalShareData(string key, string? fileId = default, string? folderId = default)
        {
            var localVarResponse = GetExternalShareDataWithHttpInfo(key, fileId, folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>ApiResponse of ExternalShareWrapper</returns>
        public ApiResponse<ExternalShareWrapper> GetExternalShareDataWithHttpInfo(string key, string? fileId = default, string? folderId = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling SharingApi->GetExternalShareData");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (fileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileId", fileId));
            }
            if (folderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "folderId", folderId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<ExternalShareWrapper>("/api/2.0/files/share/{key}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetExternalShareData", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ExternalShareWrapper</returns>
        public async Task<ExternalShareWrapper> GetExternalShareDataAsync(string key, string? fileId = default, string? folderId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetExternalShareDataWithHttpInfoAsync(key, fileId, folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The unique key of the external shared data.</param>
        /// <param name="fileId">The unique document identifier. (optional)</param>
        /// <param name="folderId">The unique folder identifier. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-external-share-data/">REST API Reference for GetExternalShareData Operation</seealso>
        /// <returns>Task of ApiResponse (ExternalShareWrapper)</returns>
        public async Task<ApiResponse<ExternalShareWrapper>> GetExternalShareDataWithHttpInfoAsync(string key, string? fileId = default, string? folderId = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new ApiException(400, "Missing required parameter 'key' when calling SharingApi->GetExternalShareData");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("key", ClientUtils.ParameterToString(key)); // path parameter
            if (fileId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileId", fileId));
            }
            if (folderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "folderId", folderId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ExternalShareWrapper>("/api/2.0/files/share/{key}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetExternalShareData", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetFileSecurityInfo(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFileSecurityInfoWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetFileSecurityInfoWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileShareArrayWrapper>("/api/2.0/files/file/{id}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetFileSecurityInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFileSecurityInfoWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-security-info/">REST API Reference for GetFileSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetFileSecurityInfoWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/file/{id}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetFolderSecurityInfo(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFolderSecurityInfoWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetFolderSecurityInfoWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileShareArrayWrapper>("/api/2.0/files/folder/{id}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetFolderSecurityInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFolderSecurityInfoWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The folder unique identifier.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-folder-security-info/">REST API Reference for GetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetFolderSecurityInfoWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/folder/{id}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFolderSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>GroupMemberSecurityRequestArrayWrapper</returns>
        public GroupMemberSecurityRequestArrayWrapper GetGroupsMembersWithFileSecurity(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarResponse = GetGroupsMembersWithFileSecurityWithHttpInfo(fileId, groupId, count, startIndex, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>ApiResponse of GroupMemberSecurityRequestArrayWrapper</returns>
        public ApiResponse<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFileSecurityWithHttpInfo(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<GroupMemberSecurityRequestArrayWrapper>("/api/2.0/files/file/{fileId}/group/{groupId}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroupsMembersWithFileSecurity", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>Task of GroupMemberSecurityRequestArrayWrapper</returns>
        public async Task<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFileSecurityAsync(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetGroupsMembersWithFileSecurityWithHttpInfoAsync(fileId, groupId, count, startIndex, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-file-security/">REST API Reference for GetGroupsMembersWithFileSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (GroupMemberSecurityRequestArrayWrapper)</returns>
        public async Task<ApiResponse<GroupMemberSecurityRequestArrayWrapper>> GetGroupsMembersWithFileSecurityWithHttpInfoAsync(int fileId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<GroupMemberSecurityRequestArrayWrapper>("/api/2.0/files/file/{fileId}/group/{groupId}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroupsMembersWithFileSecurity", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>GroupMemberSecurityRequestArrayWrapper</returns>
        public GroupMemberSecurityRequestArrayWrapper GetGroupsMembersWithFolderSecurity(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarResponse = GetGroupsMembersWithFolderSecurityWithHttpInfo(folderId, groupId, count, startIndex, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>ApiResponse of GroupMemberSecurityRequestArrayWrapper</returns>
        public ApiResponse<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFolderSecurityWithHttpInfo(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default)
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
            localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<GroupMemberSecurityRequestArrayWrapper>("/api/2.0/files/folder/{folderId}/group/{groupId}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroupsMembersWithFolderSecurity", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>Task of GroupMemberSecurityRequestArrayWrapper</returns>
        public async Task<GroupMemberSecurityRequestArrayWrapper> GetGroupsMembersWithFolderSecurityAsync(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetGroupsMembersWithFolderSecurityWithHttpInfoAsync(folderId, groupId, count, startIndex, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="count">The number of items to be retrieved in the current query. (optional)</param>
        /// <param name="startIndex">The starting index for the query result set. (optional)</param>
        /// <param name="filterValue">The filter value used for searching or querying group members based on text input. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-groups-members-with-folder-security/">REST API Reference for GetGroupsMembersWithFolderSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (GroupMemberSecurityRequestArrayWrapper)</returns>
        public async Task<ApiResponse<GroupMemberSecurityRequestArrayWrapper>> GetGroupsMembersWithFolderSecurityWithHttpInfoAsync(int folderId, Guid groupId, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            localVarRequestOptions.PathParameters.Add("groupId", ClientUtils.ParameterToString(groupId)); // path parameter
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<GroupMemberSecurityRequestArrayWrapper>("/api/2.0/files/folder/{folderId}/group/{groupId}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetGroupsMembersWithFolderSecurity", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetSecurityInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = GetSecurityInfoWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetSecurityInfoWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<FileShareArrayWrapper>("/api/2.0/files/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetSecurityInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSecurityInfoWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-security-info/">REST API Reference for GetSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetSecurityInfoWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileShareArrayWrapper>("/api/2.0/files/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        public MentionWrapperArrayWrapper GetSharedUsers(int fileId)
        {
            var localVarResponse = GetSharedUsersWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        public ApiResponse<MentionWrapperArrayWrapper> GetSharedUsersWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sharedusers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSharedUsers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        public async Task<MentionWrapperArrayWrapper> GetSharedUsersAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetSharedUsersWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-shared-users/">REST API Reference for GetSharedUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        public async Task<ApiResponse<MentionWrapperArrayWrapper>> GetSharedUsersWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sharedusers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetSharedUsers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper RemoveSecurityInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = RemoveSecurityInfoWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> RemoveSecurityInfoWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Delete<BooleanWrapper>("/api/2.0/files/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> RemoveSecurityInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RemoveSecurityInfoWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/remove-security-info/">REST API Reference for RemoveSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> RemoveSecurityInfoWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<BooleanWrapper>("/api/2.0/files/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RemoveSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>AceShortWrapperArrayWrapper</returns>
        public AceShortWrapperArrayWrapper SendEditorNotify(int fileId, MentionMessageWrapper? mentionMessageWrapper = default)
        {
            var localVarResponse = SendEditorNotifyWithHttpInfo(fileId, mentionMessageWrapper);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>ApiResponse of AceShortWrapperArrayWrapper</returns>
        public ApiResponse<AceShortWrapperArrayWrapper> SendEditorNotifyWithHttpInfo(int fileId, MentionMessageWrapper? mentionMessageWrapper = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (mentionMessageWrapper != null) localVarRequestOptions.Data = mentionMessageWrapper;


            // make the HTTP request
            var localVarResponse = Client.Post<AceShortWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sendeditornotify", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendEditorNotify", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of AceShortWrapperArrayWrapper</returns>
        public async Task<AceShortWrapperArrayWrapper> SendEditorNotifyAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SendEditorNotifyWithHttpInfoAsync(fileId, mentionMessageWrapper, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID with the mention message.</param>
        /// <param name="mentionMessageWrapper">The mention message. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/send-editor-notify/">REST API Reference for SendEditorNotify Operation</seealso>
        /// <returns>Task of ApiResponse (AceShortWrapperArrayWrapper)</returns>
        public async Task<ApiResponse<AceShortWrapperArrayWrapper>> SendEditorNotifyWithHttpInfoAsync(int fileId, MentionMessageWrapper? mentionMessageWrapper = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (mentionMessageWrapper != null) localVarRequestOptions.Data = mentionMessageWrapper;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AceShortWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/sendeditornotify", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SendEditorNotify", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper SetFileSecurityInfo(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto)
        {
            var localVarResponse = SetFileSecurityInfoWithHttpInfo(fileId, securityInfoSimpleRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> SetFileSecurityInfoWithHttpInfo(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto)
        {
            // verify the required parameter 'securityInfoSimpleRequestDto' is set
            if (securityInfoSimpleRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'securityInfoSimpleRequestDto' when calling SharingApi->SetFileSecurityInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (securityInfoSimpleRequestDto != null) localVarRequestOptions.Data = securityInfoSimpleRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileShareArrayWrapper>("/api/2.0/files/file/{fileId}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> SetFileSecurityInfoAsync(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFileSecurityInfoWithHttpInfoAsync(fileId, securityInfoSimpleRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-security-info/">REST API Reference for SetFileSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> SetFileSecurityInfoWithHttpInfoAsync(int fileId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'securityInfoSimpleRequestDto' is set
            if (securityInfoSimpleRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'securityInfoSimpleRequestDto' when calling SharingApi->SetFileSecurityInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (securityInfoSimpleRequestDto != null) localVarRequestOptions.Data = securityInfoSimpleRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareArrayWrapper>("/api/2.0/files/file/{fileId}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper SetFolderSecurityInfo(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto)
        {
            var localVarResponse = SetFolderSecurityInfoWithHttpInfo(folderId, securityInfoSimpleRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> SetFolderSecurityInfoWithHttpInfo(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto)
        {
            // verify the required parameter 'securityInfoSimpleRequestDto' is set
            if (securityInfoSimpleRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'securityInfoSimpleRequestDto' when calling SharingApi->SetFolderSecurityInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (securityInfoSimpleRequestDto != null) localVarRequestOptions.Data = securityInfoSimpleRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileShareArrayWrapper>("/api/2.0/files/folder/{folderId}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> SetFolderSecurityInfoAsync(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFolderSecurityInfoWithHttpInfoAsync(folderId, securityInfoSimpleRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID.</param>
        /// <param name="securityInfoSimpleRequestDto">The parameters of the security information simple request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-folder-security-info/">REST API Reference for SetFolderSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> SetFolderSecurityInfoWithHttpInfoAsync(int folderId, SecurityInfoSimpleRequestDto securityInfoSimpleRequestDto, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'securityInfoSimpleRequestDto' is set
            if (securityInfoSimpleRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'securityInfoSimpleRequestDto' when calling SharingApi->SetFolderSecurityInfo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (securityInfoSimpleRequestDto != null) localVarRequestOptions.Data = securityInfoSimpleRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareArrayWrapper>("/api/2.0/files/folder/{folderId}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFolderSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper SetSecurityInfo(SecurityInfoRequestDto? securityInfoRequestDto = default)
        {
            var localVarResponse = SetSecurityInfoWithHttpInfo(securityInfoRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> SetSecurityInfoWithHttpInfo(SecurityInfoRequestDto? securityInfoRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (securityInfoRequestDto != null) localVarRequestOptions.Data = securityInfoRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileShareArrayWrapper>("/api/2.0/files/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> SetSecurityInfoAsync(SecurityInfoRequestDto? securityInfoRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetSecurityInfoWithHttpInfoAsync(securityInfoRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="securityInfoRequestDto">The security information request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-security-info/">REST API Reference for SetSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> SetSecurityInfoWithHttpInfoAsync(SecurityInfoRequestDto? securityInfoRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (securityInfoRequestDto != null) localVarRequestOptions.Data = securityInfoRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareArrayWrapper>("/api/2.0/files/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
