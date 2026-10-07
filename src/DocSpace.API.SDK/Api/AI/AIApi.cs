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
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiApproveToolCall(AiApproveToolCallRequest aiApproveToolCallRequest);

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiApproveToolCallWithHttpInfo(AiApproveToolCallRequest aiApproveToolCallRequest);
        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiDenyToolCall(AiToolCallData aiToolCallData);

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiDenyToolCallWithHttpInfo(AiToolCallData aiToolCallData);
        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiRegenerateStream(AiRegenerateStreamRequest aiRegenerateStreamRequest);

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiRegenerateStreamWithHttpInfo(AiRegenerateStreamRequest aiRegenerateStreamRequest);
        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        AiThreadMessageLike AiSend(AiSendRequest aiSendRequest);

        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        ApiResponse<AiThreadMessageLike> AiSendWithHttpInfo(AiSendRequest aiSendRequest);
        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        AiThreadMessageLike AiSendCustom(AiSendCustomRequest aiSendCustomRequest);

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        ApiResponse<AiThreadMessageLike> AiSendCustomWithHttpInfo(AiSendCustomRequest aiSendCustomRequest);
        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        AiChatEvent AiSendWithStream(AiSendStreamBody aiSendStreamBody);

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        ApiResponse<AiChatEvent> AiSendWithStreamWithHttpInfo(AiSendStreamBody aiSendStreamBody);
        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>AiOpenAIStreamChunk</returns>
        AiOpenAIStreamChunk AiSendWithStreamOpenAI(AiSendStreamBody aiSendStreamBody);

        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>ApiResponse of AiOpenAIStreamChunk</returns>
        ApiResponse<AiOpenAIStreamChunk> AiSendWithStreamOpenAIWithHttpInfo(AiSendStreamBody aiSendStreamBody);
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
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiApproveToolCallAsync(AiApproveToolCallRequest aiApproveToolCallRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiApproveToolCallWithHttpInfoAsync(AiApproveToolCallRequest aiApproveToolCallRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiDenyToolCallAsync(AiToolCallData aiToolCallData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiDenyToolCallWithHttpInfoAsync(AiToolCallData aiToolCallData, CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiRegenerateStreamAsync(AiRegenerateStreamRequest aiRegenerateStreamRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiRegenerateStreamWithHttpInfoAsync(AiRegenerateStreamRequest aiRegenerateStreamRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        Task<AiThreadMessageLike> AiSendAsync(AiSendRequest aiSendRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        Task<ApiResponse<AiThreadMessageLike>> AiSendWithHttpInfoAsync(AiSendRequest aiSendRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        Task<AiThreadMessageLike> AiSendCustomAsync(AiSendCustomRequest aiSendCustomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        Task<ApiResponse<AiThreadMessageLike>> AiSendCustomWithHttpInfoAsync(AiSendCustomRequest aiSendCustomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        Task<AiChatEvent> AiSendWithStreamAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        Task<ApiResponse<AiChatEvent>> AiSendWithStreamWithHttpInfoAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of AiOpenAIStreamChunk</returns>
        Task<AiOpenAIStreamChunk> AiSendWithStreamOpenAIAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of ApiResponse (AiOpenAIStreamChunk)</returns>
        Task<ApiResponse<AiOpenAIStreamChunk>> AiSendWithStreamOpenAIWithHttpInfoAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default);
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
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiApproveToolCall(AiApproveToolCallRequest aiApproveToolCallRequest)
        {
            var localVarResponse = AiApproveToolCallWithHttpInfo(aiApproveToolCallRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiApproveToolCallWithHttpInfo(AiApproveToolCallRequest aiApproveToolCallRequest)
        {
            // verify the required parameter 'aiApproveToolCallRequest' is set
            if (aiApproveToolCallRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiApproveToolCallRequest' when calling AIApi->AiApproveToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiApproveToolCallRequest != null) localVarRequestOptions.Data = aiApproveToolCallRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/approve-tool-call", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiApproveToolCall", localVarResponse);
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
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiApproveToolCallAsync(AiApproveToolCallRequest aiApproveToolCallRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiApproveToolCallWithHttpInfoAsync(aiApproveToolCallRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Approve tool call
        /// </summary>
        /// <remarks>
        /// Resumes a chat round that a tool call has paused, and streams the continuation as newline-delimited `ChatEvent` objects. The result supplied in the request is persisted onto the assistant message that issued the call, so the tool is not executed here - the caller runs it and reports the outcome. The round continues against the augmented history and may pause again on a further tool call. Call `POST api/2.0/ai/ai/deny-tool-call` instead to refuse the call and let the model answer without it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiApproveToolCallRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-approve-tool-call/">REST API Reference for AiApproveToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiApproveToolCallWithHttpInfoAsync(AiApproveToolCallRequest aiApproveToolCallRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiApproveToolCallRequest' is set
            if (aiApproveToolCallRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiApproveToolCallRequest' when calling AIApi->AiApproveToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiApproveToolCallRequest != null) localVarRequestOptions.Data = aiApproveToolCallRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/approve-tool-call", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiApproveToolCall", localVarResponse);
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
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiDenyToolCall(AiToolCallData aiToolCallData)
        {
            var localVarResponse = AiDenyToolCallWithHttpInfo(aiToolCallData);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiDenyToolCallWithHttpInfo(AiToolCallData aiToolCallData)
        {
            // verify the required parameter 'aiToolCallData' is set
            if (aiToolCallData == null)
                throw new ApiException(400, "Missing required parameter 'aiToolCallData' when calling AIApi->AiDenyToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolCallData != null) localVarRequestOptions.Data = aiToolCallData;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/deny-tool-call", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiDenyToolCall", localVarResponse);
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
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiDenyToolCallAsync(AiToolCallData aiToolCallData, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiDenyToolCallWithHttpInfoAsync(aiToolCallData, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deny tool call
        /// </summary>
        /// <remarks>
        /// Refuses the tool call a chat round is paused on and resumes it immediately, streaming the continuation as newline-delimited `ChatEvent` objects. The literal `User deny tool call` is persisted in place of the tool result, so the model sees an explicit refusal rather than a missing answer and may reply without the tool or ask for something else. Nothing is executed and no result is accepted from the caller. Use `POST api/2.0/ai/ai/approve-tool-call` to supply a result instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolCallData">Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-deny-tool-call/">REST API Reference for AiDenyToolCall Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiDenyToolCallWithHttpInfoAsync(AiToolCallData aiToolCallData, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolCallData' is set
            if (aiToolCallData == null)
                throw new ApiException(400, "Missing required parameter 'aiToolCallData' when calling AIApi->AiDenyToolCall");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolCallData != null) localVarRequestOptions.Data = aiToolCallData;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/deny-tool-call", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiDenyToolCall", localVarResponse);
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
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiRegenerateStream(AiRegenerateStreamRequest aiRegenerateStreamRequest)
        {
            var localVarResponse = AiRegenerateStreamWithHttpInfo(aiRegenerateStreamRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiRegenerateStreamWithHttpInfo(AiRegenerateStreamRequest aiRegenerateStreamRequest)
        {
            // verify the required parameter 'aiRegenerateStreamRequest' is set
            if (aiRegenerateStreamRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiRegenerateStreamRequest' when calling AIApi->AiRegenerateStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiRegenerateStreamRequest != null) localVarRequestOptions.Data = aiRegenerateStreamRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/regenerate-stream", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiRegenerateStream", localVarResponse);
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
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiRegenerateStreamAsync(AiRegenerateStreamRequest aiRegenerateStreamRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiRegenerateStreamWithHttpInfoAsync(aiRegenerateStreamRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate stream
        /// </summary>
        /// <remarks>
        /// Re-rolls the last assistant reply of an existing thread: every message after the last user message - the previous reply and any tool-call hops - is dropped, and a fresh reply is streamed as newline-delimited `ChatEvent` objects against the unchanged prompt. The thread has to exist already, `threadId` is required, and no title is generated. The dropped messages are gone for good, so this is a destructive operation on the thread's tail rather than a retry that keeps both answers. Unlike `send-with-stream` the profile is not verified before the stream opens, so an unusable model surfaces as an error frame inside the 200 rather than as a 4xx.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiRegenerateStreamRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-regenerate-stream/">REST API Reference for AiRegenerateStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiRegenerateStreamWithHttpInfoAsync(AiRegenerateStreamRequest aiRegenerateStreamRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiRegenerateStreamRequest' is set
            if (aiRegenerateStreamRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiRegenerateStreamRequest' when calling AIApi->AiRegenerateStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiRegenerateStreamRequest != null) localVarRequestOptions.Data = aiRegenerateStreamRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/regenerate-stream", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiRegenerateStream", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        public AiThreadMessageLike AiSend(AiSendRequest aiSendRequest)
        {
            var localVarResponse = AiSendWithHttpInfo(aiSendRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        public ApiResponse<AiThreadMessageLike> AiSendWithHttpInfo(AiSendRequest aiSendRequest)
        {
            // verify the required parameter 'aiSendRequest' is set
            if (aiSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSendRequest' when calling AIApi->AiSend");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendRequest != null) localVarRequestOptions.Data = aiSendRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiThreadMessageLike>("/api/2.0/ai/ai/send", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSend", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        public async Task<AiThreadMessageLike> AiSendAsync(AiSendRequest aiSendRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSendWithHttpInfoAsync(aiSendRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Run an AI action
        /// </summary>
        /// <remarks>
        /// Runs one AI action and returns the whole answer as a single JSON document. The model is the profile bound to `actionType`, falling back to the `Default` assignment slot, so this operation accepts no `profileId` of its own. Nothing is persisted - no thread is opened, no message is stored and no title is generated - which makes it the one to use for a stand-alone completion rather than for a conversation. `entityId` and `contextEntityId` set the scope of the round, which decides the workspace context and the custom MCP servers it may reach. For a conversation that keeps its history, use `POST api/2.0/ai/ai/send-with-stream` instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send/">REST API Reference for AiSend Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        public async Task<ApiResponse<AiThreadMessageLike>> AiSendWithHttpInfoAsync(AiSendRequest aiSendRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSendRequest' is set
            if (aiSendRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSendRequest' when calling AIApi->AiSend");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendRequest != null) localVarRequestOptions.Data = aiSendRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiThreadMessageLike>("/api/2.0/ai/ai/send", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSend", localVarResponse);
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
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>AiThreadMessageLike</returns>
        public AiThreadMessageLike AiSendCustom(AiSendCustomRequest aiSendCustomRequest)
        {
            var localVarResponse = AiSendCustomWithHttpInfo(aiSendCustomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>ApiResponse of AiThreadMessageLike</returns>
        public ApiResponse<AiThreadMessageLike> AiSendCustomWithHttpInfo(AiSendCustomRequest aiSendCustomRequest)
        {
            // verify the required parameter 'aiSendCustomRequest' is set
            if (aiSendCustomRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSendCustomRequest' when calling AIApi->AiSendCustom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendCustomRequest != null) localVarRequestOptions.Data = aiSendCustomRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiThreadMessageLike>("/api/2.0/ai/ai/send-custom", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSendCustom", localVarResponse);
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
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>Task of AiThreadMessageLike</returns>
        public async Task<AiThreadMessageLike> AiSendCustomAsync(AiSendCustomRequest aiSendCustomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSendCustomWithHttpInfoAsync(aiSendCustomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send custom
        /// </summary>
        /// <remarks>
        /// Runs a free-form one-turn call against a system prompt supplied in the request, with no thread, no history and nothing persisted. The model is the explicit `profileId` when it resolves, otherwise the `Default` assignment slot. The shape of the answer depends on the body rather than on the route: with `isStream` set it arrives as a newline-delimited stream of chat events, and without it as a single JSON document, so a client has to handle both. Use `POST api/2.0/ai/ai/send` when the prompt should come from the portal's own action configuration instead of from the caller.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendCustomRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-custom/">REST API Reference for AiSendCustom Operation</seealso>
        /// <returns>Task of ApiResponse (AiThreadMessageLike)</returns>
        public async Task<ApiResponse<AiThreadMessageLike>> AiSendCustomWithHttpInfoAsync(AiSendCustomRequest aiSendCustomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSendCustomRequest' is set
            if (aiSendCustomRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSendCustomRequest' when calling AIApi->AiSendCustom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendCustomRequest != null) localVarRequestOptions.Data = aiSendCustomRequest;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiThreadMessageLike>("/api/2.0/ai/ai/send-custom", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSendCustom", localVarResponse);
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
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>AiChatEvent</returns>
        public AiChatEvent AiSendWithStream(AiSendStreamBody aiSendStreamBody)
        {
            var localVarResponse = AiSendWithStreamWithHttpInfo(aiSendStreamBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>ApiResponse of AiChatEvent</returns>
        public ApiResponse<AiChatEvent> AiSendWithStreamWithHttpInfo(AiSendStreamBody aiSendStreamBody)
        {
            // verify the required parameter 'aiSendStreamBody' is set
            if (aiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiSendStreamBody' when calling AIApi->AiSendWithStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/x-ndjson","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendStreamBody != null) localVarRequestOptions.Data = aiSendStreamBody;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiChatEvent>("/api/2.0/ai/ai/send-with-stream", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSendWithStream", localVarResponse);
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
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>Task of AiChatEvent</returns>
        public async Task<AiChatEvent> AiSendWithStreamAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSendWithStreamWithHttpInfoAsync(aiSendStreamBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send with stream
        /// </summary>
        /// <remarks>
        /// Runs one chat round and streams it back as newline-delimited `ChatEvent` objects. Omitting `threadId` opens a new thread, which requires that `entityId` names a room the caller can open and that a profile resolves for it; the user message and the reply are persisted either way, and a new thread also gets a generated title. The model is settled in a fixed order - an agent's assignment in scope overrides everything, then the explicit `profileId`, then the one stored on the thread, then the `Chat` assignment - and the effective profile is checked before the stream opens, so an unknown one fails with 400 rather than as an error buried in a 200. A tool call pauses the round and ends the stream; resume it with `POST api/2.0/ai/ai/approve-tool-call` or `POST api/2.0/ai/ai/deny-tool-call`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream/">REST API Reference for AiSendWithStream Operation</seealso>
        /// <returns>Task of ApiResponse (AiChatEvent)</returns>
        public async Task<ApiResponse<AiChatEvent>> AiSendWithStreamWithHttpInfoAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSendStreamBody' is set
            if (aiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiSendStreamBody' when calling AIApi->AiSendWithStream");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/x-ndjson", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendStreamBody != null) localVarRequestOptions.Data = aiSendStreamBody;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiChatEvent>("/api/2.0/ai/ai/send-with-stream", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSendWithStream", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>AiOpenAIStreamChunk</returns>
        public AiOpenAIStreamChunk AiSendWithStreamOpenAI(AiSendStreamBody aiSendStreamBody)
        {
            var localVarResponse = AiSendWithStreamOpenAIWithHttpInfo(aiSendStreamBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>ApiResponse of AiOpenAIStreamChunk</returns>
        public ApiResponse<AiOpenAIStreamChunk> AiSendWithStreamOpenAIWithHttpInfo(AiSendStreamBody aiSendStreamBody)
        {
            // verify the required parameter 'aiSendStreamBody' is set
            if (aiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiSendStreamBody' when calling AIApi->AiSendWithStreamOpenAI");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["text/event-stream","application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendStreamBody != null) localVarRequestOptions.Data = aiSendStreamBody;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = Client.Post<AiOpenAIStreamChunk>("/api/2.0/ai/ai/send-with-stream-openai", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSendWithStreamOpenAI", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of AiOpenAIStreamChunk</returns>
        public async Task<AiOpenAIStreamChunk> AiSendWithStreamOpenAIAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSendWithStreamOpenAIWithHttpInfoAsync(aiSendStreamBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Stream a chat in OpenAI format
        /// </summary>
        /// <remarks>
        /// The same chat round as `send-with-stream`, re-encoded as a server-sent-events stream of OpenAI `chat.completion.chunk` objects terminated by a `[DONE]` sentinel. Thread handling, persistence, title generation and the profile pre-flight are identical, and a tool call ends the stream with `finish_reason: tool_calls` instead of a pause event - resume it through the same approve and deny operations. Unlike `send-with-stream` it does not reject an empty user message and does not enforce the per-kind attachment cap, so validate both before calling. Choose this route only for a client that already speaks the OpenAI wire format; `POST api/2.0/ai/ai/send-with-stream` is the native one.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSendStreamBody">Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-send-with-stream-open-ai/">REST API Reference for AiSendWithStreamOpenAI Operation</seealso>
        /// <returns>Task of ApiResponse (AiOpenAIStreamChunk)</returns>
        public async Task<ApiResponse<AiOpenAIStreamChunk>> AiSendWithStreamOpenAIWithHttpInfoAsync(AiSendStreamBody aiSendStreamBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSendStreamBody' is set
            if (aiSendStreamBody == null)
                throw new ApiException(400, "Missing required parameter 'aiSendStreamBody' when calling AIApi->AiSendWithStreamOpenAI");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "text/event-stream", "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSendStreamBody != null) localVarRequestOptions.Data = aiSendStreamBody;

            // authentication (cookieAuth) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiOpenAIStreamChunk>("/api/2.0/ai/ai/send-with-stream-openai", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSendWithStreamOpenAI", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
