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
    public interface IOperationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper BulkDownload(DownloadRequestDto? downloadRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> BulkDownloadWithHttpInfo(DownloadRequestDto? downloadRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        ConversationResultArrayWrapper CheckConversionStatus(int fileId, bool? start = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        ApiResponse<ConversationResultArrayWrapper> CheckConversionStatusWithHttpInfo(int fileId, bool? start = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        FileEntryBaseArrayWrapper CheckMoveOrCopyBatchItems(BatchRequestDto? inDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        ApiResponse<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsWithHttpInfo(BatchRequestDto? inDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>CheckDestFolderWrapper</returns>
        CheckDestFolderWrapper CheckMoveOrCopyDestFolder(BatchRequestDto? inDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>ApiResponse of CheckDestFolderWrapper</returns>
        ApiResponse<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderWithHttpInfo(BatchRequestDto? inDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper CopyBatchItems(BatchRequestDto? batchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> CopyBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper CreateUploadSession(int folderId, SessionRequest? sessionRequest = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> CreateUploadSessionWithHttpInfo(int folderId, SessionRequest? sessionRequest = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteBatchItems(DeleteBatchRequestDto? deleteBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteBatchItemsWithHttpInfo(DeleteBatchRequestDto? deleteBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper DeleteFileVersions(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> DeleteFileVersionsWithHttpInfo(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DuplicateBatchItems(DuplicateRequestDto? duplicateRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DuplicateBatchItemsWithHttpInfo(DuplicateRequestDto? duplicateRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper EmptyTrash(bool? single = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> EmptyTrashWithHttpInfo(bool? single = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper GetOperationStatuses(string? id = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> GetOperationStatusesWithHttpInfo(string? id = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper GetOperationStatusesByType(FileOperationType operationType, string? id = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> GetOperationStatusesByTypeWithHttpInfo(FileOperationType operationType, string? id = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper MarkAsRead(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> MarkAsReadWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper MoveBatchItems(BatchRequestDto? batchRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> MoveBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        ConversationResultArrayWrapper StartFileConversion(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        ApiResponse<ConversationResultArrayWrapper> StartFileConversionWithHttpInfo(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper TerminateTasks(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> TerminateTasksWithHttpInfo(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper UpdateFileComment(int fileId, UpdateComment? updateComment = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> UpdateFileCommentWithHttpInfo(int fileId, UpdateComment? updateComment = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> BulkDownloadAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> BulkDownloadWithHttpInfoAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        Task<ConversationResultArrayWrapper> CheckConversionStatusAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        Task<ApiResponse<ConversationResultArrayWrapper>> CheckConversionStatusWithHttpInfoAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        Task<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<FileEntryBaseArrayWrapper>> CheckMoveOrCopyBatchItemsWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of CheckDestFolderWrapper</returns>
        Task<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of ApiResponse (CheckDestFolderWrapper)</returns>
        Task<ApiResponse<CheckDestFolderWrapper>> CheckMoveOrCopyDestFolderWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> CopyBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> CopyBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> CreateUploadSessionAsync(int folderId, SessionRequest? sessionRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> CreateUploadSessionWithHttpInfoAsync(int folderId, SessionRequest? sessionRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DeleteBatchItemsAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DeleteBatchItemsWithHttpInfoAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        Task<FileOperationWrapper> DeleteFileVersionsAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        Task<ApiResponse<FileOperationWrapper>> DeleteFileVersionsWithHttpInfoAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> DuplicateBatchItemsAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> DuplicateBatchItemsWithHttpInfoAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> EmptyTrashAsync(bool? single = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> EmptyTrashWithHttpInfoAsync(bool? single = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> GetOperationStatusesAsync(string? id = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesWithHttpInfoAsync(string? id = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> GetOperationStatusesByTypeAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesByTypeWithHttpInfoAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> MarkAsReadAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> MarkAsReadWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> MoveBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> MoveBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        Task<ConversationResultArrayWrapper> StartFileConversionAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        Task<ApiResponse<ConversationResultArrayWrapper>> StartFileConversionWithHttpInfoAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        Task<FileOperationArrayWrapper> TerminateTasksAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        Task<ApiResponse<FileOperationArrayWrapper>> TerminateTasksWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        Task<StringWrapper> UpdateFileCommentAsync(int fileId, UpdateComment? updateComment = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        Task<ApiResponse<StringWrapper>> UpdateFileCommentWithHttpInfoAsync(int fileId, UpdateComment? updateComment = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOperationsApi : IOperationsApiSync, IOperationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OperationsApi : IDisposable, IOperationsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public OperationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public OperationsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public OperationsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public OperationsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationsApi"/> class.
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
        public OperationsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class using a Configuration object.
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
        public OperationsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="OperationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public OperationsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper BulkDownload(DownloadRequestDto? downloadRequestDto = default)
        {
            var localVarResponse = BulkDownloadWithHttpInfo(downloadRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> BulkDownloadWithHttpInfo(DownloadRequestDto? downloadRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (downloadRequestDto != null) localVarRequestOptions.Data = downloadRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/bulkdownload", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("BulkDownload", localVarResponse);
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
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> BulkDownloadAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await BulkDownloadWithHttpInfoAsync(downloadRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="downloadRequestDto">The request parameters for downloading files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/bulk-download/">REST API Reference for BulkDownload Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> BulkDownloadWithHttpInfoAsync(DownloadRequestDto? downloadRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (downloadRequestDto != null) localVarRequestOptions.Data = downloadRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/bulkdownload", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("BulkDownload", localVarResponse);
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
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        public ConversationResultArrayWrapper CheckConversionStatus(int fileId, bool? start = default)
        {
            var localVarResponse = CheckConversionStatusWithHttpInfo(fileId, start);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        public ApiResponse<ConversationResultArrayWrapper> CheckConversionStatusWithHttpInfo(int fileId, bool? start = default)
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
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start", start));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckConversionStatus", localVarResponse);
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
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        public async Task<ConversationResultArrayWrapper> CheckConversionStatusAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckConversionStatusWithHttpInfoAsync(fileId, start, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to check conversion status.</param>
        /// <param name="start">Specifies whether a conversion operation is started or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-conversion-status/">REST API Reference for CheckConversionStatus Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        public async Task<ApiResponse<ConversationResultArrayWrapper>> CheckConversionStatusWithHttpInfoAsync(int fileId, bool? start = default, CancellationToken cancellationToken = default)
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
            if (start != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "start", start));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckConversionStatus", localVarResponse);
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
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>FileEntryBaseArrayWrapper</returns>
        public FileEntryBaseArrayWrapper CheckMoveOrCopyBatchItems(BatchRequestDto? inDto = default)
        {
            var localVarResponse = CheckMoveOrCopyBatchItemsWithHttpInfo(inDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileEntryBaseArrayWrapper</returns>
        public ApiResponse<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsWithHttpInfo(BatchRequestDto? inDto = default)
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


            // make the HTTP request
            var localVarResponse = Client.Get<FileEntryBaseArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyBatchItems", localVarResponse);
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
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of FileEntryBaseArrayWrapper</returns>
        public async Task<FileEntryBaseArrayWrapper> CheckMoveOrCopyBatchItemsAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckMoveOrCopyBatchItemsWithHttpInfoAsync(inDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-batch-items/">REST API Reference for CheckMoveOrCopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<FileEntryBaseArrayWrapper>> CheckMoveOrCopyBatchItemsWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileEntryBaseArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyBatchItems", localVarResponse);
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
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>CheckDestFolderWrapper</returns>
        public CheckDestFolderWrapper CheckMoveOrCopyDestFolder(BatchRequestDto? inDto = default)
        {
            var localVarResponse = CheckMoveOrCopyDestFolderWithHttpInfo(inDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>ApiResponse of CheckDestFolderWrapper</returns>
        public ApiResponse<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderWithHttpInfo(BatchRequestDto? inDto = default)
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


            // make the HTTP request
            var localVarResponse = Client.Get<CheckDestFolderWrapper>("/api/2.0/files/fileops/checkdestfolder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyDestFolder", localVarResponse);
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
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of CheckDestFolderWrapper</returns>
        public async Task<CheckDestFolderWrapper> CheckMoveOrCopyDestFolderAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CheckMoveOrCopyDestFolderWithHttpInfoAsync(inDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-move-or-copy-dest-folder/">REST API Reference for CheckMoveOrCopyDestFolder Operation</seealso>
        /// <returns>Task of ApiResponse (CheckDestFolderWrapper)</returns>
        public async Task<ApiResponse<CheckDestFolderWrapper>> CheckMoveOrCopyDestFolderWithHttpInfoAsync(BatchRequestDto? inDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (inDto != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "inDto", inDto));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<CheckDestFolderWrapper>("/api/2.0/files/fileops/checkdestfolder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CheckMoveOrCopyDestFolder", localVarResponse);
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
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper CopyBatchItems(BatchRequestDto? batchRequestDto = default)
        {
            var localVarResponse = CopyBatchItemsWithHttpInfo(batchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> CopyBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/copy", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CopyBatchItems", localVarResponse);
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
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> CopyBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CopyBatchItemsWithHttpInfoAsync(batchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-batch-items/">REST API Reference for CopyBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> CopyBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/copy", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CopyBatchItems", localVarResponse);
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
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper CreateUploadSession(int folderId, SessionRequest? sessionRequest = default)
        {
            var localVarResponse = CreateUploadSessionWithHttpInfo(folderId, sessionRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> CreateUploadSessionWithHttpInfo(int folderId, SessionRequest? sessionRequest = default)
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
            if (sessionRequest != null) localVarRequestOptions.Data = sessionRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<ObjectWrapper>("/api/2.0/files/{folderId}/upload/create_session", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateUploadSession", localVarResponse);
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
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> CreateUploadSessionAsync(int folderId, SessionRequest? sessionRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateUploadSessionWithHttpInfoAsync(folderId, sessionRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID of the session.</param>
        /// <param name="sessionRequest">The session parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-upload-session/">REST API Reference for CreateUploadSession Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> CreateUploadSessionWithHttpInfoAsync(int folderId, SessionRequest? sessionRequest = default, CancellationToken cancellationToken = default)
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
            if (sessionRequest != null) localVarRequestOptions.Data = sessionRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/{folderId}/upload/create_session", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateUploadSession", localVarResponse);
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
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteBatchItems(DeleteBatchRequestDto? deleteBatchRequestDto = default)
        {
            var localVarResponse = DeleteBatchItemsWithHttpInfo(deleteBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteBatchItemsWithHttpInfo(DeleteBatchRequestDto? deleteBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteBatchRequestDto != null) localVarRequestOptions.Data = deleteBatchRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteBatchItems", localVarResponse);
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
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DeleteBatchItemsAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteBatchItemsWithHttpInfoAsync(deleteBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBatchRequestDto">The request parameters for deleting files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-batch-items/">REST API Reference for DeleteBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DeleteBatchItemsWithHttpInfoAsync(DeleteBatchRequestDto? deleteBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteBatchRequestDto != null) localVarRequestOptions.Data = deleteBatchRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteBatchItems", localVarResponse);
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
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper DeleteFileVersions(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default)
        {
            var localVarResponse = DeleteFileVersionsWithHttpInfo(deleteVersionBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public ApiResponse<FileOperationWrapper> DeleteFileVersionsWithHttpInfo(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteVersionBatchRequestDto != null) localVarRequestOptions.Data = deleteVersionBatchRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationWrapper>("/api/2.0/files/fileops/deleteversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFileVersions", localVarResponse);
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
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async Task<FileOperationWrapper> DeleteFileVersionsAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteFileVersionsWithHttpInfoAsync(deleteVersionBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteVersionBatchRequestDto">The request parameters for deleting file versions. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file-versions/">REST API Reference for DeleteFileVersions Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async Task<ApiResponse<FileOperationWrapper>> DeleteFileVersionsWithHttpInfoAsync(DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (deleteVersionBatchRequestDto != null) localVarRequestOptions.Data = deleteVersionBatchRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationWrapper>("/api/2.0/files/fileops/deleteversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteFileVersions", localVarResponse);
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
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DuplicateBatchItems(DuplicateRequestDto? duplicateRequestDto = default)
        {
            var localVarResponse = DuplicateBatchItemsWithHttpInfo(duplicateRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DuplicateBatchItemsWithHttpInfo(DuplicateRequestDto? duplicateRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (duplicateRequestDto != null) localVarRequestOptions.Data = duplicateRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/duplicate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DuplicateBatchItems", localVarResponse);
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
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> DuplicateBatchItemsAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DuplicateBatchItemsWithHttpInfoAsync(duplicateRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="duplicateRequestDto">The duplicate request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/duplicate-batch-items/">REST API Reference for DuplicateBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> DuplicateBatchItemsWithHttpInfoAsync(DuplicateRequestDto? duplicateRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (duplicateRequestDto != null) localVarRequestOptions.Data = duplicateRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/duplicate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DuplicateBatchItems", localVarResponse);
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
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper EmptyTrash(bool? single = default)
        {
            var localVarResponse = EmptyTrashWithHttpInfo(single);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> EmptyTrashWithHttpInfo(bool? single = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (single != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Single", single));
            }


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/emptytrash", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EmptyTrash", localVarResponse);
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
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> EmptyTrashAsync(bool? single = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await EmptyTrashWithHttpInfoAsync(single, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="single">Specifies whether to return only the current operation (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/empty-trash/">REST API Reference for EmptyTrash Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> EmptyTrashWithHttpInfoAsync(bool? single = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (single != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "Single", single));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/emptytrash", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("EmptyTrash", localVarResponse);
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
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper GetOperationStatuses(string? id = default)
        {
            var localVarResponse = GetOperationStatusesWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> GetOperationStatusesWithHttpInfo(string? id = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileOperationArrayWrapper>("/api/2.0/files/fileops", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatuses", localVarResponse);
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
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> GetOperationStatusesAsync(string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetOperationStatusesWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses/">REST API Reference for GetOperationStatuses Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesWithHttpInfoAsync(string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatuses", localVarResponse);
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
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper GetOperationStatusesByType(FileOperationType operationType, string? id = default)
        {
            var localVarResponse = GetOperationStatusesByTypeWithHttpInfo(operationType, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> GetOperationStatusesByTypeWithHttpInfo(FileOperationType operationType, string? id = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("operationType", ClientUtils.ParameterToString(operationType)); // path parameter
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileOperationArrayWrapper>("/api/2.0/files/fileops/{operationType}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatusesByType", localVarResponse);
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
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> GetOperationStatusesByTypeAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetOperationStatusesByTypeWithHttpInfoAsync(operationType, id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationType">Specifies the type of file operation to be retrieved.</param>
        /// <param name="id">The ID of the file operation. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-operation-statuses-by-type/">REST API Reference for GetOperationStatusesByType Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> GetOperationStatusesByTypeWithHttpInfoAsync(FileOperationType operationType, string? id = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("operationType", ClientUtils.ParameterToString(operationType)); // path parameter
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/{operationType}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetOperationStatusesByType", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper MarkAsRead(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = MarkAsReadWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> MarkAsReadWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/markasread", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MarkAsRead", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> MarkAsReadAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MarkAsReadWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto">The base batch request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/mark-as-read/">REST API Reference for MarkAsRead Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> MarkAsReadWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/markasread", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MarkAsRead", localVarResponse);
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
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper MoveBatchItems(BatchRequestDto? batchRequestDto = default)
        {
            var localVarResponse = MoveBatchItemsWithHttpInfo(batchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> MoveBatchItemsWithHttpInfo(BatchRequestDto? batchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveBatchItems", localVarResponse);
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
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> MoveBatchItemsAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await MoveBatchItemsWithHttpInfoAsync(batchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchRequestDto">The request parameters for copying/moving files. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/move-batch-items/">REST API Reference for MoveBatchItems Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> MoveBatchItemsWithHttpInfoAsync(BatchRequestDto? batchRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchRequestDto != null) localVarRequestOptions.Data = batchRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/move", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("MoveBatchItems", localVarResponse);
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
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ConversationResultArrayWrapper</returns>
        public ConversationResultArrayWrapper StartFileConversion(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default)
        {
            var localVarResponse = StartFileConversionWithHttpInfo(fileId, checkConversionRequestDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>ApiResponse of ConversationResultArrayWrapper</returns>
        public ApiResponse<ConversationResultArrayWrapper> StartFileConversionWithHttpInfo(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default)
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
            if (checkConversionRequestDtoInteger != null) localVarRequestOptions.Data = checkConversionRequestDtoInteger;


            // make the HTTP request
            var localVarResponse = Client.Put<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartFileConversion", localVarResponse);
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
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ConversationResultArrayWrapper</returns>
        public async Task<ConversationResultArrayWrapper> StartFileConversionAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StartFileConversionWithHttpInfoAsync(fileId, checkConversionRequestDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start conversion proccess.</param>
        /// <param name="checkConversionRequestDtoInteger">The parameters for checking file conversion. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-file-conversion/">REST API Reference for StartFileConversion Operation</seealso>
        /// <returns>Task of ApiResponse (ConversationResultArrayWrapper)</returns>
        public async Task<ApiResponse<ConversationResultArrayWrapper>> StartFileConversionWithHttpInfoAsync(int fileId, CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = default, CancellationToken cancellationToken = default)
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
            if (checkConversionRequestDtoInteger != null) localVarRequestOptions.Data = checkConversionRequestDtoInteger;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<ConversationResultArrayWrapper>("/api/2.0/files/file/{fileId}/checkconversion", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartFileConversion", localVarResponse);
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
        /// <param name="id">The operation ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper TerminateTasks(string id)
        {
            var localVarResponse = TerminateTasksWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> TerminateTasksWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperationsApi->TerminateTasks");

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
            var localVarResponse = Client.Put<FileOperationArrayWrapper>("/api/2.0/files/fileops/terminate/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateTasks", localVarResponse);
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
        /// <param name="id">The operation ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async Task<FileOperationArrayWrapper> TerminateTasksAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await TerminateTasksWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The operation ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-tasks/">REST API Reference for TerminateTasks Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async Task<ApiResponse<FileOperationArrayWrapper>> TerminateTasksWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling OperationsApi->TerminateTasks");

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

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationArrayWrapper>("/api/2.0/files/fileops/terminate/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateTasks", localVarResponse);
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
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper UpdateFileComment(int fileId, UpdateComment? updateComment = default)
        {
            var localVarResponse = UpdateFileCommentWithHttpInfo(fileId, updateComment);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> UpdateFileCommentWithHttpInfo(int fileId, UpdateComment? updateComment = default)
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
            if (updateComment != null) localVarRequestOptions.Data = updateComment;


            // make the HTTP request
            var localVarResponse = Client.Put<StringWrapper>("/api/2.0/files/file/{fileId}/comment", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFileComment", localVarResponse);
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
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async Task<StringWrapper> UpdateFileCommentAsync(int fileId, UpdateComment? updateComment = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateFileCommentWithHttpInfoAsync(fileId, updateComment, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID where the comment is located.</param>
        /// <param name="updateComment">The parameters for updating a comment. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file-comment/">REST API Reference for UpdateFileComment Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async Task<ApiResponse<StringWrapper>> UpdateFileCommentWithHttpInfoAsync(int fileId, UpdateComment? updateComment = default, CancellationToken cancellationToken = default)
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
            if (updateComment != null) localVarRequestOptions.Data = updateComment;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<StringWrapper>("/api/2.0/files/file/{fileId}/comment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateFileComment", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
