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
    public interface IAssignmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>AiAssignmentMutationResult</returns>
        AiAssignmentMutationResult AiAssignmentsAssign(AiAssignmentsAssignRequest aiAssignmentsAssignRequest);

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>ApiResponse of AiAssignmentMutationResult</returns>
        ApiResponse<AiAssignmentMutationResult> AiAssignmentsAssignWithHttpInfo(AiAssignmentsAssignRequest aiAssignmentsAssignRequest);
        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>AiBulkAssignmentResult</returns>
        AiBulkAssignmentResult AiAssignmentsBulkAssign(Dictionary<string, string> requestBody);

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>ApiResponse of AiBulkAssignmentResult</returns>
        ApiResponse<AiBulkAssignmentResult> AiAssignmentsBulkAssignWithHttpInfo(Dictionary<string, string> requestBody);
        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiAssignmentsCascadeProfileDelete(string body);

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiAssignmentsCascadeProfileDeleteWithHttpInfo(string body);
        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        Dictionary<string, string> AiAssignmentsGetAllAssignments(string? entityId = default);

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        ApiResponse<Dictionary<string, string>> AiAssignmentsGetAllAssignmentsWithHttpInfo(string? entityId = default);
        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>string</returns>
        string AiAssignmentsGetAssignment(string actionType);

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AiAssignmentsGetAssignmentWithHttpInfo(string actionType);
        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>AiResolvedAssignment</returns>
        AiResolvedAssignment AiAssignmentsResolveForAction(string actionType, string? entityId = default);

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>ApiResponse of AiResolvedAssignment</returns>
        ApiResponse<AiResolvedAssignment> AiAssignmentsResolveForActionWithHttpInfo(string actionType, string? entityId = default);
        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>AiResolvedAssignment</returns>
        AiResolvedAssignment AiAssignmentsTryResolveForAction(string actionType, string? entityId = default);

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>ApiResponse of AiResolvedAssignment</returns>
        ApiResponse<AiResolvedAssignment> AiAssignmentsTryResolveForActionWithHttpInfo(string actionType, string? entityId = default);
        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiAssignmentsUnassign(string body);

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiAssignmentsUnassignWithHttpInfo(string body);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAssignmentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>Task of AiAssignmentMutationResult</returns>
        Task<AiAssignmentMutationResult> AiAssignmentsAssignAsync(AiAssignmentsAssignRequest aiAssignmentsAssignRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>Task of ApiResponse (AiAssignmentMutationResult)</returns>
        Task<ApiResponse<AiAssignmentMutationResult>> AiAssignmentsAssignWithHttpInfoAsync(AiAssignmentsAssignRequest aiAssignmentsAssignRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of AiBulkAssignmentResult</returns>
        Task<AiBulkAssignmentResult> AiAssignmentsBulkAssignAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of ApiResponse (AiBulkAssignmentResult)</returns>
        Task<ApiResponse<AiBulkAssignmentResult>> AiAssignmentsBulkAssignWithHttpInfoAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiAssignmentsCascadeProfileDeleteAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiAssignmentsCascadeProfileDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        Task<Dictionary<string, string>> AiAssignmentsGetAllAssignmentsAsync(string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        Task<ApiResponse<Dictionary<string, string>>> AiAssignmentsGetAllAssignmentsWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of string</returns>
        Task<string> AiAssignmentsGetAssignmentAsync(string actionType, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        Task<ApiResponse<string>> AiAssignmentsGetAssignmentWithHttpInfoAsync(string actionType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of AiResolvedAssignment</returns>
        Task<AiResolvedAssignment> AiAssignmentsResolveForActionAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (AiResolvedAssignment)</returns>
        Task<ApiResponse<AiResolvedAssignment>> AiAssignmentsResolveForActionWithHttpInfoAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of AiResolvedAssignment</returns>
        Task<AiResolvedAssignment> AiAssignmentsTryResolveForActionAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (AiResolvedAssignment)</returns>
        Task<ApiResponse<AiResolvedAssignment>> AiAssignmentsTryResolveForActionWithHttpInfoAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiAssignmentsUnassignAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiAssignmentsUnassignWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAssignmentsApi : IAssignmentsApiSync, IAssignmentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssignmentsApi : IDisposable, IAssignmentsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public AssignmentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public AssignmentsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public AssignmentsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public AssignmentsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class.
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
        public AssignmentsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class using a Configuration object.
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
        public AssignmentsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="AssignmentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AssignmentsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>AiAssignmentMutationResult</returns>
        public AiAssignmentMutationResult AiAssignmentsAssign(AiAssignmentsAssignRequest aiAssignmentsAssignRequest)
        {
            var localVarResponse = AiAssignmentsAssignWithHttpInfo(aiAssignmentsAssignRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>ApiResponse of AiAssignmentMutationResult</returns>
        public ApiResponse<AiAssignmentMutationResult> AiAssignmentsAssignWithHttpInfo(AiAssignmentsAssignRequest aiAssignmentsAssignRequest)
        {
            // verify the required parameter 'aiAssignmentsAssignRequest' is set
            if (aiAssignmentsAssignRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAssignmentsAssignRequest' when calling AssignmentsApi->AiAssignmentsAssign");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAssignmentsAssignRequest != null) localVarRequestOptions.Data = aiAssignmentsAssignRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiAssignmentMutationResult>("/api/2.0/ai/assignments/assign", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsAssign", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>Task of AiAssignmentMutationResult</returns>
        public async Task<AiAssignmentMutationResult> AiAssignmentsAssignAsync(AiAssignmentsAssignRequest aiAssignmentsAssignRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsAssignWithHttpInfoAsync(aiAssignmentsAssignRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Assign
        /// </summary>
        /// <remarks>
        /// Binds a profile to an AI action, creating the assignment or updating it in place. The profile's declared capabilities are validated against the action, except for the `Default` slot.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiAssignmentsAssignRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-assign/">REST API Reference for AiAssignmentsAssign Operation</seealso>
        /// <returns>Task of ApiResponse (AiAssignmentMutationResult)</returns>
        public async Task<ApiResponse<AiAssignmentMutationResult>> AiAssignmentsAssignWithHttpInfoAsync(AiAssignmentsAssignRequest aiAssignmentsAssignRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiAssignmentsAssignRequest' is set
            if (aiAssignmentsAssignRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiAssignmentsAssignRequest' when calling AssignmentsApi->AiAssignmentsAssign");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiAssignmentsAssignRequest != null) localVarRequestOptions.Data = aiAssignmentsAssignRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiAssignmentMutationResult>("/api/2.0/ai/assignments/assign", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsAssign", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>AiBulkAssignmentResult</returns>
        public AiBulkAssignmentResult AiAssignmentsBulkAssign(Dictionary<string, string> requestBody)
        {
            var localVarResponse = AiAssignmentsBulkAssignWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>ApiResponse of AiBulkAssignmentResult</returns>
        public ApiResponse<AiBulkAssignmentResult> AiAssignmentsBulkAssignWithHttpInfo(Dictionary<string, string> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AssignmentsApi->AiAssignmentsBulkAssign");

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
            var localVarResponse = Client.Put<AiBulkAssignmentResult>("/api/2.0/ai/assignments/bulk-assign", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsBulkAssign", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of AiBulkAssignmentResult</returns>
        public async Task<AiBulkAssignmentResult> AiAssignmentsBulkAssignAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsBulkAssignWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Bulk assign
        /// </summary>
        /// <remarks>
        /// Applies many action-to-profile bindings at once. Every entry is validated first and nothing is written if any of them fails, so the assignment set is never left half-written.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-bulk-assign/">REST API Reference for AiAssignmentsBulkAssign Operation</seealso>
        /// <returns>Task of ApiResponse (AiBulkAssignmentResult)</returns>
        public async Task<ApiResponse<AiBulkAssignmentResult>> AiAssignmentsBulkAssignWithHttpInfoAsync(Dictionary<string, string> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling AssignmentsApi->AiAssignmentsBulkAssign");

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiBulkAssignmentResult>("/api/2.0/ai/assignments/bulk-assign", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsBulkAssign", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiAssignmentsCascadeProfileDelete(string body)
        {
            var localVarResponse = AiAssignmentsCascadeProfileDeleteWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiAssignmentsCascadeProfileDeleteWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->AiAssignmentsCascadeProfileDelete");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/assignments/cascade-profile-delete", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsCascadeProfileDelete", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiAssignmentsCascadeProfileDeleteAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsCascadeProfileDeleteWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Cascade profile delete
        /// </summary>
        /// <remarks>
        /// Cleans up the assignments pointing at a profile that is about to be deleted: the `Default` slot is promoted to the first remaining profile (or dropped when none is left), and every other slot holding that profile is unbound.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-cascade-profile-delete/">REST API Reference for AiAssignmentsCascadeProfileDelete Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiAssignmentsCascadeProfileDeleteWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->AiAssignmentsCascadeProfileDelete");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/assignments/cascade-profile-delete", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsCascadeProfileDelete", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Dictionary&lt;string, string&gt;</returns>
        public Dictionary<string, string> AiAssignmentsGetAllAssignments(string? entityId = default)
        {
            var localVarResponse = AiAssignmentsGetAllAssignmentsWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, string&gt;</returns>
        public ApiResponse<Dictionary<string, string>> AiAssignmentsGetAllAssignmentsWithHttpInfo(string? entityId = default)
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


            // make the HTTP request
            var localVarResponse = Client.Get<Dictionary<string, string>>("/api/2.0/ai/assignments/get-all-assignments", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsGetAllAssignments", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, string&gt;</returns>
        public async Task<Dictionary<string, string>> AiAssignmentsGetAllAssignmentsAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsGetAllAssignmentsWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all assignments
        /// </summary>
        /// <remarks>
        /// Returns the full action-to-profile assignment map of the scope.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-all-assignments/">REST API Reference for AiAssignmentsGetAllAssignments Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, string&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, string>>> AiAssignmentsGetAllAssignmentsWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default)
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


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Dictionary<string, string>>("/api/2.0/ai/assignments/get-all-assignments", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsGetAllAssignments", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>string</returns>
        public string AiAssignmentsGetAssignment(string actionType)
        {
            var localVarResponse = AiAssignmentsGetAssignmentWithHttpInfo(actionType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse<string> AiAssignmentsGetAssignmentWithHttpInfo(string actionType)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->AiAssignmentsGetAssignment");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));


            // make the HTTP request
            var localVarResponse = Client.Get<string>("/api/2.0/ai/assignments/get-assignment", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsGetAssignment", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of string</returns>
        public async Task<string> AiAssignmentsGetAssignmentAsync(string actionType, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsGetAssignmentWithHttpInfoAsync(actionType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get assignment
        /// </summary>
        /// <remarks>
        /// Returns the profile bound to one AI action, without the `Default` fallback.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-get-assignment/">REST API Reference for AiAssignmentsGetAssignment Operation</seealso>
        /// <returns>Task of ApiResponse (string)</returns>
        public async Task<ApiResponse<string>> AiAssignmentsGetAssignmentWithHttpInfoAsync(string actionType, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->AiAssignmentsGetAssignment");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<string>("/api/2.0/ai/assignments/get-assignment", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsGetAssignment", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>AiResolvedAssignment</returns>
        public AiResolvedAssignment AiAssignmentsResolveForAction(string actionType, string? entityId = default)
        {
            var localVarResponse = AiAssignmentsResolveForActionWithHttpInfo(actionType, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>ApiResponse of AiResolvedAssignment</returns>
        public ApiResponse<AiResolvedAssignment> AiAssignmentsResolveForActionWithHttpInfo(string actionType, string? entityId = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->AiAssignmentsResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<AiResolvedAssignment>("/api/2.0/ai/assignments/resolve-for-action", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsResolveForAction", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of AiResolvedAssignment</returns>
        public async Task<AiResolvedAssignment> AiAssignmentsResolveForActionAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsResolveForActionWithHttpInfoAsync(actionType, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action, falling back to the `Default` slot when the action itself has none. Fails when neither slot is set or the bound profile no longer exists - use `try-resolve-for-action` for an empty answer instead.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-resolve-for-action/">REST API Reference for AiAssignmentsResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (AiResolvedAssignment)</returns>
        public async Task<ApiResponse<AiResolvedAssignment>> AiAssignmentsResolveForActionWithHttpInfoAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->AiAssignmentsResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiResolvedAssignment>("/api/2.0/ai/assignments/resolve-for-action", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsResolveForAction", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>AiResolvedAssignment</returns>
        public AiResolvedAssignment AiAssignmentsTryResolveForAction(string actionType, string? entityId = default)
        {
            var localVarResponse = AiAssignmentsTryResolveForActionWithHttpInfo(actionType, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>ApiResponse of AiResolvedAssignment</returns>
        public ApiResponse<AiResolvedAssignment> AiAssignmentsTryResolveForActionWithHttpInfo(string actionType, string? entityId = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->AiAssignmentsTryResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<AiResolvedAssignment>("/api/2.0/ai/assignments/try-resolve-for-action", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsTryResolveForAction", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of AiResolvedAssignment</returns>
        public async Task<AiResolvedAssignment> AiAssignmentsTryResolveForActionAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsTryResolveForActionWithHttpInfoAsync(actionType, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Try resolve for action
        /// </summary>
        /// <remarks>
        /// Resolves the profile bound to an AI action exactly like `resolve-for-action`, but answers with an empty result instead of failing when nothing is configured.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionType">The AI action the request applies to - one of Default, Chat, Code, Summarization, Translation, TextAnalyze, ImageGeneration, OCR, Vision.</param>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-try-resolve-for-action/">REST API Reference for AiAssignmentsTryResolveForAction Operation</seealso>
        /// <returns>Task of ApiResponse (AiResolvedAssignment)</returns>
        public async Task<ApiResponse<AiResolvedAssignment>> AiAssignmentsTryResolveForActionWithHttpInfoAsync(string actionType, string? entityId = default, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'actionType' is set
            if (actionType == null)
                throw new ApiException(400, "Missing required parameter 'actionType' when calling AssignmentsApi->AiAssignmentsTryResolveForAction");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "actionType", actionType));
            if (entityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<AiResolvedAssignment>("/api/2.0/ai/assignments/try-resolve-for-action", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsTryResolveForAction", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiAssignmentsUnassign(string body)
        {
            var localVarResponse = AiAssignmentsUnassignWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiAssignmentsUnassignWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->AiAssignmentsUnassign");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/assignments/unassign", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsUnassign", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiAssignmentsUnassignAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiAssignmentsUnassignWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unassign
        /// </summary>
        /// <remarks>
        /// Removes the profile binding of an AI action. Does nothing when that slot is already empty.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-assignments-unassign/">REST API Reference for AiAssignmentsUnassign Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiAssignmentsUnassignWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AssignmentsApi->AiAssignmentsUnassign");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/assignments/unassign", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiAssignmentsUnassign", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
