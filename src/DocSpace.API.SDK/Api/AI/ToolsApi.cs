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
    public interface IToolsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>AiToolsMutationResult</returns>
        AiToolsMutationResult AiToolsAddCustomServer(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest);

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>ApiResponse of AiToolsMutationResult</returns>
        ApiResponse<AiToolsMutationResult> AiToolsAddCustomServerWithHttpInfo(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest);
        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>List&lt;string&gt;</returns>
        List<string> AiToolsGetAllowAlways(string entityId);

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> AiToolsGetAllowAlwaysWithHttpInfo(string entityId);
        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>Object</returns>
        Object AiToolsGetCustomServer(string name, string entityId);

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AiToolsGetCustomServerWithHttpInfo(string name, string entityId);
        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        Dictionary<string, List<string>> AiToolsGetDisabled(string entityId);

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<string>>> AiToolsGetDisabledWithHttpInfo(string entityId);
        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>bool</returns>
        bool AiToolsIsAllowAlways(string serverType, string toolName, string entityId);

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> AiToolsIsAllowAlwaysWithHttpInfo(string serverType, string toolName, string entityId);
        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>bool</returns>
        bool AiToolsIsToolDisabled(string serverType, string toolName, string entityId);

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        ApiResponse<bool> AiToolsIsToolDisabledWithHttpInfo(string serverType, string toolName, string entityId);
        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        Dictionary<string, Object> AiToolsListCustomServers(string entityId);

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        ApiResponse<Dictionary<string, Object>> AiToolsListCustomServersWithHttpInfo(string entityId);
        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;</returns>
        Dictionary<string, List<AiTMCPItem>> AiToolsListSystemTools(string entityId);

        /// <summary>
        /// List system tools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;</returns>
        ApiResponse<Dictionary<string, List<AiTMCPItem>>> AiToolsListSystemToolsWithHttpInfo(string entityId);
        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiToolsRemoveCustomServer(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest);

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiToolsRemoveCustomServerWithHttpInfo(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest);
        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>AiToolsBulkResult</returns>
        AiToolsBulkResult AiToolsReplaceAllCustomServers(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest);

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>ApiResponse of AiToolsBulkResult</returns>
        ApiResponse<AiToolsBulkResult> AiToolsReplaceAllCustomServersWithHttpInfo(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest);
        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiToolsSetAllowAlways(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest);

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiToolsSetAllowAlwaysWithHttpInfo(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest);
        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        AiSuccessResponse AiToolsSetDisabled(AiToolsSetDisabledRequest aiToolsSetDisabledRequest);

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        ApiResponse<AiSuccessResponse> AiToolsSetDisabledWithHttpInfo(AiToolsSetDisabledRequest aiToolsSetDisabledRequest);
        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>AiToolsMutationResult</returns>
        AiToolsMutationResult AiToolsUpdateCustomServer(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest);

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>ApiResponse of AiToolsMutationResult</returns>
        ApiResponse<AiToolsMutationResult> AiToolsUpdateCustomServerWithHttpInfo(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IToolsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of AiToolsMutationResult</returns>
        Task<AiToolsMutationResult> AiToolsAddCustomServerAsync(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (AiToolsMutationResult)</returns>
        Task<ApiResponse<AiToolsMutationResult>> AiToolsAddCustomServerWithHttpInfoAsync(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of List&lt;string&gt;</returns>
        Task<List<string>> AiToolsGetAllowAlwaysAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        Task<ApiResponse<List<string>>> AiToolsGetAllowAlwaysWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of Object</returns>
        Task<Object> AiToolsGetCustomServerAsync(string name, string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<Object>> AiToolsGetCustomServerWithHttpInfoAsync(string name, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        Task<Dictionary<string, List<string>>> AiToolsGetDisabledAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;string&gt;&gt;)</returns>
        Task<ApiResponse<Dictionary<string, List<string>>>> AiToolsGetDisabledWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Is allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> AiToolsIsAllowAlwaysAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> AiToolsIsAllowAlwaysWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of bool</returns>
        Task<bool> AiToolsIsToolDisabledAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        Task<ApiResponse<bool>> AiToolsIsToolDisabledWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        Task<Dictionary<string, Object>> AiToolsListCustomServersAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        Task<ApiResponse<Dictionary<string, Object>>> AiToolsListCustomServersWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// List system tools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;</returns>
        Task<Dictionary<string, List<AiTMCPItem>>> AiToolsListSystemToolsAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// List system tools
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;)</returns>
        Task<ApiResponse<Dictionary<string, List<AiTMCPItem>>>> AiToolsListSystemToolsWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiToolsRemoveCustomServerAsync(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiToolsRemoveCustomServerWithHttpInfoAsync(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of AiToolsBulkResult</returns>
        Task<AiToolsBulkResult> AiToolsReplaceAllCustomServersAsync(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (AiToolsBulkResult)</returns>
        Task<ApiResponse<AiToolsBulkResult>> AiToolsReplaceAllCustomServersWithHttpInfoAsync(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiToolsSetAllowAlwaysAsync(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiToolsSetAllowAlwaysWithHttpInfoAsync(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Set disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        Task<AiSuccessResponse> AiToolsSetDisabledAsync(AiToolsSetDisabledRequest aiToolsSetDisabledRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        Task<ApiResponse<AiSuccessResponse>> AiToolsSetDisabledWithHttpInfoAsync(AiToolsSetDisabledRequest aiToolsSetDisabledRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of AiToolsMutationResult</returns>
        Task<AiToolsMutationResult> AiToolsUpdateCustomServerAsync(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (AiToolsMutationResult)</returns>
        Task<ApiResponse<AiToolsMutationResult>> AiToolsUpdateCustomServerWithHttpInfoAsync(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IToolsApi : IToolsApiSync, IToolsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ToolsApi : IDisposable, IToolsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ToolsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ToolsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ToolsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ToolsApi(Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ToolsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ToolsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsApi"/> class.
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
        public ToolsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ToolsApi"/> class using a Configuration object.
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
        public ToolsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
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
        /// Initializes a new instance of the <see cref="ToolsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ToolsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>AiToolsMutationResult</returns>
        public AiToolsMutationResult AiToolsAddCustomServer(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest)
        {
            var localVarResponse = AiToolsAddCustomServerWithHttpInfo(aiToolsAddCustomServerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>ApiResponse of AiToolsMutationResult</returns>
        public ApiResponse<AiToolsMutationResult> AiToolsAddCustomServerWithHttpInfo(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest)
        {
            // verify the required parameter 'aiToolsAddCustomServerRequest' is set
            if (aiToolsAddCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsAddCustomServerRequest' when calling ToolsApi->AiToolsAddCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsAddCustomServerRequest != null) localVarRequestOptions.Data = aiToolsAddCustomServerRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<AiToolsMutationResult>("/api/2.0/ai/tools/add-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsAddCustomServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of AiToolsMutationResult</returns>
        public async Task<AiToolsMutationResult> AiToolsAddCustomServerAsync(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsAddCustomServerWithHttpInfoAsync(aiToolsAddCustomServerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsAddCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-add-custom-server/">REST API Reference for AiToolsAddCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (AiToolsMutationResult)</returns>
        public async Task<ApiResponse<AiToolsMutationResult>> AiToolsAddCustomServerWithHttpInfoAsync(AiToolsAddCustomServerRequest aiToolsAddCustomServerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolsAddCustomServerRequest' is set
            if (aiToolsAddCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsAddCustomServerRequest' when calling ToolsApi->AiToolsAddCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsAddCustomServerRequest != null) localVarRequestOptions.Data = aiToolsAddCustomServerRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<AiToolsMutationResult>("/api/2.0/ai/tools/add-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsAddCustomServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> AiToolsGetAllowAlways(string entityId)
        {
            var localVarResponse = AiToolsGetAllowAlwaysWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public ApiResponse<List<string>> AiToolsGetAllowAlwaysWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsGetAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<List<string>>("/api/2.0/ai/tools/get-allow-always", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsGetAllowAlways", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async Task<List<string>> AiToolsGetAllowAlwaysAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsGetAllowAlwaysWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-allow-always/">REST API Reference for AiToolsGetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async Task<ApiResponse<List<string>>> AiToolsGetAllowAlwaysWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsGetAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<List<string>>("/api/2.0/ai/tools/get-allow-always", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsGetAllowAlways", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>Object</returns>
        public Object AiToolsGetCustomServer(string name, string entityId)
        {
            var localVarResponse = AiToolsGetCustomServerWithHttpInfo(name, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse<Object> AiToolsGetCustomServerWithHttpInfo(string name, string entityId)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ToolsApi->AiToolsGetCustomServer");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsGetCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<Object>("/api/2.0/ai/tools/get-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsGetCustomServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of Object</returns>
        public async Task<Object> AiToolsGetCustomServerAsync(string name, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsGetCustomServerWithHttpInfoAsync(name, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-custom-server/">REST API Reference for AiToolsGetCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async Task<ApiResponse<Object>> AiToolsGetCustomServerWithHttpInfoAsync(string name, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling ToolsApi->AiToolsGetCustomServer");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsGetCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "name", name));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Object>("/api/2.0/ai/tools/get-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsGetCustomServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public Dictionary<string, List<string>> AiToolsGetDisabled(string entityId)
        {
            var localVarResponse = AiToolsGetDisabledWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, List<string>>> AiToolsGetDisabledWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsGetDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<Dictionary<string, List<string>>>("/api/2.0/ai/tools/get-disabled", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsGetDisabled", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;string&gt;&gt;</returns>
        public async Task<Dictionary<string, List<string>>> AiToolsGetDisabledAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsGetDisabledWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-get-disabled/">REST API Reference for AiToolsGetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;string&gt;&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, List<string>>>> AiToolsGetDisabledWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsGetDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Dictionary<string, List<string>>>("/api/2.0/ai/tools/get-disabled", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsGetDisabled", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>bool</returns>
        public bool AiToolsIsAllowAlways(string serverType, string toolName, string entityId)
        {
            var localVarResponse = AiToolsIsAllowAlwaysWithHttpInfo(serverType, toolName, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> AiToolsIsAllowAlwaysWithHttpInfo(string serverType, string toolName, string entityId)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->AiToolsIsAllowAlways");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->AiToolsIsAllowAlways");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsIsAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "serverType", serverType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toolName", toolName));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<bool>("/api/2.0/ai/tools/is-allow-always", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsIsAllowAlways", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> AiToolsIsAllowAlwaysAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsIsAllowAlwaysWithHttpInfoAsync(serverType, toolName, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-allow-always/">REST API Reference for AiToolsIsAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> AiToolsIsAllowAlwaysWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->AiToolsIsAllowAlways");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->AiToolsIsAllowAlways");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsIsAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "serverType", serverType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toolName", toolName));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<bool>("/api/2.0/ai/tools/is-allow-always", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsIsAllowAlways", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>bool</returns>
        public bool AiToolsIsToolDisabled(string serverType, string toolName, string entityId)
        {
            var localVarResponse = AiToolsIsToolDisabledWithHttpInfo(serverType, toolName, entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>ApiResponse of bool</returns>
        public ApiResponse<bool> AiToolsIsToolDisabledWithHttpInfo(string serverType, string toolName, string entityId)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->AiToolsIsToolDisabled");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->AiToolsIsToolDisabled");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsIsToolDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "serverType", serverType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toolName", toolName));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<bool>("/api/2.0/ai/tools/is-tool-disabled", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsIsToolDisabled", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of bool</returns>
        public async Task<bool> AiToolsIsToolDisabledAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsIsToolDisabledWithHttpInfoAsync(serverType, toolName, entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Is tool disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverType"></param>
        /// <param name="toolName"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-is-tool-disabled/">REST API Reference for AiToolsIsToolDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (bool)</returns>
        public async Task<ApiResponse<bool>> AiToolsIsToolDisabledWithHttpInfoAsync(string serverType, string toolName, string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'serverType' is set
            if (serverType == null)
                throw new ApiException(400, "Missing required parameter 'serverType' when calling ToolsApi->AiToolsIsToolDisabled");

            // verify the required parameter 'toolName' is set
            if (toolName == null)
                throw new ApiException(400, "Missing required parameter 'toolName' when calling ToolsApi->AiToolsIsToolDisabled");

            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsIsToolDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "serverType", serverType));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toolName", toolName));
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<bool>("/api/2.0/ai/tools/is-tool-disabled", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsIsToolDisabled", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>Dictionary&lt;string, Object&gt;</returns>
        public Dictionary<string, Object> AiToolsListCustomServers(string entityId)
        {
            var localVarResponse = AiToolsListCustomServersWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, Object&gt;</returns>
        public ApiResponse<Dictionary<string, Object>> AiToolsListCustomServersWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsListCustomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<Dictionary<string, Object>>("/api/2.0/ai/tools/list-custom-servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsListCustomServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, Object&gt;</returns>
        public async Task<Dictionary<string, Object>> AiToolsListCustomServersAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsListCustomServersWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-custom-servers/">REST API Reference for AiToolsListCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, Object&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, Object>>> AiToolsListCustomServersWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsListCustomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Dictionary<string, Object>>("/api/2.0/ai/tools/list-custom-servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsListCustomServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;</returns>
        public Dictionary<string, List<AiTMCPItem>> AiToolsListSystemTools(string entityId)
        {
            var localVarResponse = AiToolsListSystemToolsWithHttpInfo(entityId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>ApiResponse of Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;</returns>
        public ApiResponse<Dictionary<string, List<AiTMCPItem>>> AiToolsListSystemToolsWithHttpInfo(string entityId)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsListSystemTools");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request
            var localVarResponse = Client.Get<Dictionary<string, List<AiTMCPItem>>>("/api/2.0/ai/tools/list-system-tools", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsListSystemTools", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>Task of Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;</returns>
        public async Task<Dictionary<string, List<AiTMCPItem>>> AiToolsListSystemToolsAsync(string entityId, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsListSystemToolsWithHttpInfoAsync(entityId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List system tools
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-list-system-tools/">REST API Reference for AiToolsListSystemTools Operation</seealso>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;)</returns>
        public async Task<ApiResponse<Dictionary<string, List<AiTMCPItem>>>> AiToolsListSystemToolsWithHttpInfoAsync(string entityId, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'entityId' is set
            if (entityId == null)
                throw new ApiException(400, "Missing required parameter 'entityId' when calling ToolsApi->AiToolsListSystemTools");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "entityId", entityId));


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<Dictionary<string, List<AiTMCPItem>>>("/api/2.0/ai/tools/list-system-tools", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsListSystemTools", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiToolsRemoveCustomServer(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest)
        {
            var localVarResponse = AiToolsRemoveCustomServerWithHttpInfo(aiToolsRemoveCustomServerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiToolsRemoveCustomServerWithHttpInfo(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest)
        {
            // verify the required parameter 'aiToolsRemoveCustomServerRequest' is set
            if (aiToolsRemoveCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsRemoveCustomServerRequest' when calling ToolsApi->AiToolsRemoveCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsRemoveCustomServerRequest != null) localVarRequestOptions.Data = aiToolsRemoveCustomServerRequest;


            // make the HTTP request
            var localVarResponse = Client.Delete<AiSuccessResponse>("/api/2.0/ai/tools/remove-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsRemoveCustomServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiToolsRemoveCustomServerAsync(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsRemoveCustomServerWithHttpInfoAsync(aiToolsRemoveCustomServerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsRemoveCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-remove-custom-server/">REST API Reference for AiToolsRemoveCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiToolsRemoveCustomServerWithHttpInfoAsync(AiToolsRemoveCustomServerRequest aiToolsRemoveCustomServerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolsRemoveCustomServerRequest' is set
            if (aiToolsRemoveCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsRemoveCustomServerRequest' when calling ToolsApi->AiToolsRemoveCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsRemoveCustomServerRequest != null) localVarRequestOptions.Data = aiToolsRemoveCustomServerRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<AiSuccessResponse>("/api/2.0/ai/tools/remove-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsRemoveCustomServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>AiToolsBulkResult</returns>
        public AiToolsBulkResult AiToolsReplaceAllCustomServers(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest)
        {
            var localVarResponse = AiToolsReplaceAllCustomServersWithHttpInfo(aiToolsReplaceAllCustomServersRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>ApiResponse of AiToolsBulkResult</returns>
        public ApiResponse<AiToolsBulkResult> AiToolsReplaceAllCustomServersWithHttpInfo(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest)
        {
            // verify the required parameter 'aiToolsReplaceAllCustomServersRequest' is set
            if (aiToolsReplaceAllCustomServersRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsReplaceAllCustomServersRequest' when calling ToolsApi->AiToolsReplaceAllCustomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsReplaceAllCustomServersRequest != null) localVarRequestOptions.Data = aiToolsReplaceAllCustomServersRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiToolsBulkResult>("/api/2.0/ai/tools/replace-all-custom-servers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsReplaceAllCustomServers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of AiToolsBulkResult</returns>
        public async Task<AiToolsBulkResult> AiToolsReplaceAllCustomServersAsync(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsReplaceAllCustomServersWithHttpInfoAsync(aiToolsReplaceAllCustomServersRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Replace all custom servers
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsReplaceAllCustomServersRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-replace-all-custom-servers/">REST API Reference for AiToolsReplaceAllCustomServers Operation</seealso>
        /// <returns>Task of ApiResponse (AiToolsBulkResult)</returns>
        public async Task<ApiResponse<AiToolsBulkResult>> AiToolsReplaceAllCustomServersWithHttpInfoAsync(AiToolsReplaceAllCustomServersRequest aiToolsReplaceAllCustomServersRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolsReplaceAllCustomServersRequest' is set
            if (aiToolsReplaceAllCustomServersRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsReplaceAllCustomServersRequest' when calling ToolsApi->AiToolsReplaceAllCustomServers");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsReplaceAllCustomServersRequest != null) localVarRequestOptions.Data = aiToolsReplaceAllCustomServersRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiToolsBulkResult>("/api/2.0/ai/tools/replace-all-custom-servers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsReplaceAllCustomServers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiToolsSetAllowAlways(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest)
        {
            var localVarResponse = AiToolsSetAllowAlwaysWithHttpInfo(aiToolsSetAllowAlwaysRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiToolsSetAllowAlwaysWithHttpInfo(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest)
        {
            // verify the required parameter 'aiToolsSetAllowAlwaysRequest' is set
            if (aiToolsSetAllowAlwaysRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsSetAllowAlwaysRequest' when calling ToolsApi->AiToolsSetAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsSetAllowAlwaysRequest != null) localVarRequestOptions.Data = aiToolsSetAllowAlwaysRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/tools/set-allow-always", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsSetAllowAlways", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiToolsSetAllowAlwaysAsync(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsSetAllowAlwaysWithHttpInfoAsync(aiToolsSetAllowAlwaysRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set allow always
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetAllowAlwaysRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-allow-always/">REST API Reference for AiToolsSetAllowAlways Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiToolsSetAllowAlwaysWithHttpInfoAsync(AiToolsSetAllowAlwaysRequest aiToolsSetAllowAlwaysRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolsSetAllowAlwaysRequest' is set
            if (aiToolsSetAllowAlwaysRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsSetAllowAlwaysRequest' when calling ToolsApi->AiToolsSetAllowAlways");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsSetAllowAlwaysRequest != null) localVarRequestOptions.Data = aiToolsSetAllowAlwaysRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/tools/set-allow-always", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsSetAllowAlways", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>AiSuccessResponse</returns>
        public AiSuccessResponse AiToolsSetDisabled(AiToolsSetDisabledRequest aiToolsSetDisabledRequest)
        {
            var localVarResponse = AiToolsSetDisabledWithHttpInfo(aiToolsSetDisabledRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>ApiResponse of AiSuccessResponse</returns>
        public ApiResponse<AiSuccessResponse> AiToolsSetDisabledWithHttpInfo(AiToolsSetDisabledRequest aiToolsSetDisabledRequest)
        {
            // verify the required parameter 'aiToolsSetDisabledRequest' is set
            if (aiToolsSetDisabledRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsSetDisabledRequest' when calling ToolsApi->AiToolsSetDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsSetDisabledRequest != null) localVarRequestOptions.Data = aiToolsSetDisabledRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiSuccessResponse>("/api/2.0/ai/tools/set-disabled", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsSetDisabled", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>Task of AiSuccessResponse</returns>
        public async Task<AiSuccessResponse> AiToolsSetDisabledAsync(AiToolsSetDisabledRequest aiToolsSetDisabledRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsSetDisabledWithHttpInfoAsync(aiToolsSetDisabledRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set disabled
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsSetDisabledRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-set-disabled/">REST API Reference for AiToolsSetDisabled Operation</seealso>
        /// <returns>Task of ApiResponse (AiSuccessResponse)</returns>
        public async Task<ApiResponse<AiSuccessResponse>> AiToolsSetDisabledWithHttpInfoAsync(AiToolsSetDisabledRequest aiToolsSetDisabledRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolsSetDisabledRequest' is set
            if (aiToolsSetDisabledRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsSetDisabledRequest' when calling ToolsApi->AiToolsSetDisabled");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsSetDisabledRequest != null) localVarRequestOptions.Data = aiToolsSetDisabledRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiSuccessResponse>("/api/2.0/ai/tools/set-disabled", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsSetDisabled", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>AiToolsMutationResult</returns>
        public AiToolsMutationResult AiToolsUpdateCustomServer(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest)
        {
            var localVarResponse = AiToolsUpdateCustomServerWithHttpInfo(aiToolsUpdateCustomServerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>ApiResponse of AiToolsMutationResult</returns>
        public ApiResponse<AiToolsMutationResult> AiToolsUpdateCustomServerWithHttpInfo(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest)
        {
            // verify the required parameter 'aiToolsUpdateCustomServerRequest' is set
            if (aiToolsUpdateCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsUpdateCustomServerRequest' when calling ToolsApi->AiToolsUpdateCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsUpdateCustomServerRequest != null) localVarRequestOptions.Data = aiToolsUpdateCustomServerRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<AiToolsMutationResult>("/api/2.0/ai/tools/update-custom-server", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsUpdateCustomServer", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of AiToolsMutationResult</returns>
        public async Task<AiToolsMutationResult> AiToolsUpdateCustomServerAsync(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AiToolsUpdateCustomServerWithHttpInfoAsync(aiToolsUpdateCustomServerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update custom server
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aiToolsUpdateCustomServerRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/ai-tools-update-custom-server/">REST API Reference for AiToolsUpdateCustomServer Operation</seealso>
        /// <returns>Task of ApiResponse (AiToolsMutationResult)</returns>
        public async Task<ApiResponse<AiToolsMutationResult>> AiToolsUpdateCustomServerWithHttpInfoAsync(AiToolsUpdateCustomServerRequest aiToolsUpdateCustomServerRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'aiToolsUpdateCustomServerRequest' is set
            if (aiToolsUpdateCustomServerRequest == null)
                throw new ApiException(400, "Missing required parameter 'aiToolsUpdateCustomServerRequest' when calling ToolsApi->AiToolsUpdateCustomServer");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (aiToolsUpdateCustomServerRequest != null) localVarRequestOptions.Data = aiToolsUpdateCustomServerRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<AiToolsMutationResult>("/api/2.0/ai/tools/update-custom-server", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AiToolsUpdateCustomServer", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
