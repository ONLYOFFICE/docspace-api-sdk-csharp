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
    public interface IWebSearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiWebSearchClear(string body);

        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiWebSearchClearWithHttpInfo(string body);
        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>AiWebSearchMutationResult</returns>
        AiWebSearchMutationResult AiWebSearchConfigure(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);

        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchMutationResult</returns>
        ApiResponse<AiWebSearchMutationResult> AiWebSearchConfigureWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);
        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>AiWebSearchConfig</returns>
        AiWebSearchConfig AiWebSearchGetActiveConfig(string? entityId = default);

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchConfig</returns>
        ApiResponse<AiWebSearchConfig> AiWebSearchGetActiveConfigWithHttpInfo(string? entityId = default);
        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>bool</returns>
        bool AiWebSearchIsConfigured(string? entityId = default);

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> AiWebSearchIsConfiguredWithHttpInfo(string? entityId = default);
        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> AiWebSearchPassthroughContents(Dictionary<string, Object> requestBody);

        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> AiWebSearchPassthroughContentsWithHttpInfo(Dictionary<string, Object> requestBody);
        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> AiWebSearchPassthroughSearch(Dictionary<string, Object> requestBody);

        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> AiWebSearchPassthroughSearchWithHttpInfo(Dictionary<string, Object> requestBody);
        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiWebSearchSetActiveConfig(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiWebSearchSetActiveConfigWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest);
        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>AiProfilesTestConnection200Response</returns>
        AiProfilesTestConnection200Response AiWebSearchTestConnection(AiWebSearchConfig aiWebSearchConfig);

        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>ApiResponse of AiProfilesTestConnection200Response</returns>
        ApiResponse<AiProfilesTestConnection200Response> AiWebSearchTestConnectionWithHttpInfo(AiWebSearchConfig aiWebSearchConfig);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebSearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiWebSearchClearAsync(string body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiWebSearchClearWithHttpInfoAsync(string body, CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of AiWebSearchMutationResult</returns>
        Task<AiWebSearchMutationResult> AiWebSearchConfigureAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchMutationResult)</returns>
        Task<ApiResponse<AiWebSearchMutationResult>> AiWebSearchConfigureWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of AiWebSearchConfig</returns>
        Task<AiWebSearchConfig> AiWebSearchGetActiveConfigAsync(string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchConfig)</returns>
        Task<ApiResponse<AiWebSearchConfig>> AiWebSearchGetActiveConfigWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> AiWebSearchIsConfiguredAsync(string? entityId = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> AiWebSearchIsConfiguredWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        Task<Dictionary<string, Object>> AiWebSearchPassthroughContentsAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        Task<ApiResponse<Dictionary<string, Object>>> AiWebSearchPassthroughContentsWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        Task<Dictionary<string, Object>> AiWebSearchPassthroughSearchAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);

        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        Task<ApiResponse<Dictionary<string, Object>>> AiWebSearchPassthroughSearchWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiWebSearchSetActiveConfigAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiWebSearchSetActiveConfigWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of AiProfilesTestConnection200Response</returns>
        Task<AiProfilesTestConnection200Response> AiWebSearchTestConnectionAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesTestConnection200Response)</returns>
        Task<ApiResponse<AiProfilesTestConnection200Response>> AiWebSearchTestConnectionWithHttpInfoAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWebSearchApi : IWebSearchApiSync, IWebSearchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebSearchApi : IDisposable, IWebSearchApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public WebSearchApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public WebSearchApi(string basePath)
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
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public WebSearchApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public WebSearchApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class.
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
        public WebSearchApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class using a Configuration object.
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
        public WebSearchApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="WebSearchApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public WebSearchApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiWebSearchClear(string body)
        {
            var localVarResponse = AiWebSearchClearWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiWebSearchClearWithHttpInfo(string body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebSearchApi->AiWebSearchClear");

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
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/web-search/clear", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchClear", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiWebSearchClearAsync(string body, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchClearWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Clear the web-search configuration
        /// </summary>
        /// <remarks>
        /// Removes the portal's web-search configuration, after which web search is unavailable everywhere it was not configured separately. This is not scoped: it takes no `entityId` and any body sent with it is ignored, so it cannot be used to clear one room's configuration. Clearing an already-unconfigured portal is not an error and the call answers success either way. The stored provider key is destroyed with the configuration and has to be entered again.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Ignored. The operation always clears the portal-wide configuration, so send an empty body; a value here does not scope it to a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-clear/">REST API Reference for AiWebSearchClear Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiWebSearchClearWithHttpInfoAsync(string body, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WebSearchApi->AiWebSearchClear");

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

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/web-search/clear", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchClear", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>AiWebSearchMutationResult</returns>
        public AiWebSearchMutationResult AiWebSearchConfigure(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            var localVarResponse = AiWebSearchConfigureWithHttpInfo(aiWebSearchConfigureRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchMutationResult</returns>
        public ApiResponse<AiWebSearchMutationResult> AiWebSearchConfigureWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchConfigure");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiWebSearchMutationResult>("/api/2.0/ai/web-search/configure", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchConfigure", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of AiWebSearchMutationResult</returns>
        public async Task<AiWebSearchMutationResult> AiWebSearchConfigureAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchConfigureWithHttpInfoAsync(aiWebSearchConfigureRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Configure and verify web search
        /// </summary>
        /// <remarks>
        /// Validates a web-search configuration against the live provider and stores it only if the provider answers, which makes it the safe way to save a form in one step. `entityId` scopes the configuration to a room and has to name one the caller can open; omitting it configures the portal. A `baseUrl` pointing at a private network address is refused. Use `PUT api/2.0/ai/web-search/set-active-config` when the configuration should be stored without a provider round trip.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-configure/">REST API Reference for AiWebSearchConfigure Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchMutationResult)</returns>
        public async Task<ApiResponse<AiWebSearchMutationResult>> AiWebSearchConfigureWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchConfigure");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiWebSearchMutationResult>("/api/2.0/ai/web-search/configure", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchConfigure", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>AiWebSearchConfig</returns>
        public AiWebSearchConfig AiWebSearchGetActiveConfig(string? entityId = default)
        {
            var localVarResponse = AiWebSearchGetActiveConfigWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiWebSearchConfig</returns>
        public ApiResponse<AiWebSearchConfig> AiWebSearchGetActiveConfigWithHttpInfo(string? entityId = default)
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
            var localVarResponse = Client.Get<AiWebSearchConfig>("/api/2.0/ai/web-search/get-active-config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchGetActiveConfig", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of AiWebSearchConfig</returns>
        public async Task<AiWebSearchConfig> AiWebSearchGetActiveConfigAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchGetActiveConfigWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get active config
        /// </summary>
        /// <remarks>
        /// Returns the web-search configuration in force for a scope - the provider, its endpoint and its settings. `entityId` picks a room and has to name one the caller can open; omitting it reads the portal-wide configuration, and a room with none of its own falls back to that. An unconfigured scope answers an empty result rather than 404. The provider key is not part of the answer, so a client cannot read it back after storing it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-get-active-config/">REST API Reference for AiWebSearchGetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiWebSearchConfig)</returns>
        public async Task<ApiResponse<AiWebSearchConfig>> AiWebSearchGetActiveConfigWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<AiWebSearchConfig>("/api/2.0/ai/web-search/get-active-config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchGetActiveConfig", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>bool</returns>
        public bool AiWebSearchIsConfigured(string? entityId = default)
        {
            var localVarResponse = AiWebSearchIsConfiguredWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> AiWebSearchIsConfiguredWithHttpInfo(string? entityId = default)
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
            var localVarResponse = Client.Get<bool>("/api/2.0/ai/web-search/is-configured", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchIsConfigured", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> AiWebSearchIsConfiguredAsync(string? entityId = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchIsConfiguredWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is configured
        /// </summary>
        /// <remarks>
        /// Tells whether web search is available in a scope, as a bare boolean, which is the cheap check for hiding or showing the feature. `entityId` picks a room and has to name one the caller can open. It reports the same state as `GET api/2.0/ai/web-search/get-active-config` without transferring the configuration itself. A true answer means a provider is stored, not that the provider is currently reachable - probe that with `POST api/2.0/ai/web-search/test-connection`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId">The DocSpace entity the request is scoped to - the room, folder or agent workspace the chat is invoked from. Omit for the portal-wide scope. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-is-configured/">REST API Reference for AiWebSearchIsConfigured Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> AiWebSearchIsConfiguredWithHttpInfoAsync(string? entityId = default, CancellationToken cancellationToken = default)
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

            var localVarResponse = await AsynchronousClient.GetAsync<bool>("/api/2.0/ai/web-search/is-configured", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchIsConfigured", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> AiWebSearchPassthroughContents(Dictionary<string, Object> requestBody)
        {
            var localVarResponse = AiWebSearchPassthroughContentsWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse<Dictionary<string, Object>> AiWebSearchPassthroughContentsWithHttpInfo(Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling WebSearchApi->AiWebSearchPassthroughContents");

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
            var localVarResponse = Client.Post<Dictionary<string, Object>>("/api/2.0/ai/websearch/v1/contents", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchPassthroughContents", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async Task<Dictionary<string, Object>> AiWebSearchPassthroughContentsAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchPassthroughContentsWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Web page contents passthrough
        /// </summary>
        /// <remarks>
        /// Fetches the contents of web pages on behalf of the document editor's AI plugin, against the portal's active web-search provider, exactly as the search passthrough does — including the `entityId` / `entityKind` billing attribution. The portal-wide configuration is used and a portal without one answers 404. The provider's status, body and content type are relayed verbatim, so its 429 and its failures surface unchanged. This is the follow-up to `POST api/2.0/ai/websearch/v1/search`, which returns the results whose contents this operation retrieves.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A page-contents request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-contents/">REST API Reference for AiWebSearchPassthroughContents Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, Object>>> AiWebSearchPassthroughContentsWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling WebSearchApi->AiWebSearchPassthroughContents");

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

            var localVarResponse = await AsynchronousClient.PostAsync<Dictionary<string, Object>>("/api/2.0/ai/websearch/v1/contents", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchPassthroughContents", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> AiWebSearchPassthroughSearch(Dictionary<string, Object> requestBody)
        {
            var localVarResponse = AiWebSearchPassthroughSearchWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse<Dictionary<string, Object>> AiWebSearchPassthroughSearchWithHttpInfo(Dictionary<string, Object> requestBody)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling WebSearchApi->AiWebSearchPassthroughSearch");

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
            var localVarResponse = Client.Post<Dictionary<string, Object>>("/api/2.0/ai/websearch/v1/search", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchPassthroughSearch", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async Task<Dictionary<string, Object>> AiWebSearchPassthroughSearchAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchPassthroughSearchWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Web search passthrough
        /// </summary>
        /// <remarks>
        /// Runs a web search on behalf of the document editor's AI plugin, which holds only a placeholder configuration - the portal's active provider and its key are resolved here, so neither ever reaches the browser. The portal-wide configuration is used, and a portal without one answers 404. The `entityId` and `entityKind` query parameters name the document the search is billed to; with the ONLYOFFICE provider the entry is resolved under the caller's credentials and sent to the gateway as the request `metadata` (`source_id` / `source_type` / `source_title`), and an entry the caller cannot open sends none. The provider's own status, body and content type are relayed as they stand, so a provider that rate-limits answers 429 and one that is unreachable answers 502. Closing the connection aborts the upstream request.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">A search request in the shape the portal's active web-search provider expects, forwarded to it unchanged. The endpoint and the key come from the stored configuration and must not be sent here.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-passthrough-search/">REST API Reference for AiWebSearchPassthroughSearch Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, Object>>> AiWebSearchPassthroughSearchWithHttpInfoAsync(Dictionary<string, Object> requestBody, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'requestBody' is set
            if (requestBody == null)
                throw new ApiException(400, "Missing required parameter 'requestBody' when calling WebSearchApi->AiWebSearchPassthroughSearch");

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

            var localVarResponse = await AsynchronousClient.PostAsync<Dictionary<string, Object>>("/api/2.0/ai/websearch/v1/search", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchPassthroughSearch", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiWebSearchSetActiveConfig(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            var localVarResponse = AiWebSearchSetActiveConfigWithHttpInfo(aiWebSearchConfigureRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiWebSearchSetActiveConfigWithHttpInfo(AiWebSearchConfigureRequest aiWebSearchConfigureRequest)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchSetActiveConfig");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/web-search/set-active-config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchSetActiveConfig", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiWebSearchSetActiveConfigAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchSetActiveConfigWithHttpInfoAsync(aiWebSearchConfigureRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set active config
        /// </summary>
        /// <remarks>
        /// Stores a web-search configuration without contacting the provider first, for a form that has already validated its input or for restoring a known-good configuration. `entityId` scopes it to a room and has to name one the caller can open. A `baseUrl` pointing at a private network address is still refused, because that check is local. Nothing guarantees the stored provider works: follow up with `POST api/2.0/ai/web-search/test-connection`, or use `PUT api/2.0/ai/web-search/configure` to have the store gated on a live probe.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfigureRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-set-active-config/">REST API Reference for AiWebSearchSetActiveConfig Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiWebSearchSetActiveConfigWithHttpInfoAsync(AiWebSearchConfigureRequest aiWebSearchConfigureRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiWebSearchConfigureRequest' is set
            if (aiWebSearchConfigureRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfigureRequest' when calling WebSearchApi->AiWebSearchSetActiveConfig");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfigureRequest != null) localVarRequestOptions.Data = aiWebSearchConfigureRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/web-search/set-active-config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchSetActiveConfig", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>AiProfilesTestConnection200Response</returns>
        public AiProfilesTestConnection200Response AiWebSearchTestConnection(AiWebSearchConfig aiWebSearchConfig)
        {
            var localVarResponse = AiWebSearchTestConnectionWithHttpInfo(aiWebSearchConfig);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>ApiResponse of AiProfilesTestConnection200Response</returns>
        public ApiResponse<AiProfilesTestConnection200Response> AiWebSearchTestConnectionWithHttpInfo(AiWebSearchConfig aiWebSearchConfig)
        {
            // verify the required parameter 'aiWebSearchConfig' is set
            if (aiWebSearchConfig == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfig' when calling WebSearchApi->AiWebSearchTestConnection");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfig != null) localVarRequestOptions.Data = aiWebSearchConfig;


            // make the HTTP request
            var localVarResponse = Client.Post<AiProfilesTestConnection200Response>("/api/2.0/ai/web-search/test-connection", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchTestConnection", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of AiProfilesTestConnection200Response</returns>
        public async Task<AiProfilesTestConnection200Response> AiWebSearchTestConnectionAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiWebSearchTestConnectionWithHttpInfoAsync(aiWebSearchConfig, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Test a web-search provider
        /// </summary>
        /// <remarks>
        /// Probes a web-search configuration against the live provider and reports the outcome, storing nothing - this is what a Test button calls so that a failure commits no state. The configuration is taken from the request rather than from storage, so credentials that were never saved can be checked. A `baseUrl` pointing at a private network address is refused before any request leaves the portal. The verdict is carried in the body rather than in the status, so a failed probe still answers 200 and the caller has to read the payload.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiWebSearchConfig">Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-web-search-test-connection/">REST API Reference for AiWebSearchTestConnection Operation</seealso>
        /// <returns>Task of ApiResponse (AiProfilesTestConnection200Response)</returns>
        public async Task<ApiResponse<AiProfilesTestConnection200Response>> AiWebSearchTestConnectionWithHttpInfoAsync(AiWebSearchConfig aiWebSearchConfig, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiWebSearchConfig' is set
            if (aiWebSearchConfig == null)
                throw new ApiException(400, "Missing required parameter 'aiWebSearchConfig' when calling WebSearchApi->AiWebSearchTestConnection");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiWebSearchConfig != null) localVarRequestOptions.Data = aiWebSearchConfig;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiProfilesTestConnection200Response>("/api/2.0/ai/web-search/test-connection", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiWebSearchTestConnection", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
