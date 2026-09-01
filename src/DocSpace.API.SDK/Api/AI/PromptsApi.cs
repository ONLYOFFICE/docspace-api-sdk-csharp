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
namespace DocSpace.API.SDK.Api.AI
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
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>AiPromptMutationResult</returns>
        AiPromptMutationResult AiPromptsCreate(AiCreatePromptInput aiCreatePromptInput);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>ApiResponse of AiPromptMutationResult</returns>
        ApiResponse<AiPromptMutationResult> AiPromptsCreateWithHttpInfo(AiCreatePromptInput aiCreatePromptInput);
        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>AiFolderMutationResult</returns>
        AiFolderMutationResult AiPromptsCreateFolder(string body);

        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>ApiResponse of AiFolderMutationResult</returns>
        ApiResponse<AiFolderMutationResult> AiPromptsCreateFolderWithHttpInfo(string body);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiPromptsDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiPromptsDeleteWithHttpInfo(string body);
        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiPromptsDeleteFolder(string body);

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiPromptsDeleteFolderWithHttpInfo(string body);
        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>AiPromptBundle</returns>
        AiPromptBundle AiPromptsExport();

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>ApiResponse of AiPromptBundle</returns>
        ApiResponse<AiPromptBundle> AiPromptsExportWithHttpInfo();
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>AiPrompt</returns>
        AiPrompt AiPromptsGetById(string id);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>ApiResponse of AiPrompt</returns>
        ApiResponse<AiPrompt> AiPromptsGetByIdWithHttpInfo(string id);
        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>AiPromptFolder</returns>
        AiPromptFolder AiPromptsGetFolderById(string id);

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>ApiResponse of AiPromptFolder</returns>
        ApiResponse<AiPromptFolder> AiPromptsGetFolderByIdWithHttpInfo(string id);
        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>AiImportResult</returns>
        AiImportResult AiPromptsImportBundle(AiPromptsImportBundleRequest aiPromptsImportBundleRequest);

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>ApiResponse of AiImportResult</returns>
        ApiResponse<AiImportResult> AiPromptsImportBundleWithHttpInfo(AiPromptsImportBundleRequest aiPromptsImportBundleRequest);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>List&lt;AiPrompt&gt;</returns>
        List<AiPrompt> AiPromptsList(string? folderId = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiPrompt&gt;</returns>
        ApiResponse<List<AiPrompt>> AiPromptsListWithHttpInfo(string? folderId = default);
        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>List&lt;AiPromptFolder&gt;</returns>
        List<AiPromptFolder> AiPromptsListFolders();

        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiPromptFolder&gt;</returns>
        ApiResponse<List<AiPromptFolder>> AiPromptsListFoldersWithHttpInfo();
        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>AiPromptMutationResult</returns>
        AiPromptMutationResult AiPromptsMove(AiPromptsMoveRequest aiPromptsMoveRequest);

        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>ApiResponse of AiPromptMutationResult</returns>
        ApiResponse<AiPromptMutationResult> AiPromptsMoveWithHttpInfo(AiPromptsMoveRequest aiPromptsMoveRequest);
        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>AiFolderMutationResult</returns>
        AiFolderMutationResult AiPromptsRenameFolder(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest);

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>ApiResponse of AiFolderMutationResult</returns>
        ApiResponse<AiFolderMutationResult> AiPromptsRenameFolderWithHttpInfo(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>AiPromptMutationResult</returns>
        AiPromptMutationResult AiPromptsUpdate(AiPromptsUpdateRequest aiPromptsUpdateRequest);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>ApiResponse of AiPromptMutationResult</returns>
        ApiResponse<AiPromptMutationResult> AiPromptsUpdateWithHttpInfo(AiPromptsUpdateRequest aiPromptsUpdateRequest);
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
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>Task of AiPromptMutationResult</returns>
        Task<AiPromptMutationResult> AiPromptsCreateAsync(AiCreatePromptInput aiCreatePromptInput, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptMutationResult)</returns>
        Task<ApiResponse<AiPromptMutationResult>> AiPromptsCreateWithHttpInfoAsync(AiCreatePromptInput aiCreatePromptInput, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of AiFolderMutationResult</returns>
        Task<AiFolderMutationResult> AiPromptsCreateFolderAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderMutationResult)</returns>
        Task<ApiResponse<AiFolderMutationResult>> AiPromptsCreateFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiPromptsDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiPromptsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiPromptsDeleteFolderAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiPromptsDeleteFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>Task of AiPromptBundle</returns>
        Task<AiPromptBundle> AiPromptsExportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptBundle)</returns>
        Task<ApiResponse<AiPromptBundle>> AiPromptsExportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>Task of AiPrompt</returns>
        Task<AiPrompt> AiPromptsGetByIdAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (AiPrompt)</returns>
        Task<ApiResponse<AiPrompt>> AiPromptsGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of AiPromptFolder</returns>
        Task<AiPromptFolder> AiPromptsGetFolderByIdAsync(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptFolder)</returns>
        Task<ApiResponse<AiPromptFolder>> AiPromptsGetFolderByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default);
        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>Task of AiImportResult</returns>
        Task<AiImportResult> AiPromptsImportBundleAsync(AiPromptsImportBundleRequest aiPromptsImportBundleRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>Task of ApiResponse (AiImportResult)</returns>
        Task<ApiResponse<AiImportResult>> AiPromptsImportBundleWithHttpInfoAsync(AiPromptsImportBundleRequest aiPromptsImportBundleRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>Task of List&lt;AiPrompt&gt;</returns>
        Task<List<AiPrompt>> AiPromptsListAsync(string? folderId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiPrompt&gt;)</returns>
        Task<ApiResponse<List<AiPrompt>>> AiPromptsListWithHttpInfoAsync(string? folderId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>Task of List&lt;AiPromptFolder&gt;</returns>
        Task<List<AiPromptFolder>> AiPromptsListFoldersAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiPromptFolder&gt;)</returns>
        Task<ApiResponse<List<AiPromptFolder>>> AiPromptsListFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>Task of AiPromptMutationResult</returns>
        Task<AiPromptMutationResult> AiPromptsMoveAsync(AiPromptsMoveRequest aiPromptsMoveRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptMutationResult)</returns>
        Task<ApiResponse<AiPromptMutationResult>> AiPromptsMoveWithHttpInfoAsync(AiPromptsMoveRequest aiPromptsMoveRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of AiFolderMutationResult</returns>
        Task<AiFolderMutationResult> AiPromptsRenameFolderAsync(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderMutationResult)</returns>
        Task<ApiResponse<AiFolderMutationResult>> AiPromptsRenameFolderWithHttpInfoAsync(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>Task of AiPromptMutationResult</returns>
        Task<AiPromptMutationResult> AiPromptsUpdateAsync(AiPromptsUpdateRequest aiPromptsUpdateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptMutationResult)</returns>
        Task<ApiResponse<AiPromptMutationResult>> AiPromptsUpdateWithHttpInfoAsync(AiPromptsUpdateRequest aiPromptsUpdateRequest, CancellationToken cancellationToken = default);
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
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>AiPromptMutationResult</returns>
        public AiPromptMutationResult AiPromptsCreate(AiCreatePromptInput aiCreatePromptInput)
        {
            var localVarResponse = AiPromptsCreateWithHttpInfo(aiCreatePromptInput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>ApiResponse of AiPromptMutationResult</returns>
        public ApiResponse<AiPromptMutationResult> AiPromptsCreateWithHttpInfo(AiCreatePromptInput aiCreatePromptInput)
        {
            // verify the required parameter 'aiCreatePromptInput' is set
            if (aiCreatePromptInput == null)
                throw new ApiException(400, "Missing required parameter 'aiCreatePromptInput' when calling PromptsApi->AiPromptsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiCreatePromptInput != null) localVarRequestOptions.Data = aiCreatePromptInput;


            // make the HTTP request
            var localVarResponse = Client.Post<AiPromptMutationResult>("/api/2.0/ai/prompts/create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsCreate", localVarResponse);
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
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>Task of AiPromptMutationResult</returns>
        public async Task<AiPromptMutationResult> AiPromptsCreateAsync(AiCreatePromptInput aiCreatePromptInput, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsCreateWithHttpInfoAsync(aiCreatePromptInput, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Saves a new prompt. The name must be non-empty and unique inside its folder, and `folderId` must point at an existing folder - omit it for the root.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiCreatePromptInput">Input for creating a prompt — the engine generates `id`/`createdAt`/`updatedAt`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create/">REST API Reference for AiPromptsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptMutationResult)</returns>
        public async Task<ApiResponse<AiPromptMutationResult>> AiPromptsCreateWithHttpInfoAsync(AiCreatePromptInput aiCreatePromptInput, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiCreatePromptInput' is set
            if (aiCreatePromptInput == null)
                throw new ApiException(400, "Missing required parameter 'aiCreatePromptInput' when calling PromptsApi->AiPromptsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiCreatePromptInput != null) localVarRequestOptions.Data = aiCreatePromptInput;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiPromptMutationResult>("/api/2.0/ai/prompts/create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsCreate", localVarResponse);
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
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>AiFolderMutationResult</returns>
        public AiFolderMutationResult AiPromptsCreateFolder(string body)
        {
            var localVarResponse = AiPromptsCreateFolderWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>ApiResponse of AiFolderMutationResult</returns>
        public ApiResponse<AiFolderMutationResult> AiPromptsCreateFolderWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->AiPromptsCreateFolder");

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
            var localVarResponse = Client.Post<AiFolderMutationResult>("/api/2.0/ai/prompts/create-folder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsCreateFolder", localVarResponse);
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
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of AiFolderMutationResult</returns>
        public async Task<AiFolderMutationResult> AiPromptsCreateFolderAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsCreateFolderWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create folder
        /// </summary>
        /// <remarks>
        /// Creates a prompt folder. The name must be non-empty and unique across the portal - prompt folders do not nest.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-create-folder/">REST API Reference for AiPromptsCreateFolder Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderMutationResult)</returns>
        public async Task<ApiResponse<AiFolderMutationResult>> AiPromptsCreateFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->AiPromptsCreateFolder");

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

            var localVarResponse = await AsynchronousClient.PostAsync<AiFolderMutationResult>("/api/2.0/ai/prompts/create-folder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsCreateFolder", localVarResponse);
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
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiPromptsDelete(string body)
        {
            var localVarResponse = AiPromptsDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiPromptsDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->AiPromptsDelete");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/prompts/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsDelete", localVarResponse);
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
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiPromptsDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a saved prompt. Does nothing when it no longer exists.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete/">REST API Reference for AiPromptsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiPromptsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->AiPromptsDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/prompts/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsDelete", localVarResponse);
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
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiPromptsDeleteFolder(string body)
        {
            var localVarResponse = AiPromptsDeleteFolderWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiPromptsDeleteFolderWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->AiPromptsDeleteFolder");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/prompts/delete-folder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsDeleteFolder", localVarResponse);
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
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiPromptsDeleteFolderAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsDeleteFolderWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete folder
        /// </summary>
        /// <remarks>
        /// Deletes a prompt folder together with the prompts inside it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-delete-folder/">REST API Reference for AiPromptsDeleteFolder Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiPromptsDeleteFolderWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PromptsApi->AiPromptsDeleteFolder");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/prompts/delete-folder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsDeleteFolder", localVarResponse);
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
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>AiPromptBundle</returns>
        public AiPromptBundle AiPromptsExport()
        {
            var localVarResponse = AiPromptsExportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>ApiResponse of AiPromptBundle</returns>
        public ApiResponse<AiPromptBundle> AiPromptsExportWithHttpInfo()
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
            var localVarResponse = Client.Get<AiPromptBundle>("/api/2.0/ai/prompts/export", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsExport", localVarResponse);
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
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>Task of AiPromptBundle</returns>
        public async Task<AiPromptBundle> AiPromptsExportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsExportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <remarks>
        /// Builds a self-contained, versioned bundle of every saved prompt and folder, ready for `import-bundle`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-export/">REST API Reference for AiPromptsExport Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptBundle)</returns>
        public async Task<ApiResponse<AiPromptBundle>> AiPromptsExportWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiPromptBundle>("/api/2.0/ai/prompts/export", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsExport", localVarResponse);
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
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>AiPrompt</returns>
        public AiPrompt AiPromptsGetById(string id)
        {
            var localVarResponse = AiPromptsGetByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>ApiResponse of AiPrompt</returns>
        public ApiResponse<AiPrompt> AiPromptsGetByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->AiPromptsGetById");

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
            var localVarResponse = Client.Get<AiPrompt>("/api/2.0/ai/prompts/get-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsGetById", localVarResponse);
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
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>Task of AiPrompt</returns>
        public async Task<AiPrompt> AiPromptsGetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsGetByIdWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one saved prompt, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The saved prompt identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-by-id/">REST API Reference for AiPromptsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (AiPrompt)</returns>
        public async Task<ApiResponse<AiPrompt>> AiPromptsGetByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->AiPromptsGetById");

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiPrompt>("/api/2.0/ai/prompts/get-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsGetById", localVarResponse);
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
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>AiPromptFolder</returns>
        public AiPromptFolder AiPromptsGetFolderById(string id)
        {
            var localVarResponse = AiPromptsGetFolderByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>ApiResponse of AiPromptFolder</returns>
        public ApiResponse<AiPromptFolder> AiPromptsGetFolderByIdWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->AiPromptsGetFolderById");

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
            var localVarResponse = Client.Get<AiPromptFolder>("/api/2.0/ai/prompts/get-folder-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsGetFolderById", localVarResponse);
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
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of AiPromptFolder</returns>
        public async Task<AiPromptFolder> AiPromptsGetFolderByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsGetFolderByIdWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get folder by id
        /// </summary>
        /// <remarks>
        /// Returns one prompt folder, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The prompt folder identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-get-folder-by-id/">REST API Reference for AiPromptsGetFolderById Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptFolder)</returns>
        public async Task<ApiResponse<AiPromptFolder>> AiPromptsGetFolderByIdWithHttpInfoAsync(string id, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PromptsApi->AiPromptsGetFolderById");

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiPromptFolder>("/api/2.0/ai/prompts/get-folder-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsGetFolderById", localVarResponse);
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
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>AiImportResult</returns>
        public AiImportResult AiPromptsImportBundle(AiPromptsImportBundleRequest aiPromptsImportBundleRequest)
        {
            var localVarResponse = AiPromptsImportBundleWithHttpInfo(aiPromptsImportBundleRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>ApiResponse of AiImportResult</returns>
        public ApiResponse<AiImportResult> AiPromptsImportBundleWithHttpInfo(AiPromptsImportBundleRequest aiPromptsImportBundleRequest)
        {
            // verify the required parameter 'aiPromptsImportBundleRequest' is set
            if (aiPromptsImportBundleRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsImportBundleRequest' when calling PromptsApi->AiPromptsImportBundle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsImportBundleRequest != null) localVarRequestOptions.Data = aiPromptsImportBundleRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiImportResult>("/api/2.0/ai/prompts/import-bundle", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsImportBundle", localVarResponse);
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
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>Task of AiImportResult</returns>
        public async Task<AiImportResult> AiPromptsImportBundleAsync(AiPromptsImportBundleRequest aiPromptsImportBundleRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsImportBundleWithHttpInfoAsync(aiPromptsImportBundleRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Import bundle
        /// </summary>
        /// <remarks>
        /// Restores a prompt bundle. `replace` wipes the current prompts and folders before writing the bundle, `merge` writes the bundle on top of what is already there; both validate the folder references inside the bundle before any write, so a corrupt bundle is rejected whole.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsImportBundleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-import-bundle/">REST API Reference for AiPromptsImportBundle Operation</seealso>
        /// <returns>Task of ApiResponse (AiImportResult)</returns>
        public async Task<ApiResponse<AiImportResult>> AiPromptsImportBundleWithHttpInfoAsync(AiPromptsImportBundleRequest aiPromptsImportBundleRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiPromptsImportBundleRequest' is set
            if (aiPromptsImportBundleRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsImportBundleRequest' when calling PromptsApi->AiPromptsImportBundle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsImportBundleRequest != null) localVarRequestOptions.Data = aiPromptsImportBundleRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiImportResult>("/api/2.0/ai/prompts/import-bundle", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsImportBundle", localVarResponse);
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
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>List&lt;AiPrompt&gt;</returns>
        public List<AiPrompt> AiPromptsList(string? folderId = default)
        {
            var localVarResponse = AiPromptsListWithHttpInfo(folderId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiPrompt&gt;</returns>
        public ApiResponse<List<AiPrompt>> AiPromptsListWithHttpInfo(string? folderId = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (folderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "folderId", folderId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<List<AiPrompt>>("/api/2.0/ai/prompts/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsList", localVarResponse);
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
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>Task of List&lt;AiPrompt&gt;</returns>
        public async Task<List<AiPrompt>> AiPromptsListAsync(string? folderId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsListWithHttpInfoAsync(folderId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists saved prompts. Scope the answer to one folder, ask for the root-level prompts only, or omit the folder to get every prompt newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The prompt folder identifier. Omit to list the prompts that sit outside any folder. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list/">REST API Reference for AiPromptsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiPrompt&gt;)</returns>
        public async Task<ApiResponse<List<AiPrompt>>> AiPromptsListWithHttpInfoAsync(string? folderId = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (folderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "folderId", folderId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<AiPrompt>>("/api/2.0/ai/prompts/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsList", localVarResponse);
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
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>List&lt;AiPromptFolder&gt;</returns>
        public List<AiPromptFolder> AiPromptsListFolders()
        {
            var localVarResponse = AiPromptsListFoldersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiPromptFolder&gt;</returns>
        public ApiResponse<List<AiPromptFolder>> AiPromptsListFoldersWithHttpInfo()
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
            var localVarResponse = Client.Get<List<AiPromptFolder>>("/api/2.0/ai/prompts/list-folders", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsListFolders", localVarResponse);
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
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>Task of List&lt;AiPromptFolder&gt;</returns>
        public async Task<List<AiPromptFolder>> AiPromptsListFoldersAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsListFoldersWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List folders
        /// </summary>
        /// <remarks>
        /// Lists the prompt folders, newest first.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-list-folders/">REST API Reference for AiPromptsListFolders Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiPromptFolder&gt;)</returns>
        public async Task<ApiResponse<List<AiPromptFolder>>> AiPromptsListFoldersWithHttpInfoAsync(CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<List<AiPromptFolder>>("/api/2.0/ai/prompts/list-folders", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsListFolders", localVarResponse);
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
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>AiPromptMutationResult</returns>
        public AiPromptMutationResult AiPromptsMove(AiPromptsMoveRequest aiPromptsMoveRequest)
        {
            var localVarResponse = AiPromptsMoveWithHttpInfo(aiPromptsMoveRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>ApiResponse of AiPromptMutationResult</returns>
        public ApiResponse<AiPromptMutationResult> AiPromptsMoveWithHttpInfo(AiPromptsMoveRequest aiPromptsMoveRequest)
        {
            // verify the required parameter 'aiPromptsMoveRequest' is set
            if (aiPromptsMoveRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsMoveRequest' when calling PromptsApi->AiPromptsMove");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsMoveRequest != null) localVarRequestOptions.Data = aiPromptsMoveRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiPromptMutationResult>("/api/2.0/ai/prompts/move", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsMove", localVarResponse);
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
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>Task of AiPromptMutationResult</returns>
        public async Task<AiPromptMutationResult> AiPromptsMoveAsync(AiPromptsMoveRequest aiPromptsMoveRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsMoveWithHttpInfoAsync(aiPromptsMoveRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Moves a saved prompt into another folder, or to the root. The name is re-validated in the target folder, so the move fails when a prompt of that name is already there.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsMoveRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-move/">REST API Reference for AiPromptsMove Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptMutationResult)</returns>
        public async Task<ApiResponse<AiPromptMutationResult>> AiPromptsMoveWithHttpInfoAsync(AiPromptsMoveRequest aiPromptsMoveRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiPromptsMoveRequest' is set
            if (aiPromptsMoveRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsMoveRequest' when calling PromptsApi->AiPromptsMove");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsMoveRequest != null) localVarRequestOptions.Data = aiPromptsMoveRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiPromptMutationResult>("/api/2.0/ai/prompts/move", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsMove", localVarResponse);
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
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>AiFolderMutationResult</returns>
        public AiFolderMutationResult AiPromptsRenameFolder(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest)
        {
            var localVarResponse = AiPromptsRenameFolderWithHttpInfo(aiPromptsRenameFolderRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>ApiResponse of AiFolderMutationResult</returns>
        public ApiResponse<AiFolderMutationResult> AiPromptsRenameFolderWithHttpInfo(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest)
        {
            // verify the required parameter 'aiPromptsRenameFolderRequest' is set
            if (aiPromptsRenameFolderRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsRenameFolderRequest' when calling PromptsApi->AiPromptsRenameFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsRenameFolderRequest != null) localVarRequestOptions.Data = aiPromptsRenameFolderRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiFolderMutationResult>("/api/2.0/ai/prompts/rename-folder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsRenameFolder", localVarResponse);
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
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of AiFolderMutationResult</returns>
        public async Task<AiFolderMutationResult> AiPromptsRenameFolderAsync(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsRenameFolderWithHttpInfoAsync(aiPromptsRenameFolderRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename folder
        /// </summary>
        /// <remarks>
        /// Renames a prompt folder, validating the new name against the existing folders.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsRenameFolderRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-rename-folder/">REST API Reference for AiPromptsRenameFolder Operation</seealso>
        /// <returns>Task of ApiResponse (AiFolderMutationResult)</returns>
        public async Task<ApiResponse<AiFolderMutationResult>> AiPromptsRenameFolderWithHttpInfoAsync(AiPromptsRenameFolderRequest aiPromptsRenameFolderRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiPromptsRenameFolderRequest' is set
            if (aiPromptsRenameFolderRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsRenameFolderRequest' when calling PromptsApi->AiPromptsRenameFolder");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsRenameFolderRequest != null) localVarRequestOptions.Data = aiPromptsRenameFolderRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiFolderMutationResult>("/api/2.0/ai/prompts/rename-folder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsRenameFolder", localVarResponse);
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
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>AiPromptMutationResult</returns>
        public AiPromptMutationResult AiPromptsUpdate(AiPromptsUpdateRequest aiPromptsUpdateRequest)
        {
            var localVarResponse = AiPromptsUpdateWithHttpInfo(aiPromptsUpdateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>ApiResponse of AiPromptMutationResult</returns>
        public ApiResponse<AiPromptMutationResult> AiPromptsUpdateWithHttpInfo(AiPromptsUpdateRequest aiPromptsUpdateRequest)
        {
            // verify the required parameter 'aiPromptsUpdateRequest' is set
            if (aiPromptsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsUpdateRequest' when calling PromptsApi->AiPromptsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsUpdateRequest != null) localVarRequestOptions.Data = aiPromptsUpdateRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiPromptMutationResult>("/api/2.0/ai/prompts/update", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsUpdate", localVarResponse);
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
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>Task of AiPromptMutationResult</returns>
        public async Task<AiPromptMutationResult> AiPromptsUpdateAsync(AiPromptsUpdateRequest aiPromptsUpdateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiPromptsUpdateWithHttpInfoAsync(aiPromptsUpdateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Updates a saved prompt. The name and the folder reference are re-validated whenever either of them changes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiPromptsUpdateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-prompts-update/">REST API Reference for AiPromptsUpdate Operation</seealso>
        /// <returns>Task of ApiResponse (AiPromptMutationResult)</returns>
        public async Task<ApiResponse<AiPromptMutationResult>> AiPromptsUpdateWithHttpInfoAsync(AiPromptsUpdateRequest aiPromptsUpdateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiPromptsUpdateRequest' is set
            if (aiPromptsUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiPromptsUpdateRequest' when calling PromptsApi->AiPromptsUpdate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiPromptsUpdateRequest != null) localVarRequestOptions.Data = aiPromptsUpdateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiPromptMutationResult>("/api/2.0/ai/prompts/update", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiPromptsUpdate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
