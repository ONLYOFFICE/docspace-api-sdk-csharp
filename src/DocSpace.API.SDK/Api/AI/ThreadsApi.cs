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
    public interface IThreadsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        AiThreadMessageLike AiThreadsAppendUserMessage(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest);

        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        ApiResponse<AiThreadMessageLike> AiThreadsAppendUserMessageWithHttpInfo(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest);
        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiThreadsClearMessages(string body);

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiThreadsClearMessagesWithHttpInfo(string body);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>AiThread</returns>
        AiThread AiThreadsCreate(AiThreadsCreateRequest aiThreadsCreateRequest);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>ApiResponse of AiThread</returns>
        ApiResponse<AiThread> AiThreadsCreateWithHttpInfo(AiThreadsCreateRequest aiThreadsCreateRequest);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiThreadsDelete(string body);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiThreadsDeleteWithHttpInfo(string body);
        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiThreadsDeleteMessage(string body);

        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiThreadsDeleteMessageWithHttpInfo(string body);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>AiThread</returns>
        AiThread AiThreadsGetById(string threadId);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>ApiResponse of AiThread</returns>
        ApiResponse<AiThread> AiThreadsGetByIdWithHttpInfo(string threadId);
        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        AiThreadMessageLike AiThreadsGetMessageById(string messageId);

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        ApiResponse<AiThreadMessageLike> AiThreadsGetMessageByIdWithHttpInfo(string messageId);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>List&lt;AiThread&gt;</returns>
        List<AiThread> AiThreadsList(string? entityId = default, string? count = default, string? cursor = default, string? query = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiThread&gt;</returns>
        ApiResponse<List<AiThread>> AiThreadsListWithHttpInfo(string? entityId = default, string? count = default, string? cursor = default, string? query = default);
        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>AiOpenOrCreateResult</returns>
        AiOpenOrCreateResult AiThreadsOpenOrCreate(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest);

        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>ApiResponse of AiOpenOrCreateResult</returns>
        ApiResponse<AiOpenOrCreateResult> AiThreadsOpenOrCreateWithHttpInfo(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest);
        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>List&lt;AiThreadMessageLike&gt;</returns>
        List<AiThreadMessageLike> AiThreadsReadMessages(string threadId, string? count = default, string? cursor = default, string? direction = default);

        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiThreadMessageLike&gt;</returns>
        ApiResponse<List<AiThreadMessageLike>> AiThreadsReadMessagesWithHttpInfo(string threadId, string? count = default, string? cursor = default, string? direction = default);
        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>string</returns>
        string AiThreadsRegenerateTitle(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest);

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AiThreadsRegenerateTitleWithHttpInfo(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest);
        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiThreadsRename(AiThreadsRenameRequest aiThreadsRenameRequest);

        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiThreadsRenameWithHttpInfo(AiThreadsRenameRequest aiThreadsRenameRequest);
        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiThreadsTouch(AiThreadsTouchRequest aiThreadsTouchRequest);

        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiThreadsTouchWithHttpInfo(AiThreadsTouchRequest aiThreadsTouchRequest);
        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiThreadsUpdateMessage(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest);

        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiThreadsUpdateMessageWithHttpInfo(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest);
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
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        Task<AiThreadMessageLike> AiThreadsAppendUserMessageAsync(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        Task<ApiResponse<AiThreadMessageLike>> AiThreadsAppendUserMessageWithHttpInfoAsync(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiThreadsClearMessagesAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiThreadsClearMessagesWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>Task of AiThread</returns>
        Task<AiThread> AiThreadsCreateAsync(AiThreadsCreateRequest aiThreadsCreateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiThread)</returns>
        Task<ApiResponse<AiThread>> AiThreadsCreateWithHttpInfoAsync(AiThreadsCreateRequest aiThreadsCreateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiThreadsDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiThreadsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiThreadsDeleteMessageAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiThreadsDeleteMessageWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>Task of AiThread</returns>
        Task<AiThread> AiThreadsGetByIdAsync(string threadId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (AiThread)</returns>
        Task<ApiResponse<AiThread>> AiThreadsGetByIdWithHttpInfoAsync(string threadId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        Task<AiThreadMessageLike> AiThreadsGetMessageByIdAsync(string messageId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        Task<ApiResponse<AiThreadMessageLike>> AiThreadsGetMessageByIdWithHttpInfoAsync(string messageId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>Task of List&lt;AiThread&gt;</returns>
        Task<List<AiThread>> AiThreadsListAsync(string? entityId = default, string? count = default, string? cursor = default, string? query = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiThread&gt;)</returns>
        Task<ApiResponse<List<AiThread>>> AiThreadsListWithHttpInfoAsync(string? entityId = default, string? count = default, string? cursor = default, string? query = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of AiOpenOrCreateResult</returns>
        Task<AiOpenOrCreateResult> AiThreadsOpenOrCreateAsync(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiOpenOrCreateResult)</returns>
        Task<ApiResponse<AiOpenOrCreateResult>> AiThreadsOpenOrCreateWithHttpInfoAsync(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>Task of List&lt;AiThreadMessageLike&gt;</returns>
        Task<List<AiThreadMessageLike>> AiThreadsReadMessagesAsync(string threadId, string? count = default, string? cursor = default, string? direction = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiThreadMessageLike&gt;)</returns>
        Task<ApiResponse<List<AiThreadMessageLike>>> AiThreadsReadMessagesWithHttpInfoAsync(string threadId, string? count = default, string? cursor = default, string? direction = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of string</returns>
        Task<string> AiThreadsRegenerateTitleAsync(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        Task<ApiResponse<string>> AiThreadsRegenerateTitleWithHttpInfoAsync(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiThreadsRenameAsync(AiThreadsRenameRequest aiThreadsRenameRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiThreadsRenameWithHttpInfoAsync(AiThreadsRenameRequest aiThreadsRenameRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiThreadsTouchAsync(AiThreadsTouchRequest aiThreadsTouchRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiThreadsTouchWithHttpInfoAsync(AiThreadsTouchRequest aiThreadsTouchRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiThreadsUpdateMessageAsync(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiThreadsUpdateMessageWithHttpInfoAsync(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default);
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
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        public AiThreadMessageLike AiThreadsAppendUserMessage(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest)
        {
            var localVarResponse = AiThreadsAppendUserMessageWithHttpInfo(aiThreadsAppendUserMessageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        public ApiResponse<AiThreadMessageLike> AiThreadsAppendUserMessageWithHttpInfo(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest)
        {
            // verify the required parameter 'aiThreadsAppendUserMessageRequest' is set
            if (aiThreadsAppendUserMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsAppendUserMessageRequest' when calling ThreadsApi->AiThreadsAppendUserMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsAppendUserMessageRequest != null) localVarRequestOptions.Data = aiThreadsAppendUserMessageRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiThreadMessageLike>("/api/2.0/ai/threads/append-user-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsAppendUserMessage", localVarResponse);
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
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        public async Task<AiThreadMessageLike> AiThreadsAppendUserMessageAsync(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsAppendUserMessageWithHttpInfoAsync(aiThreadsAppendUserMessageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Append user message
        /// </summary>
        /// <remarks>
        /// Persists a user message in a thread and bumps the thread's last-edit date so it resurfaces in the sidebar. Optionally rebinds the thread to another profile when the model changed mid-conversation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsAppendUserMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-append-user-message/">REST API Reference for AiThreadsAppendUserMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        public async Task<ApiResponse<AiThreadMessageLike>> AiThreadsAppendUserMessageWithHttpInfoAsync(AiThreadsAppendUserMessageRequest aiThreadsAppendUserMessageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsAppendUserMessageRequest' is set
            if (aiThreadsAppendUserMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsAppendUserMessageRequest' when calling ThreadsApi->AiThreadsAppendUserMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsAppendUserMessageRequest != null) localVarRequestOptions.Data = aiThreadsAppendUserMessageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiThreadMessageLike>("/api/2.0/ai/threads/append-user-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsAppendUserMessage", localVarResponse);
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
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiThreadsClearMessages(string body)
        {
            var localVarResponse = AiThreadsClearMessagesWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiThreadsClearMessagesWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->AiThreadsClearMessages");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/threads/clear-messages", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsClearMessages", localVarResponse);
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
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiThreadsClearMessagesAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsClearMessagesWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear messages
        /// </summary>
        /// <remarks>
        /// Drops every message of a thread while keeping the thread itself, and bumps its last-edit date.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-clear-messages/">REST API Reference for AiThreadsClearMessages Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiThreadsClearMessagesWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->AiThreadsClearMessages");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/threads/clear-messages", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsClearMessages", localVarResponse);
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
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>AiThread</returns>
        public AiThread AiThreadsCreate(AiThreadsCreateRequest aiThreadsCreateRequest)
        {
            var localVarResponse = AiThreadsCreateWithHttpInfo(aiThreadsCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>ApiResponse of AiThread</returns>
        public ApiResponse<AiThread> AiThreadsCreateWithHttpInfo(AiThreadsCreateRequest aiThreadsCreateRequest)
        {
            // verify the required parameter 'aiThreadsCreateRequest' is set
            if (aiThreadsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsCreateRequest' when calling ThreadsApi->AiThreadsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsCreateRequest != null) localVarRequestOptions.Data = aiThreadsCreateRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiThread>("/api/2.0/ai/threads/create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsCreate", localVarResponse);
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
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>Task of AiThread</returns>
        public async Task<AiThread> AiThreadsCreateAsync(AiThreadsCreateRequest aiThreadsCreateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsCreateWithHttpInfoAsync(aiThreadsCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// Creates a chat thread with a caller-supplied title. Use `open-or-create` instead when the title should be generated from the first user message.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-create/">REST API Reference for AiThreadsCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiThread)</returns>
        public async Task<ApiResponse<AiThread>> AiThreadsCreateWithHttpInfoAsync(AiThreadsCreateRequest aiThreadsCreateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsCreateRequest' is set
            if (aiThreadsCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsCreateRequest' when calling ThreadsApi->AiThreadsCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsCreateRequest != null) localVarRequestOptions.Data = aiThreadsCreateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiThread>("/api/2.0/ai/threads/create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsCreate", localVarResponse);
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
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiThreadsDelete(string body)
        {
            var localVarResponse = AiThreadsDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiThreadsDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->AiThreadsDelete");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/threads/delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsDelete", localVarResponse);
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
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiThreadsDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// Deletes a chat thread together with its messages.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete/">REST API Reference for AiThreadsDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiThreadsDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->AiThreadsDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/threads/delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsDelete", localVarResponse);
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
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiThreadsDeleteMessage(string body)
        {
            var localVarResponse = AiThreadsDeleteMessageWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiThreadsDeleteMessageWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->AiThreadsDeleteMessage");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/threads/delete-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsDeleteMessage", localVarResponse);
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
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiThreadsDeleteMessageAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsDeleteMessageWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete message
        /// </summary>
        /// <remarks>
        /// Deletes one chat message, leaving the rest of the thread untouched.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-delete-message/">REST API Reference for AiThreadsDeleteMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiThreadsDeleteMessageWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThreadsApi->AiThreadsDeleteMessage");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/threads/delete-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsDeleteMessage", localVarResponse);
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
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>AiThread</returns>
        public AiThread AiThreadsGetById(string threadId)
        {
            var localVarResponse = AiThreadsGetByIdWithHttpInfo(threadId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>ApiResponse of AiThread</returns>
        public ApiResponse<AiThread> AiThreadsGetByIdWithHttpInfo(string threadId)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->AiThreadsGetById");

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
            var localVarResponse = Client.Get<AiThread>("/api/2.0/ai/threads/get-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsGetById", localVarResponse);
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
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>Task of AiThread</returns>
        public async Task<AiThread> AiThreadsGetByIdAsync(string threadId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsGetByIdWithHttpInfoAsync(threadId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get by id
        /// </summary>
        /// <remarks>
        /// Returns one chat thread, or an empty result when the identifier is unknown.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-by-id/">REST API Reference for AiThreadsGetById Operation</seealso>
        /// <returns>Task of ApiResponse (AiThread)</returns>
        public async Task<ApiResponse<AiThread>> AiThreadsGetByIdWithHttpInfoAsync(string threadId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->AiThreadsGetById");

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiThread>("/api/2.0/ai/threads/get-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsGetById", localVarResponse);
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
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        public AiThreadMessageLike AiThreadsGetMessageById(string messageId)
        {
            var localVarResponse = AiThreadsGetMessageByIdWithHttpInfo(messageId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        public ApiResponse<AiThreadMessageLike> AiThreadsGetMessageByIdWithHttpInfo(string messageId)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ThreadsApi->AiThreadsGetMessageById");

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
            var localVarResponse = Client.Get<AiThreadMessageLike>("/api/2.0/ai/threads/get-message-by-id", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsGetMessageById", localVarResponse);
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
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        public async Task<AiThreadMessageLike> AiThreadsGetMessageByIdAsync(string messageId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsGetMessageByIdWithHttpInfoAsync(messageId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get message by id
        /// </summary>
        /// <remarks>
        /// Returns one chat message by its globally unique identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="messageId">The globally unique chat message identifier.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-get-message-by-id/">REST API Reference for AiThreadsGetMessageById Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        public async Task<ApiResponse<AiThreadMessageLike>> AiThreadsGetMessageByIdWithHttpInfoAsync(string messageId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling ThreadsApi->AiThreadsGetMessageById");

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

            var localVarResponse = await AsynchronousClient.GetAsync<AiThreadMessageLike>("/api/2.0/ai/threads/get-message-by-id", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsGetMessageById", localVarResponse);
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
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>List&lt;AiThread&gt;</returns>
        public List<AiThread> AiThreadsList(string? entityId = default, string? count = default, string? cursor = default, string? query = default)
        {
            var localVarResponse = AiThreadsListWithHttpInfo(entityId, count, cursor, query);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiThread&gt;</returns>
        public ApiResponse<List<AiThread>> AiThreadsListWithHttpInfo(string? entityId = default, string? count = default, string? cursor = default, string? query = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Get<List<AiThread>>("/api/2.0/ai/threads/list", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsList", localVarResponse);
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
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>Task of List&lt;AiThread&gt;</returns>
        public async Task<List<AiThread>> AiThreadsListAsync(string? entityId = default, string? count = default, string? cursor = default, string? query = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsListWithHttpInfoAsync(entityId, count, cursor, query, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Lists the chat threads of the scope, most recently edited first. Supports cursor pagination and a server-side case-insensitive title search.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="query">The full-text query the thread list is filtered by. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-list/">REST API Reference for AiThreadsList Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiThread&gt;)</returns>
        public async Task<ApiResponse<List<AiThread>>> AiThreadsListWithHttpInfoAsync(string? entityId = default, string? count = default, string? cursor = default, string? query = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "query", query));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<AiThread>>("/api/2.0/ai/threads/list", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsList", localVarResponse);
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
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>AiOpenOrCreateResult</returns>
        public AiOpenOrCreateResult AiThreadsOpenOrCreate(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest)
        {
            var localVarResponse = AiThreadsOpenOrCreateWithHttpInfo(aiThreadsOpenOrCreateRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>ApiResponse of AiOpenOrCreateResult</returns>
        public ApiResponse<AiOpenOrCreateResult> AiThreadsOpenOrCreateWithHttpInfo(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest)
        {
            // verify the required parameter 'aiThreadsOpenOrCreateRequest' is set
            if (aiThreadsOpenOrCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsOpenOrCreateRequest' when calling ThreadsApi->AiThreadsOpenOrCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsOpenOrCreateRequest != null) localVarRequestOptions.Data = aiThreadsOpenOrCreateRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiOpenOrCreateResult>("/api/2.0/ai/threads/open-or-create", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsOpenOrCreate", localVarResponse);
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
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of AiOpenOrCreateResult</returns>
        public async Task<AiOpenOrCreateResult> AiThreadsOpenOrCreateAsync(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsOpenOrCreateWithHttpInfoAsync(aiThreadsOpenOrCreateRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open or create
        /// </summary>
        /// <remarks>
        /// Opens a chat thread and returns its history, or creates one with a title generated from the supplied first message. That first message is not persisted - the caller decides whether to follow up with `append-user-message`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsOpenOrCreateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-open-or-create/">REST API Reference for AiThreadsOpenOrCreate Operation</seealso>
        /// <returns>Task of ApiResponse (AiOpenOrCreateResult)</returns>
        public async Task<ApiResponse<AiOpenOrCreateResult>> AiThreadsOpenOrCreateWithHttpInfoAsync(AiThreadsOpenOrCreateRequest aiThreadsOpenOrCreateRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsOpenOrCreateRequest' is set
            if (aiThreadsOpenOrCreateRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsOpenOrCreateRequest' when calling ThreadsApi->AiThreadsOpenOrCreate");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsOpenOrCreateRequest != null) localVarRequestOptions.Data = aiThreadsOpenOrCreateRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiOpenOrCreateResult>("/api/2.0/ai/threads/open-or-create", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsOpenOrCreate", localVarResponse);
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
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>List&lt;AiThreadMessageLike&gt;</returns>
        public List<AiThreadMessageLike> AiThreadsReadMessages(string threadId, string? count = default, string? cursor = default, string? direction = default)
        {
            var localVarResponse = AiThreadsReadMessagesWithHttpInfo(threadId, count, cursor, direction);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>ApiResponse of List&lt;AiThreadMessageLike&gt;</returns>
        public ApiResponse<List<AiThreadMessageLike>> AiThreadsReadMessagesWithHttpInfo(string threadId, string? count = default, string? cursor = default, string? direction = default)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->AiThreadsReadMessages");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "threadId", threadId));
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "direction", direction));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Get<List<AiThreadMessageLike>>("/api/2.0/ai/threads/read-messages", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsReadMessages", localVarResponse);
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
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>Task of List&lt;AiThreadMessageLike&gt;</returns>
        public async Task<List<AiThreadMessageLike>> AiThreadsReadMessagesAsync(string threadId, string? count = default, string? cursor = default, string? direction = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsReadMessagesWithHttpInfoAsync(threadId, count, cursor, direction, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Read messages
        /// </summary>
        /// <remarks>
        /// Reads the messages of a thread, with the same cursor pagination as the thread list.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="threadId">The chat thread identifier.</param>
        /// <param name="count">The maximum number of items to return in one page. (optional)</param>
        /// <param name="cursor">The keyset pagination cursor: the JSON-encoded sort key of the last item already received. Omit for the first page. (optional)</param>
        /// <param name="direction">The order the message page is read in. Only desc turns the read around and pages back from the newest message; omit for the forward read. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-read-messages/">REST API Reference for AiThreadsReadMessages Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;AiThreadMessageLike&gt;)</returns>
        public async Task<ApiResponse<List<AiThreadMessageLike>>> AiThreadsReadMessagesWithHttpInfoAsync(string threadId, string? count = default, string? cursor = default, string? direction = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'threadId' is set
            if (threadId == null)
                throw new ApiException(400, "Missing required parameter 'threadId' when calling ThreadsApi->AiThreadsReadMessages");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "threadId", threadId));
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (direction != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "direction", direction));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<AiThreadMessageLike>>("/api/2.0/ai/threads/read-messages", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsReadMessages", localVarResponse);
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
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>string</returns>
        public string AiThreadsRegenerateTitle(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest)
        {
            var localVarResponse = AiThreadsRegenerateTitleWithHttpInfo(aiThreadsRegenerateTitleRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> AiThreadsRegenerateTitleWithHttpInfo(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest)
        {
            // verify the required parameter 'aiThreadsRegenerateTitleRequest' is set
            if (aiThreadsRegenerateTitleRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsRegenerateTitleRequest' when calling ThreadsApi->AiThreadsRegenerateTitle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsRegenerateTitleRequest != null) localVarRequestOptions.Data = aiThreadsRegenerateTitleRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<string>("/api/2.0/ai/threads/regenerate-title", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsRegenerateTitle", localVarResponse);
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
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of string</returns>
        public async Task<string> AiThreadsRegenerateTitleAsync(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsRegenerateTitleWithHttpInfoAsync(aiThreadsRegenerateTitleRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate title
        /// </summary>
        /// <remarks>
        /// Generates a fresh title from the thread's first user message and persists it. Fails when the thread has no user message yet.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRegenerateTitleRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-regenerate-title/">REST API Reference for AiThreadsRegenerateTitle Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        public async Task<ApiResponse<string>> AiThreadsRegenerateTitleWithHttpInfoAsync(AiThreadsRegenerateTitleRequest aiThreadsRegenerateTitleRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsRegenerateTitleRequest' is set
            if (aiThreadsRegenerateTitleRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsRegenerateTitleRequest' when calling ThreadsApi->AiThreadsRegenerateTitle");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsRegenerateTitleRequest != null) localVarRequestOptions.Data = aiThreadsRegenerateTitleRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<string>("/api/2.0/ai/threads/regenerate-title", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsRegenerateTitle", localVarResponse);
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
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiThreadsRename(AiThreadsRenameRequest aiThreadsRenameRequest)
        {
            var localVarResponse = AiThreadsRenameWithHttpInfo(aiThreadsRenameRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiThreadsRenameWithHttpInfo(AiThreadsRenameRequest aiThreadsRenameRequest)
        {
            // verify the required parameter 'aiThreadsRenameRequest' is set
            if (aiThreadsRenameRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsRenameRequest' when calling ThreadsApi->AiThreadsRename");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsRenameRequest != null) localVarRequestOptions.Data = aiThreadsRenameRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/threads/rename", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsRename", localVarResponse);
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
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiThreadsRenameAsync(AiThreadsRenameRequest aiThreadsRenameRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsRenameWithHttpInfoAsync(aiThreadsRenameRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename
        /// </summary>
        /// <remarks>
        /// Renames a chat thread and bumps its last-edit date so the new title shows up in the sidebar.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsRenameRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-rename/">REST API Reference for AiThreadsRename Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiThreadsRenameWithHttpInfoAsync(AiThreadsRenameRequest aiThreadsRenameRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsRenameRequest' is set
            if (aiThreadsRenameRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsRenameRequest' when calling ThreadsApi->AiThreadsRename");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsRenameRequest != null) localVarRequestOptions.Data = aiThreadsRenameRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/threads/rename", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsRename", localVarResponse);
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
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiThreadsTouch(AiThreadsTouchRequest aiThreadsTouchRequest)
        {
            var localVarResponse = AiThreadsTouchWithHttpInfo(aiThreadsTouchRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiThreadsTouchWithHttpInfo(AiThreadsTouchRequest aiThreadsTouchRequest)
        {
            // verify the required parameter 'aiThreadsTouchRequest' is set
            if (aiThreadsTouchRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsTouchRequest' when calling ThreadsApi->AiThreadsTouch");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsTouchRequest != null) localVarRequestOptions.Data = aiThreadsTouchRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiSuccessResponse>("/api/2.0/ai/threads/touch", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsTouch", localVarResponse);
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
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiThreadsTouchAsync(AiThreadsTouchRequest aiThreadsTouchRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsTouchWithHttpInfoAsync(aiThreadsTouchRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Touch
        /// </summary>
        /// <remarks>
        /// Bumps a thread's last-edit date, and optionally rebinds it to another profile, when something other than a new message - a model switch, say - should resurface it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsTouchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-touch/">REST API Reference for AiThreadsTouch Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiThreadsTouchWithHttpInfoAsync(AiThreadsTouchRequest aiThreadsTouchRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsTouchRequest' is set
            if (aiThreadsTouchRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsTouchRequest' when calling ThreadsApi->AiThreadsTouch");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsTouchRequest != null) localVarRequestOptions.Data = aiThreadsTouchRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiSuccessResponse>("/api/2.0/ai/threads/touch", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsTouch", localVarResponse);
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
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiThreadsUpdateMessage(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest)
        {
            var localVarResponse = AiThreadsUpdateMessageWithHttpInfo(aiThreadsUpdateMessageRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiThreadsUpdateMessageWithHttpInfo(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest)
        {
            // verify the required parameter 'aiThreadsUpdateMessageRequest' is set
            if (aiThreadsUpdateMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsUpdateMessageRequest' when calling ThreadsApi->AiThreadsUpdateMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsUpdateMessageRequest != null) localVarRequestOptions.Data = aiThreadsUpdateMessageRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/threads/update-message", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsUpdateMessage", localVarResponse);
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
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiThreadsUpdateMessageAsync(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiThreadsUpdateMessageWithHttpInfoAsync(aiThreadsUpdateMessageRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update message
        /// </summary>
        /// <remarks>
        /// Replaces the content of a chat message - used by the edit and regenerate flows that change a message outside the streaming lifecycle.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiThreadsUpdateMessageRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-threads-update-message/">REST API Reference for AiThreadsUpdateMessage Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiThreadsUpdateMessageWithHttpInfoAsync(AiThreadsUpdateMessageRequest aiThreadsUpdateMessageRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiThreadsUpdateMessageRequest' is set
            if (aiThreadsUpdateMessageRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiThreadsUpdateMessageRequest' when calling ThreadsApi->AiThreadsUpdateMessage");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiThreadsUpdateMessageRequest != null) localVarRequestOptions.Data = aiThreadsUpdateMessageRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/threads/update-message", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiThreadsUpdateMessage", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
