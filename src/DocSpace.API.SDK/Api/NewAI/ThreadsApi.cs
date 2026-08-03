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
    public interface IThreadsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Append user message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        NewAiThreadMessageLike NewAiThreadsAppendUserMessage(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest);

        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        ApiResponse<NewAiThreadMessageLike> NewAiThreadsAppendUserMessageWithHttpInfo(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest);
        /// <summary>
        /// Clear messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiThreadsClearMessages(string body);

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiThreadsClearMessagesWithHttpInfo(string body);
        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>NewAiThread</returns>
        NewAiThread NewAiThreadsCreate(NewAiThreadsCreateRequest newAiThreadsCreateRequest);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiThread</returns>
        ApiResponse<NewAiThread> NewAiThreadsCreateWithHttpInfo(NewAiThreadsCreateRequest newAiThreadsCreateRequest);
        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiThreadsDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiThreadsDeleteWithHttpInfo(string body);
        /// <summary>
        /// Delete message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiThreadsDeleteMessage(string body);

        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiThreadsDeleteMessageWithHttpInfo(string body);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>NewAiThread</returns>
        NewAiThread NewAiThreadsGetById(string threadId);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>ApiResponse of NewAiThread</returns>
        ApiResponse<NewAiThread> NewAiThreadsGetByIdWithHttpInfo(string threadId);
        /// <summary>
        /// Get message by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        NewAiThreadMessageLike NewAiThreadsGetMessageById(string messageId);

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        ApiResponse<NewAiThreadMessageLike> NewAiThreadsGetMessageByIdWithHttpInfo(string messageId);
        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>List&lt;NewAiThread&gt;</returns>
        List<NewAiThread> NewAiThreadsList(string entityId, string count, string cursor, string query);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiThread&gt;</returns>
        ApiResponse<List<NewAiThread>> NewAiThreadsListWithHttpInfo(string entityId, string count, string cursor, string query);
        /// <summary>
        /// Open or create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>NewAiOpenOrCreateResult</returns>
        NewAiOpenOrCreateResult NewAiThreadsOpenOrCreate(NewAiOpenOrCreateInput newAiOpenOrCreateInput);

        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiOpenOrCreateResult</returns>
        ApiResponse<NewAiOpenOrCreateResult> NewAiThreadsOpenOrCreateWithHttpInfo(NewAiOpenOrCreateInput newAiOpenOrCreateInput);
        /// <summary>
        /// Read messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>List&lt;NewAiThreadMessageLike&gt;</returns>
        List<NewAiThreadMessageLike> NewAiThreadsReadMessages(string threadId, string count, string cursor);

        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiThreadMessageLike&gt;</returns>
        ApiResponse<List<NewAiThreadMessageLike>> NewAiThreadsReadMessagesWithHttpInfo(string threadId, string count, string cursor);
        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>string</returns>
        string NewAiThreadsRegenerateTitle(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest);

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> NewAiThreadsRegenerateTitleWithHttpInfo(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest);
        /// <summary>
        /// Rename
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiThreadsRename(NewAiThreadsRenameRequest newAiThreadsRenameRequest);

        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiThreadsRenameWithHttpInfo(NewAiThreadsRenameRequest newAiThreadsRenameRequest);
        /// <summary>
        /// Touch
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiThreadsTouch(NewAiThreadsTouchRequest newAiThreadsTouchRequest);

        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiThreadsTouchWithHttpInfo(NewAiThreadsTouchRequest newAiThreadsTouchRequest);
        /// <summary>
        /// Update message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        NewAiSuccessResponse NewAiThreadsUpdateMessage(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest);

        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        ApiResponse<NewAiSuccessResponse> NewAiThreadsUpdateMessageWithHttpInfo(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThreadsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        Task<NewAiThreadMessageLike> NewAiThreadsAppendUserMessageAsync(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        Task<ApiResponse<NewAiThreadMessageLike>> NewAiThreadsAppendUserMessageWithHttpInfoAsync(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiThreadsClearMessagesAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsClearMessagesWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>Task of NewAiThread</returns>
        Task<NewAiThread> NewAiThreadsCreateAsync(NewAiThreadsCreateRequest newAiThreadsCreateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThread)</returns>
        Task<ApiResponse<NewAiThread>> NewAiThreadsCreateWithHttpInfoAsync(NewAiThreadsCreateRequest newAiThreadsCreateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiThreadsDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiThreadsDeleteMessageAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsDeleteMessageWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>Task of NewAiThread</returns>
        Task<NewAiThread> NewAiThreadsGetByIdAsync(string threadId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThread)</returns>
        Task<ApiResponse<NewAiThread>> NewAiThreadsGetByIdWithHttpInfoAsync(string threadId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        Task<NewAiThreadMessageLike> NewAiThreadsGetMessageByIdAsync(string messageId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        Task<ApiResponse<NewAiThreadMessageLike>> NewAiThreadsGetMessageByIdWithHttpInfoAsync(string messageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>Task of List&lt;NewAiThread&gt;</returns>
        Task<List<NewAiThread>> NewAiThreadsListAsync(string entityId, string count, string cursor, string query, CancellationToken cancellationToken = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiThread&gt;)</returns>
        Task<ApiResponse<List<NewAiThread>>> NewAiThreadsListWithHttpInfoAsync(string entityId, string count, string cursor, string query, CancellationToken cancellationToken = default);
        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of NewAiOpenOrCreateResult</returns>
        Task<NewAiOpenOrCreateResult> NewAiThreadsOpenOrCreateAsync(NewAiOpenOrCreateInput newAiOpenOrCreateInput, CancellationToken cancellationToken = default);

        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiOpenOrCreateResult)</returns>
        Task<ApiResponse<NewAiOpenOrCreateResult>> NewAiThreadsOpenOrCreateWithHttpInfoAsync(NewAiOpenOrCreateInput newAiOpenOrCreateInput, CancellationToken cancellationToken = default);
        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>Task of List&lt;NewAiThreadMessageLike&gt;</returns>
        Task<List<NewAiThreadMessageLike>> NewAiThreadsReadMessagesAsync(string threadId, string count, string cursor, CancellationToken cancellationToken = default);

        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiThreadMessageLike&gt;)</returns>
        Task<ApiResponse<List<NewAiThreadMessageLike>>> NewAiThreadsReadMessagesWithHttpInfoAsync(string threadId, string count, string cursor, CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of string</returns>
        Task<string> NewAiThreadsRegenerateTitleAsync(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        Task<ApiResponse<string>> NewAiThreadsRegenerateTitleWithHttpInfoAsync(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiThreadsRenameAsync(NewAiThreadsRenameRequest newAiThreadsRenameRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsRenameWithHttpInfoAsync(NewAiThreadsRenameRequest newAiThreadsRenameRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiThreadsTouchAsync(NewAiThreadsTouchRequest newAiThreadsTouchRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsTouchWithHttpInfoAsync(NewAiThreadsTouchRequest newAiThreadsTouchRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        Task<NewAiSuccessResponse> NewAiThreadsUpdateMessageAsync(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsUpdateMessageWithHttpInfoAsync(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThreadsApi : IThreadsApiSync, IThreadsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ThreadsApi : IDisposable, IThreadsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ThreadsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ThreadsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ThreadsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ThreadsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class.
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
        public ThreadsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class using a Configuration object.
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
        public ThreadsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ThreadsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ThreadsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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

        public ThreadsApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        
        /// <summary>
        /// Append user message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        public NewAiThreadMessageLike NewAiThreadsAppendUserMessage(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest)
        {
            var localVarResponse = NewAiThreadsAppendUserMessageWithHttpInfo(newAiThreadsAppendUserMessageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Append user message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        public ApiResponse<NewAiThreadMessageLike> NewAiThreadsAppendUserMessageWithHttpInfo(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest)
        {
            // verify the required parameter 'newAiThreadsAppendUserMessageRequest' is set
            if (newAiThreadsAppendUserMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsAppendUserMessageRequest' when calling ThreadsApi->NewAiThreadsAppendUserMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsAppendUserMessageRequest != null) localVarRequestOptions.Data = newAiThreadsAppendUserMessageRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiThreadMessageLike>("/api/2.0/ai/threads/append-user-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsAppendUserMessage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Append user message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        public async Task<NewAiThreadMessageLike> NewAiThreadsAppendUserMessageAsync(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsAppendUserMessageWithHttpInfoAsync(newAiThreadsAppendUserMessageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Append user message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-append-user-message/">REST API Reference for NewAiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        public async Task<ApiResponse<NewAiThreadMessageLike>> NewAiThreadsAppendUserMessageWithHttpInfoAsync(NewAiThreadsAppendUserMessageRequest newAiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiThreadsAppendUserMessageRequest' is set
            if (newAiThreadsAppendUserMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsAppendUserMessageRequest' when calling ThreadsApi->NewAiThreadsAppendUserMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsAppendUserMessageRequest != null) localVarRequestOptions.Data = newAiThreadsAppendUserMessageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiThreadMessageLike>("/api/2.0/ai/threads/append-user-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsAppendUserMessage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiThreadsClearMessages(string body)
        {
            var localVarResponse = NewAiThreadsClearMessagesWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiThreadsClearMessagesWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->NewAiThreadsClearMessages");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/threads/clear-messages", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsClearMessages", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiThreadsClearMessagesAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsClearMessagesWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-clear-messages/">REST API Reference for NewAiThreadsClearMessages Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsClearMessagesWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->NewAiThreadsClearMessages");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/threads/clear-messages", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsClearMessages", localVarResponse);
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
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>NewAiThread</returns>
        public NewAiThread NewAiThreadsCreate(NewAiThreadsCreateRequest newAiThreadsCreateRequest)
        {
            var localVarResponse = NewAiThreadsCreateWithHttpInfo(newAiThreadsCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiThread</returns>
        public ApiResponse<NewAiThread> NewAiThreadsCreateWithHttpInfo(NewAiThreadsCreateRequest newAiThreadsCreateRequest)
        {
            // verify the required parameter 'newAiThreadsCreateRequest' is set
            if (newAiThreadsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsCreateRequest' when calling ThreadsApi->NewAiThreadsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsCreateRequest != null) localVarRequestOptions.Data = newAiThreadsCreateRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiThread>("/api/2.0/ai/threads/create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsCreate", localVarResponse);
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
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>Task of NewAiThread</returns>
        public async Task<NewAiThread> NewAiThreadsCreateAsync(NewAiThreadsCreateRequest newAiThreadsCreateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsCreateWithHttpInfoAsync(newAiThreadsCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-create/">REST API Reference for NewAiThreadsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThread)</returns>
        public async Task<ApiResponse<NewAiThread>> NewAiThreadsCreateWithHttpInfoAsync(NewAiThreadsCreateRequest newAiThreadsCreateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiThreadsCreateRequest' is set
            if (newAiThreadsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsCreateRequest' when calling ThreadsApi->NewAiThreadsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsCreateRequest != null) localVarRequestOptions.Data = newAiThreadsCreateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiThread>("/api/2.0/ai/threads/create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsCreate", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiThreadsDelete(string body)
        {
            var localVarResponse = NewAiThreadsDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiThreadsDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->NewAiThreadsDelete");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/threads/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsDelete", localVarResponse);
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
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiThreadsDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete/">REST API Reference for NewAiThreadsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->NewAiThreadsDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/threads/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiThreadsDeleteMessage(string body)
        {
            var localVarResponse = NewAiThreadsDeleteMessageWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiThreadsDeleteMessageWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->NewAiThreadsDeleteMessage");

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
            var localVarResponse = Client.Delete<NewAiSuccessResponse>("/api/2.0/ai/threads/delete-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsDeleteMessage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiThreadsDeleteMessageAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsDeleteMessageWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-delete-message/">REST API Reference for NewAiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsDeleteMessageWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->NewAiThreadsDeleteMessage");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<NewAiSuccessResponse>("/api/2.0/ai/threads/delete-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsDeleteMessage", localVarResponse);
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
        /// <param name="threadId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>NewAiThread</returns>
        public NewAiThread NewAiThreadsGetById(string threadId)
        {
            var localVarResponse = NewAiThreadsGetByIdWithHttpInfo(threadId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>ApiResponse of NewAiThread</returns>
        public ApiResponse<NewAiThread> NewAiThreadsGetByIdWithHttpInfo(string threadId)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->NewAiThreadsGetById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "threadId", threadId));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiThread>("/api/2.0/ai/threads/get-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsGetById", localVarResponse);
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
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>Task of NewAiThread</returns>
        public async Task<NewAiThread> NewAiThreadsGetByIdAsync(string threadId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsGetByIdWithHttpInfoAsync(threadId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-by-id/">REST API Reference for NewAiThreadsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThread)</returns>
        public async Task<ApiResponse<NewAiThread>> NewAiThreadsGetByIdWithHttpInfoAsync(string threadId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->NewAiThreadsGetById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "threadId", threadId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiThread>("/api/2.0/ai/threads/get-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsGetById", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>NewAiThreadMessageLike</returns>
        public NewAiThreadMessageLike NewAiThreadsGetMessageById(string messageId)
        {
            var localVarResponse = NewAiThreadsGetMessageByIdWithHttpInfo(messageId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>ApiResponse of NewAiThreadMessageLike</returns>
        public ApiResponse<NewAiThreadMessageLike> NewAiThreadsGetMessageByIdWithHttpInfo(string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ThreadsApi->NewAiThreadsGetMessageById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "messageId", messageId));


            // make the HTTP request
            var localVarResponse = Client.Get<NewAiThreadMessageLike>("/api/2.0/ai/threads/get-message-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsGetMessageById", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of NewAiThreadMessageLike</returns>
        public async Task<NewAiThreadMessageLike> NewAiThreadsGetMessageByIdAsync(string messageId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsGetMessageByIdWithHttpInfoAsync(messageId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-get-message-by-id/">REST API Reference for NewAiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiThreadMessageLike)</returns>
        public async Task<ApiResponse<NewAiThreadMessageLike>> NewAiThreadsGetMessageByIdWithHttpInfoAsync(string messageId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ThreadsApi->NewAiThreadsGetMessageById");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "messageId", messageId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewAiThreadMessageLike>("/api/2.0/ai/threads/get-message-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsGetMessageById", localVarResponse);
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
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>List&lt;NewAiThread&gt;</returns>
        public List<NewAiThread> NewAiThreadsList(string entityId, string count, string cursor, string query)
        {
            var localVarResponse = NewAiThreadsListWithHttpInfo(entityId, count, cursor, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiThread&gt;</returns>
        public ApiResponse<List<NewAiThread>> NewAiThreadsListWithHttpInfo(string entityId, string count, string cursor, string query)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ThreadsApi->NewAiThreadsList");

            // verify the required parameter 'count' is set
            if (count == null)
                throw new ApiException(400, "Missing required parameter 'count' when calling ThreadsApi->NewAiThreadsList");

            // verify the required parameter 'cursor' is set
            if (cursor == null)
                throw new ApiException(400, "Missing required parameter 'cursor' when calling ThreadsApi->NewAiThreadsList");

            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling ThreadsApi->NewAiThreadsList");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Get<List<NewAiThread>>("/api/2.0/ai/threads/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsList", localVarResponse);
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
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>Task of List&lt;NewAiThread&gt;</returns>
        public async Task<List<NewAiThread>> NewAiThreadsListAsync(string entityId, string count, string cursor, string query, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsListWithHttpInfoAsync(entityId, count, cursor, query, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="query"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-list/">REST API Reference for NewAiThreadsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiThread&gt;)</returns>
        public async Task<ApiResponse<List<NewAiThread>>> NewAiThreadsListWithHttpInfoAsync(string entityId, string count, string cursor, string query, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ThreadsApi->NewAiThreadsList");

            // verify the required parameter 'count' is set
            if (count == null)
                throw new ApiException(400, "Missing required parameter 'count' when calling ThreadsApi->NewAiThreadsList");

            // verify the required parameter 'cursor' is set
            if (cursor == null)
                throw new ApiException(400, "Missing required parameter 'cursor' when calling ThreadsApi->NewAiThreadsList");

            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling ThreadsApi->NewAiThreadsList");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<NewAiThread>>("/api/2.0/ai/threads/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsList", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open or create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>NewAiOpenOrCreateResult</returns>
        public NewAiOpenOrCreateResult NewAiThreadsOpenOrCreate(NewAiOpenOrCreateInput newAiOpenOrCreateInput)
        {
            var localVarResponse = NewAiThreadsOpenOrCreateWithHttpInfo(newAiOpenOrCreateInput);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open or create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>ApiResponse of NewAiOpenOrCreateResult</returns>
        public ApiResponse<NewAiOpenOrCreateResult> NewAiThreadsOpenOrCreateWithHttpInfo(NewAiOpenOrCreateInput newAiOpenOrCreateInput)
        {
            // verify the required parameter 'newAiOpenOrCreateInput' is set
            if (newAiOpenOrCreateInput == null)
                throw new ApiException(400, "Missing required parameter 'newAiOpenOrCreateInput' when calling ThreadsApi->NewAiThreadsOpenOrCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiOpenOrCreateInput != null) localVarRequestOptions.Data = newAiOpenOrCreateInput;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiOpenOrCreateResult>("/api/2.0/ai/threads/open-or-create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsOpenOrCreate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open or create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of NewAiOpenOrCreateResult</returns>
        public async Task<NewAiOpenOrCreateResult> NewAiThreadsOpenOrCreateAsync(NewAiOpenOrCreateInput newAiOpenOrCreateInput, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsOpenOrCreateWithHttpInfoAsync(newAiOpenOrCreateInput, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open or create
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiOpenOrCreateInput">Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-open-or-create/">REST API Reference for NewAiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiOpenOrCreateResult)</returns>
        public async Task<ApiResponse<NewAiOpenOrCreateResult>> NewAiThreadsOpenOrCreateWithHttpInfoAsync(NewAiOpenOrCreateInput newAiOpenOrCreateInput, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiOpenOrCreateInput' is set
            if (newAiOpenOrCreateInput == null)
                throw new ApiException(400, "Missing required parameter 'newAiOpenOrCreateInput' when calling ThreadsApi->NewAiThreadsOpenOrCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiOpenOrCreateInput != null) localVarRequestOptions.Data = newAiOpenOrCreateInput;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiOpenOrCreateResult>("/api/2.0/ai/threads/open-or-create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsOpenOrCreate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Read messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>List&lt;NewAiThreadMessageLike&gt;</returns>
        public List<NewAiThreadMessageLike> NewAiThreadsReadMessages(string threadId, string count, string cursor)
        {
            var localVarResponse = NewAiThreadsReadMessagesWithHttpInfo(threadId, count, cursor);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>ApiResponse of List&lt;NewAiThreadMessageLike&gt;</returns>
        public ApiResponse<List<NewAiThreadMessageLike>> NewAiThreadsReadMessagesWithHttpInfo(string threadId, string count, string cursor)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->NewAiThreadsReadMessages");

            // verify the required parameter 'count' is set
            if (count == null)
                throw new ApiException(400, "Missing required parameter 'count' when calling ThreadsApi->NewAiThreadsReadMessages");

            // verify the required parameter 'cursor' is set
            if (cursor == null)
                throw new ApiException(400, "Missing required parameter 'cursor' when calling ThreadsApi->NewAiThreadsReadMessages");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "threadId", threadId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Get<List<NewAiThreadMessageLike>>("/api/2.0/ai/threads/read-messages", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsReadMessages", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Read messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>Task of List&lt;NewAiThreadMessageLike&gt;</returns>
        public async Task<List<NewAiThreadMessageLike>> NewAiThreadsReadMessagesAsync(string threadId, string count, string cursor, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsReadMessagesWithHttpInfoAsync(threadId, count, cursor, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read messages
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId"></param>
        /// <param name="count"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-read-messages/">REST API Reference for NewAiThreadsReadMessages Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;NewAiThreadMessageLike&gt;)</returns>
        public async Task<ApiResponse<List<NewAiThreadMessageLike>>> NewAiThreadsReadMessagesWithHttpInfoAsync(string threadId, string count, string cursor, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->NewAiThreadsReadMessages");

            // verify the required parameter 'count' is set
            if (count == null)
                throw new ApiException(400, "Missing required parameter 'count' when calling ThreadsApi->NewAiThreadsReadMessages");

            // verify the required parameter 'cursor' is set
            if (cursor == null)
                throw new ApiException(400, "Missing required parameter 'cursor' when calling ThreadsApi->NewAiThreadsReadMessages");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "threadId", threadId));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<NewAiThreadMessageLike>>("/api/2.0/ai/threads/read-messages", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsReadMessages", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>string</returns>
        public string NewAiThreadsRegenerateTitle(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest)
        {
            var localVarResponse = NewAiThreadsRegenerateTitleWithHttpInfo(newAiThreadsRegenerateTitleRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> NewAiThreadsRegenerateTitleWithHttpInfo(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest)
        {
            // verify the required parameter 'newAiThreadsRegenerateTitleRequest' is set
            if (newAiThreadsRegenerateTitleRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsRegenerateTitleRequest' when calling ThreadsApi->NewAiThreadsRegenerateTitle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsRegenerateTitleRequest != null) localVarRequestOptions.Data = newAiThreadsRegenerateTitleRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<string>("/api/2.0/ai/threads/regenerate-title", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsRegenerateTitle", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of string</returns>
        public async Task<string> NewAiThreadsRegenerateTitleAsync(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsRegenerateTitleWithHttpInfoAsync(newAiThreadsRegenerateTitleRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-regenerate-title/">REST API Reference for NewAiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        public async Task<ApiResponse<string>> NewAiThreadsRegenerateTitleWithHttpInfoAsync(NewAiThreadsRegenerateTitleRequest newAiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiThreadsRegenerateTitleRequest' is set
            if (newAiThreadsRegenerateTitleRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsRegenerateTitleRequest' when calling ThreadsApi->NewAiThreadsRegenerateTitle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsRegenerateTitleRequest != null) localVarRequestOptions.Data = newAiThreadsRegenerateTitleRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<string>("/api/2.0/ai/threads/regenerate-title", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsRegenerateTitle", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiThreadsRename(NewAiThreadsRenameRequest newAiThreadsRenameRequest)
        {
            var localVarResponse = NewAiThreadsRenameWithHttpInfo(newAiThreadsRenameRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiThreadsRenameWithHttpInfo(NewAiThreadsRenameRequest newAiThreadsRenameRequest)
        {
            // verify the required parameter 'newAiThreadsRenameRequest' is set
            if (newAiThreadsRenameRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsRenameRequest' when calling ThreadsApi->NewAiThreadsRename");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsRenameRequest != null) localVarRequestOptions.Data = newAiThreadsRenameRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiSuccessResponse>("/api/2.0/ai/threads/rename", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsRename", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiThreadsRenameAsync(NewAiThreadsRenameRequest newAiThreadsRenameRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsRenameWithHttpInfoAsync(newAiThreadsRenameRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-rename/">REST API Reference for NewAiThreadsRename Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsRenameWithHttpInfoAsync(NewAiThreadsRenameRequest newAiThreadsRenameRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiThreadsRenameRequest' is set
            if (newAiThreadsRenameRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsRenameRequest' when calling ThreadsApi->NewAiThreadsRename");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsRenameRequest != null) localVarRequestOptions.Data = newAiThreadsRenameRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiSuccessResponse>("/api/2.0/ai/threads/rename", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsRename", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Touch
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiThreadsTouch(NewAiThreadsTouchRequest newAiThreadsTouchRequest)
        {
            var localVarResponse = NewAiThreadsTouchWithHttpInfo(newAiThreadsTouchRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Touch
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiThreadsTouchWithHttpInfo(NewAiThreadsTouchRequest newAiThreadsTouchRequest)
        {
            // verify the required parameter 'newAiThreadsTouchRequest' is set
            if (newAiThreadsTouchRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsTouchRequest' when calling ThreadsApi->NewAiThreadsTouch");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsTouchRequest != null) localVarRequestOptions.Data = newAiThreadsTouchRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<NewAiSuccessResponse>("/api/2.0/ai/threads/touch", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsTouch", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Touch
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiThreadsTouchAsync(NewAiThreadsTouchRequest newAiThreadsTouchRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsTouchWithHttpInfoAsync(newAiThreadsTouchRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Touch
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-touch/">REST API Reference for NewAiThreadsTouch Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsTouchWithHttpInfoAsync(NewAiThreadsTouchRequest newAiThreadsTouchRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiThreadsTouchRequest' is set
            if (newAiThreadsTouchRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsTouchRequest' when calling ThreadsApi->NewAiThreadsTouch");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsTouchRequest != null) localVarRequestOptions.Data = newAiThreadsTouchRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<NewAiSuccessResponse>("/api/2.0/ai/threads/touch", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsTouch", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>NewAiSuccessResponse</returns>
        public NewAiSuccessResponse NewAiThreadsUpdateMessage(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest)
        {
            var localVarResponse = NewAiThreadsUpdateMessageWithHttpInfo(newAiThreadsUpdateMessageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>ApiResponse of NewAiSuccessResponse</returns>
        public ApiResponse<NewAiSuccessResponse> NewAiThreadsUpdateMessageWithHttpInfo(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest)
        {
            // verify the required parameter 'newAiThreadsUpdateMessageRequest' is set
            if (newAiThreadsUpdateMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsUpdateMessageRequest' when calling ThreadsApi->NewAiThreadsUpdateMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsUpdateMessageRequest != null) localVarRequestOptions.Data = newAiThreadsUpdateMessageRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<NewAiSuccessResponse>("/api/2.0/ai/threads/update-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsUpdateMessage", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of NewAiSuccessResponse</returns>
        public async Task<NewAiSuccessResponse> NewAiThreadsUpdateMessageAsync(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await NewAiThreadsUpdateMessageWithHttpInfoAsync(newAiThreadsUpdateMessageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update message
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="newAiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/new-ai-threads-update-message/">REST API Reference for NewAiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of ApiResponse (NewAiSuccessResponse)</returns>
        public async Task<ApiResponse<NewAiSuccessResponse>> NewAiThreadsUpdateMessageWithHttpInfoAsync(NewAiThreadsUpdateMessageRequest newAiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'newAiThreadsUpdateMessageRequest' is set
            if (newAiThreadsUpdateMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'newAiThreadsUpdateMessageRequest' when calling ThreadsApi->NewAiThreadsUpdateMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (newAiThreadsUpdateMessageRequest != null) localVarRequestOptions.Data = newAiThreadsUpdateMessageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<NewAiSuccessResponse>("/api/2.0/ai/threads/update-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("NewAiThreadsUpdateMessage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
