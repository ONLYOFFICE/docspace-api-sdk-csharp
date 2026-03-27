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
    public interface IChatApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns></returns>
        void ContinueChat(Guid chatId, ContinueChatBody continueChatBody);

        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ContinueChatWithHttpInfo(Guid chatId, ContinueChatBody continueChatBody);
        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns></returns>
        void DeleteChat(Guid chatId);

        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteChatWithHttpInfo(Guid chatId);
        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns></returns>
        void ExportChat(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger);

        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExportChatWithHttpInfo(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger);
        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>ChatWrapper</returns>
        ChatWrapper GetChat(Guid chatId);

        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>ApiResponse of ChatWrapper</returns>
        ApiResponse<ChatWrapper> GetChatWithHttpInfo(Guid chatId);
        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>ModelArrayWrapper</returns>
        ModelArrayWrapper GetChatModels(int? provider = default);

        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>ApiResponse of ModelArrayWrapper</returns>
        ApiResponse<ModelArrayWrapper> GetChatModelsWithHttpInfo(int? provider = default);
        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>ChatArrayWrapper</returns>
        ChatArrayWrapper GetChats(int roomId, int? startIndex = default, int? count = default);

        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>ApiResponse of ChatArrayWrapper</returns>
        ApiResponse<ChatArrayWrapper> GetChatsWithHttpInfo(int roomId, int? startIndex = default, int? count = default);
        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>MessageArrayWrapper</returns>
        MessageArrayWrapper GetMessages(Guid chatId, int? startIndex = default, int? count = default);

        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>ApiResponse of MessageArrayWrapper</returns>
        ApiResponse<MessageArrayWrapper> GetMessagesWithHttpInfo(Guid chatId, int? startIndex = default, int? count = default);
        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>UserChatSettingsWrapper</returns>
        UserChatSettingsWrapper GetUserChatsSettings(int roomId);

        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>ApiResponse of UserChatSettingsWrapper</returns>
        ApiResponse<UserChatSettingsWrapper> GetUserChatsSettingsWithHttpInfo(int roomId);
        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns></returns>
        void ProvidePermission(string callId, ToolDecisionRequestBody toolDecisionRequestBody);

        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ProvidePermissionWithHttpInfo(string callId, ToolDecisionRequestBody toolDecisionRequestBody);
        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>ChatWrapper</returns>
        ChatWrapper RenameChat(Guid chatId, RenameChatBody renameChatBody);

        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>ApiResponse of ChatWrapper</returns>
        ApiResponse<ChatWrapper> RenameChatWithHttpInfo(Guid chatId, RenameChatBody renameChatBody);
        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>UserChatSettingsWrapper</returns>
        UserChatSettingsWrapper SetUserChatsSettings(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody);

        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>ApiResponse of UserChatSettingsWrapper</returns>
        ApiResponse<UserChatSettingsWrapper> SetUserChatsSettingsWithHttpInfo(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody);
        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns></returns>
        void StartNewChat(int roomId, StartNewChatBody startNewChatBody);

        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> StartNewChatWithHttpInfo(int roomId, StartNewChatBody startNewChatBody);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChatApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns>Task of void</returns>
        Task ContinueChatAsync(Guid chatId, ContinueChatBody continueChatBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ContinueChatWithHttpInfoAsync(Guid chatId, ContinueChatBody continueChatBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteChatAsync(Guid chatId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteChatWithHttpInfoAsync(Guid chatId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns>Task of void</returns>
        Task ExportChatAsync(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger, CancellationToken cancellationToken = default);

        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ExportChatWithHttpInfoAsync(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>Task of ChatWrapper</returns>
        Task<ChatWrapper> GetChatAsync(Guid chatId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>Task of ApiResponse (ChatWrapper)</returns>
        Task<ApiResponse<ChatWrapper>> GetChatWithHttpInfoAsync(Guid chatId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>Task of ModelArrayWrapper</returns>
        Task<ModelArrayWrapper> GetChatModelsAsync(int? provider = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>Task of ApiResponse (ModelArrayWrapper)</returns>
        Task<ApiResponse<ModelArrayWrapper>> GetChatModelsWithHttpInfoAsync(int? provider = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>Task of ChatArrayWrapper</returns>
        Task<ChatArrayWrapper> GetChatsAsync(int roomId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>Task of ApiResponse (ChatArrayWrapper)</returns>
        Task<ApiResponse<ChatArrayWrapper>> GetChatsWithHttpInfoAsync(int roomId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>Task of MessageArrayWrapper</returns>
        Task<MessageArrayWrapper> GetMessagesAsync(Guid chatId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>Task of ApiResponse (MessageArrayWrapper)</returns>
        Task<ApiResponse<MessageArrayWrapper>> GetMessagesWithHttpInfoAsync(Guid chatId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>Task of UserChatSettingsWrapper</returns>
        Task<UserChatSettingsWrapper> GetUserChatsSettingsAsync(int roomId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (UserChatSettingsWrapper)</returns>
        Task<ApiResponse<UserChatSettingsWrapper>> GetUserChatsSettingsWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns>Task of void</returns>
        Task ProvidePermissionAsync(string callId, ToolDecisionRequestBody toolDecisionRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ProvidePermissionWithHttpInfoAsync(string callId, ToolDecisionRequestBody toolDecisionRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>Task of ChatWrapper</returns>
        Task<ChatWrapper> RenameChatAsync(Guid chatId, RenameChatBody renameChatBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>Task of ApiResponse (ChatWrapper)</returns>
        Task<ApiResponse<ChatWrapper>> RenameChatWithHttpInfoAsync(Guid chatId, RenameChatBody renameChatBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>Task of UserChatSettingsWrapper</returns>
        Task<UserChatSettingsWrapper> SetUserChatsSettingsAsync(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (UserChatSettingsWrapper)</returns>
        Task<ApiResponse<UserChatSettingsWrapper>> SetUserChatsSettingsWithHttpInfoAsync(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns>Task of void</returns>
        Task StartNewChatAsync(int roomId, StartNewChatBody startNewChatBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> StartNewChatWithHttpInfoAsync(int roomId, StartNewChatBody startNewChatBody, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChatApi : IChatApiSync, IChatApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChatApi : IDisposable, IChatApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ChatApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ChatApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ChatApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ChatApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ChatApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
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
        public ChatApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ChatApi"/> class using a Configuration object.
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
        public ChatApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ChatApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ChatApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns></returns>
        public void ContinueChat(Guid chatId, ContinueChatBody continueChatBody)
        {
            ContinueChatWithHttpInfo(chatId, continueChatBody);
        }

        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ContinueChatWithHttpInfo(Guid chatId, ContinueChatBody continueChatBody)
        {
            // verify the required parameter 'continueChatBody' is set
            if (continueChatBody == null)
                throw new ApiException(400, "Missing required parameter 'continueChatBody' when calling ChatApi->ContinueChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (continueChatBody != null) localVarRequestOptions.Data = continueChatBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/ai/chats/{chatId}/messages", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ContinueChat", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ContinueChatAsync(Guid chatId, ContinueChatBody continueChatBody, CancellationToken cancellationToken = default)
        {
            await ContinueChatWithHttpInfoAsync(chatId, continueChatBody, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a message to an existing AI chat
        /// </summary>
        /// <remarks>
        /// Appends a new user message to an existing chat session and streams the AI assistant's response.  The full conversation history of the chat is sent to the AI provider to maintain context.  The response is delivered as a Server-Sent Events (SSE) stream with periodic keep-alive pings.  File references can optionally be attached to provide additional context.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the existing AI chat session to continue.</param>
        /// <param name="continueChatBody">The message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/continue-chat/">REST API Reference for ContinueChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ContinueChatWithHttpInfoAsync(Guid chatId, ContinueChatBody continueChatBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'continueChatBody' is set
            if (continueChatBody == null)
                throw new ApiException(400, "Missing required parameter 'continueChatBody' when calling ChatApi->ContinueChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (continueChatBody != null) localVarRequestOptions.Data = continueChatBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/ai/chats/{chatId}/messages", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ContinueChat", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns></returns>
        public void DeleteChat(Guid chatId)
        {
            DeleteChatWithHttpInfo(chatId);
        }

        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteChatWithHttpInfo(Guid chatId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/ai/chats/{chatId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteChat", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteChatAsync(Guid chatId, CancellationToken cancellationToken = default)
        {
            await DeleteChatWithHttpInfoAsync(chatId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete an AI chat
        /// </summary>
        /// <remarks>
        /// Permanently deletes an AI chat session along with all of its messages.  Only the chat owner can delete their own chat sessions. This action cannot be undone.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to delete.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-chat/">REST API Reference for DeleteChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteChatWithHttpInfoAsync(Guid chatId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/ai/chats/{chatId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteChat", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns></returns>
        public void ExportChat(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger)
        {
            ExportChatWithHttpInfo(chatId, exportChatRequestBodyInteger);
        }

        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ExportChatWithHttpInfo(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger)
        {
            // verify the required parameter 'exportChatRequestBodyInteger' is set
            if (exportChatRequestBodyInteger == null)
                throw new ApiException(400, "Missing required parameter 'exportChatRequestBodyInteger' when calling ChatApi->ExportChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (exportChatRequestBodyInteger != null) localVarRequestOptions.Data = exportChatRequestBodyInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/ai/chats/{chatId}/messages/export", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExportChat", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ExportChatAsync(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger, CancellationToken cancellationToken = default)
        {
            await ExportChatWithHttpInfoAsync(chatId, exportChatRequestBodyInteger, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Export AI chat messages to a file
        /// </summary>
        /// <remarks>
        /// Exports the entire message history of an AI chat session and saves it as a document in the specified folder.  The exported file is created with the provided title. Only the chat owner can export their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to export.</param>
        /// <param name="exportChatRequestBodyInteger">The export parameters including destination folder and file title.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/export-chat/">REST API Reference for ExportChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ExportChatWithHttpInfoAsync(Guid chatId, ExportChatRequestBodyInteger exportChatRequestBodyInteger, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'exportChatRequestBodyInteger' is set
            if (exportChatRequestBodyInteger == null)
                throw new ApiException(400, "Missing required parameter 'exportChatRequestBodyInteger' when calling ChatApi->ExportChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (exportChatRequestBodyInteger != null) localVarRequestOptions.Data = exportChatRequestBodyInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/ai/chats/{chatId}/messages/export", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ExportChat", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>ChatWrapper</returns>
        public ChatWrapper GetChat(Guid chatId)
        {
            var localVarResponse = GetChatWithHttpInfo(chatId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>ApiResponse of ChatWrapper</returns>
        public ApiResponse<ChatWrapper> GetChatWithHttpInfo(Guid chatId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<ChatWrapper>("/api/2.0/ai/chats/{chatId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetChat", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>Task of ChatWrapper</returns>
        public async Task<ChatWrapper> GetChatAsync(Guid chatId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetChatWithHttpInfoAsync(chatId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an AI chat by ID
        /// </summary>
        /// <remarks>
        /// Retrieves the metadata of a single AI chat session, including its title, creation date, and the user who created it.  Only the chat owner can access their own chat sessions.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat/">REST API Reference for GetChat Operation</seealso>
        /// <returns>Task of ApiResponse (ChatWrapper)</returns>
        public async Task<ApiResponse<ChatWrapper>> GetChatWithHttpInfoAsync(Guid chatId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ChatWrapper>("/api/2.0/ai/chats/{chatId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetChat", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>ModelArrayWrapper</returns>
        public ModelArrayWrapper GetChatModels(int? provider = default)
        {
            var localVarResponse = GetChatModelsWithHttpInfo(provider);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>ApiResponse of ModelArrayWrapper</returns>
        public ApiResponse<ModelArrayWrapper> GetChatModelsWithHttpInfo(int? provider = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "provider", provider));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<ModelArrayWrapper>("/api/2.0/ai/chats/models", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetChatModels", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>Task of ModelArrayWrapper</returns>
        public async Task<ModelArrayWrapper> GetChatModelsAsync(int? provider = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetChatModelsWithHttpInfoAsync(provider, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get available AI models
        /// </summary>
        /// <remarks>
        /// Returns the list of AI models available for chat conversations.  Optionally filters the results to models from a specific provider when the provider query parameter is specified.  Each model entry includes the provider ID, provider display name, and the model identifier.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="provider">The optional AI provider identifier to filter models by. When set to 0, models from all providers are returned. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chat-models/">REST API Reference for GetChatModels Operation</seealso>
        /// <returns>Task of ApiResponse (ModelArrayWrapper)</returns>
        public async Task<ApiResponse<ModelArrayWrapper>> GetChatModelsWithHttpInfoAsync(int? provider = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "provider", provider));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ModelArrayWrapper>("/api/2.0/ai/chats/models", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetChatModels", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>ChatArrayWrapper</returns>
        public ChatArrayWrapper GetChats(int roomId, int? startIndex = default, int? count = default)
        {
            var localVarResponse = GetChatsWithHttpInfo(roomId, startIndex, count);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>ApiResponse of ChatArrayWrapper</returns>
        public ApiResponse<ChatArrayWrapper> GetChatsWithHttpInfo(int roomId, int? startIndex = default, int? count = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<ChatArrayWrapper>("/api/2.0/ai/rooms/{roomId}/chats", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetChats", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>Task of ChatArrayWrapper</returns>
        public async Task<ChatArrayWrapper> GetChatsAsync(int roomId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetChatsWithHttpInfoAsync(roomId, startIndex, count, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI chats in a room
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of AI chat sessions that belong to the current user within the specified room.  Supports pagination via the startIndex and count query parameters. The total number of chats is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose AI chat sessions are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-chats/">REST API Reference for GetChats Operation</seealso>
        /// <returns>Task of ApiResponse (ChatArrayWrapper)</returns>
        public async Task<ApiResponse<ChatArrayWrapper>> GetChatsWithHttpInfoAsync(int roomId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ChatArrayWrapper>("/api/2.0/ai/rooms/{roomId}/chats", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetChats", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>MessageArrayWrapper</returns>
        public MessageArrayWrapper GetMessages(Guid chatId, int? startIndex = default, int? count = default)
        {
            var localVarResponse = GetMessagesWithHttpInfo(chatId, startIndex, count);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>ApiResponse of MessageArrayWrapper</returns>
        public ApiResponse<MessageArrayWrapper> GetMessagesWithHttpInfo(Guid chatId, int? startIndex = default, int? count = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<MessageArrayWrapper>("/api/2.0/ai/chats/{chatId}/messages", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMessages", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>Task of MessageArrayWrapper</returns>
        public async Task<MessageArrayWrapper> GetMessagesAsync(Guid chatId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetMessagesWithHttpInfoAsync(chatId, startIndex, count, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get messages of an AI chat
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of messages from an AI chat session owned by the current user.  Each message includes its role (user or assistant), content blocks (text, tool calls, attachments), and timestamp.  Supports pagination via the startIndex and count query parameters. The total number of messages is included in the response metadata.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session whose messages are to be listed.</param>
        /// <param name="startIndex">The number of items to skip before returning results (zero-based offset). Defaults to 0. (optional)</param>
        /// <param name="count">The maximum number of items to return per page. Defaults to 100. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-messages/">REST API Reference for GetMessages Operation</seealso>
        /// <returns>Task of ApiResponse (MessageArrayWrapper)</returns>
        public async Task<ApiResponse<MessageArrayWrapper>> GetMessagesWithHttpInfoAsync(Guid chatId, int? startIndex = default, int? count = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<MessageArrayWrapper>("/api/2.0/ai/chats/{chatId}/messages", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetMessages", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>UserChatSettingsWrapper</returns>
        public UserChatSettingsWrapper GetUserChatsSettings(int roomId)
        {
            var localVarResponse = GetUserChatsSettingsWithHttpInfo(roomId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>ApiResponse of UserChatSettingsWrapper</returns>
        public ApiResponse<UserChatSettingsWrapper> GetUserChatsSettingsWithHttpInfo(int roomId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Get<UserChatSettingsWrapper>("/api/2.0/ai/rooms/{roomId}/chats/config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserChatsSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>Task of UserChatSettingsWrapper</returns>
        public async Task<UserChatSettingsWrapper> GetUserChatsSettingsAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetUserChatsSettingsWithHttpInfoAsync(roomId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Retrieves the current user's personal AI chat preferences for the specified room,  including whether web search is enabled for AI-assisted responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be retrieved.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-user-chats-settings/">REST API Reference for GetUserChatsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (UserChatSettingsWrapper)</returns>
        public async Task<ApiResponse<UserChatSettingsWrapper>> GetUserChatsSettingsWithHttpInfoAsync(int roomId, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<UserChatSettingsWrapper>("/api/2.0/ai/rooms/{roomId}/chats/config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetUserChatsSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns></returns>
        public void ProvidePermission(string callId, ToolDecisionRequestBody toolDecisionRequestBody)
        {
            ProvidePermissionWithHttpInfo(callId, toolDecisionRequestBody);
        }

        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ProvidePermissionWithHttpInfo(string callId, ToolDecisionRequestBody toolDecisionRequestBody)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ChatApi->ProvidePermission");

            // verify the required parameter 'toolDecisionRequestBody' is set
            if (toolDecisionRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'toolDecisionRequestBody' when calling ChatApi->ProvidePermission");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("callId", ClientUtils.ParameterToString(callId)); // path parameter
            if (toolDecisionRequestBody != null) localVarRequestOptions.Data = toolDecisionRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/ai/chats/tool-permissions/{callId}/decision", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ProvidePermission", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ProvidePermissionAsync(string callId, ToolDecisionRequestBody toolDecisionRequestBody, CancellationToken cancellationToken = default)
        {
            await ProvidePermissionWithHttpInfoAsync(callId, toolDecisionRequestBody, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Submit a tool execution permission decision
        /// </summary>
        /// <remarks>
        /// Provides the user's approval or denial decision for a pending MCP (Model Context Protocol) tool execution request.  When an AI assistant attempts to invoke an external tool that requires explicit user consent,  the client receives a permission prompt via the SSE stream. This endpoint is used to submit the user's decision  so that the AI chat session can proceed accordingly.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="callId">The unique identifier of the pending tool execution call awaiting a permission decision.</param>
        /// <param name="toolDecisionRequestBody">The permission decision parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/provide-permission/">REST API Reference for ProvidePermission Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ProvidePermissionWithHttpInfoAsync(string callId, ToolDecisionRequestBody toolDecisionRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'callId' is set
            if (callId == null)
                throw new ApiException(400, "Missing required parameter 'callId' when calling ChatApi->ProvidePermission");

            // verify the required parameter 'toolDecisionRequestBody' is set
            if (toolDecisionRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'toolDecisionRequestBody' when calling ChatApi->ProvidePermission");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("callId", ClientUtils.ParameterToString(callId)); // path parameter
            if (toolDecisionRequestBody != null) localVarRequestOptions.Data = toolDecisionRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/ai/chats/tool-permissions/{callId}/decision", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ProvidePermission", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>ChatWrapper</returns>
        public ChatWrapper RenameChat(Guid chatId, RenameChatBody renameChatBody)
        {
            var localVarResponse = RenameChatWithHttpInfo(chatId, renameChatBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>ApiResponse of ChatWrapper</returns>
        public ApiResponse<ChatWrapper> RenameChatWithHttpInfo(Guid chatId, RenameChatBody renameChatBody)
        {
            // verify the required parameter 'renameChatBody' is set
            if (renameChatBody == null)
                throw new ApiException(400, "Missing required parameter 'renameChatBody' when calling ChatApi->RenameChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (renameChatBody != null) localVarRequestOptions.Data = renameChatBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<ChatWrapper>("/api/2.0/ai/chats/{chatId}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RenameChat", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>Task of ChatWrapper</returns>
        public async Task<ChatWrapper> RenameChatAsync(Guid chatId, RenameChatBody renameChatBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await RenameChatWithHttpInfoAsync(chatId, renameChatBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Rename an AI chat
        /// </summary>
        /// <remarks>
        /// Updates the display title of an existing AI chat session owned by the current user.  The new name must not exceed 255 characters.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chatId">The unique identifier of the AI chat session to rename.</param>
        /// <param name="renameChatBody">The new chat name.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/rename-chat/">REST API Reference for RenameChat Operation</seealso>
        /// <returns>Task of ApiResponse (ChatWrapper)</returns>
        public async Task<ApiResponse<ChatWrapper>> RenameChatWithHttpInfoAsync(Guid chatId, RenameChatBody renameChatBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'renameChatBody' is set
            if (renameChatBody == null)
                throw new ApiException(400, "Missing required parameter 'renameChatBody' when calling ChatApi->RenameChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("chatId", ClientUtils.ParameterToString(chatId)); // path parameter
            if (renameChatBody != null) localVarRequestOptions.Data = renameChatBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<ChatWrapper>("/api/2.0/ai/chats/{chatId}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("RenameChat", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>UserChatSettingsWrapper</returns>
        public UserChatSettingsWrapper SetUserChatsSettings(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody)
        {
            var localVarResponse = SetUserChatsSettingsWithHttpInfo(roomId, setUserChatSettingsRequestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>ApiResponse of UserChatSettingsWrapper</returns>
        public ApiResponse<UserChatSettingsWrapper> SetUserChatsSettingsWithHttpInfo(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody)
        {
            // verify the required parameter 'setUserChatSettingsRequestBody' is set
            if (setUserChatSettingsRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setUserChatSettingsRequestBody' when calling ChatApi->SetUserChatsSettings");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (setUserChatSettingsRequestBody != null) localVarRequestOptions.Data = setUserChatSettingsRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Put<UserChatSettingsWrapper>("/api/2.0/ai/rooms/{roomId}/chats/config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetUserChatsSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>Task of UserChatSettingsWrapper</returns>
        public async Task<UserChatSettingsWrapper> SetUserChatsSettingsAsync(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetUserChatsSettingsWithHttpInfoAsync(roomId, setUserChatSettingsRequestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user chat settings for a room
        /// </summary>
        /// <remarks>
        /// Saves the current user's personal AI chat preferences for the specified room.  Currently supports toggling the web search capability, which allows the AI assistant to search the internet when generating responses.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room whose chat settings are to be updated.</param>
        /// <param name="setUserChatSettingsRequestBody">The chat settings to apply.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-user-chats-settings/">REST API Reference for SetUserChatsSettings Operation</seealso>
        /// <returns>Task of ApiResponse (UserChatSettingsWrapper)</returns>
        public async Task<ApiResponse<UserChatSettingsWrapper>> SetUserChatsSettingsWithHttpInfoAsync(int roomId, SetUserChatSettingsRequestBody setUserChatSettingsRequestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'setUserChatSettingsRequestBody' is set
            if (setUserChatSettingsRequestBody == null)
                throw new ApiException(400, "Missing required parameter 'setUserChatSettingsRequestBody' when calling ChatApi->SetUserChatsSettings");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (setUserChatSettingsRequestBody != null) localVarRequestOptions.Data = setUserChatSettingsRequestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<UserChatSettingsWrapper>("/api/2.0/ai/rooms/{roomId}/chats/config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetUserChatsSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns></returns>
        public void StartNewChat(int roomId, StartNewChatBody startNewChatBody)
        {
            StartNewChatWithHttpInfo(roomId, startNewChatBody);
        }

        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> StartNewChatWithHttpInfo(int roomId, StartNewChatBody startNewChatBody)
        {
            // verify the required parameter 'startNewChatBody' is set
            if (startNewChatBody == null)
                throw new ApiException(400, "Missing required parameter 'startNewChatBody' when calling ChatApi->StartNewChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (startNewChatBody != null) localVarRequestOptions.Data = startNewChatBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/ai/rooms/{roomId}/chats", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartNewChat", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task StartNewChatAsync(int roomId, StartNewChatBody startNewChatBody, CancellationToken cancellationToken = default)
        {
            await StartNewChatWithHttpInfoAsync(roomId, startNewChatBody, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Start a new AI chat
        /// </summary>
        /// <remarks>
        /// Creates a new AI chat session within the specified room and sends the initial message to the configured AI provider.  The response is delivered as a Server-Sent Events (SSE) stream containing completion chunks (text deltas, tool calls, tool results, and message lifecycle events)  with periodic keep-alive pings every 5 seconds. File references can be included as context for the AI model.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomId">The identifier of the room in which to create the new AI chat session.</param>
        /// <param name="startNewChatBody">The initial message and optional file attachments.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-new-chat/">REST API Reference for StartNewChat Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> StartNewChatWithHttpInfoAsync(int roomId, StartNewChatBody startNewChatBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'startNewChatBody' is set
            if (startNewChatBody == null)
                throw new ApiException(400, "Missing required parameter 'startNewChatBody' when calling ChatApi->StartNewChat");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("roomId", ClientUtils.ParameterToString(roomId)); // path parameter
            if (startNewChatBody != null) localVarRequestOptions.Data = startNewChatBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(Configuration.Username) || !string.IsNullOrEmpty(Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(Configuration.Username + ":" + Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/ai/rooms/{roomId}/chats", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartNewChat", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
