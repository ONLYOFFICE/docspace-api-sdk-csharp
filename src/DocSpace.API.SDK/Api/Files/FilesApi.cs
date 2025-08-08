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
    public interface IFilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper AddTemplates(TemplatesRequestDto? templatesRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> AddTemplatesWithHttpInfo(TemplatesRequestDto? templatesRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>FileStringArrayWrapper</returns>
        FileStringArrayWrapper ChangeVersionHistory(int fileId, ChangeHistory? changeHistory = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>ApiResponse of FileStringArrayWrapper</returns>
        ApiResponse<FileStringArrayWrapper> ChangeVersionHistoryWithHttpInfo(int fileId, ChangeHistory? changeHistory = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper CheckFillFormDraft(int fileId, CheckFillFormDraft? checkFillFormDraft = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> CheckFillFormDraftWithHttpInfo(int fileId, CheckFillFormDraft? checkFillFormDraft = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>FileEntryBaseWrapper</returns>
        FileEntryBaseWrapper CopyFileAs(int fileId, CopyAsJsonElement? copyAsJsonElement = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseWrapper</returns>
        ApiResponse<FileEntryBaseWrapper> CopyFileAsWithHttpInfo(int fileId, CopyAsJsonElement? copyAsJsonElement = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper CreateEditSession(int fileId, long? fileSize = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> CreateEditSessionWithHttpInfo(int fileId, long? fileSize = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateFile(int folderId, CreateFileJsonElement? createFileJsonElement = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateFileWithHttpInfo(int folderId, CreateFileJsonElement? createFileJsonElement = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateFileInMyDocuments(CreateFileJsonElement? createFileJsonElement = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateFileInMyDocumentsWithHttpInfo(CreateFileJsonElement? createFileJsonElement = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateHtmlFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateHtmlFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateHtmlFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateHtmlFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper CreatePrimaryExternalLink(int id, FileLinkRequest? fileLinkRequest = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> CreatePrimaryExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateTextFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateTextFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateTextFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateTextFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper CreateThumbnails(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> CreateThumbnailsWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteFile(int fileId, Delete delete);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteFileWithHttpInfo(int fileId, Delete delete);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>NoContentResultWrapper</returns>
        NoContentResultWrapper DeleteRecent(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>ApiResponse of NoContentResultWrapper</returns>
        ApiResponse<NoContentResultWrapper> DeleteRecentWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper DeleteTemplates(List<int>? requestBody = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> DeleteTemplatesWithHttpInfo(List<int>? requestBody = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>FormRoleArrayWrapper</returns>
        FormRoleArrayWrapper GetAllFormRoles(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>ApiResponse of FormRoleArrayWrapper</returns>
        ApiResponse<FormRoleArrayWrapper> GetAllFormRolesWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>EditHistoryDataWrapper</returns>
        EditHistoryDataWrapper GetEditDiffUrl(int fileId, int? version = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>ApiResponse of EditHistoryDataWrapper</returns>
        ApiResponse<EditHistoryDataWrapper> GetEditDiffUrlWithHttpInfo(int fileId, int? version = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        EditHistoryArrayWrapper GetEditHistory(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        ApiResponse<EditHistoryArrayWrapper> GetEditHistoryWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        HistoryArrayWrapper GetFileHistory(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        ApiResponse<HistoryArrayWrapper> GetFileHistoryWithHttpInfo(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper GetFileInfo(int fileId, int? version = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> GetFileInfoWithHttpInfo(int fileId, int? version = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetFileLinks(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetFileLinksWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper GetFilePrimaryExternalLink(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> GetFilePrimaryExternalLinkWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>FileStringArrayWrapper</returns>
        FileStringArrayWrapper GetFileVersionInfo(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>ApiResponse of FileStringArrayWrapper</returns>
        ApiResponse<FileStringArrayWrapper> GetFileVersionInfoWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>FillingFormResultIntegerWrapper</returns>
        FillingFormResultIntegerWrapper GetFillResult(string? fillingSessionId = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>ApiResponse of FillingFormResultIntegerWrapper</returns>
        ApiResponse<FillingFormResultIntegerWrapper> GetFillResultWithHttpInfo(string? fillingSessionId = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>FileLinkWrapper</returns>
        FileLinkWrapper GetPresignedFileUri(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>ApiResponse of FileLinkWrapper</returns>
        ApiResponse<FileLinkWrapper> GetPresignedFileUriWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPresignedUri(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPresignedUriWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        MentionWrapperArrayWrapper GetProtectedFileUsers(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        ApiResponse<MentionWrapperArrayWrapper> GetProtectedFileUsersWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>FileReferenceWrapper</returns>
        FileReferenceWrapper GetReferenceData(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>ApiResponse of FileReferenceWrapper</returns>
        ApiResponse<FileReferenceWrapper> GetReferenceDataWithHttpInfo(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper IsFormPDF(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> IsFormPDFWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper LockFile(int fileId, LockFileParameters? lockFileParameters = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> LockFileWithHttpInfo(int fileId, LockFileParameters? lockFileParameters = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns></returns>
        void ManageFormFilling(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ManageFormFillingWithHttpInfo(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ConfigurationIntegerWrapper</returns>
        ConfigurationIntegerWrapper OpenEditFile(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ApiResponse of ConfigurationIntegerWrapper</returns>
        ApiResponse<ConfigurationIntegerWrapper> OpenEditFileWithHttpInfo(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        EditHistoryArrayWrapper RestoreFileVersion(int fileId, int? version = default, string? url = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        ApiResponse<EditHistoryArrayWrapper> RestoreFileVersionWithHttpInfo(int fileId, int? version = default, string? url = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SaveEditingFileFromForm(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SaveEditingFileFromFormWithHttpInfo(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SaveFileAsPdf(int id, SaveAsPdfInteger? saveAsPdfInteger = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SaveFileAsPdfWithHttpInfo(int id, SaveAsPdfInteger? saveAsPdfInteger = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>FormRoleWrapper</returns>
        FormRoleWrapper SaveFormRoleMapping(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>ApiResponse of FormRoleWrapper</returns>
        ApiResponse<FormRoleWrapper> SaveFormRoleMappingWithHttpInfo(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SetCustomFilterTag(int fileId, CustomFilterParameters? customFilterParameters = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SetCustomFilterTagWithHttpInfo(int fileId, CustomFilterParameters? customFilterParameters = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper SetExternalLink(int id, FileLinkRequest? fileLinkRequest = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> SetExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SetFileOrder(int fileId, OrderRequestDto? orderRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SetFileOrderWithHttpInfo(int fileId, OrderRequestDto? orderRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>FileEntryStringArrayWrapper</returns>
        FileEntryStringArrayWrapper SetFilesOrder(OrdersRequestDtoInteger? ordersRequestDtoInteger = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>ApiResponse of FileEntryStringArrayWrapper</returns>
        ApiResponse<FileEntryStringArrayWrapper> SetFilesOrderWithHttpInfo(OrdersRequestDtoInteger? ordersRequestDtoInteger = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper StartEditFile(int fileId, StartEdit? startEdit = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> StartEditFileWithHttpInfo(int fileId, StartEdit? startEdit = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper StartFillingFile(int fileId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> StartFillingFileWithHttpInfo(int fileId);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>KeyValuePairBooleanStringWrapper</returns>
        KeyValuePairBooleanStringWrapper TrackEditFile(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>ApiResponse of KeyValuePairBooleanStringWrapper</returns>
        ApiResponse<KeyValuePairBooleanStringWrapper> TrackEditFileWithHttpInfo(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper UpdateFile(int fileId, UpdateFile? updateFile = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> UpdateFileWithHttpInfo(int fileId, UpdateFile? updateFile = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> AddTemplatesAsync(TemplatesRequestDto? templatesRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> AddTemplatesWithHttpInfoAsync(TemplatesRequestDto? templatesRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of FileStringArrayWrapper</returns>
        Task<FileStringArrayWrapper> ChangeVersionHistoryAsync(int fileId, ChangeHistory? changeHistory = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of ApiResponse (FileStringArrayWrapper)</returns>
        Task<ApiResponse<FileStringArrayWrapper>> ChangeVersionHistoryWithHttpInfoAsync(int fileId, ChangeHistory? changeHistory = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> CheckFillFormDraftAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> CheckFillFormDraftWithHttpInfoAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of FileEntryBaseWrapper</returns>
        Task<FileEntryBaseWrapper> CopyFileAsAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseWrapper)</returns>
        Task<ApiResponse<FileEntryBaseWrapper>> CopyFileAsWithHttpInfoAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> CreateEditSessionAsync(int fileId, long? fileSize = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> CreateEditSessionWithHttpInfoAsync(int fileId, long? fileSize = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> CreateFileAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> CreateFileWithHttpInfoAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> CreateFileInMyDocumentsAsync(CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> CreateFileInMyDocumentsWithHttpInfoAsync(CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> CreateHtmlFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> CreateHtmlFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> CreatePrimaryExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> CreatePrimaryExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> CreateTextFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> CreateTextFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> CreateTextFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> CreateTextFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        Task<ObjectArrayWrapper> CreateThumbnailsAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        Task<ApiResponse<ObjectArrayWrapper>> CreateThumbnailsWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DeleteFileAsync(int fileId, Delete delete, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DeleteFileWithHttpInfoAsync(int fileId, Delete delete, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of NoContentResultWrapper</returns>
        Task<NoContentResultWrapper> DeleteRecentAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of ApiResponse (NoContentResultWrapper)</returns>
        Task<ApiResponse<NoContentResultWrapper>> DeleteRecentWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> DeleteTemplatesAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> DeleteTemplatesWithHttpInfoAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of FormRoleArrayWrapper</returns>
        Task<FormRoleArrayWrapper> GetAllFormRolesAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleArrayWrapper)</returns>
        Task<ApiResponse<FormRoleArrayWrapper>> GetAllFormRolesWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of EditHistoryDataWrapper</returns>
        Task<EditHistoryDataWrapper> GetEditDiffUrlAsync(int fileId, int? version = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryDataWrapper)</returns>
        Task<ApiResponse<EditHistoryDataWrapper>> GetEditDiffUrlWithHttpInfoAsync(int fileId, int? version = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        Task<EditHistoryArrayWrapper> GetEditHistoryAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        Task<ApiResponse<EditHistoryArrayWrapper>> GetEditHistoryWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        Task<HistoryArrayWrapper> GetFileHistoryAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        Task<ApiResponse<HistoryArrayWrapper>> GetFileHistoryWithHttpInfoAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> GetFileInfoAsync(int fileId, int? version = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> GetFileInfoWithHttpInfoAsync(int fileId, int? version = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetFileLinksAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetFileLinksWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> GetFilePrimaryExternalLinkAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> GetFilePrimaryExternalLinkWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of FileStringArrayWrapper</returns>
        Task<FileStringArrayWrapper> GetFileVersionInfoAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileStringArrayWrapper)</returns>
        Task<ApiResponse<FileStringArrayWrapper>> GetFileVersionInfoWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of FillingFormResultIntegerWrapper</returns>
        Task<FillingFormResultIntegerWrapper> GetFillResultAsync(string? fillingSessionId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of ApiResponse (FillingFormResultIntegerWrapper)</returns>
        Task<ApiResponse<FillingFormResultIntegerWrapper>> GetFillResultWithHttpInfoAsync(string? fillingSessionId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of FileLinkWrapper</returns>
        Task<FileLinkWrapper> GetPresignedFileUriAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of ApiResponse (FileLinkWrapper)</returns>
        Task<ApiResponse<FileLinkWrapper>> GetPresignedFileUriWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> GetPresignedUriAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> GetPresignedUriWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        Task<MentionWrapperArrayWrapper> GetProtectedFileUsersAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        Task<ApiResponse<MentionWrapperArrayWrapper>> GetProtectedFileUsersWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of FileReferenceWrapper</returns>
        Task<FileReferenceWrapper> GetReferenceDataAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of ApiResponse (FileReferenceWrapper)</returns>
        Task<ApiResponse<FileReferenceWrapper>> GetReferenceDataWithHttpInfoAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> IsFormPDFAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> IsFormPDFWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> LockFileAsync(int fileId, LockFileParameters? lockFileParameters = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> LockFileWithHttpInfoAsync(int fileId, LockFileParameters? lockFileParameters = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of void</returns>
        Task ManageFormFillingAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ManageFormFillingWithHttpInfoAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ConfigurationIntegerWrapper</returns>
        Task<ConfigurationIntegerWrapper> OpenEditFileAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (ConfigurationIntegerWrapper)</returns>
        Task<ApiResponse<ConfigurationIntegerWrapper>> OpenEditFileWithHttpInfoAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        Task<EditHistoryArrayWrapper> RestoreFileVersionAsync(int fileId, int? version = default, string? url = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        Task<ApiResponse<EditHistoryArrayWrapper>> RestoreFileVersionWithHttpInfoAsync(int fileId, int? version = default, string? url = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> SaveEditingFileFromFormAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> SaveEditingFileFromFormWithHttpInfoAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> SaveFileAsPdfAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> SaveFileAsPdfWithHttpInfoAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of FormRoleWrapper</returns>
        Task<FormRoleWrapper> SaveFormRoleMappingAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleWrapper)</returns>
        Task<ApiResponse<FormRoleWrapper>> SaveFormRoleMappingWithHttpInfoAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> SetCustomFilterTagAsync(int fileId, CustomFilterParameters? customFilterParameters = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> SetCustomFilterTagWithHttpInfoAsync(int fileId, CustomFilterParameters? customFilterParameters = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> SetExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> SetExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> SetFileOrderAsync(int fileId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> SetFileOrderWithHttpInfoAsync(int fileId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of FileEntryStringArrayWrapper</returns>
        Task<FileEntryStringArrayWrapper> SetFilesOrderAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryStringArrayWrapper)</returns>
        Task<ApiResponse<FileEntryStringArrayWrapper>> SetFilesOrderWithHttpInfoAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> StartEditFileAsync(int fileId, StartEdit? startEdit = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> StartEditFileWithHttpInfoAsync(int fileId, StartEdit? startEdit = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> StartFillingFileAsync(int fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> StartFillingFileWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of KeyValuePairBooleanStringWrapper</returns>
        Task<KeyValuePairBooleanStringWrapper> TrackEditFileAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (KeyValuePairBooleanStringWrapper)</returns>
        Task<ApiResponse<KeyValuePairBooleanStringWrapper>> TrackEditFileWithHttpInfoAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        Task<FileIntegerWrapper> UpdateFileAsync(int fileId, UpdateFile? updateFile = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        Task<ApiResponse<FileIntegerWrapper>> UpdateFileWithHttpInfoAsync(int fileId, UpdateFile? updateFile = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesApi : IFilesApiSync, IFilesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FilesApi : IDisposable, IFilesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FilesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FilesApi(string basePath)
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
        /// Initializes a new instance of the <see cref="FilesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FilesApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="FilesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FilesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApi"/> class.
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
        public FilesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FilesApi"/> class using a Configuration object.
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
        public FilesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="FilesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FilesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper AddTemplates(TemplatesRequestDto? templatesRequestDto = default)
        {
            var localVarResponse = AddTemplatesWithHttpInfo(templatesRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> AddTemplatesWithHttpInfo(TemplatesRequestDto? templatesRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (templatesRequestDto != null) localVarRequestOptions.Data = templatesRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddTemplates", localVarResponse);
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
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> AddTemplatesAsync(TemplatesRequestDto? templatesRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddTemplatesWithHttpInfoAsync(templatesRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto">The request parameters for adding files to the template list. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> AddTemplatesWithHttpInfoAsync(TemplatesRequestDto? templatesRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (templatesRequestDto != null) localVarRequestOptions.Data = templatesRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddTemplates", localVarResponse);
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
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>FileStringArrayWrapper</returns>
        public FileStringArrayWrapper ChangeVersionHistory(int fileId, ChangeHistory? changeHistory = default)
        {
            var localVarResponse = ChangeVersionHistoryWithHttpInfo(fileId, changeHistory);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>ApiResponse of FileStringArrayWrapper</returns>
        public ApiResponse<FileStringArrayWrapper> ChangeVersionHistoryWithHttpInfo(int fileId, ChangeHistory? changeHistory = default)
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
            if (changeHistory != null) localVarRequestOptions.Data = changeHistory;


            // make the HTTP request
            var localVarResponse = Client.Put<FileStringArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeVersionHistory", localVarResponse);
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
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of FileStringArrayWrapper</returns>
        public async Task<FileStringArrayWrapper> ChangeVersionHistoryAsync(int fileId, ChangeHistory? changeHistory = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeVersionHistoryWithHttpInfoAsync(fileId, changeHistory, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of ApiResponse (FileStringArrayWrapper)</returns>
        public async Task<ApiResponse<FileStringArrayWrapper>> ChangeVersionHistoryWithHttpInfoAsync(int fileId, ChangeHistory? changeHistory = default, CancellationToken cancellationToken = default)
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
            if (changeHistory != null) localVarRequestOptions.Data = changeHistory;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileStringArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeVersionHistory", localVarResponse);
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
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper CheckFillFormDraft(int fileId, CheckFillFormDraft? checkFillFormDraft = default)
        {
            var localVarResponse = CheckFillFormDraftWithHttpInfo(fileId, checkFillFormDraft);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> CheckFillFormDraftWithHttpInfo(int fileId, CheckFillFormDraft? checkFillFormDraft = default)
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
            if (checkFillFormDraft != null) localVarRequestOptions.Data = checkFillFormDraft;


            // make the HTTP request
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/files/masterform/{fileId}/checkfillformdraft", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckFillFormDraft", localVarResponse);
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
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> CheckFillFormDraftAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckFillFormDraftWithHttpInfoAsync(fileId, checkFillFormDraft, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> CheckFillFormDraftWithHttpInfoAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, CancellationToken cancellationToken = default)
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
            if (checkFillFormDraft != null) localVarRequestOptions.Data = checkFillFormDraft;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/files/masterform/{fileId}/checkfillformdraft", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckFillFormDraft", localVarResponse);
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
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>FileEntryBaseWrapper</returns>
        public FileEntryBaseWrapper CopyFileAs(int fileId, CopyAsJsonElement? copyAsJsonElement = default)
        {
            var localVarResponse = CopyFileAsWithHttpInfo(fileId, copyAsJsonElement);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseWrapper</returns>
        public ApiResponse<FileEntryBaseWrapper> CopyFileAsWithHttpInfo(int fileId, CopyAsJsonElement? copyAsJsonElement = default)
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
            if (copyAsJsonElement != null) localVarRequestOptions.Data = copyAsJsonElement;


            // make the HTTP request
            var localVarResponse = Client.Post<FileEntryBaseWrapper>("/api/2.0/files/file/{fileId}/copyas", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CopyFileAs", localVarResponse);
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
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of FileEntryBaseWrapper</returns>
        public async Task<FileEntryBaseWrapper> CopyFileAsAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CopyFileAsWithHttpInfoAsync(fileId, copyAsJsonElement, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseWrapper>> CopyFileAsWithHttpInfoAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, CancellationToken cancellationToken = default)
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
            if (copyAsJsonElement != null) localVarRequestOptions.Data = copyAsJsonElement;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileEntryBaseWrapper>("/api/2.0/files/file/{fileId}/copyas", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CopyFileAs", localVarResponse);
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
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper CreateEditSession(int fileId, long? fileSize = default)
        {
            var localVarResponse = CreateEditSessionWithHttpInfo(fileId, fileSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> CreateEditSessionWithHttpInfo(int fileId, long? fileSize = default)
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
            if (fileSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileSize", fileSize));
            }


            // make the HTTP request
            var localVarResponse = Client.Post<ObjectWrapper>("/api/2.0/files/file/{fileId}/edit_session", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateEditSession", localVarResponse);
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
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> CreateEditSessionAsync(int fileId, long? fileSize = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateEditSessionWithHttpInfoAsync(fileId, fileSize, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> CreateEditSessionWithHttpInfoAsync(int fileId, long? fileSize = default, CancellationToken cancellationToken = default)
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
            if (fileSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileSize", fileSize));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/file/{fileId}/edit_session", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateEditSession", localVarResponse);
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
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateFile(int folderId, CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarResponse = CreateFileWithHttpInfo(folderId, createFileJsonElement);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateFileWithHttpInfo(int folderId, CreateFileJsonElement? createFileJsonElement = default)
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
            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/file", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFile", localVarResponse);
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
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> CreateFileAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateFileWithHttpInfoAsync(folderId, createFileJsonElement, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> CreateFileWithHttpInfoAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/file", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFile", localVarResponse);
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
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateFileInMyDocuments(CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarResponse = CreateFileInMyDocumentsWithHttpInfo(createFileJsonElement);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateFileInMyDocumentsWithHttpInfo(CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/file", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFileInMyDocuments", localVarResponse);
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
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> CreateFileInMyDocumentsAsync(CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateFileInMyDocumentsWithHttpInfoAsync(createFileJsonElement, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> CreateFileInMyDocumentsWithHttpInfoAsync(CreateFileJsonElement? createFileJsonElement = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/file", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateFileInMyDocuments", localVarResponse);
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
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateHtmlFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateHtmlFileWithHttpInfo(folderId, createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateHtmlFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
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
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/html", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateHtmlFile", localVarResponse);
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
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> CreateHtmlFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateHtmlFileWithHttpInfoAsync(folderId, createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/html", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateHtmlFile", localVarResponse);
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
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateHtmlFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateHtmlFileInMyDocumentsWithHttpInfo(createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateHtmlFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/html", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateHtmlFileInMyDocuments", localVarResponse);
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
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> CreateHtmlFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateHtmlFileInMyDocumentsWithHttpInfoAsync(createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/html", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateHtmlFileInMyDocuments", localVarResponse);
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
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper CreatePrimaryExternalLink(int id, FileLinkRequest? fileLinkRequest = default)
        {
            var localVarResponse = CreatePrimaryExternalLinkWithHttpInfo(id, fileLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> CreatePrimaryExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreatePrimaryExternalLink", localVarResponse);
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
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> CreatePrimaryExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreatePrimaryExternalLinkWithHttpInfoAsync(id, fileLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> CreatePrimaryExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreatePrimaryExternalLink", localVarResponse);
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
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateTextFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateTextFileWithHttpInfo(folderId, createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateTextFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
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
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/text", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateTextFile", localVarResponse);
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
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> CreateTextFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateTextFileWithHttpInfoAsync(folderId, createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> CreateTextFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/text", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateTextFile", localVarResponse);
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
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateTextFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateTextFileInMyDocumentsWithHttpInfo(createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateTextFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/text", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateTextFileInMyDocuments", localVarResponse);
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
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> CreateTextFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateTextFileInMyDocumentsWithHttpInfoAsync(createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> CreateTextFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/text", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateTextFileInMyDocuments", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper CreateThumbnails(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = CreateThumbnailsWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> CreateThumbnailsWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
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
            var localVarResponse = Client.Post<ObjectArrayWrapper>("/api/2.0/files/thumbnails", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateThumbnails", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async Task<ObjectArrayWrapper> CreateThumbnailsAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateThumbnailsWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async Task<ApiResponse<ObjectArrayWrapper>> CreateThumbnailsWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PostAsync<ObjectArrayWrapper>("/api/2.0/files/thumbnails", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateThumbnails", localVarResponse);
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
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteFile(int fileId, Delete delete)
        {
            var localVarResponse = DeleteFileWithHttpInfo(fileId, delete);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteFileWithHttpInfo(int fileId, Delete delete)
        {
            // verify the required parameter 'delete' is set
            if (delete == null)
                throw new ApiException(400, "Missing required parameter 'delete' when calling FilesApi->DeleteFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (delete != null) localVarRequestOptions.Data = delete;


            // make the HTTP request
            var localVarResponse = Client.Delete<FileOperationArrayWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFile", localVarResponse);
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
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DeleteFileAsync(int fileId, Delete delete, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteFileWithHttpInfoAsync(fileId, delete, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DeleteFileWithHttpInfoAsync(int fileId, Delete delete, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'delete' is set
            if (delete == null)
                throw new ApiException(400, "Missing required parameter 'delete' when calling FilesApi->DeleteFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (delete != null) localVarRequestOptions.Data = delete;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<FileOperationArrayWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFile", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>NoContentResultWrapper</returns>
        public NoContentResultWrapper DeleteRecent(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = DeleteRecentWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>ApiResponse of NoContentResultWrapper</returns>
        public ApiResponse<NoContentResultWrapper> DeleteRecentWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
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
            var localVarResponse = Client.Delete<NoContentResultWrapper>("/api/2.0/files/recent", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRecent", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of NoContentResultWrapper</returns>
        public async Task<NoContentResultWrapper> DeleteRecentAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteRecentWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of ApiResponse (NoContentResultWrapper)</returns>
        public async Task<ApiResponse<NoContentResultWrapper>> DeleteRecentWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NoContentResultWrapper>("/api/2.0/files/recent", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRecent", localVarResponse);
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
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper DeleteTemplates(List<int>? requestBody = default)
        {
            var localVarResponse = DeleteTemplatesWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> DeleteTemplatesWithHttpInfo(List<int>? requestBody = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request
            var localVarResponse = Client.Delete<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteTemplates", localVarResponse);
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
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> DeleteTemplatesAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteTemplatesWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> DeleteTemplatesWithHttpInfoAsync(List<int>? requestBody = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteTemplates", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>FormRoleArrayWrapper</returns>
        public FormRoleArrayWrapper GetAllFormRoles(int fileId)
        {
            var localVarResponse = GetAllFormRolesWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>ApiResponse of FormRoleArrayWrapper</returns>
        public ApiResponse<FormRoleArrayWrapper> GetAllFormRolesWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<FormRoleArrayWrapper>("/api/2.0/files/file/{fileId}/formroles", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllFormRoles", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of FormRoleArrayWrapper</returns>
        public async Task<FormRoleArrayWrapper> GetAllFormRolesAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetAllFormRolesWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleArrayWrapper)</returns>
        public async Task<ApiResponse<FormRoleArrayWrapper>> GetAllFormRolesWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FormRoleArrayWrapper>("/api/2.0/files/file/{fileId}/formroles", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetAllFormRoles", localVarResponse);
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
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>EditHistoryDataWrapper</returns>
        public EditHistoryDataWrapper GetEditDiffUrl(int fileId, int? version = default)
        {
            var localVarResponse = GetEditDiffUrlWithHttpInfo(fileId, version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>ApiResponse of EditHistoryDataWrapper</returns>
        public ApiResponse<EditHistoryDataWrapper> GetEditDiffUrlWithHttpInfo(int fileId, int? version = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<EditHistoryDataWrapper>("/api/2.0/files/file/{fileId}/edit/diff", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetEditDiffUrl", localVarResponse);
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
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of EditHistoryDataWrapper</returns>
        public async Task<EditHistoryDataWrapper> GetEditDiffUrlAsync(int fileId, int? version = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetEditDiffUrlWithHttpInfoAsync(fileId, version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryDataWrapper)</returns>
        public async Task<ApiResponse<EditHistoryDataWrapper>> GetEditDiffUrlWithHttpInfoAsync(int fileId, int? version = default, CancellationToken cancellationToken = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<EditHistoryDataWrapper>("/api/2.0/files/file/{fileId}/edit/diff", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetEditDiffUrl", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        public EditHistoryArrayWrapper GetEditHistory(int fileId)
        {
            var localVarResponse = GetEditHistoryWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        public ApiResponse<EditHistoryArrayWrapper> GetEditHistoryWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/edit/history", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetEditHistory", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        public async Task<EditHistoryArrayWrapper> GetEditHistoryAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetEditHistoryWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        public async Task<ApiResponse<EditHistoryArrayWrapper>> GetEditHistoryWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/edit/history", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetEditHistory", localVarResponse);
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
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        public HistoryArrayWrapper GetFileHistory(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFileHistoryWithHttpInfo(fileId, fromDate, toDate, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        public ApiResponse<HistoryArrayWrapper> GetFileHistoryWithHttpInfo(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default)
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


            // make the HTTP request
            var localVarResponse = Client.Get<HistoryArrayWrapper>("/api/2.0/files/file/{fileId}/log", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileHistory", localVarResponse);
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
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        public async Task<HistoryArrayWrapper> GetFileHistoryAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFileHistoryWithHttpInfoAsync(fileId, fromDate, toDate, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        public async Task<ApiResponse<HistoryArrayWrapper>> GetFileHistoryWithHttpInfoAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
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


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<HistoryArrayWrapper>("/api/2.0/files/file/{fileId}/log", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileHistory", localVarResponse);
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
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper GetFileInfo(int fileId, int? version = default)
        {
            var localVarResponse = GetFileInfoWithHttpInfo(fileId, version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> GetFileInfoWithHttpInfo(int fileId, int? version = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileInfo", localVarResponse);
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
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> GetFileInfoAsync(int fileId, int? version = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFileInfoWithHttpInfoAsync(fileId, version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> GetFileInfoWithHttpInfoAsync(int fileId, int? version = default, CancellationToken cancellationToken = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileInfo", localVarResponse);
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
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetFileLinks(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFileLinksWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetFileLinksWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            var localVarResponse = Client.Get<FileShareArrayWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileLinks", localVarResponse);
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
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetFileLinksAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFileLinksWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetFileLinksWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileLinks", localVarResponse);
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
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper GetFilePrimaryExternalLink(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFilePrimaryExternalLinkWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> GetFilePrimaryExternalLinkWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            var localVarResponse = Client.Get<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilePrimaryExternalLink", localVarResponse);
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
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> GetFilePrimaryExternalLinkAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFilePrimaryExternalLinkWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> GetFilePrimaryExternalLinkWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFilePrimaryExternalLink", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>FileStringArrayWrapper</returns>
        public FileStringArrayWrapper GetFileVersionInfo(int fileId)
        {
            var localVarResponse = GetFileVersionInfoWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>ApiResponse of FileStringArrayWrapper</returns>
        public ApiResponse<FileStringArrayWrapper> GetFileVersionInfoWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<FileStringArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileVersionInfo", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of FileStringArrayWrapper</returns>
        public async Task<FileStringArrayWrapper> GetFileVersionInfoAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFileVersionInfoWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileStringArrayWrapper)</returns>
        public async Task<ApiResponse<FileStringArrayWrapper>> GetFileVersionInfoWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FileStringArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFileVersionInfo", localVarResponse);
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
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>FillingFormResultIntegerWrapper</returns>
        public FillingFormResultIntegerWrapper GetFillResult(string? fillingSessionId = default)
        {
            var localVarResponse = GetFillResultWithHttpInfo(fillingSessionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>ApiResponse of FillingFormResultIntegerWrapper</returns>
        public ApiResponse<FillingFormResultIntegerWrapper> GetFillResultWithHttpInfo(string? fillingSessionId = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (fillingSessionId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fillingSessionId", fillingSessionId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FillingFormResultIntegerWrapper>("/api/2.0/files/file/fillresult", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFillResult", localVarResponse);
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
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of FillingFormResultIntegerWrapper</returns>
        public async Task<FillingFormResultIntegerWrapper> GetFillResultAsync(string? fillingSessionId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetFillResultWithHttpInfoAsync(fillingSessionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of ApiResponse (FillingFormResultIntegerWrapper)</returns>
        public async Task<ApiResponse<FillingFormResultIntegerWrapper>> GetFillResultWithHttpInfoAsync(string? fillingSessionId = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (fillingSessionId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fillingSessionId", fillingSessionId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FillingFormResultIntegerWrapper>("/api/2.0/files/file/fillresult", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetFillResult", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>FileLinkWrapper</returns>
        public FileLinkWrapper GetPresignedFileUri(int fileId)
        {
            var localVarResponse = GetPresignedFileUriWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>ApiResponse of FileLinkWrapper</returns>
        public ApiResponse<FileLinkWrapper> GetPresignedFileUriWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<FileLinkWrapper>("/api/2.0/files/file/{fileId}/presigned", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPresignedFileUri", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of FileLinkWrapper</returns>
        public async Task<FileLinkWrapper> GetPresignedFileUriAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPresignedFileUriWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of ApiResponse (FileLinkWrapper)</returns>
        public async Task<ApiResponse<FileLinkWrapper>> GetPresignedFileUriWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<FileLinkWrapper>("/api/2.0/files/file/{fileId}/presigned", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPresignedFileUri", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPresignedUri(int fileId)
        {
            var localVarResponse = GetPresignedUriWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPresignedUriWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<StringWrapper>("/api/2.0/files/file/{fileId}/presigneduri", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPresignedUri", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> GetPresignedUriAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPresignedUriWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> GetPresignedUriWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/files/file/{fileId}/presigneduri", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPresignedUri", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        public MentionWrapperArrayWrapper GetProtectedFileUsers(int fileId)
        {
            var localVarResponse = GetProtectedFileUsersWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        public ApiResponse<MentionWrapperArrayWrapper> GetProtectedFileUsersWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/protectusers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProtectedFileUsers", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        public async Task<MentionWrapperArrayWrapper> GetProtectedFileUsersAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetProtectedFileUsersWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        public async Task<ApiResponse<MentionWrapperArrayWrapper>> GetProtectedFileUsersWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/protectusers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetProtectedFileUsers", localVarResponse);
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
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>FileReferenceWrapper</returns>
        public FileReferenceWrapper GetReferenceData(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default)
        {
            var localVarResponse = GetReferenceDataWithHttpInfo(getReferenceDataDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>ApiResponse of FileReferenceWrapper</returns>
        public ApiResponse<FileReferenceWrapper> GetReferenceDataWithHttpInfo(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (getReferenceDataDtoInteger != null) localVarRequestOptions.Data = getReferenceDataDtoInteger;


            // make the HTTP request
            var localVarResponse = Client.Post<FileReferenceWrapper>("/api/2.0/files/file/referencedata", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetReferenceData", localVarResponse);
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
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of FileReferenceWrapper</returns>
        public async Task<FileReferenceWrapper> GetReferenceDataAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetReferenceDataWithHttpInfoAsync(getReferenceDataDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger">The request parameters for getting reference data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of ApiResponse (FileReferenceWrapper)</returns>
        public async Task<ApiResponse<FileReferenceWrapper>> GetReferenceDataWithHttpInfoAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (getReferenceDataDtoInteger != null) localVarRequestOptions.Data = getReferenceDataDtoInteger;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileReferenceWrapper>("/api/2.0/files/file/referencedata", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetReferenceData", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper IsFormPDF(int fileId)
        {
            var localVarResponse = IsFormPDFWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> IsFormPDFWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Get<BooleanWrapper>("/api/2.0/files/file/{fileId}/isformpdf", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("IsFormPDF", localVarResponse);
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
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> IsFormPDFAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await IsFormPDFWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> IsFormPDFWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/files/file/{fileId}/isformpdf", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("IsFormPDF", localVarResponse);
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
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper LockFile(int fileId, LockFileParameters? lockFileParameters = default)
        {
            var localVarResponse = LockFileWithHttpInfo(fileId, lockFileParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> LockFileWithHttpInfo(int fileId, LockFileParameters? lockFileParameters = default)
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
            if (lockFileParameters != null) localVarRequestOptions.Data = lockFileParameters;


            // make the HTTP request
            var localVarResponse = Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/lock", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("LockFile", localVarResponse);
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
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> LockFileAsync(int fileId, LockFileParameters? lockFileParameters = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await LockFileWithHttpInfoAsync(fileId, lockFileParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> LockFileWithHttpInfoAsync(int fileId, LockFileParameters? lockFileParameters = default, CancellationToken cancellationToken = default)
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
            if (lockFileParameters != null) localVarRequestOptions.Data = lockFileParameters;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/lock", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("LockFile", localVarResponse);
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
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns></returns>
        public void ManageFormFilling(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default)
        {
            ManageFormFillingWithHttpInfo(fileId, manageFormFillingDtoInteger);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ManageFormFillingWithHttpInfo(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->ManageFormFilling");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (manageFormFillingDtoInteger != null) localVarRequestOptions.Data = manageFormFillingDtoInteger;


            // make the HTTP request
            var localVarResponse = Client.Put<Object>("/api/2.0/files/file/{fileId}/manageformfilling", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ManageFormFilling", localVarResponse);
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
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ManageFormFillingAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, CancellationToken cancellationToken = default)
        {
            await ManageFormFillingWithHttpInfoAsync(fileId, manageFormFillingDtoInteger, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger">The parameters for managing form filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ManageFormFillingWithHttpInfoAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->ManageFormFilling");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (manageFormFillingDtoInteger != null) localVarRequestOptions.Data = manageFormFillingDtoInteger;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<Object>("/api/2.0/files/file/{fileId}/manageformfilling", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ManageFormFilling", localVarResponse);
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
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ConfigurationIntegerWrapper</returns>
        public ConfigurationIntegerWrapper OpenEditFile(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default)
        {
            var localVarResponse = OpenEditFileWithHttpInfo(fileId, version, view, editorType, edit, fill);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ApiResponse of ConfigurationIntegerWrapper</returns>
        public ApiResponse<ConfigurationIntegerWrapper> OpenEditFileWithHttpInfo(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (view != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "view", view));
            }
            if (editorType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "editorType", editorType));
            }
            if (edit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "edit", edit));
            }
            if (fill != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fill", fill));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<ConfigurationIntegerWrapper>("/api/2.0/files/file/{fileId}/openedit", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("OpenEditFile", localVarResponse);
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
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ConfigurationIntegerWrapper</returns>
        public async Task<ConfigurationIntegerWrapper> OpenEditFileAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await OpenEditFileWithHttpInfoAsync(fileId, version, view, editorType, edit, fill, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (ConfigurationIntegerWrapper)</returns>
        public async Task<ApiResponse<ConfigurationIntegerWrapper>> OpenEditFileWithHttpInfoAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, CancellationToken cancellationToken = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (view != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "view", view));
            }
            if (editorType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "editorType", editorType));
            }
            if (edit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "edit", edit));
            }
            if (fill != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fill", fill));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ConfigurationIntegerWrapper>("/api/2.0/files/file/{fileId}/openedit", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("OpenEditFile", localVarResponse);
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
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        public EditHistoryArrayWrapper RestoreFileVersion(int fileId, int? version = default, string? url = default)
        {
            var localVarResponse = RestoreFileVersionWithHttpInfo(fileId, version, url);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        public ApiResponse<EditHistoryArrayWrapper> RestoreFileVersionWithHttpInfo(int fileId, int? version = default, string? url = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (url != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "url", url));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/restoreversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RestoreFileVersion", localVarResponse);
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
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        public async Task<EditHistoryArrayWrapper> RestoreFileVersionAsync(int fileId, int? version = default, string? url = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RestoreFileVersionWithHttpInfoAsync(fileId, version, url, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        public async Task<ApiResponse<EditHistoryArrayWrapper>> RestoreFileVersionWithHttpInfoAsync(int fileId, int? version = default, string? url = default, CancellationToken cancellationToken = default)
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
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (url != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "url", url));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/restoreversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RestoreFileVersion", localVarResponse);
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
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SaveEditingFileFromForm(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default)
        {
            var localVarResponse = SaveEditingFileFromFormWithHttpInfo(fileId, fileExtension, downloadUri, file, forcesave);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SaveEditingFileFromFormWithHttpInfo(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fileExtension != null)
            {
                localVarRequestOptions.FormParameters.Add("FileExtension",ClientUtils.ParameterToString(fileExtension)); // form parameter
            }
            if (downloadUri != null)
            {
                localVarRequestOptions.FormParameters.Add("DownloadUri",ClientUtils.ParameterToString(downloadUri)); // form parameter
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (forcesave != null)
            {
                localVarRequestOptions.FormParameters.Add("Forcesave",ClientUtils.ParameterToString(forcesave)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/saveediting", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveEditingFileFromForm", localVarResponse);
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
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> SaveEditingFileFromFormAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveEditingFileFromFormWithHttpInfoAsync(fileId, fileExtension, downloadUri, file, forcesave, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> SaveEditingFileFromFormWithHttpInfoAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fileExtension != null)
            {
                localVarRequestOptions.FormParameters.Add("FileExtension", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(fileExtension)); // form parameter
            }
            if (downloadUri != null)
            {
                localVarRequestOptions.FormParameters.Add("DownloadUri", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(downloadUri)); // form parameter
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (forcesave != null)
            {
                localVarRequestOptions.FormParameters.Add("Forcesave", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(forcesave)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/saveediting", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveEditingFileFromForm", localVarResponse);
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
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SaveFileAsPdf(int id, SaveAsPdfInteger? saveAsPdfInteger = default)
        {
            var localVarResponse = SaveFileAsPdfWithHttpInfo(id, saveAsPdfInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SaveFileAsPdfWithHttpInfo(int id, SaveAsPdfInteger? saveAsPdfInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (saveAsPdfInteger != null) localVarRequestOptions.Data = saveAsPdfInteger;


            // make the HTTP request
            var localVarResponse = Client.Post<FileIntegerWrapper>("/api/2.0/files/file/{id}/saveaspdf", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveFileAsPdf", localVarResponse);
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
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> SaveFileAsPdfAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveFileAsPdfWithHttpInfoAsync(id, saveAsPdfInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> SaveFileAsPdfWithHttpInfoAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (saveAsPdfInteger != null) localVarRequestOptions.Data = saveAsPdfInteger;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/file/{id}/saveaspdf", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveFileAsPdf", localVarResponse);
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
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>FormRoleWrapper</returns>
        public FormRoleWrapper SaveFormRoleMapping(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default)
        {
            var localVarResponse = SaveFormRoleMappingWithHttpInfo(fileId, saveFormRoleMappingDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>ApiResponse of FormRoleWrapper</returns>
        public ApiResponse<FormRoleWrapper> SaveFormRoleMappingWithHttpInfo(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->SaveFormRoleMapping");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (saveFormRoleMappingDtoInteger != null) localVarRequestOptions.Data = saveFormRoleMappingDtoInteger;


            // make the HTTP request
            var localVarResponse = Client.Post<FormRoleWrapper>("/api/2.0/files/file/{fileId}/formrolemapping", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveFormRoleMapping", localVarResponse);
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
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of FormRoleWrapper</returns>
        public async Task<FormRoleWrapper> SaveFormRoleMappingAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SaveFormRoleMappingWithHttpInfoAsync(fileId, saveFormRoleMappingDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger">The parameters for saving form role mapping. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleWrapper)</returns>
        public async Task<ApiResponse<FormRoleWrapper>> SaveFormRoleMappingWithHttpInfoAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesApi->SaveFormRoleMapping");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (saveFormRoleMappingDtoInteger != null) localVarRequestOptions.Data = saveFormRoleMappingDtoInteger;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FormRoleWrapper>("/api/2.0/files/file/{fileId}/formrolemapping", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SaveFormRoleMapping", localVarResponse);
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
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SetCustomFilterTag(int fileId, CustomFilterParameters? customFilterParameters = default)
        {
            var localVarResponse = SetCustomFilterTagWithHttpInfo(fileId, customFilterParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SetCustomFilterTagWithHttpInfo(int fileId, CustomFilterParameters? customFilterParameters = default)
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
            if (customFilterParameters != null) localVarRequestOptions.Data = customFilterParameters;


            // make the HTTP request
            var localVarResponse = Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/customfilter", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetCustomFilterTag", localVarResponse);
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
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> SetCustomFilterTagAsync(int fileId, CustomFilterParameters? customFilterParameters = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetCustomFilterTagWithHttpInfoAsync(fileId, customFilterParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> SetCustomFilterTagWithHttpInfoAsync(int fileId, CustomFilterParameters? customFilterParameters = default, CancellationToken cancellationToken = default)
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
            if (customFilterParameters != null) localVarRequestOptions.Data = customFilterParameters;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/customfilter", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetCustomFilterTag", localVarResponse);
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
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper SetExternalLink(int id, FileLinkRequest? fileLinkRequest = default)
        {
            var localVarResponse = SetExternalLinkWithHttpInfo(id, fileLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> SetExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<FileShareWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetExternalLink", localVarResponse);
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
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> SetExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetExternalLinkWithHttpInfoAsync(id, fileLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> SetExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetExternalLink", localVarResponse);
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
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SetFileOrder(int fileId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarResponse = SetFileOrderWithHttpInfo(fileId, orderRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SetFileOrderWithHttpInfo(int fileId, OrderRequestDto? orderRequestDto = default)
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
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileIntegerWrapper>("/api/2.0/files/{fileId}/order", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileOrder", localVarResponse);
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
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> SetFileOrderAsync(int fileId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFileOrderWithHttpInfoAsync(fileId, orderRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> SetFileOrderWithHttpInfoAsync(int fileId, OrderRequestDto? orderRequestDto = default, CancellationToken cancellationToken = default)
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
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/{fileId}/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFileOrder", localVarResponse);
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
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>FileEntryStringArrayWrapper</returns>
        public FileEntryStringArrayWrapper SetFilesOrder(OrdersRequestDtoInteger? ordersRequestDtoInteger = default)
        {
            var localVarResponse = SetFilesOrderWithHttpInfo(ordersRequestDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>ApiResponse of FileEntryStringArrayWrapper</returns>
        public ApiResponse<FileEntryStringArrayWrapper> SetFilesOrderWithHttpInfo(OrdersRequestDtoInteger? ordersRequestDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ordersRequestDtoInteger != null) localVarRequestOptions.Data = ordersRequestDtoInteger;


            // make the HTTP request
            var localVarResponse = Client.Put<FileEntryStringArrayWrapper>("/api/2.0/files/order", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFilesOrder", localVarResponse);
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
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of FileEntryStringArrayWrapper</returns>
        public async Task<FileEntryStringArrayWrapper> SetFilesOrderAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetFilesOrderWithHttpInfoAsync(ordersRequestDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger">The collection of items to be ordered. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryStringArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryStringArrayWrapper>> SetFilesOrderWithHttpInfoAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ordersRequestDtoInteger != null) localVarRequestOptions.Data = ordersRequestDtoInteger;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileEntryStringArrayWrapper>("/api/2.0/files/order", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetFilesOrder", localVarResponse);
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
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper StartEditFile(int fileId, StartEdit? startEdit = default)
        {
            var localVarResponse = StartEditFileWithHttpInfo(fileId, startEdit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> StartEditFileWithHttpInfo(int fileId, StartEdit? startEdit = default)
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
            if (startEdit != null) localVarRequestOptions.Data = startEdit;


            // make the HTTP request
            var localVarResponse = Client.Post<StringWrapper>("/api/2.0/files/file/{fileId}/startedit", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartEditFile", localVarResponse);
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
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> StartEditFileAsync(int fileId, StartEdit? startEdit = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StartEditFileWithHttpInfoAsync(fileId, startEdit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> StartEditFileWithHttpInfoAsync(int fileId, StartEdit? startEdit = default, CancellationToken cancellationToken = default)
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
            if (startEdit != null) localVarRequestOptions.Data = startEdit;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/files/file/{fileId}/startedit", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartEditFile", localVarResponse);
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
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper StartFillingFile(int fileId)
        {
            var localVarResponse = StartFillingFileWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> StartFillingFileWithHttpInfo(int fileId)
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
            var localVarResponse = Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/startfilling", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartFillingFile", localVarResponse);
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
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> StartFillingFileAsync(int fileId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StartFillingFileWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> StartFillingFileWithHttpInfoAsync(int fileId, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/startfilling", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartFillingFile", localVarResponse);
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
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>KeyValuePairBooleanStringWrapper</returns>
        public KeyValuePairBooleanStringWrapper TrackEditFile(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default)
        {
            var localVarResponse = TrackEditFileWithHttpInfo(fileId, tabId, docKeyForTrack, isFinish);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>ApiResponse of KeyValuePairBooleanStringWrapper</returns>
        public ApiResponse<KeyValuePairBooleanStringWrapper> TrackEditFileWithHttpInfo(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default)
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
            if (tabId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tabId", tabId));
            }
            if (docKeyForTrack != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "docKeyForTrack", docKeyForTrack));
            }
            if (isFinish != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isFinish", isFinish));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<KeyValuePairBooleanStringWrapper>("/api/2.0/files/file/{fileId}/trackeditfile", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TrackEditFile", localVarResponse);
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
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of KeyValuePairBooleanStringWrapper</returns>
        public async Task<KeyValuePairBooleanStringWrapper> TrackEditFileAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await TrackEditFileWithHttpInfoAsync(fileId, tabId, docKeyForTrack, isFinish, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (KeyValuePairBooleanStringWrapper)</returns>
        public async Task<ApiResponse<KeyValuePairBooleanStringWrapper>> TrackEditFileWithHttpInfoAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, CancellationToken cancellationToken = default)
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
            if (tabId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tabId", tabId));
            }
            if (docKeyForTrack != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "docKeyForTrack", docKeyForTrack));
            }
            if (isFinish != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isFinish", isFinish));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<KeyValuePairBooleanStringWrapper>("/api/2.0/files/file/{fileId}/trackeditfile", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TrackEditFile", localVarResponse);
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
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper UpdateFile(int fileId, UpdateFile? updateFile = default)
        {
            var localVarResponse = UpdateFileWithHttpInfo(fileId, updateFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> UpdateFileWithHttpInfo(int fileId, UpdateFile? updateFile = default)
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
            if (updateFile != null) localVarRequestOptions.Data = updateFile;


            // make the HTTP request
            var localVarResponse = Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFile", localVarResponse);
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
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async Task<FileIntegerWrapper> UpdateFileAsync(int fileId, UpdateFile? updateFile = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateFileWithHttpInfoAsync(fileId, updateFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async Task<ApiResponse<FileIntegerWrapper>> UpdateFileWithHttpInfoAsync(int fileId, UpdateFile? updateFile = default, CancellationToken cancellationToken = default)
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
            if (updateFile != null) localVarRequestOptions.Data = updateFile;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
