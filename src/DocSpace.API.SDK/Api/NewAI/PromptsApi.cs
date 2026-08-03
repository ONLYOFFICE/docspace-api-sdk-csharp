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
namespace DocSpace.API.SDK.Api.NewAI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPromptsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>NewAiPromptMutationResult</returns>
        NewAiPromptMutationResult NewAiPromptsCreate(NewAiCreatePromptInput newAiCreatePromptInput);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptMutationResult</returns>
        ApiResponse<NewAiPromptMutationResult> NewAiPromptsCreateWithHttpInfo(NewAiCreatePromptInput newAiCreatePromptInput);
        /// <summary>
        /// Create folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>NewAiFolderMutationResult</returns>
        NewAiFolderMutationResult NewAiPromptsCreateFolder(string body);

        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderMutationResult</returns>
        ApiResponse<NewAiFolderMutationResult> NewAiPromptsCreateFolderWithHttpInfo(string body);
        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiPromptsDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiPromptsDeleteWithHttpInfo(string body);
        /// <summary>
        /// Delete folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiPromptsDeleteFolder(string body);

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiPromptsDeleteFolderWithHttpInfo(string body);
        /// <summary>
        /// Export
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>NewAiPromptBundle</returns>
        NewAiPromptBundle NewAiPromptsExport();

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptBundle</returns>
        ApiResponse<NewAiPromptBundle> NewAiPromptsExportWithHttpInfo();
        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>NewAiPrompt</returns>
        NewAiPrompt NewAiPromptsGetById(string id);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>ApiResponse of NewAiPrompt</returns>
        ApiResponse<NewAiPrompt> NewAiPromptsGetByIdWithHttpInfo(string id);
        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>NewAiPromptFolder</returns>
        NewAiPromptFolder NewAiPromptsGetFolderById(string id);

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptFolder</returns>
        ApiResponse<NewAiPromptFolder> NewAiPromptsGetFolderByIdWithHttpInfo(string id);
        /// <summary>
        /// Import bundle
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>NewAiImportResult</returns>
        NewAiImportResult NewAiPromptsImportBundle(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest);

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>ApiResponse of NewAiImportResult</returns>
        ApiResponse<NewAiImportResult> NewAiPromptsImportBundleWithHttpInfo(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest);
        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>List&lt;NewAiPrompt&gt;</returns>
        List<NewAiPrompt> NewAiPromptsList(string folderId);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiPrompt&gt;</returns>
        ApiResponse<List<NewAiPrompt>> NewAiPromptsListWithHttpInfo(string folderId);
        /// <summary>
        /// List folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>List&lt;NewAiPromptFolder&gt;</returns>
        List<NewAiPromptFolder> NewAiPromptsListFolders();

        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiPromptFolder&gt;</returns>
        ApiResponse<List<NewAiPromptFolder>> NewAiPromptsListFoldersWithHttpInfo();
        /// <summary>
        /// Move
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>NewAiPromptMutationResult</returns>
        NewAiPromptMutationResult NewAiPromptsMove(NewAiPromptsMoveRequest newAiPromptsMoveRequest);

        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptMutationResult</returns>
        ApiResponse<NewAiPromptMutationResult> NewAiPromptsMoveWithHttpInfo(NewAiPromptsMoveRequest newAiPromptsMoveRequest);
        /// <summary>
        /// Rename folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>NewAiFolderMutationResult</returns>
        NewAiFolderMutationResult NewAiPromptsRenameFolder(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest);

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderMutationResult</returns>
        ApiResponse<NewAiFolderMutationResult> NewAiPromptsRenameFolderWithHttpInfo(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest);
        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>NewAiPromptMutationResult</returns>
        NewAiPromptMutationResult NewAiPromptsUpdate(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptMutationResult</returns>
        ApiResponse<NewAiPromptMutationResult> NewAiPromptsUpdateWithHttpInfo(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPromptsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>Task of NewAiPromptMutationResult</returns>
        Task<NewAiPromptMutationResult> NewAiPromptsCreateAsync(NewAiCreatePromptInput newAiCreatePromptInput, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptMutationResult)</returns>
        Task<ApiResponse<NewAiPromptMutationResult>> NewAiPromptsCreateWithHttpInfoAsync(NewAiCreatePromptInput newAiCreatePromptInput, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of NewAiFolderMutationResult</returns>
        Task<NewAiFolderMutationResult> NewAiPromptsCreateFolderAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderMutationResult)</returns>
        Task<ApiResponse<NewAiFolderMutationResult>> NewAiPromptsCreateFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiPromptsDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiPromptsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiPromptsDeleteFolderAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiPromptsDeleteFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>Task of NewAiPromptBundle</returns>
        Task<NewAiPromptBundle> NewAiPromptsExportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptBundle)</returns>
        Task<ApiResponse<NewAiPromptBundle>> NewAiPromptsExportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>Task of NewAiPrompt</returns>
        Task<NewAiPrompt> NewAiPromptsGetByIdAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPrompt)</returns>
        Task<ApiResponse<NewAiPrompt>> NewAiPromptsGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of NewAiPromptFolder</returns>
        Task<NewAiPromptFolder> NewAiPromptsGetFolderByIdAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptFolder)</returns>
        Task<ApiResponse<NewAiPromptFolder>> NewAiPromptsGetFolderByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>Task of NewAiImportResult</returns>
        Task<NewAiImportResult> NewAiPromptsImportBundleAsync(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiImportResult)</returns>
        Task<ApiResponse<NewAiImportResult>> NewAiPromptsImportBundleWithHttpInfoAsync(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>Task of List&lt;NewAiPrompt&gt;</returns>
        Task<List<NewAiPrompt>> NewAiPromptsListAsync(string folderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiPrompt&gt;)</returns>
        Task<ApiResponse<List<NewAiPrompt>>> NewAiPromptsListWithHttpInfoAsync(string folderId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>Task of List&lt;NewAiPromptFolder&gt;</returns>
        Task<List<NewAiPromptFolder>> NewAiPromptsListFoldersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiPromptFolder&gt;)</returns>
        Task<ApiResponse<List<NewAiPromptFolder>>> NewAiPromptsListFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>Task of NewAiPromptMutationResult</returns>
        Task<NewAiPromptMutationResult> NewAiPromptsMoveAsync(NewAiPromptsMoveRequest newAiPromptsMoveRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptMutationResult)</returns>
        Task<ApiResponse<NewAiPromptMutationResult>> NewAiPromptsMoveWithHttpInfoAsync(NewAiPromptsMoveRequest newAiPromptsMoveRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of NewAiFolderMutationResult</returns>
        Task<NewAiFolderMutationResult> NewAiPromptsRenameFolderAsync(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderMutationResult)</returns>
        Task<ApiResponse<NewAiFolderMutationResult>> NewAiPromptsRenameFolderWithHttpInfoAsync(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>Task of NewAiPromptMutationResult</returns>
        Task<NewAiPromptMutationResult> NewAiPromptsUpdateAsync(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptMutationResult)</returns>
        Task<ApiResponse<NewAiPromptMutationResult>> NewAiPromptsUpdateWithHttpInfoAsync(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPromptsApi : IPromptsApiSync, IPromptsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PromptsApi : IDisposable, IPromptsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public PromptsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public PromptsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="PromptsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public PromptsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="PromptsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public PromptsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptsApi"/> class.
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
        public PromptsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PromptsApi"/> class using a Configuration object.
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
        public PromptsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="PromptsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public PromptsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>NewAiPromptMutationResult</returns>
        public NewAiPromptMutationResult NewAiPromptsCreate(NewAiCreatePromptInput newAiCreatePromptInput)
        {
            var localVarResponse = NewAiPromptsCreateWithHttpInfo(newAiCreatePromptInput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptMutationResult</returns>
        public ApiResponse<NewAiPromptMutationResult> NewAiPromptsCreateWithHttpInfo(NewAiCreatePromptInput newAiCreatePromptInput)
        {
            // verify the required parameter 'newAiCreatePromptInput' is set
            if (newAiCreatePromptInput == null)
                throw new ApiException(400, "Missing required parameter 'newAiCreatePromptInput' when calling PromptsApi->NewAiPromptsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiCreatePromptInput != null) localVarRequestOptions.Data = newAiCreatePromptInput;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiPromptMutationResult>("/api/2.0/ai/prompts/create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsCreate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>Task of NewAiPromptMutationResult</returns>
        public async Task<NewAiPromptMutationResult> NewAiPromptsCreateAsync(NewAiCreatePromptInput newAiCreatePromptInput, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsCreateWithHttpInfoAsync(newAiCreatePromptInput, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create/">REST API Reference for NewAiPromptsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptMutationResult)</returns>
        public async Task<ApiResponse<NewAiPromptMutationResult>> NewAiPromptsCreateWithHttpInfoAsync(NewAiCreatePromptInput newAiCreatePromptInput, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiCreatePromptInput' is set
            if (newAiCreatePromptInput == null)
                throw new ApiException(400, "Missing required parameter 'newAiCreatePromptInput' when calling PromptsApi->NewAiPromptsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiCreatePromptInput != null) localVarRequestOptions.Data = newAiCreatePromptInput;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiPromptMutationResult>("/api/2.0/ai/prompts/create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsCreate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>NewAiFolderMutationResult</returns>
        public NewAiFolderMutationResult NewAiPromptsCreateFolder(string body)
        {
            var localVarResponse = NewAiPromptsCreateFolderWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderMutationResult</returns>
        public ApiResponse<NewAiFolderMutationResult> NewAiPromptsCreateFolderWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->NewAiPromptsCreateFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (body != null) localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiFolderMutationResult>("/api/2.0/ai/prompts/create-folder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsCreateFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of NewAiFolderMutationResult</returns>
        public async Task<NewAiFolderMutationResult> NewAiPromptsCreateFolderAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsCreateFolderWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-create-folder/">REST API Reference for NewAiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderMutationResult)</returns>
        public async Task<ApiResponse<NewAiFolderMutationResult>> NewAiPromptsCreateFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->NewAiPromptsCreateFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (body != null) localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiFolderMutationResult>("/api/2.0/ai/prompts/create-folder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsCreateFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiPromptsDelete(string body)
        {
            var localVarResponse = NewAiPromptsDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiPromptsDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->NewAiPromptsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (body != null) localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/prompts/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsDelete", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiPromptsDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete/">REST API Reference for NewAiPromptsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiPromptsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->NewAiPromptsDelete");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (body != null) localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/prompts/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiPromptsDeleteFolder(string body)
        {
            var localVarResponse = NewAiPromptsDeleteFolderWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiPromptsDeleteFolderWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->NewAiPromptsDeleteFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (body != null) localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/prompts/delete-folder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsDeleteFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiPromptsDeleteFolderAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsDeleteFolderWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-delete-folder/">REST API Reference for NewAiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiPromptsDeleteFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->NewAiPromptsDeleteFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (body != null) localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/prompts/delete-folder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsDeleteFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>NewAiPromptBundle</returns>
        public NewAiPromptBundle NewAiPromptsExport()
        {
            var localVarResponse = NewAiPromptsExportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptBundle</returns>
        public ApiResponse<NewAiPromptBundle> NewAiPromptsExportWithHttpInfo()
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
            var localVarResponse = Client.Get<NewAiPromptBundle>("/api/2.0/ai/prompts/export", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsExport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>Task of NewAiPromptBundle</returns>
        public async Task<NewAiPromptBundle> NewAiPromptsExportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsExportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-export/">REST API Reference for NewAiPromptsExport Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptBundle)</returns>
        public async Task<ApiResponse<NewAiPromptBundle>> NewAiPromptsExportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiPromptBundle>("/api/2.0/ai/prompts/export", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsExport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>NewAiPrompt</returns>
        public NewAiPrompt NewAiPromptsGetById(string id)
        {
            var localVarResponse = NewAiPromptsGetByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>ApiResponse of NewAiPrompt</returns>
        public ApiResponse<NewAiPrompt> NewAiPromptsGetByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->NewAiPromptsGetById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiPrompt>("/api/2.0/ai/prompts/get-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsGetById", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>Task of NewAiPrompt</returns>
        public async Task<NewAiPrompt> NewAiPromptsGetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsGetByIdWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-by-id/">REST API Reference for NewAiPromptsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPrompt)</returns>
        public async Task<ApiResponse<NewAiPrompt>> NewAiPromptsGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->NewAiPromptsGetById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiPrompt>("/api/2.0/ai/prompts/get-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsGetById", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>NewAiPromptFolder</returns>
        public NewAiPromptFolder NewAiPromptsGetFolderById(string id)
        {
            var localVarResponse = NewAiPromptsGetFolderByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptFolder</returns>
        public ApiResponse<NewAiPromptFolder> NewAiPromptsGetFolderByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->NewAiPromptsGetFolderById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiPromptFolder>("/api/2.0/ai/prompts/get-folder-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsGetFolderById", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of NewAiPromptFolder</returns>
        public async Task<NewAiPromptFolder> NewAiPromptsGetFolderByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsGetFolderByIdWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-get-folder-by-id/">REST API Reference for NewAiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptFolder)</returns>
        public async Task<ApiResponse<NewAiPromptFolder>> NewAiPromptsGetFolderByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->NewAiPromptsGetFolderById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "id", id));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiPromptFolder>("/api/2.0/ai/prompts/get-folder-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsGetFolderById", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>NewAiImportResult</returns>
        public NewAiImportResult NewAiPromptsImportBundle(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest)
        {
            var localVarResponse = NewAiPromptsImportBundleWithHttpInfo(newAiPromptsImportBundleRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>ApiResponse of NewAiImportResult</returns>
        public ApiResponse<NewAiImportResult> NewAiPromptsImportBundleWithHttpInfo(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest)
        {
            // verify the required parameter 'newAiPromptsImportBundleRequest' is set
            if (newAiPromptsImportBundleRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsImportBundleRequest' when calling PromptsApi->NewAiPromptsImportBundle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsImportBundleRequest != null) localVarRequestOptions.Data = newAiPromptsImportBundleRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiImportResult>("/api/2.0/ai/prompts/import-bundle", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsImportBundle", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>Task of NewAiImportResult</returns>
        public async Task<NewAiImportResult> NewAiPromptsImportBundleAsync(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsImportBundleWithHttpInfoAsync(newAiPromptsImportBundleRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-import-bundle/">REST API Reference for NewAiPromptsImportBundle Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiImportResult)</returns>
        public async Task<ApiResponse<NewAiImportResult>> NewAiPromptsImportBundleWithHttpInfoAsync(NewAiPromptsImportBundleRequest newAiPromptsImportBundleRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiPromptsImportBundleRequest' is set
            if (newAiPromptsImportBundleRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsImportBundleRequest' when calling PromptsApi->NewAiPromptsImportBundle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsImportBundleRequest != null) localVarRequestOptions.Data = newAiPromptsImportBundleRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiImportResult>("/api/2.0/ai/prompts/import-bundle", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsImportBundle", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>List&lt;NewAiPrompt&gt;</returns>
        public List<NewAiPrompt> NewAiPromptsList(string folderId)
        {
            var localVarResponse = NewAiPromptsListWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiPrompt&gt;</returns>
        public ApiResponse<List<NewAiPrompt>> NewAiPromptsListWithHttpInfo(string folderId)
        {
            // verify the required parameter 'folderId' is set
            if (folderId == null)
                throw new ApiException(400, "Missing required parameter 'folderId' when calling PromptsApi->NewAiPromptsList");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "folderId", folderId));


            // make the HTTP request
            var localVarResponse = Client.Get<List<NewAiPrompt>>("/api/2.0/ai/prompts/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsList", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>Task of List&lt;NewAiPrompt&gt;</returns>
        public async Task<List<NewAiPrompt>> NewAiPromptsListAsync(string folderId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsListWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list/">REST API Reference for NewAiPromptsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiPrompt&gt;)</returns>
        public async Task<ApiResponse<List<NewAiPrompt>>> NewAiPromptsListWithHttpInfoAsync(string folderId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'folderId' is set
            if (folderId == null)
                throw new ApiException(400, "Missing required parameter 'folderId' when calling PromptsApi->NewAiPromptsList");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "folderId", folderId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<NewAiPrompt>>("/api/2.0/ai/prompts/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsList", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>List&lt;NewAiPromptFolder&gt;</returns>
        public List<NewAiPromptFolder> NewAiPromptsListFolders()
        {
            var localVarResponse = NewAiPromptsListFoldersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiPromptFolder&gt;</returns>
        public ApiResponse<List<NewAiPromptFolder>> NewAiPromptsListFoldersWithHttpInfo()
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
            var localVarResponse = Client.Get<List<NewAiPromptFolder>>("/api/2.0/ai/prompts/list-folders", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsListFolders", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>Task of List&lt;NewAiPromptFolder&gt;</returns>
        public async Task<List<NewAiPromptFolder>> NewAiPromptsListFoldersAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsListFoldersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List folders
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-list-folders/">REST API Reference for NewAiPromptsListFolders Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiPromptFolder&gt;)</returns>
        public async Task<ApiResponse<List<NewAiPromptFolder>>> NewAiPromptsListFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<List<NewAiPromptFolder>>("/api/2.0/ai/prompts/list-folders", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsListFolders", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>NewAiPromptMutationResult</returns>
        public NewAiPromptMutationResult NewAiPromptsMove(NewAiPromptsMoveRequest newAiPromptsMoveRequest)
        {
            var localVarResponse = NewAiPromptsMoveWithHttpInfo(newAiPromptsMoveRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptMutationResult</returns>
        public ApiResponse<NewAiPromptMutationResult> NewAiPromptsMoveWithHttpInfo(NewAiPromptsMoveRequest newAiPromptsMoveRequest)
        {
            // verify the required parameter 'newAiPromptsMoveRequest' is set
            if (newAiPromptsMoveRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsMoveRequest' when calling PromptsApi->NewAiPromptsMove");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsMoveRequest != null) localVarRequestOptions.Data = newAiPromptsMoveRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiPromptMutationResult>("/api/2.0/ai/prompts/move", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsMove", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Move
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>Task of NewAiPromptMutationResult</returns>
        public async Task<NewAiPromptMutationResult> NewAiPromptsMoveAsync(NewAiPromptsMoveRequest newAiPromptsMoveRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsMoveWithHttpInfoAsync(newAiPromptsMoveRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-move/">REST API Reference for NewAiPromptsMove Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptMutationResult)</returns>
        public async Task<ApiResponse<NewAiPromptMutationResult>> NewAiPromptsMoveWithHttpInfoAsync(NewAiPromptsMoveRequest newAiPromptsMoveRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiPromptsMoveRequest' is set
            if (newAiPromptsMoveRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsMoveRequest' when calling PromptsApi->NewAiPromptsMove");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsMoveRequest != null) localVarRequestOptions.Data = newAiPromptsMoveRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiPromptMutationResult>("/api/2.0/ai/prompts/move", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsMove", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>NewAiFolderMutationResult</returns>
        public NewAiFolderMutationResult NewAiPromptsRenameFolder(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest)
        {
            var localVarResponse = NewAiPromptsRenameFolderWithHttpInfo(newAiPromptsRenameFolderRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>ApiResponse of NewAiFolderMutationResult</returns>
        public ApiResponse<NewAiFolderMutationResult> NewAiPromptsRenameFolderWithHttpInfo(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest)
        {
            // verify the required parameter 'newAiPromptsRenameFolderRequest' is set
            if (newAiPromptsRenameFolderRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsRenameFolderRequest' when calling PromptsApi->NewAiPromptsRenameFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsRenameFolderRequest != null) localVarRequestOptions.Data = newAiPromptsRenameFolderRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiFolderMutationResult>("/api/2.0/ai/prompts/rename-folder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsRenameFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of NewAiFolderMutationResult</returns>
        public async Task<NewAiFolderMutationResult> NewAiPromptsRenameFolderAsync(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsRenameFolderWithHttpInfoAsync(newAiPromptsRenameFolderRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-rename-folder/">REST API Reference for NewAiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiFolderMutationResult)</returns>
        public async Task<ApiResponse<NewAiFolderMutationResult>> NewAiPromptsRenameFolderWithHttpInfoAsync(NewAiPromptsRenameFolderRequest newAiPromptsRenameFolderRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiPromptsRenameFolderRequest' is set
            if (newAiPromptsRenameFolderRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsRenameFolderRequest' when calling PromptsApi->NewAiPromptsRenameFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsRenameFolderRequest != null) localVarRequestOptions.Data = newAiPromptsRenameFolderRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiFolderMutationResult>("/api/2.0/ai/prompts/rename-folder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsRenameFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>NewAiPromptMutationResult</returns>
        public NewAiPromptMutationResult NewAiPromptsUpdate(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest)
        {
            var localVarResponse = NewAiPromptsUpdateWithHttpInfo(newAiPromptsUpdateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>ApiResponse of NewAiPromptMutationResult</returns>
        public ApiResponse<NewAiPromptMutationResult> NewAiPromptsUpdateWithHttpInfo(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest)
        {
            // verify the required parameter 'newAiPromptsUpdateRequest' is set
            if (newAiPromptsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsUpdateRequest' when calling PromptsApi->NewAiPromptsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsUpdateRequest != null) localVarRequestOptions.Data = newAiPromptsUpdateRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiPromptMutationResult>("/api/2.0/ai/prompts/update", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsUpdate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>Task of NewAiPromptMutationResult</returns>
        public async Task<NewAiPromptMutationResult> NewAiPromptsUpdateAsync(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiPromptsUpdateWithHttpInfoAsync(newAiPromptsUpdateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-prompts-update/">REST API Reference for NewAiPromptsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiPromptMutationResult)</returns>
        public async Task<ApiResponse<NewAiPromptMutationResult>> NewAiPromptsUpdateWithHttpInfoAsync(NewAiPromptsUpdateRequest newAiPromptsUpdateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiPromptsUpdateRequest' is set
            if (newAiPromptsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiPromptsUpdateRequest' when calling PromptsApi->NewAiPromptsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiPromptsUpdateRequest != null) localVarRequestOptions.Data = newAiPromptsUpdateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiPromptMutationResult>("/api/2.0/ai/prompts/update", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiPromptsUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
