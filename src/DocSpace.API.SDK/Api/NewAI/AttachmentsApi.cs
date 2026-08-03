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
    public interface IAttachmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiAttachmentsDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiAttachmentsDeleteWithHttpInfo(string body);
        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiAttachmentsDeleteMany(List<string> requestBody);

        /// <summary>
        /// Delete many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiAttachmentsDeleteManyWithHttpInfo(List<string> requestBody);
        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>NewAiAttachment</returns>
        NewAiAttachment NewAiAttachmentsGet(string body);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>ApiResponse of NewAiAttachment</returns>
        ApiResponse<NewAiAttachment> NewAiAttachmentsGetWithHttpInfo(string body);
        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>List&lt;NewAiAttachment&gt;</returns>
        List<NewAiAttachment> NewAiAttachmentsGetMany(List<string> requestBody);

        /// <summary>
        /// Get many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiAttachment&gt;</returns>
        ApiResponse<List<NewAiAttachment>> NewAiAttachmentsGetManyWithHttpInfo(List<string> requestBody);
        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiAttachmentsLinkToMessage(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest);

        /// <summary>
        /// Link to message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiAttachmentsLinkToMessageWithHttpInfo(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest);
        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>NewAiAttachment</returns>
        NewAiAttachment NewAiAttachmentsSaveFile(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest);

        /// <summary>
        /// Save file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>ApiResponse of NewAiAttachment</returns>
        ApiResponse<NewAiAttachment> NewAiAttachmentsSaveFileWithHttpInfo(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest);
        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>List&lt;NewAiAttachment&gt;</returns>
        List<NewAiAttachment> NewAiAttachmentsSaveFilesMany(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest);

        /// <summary>
        /// Save files many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiAttachment&gt;</returns>
        ApiResponse<List<NewAiAttachment>> NewAiAttachmentsSaveFilesManyWithHttpInfo(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest);
        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>NewAiAttachment</returns>
        NewAiAttachment NewAiAttachmentsSaveImage(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest);

        /// <summary>
        /// Save image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>ApiResponse of NewAiAttachment</returns>
        ApiResponse<NewAiAttachment> NewAiAttachmentsSaveImageWithHttpInfo(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest);
        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>List&lt;NewAiAttachment&gt;</returns>
        List<NewAiAttachment> NewAiAttachmentsSaveImagesMany(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest);

        /// <summary>
        /// Save images many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiAttachment&gt;</returns>
        ApiResponse<List<NewAiAttachment>> NewAiAttachmentsSaveImagesManyWithHttpInfo(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAttachmentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiAttachmentsDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiAttachmentsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiAttachmentsDeleteManyAsync(List<string> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiAttachmentsDeleteManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>Task of NewAiAttachment</returns>
        Task<NewAiAttachment> NewAiAttachmentsGetAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAttachment)</returns>
        Task<ApiResponse<NewAiAttachment>> NewAiAttachmentsGetWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of List&lt;NewAiAttachment&gt;</returns>
        Task<List<NewAiAttachment>> NewAiAttachmentsGetManyAsync(List<string> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiAttachment&gt;)</returns>
        Task<ApiResponse<List<NewAiAttachment>>> NewAiAttachmentsGetManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Link to message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiAttachmentsLinkToMessageAsync(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Link to message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiAttachmentsLinkToMessageWithHttpInfoAsync(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of NewAiAttachment</returns>
        Task<NewAiAttachment> NewAiAttachmentsSaveFileAsync(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAttachment)</returns>
        Task<ApiResponse<NewAiAttachment>> NewAiAttachmentsSaveFileWithHttpInfoAsync(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save files many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of List&lt;NewAiAttachment&gt;</returns>
        Task<List<NewAiAttachment>> NewAiAttachmentsSaveFilesManyAsync(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save files many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiAttachment&gt;)</returns>
        Task<ApiResponse<List<NewAiAttachment>>> NewAiAttachmentsSaveFilesManyWithHttpInfoAsync(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of NewAiAttachment</returns>
        Task<NewAiAttachment> NewAiAttachmentsSaveImageAsync(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAttachment)</returns>
        Task<ApiResponse<NewAiAttachment>> NewAiAttachmentsSaveImageWithHttpInfoAsync(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save images many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of List&lt;NewAiAttachment&gt;</returns>
        Task<List<NewAiAttachment>> NewAiAttachmentsSaveImagesManyAsync(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save images many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiAttachment&gt;)</returns>
        Task<ApiResponse<List<NewAiAttachment>>> NewAiAttachmentsSaveImagesManyWithHttpInfoAsync(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAttachmentsApi : IAttachmentsApiSync, IAttachmentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachmentsApi : IDisposable, IAttachmentsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AttachmentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AttachmentsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AttachmentsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AttachmentsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
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
        public AttachmentsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class using a Configuration object.
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
        public AttachmentsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AttachmentsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiAttachmentsDelete(string body)
        {
            var localVarResponse = NewAiAttachmentsDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiAttachmentsDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->NewAiAttachmentsDelete");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/attachments/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsDelete", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiAttachmentsDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete/">REST API Reference for NewAiAttachmentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiAttachmentsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->NewAiAttachmentsDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/attachments/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiAttachmentsDeleteMany(List<string> requestBody)
        {
            var localVarResponse = NewAiAttachmentsDeleteManyWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiAttachmentsDeleteManyWithHttpInfo(List<string> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->NewAiAttachmentsDeleteMany");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/attachments/delete-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsDeleteMany", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiAttachmentsDeleteManyAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsDeleteManyWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-delete-many/">REST API Reference for NewAiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiAttachmentsDeleteManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->NewAiAttachmentsDeleteMany");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/attachments/delete-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsDeleteMany", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>NewAiAttachment</returns>
        public NewAiAttachment NewAiAttachmentsGet(string body)
        {
            var localVarResponse = NewAiAttachmentsGetWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>ApiResponse of NewAiAttachment</returns>
        public ApiResponse<NewAiAttachment> NewAiAttachmentsGetWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->NewAiAttachmentsGet");

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
            var localVarResponse = Client.Post<NewAiAttachment>("/api/2.0/ai/attachments/get", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsGet", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>Task of NewAiAttachment</returns>
        public async Task<NewAiAttachment> NewAiAttachmentsGetAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsGetWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get/">REST API Reference for NewAiAttachmentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAttachment)</returns>
        public async Task<ApiResponse<NewAiAttachment>> NewAiAttachmentsGetWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->NewAiAttachmentsGet");

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

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiAttachment>("/api/2.0/ai/attachments/get", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsGet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>List&lt;NewAiAttachment&gt;</returns>
        public List<NewAiAttachment> NewAiAttachmentsGetMany(List<string> requestBody)
        {
            var localVarResponse = NewAiAttachmentsGetManyWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiAttachment&gt;</returns>
        public ApiResponse<List<NewAiAttachment>> NewAiAttachmentsGetManyWithHttpInfo(List<string> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->NewAiAttachmentsGetMany");

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
            var localVarResponse = Client.Post<List<NewAiAttachment>>("/api/2.0/ai/attachments/get-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsGetMany", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of List&lt;NewAiAttachment&gt;</returns>
        public async Task<List<NewAiAttachment>> NewAiAttachmentsGetManyAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsGetManyWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-get-many/">REST API Reference for NewAiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiAttachment&gt;)</returns>
        public async Task<ApiResponse<List<NewAiAttachment>>> NewAiAttachmentsGetManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->NewAiAttachmentsGetMany");

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

            var localVarResponse = await AsynchronousClient.PostAsync<List<NewAiAttachment>>("/api/2.0/ai/attachments/get-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsGetMany", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiAttachmentsLinkToMessage(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest)
        {
            var localVarResponse = NewAiAttachmentsLinkToMessageWithHttpInfo(newAiAttachmentsLinkToMessageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiAttachmentsLinkToMessageWithHttpInfo(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest)
        {
            // verify the required parameter 'newAiAttachmentsLinkToMessageRequest' is set
            if (newAiAttachmentsLinkToMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsLinkToMessageRequest' when calling AttachmentsApi->NewAiAttachmentsLinkToMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsLinkToMessageRequest != null) localVarRequestOptions.Data = newAiAttachmentsLinkToMessageRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiSuccessResponse>("/api/2.0/ai/attachments/link-to-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsLinkToMessage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiAttachmentsLinkToMessageAsync(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsLinkToMessageWithHttpInfoAsync(newAiAttachmentsLinkToMessageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-link-to-message/">REST API Reference for NewAiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiAttachmentsLinkToMessageWithHttpInfoAsync(NewAiAttachmentsLinkToMessageRequest newAiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAttachmentsLinkToMessageRequest' is set
            if (newAiAttachmentsLinkToMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsLinkToMessageRequest' when calling AttachmentsApi->NewAiAttachmentsLinkToMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsLinkToMessageRequest != null) localVarRequestOptions.Data = newAiAttachmentsLinkToMessageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiSuccessResponse>("/api/2.0/ai/attachments/link-to-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsLinkToMessage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>NewAiAttachment</returns>
        public NewAiAttachment NewAiAttachmentsSaveFile(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest)
        {
            var localVarResponse = NewAiAttachmentsSaveFileWithHttpInfo(newAiAttachmentsSaveFileRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>ApiResponse of NewAiAttachment</returns>
        public ApiResponse<NewAiAttachment> NewAiAttachmentsSaveFileWithHttpInfo(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest)
        {
            // verify the required parameter 'newAiAttachmentsSaveFileRequest' is set
            if (newAiAttachmentsSaveFileRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveFileRequest' when calling AttachmentsApi->NewAiAttachmentsSaveFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveFileRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveFileRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiAttachment>("/api/2.0/ai/attachments/save-file", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveFile", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of NewAiAttachment</returns>
        public async Task<NewAiAttachment> NewAiAttachmentsSaveFileAsync(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsSaveFileWithHttpInfoAsync(newAiAttachmentsSaveFileRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-file/">REST API Reference for NewAiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAttachment)</returns>
        public async Task<ApiResponse<NewAiAttachment>> NewAiAttachmentsSaveFileWithHttpInfoAsync(NewAiAttachmentsSaveFileRequest newAiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAttachmentsSaveFileRequest' is set
            if (newAiAttachmentsSaveFileRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveFileRequest' when calling AttachmentsApi->NewAiAttachmentsSaveFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveFileRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveFileRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiAttachment>("/api/2.0/ai/attachments/save-file", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveFile", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>List&lt;NewAiAttachment&gt;</returns>
        public List<NewAiAttachment> NewAiAttachmentsSaveFilesMany(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest)
        {
            var localVarResponse = NewAiAttachmentsSaveFilesManyWithHttpInfo(newAiAttachmentsSaveFilesManyRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiAttachment&gt;</returns>
        public ApiResponse<List<NewAiAttachment>> NewAiAttachmentsSaveFilesManyWithHttpInfo(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest)
        {
            // verify the required parameter 'newAiAttachmentsSaveFilesManyRequest' is set
            if (newAiAttachmentsSaveFilesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveFilesManyRequest' when calling AttachmentsApi->NewAiAttachmentsSaveFilesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveFilesManyRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveFilesManyRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<List<NewAiAttachment>>("/api/2.0/ai/attachments/save-files-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveFilesMany", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of List&lt;NewAiAttachment&gt;</returns>
        public async Task<List<NewAiAttachment>> NewAiAttachmentsSaveFilesManyAsync(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsSaveFilesManyWithHttpInfoAsync(newAiAttachmentsSaveFilesManyRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-files-many/">REST API Reference for NewAiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiAttachment&gt;)</returns>
        public async Task<ApiResponse<List<NewAiAttachment>>> NewAiAttachmentsSaveFilesManyWithHttpInfoAsync(NewAiAttachmentsSaveFilesManyRequest newAiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAttachmentsSaveFilesManyRequest' is set
            if (newAiAttachmentsSaveFilesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveFilesManyRequest' when calling AttachmentsApi->NewAiAttachmentsSaveFilesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveFilesManyRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveFilesManyRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<List<NewAiAttachment>>("/api/2.0/ai/attachments/save-files-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveFilesMany", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>NewAiAttachment</returns>
        public NewAiAttachment NewAiAttachmentsSaveImage(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest)
        {
            var localVarResponse = NewAiAttachmentsSaveImageWithHttpInfo(newAiAttachmentsSaveImageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>ApiResponse of NewAiAttachment</returns>
        public ApiResponse<NewAiAttachment> NewAiAttachmentsSaveImageWithHttpInfo(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest)
        {
            // verify the required parameter 'newAiAttachmentsSaveImageRequest' is set
            if (newAiAttachmentsSaveImageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveImageRequest' when calling AttachmentsApi->NewAiAttachmentsSaveImage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveImageRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveImageRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiAttachment>("/api/2.0/ai/attachments/save-image", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveImage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of NewAiAttachment</returns>
        public async Task<NewAiAttachment> NewAiAttachmentsSaveImageAsync(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsSaveImageWithHttpInfoAsync(newAiAttachmentsSaveImageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-image/">REST API Reference for NewAiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiAttachment)</returns>
        public async Task<ApiResponse<NewAiAttachment>> NewAiAttachmentsSaveImageWithHttpInfoAsync(NewAiAttachmentsSaveImageRequest newAiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAttachmentsSaveImageRequest' is set
            if (newAiAttachmentsSaveImageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveImageRequest' when calling AttachmentsApi->NewAiAttachmentsSaveImage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveImageRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveImageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiAttachment>("/api/2.0/ai/attachments/save-image", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveImage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>List&lt;NewAiAttachment&gt;</returns>
        public List<NewAiAttachment> NewAiAttachmentsSaveImagesMany(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest)
        {
            var localVarResponse = NewAiAttachmentsSaveImagesManyWithHttpInfo(newAiAttachmentsSaveImagesManyRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiAttachment&gt;</returns>
        public ApiResponse<List<NewAiAttachment>> NewAiAttachmentsSaveImagesManyWithHttpInfo(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest)
        {
            // verify the required parameter 'newAiAttachmentsSaveImagesManyRequest' is set
            if (newAiAttachmentsSaveImagesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveImagesManyRequest' when calling AttachmentsApi->NewAiAttachmentsSaveImagesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveImagesManyRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveImagesManyRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<List<NewAiAttachment>>("/api/2.0/ai/attachments/save-images-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveImagesMany", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of List&lt;NewAiAttachment&gt;</returns>
        public async Task<List<NewAiAttachment>> NewAiAttachmentsSaveImagesManyAsync(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiAttachmentsSaveImagesManyWithHttpInfoAsync(newAiAttachmentsSaveImagesManyRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-attachments-save-images-many/">REST API Reference for NewAiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiAttachment&gt;)</returns>
        public async Task<ApiResponse<List<NewAiAttachment>>> NewAiAttachmentsSaveImagesManyWithHttpInfoAsync(NewAiAttachmentsSaveImagesManyRequest newAiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiAttachmentsSaveImagesManyRequest' is set
            if (newAiAttachmentsSaveImagesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiAttachmentsSaveImagesManyRequest' when calling AttachmentsApi->NewAiAttachmentsSaveImagesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiAttachmentsSaveImagesManyRequest != null) localVarRequestOptions.Data = newAiAttachmentsSaveImagesManyRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<List<NewAiAttachment>>("/api/2.0/ai/attachments/save-images-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiAttachmentsSaveImagesMany", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
