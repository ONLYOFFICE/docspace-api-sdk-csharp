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
    public interface IAIApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiAiApproveToolCall(AiAiApproveToolCallRequest aiAiApproveToolCallRequest);

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiAiApproveToolCallWithHttpInfo(AiAiApproveToolCallRequest aiAiApproveToolCallRequest);
        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiAiDenyToolCall(AiAiToolCallData aiAiToolCallData);

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiAiDenyToolCallWithHttpInfo(AiAiToolCallData aiAiToolCallData);
        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiAiRegenerateStream(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest);

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiAiRegenerateStreamWithHttpInfo(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest);
        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        AiThreadMessageLike AiAiSend(AiAiSendRequest aiAiSendRequest);

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        ApiResponse<AiThreadMessageLike> AiAiSendWithHttpInfo(AiAiSendRequest aiAiSendRequest);
        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        AiThreadMessageLike AiAiSendCustom(AiAiSendCustomRequest aiAiSendCustomRequest);

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        ApiResponse<AiThreadMessageLike> AiAiSendCustomWithHttpInfo(AiAiSendCustomRequest aiAiSendCustomRequest);
        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiAiSendWithStream(AiAiSendStreamBody aiAiSendStreamBody);

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiAiSendWithStreamWithHttpInfo(AiAiSendStreamBody aiAiSendStreamBody);
        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>AiOpenAIStreamChunk</returns>
        AiOpenAIStreamChunk AiAiSendWithStreamOpenAI(AiAiSendStreamBody aiAiSendStreamBody);

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>ApiResponse of AiOpenAIStreamChunk</returns>
        ApiResponse<AiOpenAIStreamChunk> AiAiSendWithStreamOpenAIWithHttpInfo(AiAiSendStreamBody aiAiSendStreamBody);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiAiApproveToolCallAsync(AiAiApproveToolCallRequest aiAiApproveToolCallRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiAiApproveToolCallWithHttpInfoAsync(AiAiApproveToolCallRequest aiAiApproveToolCallRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiAiDenyToolCallAsync(AiAiToolCallData aiAiToolCallData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiAiDenyToolCallWithHttpInfoAsync(AiAiToolCallData aiAiToolCallData, CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiAiRegenerateStreamAsync(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiAiRegenerateStreamWithHttpInfoAsync(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        Task<AiThreadMessageLike> AiAiSendAsync(AiAiSendRequest aiAiSendRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        Task<ApiResponse<AiThreadMessageLike>> AiAiSendWithHttpInfoAsync(AiAiSendRequest aiAiSendRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        Task<AiThreadMessageLike> AiAiSendCustomAsync(AiAiSendCustomRequest aiAiSendCustomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        Task<ApiResponse<AiThreadMessageLike>> AiAiSendCustomWithHttpInfoAsync(AiAiSendCustomRequest aiAiSendCustomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiAiSendWithStreamAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiAiSendWithStreamWithHttpInfoAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of AiOpenAIStreamChunk</returns>
        Task<AiOpenAIStreamChunk> AiAiSendWithStreamOpenAIAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of ApiResponse (AiOpenAIStreamChunk)</returns>
        Task<ApiResponse<AiOpenAIStreamChunk>> AiAiSendWithStreamOpenAIWithHttpInfoAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAIApi : IAIApiSync, IAIApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AIApi : IDisposable, IAIApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AIApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AIApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AIApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AIApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIApi"/> class.
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
        public AIApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class using a Configuration object.
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
        public AIApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AIApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AIApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiAiApproveToolCall(AiAiApproveToolCallRequest aiAiApproveToolCallRequest)
        {
            var localVarResponse = AiAiApproveToolCallWithHttpInfo(aiAiApproveToolCallRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiAiApproveToolCallWithHttpInfo(AiAiApproveToolCallRequest aiAiApproveToolCallRequest)
        {
            // verify the required parameter 'aiAiApproveToolCallRequest' is set
            if (aiAiApproveToolCallRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiApproveToolCallRequest' when calling AIApi->AiAiApproveToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiApproveToolCallRequest != null) localVarRequestOptions.Data = aiAiApproveToolCallRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/approve-tool-call", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiApproveToolCall", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiAiApproveToolCallAsync(AiAiApproveToolCallRequest aiAiApproveToolCallRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiApproveToolCallWithHttpInfoAsync(aiAiApproveToolCallRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round paused on a tool call. The supplied result is persisted onto the assistant message that issued the call and the stream continues with the augmented history.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-approve-tool-call/">REST API Reference for AiAiApproveToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiAiApproveToolCallWithHttpInfoAsync(AiAiApproveToolCallRequest aiAiApproveToolCallRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiApproveToolCallRequest' is set
            if (aiAiApproveToolCallRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiApproveToolCallRequest' when calling AIApi->AiAiApproveToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiApproveToolCallRequest != null) localVarRequestOptions.Data = aiAiApproveToolCallRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/approve-tool-call", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiApproveToolCall", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiAiDenyToolCall(AiAiToolCallData aiAiToolCallData)
        {
            var localVarResponse = AiAiDenyToolCallWithHttpInfo(aiAiToolCallData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiAiDenyToolCallWithHttpInfo(AiAiToolCallData aiAiToolCallData)
        {
            // verify the required parameter 'aiAiToolCallData' is set
            if (aiAiToolCallData == null)
                throw new ApiException(400, "Missing required parameter 'aiAiToolCallData' when calling AIApi->AiAiDenyToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiToolCallData != null) localVarRequestOptions.Data = aiAiToolCallData;


            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/deny-tool-call", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiDenyToolCall", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiAiDenyToolCallAsync(AiAiToolCallData aiAiToolCallData, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiDenyToolCallWithHttpInfoAsync(aiAiToolCallData, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Denies the pending tool call and resumes the chat immediately, with `User deny tool call` standing in for the tool result.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-deny-tool-call/">REST API Reference for AiAiDenyToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiAiDenyToolCallWithHttpInfoAsync(AiAiToolCallData aiAiToolCallData, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiToolCallData' is set
            if (aiAiToolCallData == null)
                throw new ApiException(400, "Missing required parameter 'aiAiToolCallData' when calling AIApi->AiAiDenyToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiToolCallData != null) localVarRequestOptions.Data = aiAiToolCallData;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/deny-tool-call", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiDenyToolCall", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiAiRegenerateStream(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest)
        {
            var localVarResponse = AiAiRegenerateStreamWithHttpInfo(aiAiRegenerateStreamRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiAiRegenerateStreamWithHttpInfo(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest)
        {
            // verify the required parameter 'aiAiRegenerateStreamRequest' is set
            if (aiAiRegenerateStreamRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiRegenerateStreamRequest' when calling AIApi->AiAiRegenerateStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiRegenerateStreamRequest != null) localVarRequestOptions.Data = aiAiRegenerateStreamRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/regenerate-stream", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiRegenerateStream", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiAiRegenerateStreamAsync(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiRegenerateStreamWithHttpInfoAsync(aiAiRegenerateStreamRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply in an existing thread: every message after the last user message (the previous reply plus any tool-call hops) is dropped and a fresh reply is streamed against the unchanged prompt. The thread must already exist and no title is generated.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-regenerate-stream/">REST API Reference for AiAiRegenerateStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiAiRegenerateStreamWithHttpInfoAsync(AiAiRegenerateStreamRequest aiAiRegenerateStreamRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiRegenerateStreamRequest' is set
            if (aiAiRegenerateStreamRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiRegenerateStreamRequest' when calling AIApi->AiAiRegenerateStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiRegenerateStreamRequest != null) localVarRequestOptions.Data = aiAiRegenerateStreamRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/regenerate-stream", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiRegenerateStream", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        public AiThreadMessageLike AiAiSend(AiAiSendRequest aiAiSendRequest)
        {
            var localVarResponse = AiAiSendWithHttpInfo(aiAiSendRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        public ApiResponse<AiThreadMessageLike> AiAiSendWithHttpInfo(AiAiSendRequest aiAiSendRequest)
        {
            // verify the required parameter 'aiAiSendRequest' is set
            if (aiAiSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendRequest' when calling AIApi->AiAiSend");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendRequest != null) localVarRequestOptions.Data = aiAiSendRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiThreadMessageLike>("/api/2.0/ai/ai/send", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSend", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        public async Task<AiThreadMessageLike> AiAiSendAsync(AiAiSendRequest aiAiSendRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiSendWithHttpInfoAsync(aiAiSendRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send
        /// </summary>
        /// <remarks>
        /// Runs one AI action: the profile bound to `actionType` (falling back to the `Default` slot) is dispatched against a single-message history. Nothing is persisted - no thread, no title generation, no storage writes.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send/">REST API Reference for AiAiSend Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        public async Task<ApiResponse<AiThreadMessageLike>> AiAiSendWithHttpInfoAsync(AiAiSendRequest aiAiSendRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiSendRequest' is set
            if (aiAiSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendRequest' when calling AIApi->AiAiSend");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendRequest != null) localVarRequestOptions.Data = aiAiSendRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiThreadMessageLike>("/api/2.0/ai/ai/send", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSend", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        public AiThreadMessageLike AiAiSendCustom(AiAiSendCustomRequest aiAiSendCustomRequest)
        {
            var localVarResponse = AiAiSendCustomWithHttpInfo(aiAiSendCustomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        public ApiResponse<AiThreadMessageLike> AiAiSendCustomWithHttpInfo(AiAiSendCustomRequest aiAiSendCustomRequest)
        {
            // verify the required parameter 'aiAiSendCustomRequest' is set
            if (aiAiSendCustomRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendCustomRequest' when calling AIApi->AiAiSendCustom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendCustomRequest != null) localVarRequestOptions.Data = aiAiSendCustomRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiThreadMessageLike>("/api/2.0/ai/ai/send-custom", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSendCustom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        public async Task<AiThreadMessageLike> AiAiSendCustomAsync(AiAiSendCustomRequest aiAiSendCustomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiSendCustomWithHttpInfoAsync(aiAiSendCustomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a caller-supplied system prompt. No thread, no history and no persistence. The profile is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-custom/">REST API Reference for AiAiSendCustom Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        public async Task<ApiResponse<AiThreadMessageLike>> AiAiSendCustomWithHttpInfoAsync(AiAiSendCustomRequest aiAiSendCustomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiSendCustomRequest' is set
            if (aiAiSendCustomRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendCustomRequest' when calling AIApi->AiAiSendCustom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendCustomRequest != null) localVarRequestOptions.Data = aiAiSendCustomRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiThreadMessageLike>("/api/2.0/ai/ai/send-custom", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSendCustom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiAiSendWithStream(AiAiSendStreamBody aiAiSendStreamBody)
        {
            var localVarResponse = AiAiSendWithStreamWithHttpInfo(aiAiSendStreamBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiAiSendWithStreamWithHttpInfo(AiAiSendStreamBody aiAiSendStreamBody)
        {
            // verify the required parameter 'aiAiSendStreamBody' is set
            if (aiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendStreamBody' when calling AIApi->AiAiSendWithStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendStreamBody != null) localVarRequestOptions.Data = aiAiSendStreamBody;


            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/send-with-stream", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSendWithStream", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiAiSendWithStreamAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiSendWithStreamWithHttpInfoAsync(aiAiSendStreamBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Starts a chat round and streams it back as newline-delimited `ChatEvent` objects. The thread is opened or created, the user message and the reply are persisted, a new thread gets a generated title, and a tool call pauses the round until it is approved or denied.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream/">REST API Reference for AiAiSendWithStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiAiSendWithStreamWithHttpInfoAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiSendStreamBody' is set
            if (aiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendStreamBody' when calling AIApi->AiAiSendWithStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendStreamBody != null) localVarRequestOptions.Data = aiAiSendStreamBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/send-with-stream", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSendWithStream", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>AiOpenAIStreamChunk</returns>
        public AiOpenAIStreamChunk AiAiSendWithStreamOpenAI(AiAiSendStreamBody aiAiSendStreamBody)
        {
            var localVarResponse = AiAiSendWithStreamOpenAIWithHttpInfo(aiAiSendStreamBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>ApiResponse of AiOpenAIStreamChunk</returns>
        public ApiResponse<AiOpenAIStreamChunk> AiAiSendWithStreamOpenAIWithHttpInfo(AiAiSendStreamBody aiAiSendStreamBody)
        {
            // verify the required parameter 'aiAiSendStreamBody' is set
            if (aiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendStreamBody' when calling AIApi->AiAiSendWithStreamOpenAI");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["text/event-stream","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendStreamBody != null) localVarRequestOptions.Data = aiAiSendStreamBody;


            // make the HTTP request
            var localVarResponse = Client.Post<AiOpenAIStreamChunk>("/api/2.0/ai/ai/send-with-stream-openai", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSendWithStreamOpenAI", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of AiOpenAIStreamChunk</returns>
        public async Task<AiOpenAIStreamChunk> AiAiSendWithStreamOpenAIAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAiSendWithStreamOpenAIWithHttpInfoAsync(aiAiSendStreamBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream open ai
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as an OpenAI Chat Completions stream of `chat.completion.chunk` objects. Storage, title generation and tool-call pauses are identical - only the wire shape differs; a tool call ends the stream with `finish_reason: tool_calls`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-ai-send-with-stream-open-ai/">REST API Reference for AiAiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of ApiResponse (AiOpenAIStreamChunk)</returns>
        public async Task<ApiResponse<AiOpenAIStreamChunk>> AiAiSendWithStreamOpenAIWithHttpInfoAsync(AiAiSendStreamBody aiAiSendStreamBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAiSendStreamBody' is set
            if (aiAiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiAiSendStreamBody' when calling AIApi->AiAiSendWithStreamOpenAI");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "text/event-stream", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAiSendStreamBody != null) localVarRequestOptions.Data = aiAiSendStreamBody;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiOpenAIStreamChunk>("/api/2.0/ai/ai/send-with-stream-openai", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAiSendWithStreamOpenAI", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
