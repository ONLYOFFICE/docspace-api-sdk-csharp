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
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>AiSettingsWrapper</returns>
        AiSettingsWrapper AiSettingsGet();

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>ApiResponse of AiSettingsWrapper</returns>
        ApiResponse<AiSettingsWrapper> AiSettingsGetWithHttpInfo();
        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiSettingsGetToolMode();

        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiSettingsGetToolModeWithHttpInfo();
        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>AiUserSettingsWrapper</returns>
        AiUserSettingsWrapper AiSettingsGetUser();

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>ApiResponse of AiUserSettingsWrapper</returns>
        ApiResponse<AiUserSettingsWrapper> AiSettingsGetUserWithHttpInfo();
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        AiVectorizationSettingsWrapper AiSettingsGetVectorization();

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        ApiResponse<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationWithHttpInfo();
        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiSettingsSetToolMode(Dictionary<string, Object> aiSettingsSetToolModeRequest);

        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiSettingsSetToolModeWithHttpInfo(Dictionary<string, Object> aiSettingsSetToolModeRequest);
        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>AiUserSettingsWrapper</returns>
        AiUserSettingsWrapper AiSettingsSetUser(Dictionary<string, Object> aiSettingsSetUserRequest);

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>ApiResponse of AiUserSettingsWrapper</returns>
        ApiResponse<AiUserSettingsWrapper> AiSettingsSetUserWithHttpInfo(Dictionary<string, Object> aiSettingsSetUserRequest);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        AiVectorizationSettingsWrapper AiSettingsSetVectorization(Dictionary<string, Object> aiSettingsSetVectorizationRequest);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        ApiResponse<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationWithHttpInfo(Dictionary<string, Object> aiSettingsSetVectorizationRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of AiSettingsWrapper</returns>
        Task<AiSettingsWrapper> AiSettingsGetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiSettingsWrapper)</returns>
        Task<ApiResponse<AiSettingsWrapper>> AiSettingsGetWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiSettingsGetToolModeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiSettingsGetToolModeWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of AiUserSettingsWrapper</returns>
        Task<AiUserSettingsWrapper> AiSettingsGetUserAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiUserSettingsWrapper)</returns>
        Task<ApiResponse<AiUserSettingsWrapper>> AiSettingsGetUserWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        Task<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsGetVectorizationWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiSettingsSetToolModeAsync(Dictionary<string, Object> aiSettingsSetToolModeRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiSettingsSetToolModeWithHttpInfoAsync(Dictionary<string, Object> aiSettingsSetToolModeRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of AiUserSettingsWrapper</returns>
        Task<AiUserSettingsWrapper> AiSettingsSetUserAsync(Dictionary<string, Object> aiSettingsSetUserRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiUserSettingsWrapper)</returns>
        Task<ApiResponse<AiUserSettingsWrapper>> AiSettingsSetUserWithHttpInfoAsync(Dictionary<string, Object> aiSettingsSetUserRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        Task<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationAsync(Dictionary<string, Object> aiSettingsSetVectorizationRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsSetVectorizationWithHttpInfoAsync(Dictionary<string, Object> aiSettingsSetVectorizationRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi : ISettingsApiSync, ISettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsApi : IDisposable, ISettingsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public SettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public SettingsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public SettingsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public SettingsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
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
        public SettingsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class using a Configuration object.
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
        public SettingsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SettingsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>AiSettingsWrapper</returns>
        public AiSettingsWrapper AiSettingsGet()
        {
            var localVarResponse = AiSettingsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>ApiResponse of AiSettingsWrapper</returns>
        public ApiResponse<AiSettingsWrapper> AiSettingsGetWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = Client.Get<AiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGet", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of AiSettingsWrapper</returns>
        public async Task<AiSettingsWrapper> AiSettingsGetAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get AI settings
        /// </summary>
        /// <remarks>
        /// Reports the portal's AI configuration and whether AI is usable at all, which is the first call a client makes before offering any AI feature. It takes no parameters and is proxied unchanged to the DocSpace AI service, so the answer is that service's settings payload. Among other things it says whether the portal runs on the central AI gateway, which decides whether provider profiles can be edited here at all. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get/">REST API Reference for AiSettingsGet Operation</seealso>
        /// <returns>Task of ApiResponse (AiSettingsWrapper)</returns>
        public async Task<ApiResponse<AiSettingsWrapper>> AiSettingsGetWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSettingsWrapper>("/api/2.0/ai/config", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGet", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiSettingsGetToolMode()
        {
            var localVarResponse = AiSettingsGetToolModeWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiSettingsGetToolModeWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = Client.Get<AiSuccessResponse>("/api/2.0/ai/config/tool-mode", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetToolMode", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiSettingsGetToolModeAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetToolModeWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the tool permission mode
        /// </summary>
        /// <remarks>
        /// Returns the calling user's tool permission mode as the DocSpace AI service spells it - `{ mode }` with the service's `ToolPermissionMode` enum (`Ask`, `Auto`, `Allow`), proxied unchanged. The chat reads the same value in its own spelling through `GET api/2.0/ai/preferences/get-tool-permission-mode`. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-tool-mode/">REST API Reference for AiSettingsGetToolMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiSettingsGetToolModeWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<AiSuccessResponse>("/api/2.0/ai/config/tool-mode", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetToolMode", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>AiUserSettingsWrapper</returns>
        public AiUserSettingsWrapper AiSettingsGetUser()
        {
            var localVarResponse = AiSettingsGetUserWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>ApiResponse of AiUserSettingsWrapper</returns>
        public ApiResponse<AiUserSettingsWrapper> AiSettingsGetUserWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = Client.Get<AiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetUser", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of AiUserSettingsWrapper</returns>
        public async Task<AiUserSettingsWrapper> AiSettingsGetUserAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetUserWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get user AI settings
        /// </summary>
        /// <remarks>
        /// Returns the AI settings of the calling user, as opposed to the portal-wide ones. It takes no parameters - the user is the authenticated caller, and there is no way to read somebody else's settings - and is proxied unchanged to the DocSpace AI service. Use `GET api/2.0/ai/config` for the portal-wide configuration. This is a read-only operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-user/">REST API Reference for AiSettingsGetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiUserSettingsWrapper)</returns>
        public async Task<ApiResponse<AiUserSettingsWrapper>> AiSettingsGetUserWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<AiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetUser", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        public AiVectorizationSettingsWrapper AiSettingsGetVectorization()
        {
            var localVarResponse = AiSettingsGetVectorizationWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        public ApiResponse<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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
            var localVarResponse = Client.Get<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetVectorization", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        public async Task<AiVectorizationSettingsWrapper> AiSettingsGetVectorizationAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsGetVectorizationWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get vectorization settings
        /// </summary>
        /// <remarks>
        /// Returns the portal's vectorization settings - the embedding provider and the options used when portal content is indexed for retrieval. It takes no parameters and is proxied unchanged to the DocSpace AI service. Vectorization is a portal-wide setting, so there is no room-scoped form of it. Change it with `PUT api/2.0/ai/config/vectorization`.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-get-vectorization/">REST API Reference for AiSettingsGetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsGetVectorizationWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


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

            var localVarResponse = await AsynchronousClient.GetAsync<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsGetVectorization", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiSettingsSetToolMode(Dictionary<string, Object> aiSettingsSetToolModeRequest)
        {
            var localVarResponse = AiSettingsSetToolModeWithHttpInfo(aiSettingsSetToolModeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiSettingsSetToolModeWithHttpInfo(Dictionary<string, Object> aiSettingsSetToolModeRequest)
        {
            // verify the required parameter 'aiSettingsSetToolModeRequest' is set
            if (aiSettingsSetToolModeRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSettingsSetToolModeRequest' when calling SettingsApi->AiSettingsSetToolMode");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSettingsSetToolModeRequest != null) localVarRequestOptions.Data = aiSettingsSetToolModeRequest;

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
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/config/tool-mode", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetToolMode", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiSettingsSetToolModeAsync(Dictionary<string, Object> aiSettingsSetToolModeRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsSetToolModeWithHttpInfoAsync(aiSettingsSetToolModeRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the tool permission mode
        /// </summary>
        /// <remarks>
        /// Stores the calling user's tool permission mode and returns the stored result. The body (`{ mode }`) is proxied unchanged to the DocSpace AI service, which rejects a value outside its `ToolPermissionMode` enum. The mode applies to every chat of the user in the portal.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetToolModeRequest">`{ mode }` with the AI service's `ToolPermissionMode` enum, proxied unchanged; the service rejects anything outside the enum.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-tool-mode/">REST API Reference for AiSettingsSetToolMode Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiSettingsSetToolModeWithHttpInfoAsync(Dictionary<string, Object> aiSettingsSetToolModeRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSettingsSetToolModeRequest' is set
            if (aiSettingsSetToolModeRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSettingsSetToolModeRequest' when calling SettingsApi->AiSettingsSetToolMode");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSettingsSetToolModeRequest != null) localVarRequestOptions.Data = aiSettingsSetToolModeRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/config/tool-mode", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetToolMode", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>AiUserSettingsWrapper</returns>
        public AiUserSettingsWrapper AiSettingsSetUser(Dictionary<string, Object> aiSettingsSetUserRequest)
        {
            var localVarResponse = AiSettingsSetUserWithHttpInfo(aiSettingsSetUserRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>ApiResponse of AiUserSettingsWrapper</returns>
        public ApiResponse<AiUserSettingsWrapper> AiSettingsSetUserWithHttpInfo(Dictionary<string, Object> aiSettingsSetUserRequest)
        {
            // verify the required parameter 'aiSettingsSetUserRequest' is set
            if (aiSettingsSetUserRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSettingsSetUserRequest' when calling SettingsApi->AiSettingsSetUser");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSettingsSetUserRequest != null) localVarRequestOptions.Data = aiSettingsSetUserRequest;

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
            var localVarResponse = Client.Put<AiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetUser", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of AiUserSettingsWrapper</returns>
        public async Task<AiUserSettingsWrapper> AiSettingsSetUserAsync(Dictionary<string, Object> aiSettingsSetUserRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsSetUserWithHttpInfoAsync(aiSettingsSetUserRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update user AI settings
        /// </summary>
        /// <remarks>
        /// Replaces the AI settings of the calling user and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value comes back with that service's verdict. Only the caller's own settings can be written. Portal-wide configuration is not touched by this operation.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetUserRequest">The user's AI settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/user` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-user/">REST API Reference for AiSettingsSetUser Operation</seealso>
        /// <returns>Task of ApiResponse (AiUserSettingsWrapper)</returns>
        public async Task<ApiResponse<AiUserSettingsWrapper>> AiSettingsSetUserWithHttpInfoAsync(Dictionary<string, Object> aiSettingsSetUserRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSettingsSetUserRequest' is set
            if (aiSettingsSetUserRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSettingsSetUserRequest' when calling SettingsApi->AiSettingsSetUser");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSettingsSetUserRequest != null) localVarRequestOptions.Data = aiSettingsSetUserRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiUserSettingsWrapper>("/api/2.0/ai/config/user", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetUser", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>AiVectorizationSettingsWrapper</returns>
        public AiVectorizationSettingsWrapper AiSettingsSetVectorization(Dictionary<string, Object> aiSettingsSetVectorizationRequest)
        {
            var localVarResponse = AiSettingsSetVectorizationWithHttpInfo(aiSettingsSetVectorizationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>ApiResponse of AiVectorizationSettingsWrapper</returns>
        public ApiResponse<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationWithHttpInfo(Dictionary<string, Object> aiSettingsSetVectorizationRequest)
        {
            // verify the required parameter 'aiSettingsSetVectorizationRequest' is set
            if (aiSettingsSetVectorizationRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSettingsSetVectorizationRequest' when calling SettingsApi->AiSettingsSetVectorization");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSettingsSetVectorizationRequest != null) localVarRequestOptions.Data = aiSettingsSetVectorizationRequest;

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
            var localVarResponse = Client.Put<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetVectorization", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of AiVectorizationSettingsWrapper</returns>
        public async Task<AiVectorizationSettingsWrapper> AiSettingsSetVectorizationAsync(Dictionary<string, Object> aiSettingsSetVectorizationRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiSettingsSetVectorizationWithHttpInfoAsync(aiSettingsSetVectorizationRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update vectorization settings
        /// </summary>
        /// <remarks>
        /// Replaces the portal's vectorization settings and returns the stored result. The body is proxied unchanged to the DocSpace AI service, which validates it, so a rejected value is reported with that service's own verdict rather than being checked here. Changing the embedding provider does not re-index anything already indexed - start that separately with `POST api/2.0/ai/vectorization/tasks`. This is a portal-wide setting and requires the permissions the AI service demands for it.
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiSettingsSetVectorizationRequest">The portal's vectorization settings, proxied unchanged to the DocSpace AI service, which owns and validates the shape. Read the current one with `GET api/2.0/ai/config/vectorization` and send it back changed.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-settings-set-vectorization/">REST API Reference for AiSettingsSetVectorization Operation</seealso>
        /// <returns>Task of ApiResponse (AiVectorizationSettingsWrapper)</returns>
        public async Task<ApiResponse<AiVectorizationSettingsWrapper>> AiSettingsSetVectorizationWithHttpInfoAsync(Dictionary<string, Object> aiSettingsSetVectorizationRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiSettingsSetVectorizationRequest' is set
            if (aiSettingsSetVectorizationRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiSettingsSetVectorizationRequest' when calling SettingsApi->AiSettingsSetVectorization");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiSettingsSetVectorizationRequest != null) localVarRequestOptions.Data = aiSettingsSetVectorizationRequest;

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

            var localVarResponse = await AsynchronousClient.PutAsync<AiVectorizationSettingsWrapper>("/api/2.0/ai/config/vectorization", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiSettingsSetVectorization", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
