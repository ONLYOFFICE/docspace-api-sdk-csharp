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
    public interface IAttachmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiAttachmentsDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiAttachmentsDeleteWithHttpInfo(string body);
        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiAttachmentsDeleteMany(List<string> requestBody);

        /// <summary>
        /// Delete many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiAttachmentsDeleteManyWithHttpInfo(List<string> requestBody);
        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>AiAttachment</returns>
        AiAttachment AiAttachmentsGet(string body);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>ApiResponse of AiAttachment</returns>
        ApiResponse<AiAttachment> AiAttachmentsGetWithHttpInfo(string body);
        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>List&lt;AiAttachment&gt;</returns>
        List<AiAttachment> AiAttachmentsGetMany(List<string> requestBody);

        /// <summary>
        /// Get many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiAttachment&gt;</returns>
        ApiResponse<List<AiAttachment>> AiAttachmentsGetManyWithHttpInfo(List<string> requestBody);
        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiAttachmentsLinkToMessage(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest);

        /// <summary>
        /// Link to message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiAttachmentsLinkToMessageWithHttpInfo(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest);
        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>AiAttachment</returns>
        AiAttachment AiAttachmentsSaveFile(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest);

        /// <summary>
        /// Save file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>ApiResponse of AiAttachment</returns>
        ApiResponse<AiAttachment> AiAttachmentsSaveFileWithHttpInfo(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest);
        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>List&lt;AiAttachment&gt;</returns>
        List<AiAttachment> AiAttachmentsSaveFilesMany(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest);

        /// <summary>
        /// Save files many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiAttachment&gt;</returns>
        ApiResponse<List<AiAttachment>> AiAttachmentsSaveFilesManyWithHttpInfo(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest);
        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>AiAttachment</returns>
        AiAttachment AiAttachmentsSaveImage(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest);

        /// <summary>
        /// Save image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>ApiResponse of AiAttachment</returns>
        ApiResponse<AiAttachment> AiAttachmentsSaveImageWithHttpInfo(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest);
        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>List&lt;AiAttachment&gt;</returns>
        List<AiAttachment> AiAttachmentsSaveImagesMany(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest);

        /// <summary>
        /// Save images many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiAttachment&gt;</returns>
        ApiResponse<List<AiAttachment>> AiAttachmentsSaveImagesManyWithHttpInfo(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiAttachmentsDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiAttachmentsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiAttachmentsDeleteManyAsync(List<string> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiAttachmentsDeleteManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>Task of AiAttachment</returns>
        Task<AiAttachment> AiAttachmentsGetAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiAttachment)</returns>
        Task<ApiResponse<AiAttachment>> AiAttachmentsGetWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of List&lt;AiAttachment&gt;</returns>
        Task<List<AiAttachment>> AiAttachmentsGetManyAsync(List<string> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiAttachment&gt;)</returns>
        Task<ApiResponse<List<AiAttachment>>> AiAttachmentsGetManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Link to message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiAttachmentsLinkToMessageAsync(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Link to message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiAttachmentsLinkToMessageWithHttpInfoAsync(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of AiAttachment</returns>
        Task<AiAttachment> AiAttachmentsSaveFileAsync(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of ApiResponse (AiAttachment)</returns>
        Task<ApiResponse<AiAttachment>> AiAttachmentsSaveFileWithHttpInfoAsync(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save files many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of List&lt;AiAttachment&gt;</returns>
        Task<List<AiAttachment>> AiAttachmentsSaveFilesManyAsync(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save files many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiAttachment&gt;)</returns>
        Task<ApiResponse<List<AiAttachment>>> AiAttachmentsSaveFilesManyWithHttpInfoAsync(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of AiAttachment</returns>
        Task<AiAttachment> AiAttachmentsSaveImageAsync(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of ApiResponse (AiAttachment)</returns>
        Task<ApiResponse<AiAttachment>> AiAttachmentsSaveImageWithHttpInfoAsync(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Save images many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of List&lt;AiAttachment&gt;</returns>
        Task<List<AiAttachment>> AiAttachmentsSaveImagesManyAsync(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Save images many
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiAttachment&gt;)</returns>
        Task<ApiResponse<List<AiAttachment>>> AiAttachmentsSaveImagesManyWithHttpInfoAsync(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiAttachmentsDelete(string body)
        {
            var localVarResponse = AiAttachmentsDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiAttachmentsDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->AiAttachmentsDelete");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/attachments/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsDelete", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiAttachmentsDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete/">REST API Reference for AiAttachmentsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiAttachmentsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->AiAttachmentsDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/attachments/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsDelete", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiAttachmentsDeleteMany(List<string> requestBody)
        {
            var localVarResponse = AiAttachmentsDeleteManyWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiAttachmentsDeleteManyWithHttpInfo(List<string> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->AiAttachmentsDeleteMany");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/attachments/delete-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsDeleteMany", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiAttachmentsDeleteManyAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsDeleteManyWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-delete-many/">REST API Reference for AiAttachmentsDeleteMany Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiAttachmentsDeleteManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->AiAttachmentsDeleteMany");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/attachments/delete-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsDeleteMany", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>AiAttachment</returns>
        public AiAttachment AiAttachmentsGet(string body)
        {
            var localVarResponse = AiAttachmentsGetWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>ApiResponse of AiAttachment</returns>
        public ApiResponse<AiAttachment> AiAttachmentsGetWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->AiAttachmentsGet");

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
            var localVarResponse = Client.Post<AiAttachment>("/api/2.0/ai/attachments/get", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsGet", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>Task of AiAttachment</returns>
        public async Task<AiAttachment> AiAttachmentsGetAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsGetWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get/">REST API Reference for AiAttachmentsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiAttachment)</returns>
        public async Task<ApiResponse<AiAttachment>> AiAttachmentsGetWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AttachmentsApi->AiAttachmentsGet");

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

            var localVarResponse = await AsynchronousClient.PostAsync<AiAttachment>("/api/2.0/ai/attachments/get", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsGet", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>List&lt;AiAttachment&gt;</returns>
        public List<AiAttachment> AiAttachmentsGetMany(List<string> requestBody)
        {
            var localVarResponse = AiAttachmentsGetManyWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiAttachment&gt;</returns>
        public ApiResponse<List<AiAttachment>> AiAttachmentsGetManyWithHttpInfo(List<string> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->AiAttachmentsGetMany");

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
            var localVarResponse = Client.Post<List<AiAttachment>>("/api/2.0/ai/attachments/get-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsGetMany", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of List&lt;AiAttachment&gt;</returns>
        public async Task<List<AiAttachment>> AiAttachmentsGetManyAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsGetManyWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-get-many/">REST API Reference for AiAttachmentsGetMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiAttachment&gt;)</returns>
        public async Task<ApiResponse<List<AiAttachment>>> AiAttachmentsGetManyWithHttpInfoAsync(List<string> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AttachmentsApi->AiAttachmentsGetMany");

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

            var localVarResponse = await AsynchronousClient.PostAsync<List<AiAttachment>>("/api/2.0/ai/attachments/get-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsGetMany", localVarResponse);
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
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiAttachmentsLinkToMessage(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest)
        {
            var localVarResponse = AiAttachmentsLinkToMessageWithHttpInfo(aiAttachmentsLinkToMessageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiAttachmentsLinkToMessageWithHttpInfo(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest)
        {
            // verify the required parameter 'aiAttachmentsLinkToMessageRequest' is set
            if (aiAttachmentsLinkToMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsLinkToMessageRequest' when calling AttachmentsApi->AiAttachmentsLinkToMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsLinkToMessageRequest != null) localVarRequestOptions.Data = aiAttachmentsLinkToMessageRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiSuccessResponse>("/api/2.0/ai/attachments/link-to-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsLinkToMessage", localVarResponse);
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
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiAttachmentsLinkToMessageAsync(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsLinkToMessageWithHttpInfoAsync(aiAttachmentsLinkToMessageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Link to message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsLinkToMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-link-to-message/">REST API Reference for AiAttachmentsLinkToMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiAttachmentsLinkToMessageWithHttpInfoAsync(AiAttachmentsLinkToMessageRequest aiAttachmentsLinkToMessageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAttachmentsLinkToMessageRequest' is set
            if (aiAttachmentsLinkToMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsLinkToMessageRequest' when calling AttachmentsApi->AiAttachmentsLinkToMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsLinkToMessageRequest != null) localVarRequestOptions.Data = aiAttachmentsLinkToMessageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiSuccessResponse>("/api/2.0/ai/attachments/link-to-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsLinkToMessage", localVarResponse);
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
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>AiAttachment</returns>
        public AiAttachment AiAttachmentsSaveFile(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest)
        {
            var localVarResponse = AiAttachmentsSaveFileWithHttpInfo(aiAttachmentsSaveFileRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>ApiResponse of AiAttachment</returns>
        public ApiResponse<AiAttachment> AiAttachmentsSaveFileWithHttpInfo(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest)
        {
            // verify the required parameter 'aiAttachmentsSaveFileRequest' is set
            if (aiAttachmentsSaveFileRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveFileRequest' when calling AttachmentsApi->AiAttachmentsSaveFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveFileRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveFileRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiAttachment>("/api/2.0/ai/attachments/save-file", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveFile", localVarResponse);
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
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of AiAttachment</returns>
        public async Task<AiAttachment> AiAttachmentsSaveFileAsync(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsSaveFileWithHttpInfoAsync(aiAttachmentsSaveFileRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save file
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFileRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-file/">REST API Reference for AiAttachmentsSaveFile Operation</seealso>
        /// <returns>Task of ApiResponse (AiAttachment)</returns>
        public async Task<ApiResponse<AiAttachment>> AiAttachmentsSaveFileWithHttpInfoAsync(AiAttachmentsSaveFileRequest aiAttachmentsSaveFileRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAttachmentsSaveFileRequest' is set
            if (aiAttachmentsSaveFileRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveFileRequest' when calling AttachmentsApi->AiAttachmentsSaveFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveFileRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveFileRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiAttachment>("/api/2.0/ai/attachments/save-file", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveFile", localVarResponse);
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
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>List&lt;AiAttachment&gt;</returns>
        public List<AiAttachment> AiAttachmentsSaveFilesMany(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest)
        {
            var localVarResponse = AiAttachmentsSaveFilesManyWithHttpInfo(aiAttachmentsSaveFilesManyRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiAttachment&gt;</returns>
        public ApiResponse<List<AiAttachment>> AiAttachmentsSaveFilesManyWithHttpInfo(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest)
        {
            // verify the required parameter 'aiAttachmentsSaveFilesManyRequest' is set
            if (aiAttachmentsSaveFilesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveFilesManyRequest' when calling AttachmentsApi->AiAttachmentsSaveFilesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveFilesManyRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveFilesManyRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<List<AiAttachment>>("/api/2.0/ai/attachments/save-files-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveFilesMany", localVarResponse);
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
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of List&lt;AiAttachment&gt;</returns>
        public async Task<List<AiAttachment>> AiAttachmentsSaveFilesManyAsync(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsSaveFilesManyWithHttpInfoAsync(aiAttachmentsSaveFilesManyRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save files many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveFilesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-files-many/">REST API Reference for AiAttachmentsSaveFilesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiAttachment&gt;)</returns>
        public async Task<ApiResponse<List<AiAttachment>>> AiAttachmentsSaveFilesManyWithHttpInfoAsync(AiAttachmentsSaveFilesManyRequest aiAttachmentsSaveFilesManyRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAttachmentsSaveFilesManyRequest' is set
            if (aiAttachmentsSaveFilesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveFilesManyRequest' when calling AttachmentsApi->AiAttachmentsSaveFilesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveFilesManyRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveFilesManyRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<List<AiAttachment>>("/api/2.0/ai/attachments/save-files-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveFilesMany", localVarResponse);
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
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>AiAttachment</returns>
        public AiAttachment AiAttachmentsSaveImage(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest)
        {
            var localVarResponse = AiAttachmentsSaveImageWithHttpInfo(aiAttachmentsSaveImageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>ApiResponse of AiAttachment</returns>
        public ApiResponse<AiAttachment> AiAttachmentsSaveImageWithHttpInfo(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest)
        {
            // verify the required parameter 'aiAttachmentsSaveImageRequest' is set
            if (aiAttachmentsSaveImageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveImageRequest' when calling AttachmentsApi->AiAttachmentsSaveImage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveImageRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveImageRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiAttachment>("/api/2.0/ai/attachments/save-image", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveImage", localVarResponse);
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
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of AiAttachment</returns>
        public async Task<AiAttachment> AiAttachmentsSaveImageAsync(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsSaveImageWithHttpInfoAsync(aiAttachmentsSaveImageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-image/">REST API Reference for AiAttachmentsSaveImage Operation</seealso>
        /// <returns>Task of ApiResponse (AiAttachment)</returns>
        public async Task<ApiResponse<AiAttachment>> AiAttachmentsSaveImageWithHttpInfoAsync(AiAttachmentsSaveImageRequest aiAttachmentsSaveImageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAttachmentsSaveImageRequest' is set
            if (aiAttachmentsSaveImageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveImageRequest' when calling AttachmentsApi->AiAttachmentsSaveImage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveImageRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveImageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiAttachment>("/api/2.0/ai/attachments/save-image", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveImage", localVarResponse);
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
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>List&lt;AiAttachment&gt;</returns>
        public List<AiAttachment> AiAttachmentsSaveImagesMany(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest)
        {
            var localVarResponse = AiAttachmentsSaveImagesManyWithHttpInfo(aiAttachmentsSaveImagesManyRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiAttachment&gt;</returns>
        public ApiResponse<List<AiAttachment>> AiAttachmentsSaveImagesManyWithHttpInfo(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest)
        {
            // verify the required parameter 'aiAttachmentsSaveImagesManyRequest' is set
            if (aiAttachmentsSaveImagesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveImagesManyRequest' when calling AttachmentsApi->AiAttachmentsSaveImagesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveImagesManyRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveImagesManyRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<List<AiAttachment>>("/api/2.0/ai/attachments/save-images-many", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveImagesMany", localVarResponse);
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
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of List&lt;AiAttachment&gt;</returns>
        public async Task<List<AiAttachment>> AiAttachmentsSaveImagesManyAsync(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAttachmentsSaveImagesManyWithHttpInfoAsync(aiAttachmentsSaveImagesManyRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save images many
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAttachmentsSaveImagesManyRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-attachments-save-images-many/">REST API Reference for AiAttachmentsSaveImagesMany Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiAttachment&gt;)</returns>
        public async Task<ApiResponse<List<AiAttachment>>> AiAttachmentsSaveImagesManyWithHttpInfoAsync(AiAttachmentsSaveImagesManyRequest aiAttachmentsSaveImagesManyRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAttachmentsSaveImagesManyRequest' is set
            if (aiAttachmentsSaveImagesManyRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAttachmentsSaveImagesManyRequest' when calling AttachmentsApi->AiAttachmentsSaveImagesMany");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAttachmentsSaveImagesManyRequest != null) localVarRequestOptions.Data = aiAttachmentsSaveImagesManyRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<List<AiAttachment>>("/api/2.0/ai/attachments/save-images-many", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAttachmentsSaveImagesMany", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
